using System;

namespace test_obj
{
    class student
    {
        public int age;
        public int id;
        public string name;
    }




   class school
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            student s = new student();
            s.age = 21;
            s.id = 206;
            s.name = "bhavya";
            Console.WriteLine(s.age);
            Console.WriteLine(s.name);
            Console.WriteLine(s.id);
            student a = new student();
            a.age = 22;
            a.id = 102;
            a.name = "nitish";
            Console.WriteLine(a.age);
            Console.WriteLine(a.name);
            Console.WriteLine(a.id);


        }

    }
   
}
