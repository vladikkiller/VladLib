using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladLib
{
    //Реалізація класу Worker, який наслідує методи та атрибути класу People
    public class Worker : People
    {
        //Атрибути класу Worker
        private string position { get; set; }
        private string unit { get; set; }
        //Конструктор з параметрами класу Worker
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
        //Вивід інформації про об'єкт класу Worker
        public void PrintWorker()
        {
            base.Print();
            Console.WriteLine($"position: {position}");
            Console.WriteLine($"unit: {unit}");
        }
    }
}
