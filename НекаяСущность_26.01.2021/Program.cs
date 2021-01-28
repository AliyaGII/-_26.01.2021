using System;

namespace НекаяСущность_26._01._2021
{
    class Cat
    {
        public string name; 
        public int age;
        public string breed;
        public string color_fur;
        public string action1;
        public string action2;

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: { age}"); 
            Console.WriteLine($"Цвет шерсти: { color_fur}"); 
            Console.WriteLine($"Порода : {breed}");
            Console.WriteLine($"Любимое занятие: {action1}");
            Console.WriteLine($"Не самое любимое занятие: {action2} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat tayson = new Cat();
            tayson.name = "Тайсон";
            tayson.age = 7;
            tayson.breed = "Шотландский вислоухий";
            tayson.color_fur = "Чёрный";
            tayson.action1 = "Просить кушать";
            tayson.action2 = "Купаться";
            tayson.GetInfo(); 
            Console.ReadKey();
        }
    }
}
