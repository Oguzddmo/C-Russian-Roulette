using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Russian_roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Roulette object1 = new Roulette();
            object1.Russianroulette1();


        }
    }
    public class Roulette
    {
        bullet1 object2 = new bullet1();
        bool[] gun = new bool[6] { true, true, true, true, true, true };
        int bullet = 0;
        bool player1 = true;
        bool player2 = true;
        public void Russianroulette1()
        {
            Random rnd = new Random();
            gun[rnd.Next(1, 6)] = false;


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Player 1's turn");
                Console.ReadKey();

                player1 = gun[bullet]; bullet++;
                object2.bullet1_(bullet);
                Console.WriteLine();
                if (player1 == false)
                {
                    Console.WriteLine("player1 is dead"); break;
                }
                Console.WriteLine("Player 2's turn");
                Console.ReadKey();
                player2 = gun[bullet]; bullet++;
                object2.bullet1_(bullet);
                Console.WriteLine();
                if (player2 == false)
                {
                    Console.WriteLine("player2 is dead"); break;
                }
            }
        }
    }
    public class bullet1
    {
        public void bullet1_(int bullet_)
        {
            for (int i = 0; i < bullet_; i++)
            {
                Console.Write("*");
            }
        }
    }
}
//deneme1 deneme2

