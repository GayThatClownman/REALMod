using System;

namespace REALMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döden spelar schack.");

            Player p1 = new Player();
            
            p1.weight = 3;
            p1.jumpHeight = 6;
            p1.hp = 10;
            p1.moveSpeed = 8;
            p1.name = "Per";


            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            e1.moveSpeed = 7;
            e1.dead = false;
            e2.moveSpeed = 4;
            e2.dead = false;
            
            Platform platform1 = new Platform();
            Platform platform2 = new Platform();

            platform1.x = 5;
            platform1.y = 7;
            platform1.destructible = false;


            platform2.x = 10;
            platform2.y = 12;
            platform2.destructible = true;

            Console.ReadLine();


        }
    }
}
