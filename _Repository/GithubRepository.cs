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
    public class GithubRepository : BaseRepository, IGithubRepository
    {
        public GithubRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(Github github)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"insert into Employee_Github 
                        values (@EmployeeId,@Login,@Githubid,@Url,@Type,@Name,@Company,@Blog,@Location
                       ,@Email,@Bio,@PublicRepos,@Followers,@Following,@CreatedAt,@UpdatedAt)";
                command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = github.EmployeeId;
                command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = github.Login;
                command.Parameters.Add("@Githubid", SqlDbType.Int).Value = github.Githubid;
                command.Parameters.Add("@Url", SqlDbType.NVarChar).Value = github.Url;
                command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = github.Type;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = github.Name;
                command.Parameters.Add("@Company", SqlDbType.NVarChar).Value = github.Company;
                command.Parameters.Add("@Blog", SqlDbType.NVarChar).Value = github.Blog;
                command.Parameters.Add("@Location", SqlDbType.NVarChar).Value = github.Location;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = github.Email;
                command.Parameters.Add("@Bio", SqlDbType.NVarChar).Value = github.Bio;
                command.Parameters.Add("@PublicRepos", SqlDbType.Int).Value = github.PublicRepos;
                command.Parameters.Add("@Followers", SqlDbType.Int).Value = github.Followers;
                command.Parameters.Add("@Following", SqlDbType.Int).Value = github.Following;
                command.Parameters.Add("@CreatedAt", SqlDbType.Date).Value = github.CreatedAt;
                command.Parameters.Add("@UpdatedAt", SqlDbType.Date).Value = github.UpdatedAt;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Github> GetAll()
        {
            var githubList = new List<Github>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from Employee_github";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var github = new Github();
                        github.Id = (int)reader[0];
                        github.EmployeeId = (int)reader[1];
                        github.Login = reader[2].ToString();
                        github.Githubid = (int)reader[3];
                        github.Url = reader[4].ToString();
                        github.Type = reader[5].ToString();
                        github.Name = reader[6].ToString();
                        github.Company = reader[7].ToString();
                        github.Blog = reader[8].ToString();
                        github.Location = reader[9].ToString();
                        github.Email = reader[10].ToString();
                        github.Bio = reader[11].ToString();
                        github.PublicRepos = (int)reader[12];
                        github.Followers = (int)reader[13];
                        github.Following = (int)reader[14];
                        github.CreatedAt = (DateTime)reader[15];
                        github.UpdatedAt = (DateTime)reader[16];
                        githubList.Add(github);
                    }
                };
            }

            return githubList;
        }
    }
}
