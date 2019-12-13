using System;

namespace TextNameSpace 
{
    public class Text 
    {
        private string playerName;
        private int difficulty;
        //private string items;

        private int points;
        public Text (string name, int level)
        {
            this.playerName = name;
            this.difficulty = level;
            //this.items = item;
            this.points = Setpoints(level);
        }
        //getters for instance variables
        public string GetPlayerName()
        {
            return this.playerName; 
        }
        public int GetDifficulty()
        {
            return this.difficulty;
        }
        // public string GetItems()
        // {
        //     return this.items; 
        // }
        //setters for instance variables 
        public void SetPlayerName(string name)
        {
            this.playerName = name;
        }
        public void SetDifficulty(int level)
        {
            this.difficulty = level;
        }
        // public void SetItems(string item)
        // {
        //     this.items = item; 
        // }
        public int Setpoints(int level)
        {
            if (level==1)
            {
                return 3;
            }
            else if (level==2)
            {
                return 4;
            }
            else if (level==3)
            {
                return 5;
            }
            return -1;
        }
        public void AddPoints(int point)
        {
            this.points+=point; 
        }
        public void SubPoints(int point)
        {
            this.points-=point; 
        }
        public int ReturnPoint()
        {
            return this.points;
        }

        public string GetRoom(int index)
        {
            string [] arrayRooms = {"Living Room", "Kitchen", "Bedroom", "Bathroom","Garage"};
            return arrayRooms[index];

        }
        public string Print()
        {
            string output="Player Name: "+ this.playerName+ ", Level of Difficulty: "+ this.difficulty;
            return output; 
        }
    }
}