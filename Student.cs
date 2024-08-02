
namespace HW3August
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullData()
        {
            return $"name:{name}, surname:{surname}, age:{age}";
        }

    }
}
