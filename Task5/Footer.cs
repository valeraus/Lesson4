using System;

namespace Task5
{
    class Footer : Part
    {
        //string content;

        public override string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Нижній колонтитул відсутній.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}