namespace Aimbot_cSharp
{
    //HERE WE DEFINE A SERIES OF CLASSES AND STRUCTS THAT HELP us
    //Offsets is stored within the PlayerData struct, we store a series of pointers to the player information

    public class PlayerDataAddr
    {
        public int yaw = 0x40;
        public int pitch = 0x44;
        public int xPos = 0x4;
        public int yPos = 0x8;
        public int zPos = 0xc;
        public int health = 0xf8;

        public PlayerDataAddr()
        {
        }

    }

    //Stores pointers to our player, NO actual information is stored here e.g. Health:100 instead we get
    public struct PlayerData
    {
        public int baseAddress;

        //ALL THESE BELOW ARE pointers to our player's information
        public PlayerDataAddr offsets;
    }

    //Here we store the actual contents of the memory addresses usually within "PlayerData" we
    public struct PlayerDataVec
    {
        public float yaw;
        public float pitch;
        public float xPos;
        public float yPos;
        public float zPos;
        public int health;
    }
}