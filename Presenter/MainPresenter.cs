using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecursosHumanosGithub.View;
using RecursosHumanosGithub.Model;
using RecursosHumanosGithub._Repository;

namespace RecursosHumanosGithub.Presenter
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.ShowEmployeeView += ShowEmployeeView;
            this._mainView.ShowGithubView += ShowGithubView;
        }

        private void ShowGithubView(object sender, EventArgs e)
        {
            IGithubView view = GithubView.GetInstance((MainView)_mainView);
            IGithubRepository githubRepository = new GithubRepository(sqlConnectionString);
            new GithubPresenter(githubRepository, view);
        }

        private void ShowEmployeeView(object sender, EventArgs e)
        {
            IEmployeeView view = EmployeeView.GetInstance((MainView)_mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            IGithubRepository githubRepository = new GithubRepository(sqlConnectionString);
            new EmployeePresenter(repository,githubRepository, view);
        }
    }
}
