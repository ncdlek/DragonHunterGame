using DragonHunterGame.Enums;
using System;
using System.Windows.Forms;

namespace DragonHunterGame
{
    public partial class Form1 : Form
    {
        public string playerName;
        public CharType playerChar;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
                btnStartGame.Enabled = true;
            else
                btnStartGame.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;
            playerChar = rbMage.Checked ? CharType.Mage : CharType.Warrior;

            Form2 f2 = new Form2(this);
            f2.Show();
            this.Hide();
        }
    }
}
