using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITY
{
    class Program
    {
        static void Main(string[] args)
        {
            //COM IOC - DI
            IMembro obj = Fabrica.CreateInstance();
            obj.Nome    = " Silas ";
            obj.Time    = " Brasil ";
            obj.Detalhes();

            IMembro obj1 = Fabrica.CreateInstance();
            obj.Nome     = "Jefferson ";
            obj.Time     = " Argentina ";
            obj.Detalhes();

            Console.Read();


            //SEM IOC DI
            //Membro obj2 = new Membro();
            //obj2.Nome = " Macoratti ";
            //obj2.Time = " Brasil ";
            //obj2.Detalhes();
            
            //IMembro obj3 = new Membro();
            //obj3.Nome = "Jefferson ";
            //obj3.Time = " Argentina ";
            //obj3.Detalhes();
            //Console.Read();

        }
    }
}
