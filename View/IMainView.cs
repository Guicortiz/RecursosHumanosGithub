using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanosGithub.View
{
    public interface IMainView
    {
        event EventHandler ShowEmployeeView;
        event EventHandler ShowGithubView;
    }
}
