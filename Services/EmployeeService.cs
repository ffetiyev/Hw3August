using HW3August.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3August.Services
{
    internal class EmployeeService
    {
        public void GetAll()
        {
            AppDbContest context = new AppDbContest();
            var datas = context.GetAllEmployee();

            foreach (var item in datas)
            {
                Console.WriteLine(item.fullName + " " + item.email);
            }
        }

        public void GetById(int id)
        {
            AppDbContest context = new AppDbContest();
            var datas = context.GetAllEmployee();
            var data=datas.FirstOrDefault(m=>m.id == id);
            Console.WriteLine(data.fullName + " " + data.email);

        }
    }
}
