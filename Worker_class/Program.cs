using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 6.4
//Создать абстрактный базовый класс Worker (работника) с методом Print(). 
// Создайте четыре производных класса: President, Security, Manager, Engineer.
//Переопределите метод Print() для вывода информации, соответствующей каждому типу работника.
namespace Worker_class
{
    abstract class Worker 
        {
        abstract public void Print();
        }
    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President of company Nikolay Ivanovich Dimov ");
        }
    }
    class Security:Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security works 24 hours 7 days/week ");
        }

    }
    class Manager:Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager controls all prosecces ");
        }

    }
    class Engeneer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engeneer is responsible for technical support ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            President p = new President();
            p.Print();
            Security s = new Security();
            s.Print();
            Manager m = new Manager();
            m.Print();
            Engeneer en = new Engeneer();
            en.Print();

        }
    }
}
