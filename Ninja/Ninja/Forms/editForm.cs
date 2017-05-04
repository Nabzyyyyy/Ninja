using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninja.Forms
{
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewGame_Click(object sender, EventArgs e)
        {
            if (txtCreateNewGame.Text == "")
                return;
            else
            {
                sqlFunc.createGame(txtCreateNewGame.Text);
                lblGameName.Text = txtCreateNewGame.Text;
                // ADD CHANGING CURRENT GAME TO THIS GAME
                // 
            }

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            sqlFunc.createParticipant(txtAddPlayer.Text, lblGameName.Text);
        }

        private void lblGameName_Click(object sender, EventArgs e)
        {

        }
    }
}
