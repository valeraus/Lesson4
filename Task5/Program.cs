﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно: Змінити 12 приклад першого уроку (робота з документом) і створити загальний 
    абстрактний клас для всіх частин документа.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тіло контракту...";

            Footer footer = new Footer();
            footer.Content = "Директор: Іванов І.І.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
