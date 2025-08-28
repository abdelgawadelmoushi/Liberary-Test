using System;
class Player
{

    string name;
    int number;
    int speed;
    int health;
    double exp;


    public Player(string name, int number, int speed, int health, double exp)
    { 
    this.name = name;
            this.number = number;
    this.speed = speed;
    this.health = health;
    this.exp = exp;
          }
}

  class player
{

    string name;
    int number;
    int speed;
    double health;
   
}

internal class program
{ 
    static void Main(string[] args)
    {

    Player player1 = new Player("Amr", 10, 99, 99, 5);

    }
}