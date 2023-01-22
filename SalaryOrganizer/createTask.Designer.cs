namespace SalaryOrganizer
{
    partial class createTask
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
            this.cancelCreateTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createNewTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.taskDescription = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.taskMinutes = new System.Windows.Forms.ComboBox();
            this.taskHour = new System.Windows.Forms.ComboBox();
            this.taskDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelCreateTask);
            this.groupBox1.Controls.Add(this.createNewTask);
            this.groupBox1.Controls.Add(this.taskDescription);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.taskMinutes);
            this.groupBox1.Controls.Add(this.taskHour);
            this.groupBox1.Controls.Add(this.taskDate);
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
            // cancelCreateTask
            // 
            this.cancelCreateTask.Depth = 0;
            this.cancelCreateTask.Location = new System.Drawing.Point(152, 192);
            this.cancelCreateTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelCreateTask.Name = "cancelCreateTask";
            this.cancelCreateTask.Primary = true;
            this.cancelCreateTask.Size = new System.Drawing.Size(114, 28);
            this.cancelCreateTask.TabIndex = 9;
            this.cancelCreateTask.Text = "отмена";
            this.cancelCreateTask.UseVisualStyleBackColor = true;
            this.cancelCreateTask.Click += new System.EventHandler(this.cancelCreateTask_Click);
            // 
            // createNewTask
            // 
            this.createNewTask.Depth = 0;
            this.createNewTask.Location = new System.Drawing.Point(17, 192);
            this.createNewTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.createNewTask.Name = "createNewTask";
            this.createNewTask.Primary = true;
            this.createNewTask.Size = new System.Drawing.Size(114, 28);
            this.createNewTask.TabIndex = 8;
            this.createNewTask.Text = "создать";
            this.createNewTask.UseVisualStyleBackColor = true;
            this.createNewTask.Click += new System.EventHandler(this.createNewTask_Click);
            // 
            // taskDescription
            // 
            this.taskDescription.Location = new System.Drawing.Point(97, 96);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(169, 78);
            this.taskDescription.TabIndex = 7;
            this.taskDescription.Text = "";
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
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = ":";
            // 
            // taskMinutes
            // 
            this.taskMinutes.FormattingEnabled = true;
            this.taskMinutes.Items.AddRange(new object[] {
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
            this.taskMinutes.Location = new System.Drawing.Point(166, 64);
            this.taskMinutes.Name = "taskMinutes";
            this.taskMinutes.Size = new System.Drawing.Size(45, 24);
            this.taskMinutes.TabIndex = 5;
            // 
            // taskHour
            // 
            this.taskHour.FormattingEnabled = true;
            this.taskHour.Items.AddRange(new object[] {
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
            this.taskHour.Location = new System.Drawing.Point(96, 64);
            this.taskHour.Name = "taskHour";
            this.taskHour.Size = new System.Drawing.Size(45, 24);
            this.taskHour.TabIndex = 4;
            // 
            // taskDate
            // 
            this.taskDate.Location = new System.Drawing.Point(97, 32);
            this.taskDate.MinDate = new System.DateTime(2023, 1, 22, 0, 0, 0, 0);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(169, 23);
            this.taskDate.TabIndex = 3;
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
            // createTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 329);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(310, 329);
            this.MinimumSize = new System.Drawing.Size(310, 329);
            this.Name = "createTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "добавить задание";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton cancelCreateTask;
        private MaterialSkin.Controls.MaterialRaisedButton createNewTask;
        private System.Windows.Forms.RichTextBox taskDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox taskMinutes;
        private System.Windows.Forms.ComboBox taskHour;
        private System.Windows.Forms.DateTimePicker taskDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}