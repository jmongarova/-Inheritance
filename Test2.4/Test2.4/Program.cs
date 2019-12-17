using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввойдите без ключа нажав Enter или введить ключ: ");
            string key = Console.ReadLine();
            DocumentWorker Doc = new DocumentWorker(); ;
            if (key == "root2019")
            {
                Doc = new ProDocumentWorker();
            }
            else if (key == "exproot2019")
            {
                Doc = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("Вы пользуетесь бесплатной версией");
            }
            Doc.OpenDocument();
            Doc.EditDocument();
            Doc.SaveDocument();
            Console.ReadKey();
        }
    }
}
