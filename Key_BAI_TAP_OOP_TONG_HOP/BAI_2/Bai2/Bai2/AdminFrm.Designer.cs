namespace Bai2
{
    partial class AdminFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManageUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.comboUserSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBookingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabManageDriver = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtManageResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboManage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvDriver = new System.Windows.Forms.DataGridView();
            this.DriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.comboSearchBooking = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalBookingPrice = new System.Windows.Forms.Label();
            this.dateTimeManageDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalBooking = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvBooking = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDriverType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCreateAccount = new System.Windows.Forms.TabPage();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.radioTypeDriver = new System.Windows.Forms.RadioButton();
            this.radioTypeUser = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabManageUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tabManageDriver.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDriver)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooking)).BeginInit();
            this.tabCreateAccount.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManageUser);
            this.tabControl1.Controls.Add(this.tabManageDriver);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabCreateAccount);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 611);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabManageUser
            // 
            this.tabManageUser.Controls.Add(this.groupBox2);
            this.tabManageUser.Controls.Add(this.groupBox1);
            this.tabManageUser.Controls.Add(this.dtgvUser);
            this.tabManageUser.Location = new System.Drawing.Point(4, 30);
            this.tabManageUser.Name = "tabManageUser";
            this.tabManageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageUser.Size = new System.Drawing.Size(1070, 577);
            this.tabManageUser.TabIndex = 0;
            this.tabManageUser.Text = "Quản lý khách hàng";
            this.tabManageUser.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFindUser);
            this.groupBox2.Controls.Add(this.comboUserSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(456, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm:";
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(214, 76);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(180, 39);
            this.btnFindUser.TabIndex = 2;
            this.btnFindUser.Text = "Tìm kiếm";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // comboUserSearch
            // 
            this.comboUserSearch.FormattingEnabled = true;
            this.comboUserSearch.Items.AddRange(new object[] {
            "Khách hàng \"VIP\"",
            "Khách hàng \"Thường\"",
            "Khách hàng có số chuyến đi nhiều nhất"});
            this.comboUserSearch.Location = new System.Drawing.Point(138, 34);
            this.comboUserSearch.Name = "comboUserSearch";
            this.comboUserSearch.Size = new System.Drawing.Size(436, 29);
            this.comboUserSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiêu chí:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // txtTotalUser
            // 
            this.txtTotalUser.AutoSize = true;
            this.txtTotalUser.Location = new System.Drawing.Point(302, 52);
            this.txtTotalUser.Name = "txtTotalUser";
            this.txtTotalUser.Size = new System.Drawing.Size(37, 21);
            this.txtTotalUser.TabIndex = 1;
            this.txtTotalUser.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số khách hàng trong hệ thống:";
            // 
            // dtgvUser
            // 
            this.dtgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserType,
            this.UserPhone,
            this.UserBookingPrice});
            this.dtgvUser.Location = new System.Drawing.Point(0, 0);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.Size = new System.Drawing.Size(1070, 407);
            this.dtgvUser.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Mã KH";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Họ và tên KH";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserType
            // 
            this.UserType.HeaderText = "Loại tài khoản";
            this.UserType.Name = "UserType";
            this.UserType.ReadOnly = true;
            // 
            // UserPhone
            // 
            this.UserPhone.HeaderText = "SĐT";
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            // 
            // UserBookingPrice
            // 
            this.UserBookingPrice.HeaderText = "Số tiền đã thanh toán";
            this.UserBookingPrice.Name = "UserBookingPrice";
            this.UserBookingPrice.ReadOnly = true;
            // 
            // tabManageDriver
            // 
            this.tabManageDriver.Controls.Add(this.groupBox4);
            this.tabManageDriver.Controls.Add(this.groupBox3);
            this.tabManageDriver.Controls.Add(this.dtgvDriver);
            this.tabManageDriver.Location = new System.Drawing.Point(4, 30);
            this.tabManageDriver.Name = "tabManageDriver";
            this.tabManageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageDriver.Size = new System.Drawing.Size(1070, 577);
            this.tabManageDriver.TabIndex = 1;
            this.tabManageDriver.Text = "Quản lý tài xế";
            this.tabManageDriver.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.comboSearch);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(586, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 156);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(135, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboSearch
            // 
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "Tài xế đi xe máy được thưởng",
            "Tài xế đi xe máy được thưởng",
            "Tài xế đi xe 4 chỗ được thưởng",
            "Tài xế đi xe 7 chỗ được thưởng",
            "Tài xế đi xe tải được thưởng",
            "Tài xế chạy cho doanh thu cao nhất."});
            this.comboSearch.Location = new System.Drawing.Point(125, 38);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(273, 29);
            this.comboSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tiêu chí:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtManageResult);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboManage);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(76, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 156);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // txtManageResult
            // 
            this.txtManageResult.AutoSize = true;
            this.txtManageResult.ForeColor = System.Drawing.Color.Red;
            this.txtManageResult.Location = new System.Drawing.Point(121, 93);
            this.txtManageResult.Name = "txtManageResult";
            this.txtManageResult.Size = new System.Drawing.Size(65, 21);
            this.txtManageResult.TabIndex = 3;
            this.txtManageResult.Text = "Kết quả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả:";
            // 
            // comboManage
            // 
            this.comboManage.FormattingEnabled = true;
            this.comboManage.Items.AddRange(new object[] {
            "Tổng số xe máy",
            "Tổng số xe 4 chỗ",
            "Tổng số xe 7 chỗ",
            "Tổng số xe tải <=3 tấn",
            "Tổng số xe tải >3 tấn",
            "Tổng số tài xế"});
            this.comboManage.Location = new System.Drawing.Point(125, 38);
            this.comboManage.Name = "comboManage";
            this.comboManage.Size = new System.Drawing.Size(273, 29);
            this.comboManage.TabIndex = 1;
            this.comboManage.SelectedIndexChanged += new System.EventHandler(this.comboManage_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiêu chí:";
            // 
            // dtgvDriver
            // 
            this.dtgvDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDriver.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDriver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverId,
            this.DriverName,
            this.DriverPhone,
            this.DriverType,
            this.DriverFee,
            this.DriverBonus});
            this.dtgvDriver.Location = new System.Drawing.Point(0, 0);
            this.dtgvDriver.Name = "dtgvDriver";
            this.dtgvDriver.Size = new System.Drawing.Size(1070, 381);
            this.dtgvDriver.TabIndex = 0;
            // 
            // DriverId
            // 
            this.DriverId.HeaderText = "Mã TX";
            this.DriverId.Name = "DriverId";
            this.DriverId.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Họ và tên TX";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // DriverPhone
            // 
            this.DriverPhone.HeaderText = "SĐT TX";
            this.DriverPhone.Name = "DriverPhone";
            this.DriverPhone.ReadOnly = true;
            // 
            // DriverType
            // 
            this.DriverType.HeaderText = "Loại xe";
            this.DriverType.Name = "DriverType";
            this.DriverType.ReadOnly = true;
            // 
            // DriverFee
            // 
            this.DriverFee.HeaderText = "Số tiền thuế đã nộp";
            this.DriverFee.Name = "DriverFee";
            this.DriverFee.ReadOnly = true;
            // 
            // DriverBonus
            // 
            this.DriverBonus.HeaderText = "Tiền thưởng";
            this.DriverBonus.Name = "DriverBonus";
            this.DriverBonus.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.dtgvBooking);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 577);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Chuyến đi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearchBooking);
            this.groupBox5.Controls.Add(this.comboSearchBooking);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(449, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(608, 122);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm:";
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.Location = new System.Drawing.Point(214, 76);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(180, 39);
            this.btnSearchBooking.TabIndex = 2;
            this.btnSearchBooking.Text = "Tìm kiếm";
            this.btnSearchBooking.UseVisualStyleBackColor = true;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // comboSearchBooking
            // 
            this.comboSearchBooking.FormattingEnabled = true;
            this.comboSearchBooking.Items.AddRange(new object[] {
            "Chuyến xe có tiền cước nhiều nhất đối với xe máy.",
            "Chuyến xe có tiền cước nhiều nhất đối với xe ô tô.",
            "Chuyến xe có tiền cước nhiều nhất đối với xe tải"});
            this.comboSearchBooking.Location = new System.Drawing.Point(138, 34);
            this.comboSearchBooking.Name = "comboSearchBooking";
            this.comboSearchBooking.Size = new System.Drawing.Size(436, 29);
            this.comboSearchBooking.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiêu chí:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotalBookingPrice);
            this.groupBox6.Controls.Add(this.dateTimeManageDay);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtTotalBooking);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(8, 434);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 122);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thống kê";
            // 
            // txtTotalBookingPrice
            // 
            this.txtTotalBookingPrice.AutoSize = true;
            this.txtTotalBookingPrice.ForeColor = System.Drawing.Color.Red;
            this.txtTotalBookingPrice.Location = new System.Drawing.Point(301, 76);
            this.txtTotalBookingPrice.Name = "txtTotalBookingPrice";
            this.txtTotalBookingPrice.Size = new System.Drawing.Size(28, 21);
            this.txtTotalBookingPrice.TabIndex = 4;
            this.txtTotalBookingPrice.Text = "0đ";
            // 
            // dateTimeManageDay
            // 
            this.dateTimeManageDay.CustomFormat = "dd/MM/yyyy";
            this.dateTimeManageDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeManageDay.Location = new System.Drawing.Point(155, 70);
            this.dateTimeManageDay.Name = "dateTimeManageDay";
            this.dateTimeManageDay.Size = new System.Drawing.Size(124, 29);
            this.dateTimeManageDay.TabIndex = 3;
            this.dateTimeManageDay.ValueChanged += new System.EventHandler(this.dateTimeManageDay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doanh thu ngày:";
            // 
            // txtTotalBooking
            // 
            this.txtTotalBooking.AutoSize = true;
            this.txtTotalBooking.Location = new System.Drawing.Point(151, 34);
            this.txtTotalBooking.Name = "txtTotalBooking";
            this.txtTotalBooking.Size = new System.Drawing.Size(19, 21);
            this.txtTotalBooking.TabIndex = 1;
            this.txtTotalBooking.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng số chuyến đi:";
            // 
            // dtgvBooking
            // 
            this.dtgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.BookingDriverId,
            this.BookingDriverName,
            this.BookingDriverType,
            this.BookingUserId,
            this.BookingUserName,
            this.BookingDistance,
            this.BookingTime,
            this.BookingPrice,
            this.BookingFee});
            this.dtgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dtgvBooking.Name = "dtgvBooking";
            this.dtgvBooking.Size = new System.Drawing.Size(1070, 428);
            this.dtgvBooking.TabIndex = 3;
            // 
            // BookingId
            // 
            this.BookingId.HeaderText = "Mã chuyến đi";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            // 
            // BookingDriverId
            // 
            this.BookingDriverId.HeaderText = "Mã TX";
            this.BookingDriverId.Name = "BookingDriverId";
            this.BookingDriverId.ReadOnly = true;
            // 
            // BookingDriverName
            // 
            this.BookingDriverName.HeaderText = "Tên TX";
            this.BookingDriverName.Name = "BookingDriverName";
            this.BookingDriverName.ReadOnly = true;
            // 
            // BookingDriverType
            // 
            this.BookingDriverType.HeaderText = "Loại xe";
            this.BookingDriverType.Name = "BookingDriverType";
            this.BookingDriverType.ReadOnly = true;
            // 
            // BookingUserId
            // 
            this.BookingUserId.HeaderText = "Mã KH";
            this.BookingUserId.Name = "BookingUserId";
            this.BookingUserId.ReadOnly = true;
            // 
            // BookingUserName
            // 
            this.BookingUserName.HeaderText = "Tên KH";
            this.BookingUserName.Name = "BookingUserName";
            this.BookingUserName.ReadOnly = true;
            // 
            // BookingDistance
            // 
            this.BookingDistance.HeaderText = "Khoảng cách";
            this.BookingDistance.Name = "BookingDistance";
            this.BookingDistance.ReadOnly = true;
            // 
            // BookingTime
            // 
            this.BookingTime.HeaderText = "Ngày đi";
            this.BookingTime.Name = "BookingTime";
            this.BookingTime.ReadOnly = true;
            // 
            // BookingPrice
            // 
            this.BookingPrice.HeaderText = "Số tiền TT";
            this.BookingPrice.Name = "BookingPrice";
            this.BookingPrice.ReadOnly = true;
            // 
            // BookingFee
            // 
            this.BookingFee.HeaderText = "Tiền thuế";
            this.BookingFee.Name = "BookingFee";
            this.BookingFee.ReadOnly = true;
            // 
            // tabCreateAccount
            // 
            this.tabCreateAccount.Controls.Add(this.btnCreateAccount);
            this.tabCreateAccount.Controls.Add(this.radioTypeDriver);
            this.tabCreateAccount.Controls.Add(this.radioTypeUser);
            this.tabCreateAccount.Controls.Add(this.label14);
            this.tabCreateAccount.Controls.Add(this.comboType);
            this.tabCreateAccount.Controls.Add(this.txtPhone);
            this.tabCreateAccount.Controls.Add(this.txtUsername);
            this.tabCreateAccount.Controls.Add(this.txtFullName);
            this.tabCreateAccount.Controls.Add(this.label13);
            this.tabCreateAccount.Controls.Add(this.label12);
            this.tabCreateAccount.Controls.Add(this.label11);
            this.tabCreateAccount.Controls.Add(this.label10);
            this.tabCreateAccount.Location = new System.Drawing.Point(4, 30);
            this.tabCreateAccount.Name = "tabCreateAccount";
            this.tabCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateAccount.Size = new System.Drawing.Size(1070, 577);
            this.tabCreateAccount.TabIndex = 3;
            this.tabCreateAccount.Text = "Tạo tài khoản";
            this.tabCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(153, 348);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(117, 40);
            this.btnCreateAccount.TabIndex = 13;
            this.btnCreateAccount.Text = "Tạo tài khoản";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // radioTypeDriver
            // 
            this.radioTypeDriver.AutoSize = true;
            this.radioTypeDriver.Location = new System.Drawing.Point(368, 229);
            this.radioTypeDriver.Name = "radioTypeDriver";
            this.radioTypeDriver.Size = new System.Drawing.Size(65, 25);
            this.radioTypeDriver.TabIndex = 12;
            this.radioTypeDriver.Text = "Tài xế";
            this.radioTypeDriver.UseVisualStyleBackColor = true;
            this.radioTypeDriver.CheckedChanged += new System.EventHandler(this.radioTypeDriver_CheckedChanged);
            // 
            // radioTypeUser
            // 
            this.radioTypeUser.AutoSize = true;
            this.radioTypeUser.Checked = true;
            this.radioTypeUser.Location = new System.Drawing.Point(205, 229);
            this.radioTypeUser.Name = "radioTypeUser";
            this.radioTypeUser.Size = new System.Drawing.Size(109, 25);
            this.radioTypeUser.TabIndex = 11;
            this.radioTypeUser.TabStop = true;
            this.radioTypeUser.Text = "Khách hàng";
            this.radioTypeUser.UseVisualStyleBackColor = true;
            this.radioTypeUser.CheckedChanged += new System.EventHandler(this.radioTypeUser_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "Loại tài khoản:";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Thường"});
            this.comboType.Location = new System.Drawing.Point(205, 276);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(216, 29);
            this.comboType.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(205, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 29);
            this.txtPhone.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(205, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 29);
            this.txtUsername.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Location = new System.Drawing.Point(205, 58);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(216, 29);
            this.txtFullName.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Kiểu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "SĐT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tài khoản:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Họ và tên:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(92, 25);
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFrm";
            this.tabControl1.ResumeLayout(false);
            this.tabManageUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.tabManageDriver.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDriver)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooking)).EndInit();
            this.tabCreateAccount.ResumeLayout(false);
            this.tabCreateAccount.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManageUser;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.TabPage tabManageDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBookingPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.ComboBox comboUserSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtTotalUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDriver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtManageResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboManage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearchBooking;
        private System.Windows.Forms.ComboBox comboSearchBooking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label txtTotalBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDriverType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingFee;
        private System.Windows.Forms.Label txtTotalBookingPrice;
        private System.Windows.Forms.DateTimePicker dateTimeManageDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutBtn;
        private System.Windows.Forms.TabPage tabCreateAccount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioTypeDriver;
        private System.Windows.Forms.RadioButton radioTypeUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}