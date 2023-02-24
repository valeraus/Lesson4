using System;

namespace Task5
{
    class Body : Part
    {
        //string content;

        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Тіло документу відсутнє.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}