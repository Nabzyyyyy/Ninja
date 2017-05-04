using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninja.Forms;

namespace Ninja
{
    public partial class Form1 : Form
    {
        public Form1() // constructor
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentGame = cboBoxGame.Text;
            sqlFunc sql = new sqlFunc();
            try {
                ninjaGame.players = sqlFunc.participants(currentGame);
            }
            catch (Exception) {  }

            
        }

        private void cboBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlFunc sql = new sqlFunc();
            ninjaGame.players = sqlFunc.participants(cboBoxGame.Text);
            cboBoxKiller.DataSource = ninjaGame.players;
            cboBoxTarget.DataSource = ninjaGame.players;
            cboBoxPlayer.DataSource = ninjaGame.players;


            string curGame = cboBoxGame.Text;
        }

        private void cboBoxKiller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddKill_Click(object sender, EventArgs e)
        {
            if (cboBoxKiller.Text != cboBoxTarget.Text)
                sqlFunc.AddKill(cboBoxKiller.Text, cboBoxTarget.Text, cboBoxGame.Text);
            // calls add kill function which also updates leaderboard
            
        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            sqlFunc.AddAchievement(cboBoxPlayer.Text, cboBoxAchievement.Text, cboBoxGame.Text);
            // call add achievement function which also updates leaderboard
        }

        public string getGameName()
        {
            string text = cboBoxGame.Text;
            return text;
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            editForm eform = new editForm();
            eform.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cboBoxGame.DataSource = ninjaGame.gamesList;
            Form1 myform = new Form1();
            myform.Update();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {

        }
    }
}
