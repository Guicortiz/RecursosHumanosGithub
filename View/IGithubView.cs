using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanosGithub.View
{
    public interface IGithubView
    {
		void SetEmployeeListBindingSource(BindingSource githubList);
		void Show();

		event EventHandler OpenBrosew;
	}
}
