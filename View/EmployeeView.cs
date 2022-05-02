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
    public partial class EmployeeView : Form, IEmployeeView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tCEmployeeView.TabPages.Remove(tabpEmployeeDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click+= delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            tbSearch.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);
              };
            btnAdd.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tCEmployeeView.TabPages.Remove(tabPEmployeeList);
                tCEmployeeView.TabPages.Add(tabpEmployeeDetail);
                tabpEmployeeDetail.Text = "Adicionar Funcionario";
            };
            btnEdit.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tCEmployeeView.TabPages.Remove(tabPEmployeeList);
                tCEmployeeView.TabPages.Add(tabpEmployeeDetail);
                tabpEmployeeDetail.Text = "Editar Funcionario";
            };
            btnSave.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tCEmployeeView.TabPages.Remove(tabpEmployeeDetail);
                    tCEmployeeView.TabPages.Add(tabPEmployeeList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tCEmployeeView.TabPages.Remove(tabpEmployeeDetail);
                tCEmployeeView.TabPages.Add(tabPEmployeeList);
            };
            btnDel.Click += delegate { 
                var result = MessageBox.Show("Você tem certeza que quer deletar esse registro selecionado?","Atenção",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnGetGit.Click += delegate
            {
                GetGithubApi?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
        }

        public string EmployeeId
        {
            get { return tbID.Text; }
            set { tbID.Text = value; }
        }

        public string EmployeeName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string EmployeeGithub
        {
            get { return tbGithub.Text; }
            set { tbGithub.Text = value; }
        }
        public string EmployeeLinkedin
        {
            get { return tbLinkedin.Text; }
            set { tbLinkedin.Text = value; }
        }
        public string EmployeeFone
        {
            get { return tbFone.Text; }
            set { tbFone.Text = value; }
        }
        public DateTime EmployeeBirthDay
        {
            get { return dtBirthday.Value; }
            set { dtBirthday.Value = value; }
        }
        public string SearchValue { 
            get { return tbSearch.Text; } 
            set { tbSearch.Text = value; }
        }
        public bool IsEdit { 
            get { return isEdit; }
            set { isEdit = value; } 
        }
        public bool IsSuccessful { 
            get { return isSuccessful; } 
            set { isSuccessful = value; }
        }
        public string Message { 
            get { return message; } 
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler GetGithubApi;

        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            dgvEmployee.DataSource = employeeList;
        }

        private static EmployeeView instance;
        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed) 
            { 
                instance = new EmployeeView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock= DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
