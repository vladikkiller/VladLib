using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladLib
{
    class Worker : People
    {
        private string position { get; set; }
        private string unit { get; set; }

        public Worker(int age,
            string sex,
            double height,
            double weight,
            string national,
            string creed,
            string profession,
            int passportId,
            string position,
            string unit) : base(age, sex, height, weight, national, creed, profession, passportId)
        {
            this.position = position;
            this.unit = unit;
        }
        public void PrintStudents()
        {
            base.Print();
            Console.WriteLine($"position: {position}");
            Console.WriteLine($"unit: {unit}");
        }
    }
}
