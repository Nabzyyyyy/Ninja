using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    class sqlFunc
    {
        // public static void createUser(string)
        // public static void createUserTable()
        // public static void createPartisipantsTable()
        // public static void createParticipant(string, string)
        // public static void createAchievementsTable()
        // public static void createUserAchievementsTable()
        // public static void createGame(string)
        // public static List<string> participants(string)

        public static string cmd;
        public static int cnt;

        // adds user to database if they're not already in there -- does not allow more than
        // one player with the same name (Should use both first and last name)
        public static void createUser(string name) { // id name
            Program.conn.Open();
            // checks to see if user is already in database
            cmd = "SELECT name FROM users WHERE name = '" + name + "'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (check != null) {
                // counts how many users are in the table to assign as an ID
                cmd = "SELECT COUNT(*) FROM users";
                SQLiteCommand count = new SQLiteCommand(cmd, Program.conn);
                cnt = Convert.ToInt32(count.ExecuteScalar());
                // inserts user with ID and name passed into function
                cmd = "INSERT INTO users (id, name) values (" + name + ", " + (cnt + 1) + ")";
                SQLiteCommand insertUser = new SQLiteCommand(cmd, Program.conn);

                // eventually add game name retrieved from comboBox in form:
                string gameName = "";
                createParticipant(name, gameName);
                // eventually add notification to tell form user that the player was added successfully
            }
            Program.conn.Close();
        } 



        public static void createUserTable() { // creates table of users (should only need to call once)
            // checks if user table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'users'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0) {
                Program.conn.Close();
                return;
            }
            else {
                cmd = "CREATE TABLE users (id INT, name STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            Program.conn.Close();
        }



        public static void createParticipantsTable() { // Adds table of participants for all games (should only need to call once)
            Program.conn.Open();
            // checks if participants table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'participants'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0) {
                Program.conn.Close();
                return;
            }
            else {
                cmd = "CREATE TABLE participants (userid INT, gameName STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            Program.conn.Close();
        }



        public static void createParticipant(string userid, string game) { // add new user to a game, called in createUser
            Program.conn.Open();
            // checks to see if paricipant is already in database
            cmd = "SELECT userid FROM participants WHERE userid = '" + userid + "'";
            SQLiteCommand checkID = new SQLiteCommand(cmd, Program.conn);
            if (checkID != null)
            {
                // checks to see if paricipant is already in database
                cmd = "SELECT * gameName FROM participants WHERE userid = '" + userid + "'"; //// CHECK TO SEE IF SEQUEL COMMAND IS VALID
                SQLiteCommand checkGame = new SQLiteCommand(cmd, Program.conn);
                Convert.ToInt32(checkGame);

                //foreach (int gameName in checkGame) { // for each game in gameName, check to see if game = gameName. If it does, return, if not, create participant

                //}
                if (checkGame != null) {
                    // inserts participant with userID and gameName to add them to (both passed into this function)
                    cmd = "INSERT INTO partipants (userid, gameName) values (" + userid + ", " + game + ")";
                    SQLiteCommand insertPartipant = new SQLiteCommand(cmd, Program.conn);
                }


                // eventually add notification to tell form user that the participant was added successfully
            }
            Program.conn.Close();
        } 



        public static void createAchievementsTable() {  // has list of achievements and their ids
            Program.conn.Open();
            // checks if achievement table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'achievements'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0) {
                Program.conn.Close();
                return;
            }
            else {
                cmd = "CREATE TABLE achievements (achievementid INT, name STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            Program.conn.Close();

        }
           


        public static void createUserAchievementsTable() { // creates table of achievements linked to which user and to which game
            // checks if achievement table exists
            Program.conn.Open();
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'userAchievements'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0) {
                Program.conn.Close();
                return;
            }
            else {
                cmd = "CREATE TABLE userAchievements (gameid INT, userid INT, achieveid INT, count INT)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            Program.conn.Close();
        }


        public static void createGame(string gameName) { // creates new game instance with player: id, name, score, death
            //check to see gameName exists and if not, use that to determine the new game name
            Program.conn.Open(); 

            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = " + gameName;
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                // ADD : alert user that gameName already exists and to create a game with a different name
                return;
            else {
                cmd = "CREATE TABLE " + gameName + " (id INT, name STRING, score INT, kills INT, deaths INT)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            Program.conn.Close();
            return;
            
        }


        public static List<string> participants(string gameName) {
            Program.conn.Open(); // open connection
        
            // FIRST FIND THE CURRENT GAME INSTANCE ID
            // THEN QUERY PARTIPANTS TABLE FOR ALL USERS WITH THAT ID
            List<string> ppl = new List<string>();
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = " + gameName;
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
            {
                Program.conn.Close();
                throw new Exception("Unable to find table for current Game");
            }

            SQLiteDataReader rdr = check.ExecuteReader();
            while(rdr.Read()) 
            {
                ppl.Add(rdr.GetString(rdr.GetOrdinal("name")));
            }
            rdr.Close();
            
            Program.conn.Close(); // close connection

            return ppl;
        }

        //public static List<string> Tables (this SQLiteConnection conn)
        //{
        //    string qry = "SELECT name FROM sqlite_master";

        //    List<string> tables = new List<string>();
        //    var statement = SQL



        //    return tables;
        //}

        //public static List<string> allGames()
        //{
        //    List<string> gameNames;
        //    cmd = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY 1";
        //    DataTable table = GetDataTable(cmd);

        //    try
        //    {
                
        //    }

        //    SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
        //    List<int> gamesList;


        //    return gamesList;
        //}

    }
}
