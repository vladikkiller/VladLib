namespace VladLib
{
    //Реалізація класу People
    public class People
    {
        //Опис атрибутів класу People
        private int age { get; set; }
        private string sex { get; set; }
        private double height { get; set; }
        private double weight { get; set; }
        private string national { get; set; }
        private string creed { get; set; }
        private string profession { get; set; }
        private int passportId { get; set; }
        //Параметризований конструктор класу People
        public People(int age,
            string sex,
            double height,
            double weight,
            string national,
            string creed,
            string profession,
            int passportId)
        {
            this.age = age;
            this.sex = sex;
            this.height = height;
            this.weight = weight;
            this.national = national;
            this.creed = creed;
            this.profession = profession;
            this.passportId = passportId;
        }
        //Метод для визначення індекса маси тіла людини
        public void indexImt()
        {
            double imt;
            imt = weight/Math.Pow(height, 2);
            Console.WriteLine($"IMT: {imt}");
        }
        //Метод для виводу інформації про об'єкт класу People
        public void Print()
        {
            Console.WriteLine($"age: {age} y. o.");
            Console.WriteLine($"sex: {sex}");
            Console.WriteLine($"height: {height}m");
            Console.WriteLine($"weight: {weight}kg");
            Console.WriteLine($"national: {national}");
            Console.WriteLine($"creed: {creed}");
            Console.WriteLine($"profession: {profession}");
            Console.WriteLine($"passportId: {passportId}");
        }
    }
}