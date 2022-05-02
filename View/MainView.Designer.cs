namespace RecursosHumanosGithub.View
{
    partial class MainView
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnGithubs = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnGithubs);
            this.pMenu.Controls.Add(this.BtnEmployee);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(85, 309);
            this.pMenu.TabIndex = 0;
            // 
            // btnGithubs
            // 
            this.btnGithubs.Location = new System.Drawing.Point(0, 29);
            this.btnGithubs.Name = "btnGithubs";
            this.btnGithubs.Size = new System.Drawing.Size(85, 23);
            this.btnGithubs.TabIndex = 1;
            this.btnGithubs.Text = "Githubs";
            this.btnGithubs.UseVisualStyleBackColor = true;
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Location = new System.Drawing.Point(0, 0);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(85, 23);
            this.BtnEmployee.TabIndex = 0;
            this.BtnEmployee.Text = "Funcionarios";
            this.BtnEmployee.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 309);
            this.Controls.Add(this.pMenu);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Recursos Humanos Github";
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnGithubs;
        private System.Windows.Forms.Button BtnEmployee;
    }
}