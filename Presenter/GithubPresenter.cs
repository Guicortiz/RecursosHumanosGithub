using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecursosHumanosGithub.Model;
using RecursosHumanosGithub.View;
using RecursosHumanosGithub.DTOs;

namespace RecursosHumanosGithub.Presenter
{
    public class GithubPresenter
    {
        private IGithubRepository repository;
        private IGithubView view;
        private BindingSource githubBindingSource;
        private IEnumerable<Github> githubList;

        public GithubPresenter(IGithubRepository githubRepository, IGithubView githubView)
        {
            this.githubBindingSource = new BindingSource();
            this.repository = githubRepository;
            this.view = githubView;
            this.view.SetEmployeeListBindingSource(githubBindingSource);
            this.view.OpenBrosew += OpenBrosew;
            LoadAllEmployees();
            this.view.Show();

        }

        private void OpenBrosew(object sender, EventArgs e)
        {
            var github = (Github)githubBindingSource.Current;
            System.Diagnostics.Process.Start(github.Url);
        }

        private void LoadAllEmployees()
        {
            githubList = repository.GetAll();
            githubBindingSource.DataSource = githubList;
        }                         
    }
}
