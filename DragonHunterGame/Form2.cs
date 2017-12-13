using DragonHunterGame.Enums;
using DragonHunterGame.Model;
using DragonHunterGame.Static;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DragonHunterGame
{
    public partial class Form2 : Form
    {
        Form1 mainform;
        string playerName;
        CharType playerChar;

        public Form2(Form1 f)
        {
            mainform = f;
            this.playerName = mainform.playerName;
            this.playerChar = mainform.playerChar;

            InitializeComponent();
        }

        Character player;
        Dragon dragon = new Dragon("Dragon Şirin");

        private void Form2_Load(object sender, EventArgs e)
        {
            if (playerChar == CharType.Warrior)
                player = new Warrior();
            else if (playerChar == CharType.Mage)
                player = new Mage();
            player.Name = playerName;

            gbPlayer.Text = player.Name;
            lblPlayerClass.Text = player.Type.ToString();
            lblPlayerHealth.Text = player.Health.ToString();
            lblPlayerPower.Text = player.Power.ToString();

            gbDragonName.Text = dragon.Name;
            lblDragonClass.Text = dragon.Type.ToString();
            lblDragonHealth.Text = dragon.Health.ToString();
            lblDragonPower.Text = dragon.Power.ToString();
            lblOutput.Text = "Your Turn!";

            dragon.OnDeath += E_OnDeath;
            player.OnDeath += E_OnDeath;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Visible = false;

            int hit = player.Attack(DiceRoller.Roll()); // saldırı gücünü hesapla
            dragon.HealthDecrease(hit); // canını düşür
            UpdateLabels(player.Name, hit); // labelları güncelle
            Refresh();
            Thread.Sleep(900);

            lblOutput.Text = $"{dragon.Name} attacking...";
            Refresh();
            Thread.Sleep(900);

            hit = dragon.Attack(DiceRoller.Roll());
            player.HealthDecrease(hit);
            UpdateLabels(dragon.Name, hit);
            Refresh();
            Thread.Sleep(900);

            lblOutput.Text = "Your Turn!";
            btnRoll.Visible = true;
        }

        private void UpdateLabels(string name, int hit)
        {
            lblPlayerHealth.Text = player.Health.ToString();
            lblDragonHealth.Text = dragon.Health.ToString();
            if (hit == 0)
                lblOutput.Text = $"{name} MISSED!";
            else
                lblOutput.Text = $"{name} hit {hit}!";
        }

        private void E_OnDeath()
        {
            if (player.Health <= 0)
                MessageBox.Show("You Lost!");
            else
                MessageBox.Show("You Won!");

            this.Hide();
            mainform.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainform.Show();
        }
    }
}
