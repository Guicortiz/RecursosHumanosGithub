using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecursosHumanosGithub.Model;

namespace RecursosHumanosGithub._Repository
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(Employee employee)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Employee values (@name,@github,@linkedin,@fone,@birthday,GETDATE(),null)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                command.Parameters.Add("@github", SqlDbType.NVarChar).Value = employee.Github;
                command.Parameters.Add("@linkedin", SqlDbType.NVarChar).Value = employee.Linkedin;
                command.Parameters.Add("@fone", SqlDbType.NVarChar).Value = employee.Fone;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = employee.BirthDay;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Employee where pk_int_Employee=@id";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Employee employee)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Employee 
                                        set str_Name=@name,
                                        str_Github=@github,
                                        str_linkedin=@linkedin,
                                        str_Fone=@fone,
                                        dt_Birthday=@birthday,
                                        dt_UpdatedAt=Getdate()
                                        where pk_int_Employee=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                command.Parameters.Add("@github", SqlDbType.NVarChar).Value = employee.Github;
                command.Parameters.Add("@linkedin", SqlDbType.NVarChar).Value = employee.Linkedin;
                command.Parameters.Add("@fone", SqlDbType.NVarChar).Value = employee.Fone;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = employee.BirthDay;
                command.Parameters.Add("@id", SqlDbType.Int).Value = employee.id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var employeeList = new List<Employee>();
            using(var connection=new SqlConnection(connectionString))
            using(var command=new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT pk_int_Employee,str_Name,str_Github,str_linkedin,str_Fone,dt_Birthday FROM Employee";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employee= new Employee();
                        employee.id = (int)reader[0];
                        employee.Name = reader[1].ToString();
                        employee.Github = reader[2].ToString();
                        employee.Linkedin = reader[3].ToString();
                        employee.Fone = reader[4].ToString();
                        employee.BirthDay = (DateTime)reader[5];
                        employeeList.Add(employee);
                    }
                } ;
            }

            return employeeList;
        }

        public IEnumerable<Employee> GetByValue(string value)
        {
            var employeeList = new List<Employee>();
            var employeeId = int.TryParse(value,out _) ? Convert.ToInt32(value) : 0;
            string employeeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT pk_int_Employee,str_Name,str_Github,str_linkedin,str_Fone,dt_Birthday FROM Employee
                                        where pk_int_Employee=@id or str_Name like @name+'%'";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.id = (int)reader[0];
                        employee.Name = reader[1].ToString();
                        employee.Github = reader[2].ToString();
                        employee.Linkedin = reader[3].ToString();
                        employee.Fone = reader[4].ToString();
                        employee.BirthDay = (DateTime)reader[5];
                        employeeList.Add(employee);
                    }
                };
            }

            return employeeList;
        }
    }
}
