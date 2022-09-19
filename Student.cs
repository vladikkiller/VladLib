using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladLib
{
    //Реалізація класу Student, який наслідує атрибути і методи класу People
    public class Student : People
    {
        //Атрибути класу Student
        public int numbId { get; set; }
        public string group { get; set; }
        //Параметризований конструктор класу Student
        public Student(int age,
            string sex,
            double height,
            double weight,
            string national,
            string creed,
            string profession,
            int passportId,
            int numbId,
            string group) : base(age, sex, height, weight, national, creed, profession, passportId)
        {
            this.numbId = numbId;
            this.group = group;
        }
        //Вивід інформації про об'єкт класу Student
        public void PrintStudent()
        {
            base.Print();
            Console.WriteLine($"numbID: {numbId}");
            Console.WriteLine($"group: {group}");
        }
    }
}
