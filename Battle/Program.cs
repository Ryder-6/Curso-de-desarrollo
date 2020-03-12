using System;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 100;
            int maxAtk = 80;
            int minAtk = 20;
            Enemy enemy1 = new Enemy(vida, maxAtk, minAtk);
            Enemy enemy2 = new Enemy(vida, maxAtk, minAtk);
            while (enemy1.vida > 0 && enemy2.vida > 0)
            {
                enemy1.Atacar(enemy2);
                Console.WriteLine("Vida enemigo 2: " + enemy2.vida);
                enemy2.Atacar(enemy1);
                Console.WriteLine("Vida enemigo 1: " + enemy1.vida);
            }
        }
    }
}
