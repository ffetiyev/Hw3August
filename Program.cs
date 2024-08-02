
#region HWPracticeOfLastLesson
//static string[] Search(string[] students,string pattern) => Array.FindAll(students, m => m.Contains(pattern));

//foreach (string item in Search(new string[] { "cemil", "arif", "zubeyde", "gulnar", "celal" },"c"))
//{
//    Console.WriteLine(item);
//}

//static bool ExistData(string[] students,string pattern)
//{
//    var data = Array.Find(students, m => m == pattern);

//    if (data == null)
//         return false; 

//    return true;

//}


//var exist= ExistData(new string[] { "cemil", "arif", "zubeyde", "gulnar", "celal" },"celal");

//Console.WriteLine(exist);


//string[] datas = { "cemil", "arif", "zubeyde", "gulnar", "celal" };

//var result = datas.OrderBy(m => m);
//var result = datas.OrderByDescending(m => m);
//var result = datas.Where(m => m.Contains("c")).ToArray();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//var stu1 = new
//{
//    name = "Nizami",
//    surname = "Tagiyev",
//    age = 18
//};

//var stu2 = new
//{
//    name = "Ferid",
//    surname = "Fetiyev",
//    age = 21
//};

//var stu3 = new
//{
//    name = "Turan",
//    surname = "Muradov",
//    age = 21
//};

//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age);



//using HW3August;

//Student stu1 = new Student()
//{ 
//stu1.name = "Nizami",
//stu1.surname = "Tagiyev",
//stu1.age = 18
//};


//Student stu2 = new() 
//{ 
//    name = "Ferid",
//    surname = "Fetiyev",
//    age = 21,
//};

//Student stu3 = new()
//{
//    name = "Oruc",
//    surname = "Novruzov",
//    age = 21,
//};

//Student[] students =  { stu1, stu2, stu3 };

//for (int i = 0; i < students.Length; i++)
//{
//   Console.WriteLine(students[i].name + " " + students[i].surname + " " + students[i].age);
//   Console.WriteLine($"{ students[i].name} {students[i].surname}-{students[i].age}");
//}

//using HW3August;

//Student stu1 = new Student()
//{
//    name = "Nizami",
//    surname = "Tagiyev",
//    age = 18
//};


//Student stu2 = new()
//{
//    name = "Ferid",
//    surname = "Fatiyev",
//    age = 21,
//};

//Student stu3 = new()
//{
//    name = "Oruc",
//    surname = "Novruzov",
//    age = 21,
//};

//Student[] students = new Student[] { stu1, stu2, stu3 };

//foreach (Student item in students)
//{
//    Console.WriteLine(item.GetFullData());
//}


//static void Search(Student[] studentss, string searchText)
//{
//    var datas=Array.FindAll(studentss,m=>m.name.Contains(searchText) || m.surname.Contains(searchText));
//    foreach(Student item in datas)
//    {
//        Console.WriteLine(item.GetFullData());
//    }
//}
//Search(students, "a");


//using HW3August;

//Book book = new Book("C#","Ferid",DateTime.Now);
//Console.WriteLine(book.name + " " + book.author + " " + book.date);

//Car car = new Car(5,"");

//using HW3August;
//using HW3August.Data;
//using HW3August.Services;


//EmployeeService service=new EmployeeService();

////service.GetAll();
//service.GetById(10);










#endregion


#region Hw3August

// 1. Account adinda class yaradib, onun icinde Login methodu yazin. Hemin login methoduna username ve password
// gelecek. Username cavid123 ve password Cavid1993 -e beraberdirse ekrana giriw ugurludur yazilsin,
// eks halda email ve ya password sehvdir cixsin.

//using HW3August;

//Account account1= new Account();


//var checking = account1.Login("cavid123", "Cavid1993");

//Console.WriteLine(checking);


//2.Factorial adinda class yaradin , hemin clasin icinde reqem qebul edib hemin reqemin
//factorialini hesablayan method yazin.

//using HW3August;

//Factorial factorial = new Factorial();

//var fact1 = factorial.GetFactorialOfNumber(5);

//Console.WriteLine(fact1);

//3. Calculator adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.
//Reqemler ve operstorlar console-dan daxil edilmelidir.

using HW3August;


Calculator calculator = new Calculator();

calculator.Calculation(Console.ReadLine();



#endregion