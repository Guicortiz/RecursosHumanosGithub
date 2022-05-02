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
    public partial class GithubView : Form,IGithubView
    {
        public GithubView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnGithub.Click += delegate {
                OpenBrosew?.Invoke(this, EventArgs.Empty);
            };
        }

        public void SetEmployeeListBindingSource(BindingSource githubList)
        {
            dgvGithubs.DataSource = githubList;
        }

        public event EventHandler OpenBrosew;

        private static GithubView instance;
        public static GithubView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new GithubView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
