using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanosGithub.Model
{
    public interface IGithubRepository
    {
        void Add(Github github);
        IEnumerable<Github> GetAll();
    }
}
// colocando aqui pra testar
//
