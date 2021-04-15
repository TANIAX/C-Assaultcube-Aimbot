namespace Aimbot_cSharp
{
    partial class CustomAimbot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAimbot));
            this.rightBTN = new System.Windows.Forms.Button();
            this.leftBTN = new System.Windows.Forms.Button();
            this.upBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.gameChoiceCB = new System.Windows.Forms.ComboBox();
            this.mouseXAddressLBL = new System.Windows.Forms.Label();
            this.mouseYAddressLBL = new System.Windows.Forms.Label();
            this.mouseYValueLBL = new System.Windows.Forms.Label();
            this.mouseXValueLBL = new System.Windows.Forms.Label();
            this.ProcessTMR = new System.Windows.Forms.Timer(this.components);
            this.xPosValueLBL = new System.Windows.Forms.Label();
            this.posXLBL = new System.Windows.Forms.Label();
            this.posZLBL = new System.Windows.Forms.Label();
            this.posYLBL = new System.Windows.Forms.Label();
            this.yPosValueLBL = new System.Windows.Forms.Label();
            this.zPosValueLBL = new System.Windows.Forms.Label();
            this.enemyHealthLBL = new System.Windows.Forms.Label();
            this.EnHealthValueLBL = new System.Windows.Forms.Label();
            this.HealthMineLBL = new System.Windows.Forms.Label();
            this.healthLBL = new System.Windows.Forms.Label();
            this.myDetailsLBL = new System.Windows.Forms.Label();
            this.enDetailsLBL = new System.Windows.Forms.Label();
            this.selectProcessLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xPosENLBL = new System.Windows.Forms.Label();
            this.xPosEnValueLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yPosEnValueLBL = new System.Windows.Forms.Label();
            this.zPosEnValueLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rightBTN.Location = new System.Drawing.Point(390, 500);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(66, 44);
            this.rightBTN.TabIndex = 0;
            this.rightBTN.Text = "Right";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.leftBTN.Location = new System.Drawing.Point(261, 502);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(66, 42);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "Left";
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // upBTN
            // 
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.upBTN.Location = new System.Drawing.Point(325, 460);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(66, 42);
            this.upBTN.TabIndex = 2;
            this.upBTN.Text = "Up";
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.downBTN.Location = new System.Drawing.Point(326, 544);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(66, 41);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "Down";
            this.downBTN.UseVisualStyleBackColor = true;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // gameChoiceCB
            // 
            this.gameChoiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameChoiceCB.FormattingEnabled = true;
            this.gameChoiceCB.Location = new System.Drawing.Point(48, 105);
            this.gameChoiceCB.Name = "gameChoiceCB";
            this.gameChoiceCB.Size = new System.Drawing.Size(160, 21);
            this.gameChoiceCB.Sorted = true;
            this.gameChoiceCB.TabIndex = 57;
            this.gameChoiceCB.SelectedIndexChanged += new System.EventHandler(this.gameChoiceCB_SelectedIndexChanged);
            this.gameChoiceCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameChoiceCB_MouseClick);
            // 
            // mouseXAddressLBL
            // 
            this.mouseXAddressLBL.AutoSize = true;
            this.mouseXAddressLBL.BackColor = System.Drawing.Color.Transparent;
            this.mouseXAddressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseXAddressLBL.ForeColor = System.Drawing.Color.White;
            this.mouseXAddressLBL.Location = new System.Drawing.Point(272, 130);
            this.mouseXAddressLBL.Name = "mouseXAddressLBL";
            this.mouseXAddressLBL.Size = new System.Drawing.Size(109, 29);
            this.mouseXAddressLBL.TabIndex = 58;
            this.mouseXAddressLBL.Text = "MouseX:";
            // 
            // mouseYAddressLBL
            // 
            this.mouseYAddressLBL.AutoSize = true;
            this.mouseYAddressLBL.BackColor = System.Drawing.Color.Transparent;
            this.mouseYAddressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseYAddressLBL.ForeColor = System.Drawing.Color.White;
            this.mouseYAddressLBL.Location = new System.Drawing.Point(272, 154);
            this.mouseYAddressLBL.Name = "mouseYAddressLBL";
            this.mouseYAddressLBL.Size = new System.Drawing.Size(108, 29);
            this.mouseYAddressLBL.TabIndex = 59;
            this.mouseYAddressLBL.Text = "MouseY:";
            // 
            // mouseYValueLBL
            // 
            this.mouseYValueLBL.AutoSize = true;
            this.mouseYValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.mouseYValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseYValueLBL.ForeColor = System.Drawing.Color.White;
            this.mouseYValueLBL.Location = new System.Drawing.Point(379, 154);
            this.mouseYValueLBL.Name = "mouseYValueLBL";
            this.mouseYValueLBL.Size = new System.Drawing.Size(65, 29);
            this.mouseYValueLBL.TabIndex = 60;
            this.mouseYValueLBL.Text = "1337";
            // 
            // mouseXValueLBL
            // 
            this.mouseXValueLBL.AutoSize = true;
            this.mouseXValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.mouseXValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseXValueLBL.ForeColor = System.Drawing.Color.White;
            this.mouseXValueLBL.Location = new System.Drawing.Point(379, 130);
            this.mouseXValueLBL.Name = "mouseXValueLBL";
            this.mouseXValueLBL.Size = new System.Drawing.Size(65, 29);
            this.mouseXValueLBL.TabIndex = 61;
            this.mouseXValueLBL.Text = "1337";
            // 
            // ProcessTMR
            // 
            this.ProcessTMR.Interval = 10;
            this.ProcessTMR.Tick += new System.EventHandler(this.ProcessTMR_Tick);
            // 
            // xPosValueLBL
            // 
            this.xPosValueLBL.AutoSize = true;
            this.xPosValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.xPosValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosValueLBL.ForeColor = System.Drawing.Color.White;
            this.xPosValueLBL.Location = new System.Drawing.Point(344, 180);
            this.xPosValueLBL.Name = "xPosValueLBL";
            this.xPosValueLBL.Size = new System.Drawing.Size(65, 29);
            this.xPosValueLBL.TabIndex = 63;
            this.xPosValueLBL.Text = "1337";
            // 
            // posXLBL
            // 
            this.posXLBL.AutoSize = true;
            this.posXLBL.BackColor = System.Drawing.Color.Transparent;
            this.posXLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posXLBL.ForeColor = System.Drawing.Color.White;
            this.posXLBL.Location = new System.Drawing.Point(272, 180);
            this.posXLBL.Name = "posXLBL";
            this.posXLBL.Size = new System.Drawing.Size(76, 29);
            this.posXLBL.TabIndex = 62;
            this.posXLBL.Text = "Xpos:";
            // 
            // posZLBL
            // 
            this.posZLBL.AutoSize = true;
            this.posZLBL.BackColor = System.Drawing.Color.Transparent;
            this.posZLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posZLBL.ForeColor = System.Drawing.Color.White;
            this.posZLBL.Location = new System.Drawing.Point(270, 237);
            this.posZLBL.Name = "posZLBL";
            this.posZLBL.Size = new System.Drawing.Size(73, 29);
            this.posZLBL.TabIndex = 64;
            this.posZLBL.Text = "Zpos:";
            // 
            // posYLBL
            // 
            this.posYLBL.AutoSize = true;
            this.posYLBL.BackColor = System.Drawing.Color.Transparent;
            this.posYLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posYLBL.ForeColor = System.Drawing.Color.White;
            this.posYLBL.Location = new System.Drawing.Point(270, 209);
            this.posYLBL.Name = "posYLBL";
            this.posYLBL.Size = new System.Drawing.Size(75, 29);
            this.posYLBL.TabIndex = 65;
            this.posYLBL.Text = "Ypos:";
            // 
            // yPosValueLBL
            // 
            this.yPosValueLBL.AutoSize = true;
            this.yPosValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.yPosValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosValueLBL.ForeColor = System.Drawing.Color.White;
            this.yPosValueLBL.Location = new System.Drawing.Point(342, 237);
            this.yPosValueLBL.Name = "yPosValueLBL";
            this.yPosValueLBL.Size = new System.Drawing.Size(65, 29);
            this.yPosValueLBL.TabIndex = 66;
            this.yPosValueLBL.Text = "1337";
            // 
            // zPosValueLBL
            // 
            this.zPosValueLBL.AutoSize = true;
            this.zPosValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.zPosValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zPosValueLBL.ForeColor = System.Drawing.Color.White;
            this.zPosValueLBL.Location = new System.Drawing.Point(342, 209);
            this.zPosValueLBL.Name = "zPosValueLBL";
            this.zPosValueLBL.Size = new System.Drawing.Size(65, 29);
            this.zPosValueLBL.TabIndex = 67;
            this.zPosValueLBL.Text = "1337";
            // 
            // enemyHealthLBL
            // 
            this.enemyHealthLBL.AutoSize = true;
            this.enemyHealthLBL.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealthLBL.ForeColor = System.Drawing.Color.White;
            this.enemyHealthLBL.Location = new System.Drawing.Point(493, 105);
            this.enemyHealthLBL.Name = "enemyHealthLBL";
            this.enemyHealthLBL.Size = new System.Drawing.Size(168, 29);
            this.enemyHealthLBL.TabIndex = 69;
            this.enemyHealthLBL.Text = "Enemy Health:";
            // 
            // EnHealthValueLBL
            // 
            this.EnHealthValueLBL.AutoSize = true;
            this.EnHealthValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.EnHealthValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnHealthValueLBL.ForeColor = System.Drawing.Color.White;
            this.EnHealthValueLBL.Location = new System.Drawing.Point(651, 105);
            this.EnHealthValueLBL.Name = "EnHealthValueLBL";
            this.EnHealthValueLBL.Size = new System.Drawing.Size(65, 29);
            this.EnHealthValueLBL.TabIndex = 70;
            this.EnHealthValueLBL.Text = "1337";
            // 
            // HealthMineLBL
            // 
            this.HealthMineLBL.AutoSize = true;
            this.HealthMineLBL.BackColor = System.Drawing.Color.Transparent;
            this.HealthMineLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthMineLBL.ForeColor = System.Drawing.Color.White;
            this.HealthMineLBL.Location = new System.Drawing.Point(380, 105);
            this.HealthMineLBL.Name = "HealthMineLBL";
            this.HealthMineLBL.Size = new System.Drawing.Size(65, 29);
            this.HealthMineLBL.TabIndex = 72;
            this.HealthMineLBL.Text = "1337";
            // 
            // healthLBL
            // 
            this.healthLBL.AutoSize = true;
            this.healthLBL.BackColor = System.Drawing.Color.Transparent;
            this.healthLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLBL.ForeColor = System.Drawing.Color.White;
            this.healthLBL.Location = new System.Drawing.Point(273, 105);
            this.healthLBL.Name = "healthLBL";
            this.healthLBL.Size = new System.Drawing.Size(88, 29);
            this.healthLBL.TabIndex = 71;
            this.healthLBL.Text = "Health:";
            // 
            // myDetailsLBL
            // 
            this.myDetailsLBL.AutoSize = true;
            this.myDetailsLBL.BackColor = System.Drawing.Color.Transparent;
            this.myDetailsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myDetailsLBL.ForeColor = System.Drawing.Color.White;
            this.myDetailsLBL.Location = new System.Drawing.Point(293, 76);
            this.myDetailsLBL.Name = "myDetailsLBL";
            this.myDetailsLBL.Size = new System.Drawing.Size(127, 29);
            this.myDetailsLBL.TabIndex = 73;
            this.myDetailsLBL.Text = "My details:";
            // 
            // enDetailsLBL
            // 
            this.enDetailsLBL.AutoSize = true;
            this.enDetailsLBL.BackColor = System.Drawing.Color.Transparent;
            this.enDetailsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enDetailsLBL.ForeColor = System.Drawing.Color.White;
            this.enDetailsLBL.Location = new System.Drawing.Point(536, 76);
            this.enDetailsLBL.Name = "enDetailsLBL";
            this.enDetailsLBL.Size = new System.Drawing.Size(170, 29);
            this.enDetailsLBL.TabIndex = 74;
            this.enDetailsLBL.Text = "Enemy details:";
            // 
            // selectProcessLBL
            // 
            this.selectProcessLBL.AutoSize = true;
            this.selectProcessLBL.BackColor = System.Drawing.Color.Transparent;
            this.selectProcessLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Underline);
            this.selectProcessLBL.ForeColor = System.Drawing.Color.White;
            this.selectProcessLBL.Location = new System.Drawing.Point(43, 73);
            this.selectProcessLBL.Name = "selectProcessLBL";
            this.selectProcessLBL.Size = new System.Drawing.Size(179, 29);
            this.selectProcessLBL.TabIndex = 81;
            this.selectProcessLBL.Text = "Select process:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 82;
            this.label1.Text = "AssaultCube Aimbot";
            // 
            // xPosENLBL
            // 
            this.xPosENLBL.AutoSize = true;
            this.xPosENLBL.BackColor = System.Drawing.Color.Transparent;
            this.xPosENLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosENLBL.ForeColor = System.Drawing.Color.White;
            this.xPosENLBL.Location = new System.Drawing.Point(493, 180);
            this.xPosENLBL.Name = "xPosENLBL";
            this.xPosENLBL.Size = new System.Drawing.Size(101, 29);
            this.xPosENLBL.TabIndex = 75;
            this.xPosENLBL.Text = "xPosEn:";
            // 
            // xPosEnValueLBL
            // 
            this.xPosEnValueLBL.AutoSize = true;
            this.xPosEnValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.xPosEnValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosEnValueLBL.ForeColor = System.Drawing.Color.White;
            this.xPosEnValueLBL.Location = new System.Drawing.Point(590, 180);
            this.xPosEnValueLBL.Name = "xPosEnValueLBL";
            this.xPosEnValueLBL.Size = new System.Drawing.Size(65, 29);
            this.xPosEnValueLBL.TabIndex = 76;
            this.xPosEnValueLBL.Text = "1337";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(493, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 77;
            this.label4.Text = "yPosEn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 78;
            this.label3.Text = "zPosEn:";
            // 
            // yPosEnValueLBL
            // 
            this.yPosEnValueLBL.AutoSize = true;
            this.yPosEnValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.yPosEnValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosEnValueLBL.ForeColor = System.Drawing.Color.White;
            this.yPosEnValueLBL.Location = new System.Drawing.Point(590, 209);
            this.yPosEnValueLBL.Name = "yPosEnValueLBL";
            this.yPosEnValueLBL.Size = new System.Drawing.Size(65, 29);
            this.yPosEnValueLBL.TabIndex = 79;
            this.yPosEnValueLBL.Text = "1337";
            // 
            // zPosEnValueLBL
            // 
            this.zPosEnValueLBL.AutoSize = true;
            this.zPosEnValueLBL.BackColor = System.Drawing.Color.Transparent;
            this.zPosEnValueLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zPosEnValueLBL.ForeColor = System.Drawing.Color.White;
            this.zPosEnValueLBL.Location = new System.Drawing.Point(590, 237);
            this.zPosEnValueLBL.Name = "zPosEnValueLBL";
            this.zPosEnValueLBL.Size = new System.Drawing.Size(65, 29);
            this.zPosEnValueLBL.TabIndex = 80;
            this.zPosEnValueLBL.Text = "1337";
            // 
            // CustomAimbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectProcessLBL);
            this.Controls.Add(this.zPosEnValueLBL);
            this.Controls.Add(this.yPosEnValueLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xPosEnValueLBL);
            this.Controls.Add(this.xPosENLBL);
            this.Controls.Add(this.enDetailsLBL);
            this.Controls.Add(this.myDetailsLBL);
            this.Controls.Add(this.HealthMineLBL);
            this.Controls.Add(this.healthLBL);
            this.Controls.Add(this.EnHealthValueLBL);
            this.Controls.Add(this.enemyHealthLBL);
            this.Controls.Add(this.zPosValueLBL);
            this.Controls.Add(this.yPosValueLBL);
            this.Controls.Add(this.posYLBL);
            this.Controls.Add(this.posZLBL);
            this.Controls.Add(this.xPosValueLBL);
            this.Controls.Add(this.posXLBL);
            this.Controls.Add(this.mouseXValueLBL);
            this.Controls.Add(this.mouseYValueLBL);
            this.Controls.Add(this.mouseYAddressLBL);
            this.Controls.Add(this.mouseXAddressLBL);
            this.Controls.Add(this.gameChoiceCB);
            this.Controls.Add(this.downBTN);
            this.Controls.Add(this.upBTN);
            this.Controls.Add(this.leftBTN);
            this.Controls.Add(this.rightBTN);
            this.Name = "CustomAimbot";
            this.Text = "Aimbot";
            this.Load += new System.EventHandler(this.CustomAimbot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.ComboBox gameChoiceCB;
        private System.Windows.Forms.Label mouseXAddressLBL;
        private System.Windows.Forms.Label mouseYAddressLBL;
        private System.Windows.Forms.Label mouseYValueLBL;
        private System.Windows.Forms.Label mouseXValueLBL;
        private System.Windows.Forms.Timer ProcessTMR;
        private System.Windows.Forms.Label xPosValueLBL;
        private System.Windows.Forms.Label posXLBL;
        private System.Windows.Forms.Label posZLBL;
        private System.Windows.Forms.Label posYLBL;
        private System.Windows.Forms.Label yPosValueLBL;
        private System.Windows.Forms.Label zPosValueLBL;
        private System.Windows.Forms.Label enemyHealthLBL;
        private System.Windows.Forms.Label EnHealthValueLBL;
        private System.Windows.Forms.Label HealthMineLBL;
        private System.Windows.Forms.Label healthLBL;
        private System.Windows.Forms.Label myDetailsLBL;
        private System.Windows.Forms.Label enDetailsLBL;
        private System.Windows.Forms.Label selectProcessLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xPosENLBL;
        private System.Windows.Forms.Label xPosEnValueLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yPosEnValueLBL;
        private System.Windows.Forms.Label zPosEnValueLBL;
    }
}

