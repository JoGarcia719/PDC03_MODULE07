using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using PDC03_MODULE07.Model;

using System.Threading.Tasks;

namespace PDC03_MODULE07.ViewModel
{
    public class EmployeeViewModel
    {

        //Call Database

        private Services.DatabaseContext GetContext()
        {
            return new Services.DatabaseContext();

        }

        //Insert Records

        public int InsertEmployee(EmployeeModel obj)
        {
            var _dbContext = GetContext();
            _dbContext.Employees.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;   
        }

        //Retrieve Records

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var _dbContext = GetContext();
            var res = await _dbContext.Employees.ToListAsync();
            return res;
        }

        //Delete Records

        public int DeleteEmployee(EmployeeModel obj)
        {
            var _dbContext = GetContext();
            _dbContext.Employees.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        //Update Records
        public async Task<int> UpdateEmployees(EmployeeModel obj)
        {
            var _dbContext = GetContext();
            _dbContext.Employees.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;
        }
    }
}
