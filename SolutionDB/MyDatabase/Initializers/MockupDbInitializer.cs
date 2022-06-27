using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    public class MockupDbInitializer : DropCreateDatabaseAlways<MyDBContext>
    {


        protected override void Seed(MyDBContext context)
        {

            Manager m1 = new Manager() { FirstName = "George", LastName = "Pasparakis" };
            Manager m2 = new Manager() { FirstName = "Hector", LastName = "Gatsos" };
            Manager m3 = new Manager() { FirstName = "Periklis", LastName = "Aidinopoylos" };
            Manager m4 = new Manager() { FirstName = "Bozas", LastName = "Panagiotis" };

            context.Managers.AddOrUpdate(x => new { x.FirstName, x.LastName }, m1, m2, m3, m4);


            Project p1 = new Project() { ProjectName = "C#" };
            Project p2 = new Project() { ProjectName = "Java" };
            Project p3 = new Project() { ProjectName = "Javascript" };
            Project p4 = new Project() { ProjectName = "Python" };

            context.Projects.AddOrUpdate(x => x.ProjectName, p1, p2, p3, p4);

            Employee e1 = new Employee() { FirstName = "Spyros", LastName = "Tomaras", Project = p1 };
            Employee e2 = new Employee() { FirstName = "Agathi", LastName = "Tomaras", Project = p2 };
            Employee e3 = new Employee() { FirstName = "Eleni", LastName = "Nikoaloy" };
            Employee e4 = new Employee() { FirstName = "Vaggelis", LastName = "Kallifonis" };
            Employee e5 = new Employee() { FirstName = "Kostas", LastName = "Tomaras" };
            Employee e6 = new Employee() { FirstName = "Xristos", LastName = "Papanikolaoy", Project = p4 };
            e1.Managers = new List<Manager>() { m1, m2 };
            e2.Managers = new List<Manager>() { m1, m2, m3 };
            e3.Managers = new List<Manager>() { m3, m2 };
            e4.Managers = new List<Manager>() { m1, m2, m4 };
            e5.Managers = new List<Manager>() { m1, m3 };
            e6.Managers = new List<Manager>() {  };
            

            context.Employees.AddOrUpdate(x => x.FirstName, e1, e2, e3, e4, e5, e6);
            base.Seed(context);
        }
    }
}
