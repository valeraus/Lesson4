using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створіть 2 інтерфейсу IPlayable і IRecodable. У кожному з інтерфейсів створіть 
    по 3 методу void Play () / void Pause () / void Stop () і void Record () / void Pause () / void Stop () відповідно.
    Створіть похідний клас Player від базових інтерфейсів IPlayable і IRecodable.
    Написати програму, яка виконує програвання і запис.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecodable).Stop();

            // Delay.
            Console.ReadKey();
        }
    }
}
