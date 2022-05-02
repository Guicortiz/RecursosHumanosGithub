using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanosGithub.Model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Edit(Employee employee);
        void Delete(int id);
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetByValue(string value);
    }
}
