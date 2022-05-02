namespace RecursosHumanosGithub.View
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tCEmployeeView = new System.Windows.Forms.TabControl();
            this.tabPEmployeeList = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.tabpEmployeeDetail = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.tbFone = new System.Windows.Forms.TextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.tbLinkedin = new System.Windows.Forms.TextBox();
            this.lblLinkedin = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbGithub = new System.Windows.Forms.TextBox();
            this.lblGithub = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGetGit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tCEmployeeView.SuspendLayout();
            this.tabPEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabpEmployeeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Funcionarios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(600, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tCEmployeeView
            // 
            this.tCEmployeeView.Controls.Add(this.tabPEmployeeList);
            this.tCEmployeeView.Controls.Add(this.tabpEmployeeDetail);
            this.tCEmployeeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCEmployeeView.Location = new System.Drawing.Point(0, 43);
            this.tCEmployeeView.Name = "tCEmployeeView";
            this.tCEmployeeView.SelectedIndex = 0;
            this.tCEmployeeView.Size = new System.Drawing.Size(682, 301);
            this.tCEmployeeView.TabIndex = 2;
            // 
            // tabPEmployeeList
            // 
            this.tabPEmployeeList.Controls.Add(this.btnGetGit);
            this.tabPEmployeeList.Controls.Add(this.dgvEmployee);
            this.tabPEmployeeList.Controls.Add(this.btnSearch);
            this.tabPEmployeeList.Controls.Add(this.btnDel);
            this.tabPEmployeeList.Controls.Add(this.btnEdit);
            this.tabPEmployeeList.Controls.Add(this.btnAdd);
            this.tabPEmployeeList.Controls.Add(this.tbSearch);
            this.tabPEmployeeList.Controls.Add(this.lblSearchEmployee);
            this.tabPEmployeeList.Location = new System.Drawing.Point(4, 22);
            this.tabPEmployeeList.Name = "tabPEmployeeList";
            this.tabPEmployeeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPEmployeeList.Size = new System.Drawing.Size(674, 275);
            this.tabPEmployeeList.TabIndex = 0;
            this.tabPEmployeeList.Text = "Lista Funcionarios";
            this.tabPEmployeeList.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(6, 46);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(588, 223);
            this.dgvEmployee.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(519, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(596, 104);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(596, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(596, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(6, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(507, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Location = new System.Drawing.Point(3, 3);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(105, 13);
            this.lblSearchEmployee.TabIndex = 0;
            this.lblSearchEmployee.Text = "Procurar funcionario:";
            // 
            // tabpEmployeeDetail
            // 
            this.tabpEmployeeDetail.Controls.Add(this.btnSave);
            this.tabpEmployeeDetail.Controls.Add(this.btnCancel);
            this.tabpEmployeeDetail.Controls.Add(this.dtBirthday);
            this.tabpEmployeeDetail.Controls.Add(this.lblBirthday);
            this.tabpEmployeeDetail.Controls.Add(this.tbFone);
            this.tabpEmployeeDetail.Controls.Add(this.lblFone);
            this.tabpEmployeeDetail.Controls.Add(this.tbLinkedin);
            this.tabpEmployeeDetail.Controls.Add(this.lblLinkedin);
            this.tabpEmployeeDetail.Controls.Add(this.tbName);
            this.tabpEmployeeDetail.Controls.Add(this.lblName);
            this.tabpEmployeeDetail.Controls.Add(this.tbGithub);
            this.tabpEmployeeDetail.Controls.Add(this.lblGithub);
            this.tabpEmployeeDetail.Controls.Add(this.tbID);
            this.tabpEmployeeDetail.Controls.Add(this.lblId);
            this.tabpEmployeeDetail.Location = new System.Drawing.Point(4, 22);
            this.tabpEmployeeDetail.Name = "tabpEmployeeDetail";
            this.tabpEmployeeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabpEmployeeDetail.Size = new System.Drawing.Size(674, 275);
            this.tabpEmployeeDetail.TabIndex = 1;
            this.tabpEmployeeDetail.Text = "Detalhes Funcionario";
            this.tabpEmployeeDetail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(92, 176);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(256, 20);
            this.dtBirthday.TabIndex = 6;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(10, 176);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(59, 13);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "Aniversario";
            // 
            // tbFone
            // 
            this.tbFone.Location = new System.Drawing.Point(92, 144);
            this.tbFone.Name = "tbFone";
            this.tbFone.Size = new System.Drawing.Size(100, 20);
            this.tbFone.TabIndex = 5;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(10, 147);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 8;
            this.lblFone.Text = "Fone";
            // 
            // tbLinkedin
            // 
            this.tbLinkedin.Location = new System.Drawing.Point(92, 115);
            this.tbLinkedin.Name = "tbLinkedin";
            this.tbLinkedin.Size = new System.Drawing.Size(100, 20);
            this.tbLinkedin.TabIndex = 4;
            // 
            // lblLinkedin
            // 
            this.lblLinkedin.AutoSize = true;
            this.lblLinkedin.Location = new System.Drawing.Point(10, 118);
            this.lblLinkedin.Name = "lblLinkedin";
            this.lblLinkedin.Size = new System.Drawing.Size(47, 13);
            this.lblLinkedin.TabIndex = 6;
            this.lblLinkedin.Text = "Linkedin";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nome";
            // 
            // tbGithub
            // 
            this.tbGithub.Location = new System.Drawing.Point(92, 85);
            this.tbGithub.Name = "tbGithub";
            this.tbGithub.Size = new System.Drawing.Size(100, 20);
            this.tbGithub.TabIndex = 3;
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Location = new System.Drawing.Point(10, 88);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(38, 13);
            this.lblGithub.TabIndex = 2;
            this.lblGithub.Text = "Github";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(92, 27);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 1;
            this.tbID.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // btnGetGit
            // 
            this.btnGetGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetGit.Location = new System.Drawing.Point(596, 246);
            this.btnGetGit.Name = "btnGetGit";
            this.btnGetGit.Size = new System.Drawing.Size(75, 23);
            this.btnGetGit.TabIndex = 8;
            this.btnGetGit.Text = "Github";
            this.btnGetGit.UseVisualStyleBackColor = true;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 344);
            this.Controls.Add(this.tCEmployeeView);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tCEmployeeView.ResumeLayout(false);
            this.tabPEmployeeList.ResumeLayout(false);
            this.tabPEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabpEmployeeDetail.ResumeLayout(false);
            this.tabpEmployeeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tCEmployeeView;
        private System.Windows.Forms.TabPage tabPEmployeeList;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.TabPage tabpEmployeeDetail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbLinkedin;
        private System.Windows.Forms.Label lblLinkedin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbGithub;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox tbFone;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetGit;
    }
}