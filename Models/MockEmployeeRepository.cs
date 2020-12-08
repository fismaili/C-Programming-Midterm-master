using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexDataModel.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;
        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee(){Id=4,Name="Merxhivan Ismaili",Email="m.ismaili@seeu.edu.mk",Department="CST"},
                new Employee(){Id=5,Name="Deshira Imeri",Email="d.imeri@seeu.edu.mk",Department="CST"},
                new Employee(){Id=6,Name="Xhemal Zenuni",Email="xh.zenuni@seeu.edu.mk",Department="CST"}
            };

        }
        public Employee GetEmployee(int Id)
        {
            return this.employeeList.FirstOrDefault(e => e.Id == Id);

        }

        public IEnumerable<Employee> GetEmployees()
        {
           return  this.employeeList;
        }
    }
}
