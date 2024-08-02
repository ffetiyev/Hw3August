

namespace HW3August
{
    internal class Car
    {
        public string name;
        public string color;
        public int speed;

        public Car(string name):this(100)
        {
            Console.WriteLine(name);
        }
        public Car(int b)
        {
            Console.WriteLine(b);
            Console.WriteLine(b++);
        }
        public Car(int a,string b):this(b) 
        {
            Console.WriteLine("ctor3");
        }
    }
}
