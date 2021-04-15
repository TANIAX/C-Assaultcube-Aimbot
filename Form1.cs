using ProcessMemoryReaderLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Aimbot_cSharp
{
    public partial class CustomAimbot : Form
    {
        private Process[] MyProcess;
        private ProcessModule mainModule;
        private ProcessMemoryReader Mem = new ProcessMemoryReader();
        private PlayerData MainPlayer = new PlayerData();

        private PlayerDataAddr MainPlayerOffsets = new PlayerDataAddr();
        private List<PlayerData> EnemyAddresses = new List<PlayerData>();

        private float PI = 3.14159265F; // ALTHOUGH WE CAN ALWAYS use Math.PI, I prefer to use our own as a float

        private bool GameFound = false;
        private bool FocusingOnEnemy = false;
        private int FocusTarget = -1;

        #region TESTING MOUSE X AND MOUSE Y(THIS CAN BE IGNORED)

        private void upBTN_Click(object sender, EventArgs e)
        {
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch, Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch) + 10.0f);
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw, Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw) + 10.0f);
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw, Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw) - 10.0f);
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch, Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch) - 10.0f);
        }

        #endregion TESTING MOUSE X AND MOUSE Y(THIS CAN BE IGNORED)

        public CustomAimbot()
        {
            InitializeComponent();
        }

        private void gameChoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < MyProcess.Length; i++)
                {
                    if (gameChoiceCB.SelectedItem.ToString().Contains(MyProcess[i].ProcessName))
                    {
                        MyProcess[0] = Process.GetProcessById(int.Parse(gameChoiceCB.Text.Replace(MyProcess[i].ProcessName + "-", "")));
                        mainModule = MyProcess[0].MainModule;
                        Mem.ReadProcess = MyProcess[0];
                        Mem.OpenProcess();
                        GameFound = true;

                        //create our player with the corresponding memory addresses
                        MainPlayer.baseAddress = Mem.ReadInt(0x50f4f4);
                        //GETS US TO THE BEGINNING OF OUR STRUCT
                        MainPlayer.offsets = new PlayerDataAddr();
                        SetupEnemyVars();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to process " + ex.Message, "Error");
            }
        }

        private void gameChoiceCB_MouseClick(object sender, MouseEventArgs e)
        {
            gameChoiceCB.Items.Clear();
            MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
            {
                gameChoiceCB.Items.Add(MyProcess[i].ProcessName + "-" + MyProcess[i].Id);
            }
        }

        private void CustomAimbot_Load(object sender, EventArgs e)
        {
            ProcessTMR.Enabled = true;
        }

        private void ProcessTMR_Tick(object sender, EventArgs e)
        {
            if (GameFound)
            {
                mouseXValueLBL.Text = Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw).ToString();
                mouseYValueLBL.Text = Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch).ToString();
                //DISPLAY OUR XYZ MAIN PLAYER'S POS
                xPosValueLBL.Text = Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.xPos).ToString();
                yPosValueLBL.Text = Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.yPos).ToString();
                zPosValueLBL.Text = Mem.ReadFloat(MainPlayer.baseAddress + MainPlayer.offsets.zPos).ToString();

                //SHOW OUR ENEMY VARIABLES

                HealthMineLBL.Text = Mem.ReadInt(MainPlayer.baseAddress + MainPlayer.offsets.health).ToString();

                EnHealthValueLBL.Text = Mem.ReadInt(EnemyAddresses[2].baseAddress + MainPlayer.offsets.health).ToString();
                xPosEnValueLBL.Text = Mem.ReadFloat(EnemyAddresses[2].baseAddress + MainPlayer.offsets.xPos).ToString();
                yPosEnValueLBL.Text = Mem.ReadFloat(EnemyAddresses[2].baseAddress + MainPlayer.offsets.yPos).ToString();
                zPosEnValueLBL.Text = Mem.ReadFloat(EnemyAddresses[2].baseAddress + MainPlayer.offsets.zPos).ToString();

                //RIGHT MOUSE
                int res = ProcessMemoryReaderApi.GetKeyState(02);
                if ((res & 0x8000) != 0)
                {
                    //if enemy is holding AIMBOT btn or key we focus on that person until they are dead
                    FocusingOnEnemy = true;
                    AimBot();
                }
                else
                {
                    //otherwise we stop staring at them and change targets
                    FocusingOnEnemy = false;
                    FocusTarget = -1;
                }
            }

            try
            {
                if (MyProcess != null)
                {
                    if (MyProcess[0].HasExited)
                    {
                        GameFound = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error " + ex.Message);
            }
        }

        private void AimBot()
        {
            //Grab our player's information
            PlayerDataVec playerDataVec = GetPlayerVecData(MainPlayer);
            //this will store every enemy that we have information
            List<PlayerDataVec> enemiesDataVec = new List<PlayerDataVec>();

            for (int i = 0; i < EnemyAddresses.Count; i++)
            {
                //Using our pointer we grab all the enemies information
                PlayerDataVec enemyDataVector = GetPlayerVecData(EnemyAddresses[i]);
                //add our enemy information to the list if hes alive otherwise ignore them
                enemiesDataVec.Add(enemyDataVector);
            }

            //only aim if we are ALIVE
            if (playerDataVec.health > 0)
            {
                int target = 0;
                if (FocusingOnEnemy && FocusTarget != -1)
                {
                    //If our previous target is still alive we focus on them otherwise go after someone else
                    if (enemiesDataVec[FocusTarget].health > 0)
                        target = FocusTarget;
                    else target = FindClosestEnemyIndex(enemiesDataVec.ToArray(), playerDataVec);
                }
                else//By default aim at the first guy that appears, with this we focus on whos closest to us
                    target = FindClosestEnemyIndex(enemiesDataVec.ToArray(), playerDataVec);

                //if there are more enemies we find the closest one to us then aim
                if (target != -1) //-1 means something went wrong
                {
                    FocusTarget = target;
                    //this condition is only here in case all enemies are dead to aim at NO one
                    //previously if all were dead it would aim at the last guy killed
                    if (enemiesDataVec[target].health > 0)
                        AimAtTarget(enemiesDataVec[target], playerDataVec);
                }
            }
        }

        //With this we see which enemy is closest to OUR player, we return their index that way we aim directly

        private int FindClosestEnemyIndex(PlayerDataVec[] enemiesDataVec, PlayerDataVec myPosition)
        {
            float[] distances = new float[enemiesDataVec.Length];

            //store all our distances between us and the enemies to see which is closest
            for (int i = 0; i < enemiesDataVec.Length; i++)
            {
                //only store their distance if they are ALIVE
                if (enemiesDataVec[i].health > 0)
                    distances[i] = Get3dDistance(enemiesDataVec[i], myPosition);
                else
                    // sets these as very high floats
                    distances[i] = float.MaxValue;
            }
            //Make a copy of our array so we dont lose track of which position our closest enemy is
            float[] newDistances = new float[distances.Length];
            Array.Copy(distances, newDistances, distances.Length);

            //sorts our array from LOWEST TO HIGHEST
            Array.Sort(newDistances);

            //See which enemy was closest and return that Index for us to aim at them
            for (int i = 0; i < distances.Length; i++)
            {
                if (distances[i] == newDistances[0])
                {
                    return i;
                }
            }
            return -1;
        }

        private float Get3dDistance(PlayerDataVec to, PlayerDataVec from)
        {
            return (float)
            (Math.Sqrt(
            ((to.xPos - from.xPos) * (to.xPos - from.xPos)) +
            ((to.yPos - from.yPos) * (to.yPos - from.yPos)) +
            ((to.zPos - from.zPos) * (to.zPos - from.zPos))
            ));
        }

        private void AimAtTarget(PlayerDataVec enemyDataVector, PlayerDataVec playerDataVector)
        {
            float yaw = -(float)Math.Atan2(enemyDataVector.xPos - playerDataVector.xPos, enemyDataVector.yPos - playerDataVector.yPos)
                            / PI * 180 + 180;

            float pitch = (float)Math.Asin((enemyDataVector.zPos - playerDataVector.zPos) /
                            Get3dDistance(enemyDataVector, playerDataVector))
                         * 180 / PI;

            //Set our  mouse values with our new YAW and PITCH
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.yaw, yaw);
            Mem.WriteFloat(MainPlayer.baseAddress + MainPlayer.offsets.pitch, pitch);
        }

        //get all the data and store it
        private PlayerDataVec GetPlayerVecData(PlayerData updatePlayer)
        {
            PlayerDataVec playerRet = new PlayerDataVec();

            playerRet.yaw = Mem.ReadFloat(updatePlayer.baseAddress + updatePlayer.offsets.yaw);
            playerRet.pitch = Mem.ReadFloat(updatePlayer.baseAddress + updatePlayer.offsets.pitch);

            playerRet.xPos = Mem.ReadFloat(updatePlayer.baseAddress + updatePlayer.offsets.xPos);
            playerRet.yPos = Mem.ReadFloat(updatePlayer.baseAddress + updatePlayer.offsets.yPos);
            playerRet.zPos = Mem.ReadFloat(updatePlayer.baseAddress + updatePlayer.offsets.zPos);

            playerRet.health = Mem.ReadInt(updatePlayer.baseAddress + updatePlayer.offsets.health);
            return playerRet;
        }

        //DECLARE ALL our variables regarding enemies, we later use this information to go through enemies and aim at them
        private void SetupEnemyVars()
        {
            PlayerData En1 = new PlayerData();
            //SETUP ENEMY VARIABLES
            En1.baseAddress = Mem.ReadInt(Mem.ReadInt(0x50f4f8) + 0x4);
            En1.offsets = MainPlayer.offsets;
            EnemyAddresses.Add(En1);

            PlayerData En2 = new PlayerData();
            En2.baseAddress = Mem.ReadInt(Mem.ReadInt(0x50f4f8) + 0x8);
            En2.offsets = MainPlayer.offsets;
            EnemyAddresses.Add(En2);

            PlayerData En3 = new PlayerData();
            En3.baseAddress = Mem.ReadInt(Mem.ReadInt(0x50f4f8) + 0xc);
            En3.offsets = MainPlayer.offsets;
            EnemyAddresses.Add(En3);
        }
    }
}