namespace Bai2
{
    partial class UserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabBooking = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnChangeAvatar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtResetPassword = new System.Windows.Forms.LinkLabel();
            this.txtAccountType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAvatarUser = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDriverType = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDriverId = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBookingPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDriverType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEndPosition = new System.Windows.Forms.TextBox();
            this.txtStartPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotalBooking = new System.Windows.Forms.Label();
            this.txtTotalDistance = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dtgvBooking = new System.Windows.Forms.DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.s = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBooking.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatarUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooking)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.tabUser);
            this.tabBooking.Controls.Add(this.tabPage2);
            this.tabBooking.Controls.Add(this.tabStatistic);
            this.tabBooking.Location = new System.Drawing.Point(0, 27);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.SelectedIndex = 0;
            this.tabBooking.Size = new System.Drawing.Size(1080, 622);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.SelectedIndexChanged += new System.EventHandler(this.tabBooking_SelectedIndexChanged);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnChangeAvatar);
            this.tabUser.Controls.Add(this.groupBox1);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Controls.Add(this.pictureAvatarUser);
            this.tabUser.Location = new System.Drawing.Point(4, 30);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1072, 588);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "Trang cá nhân";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeAvatar.Location = new System.Drawing.Point(47, 383);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.Size = new System.Drawing.Size(201, 34);
            this.btnChangeAvatar.TabIndex = 3;
            this.btnChangeAvatar.Text = "Đổi avatar";
            this.btnChangeAvatar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtResetPassword);
            this.groupBox1.Controls.Add(this.txtAccountType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(296, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 449);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(168, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(66, 21);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "********";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 21);
            this.label17.TabIndex = 24;
            this.label17.Text = "Mật khẩu:";
            // 
            // txtResetPassword
            // 
            this.txtResetPassword.AutoSize = true;
            this.txtResetPassword.Location = new System.Drawing.Point(309, 243);
            this.txtResetPassword.Name = "txtResetPassword";
            this.txtResetPassword.Size = new System.Drawing.Size(103, 21);
            this.txtResetPassword.TabIndex = 23;
            this.txtResetPassword.TabStop = true;
            this.txtResetPassword.Text = "Đổi mật khẩu";
            // 
            // txtAccountType
            // 
            this.txtAccountType.AutoSize = true;
            this.txtAccountType.ForeColor = System.Drawing.Color.Red;
            this.txtAccountType.Location = new System.Drawing.Point(168, 367);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(33, 21);
            this.txtAccountType.TabIndex = 22;
            this.txtAccountType.Text = "VIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Loại tài khoản:";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtStatus.Location = new System.Drawing.Point(168, 305);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(56, 21);
            this.txtStatus.TabIndex = 20;
            this.txtStatus.Text = "Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Trạng thái:";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(168, 181);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(89, 21);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.Text = "anvaccount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tài khoản:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoSize = true;
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 119);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.Text = "0987654321";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại:";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Location = new System.Drawing.Point(168, 57);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(109, 21);
            this.txtFullName.TabIndex = 14;
            this.txtFullName.Text = "Nguyễn Văn A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANG CÁ NHÂN";
            // 
            // pictureAvatarUser
            // 
            this.pictureAvatarUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureAvatarUser.Image")));
            this.pictureAvatarUser.Location = new System.Drawing.Point(39, 80);
            this.pictureAvatarUser.Name = "pictureAvatarUser";
            this.pictureAvatarUser.Size = new System.Drawing.Size(210, 280);
            this.pictureAvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatarUser.TabIndex = 0;
            this.pictureAvatarUser.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt xe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.txtDriverType);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtDriverName);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtDriverId);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(520, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 335);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tài xế";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtDriverType
            // 
            this.txtDriverType.AutoSize = true;
            this.txtDriverType.Location = new System.Drawing.Point(162, 160);
            this.txtDriverType.Name = "txtDriverType";
            this.txtDriverType.Size = new System.Drawing.Size(36, 21);
            this.txtDriverType.TabIndex = 5;
            this.txtDriverType.Text = "null";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 21);
            this.label20.TabIndex = 4;
            this.label20.Text = "Loại xe:";
            // 
            // txtDriverName
            // 
            this.txtDriverName.AutoSize = true;
            this.txtDriverName.Location = new System.Drawing.Point(162, 108);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(36, 21);
            this.txtDriverName.TabIndex = 3;
            this.txtDriverName.Text = "null";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "Họ và  tên tài xế:";
            // 
            // txtDriverId
            // 
            this.txtDriverId.AutoSize = true;
            this.txtDriverId.Location = new System.Drawing.Point(162, 56);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(36, 21);
            this.txtDriverId.TabIndex = 1;
            this.txtDriverId.Text = "null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã tài xế:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBookingPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDistance);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(68, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 336);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cước xe";
            // 
            // txtBookingPrice
            // 
            this.txtBookingPrice.AutoSize = true;
            this.txtBookingPrice.ForeColor = System.Drawing.Color.Red;
            this.txtBookingPrice.Location = new System.Drawing.Point(225, 212);
            this.txtBookingPrice.Name = "txtBookingPrice";
            this.txtBookingPrice.Size = new System.Drawing.Size(28, 21);
            this.txtBookingPrice.TabIndex = 7;
            this.txtBookingPrice.Text = "0đ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Số tiền cần thanh toán:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Location = new System.Drawing.Point(225, 160);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(28, 21);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0đ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Giảm giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(225, 108);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(28, 21);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0đ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Giá tiền:";
            // 
            // txtDistance
            // 
            this.txtDistance.AutoSize = true;
            this.txtDistance.Location = new System.Drawing.Point(225, 56);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(42, 21);
            this.txtDistance.TabIndex = 1;
            this.txtDistance.Text = "0Km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Khoảng cách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDriverType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEndPosition);
            this.groupBox2.Controls.Add(this.txtStartPosition);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBooking);
            this.groupBox2.Location = new System.Drawing.Point(68, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // comboDriverType
            // 
            this.comboDriverType.FormattingEnabled = true;
            this.comboDriverType.Items.AddRange(new object[] {
            "Xe gắn máy",
            "Xe ô tô (4 chỗ)",
            "Xe ô tô (7 chỗ)",
            "Xe ô tô tải (<=3 tấn)",
            "Xe ô tô tải (>3 tấn)"});
            this.comboDriverType.Location = new System.Drawing.Point(187, 127);
            this.comboDriverType.Name = "comboDriverType";
            this.comboDriverType.Size = new System.Drawing.Size(229, 29);
            this.comboDriverType.TabIndex = 5;
            this.comboDriverType.SelectedIndexChanged += new System.EventHandler(this.comboDriverType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "Loại xe:";
            // 
            // txtEndPosition
            // 
            this.txtEndPosition.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndPosition.Location = new System.Drawing.Point(187, 79);
            this.txtEndPosition.Name = "txtEndPosition";
            this.txtEndPosition.Size = new System.Drawing.Size(533, 29);
            this.txtEndPosition.TabIndex = 2;
            this.txtEndPosition.TextAlignChanged += new System.EventHandler(this.txtEndPosition_TextAlignChanged);
            // 
            // txtStartPosition
            // 
            this.txtStartPosition.BackColor = System.Drawing.SystemColors.Window;
            this.txtStartPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartPosition.Location = new System.Drawing.Point(187, 31);
            this.txtStartPosition.Name = "txtStartPosition";
            this.txtStartPosition.Size = new System.Drawing.Size(533, 29);
            this.txtStartPosition.TabIndex = 1;
            this.txtStartPosition.TabIndexChanged += new System.EventHandler(this.txtStartPosition_TabIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Địa điểm đến:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa điểm bắt đầu:";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(770, 75);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(116, 35);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Đặt xe";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.groupBox6);
            this.tabStatistic.Controls.Add(this.groupBox5);
            this.tabStatistic.Controls.Add(this.dtgvBooking);
            this.tabStatistic.Location = new System.Drawing.Point(4, 30);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistic.Size = new System.Drawing.Size(1072, 588);
            this.tabStatistic.TabIndex = 2;
            this.tabStatistic.Text = "Thống kê";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSort);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(503, 429);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(548, 147);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sắp xếp";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(167, 97);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(218, 36);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Chuyến đi dài nhất",
            "Chuyến đi trả tiền nhiều nhất"});
            this.comboBox2.Location = new System.Drawing.Point(188, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 29);
            this.comboBox2.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "Tiêu chí sắp xếp:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotalBooking);
            this.groupBox5.Controls.Add(this.txtTotalDistance);
            this.groupBox5.Controls.Add(this.txtTotalPrice);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(18, 429);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 147);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thống kê";
            // 
            // txtTotalBooking
            // 
            this.txtTotalBooking.AutoSize = true;
            this.txtTotalBooking.Location = new System.Drawing.Point(236, 105);
            this.txtTotalBooking.Name = "txtTotalBooking";
            this.txtTotalBooking.Size = new System.Drawing.Size(19, 21);
            this.txtTotalBooking.TabIndex = 9;
            this.txtTotalBooking.Text = "1";
            // 
            // txtTotalDistance
            // 
            this.txtTotalDistance.AutoSize = true;
            this.txtTotalDistance.Location = new System.Drawing.Point(236, 67);
            this.txtTotalDistance.Name = "txtTotalDistance";
            this.txtTotalDistance.Size = new System.Drawing.Size(50, 21);
            this.txtTotalDistance.TabIndex = 8;
            this.txtTotalDistance.Text = "20km";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Location = new System.Drawing.Point(236, 31);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(76, 21);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.Text = "100.000đ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(186, 21);
            this.label24.TabIndex = 6;
            this.label24.Text = "Tổng số km đã di chuyển:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 21);
            this.label23.TabIndex = 5;
            this.label23.Text = "Tổng số chuyến xe đã đi:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(198, 21);
            this.label22.TabIndex = 4;
            this.label22.Text = "Tổng số tiền đã thanh toán:";
            // 
            // dtgvBooking
            // 
            this.dtgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBooking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.DriverId,
            this.DriverName,
            this.DriverPhoneNumber,
            this.BookingDistance,
            this.BookingPrice});
            this.dtgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dtgvBooking.Name = "dtgvBooking";
            this.dtgvBooking.Size = new System.Drawing.Size(1072, 423);
            this.dtgvBooking.TabIndex = 0;
            // 
            // BookingId
            // 
            this.BookingId.HeaderText = "Mã chuyến đi";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            // 
            // DriverId
            // 
            this.DriverId.HeaderText = "Mã tài xế";
            this.DriverId.Name = "DriverId";
            this.DriverId.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.HeaderText = "Tên tài xế";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // DriverPhoneNumber
            // 
            this.DriverPhoneNumber.HeaderText = "SĐT tài xế";
            this.DriverPhoneNumber.Name = "DriverPhoneNumber";
            this.DriverPhoneNumber.ReadOnly = true;
            // 
            // BookingDistance
            // 
            this.BookingDistance.HeaderText = "Khoảng cách";
            this.BookingDistance.Name = "BookingDistance";
            this.BookingDistance.ReadOnly = true;
            // 
            // BookingPrice
            // 
            this.BookingPrice.HeaderText = "Tiền cước";
            this.BookingPrice.Name = "BookingPrice";
            this.BookingPrice.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // s
            // 
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(84, 23);
            this.s.Text = "Đăng xuất";
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 645);
            this.Controls.Add(this.tabBooking);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.tabBooking.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatarUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabStatistic.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooking)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabBooking;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAvatarUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel txtResetPassword;
        private System.Windows.Forms.Label txtAccountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEndPosition;
        private System.Windows.Forms.TextBox txtStartPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtBookingPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtDistance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboDriverType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtDriverType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtDriverName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtDriverId;
        private System.Windows.Forms.Button btnChangeAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvBooking;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingPrice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label txtTotalBooking;
        private System.Windows.Forms.Label txtTotalDistance;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem s;
    }
}