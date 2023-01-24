namespace SalaryOrganizer
{
    partial class alterEmployee
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
            this.shopToAlter = new System.Windows.Forms.TextBox();
            this.surnameToAlter = new System.Windows.Forms.TextBox();
            this.cancelAlterEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.alterEmployeeBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shopToAlter);
            this.groupBox1.Controls.Add(this.surnameToAlter);
            this.groupBox1.Controls.Add(this.cancelAlterEmployee);
            this.groupBox1.Controls.Add(this.alterEmployeeBtn);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "введите данные";
            // 
            // shopToAlter
            // 
            this.shopToAlter.Location = new System.Drawing.Point(171, 59);
            this.shopToAlter.Name = "shopToAlter";
            this.shopToAlter.Size = new System.Drawing.Size(133, 23);
            this.shopToAlter.TabIndex = 7;
            // 
            // surnameToAlter
            // 
            this.surnameToAlter.Location = new System.Drawing.Point(171, 25);
            this.surnameToAlter.Name = "surnameToAlter";
            this.surnameToAlter.Size = new System.Drawing.Size(133, 23);
            this.surnameToAlter.TabIndex = 6;
            // 
            // cancelAlterEmployee
            // 
            this.cancelAlterEmployee.Depth = 0;
            this.cancelAlterEmployee.Location = new System.Drawing.Point(171, 99);
            this.cancelAlterEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelAlterEmployee.Name = "cancelAlterEmployee";
            this.cancelAlterEmployee.Primary = true;
            this.cancelAlterEmployee.Size = new System.Drawing.Size(133, 36);
            this.cancelAlterEmployee.TabIndex = 5;
            this.cancelAlterEmployee.Text = "отменить";
            this.cancelAlterEmployee.UseVisualStyleBackColor = true;
            this.cancelAlterEmployee.Click += new System.EventHandler(this.cancelAlterEmployee_Click);
            // 
            // alterEmployeeBtn
            // 
            this.alterEmployeeBtn.Depth = 0;
            this.alterEmployeeBtn.Location = new System.Drawing.Point(10, 99);
            this.alterEmployeeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.alterEmployeeBtn.Name = "alterEmployeeBtn";
            this.alterEmployeeBtn.Primary = true;
            this.alterEmployeeBtn.Size = new System.Drawing.Size(133, 36);
            this.alterEmployeeBtn.TabIndex = 4;
            this.alterEmployeeBtn.Text = "обновить";
            this.alterEmployeeBtn.UseVisualStyleBackColor = true;
            this.alterEmployeeBtn.Click += new System.EventHandler(this.alterEmployeeBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 63);
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
            this.materialLabel1.Location = new System.Drawing.Point(6, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Фамилия";
            // 
            // alterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 241);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(343, 241);
            this.MinimumSize = new System.Drawing.Size(343, 241);
            this.Name = "alterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить данные сотрудника";
            this.Load += new System.EventHandler(this.alterEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox shopToAlter;
        private System.Windows.Forms.TextBox surnameToAlter;
        private MaterialSkin.Controls.MaterialRaisedButton cancelAlterEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton alterEmployeeBtn;
    }
}