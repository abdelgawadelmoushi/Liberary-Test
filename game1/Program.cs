using game1;
using System.Xml.Linq;

namespace game1
{
    #region MyRegion
    //class Player
    //{
    //    string name;
    //    int number;
    //    int speed;
    //    int health;
    //    double exp;


    //    public Player(string name, int number, int speed, int health, double exp)
    //    {
    //        this.name = name;
    //        this.number = number;
    //        this.speed = speed;
    //        this.health = health;
    //        this.exp = exp;
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Player player1 = new("Amr", 10, 99, 99, 5);
    //        Player player2 = new("Amr", 10, 99, 99, 5);
    //    }
    //}
    #endregion


    class Player
    {

        string id;
        string name;
        double health;

        public Player(string id, string name, double health)
        {
            this.id = id;
            this.name = name;
            this.health = health;
        }

        public string Id
        {
            get => this.id;

        }
        public string Name
        {
            get => this.name;
            set => this.Name = value;
        }

        public string Helth
        {
            get => name;
            set => Name = value;
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Player player1 = new("12345", "Amr", 99);
                Player player2 = new("67789", "Ahmed", 50);
                player2.Name = "Khalid";
            }
        }

    }
}