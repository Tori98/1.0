using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reka
{
    class Reka
    {
        public String Name { get; set; }


        public double PloshBas { get; set; }

        public double Protyas { get; set; }
        public Reka()
        {
            this.Name = "";
            this.PloshBas = 0;
            this.Protyas = 0;
        }


        public void Input()
        {
            Console.Write("Введите название бассейна: "); this.Name = Console.ReadLine();
            Console.Write("Введите площадь бассейна: "); this.PloshBas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите протяжённость бассейна: "); this.Protyas = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Название: {0}", this.Name);
            Console.WriteLine("Площадь: {0}", this.PloshBas);
            Console.WriteLine("Протяженность:{0} ", this.Protyas);
        }

        static void Main(string[] args)
        {
            Reka scr = new Reka();
            scr.Input();
            scr.Print();
            Console.ReadKey();
        }

    }
}
