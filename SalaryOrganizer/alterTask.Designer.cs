namespace SalaryOrganizer
{
    partial class alterTask
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
            this.alterTaskBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.alterDate = new System.Windows.Forms.DateTimePicker();
            this.alterHour = new System.Windows.Forms.ComboBox();
            this.alterMinutes = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.alterDescription = new System.Windows.Forms.RichTextBox();
            this.canceAlterTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.canceAlterTask);
            this.groupBox1.Controls.Add(this.alterDescription);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.alterMinutes);
            this.groupBox1.Controls.Add(this.alterHour);
            this.groupBox1.Controls.Add(this.alterDate);
            this.groupBox1.Controls.Add(this.alterTaskBtn);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "введите данные";
            // 
            // alterTaskBtn
            // 
            this.alterTaskBtn.Depth = 0;
            this.alterTaskBtn.Location = new System.Drawing.Point(17, 192);
            this.alterTaskBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.alterTaskBtn.Name = "alterTaskBtn";
            this.alterTaskBtn.Primary = true;
            this.alterTaskBtn.Size = new System.Drawing.Size(114, 28);
            this.alterTaskBtn.TabIndex = 3;
            this.alterTaskBtn.Text = "изменить";
            this.alterTaskBtn.UseVisualStyleBackColor = true;
            this.alterTaskBtn.Click += new System.EventHandler(this.alterTaskBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 96);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Описание";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 64);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Время";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Дата";
            // 
            // alterDate
            // 
            this.alterDate.Location = new System.Drawing.Point(97, 32);
            this.alterDate.Name = "alterDate";
            this.alterDate.Size = new System.Drawing.Size(169, 23);
            this.alterDate.TabIndex = 4;
            // 
            // alterHour
            // 
            this.alterHour.FormattingEnabled = true;
            this.alterHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.alterHour.Location = new System.Drawing.Point(96, 64);
            this.alterHour.Name = "alterHour";
            this.alterHour.Size = new System.Drawing.Size(45, 24);
            this.alterHour.TabIndex = 5;
            // 
            // alterMinutes
            // 
            this.alterMinutes.FormattingEnabled = true;
            this.alterMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.alterMinutes.Location = new System.Drawing.Point(166, 64);
            this.alterMinutes.Name = "alterMinutes";
            this.alterMinutes.Size = new System.Drawing.Size(45, 24);
            this.alterMinutes.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(147, 67);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(13, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = ":";
            // 
            // alterDescription
            // 
            this.alterDescription.Location = new System.Drawing.Point(97, 96);
            this.alterDescription.Name = "alterDescription";
            this.alterDescription.Size = new System.Drawing.Size(169, 78);
            this.alterDescription.TabIndex = 8;
            this.alterDescription.Text = "";
            // 
            // canceAlterTask
            // 
            this.canceAlterTask.Depth = 0;
            this.canceAlterTask.Location = new System.Drawing.Point(152, 192);
            this.canceAlterTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.canceAlterTask.Name = "canceAlterTask";
            this.canceAlterTask.Primary = true;
            this.canceAlterTask.Size = new System.Drawing.Size(114, 28);
            this.canceAlterTask.TabIndex = 9;
            this.canceAlterTask.Text = "отмена";
            this.canceAlterTask.UseVisualStyleBackColor = true;
            this.canceAlterTask.Click += new System.EventHandler(this.canceAlterTask_Click);
            // 
            // alterTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 329);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(310, 329);
            this.MinimumSize = new System.Drawing.Size(310, 329);
            this.Name = "alterTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "изменить задание";
            this.Load += new System.EventHandler(this.alterTask_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton alterTaskBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker alterDate;
        private System.Windows.Forms.RichTextBox alterDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox alterMinutes;
        private System.Windows.Forms.ComboBox alterHour;
        private MaterialSkin.Controls.MaterialRaisedButton canceAlterTask;
    }
}