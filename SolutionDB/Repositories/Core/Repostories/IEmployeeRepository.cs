using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Repostories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        List<Employee> EmployeesWithProjects();
        
    }
}
