using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninja
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // directory of the database
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "DB.sqlite";
            // Dictionary<string,name> scoreboard;
            // scoreboard = db.Query("SELECT name, score FROM game1 ORDER BY score");

            // leaderboard function that displays scoreboard in order

            if (!File.Exists(dir)) // if the database file does not exist, create it
            {
                SQLiteConnection.CreateFile(dir);
            }
            // open the sqlite connection
            //conn.Open();



            // close the sqlite connection
            //conn.Close();
        }

            // create the sqlite connection
            public static SQLiteConnection conn = new SQLiteConnection("Data Source=DB.sqlite;Version=3;");

           
            
        }
    }