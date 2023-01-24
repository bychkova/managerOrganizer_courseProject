namespace SalaryOrganizer
{
    partial class addEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newEmpSalary = new System.Windows.Forms.TextBox();
            this.newEmpShop = new System.Windows.Forms.TextBox();
            this.newEmpSurname = new System.Windows.Forms.TextBox();
            this.caancelAddEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addEmployeeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newEmpSalary);
            this.groupBox1.Controls.Add(this.newEmpShop);
            this.groupBox1.Controls.Add(this.newEmpSurname);
            this.groupBox1.Controls.Add(this.caancelAddEmployee);
            this.groupBox1.Controls.Add(this.addEmployeeBtn);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "введите данные";
            // 
            // newEmpSalary
            // 
            this.newEmpSalary.Location = new System.Drawing.Point(168, 109);
            this.newEmpSalary.Name = "newEmpSalary";
            this.newEmpSalary.Size = new System.Drawing.Size(132, 23);
            this.newEmpSalary.TabIndex = 7;
            // 
            // newEmpShop
            // 
            this.newEmpShop.Location = new System.Drawing.Point(167, 71);
            this.newEmpShop.Name = "newEmpShop";
            this.newEmpShop.Size = new System.Drawing.Size(133, 23);
            this.newEmpShop.TabIndex = 6;
            // 
            // newEmpSurname
            // 
            this.newEmpSurname.Location = new System.Drawing.Point(168, 29);
            this.newEmpSurname.Name = "newEmpSurname";
            this.newEmpSurname.Size = new System.Drawing.Size(132, 23);
            this.newEmpSurname.TabIndex = 5;
            // 
            // caancelAddEmployee
            // 
            this.caancelAddEmployee.Depth = 0;
            this.caancelAddEmployee.Location = new System.Drawing.Point(167, 149);
            this.caancelAddEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.caancelAddEmployee.Name = "caancelAddEmployee";
            this.caancelAddEmployee.Primary = true;
            this.caancelAddEmployee.Size = new System.Drawing.Size(133, 36);
            this.caancelAddEmployee.TabIndex = 4;
            this.caancelAddEmployee.Text = "отмена";
            this.caancelAddEmployee.UseVisualStyleBackColor = true;
            this.caancelAddEmployee.Click += new System.EventHandler(this.caancelAddEmployee_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Depth = 0;
            this.addEmployeeBtn.Location = new System.Drawing.Point(15, 149);
            this.addEmployeeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Primary = true;
            this.addEmployeeBtn.Size = new System.Drawing.Size(133, 36);
            this.addEmployeeBtn.TabIndex = 3;
            this.addEmployeeBtn.Text = "добавить";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 112);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(136, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Заработная плата";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 71);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Номер цеха";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Фамилия";
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 294);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(343, 294);
            this.MinimumSize = new System.Drawing.Size(343, 294);
            this.Name = "addEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "новый сотрудник";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newEmpSalary;
        private System.Windows.Forms.TextBox newEmpShop;
        private System.Windows.Forms.TextBox newEmpSurname;
        private MaterialSkin.Controls.MaterialRaisedButton caancelAddEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton addEmployeeBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}