using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanosGithub.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnEmployee.Click += delegate { ShowEmployeeView?.Invoke(this, EventArgs.Empty); };
            btnGithubs.Click += delegate { ShowGithubView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowEmployeeView;
        public event EventHandler ShowGithubView;
    }
}
