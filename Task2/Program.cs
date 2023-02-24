using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створіть клас AbstractHandler.
    У тілі класу створити методи void Open (), void Create (), void Chenge (), void Save ().
    Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler.
    Написати програму, яка буде виконувати визначення документа і 
    для кожного формату повинні бути методи відкриття, створення, редагування, збереження певного формату документа.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.ChooseDocument("file.doc");

            redactor.Craete();
            redactor.Open();
            redactor.Chenge();
            redactor.Save();

            // Delay.
            Console.ReadKey();
        }
    }
}
