using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class ninjaGame
    {
        public static int totalScore;
        public static List<int> gamesList;
        Form1 myform;

        ninjaGame(Form1 myform) {
            this.myform = myform;
        }

        public string currentGame() {
            //Form1 myform;// = new Form1();

            string gameName = "";
            //gameName = myform.cboBoxGame.Text;
            return gameName;
        }

    }
}
