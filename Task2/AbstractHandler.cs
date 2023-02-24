using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     abstract class AbstractHandler
    {
        protected string fileName;
        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open() 
        {
            Console.WriteLine(fileName + " вiдкритий");
        } 
        public void Create()
        {
            Console.WriteLine(fileName + " створений");
        }
        public void Chenge()
        {
            Console.WriteLine(fileName + " вiдредагований");
        }
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }
        public override void Save()
        {
            Console.WriteLine(fileName + " збережений в форматi XML");
        } 
    }
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " збережений в форматi TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " збережений в форматi DOC");
        }
    }
}

    
