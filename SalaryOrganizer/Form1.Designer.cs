namespace SalaryOrganizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.orgTabs = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.todayTasks = new System.Windows.Forms.GroupBox();
            this.showAllTasks = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.taskList = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.searchTaskByDate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.taskDateTo = new System.Windows.Forms.DateTimePicker();
            this.taskDateFrom = new System.Windows.Forms.DateTimePicker();
            this.doneTasks = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.alterTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createTask = new MaterialSkin.Controls.MaterialRaisedButton();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.deleteAllEmployeeByShop = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.alterEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.deleteEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addEmployee = new MaterialSkin.Controls.MaterialRaisedButton();
            this.salaryPage = new System.Windows.Forms.TabPage();
            this.createPayroll = new System.Windows.Forms.GroupBox();
            this.averageSalary = new System.Windows.Forms.GroupBox();
            this.sumSalary = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.shopSumSalary = new System.Windows.Forms.TextBox();
            this.showSumSalary = new System.Windows.Forms.RichTextBox();
            this.getSumSalary = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.shopAverageSalary = new System.Windows.Forms.TextBox();
            this.getAverageSalary = new MaterialSkin.Controls.MaterialRaisedButton();
            this.showAverageSalary = new System.Windows.Forms.RichTextBox();
            this.shopPayroll = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.yearPayroll = new System.Windows.Forms.TextBox();
            this.monthPayroll = new System.Windows.Forms.ComboBox();
            this.createPayrollBTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.orgTabs.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.taskList.SuspendLayout();
            this.employeePage.SuspendLayout();
            this.salaryPage.SuspendLayout();
            this.createPayroll.SuspendLayout();
            this.averageSalary.SuspendLayout();
            this.sumSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // orgTabs
            // 
            this.orgTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orgTabs.Controls.Add(this.mainPage);
            this.orgTabs.Controls.Add(this.taskList);
            this.orgTabs.Controls.Add(this.employeePage);
            this.orgTabs.Controls.Add(this.salaryPage);
            this.orgTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgTabs.ItemSize = new System.Drawing.Size(76, 35);
            this.orgTabs.Location = new System.Drawing.Point(2, 63);
            this.orgTabs.Name = "orgTabs";
            this.orgTabs.Padding = new System.Drawing.Point(10, 3);
            this.orgTabs.SelectedIndex = 0;
            this.orgTabs.Size = new System.Drawing.Size(799, 435);
            this.orgTabs.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.todayTasks);
            this.mainPage.Controls.Add(this.showAllTasks);
            this.mainPage.Controls.Add(this.mainCalendar);
            this.mainPage.Controls.Add(this.materialDivider1);
            this.mainPage.Location = new System.Drawing.Point(4, 39);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(791, 392);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Главная";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // todayTasks
            // 
            this.todayTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayTasks.AutoSize = true;
            this.todayTasks.Location = new System.Drawing.Point(21, 18);
            this.todayTasks.Name = "todayTasks";
            this.todayTasks.Size = new System.Drawing.Size(527, 359);
            this.todayTasks.TabIndex = 3;
            this.todayTasks.TabStop = false;
            this.todayTasks.Text = "Задачи на сегодня";
            // 
            // showAllTasks
            // 
            this.showAllTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllTasks.Depth = 0;
            this.showAllTasks.Location = new System.Drawing.Point(598, 211);
            this.showAllTasks.MouseState = MaterialSkin.MouseState.HOVER;
            this.showAllTasks.Name = "showAllTasks";
            this.showAllTasks.Primary = true;
            this.showAllTasks.Size = new System.Drawing.Size(164, 52);
            this.showAllTasks.TabIndex = 2;
            this.showAllTasks.Text = "показать  все задачи";
            this.showAllTasks.UseVisualStyleBackColor = true;
            // 
            // mainCalendar
            // 
            this.mainCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainCalendar.Location = new System.Drawing.Point(598, 18);
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 1;
            this.mainCalendar.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(572, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(220, 399);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // taskList
            // 
            this.taskList.Controls.Add(this.materialLabel2);
            this.taskList.Controls.Add(this.materialLabel1);
            this.taskList.Controls.Add(this.searchTaskByDate);
            this.taskList.Controls.Add(this.taskDateTo);
            this.taskList.Controls.Add(this.taskDateFrom);
            this.taskList.Controls.Add(this.doneTasks);
            this.taskList.Controls.Add(this.deleteTask);
            this.taskList.Controls.Add(this.alterTask);
            this.taskList.Controls.Add(this.createTask);
            this.taskList.Location = new System.Drawing.Point(4, 39);
            this.taskList.Name = "taskList";
            this.taskList.Padding = new System.Windows.Forms.Padding(3);
            this.taskList.Size = new System.Drawing.Size(791, 392);
            this.taskList.TabIndex = 1;
            this.taskList.Text = "Список задач";
            this.taskList.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(255, 347);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(27, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "по";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 347);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Задачи с";
            // 
            // searchTaskByDate
            // 
            this.searchTaskByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTaskByDate.Depth = 0;
            this.searchTaskByDate.Location = new System.Drawing.Point(470, 343);
            this.searchTaskByDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTaskByDate.Name = "searchTaskByDate";
            this.searchTaskByDate.Primary = true;
            this.searchTaskByDate.Size = new System.Drawing.Size(126, 26);
            this.searchTaskByDate.TabIndex = 6;
            this.searchTaskByDate.Text = "найти";
            this.searchTaskByDate.UseVisualStyleBackColor = true;
            // 
            // taskDateTo
            // 
            this.taskDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDateTo.Location = new System.Drawing.Point(284, 343);
            this.taskDateTo.Name = "taskDateTo";
            this.taskDateTo.Size = new System.Drawing.Size(155, 26);
            this.taskDateTo.TabIndex = 5;
            // 
            // taskDateFrom
            // 
            this.taskDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDateFrom.Location = new System.Drawing.Point(89, 343);
            this.taskDateFrom.Name = "taskDateFrom";
            this.taskDateFrom.Size = new System.Drawing.Size(155, 26);
            this.taskDateFrom.TabIndex = 4;
            // 
            // doneTasks
            // 
            this.doneTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doneTasks.Depth = 0;
            this.doneTasks.Location = new System.Drawing.Point(587, 16);
            this.doneTasks.MouseState = MaterialSkin.MouseState.HOVER;
            this.doneTasks.Name = "doneTasks";
            this.doneTasks.Primary = true;
            this.doneTasks.Size = new System.Drawing.Size(188, 33);
            this.doneTasks.TabIndex = 3;
            this.doneTasks.Text = "выполненные задачи";
            this.doneTasks.UseVisualStyleBackColor = true;
            // 
            // deleteTask
            // 
            this.deleteTask.Depth = 0;
            this.deleteTask.Location = new System.Drawing.Point(259, 16);
            this.deleteTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Primary = true;
            this.deleteTask.Size = new System.Drawing.Size(111, 33);
            this.deleteTask.TabIndex = 2;
            this.deleteTask.Text = "удалить";
            this.deleteTask.UseVisualStyleBackColor = true;
            // 
            // alterTask
            // 
            this.alterTask.Depth = 0;
            this.alterTask.Location = new System.Drawing.Point(133, 16);
            this.alterTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.alterTask.Name = "alterTask";
            this.alterTask.Primary = true;
            this.alterTask.Size = new System.Drawing.Size(111, 33);
            this.alterTask.TabIndex = 1;
            this.alterTask.Text = "изменить";
            this.alterTask.UseVisualStyleBackColor = true;
            // 
            // createTask
            // 
            this.createTask.Depth = 0;
            this.createTask.Location = new System.Drawing.Point(10, 16);
            this.createTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTask.Name = "createTask";
            this.createTask.Primary = true;
            this.createTask.Size = new System.Drawing.Size(111, 33);
            this.createTask.TabIndex = 0;
            this.createTask.Text = "создать";
            this.createTask.UseVisualStyleBackColor = true;
            // 
            // employeePage
            // 
            this.employeePage.Controls.Add(this.deleteAllEmployeeByShop);
            this.employeePage.Controls.Add(this.textBox1);
            this.employeePage.Controls.Add(this.materialLabel3);
            this.employeePage.Controls.Add(this.alterEmployee);
            this.employeePage.Controls.Add(this.deleteEmployee);
            this.employeePage.Controls.Add(this.addEmployee);
            this.employeePage.Location = new System.Drawing.Point(4, 39);
            this.employeePage.Name = "employeePage";
            this.employeePage.Size = new System.Drawing.Size(791, 392);
            this.employeePage.TabIndex = 2;
            this.employeePage.Text = "Список сотрудников";
            this.employeePage.UseVisualStyleBackColor = true;
            // 
            // deleteAllEmployeeByShop
            // 
            this.deleteAllEmployeeByShop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteAllEmployeeByShop.Depth = 0;
            this.deleteAllEmployeeByShop.Location = new System.Drawing.Point(341, 344);
            this.deleteAllEmployeeByShop.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteAllEmployeeByShop.Name = "deleteAllEmployeeByShop";
            this.deleteAllEmployeeByShop.Primary = true;
            this.deleteAllEmployeeByShop.Size = new System.Drawing.Size(111, 26);
            this.deleteAllEmployeeByShop.TabIndex = 5;
            this.deleteAllEmployeeByShop.Text = "выполнить";
            this.deleteAllEmployeeByShop.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(281, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 26);
            this.textBox1.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 348);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(255, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Удалить всех сотрудников цеха №";
            // 
            // alterEmployee
            // 
            this.alterEmployee.Depth = 0;
            this.alterEmployee.Location = new System.Drawing.Point(133, 16);
            this.alterEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.alterEmployee.Name = "alterEmployee";
            this.alterEmployee.Primary = true;
            this.alterEmployee.Size = new System.Drawing.Size(111, 33);
            this.alterEmployee.TabIndex = 2;
            this.alterEmployee.Text = "изменить";
            this.alterEmployee.UseVisualStyleBackColor = true;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Depth = 0;
            this.deleteEmployee.Location = new System.Drawing.Point(259, 16);
            this.deleteEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Primary = true;
            this.deleteEmployee.Size = new System.Drawing.Size(111, 33);
            this.deleteEmployee.TabIndex = 1;
            this.deleteEmployee.Text = "удалить";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.Depth = 0;
            this.addEmployee.Location = new System.Drawing.Point(10, 16);
            this.addEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Primary = true;
            this.addEmployee.Size = new System.Drawing.Size(111, 33);
            this.addEmployee.TabIndex = 0;
            this.addEmployee.Text = "добавить";
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // salaryPage
            // 
            this.salaryPage.Controls.Add(this.createPayroll);
            this.salaryPage.Controls.Add(this.averageSalary);
            this.salaryPage.Controls.Add(this.sumSalary);
            this.salaryPage.Location = new System.Drawing.Point(4, 39);
            this.salaryPage.Name = "salaryPage";
            this.salaryPage.Size = new System.Drawing.Size(791, 392);
            this.salaryPage.TabIndex = 3;
            this.salaryPage.Text = "Зарплатная ведомость";
            this.salaryPage.UseVisualStyleBackColor = true;
            // 
            // createPayroll
            // 
            this.createPayroll.Controls.Add(this.createPayrollBTN);
            this.createPayroll.Controls.Add(this.monthPayroll);
            this.createPayroll.Controls.Add(this.yearPayroll);
            this.createPayroll.Controls.Add(this.materialLabel8);
            this.createPayroll.Controls.Add(this.materialLabel7);
            this.createPayroll.Controls.Add(this.shopPayroll);
            this.createPayroll.Controls.Add(this.materialLabel6);
            this.createPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.createPayroll.Location = new System.Drawing.Point(425, 18);
            this.createPayroll.Name = "createPayroll";
            this.createPayroll.Size = new System.Drawing.Size(271, 197);
            this.createPayroll.TabIndex = 2;
            this.createPayroll.TabStop = false;
            this.createPayroll.Text = "Создать зарплатную ведомость";
            // 
            // averageSalary
            // 
            this.averageSalary.Controls.Add(this.showAverageSalary);
            this.averageSalary.Controls.Add(this.getAverageSalary);
            this.averageSalary.Controls.Add(this.shopAverageSalary);
            this.averageSalary.Controls.Add(this.materialLabel5);
            this.averageSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.averageSalary.Location = new System.Drawing.Point(18, 211);
            this.averageSalary.Name = "averageSalary";
            this.averageSalary.Size = new System.Drawing.Size(337, 167);
            this.averageSalary.TabIndex = 1;
            this.averageSalary.TabStop = false;
            this.averageSalary.Text = "Вычислить средний месячный заработок";
            // 
            // sumSalary
            // 
            this.sumSalary.Controls.Add(this.getSumSalary);
            this.sumSalary.Controls.Add(this.showSumSalary);
            this.sumSalary.Controls.Add(this.shopSumSalary);
            this.sumSalary.Controls.Add(this.materialLabel4);
            this.sumSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumSalary.Location = new System.Drawing.Point(18, 18);
            this.sumSalary.Name = "sumSalary";
            this.sumSalary.Size = new System.Drawing.Size(337, 165);
            this.sumSalary.TabIndex = 0;
            this.sumSalary.TabStop = false;
            this.sumSalary.Text = "Вычислить общую сумму выплаты за месяц ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 41);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(37, 20);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Цех";
            // 
            // shopSumSalary
            // 
            this.shopSumSalary.Location = new System.Drawing.Point(81, 41);
            this.shopSumSalary.Name = "shopSumSalary";
            this.shopSumSalary.Size = new System.Drawing.Size(43, 24);
            this.shopSumSalary.TabIndex = 1;
            // 
            // showSumSalary
            // 
            this.showSumSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showSumSalary.Location = new System.Drawing.Point(161, 41);
            this.showSumSalary.Name = "showSumSalary";
            this.showSumSalary.Size = new System.Drawing.Size(158, 96);
            this.showSumSalary.TabIndex = 2;
            this.showSumSalary.Text = "";
            // 
            // getSumSalary
            // 
            this.getSumSalary.Depth = 0;
            this.getSumSalary.Location = new System.Drawing.Point(18, 98);
            this.getSumSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.getSumSalary.Name = "getSumSalary";
            this.getSumSalary.Primary = true;
            this.getSumSalary.Size = new System.Drawing.Size(127, 38);
            this.getSumSalary.TabIndex = 3;
            this.getSumSalary.Text = "вычислить";
            this.getSumSalary.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(24, 39);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(35, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Цех";
            // 
            // shopAverageSalary
            // 
            this.shopAverageSalary.Location = new System.Drawing.Point(81, 39);
            this.shopAverageSalary.Name = "shopAverageSalary";
            this.shopAverageSalary.Size = new System.Drawing.Size(43, 24);
            this.shopAverageSalary.TabIndex = 4;
            // 
            // getAverageSalary
            // 
            this.getAverageSalary.Depth = 0;
            this.getAverageSalary.Location = new System.Drawing.Point(18, 97);
            this.getAverageSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.getAverageSalary.Name = "getAverageSalary";
            this.getAverageSalary.Primary = true;
            this.getAverageSalary.Size = new System.Drawing.Size(127, 38);
            this.getAverageSalary.TabIndex = 5;
            this.getAverageSalary.Text = "вычислить";
            this.getAverageSalary.UseVisualStyleBackColor = true;
            // 
            // showAverageSalary
            // 
            this.showAverageSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAverageSalary.Location = new System.Drawing.Point(161, 39);
            this.showAverageSalary.Name = "showAverageSalary";
            this.showAverageSalary.Size = new System.Drawing.Size(158, 96);
            this.showAverageSalary.TabIndex = 4;
            this.showAverageSalary.Text = "";
            // 
            // shopPayroll
            // 
            this.shopPayroll.Location = new System.Drawing.Point(84, 39);
            this.shopPayroll.Name = "shopPayroll";
            this.shopPayroll.Size = new System.Drawing.Size(147, 24);
            this.shopPayroll.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(18, 44);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(35, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Цех";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(18, 82);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(55, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Месяц";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(18, 117);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(35, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Год";
            // 
            // yearPayroll
            // 
            this.yearPayroll.Location = new System.Drawing.Point(84, 114);
            this.yearPayroll.Name = "yearPayroll";
            this.yearPayroll.Size = new System.Drawing.Size(147, 24);
            this.yearPayroll.TabIndex = 8;
            // 
            // monthPayroll
            // 
            this.monthPayroll.AutoCompleteCustomSource.AddRange(new string[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.monthPayroll.FormattingEnabled = true;
            this.monthPayroll.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрб",
            "ноябрь",
            "декабрь"});
            this.monthPayroll.Location = new System.Drawing.Point(84, 79);
            this.monthPayroll.Name = "monthPayroll";
            this.monthPayroll.Size = new System.Drawing.Size(147, 26);
            this.monthPayroll.TabIndex = 9;
            // 
            // createPayrollBTN
            // 
            this.createPayrollBTN.Depth = 0;
            this.createPayrollBTN.Location = new System.Drawing.Point(21, 154);
            this.createPayrollBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.createPayrollBTN.Name = "createPayrollBTN";
            this.createPayrollBTN.Primary = true;
            this.createPayrollBTN.Size = new System.Drawing.Size(210, 27);
            this.createPayrollBTN.TabIndex = 10;
            this.createPayrollBTN.Text = "создать ведомость";
            this.createPayrollBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 501);
            this.Controls.Add(this.orgTabs);
            this.Name = "Form1";
            this.Text = "Органайзер";
            this.orgTabs.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.taskList.ResumeLayout(false);
            this.taskList.PerformLayout();
            this.employeePage.ResumeLayout(false);
            this.employeePage.PerformLayout();
            this.salaryPage.ResumeLayout(false);
            this.createPayroll.ResumeLayout(false);
            this.createPayroll.PerformLayout();
            this.averageSalary.ResumeLayout(false);
            this.averageSalary.PerformLayout();
            this.sumSalary.ResumeLayout(false);
            this.sumSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl orgTabs;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage taskList;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.TabPage salaryPage;
        private System.Windows.Forms.GroupBox todayTasks;
        private MaterialSkin.Controls.MaterialRaisedButton showAllTasks;
        private System.Windows.Forms.MonthCalendar mainCalendar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton doneTasks;
        private MaterialSkin.Controls.MaterialRaisedButton deleteTask;
        private MaterialSkin.Controls.MaterialRaisedButton alterTask;
        private MaterialSkin.Controls.MaterialRaisedButton createTask;
        private System.Windows.Forms.DateTimePicker taskDateTo;
        private System.Windows.Forms.DateTimePicker taskDateFrom;
        private MaterialSkin.Controls.MaterialRaisedButton searchTaskByDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton alterEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton deleteEmployee;
        private MaterialSkin.Controls.MaterialRaisedButton addEmployee;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton deleteAllEmployeeByShop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox createPayroll;
        private System.Windows.Forms.GroupBox averageSalary;
        private System.Windows.Forms.GroupBox sumSalary;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton getSumSalary;
        private System.Windows.Forms.RichTextBox showSumSalary;
        private System.Windows.Forms.TextBox shopSumSalary;
        private System.Windows.Forms.RichTextBox showAverageSalary;
        private MaterialSkin.Controls.MaterialRaisedButton getAverageSalary;
        private System.Windows.Forms.TextBox shopAverageSalary;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton createPayrollBTN;
        private System.Windows.Forms.ComboBox monthPayroll;
        private System.Windows.Forms.TextBox yearPayroll;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox shopPayroll;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

