using HW3August.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3August.Data
{
    internal class AppDbContest
    {
        public Employee[] GetAllEmployee()
        {
            Employee emp1 = new()
            {
                id= 1,
                fullName = "Sebine Agayeva",
                adress = "Nizami",
                age = 27,
                email = "sebine@code.edu.az"
            };

            Employee emp2 = new()
            {
                id= 2,
                fullName = "Reshad Xanmemmedli",
                adress = "Nesimi",
                age = 31,
                email = "resahd@code.edu.az"
            };

            Employee emp3 = new()
            {
                id= 3,
                fullName = "Ziya Sadiq",
                adress = "Sumqayit",
                age = 20,
                email = "ziya@code.edu.az"
            };

            Employee emp4 = new()
            {
                id= 4,
                fullName = "Nicat Orucov",
                adress = "Neftciler",
                age = 18,
                email = "nicat@code.edu.az"
            };

            Employee emp5 = new()
            {
                id = 5,
                fullName = "Gulay Mehreliyeva",
                adress = "Elmler",
                age = 18,
                email = "ziya@code.edu.az"
            };

            Employee emp6 = new()
            {
                id = 6,
                fullName = "Elnare Efendiyeva",
                adress = "Sumqayit",
                age = 19,
                email = "elnare@code.edu.az"
            };

            Employee emp7 = new()
            {
                id=7,
                fullName = "Nigar Qedirova",
                adress = "Nerimanov",
                age = 19,
                email = "nigar@code.edu.az"
            };

            Employee emp8 = new()
            {
                id =8,
                fullName = "Mehriban Bagizade",
                adress = "Suraxani",
                age = 19,
                email = "mehriban@code.edu.az"
            };

            Employee emp9 = new()
            {
                id = 9,    
                fullName = "Kutaisi Ismayilova",
                adress = "Zerdab",
                age = 26,
                email = "kutaisi@code.edu.az"
            };

            Employee[] employees = { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9 };
            return employees;
        }
    }
}
