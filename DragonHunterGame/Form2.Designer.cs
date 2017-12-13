namespace DragonHunterGame
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerClass = new System.Windows.Forms.Label();
            this.lblPlayerPower = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.gbDragonName = new System.Windows.Forms.GroupBox();
            this.lblDragonHealth = new System.Windows.Forms.Label();
            this.lblDragonPower = new System.Windows.Forms.Label();
            this.lblDragonClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.gbPlayer.SuspendLayout();
            this.gbDragonName.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class:";
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Location = new System.Drawing.Point(6, 71);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(40, 13);
            this.Power.TabIndex = 1;
            this.Power.Text = "Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Health:";
            // 
            // lblPlayerClass
            // 
            this.lblPlayerClass.AutoSize = true;
            this.lblPlayerClass.Location = new System.Drawing.Point(65, 21);
            this.lblPlayerClass.Name = "lblPlayerClass";
            this.lblPlayerClass.Size = new System.Drawing.Size(19, 13);
            this.lblPlayerClass.TabIndex = 3;
            this.lblPlayerClass.Text = "<>";
            // 
            // lblPlayerPower
            // 
            this.lblPlayerPower.AutoSize = true;
            this.lblPlayerPower.Location = new System.Drawing.Point(65, 71);
            this.lblPlayerPower.Name = "lblPlayerPower";
            this.lblPlayerPower.Size = new System.Drawing.Size(19, 13);
            this.lblPlayerPower.TabIndex = 4;
            this.lblPlayerPower.Text = "<>";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(65, 46);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(19, 13);
            this.lblPlayerHealth.TabIndex = 5;
            this.lblPlayerHealth.Text = "<>";
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lblPlayerHealth);
            this.gbPlayer.Controls.Add(this.lblPlayerPower);
            this.gbPlayer.Controls.Add(this.lblPlayerClass);
            this.gbPlayer.Controls.Add(this.label3);
            this.gbPlayer.Controls.Add(this.Power);
            this.gbPlayer.Controls.Add(this.label1);
            this.gbPlayer.Location = new System.Drawing.Point(12, 12);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(143, 106);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "<>";
            // 
            // gbDragonName
            // 
            this.gbDragonName.Controls.Add(this.lblDragonHealth);
            this.gbDragonName.Controls.Add(this.lblDragonPower);
            this.gbDragonName.Controls.Add(this.lblDragonClass);
            this.gbDragonName.Controls.Add(this.label6);
            this.gbDragonName.Controls.Add(this.label7);
            this.gbDragonName.Controls.Add(this.label8);
            this.gbDragonName.Location = new System.Drawing.Point(268, 12);
            this.gbDragonName.Name = "gbDragonName";
            this.gbDragonName.Size = new System.Drawing.Size(143, 106);
            this.gbDragonName.TabIndex = 6;
            this.gbDragonName.TabStop = false;
            this.gbDragonName.Text = "<>";
            // 
            // lblDragonHealth
            // 
            this.lblDragonHealth.AutoSize = true;
            this.lblDragonHealth.Location = new System.Drawing.Point(65, 46);
            this.lblDragonHealth.Name = "lblDragonHealth";
            this.lblDragonHealth.Size = new System.Drawing.Size(19, 13);
            this.lblDragonHealth.TabIndex = 5;
            this.lblDragonHealth.Text = "<>";
            // 
            // lblDragonPower
            // 
            this.lblDragonPower.AutoSize = true;
            this.lblDragonPower.Location = new System.Drawing.Point(65, 71);
            this.lblDragonPower.Name = "lblDragonPower";
            this.lblDragonPower.Size = new System.Drawing.Size(19, 13);
            this.lblDragonPower.TabIndex = 4;
            this.lblDragonPower.Text = "<>";
            // 
            // lblDragonClass
            // 
            this.lblDragonClass.AutoSize = true;
            this.lblDragonClass.Location = new System.Drawing.Point(65, 21);
            this.lblDragonClass.Name = "lblDragonClass";
            this.lblDragonClass.Size = new System.Drawing.Size(19, 13);
            this.lblDragonClass.TabIndex = 3;
            this.lblDragonClass.Text = "<>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Health:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Power:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class:";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(180, 33);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(66, 63);
            this.btnRoll.TabIndex = 7;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(12, 130);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(399, 23);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "<Output>";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 161);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.gbDragonName);
            this.Controls.Add(this.gbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Hunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbDragonName.ResumeLayout(false);
            this.gbDragonName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerClass;
        private System.Windows.Forms.Label lblPlayerPower;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.GroupBox gbDragonName;
        private System.Windows.Forms.Label lblDragonHealth;
        private System.Windows.Forms.Label lblDragonPower;
        private System.Windows.Forms.Label lblDragonClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblOutput;
    }
}