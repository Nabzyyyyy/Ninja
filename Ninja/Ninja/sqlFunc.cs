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
        public static string cmd;
        public static int cnt;

        public static void createUser(string name) { // id name
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
        } 



        public static void createUserTable() { // creates table of users (should only need to call once)
            // checks if user table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'users'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                return;
            else {
                cmd = "CREATE TABLE users (id INT, name STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            
        }



        public static void createParticipantsTable() { // Adds table of participants for all games (should only need to call once)
            // checks if participants table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'participants'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                return;
            else {
                cmd = "CREATE TABLE participants (userid INT, gameName STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
        }



        public static void createParticipant(string userid, string game) { // add new user to a game, called in createUser
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



        } 



        public static void createAchievementsTable() {  // has list of achievements and their ids
            // checks if achievement table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'achievements'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                return;
            else {
                cmd = "CREATE TABLE achievements (achievementid INT, name STRING)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            

        }


        public static void createUserAchievementsTable() { // creates table of achievements linked to which user and to which game
            // checks if achievement table exists
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'userAchievements'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                return;
            else {
                cmd = "CREATE TABLE userAchievements (gameid INT, userid INT, achieveid INT, count INT)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }

        }


        public static void createGame(string gameName) { // creates new game instance with player: id, name, score, death
            //check to see gameName exists and if not, use that to determine the new game name
            cmd = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'userAchievements'";
            SQLiteCommand check = new SQLiteCommand(cmd, Program.conn);
            if (Convert.ToInt32(check) == 0)
                // ADD : alert user that gameName already exists and to create a game with a different name
                return;
            else {
                cmd = "CREATE TABLE " + gameName + " (id INT, name STRING, score INT, kills INT, deaths INT)";
                SQLiteCommand createTable = new SQLiteCommand(cmd, Program.conn);
            }
            
        }


    }
}
