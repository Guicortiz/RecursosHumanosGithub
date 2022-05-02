using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanosGithub.Model;
using RecursosHumanosGithub.View;
using RecursosHumanosGithub.DTOs;
using RestSharp;

namespace RecursosHumanosGithub.Presenter
{
    public class EmployeePresenter
    {
        private IEmployeeRepository repository;
        private IGithubRepository _githubRepository;
        private IEmployeeView view;
        private BindingSource employeeBindingSource;
        private IEnumerable<Employee> employeeList;

        public EmployeePresenter(IEmployeeRepository employeeRepository,IGithubRepository githubRepository, IEmployeeView employeeView)
        {
            this.employeeBindingSource = new BindingSource();
            this.repository = employeeRepository;
            this._githubRepository = githubRepository;
            this.view = employeeView;
            this.view.SearchEvent += SearchEmployee;
            this.view.AddNewEvent += AddNewEmployee;
            this.view.EditEvent += LoadSelectedEmployeeToEdit;
            this.view.DeleteEvent += DeleteSelectedEmployee;
            this.view.GetGithubApi += GetGitHubApi;
            this.view.SaveEvent += SaveEmployee;
            this.view.CancelEvent += CancelAction;
            this.view.SetEmployeeListBindingSource(employeeBindingSource);
            LoadAllEmployees();
            this.view.Show();

        }

        private async void GetGitHubApi(object sender, EventArgs e)
        {
            var employee = (Employee)employeeBindingSource.Current;
            
            RestClient restClient = new RestClient(String.Format("https://api.github.com/users/{0}", employee.Github))
                            .AddDefaultHeader(KnownHeaders.Accept, "application/vnd.github.v3+json");

            var request = new RestRequest();

            var response = await restClient.GetAsync<dtoReturnGithub>(request);

            var model = new Github();
            model.EmployeeId = employee.id;
            model.Login = response.login;
            model.Githubid = response.id;
            model.Url = response.html_url;
            model.Type = response.type;
            model.Name = response.name;
            model.Company = response.company = "";
            model.Blog = response.blog;
            model.Location = response.location;
            model.Email = response.email = "";
            model.Bio = response.bio = "";
            model.PublicRepos = response.public_repos;
            model.Followers = response.followers;
            model.Following = response.following;
            model.CreatedAt = response.created_at;
            model.UpdatedAt = response.updated_at;

            try
            {
                _githubRepository.Add(model);
                view.Message = "Github atualizado com sucesso";
                view.IsSuccessful = true;
                LoadAllEmployees();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
        }
        private void LoadAllEmployees()
        {
            employeeList = repository.GetAll();
            employeeBindingSource.DataSource = employeeList;
        }

        private void SearchEmployee(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                employeeList = repository.GetByValue(this.view.SearchValue);
            else employeeList = repository.GetAll();
            employeeBindingSource.DataSource = employeeList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            var model = new Employee();
            model.id = Convert.ToInt32(view.EmployeeId);
            model.Name = view.EmployeeName;
            model.Github = view.EmployeeGithub;
            model.Linkedin = view.EmployeeLinkedin;
            model.Fone = view.EmployeeFone;
            model.BirthDay = view.EmployeeBirthDay;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Funcionario editado com sucesso";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Funcionario adicionado com sucesso";
                }
                view.IsSuccessful = true;
                LoadAllEmployees();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.EmployeeId = "0";
            view.EmployeeName = "";
            view.EmployeeGithub = "";
            view.EmployeeLinkedin = "";
            view.EmployeeFone = "";
            view.EmployeeBirthDay = DateTime.Now;
        }

        private void DeleteSelectedEmployee(object sender, EventArgs e)
        {
            try
            {
                var employee = (Employee)employeeBindingSource.Current;
                repository.Delete(employee.id);
                view.IsSuccessful = true;
                view.Message = "Funcionario Deletado com sucesso";
                LoadAllEmployees();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message= "Um erro ocorreu, você não pode deletar este funcionario!";
            }
        }

        private void LoadSelectedEmployeeToEdit(object sender, EventArgs e)
        {
            var employee = (Employee)employeeBindingSource.Current;
            view.EmployeeId = employee.id.ToString();
            view.EmployeeName = employee.Name.ToString();
            view.EmployeeGithub = employee.Github.ToString();
            view.EmployeeLinkedin = employee.Linkedin.ToString();
            view.EmployeeFone = employee.Fone.ToString();
            view.EmployeeBirthDay = employee.BirthDay;
            view.IsEdit = true;
        }

        private void AddNewEmployee(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }



       
    }
}
