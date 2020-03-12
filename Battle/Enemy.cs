using System;
using System.Collections.Generic;
using System.Text;

namespace Battle
{
    public class Enemy
    {
        public int vida;
        public int maxAtk;
        public int minAtk;

        public Enemy(int vida, int maxAtk, int minAtk)
        {
            this.vida = vida;
            this.maxAtk = maxAtk;
            this.minAtk = minAtk;
        }

        public void Atacar(Enemy enemy)
        {
            Random random = new Random();
            enemy.RecibirDaño(random.Next(minAtk, maxAtk + 1));
        }

        public void RecibirDaño(int daño)
        {
            vida -= daño;
            if(vida <= 0)
            {
                Console.WriteLine("He muerto");
            }
        }
    }
}
