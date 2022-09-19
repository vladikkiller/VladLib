using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladLib
{
    internal class Student : People
    {
        public int numbId { get; set; }
        public string group { get; set; }

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

        public void PrintStudents()
        {
            base.Print();
            Console.WriteLine($"numbID: {numbId}");
            Console.WriteLine($"group: {group}");
        }
    }
}
