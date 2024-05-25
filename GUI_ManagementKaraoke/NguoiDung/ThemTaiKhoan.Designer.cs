namespace GUI_ManagementKaraoke.NguoiDung
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            this.pn_Content = new Guna.UI2.WinForms.Guna2Panel();
            this.pn_Child = new Guna.UI2.WinForms.Guna2Panel();
            this.title_TaoTaiKhoan = new System.Windows.Forms.Label();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.lb_NhapLaiMatKhau = new System.Windows.Forms.Label();
            this.cbb_QuyenHan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_QuyenHan = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_ThemTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.sp_Line1 = new Guna.UI2.WinForms.Guna2Separator();
            this.bt_HuyBo = new Guna.UI2.WinForms.Guna2Button();
            this.sp_Line2 = new Guna.UI2.WinForms.Guna2Separator();
            this.err_TenTaiKhoan = new System.Windows.Forms.Label();
            this.err_MatKhau = new System.Windows.Forms.Label();
            this.err_NhapLaiMatKhau = new System.Windows.Forms.Label();
            this.tt_HienThiLoi = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pn_Content.SuspendLayout();
            this.pn_Child.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Content
            // 
            this.pn_Content.BorderRadius = 30;
            this.pn_Content.Controls.Add(this.pn_Child);
            this.pn_Content.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pn_Content.Location = new System.Drawing.Point(12, 12);
            this.pn_Content.Name = "pn_Content";
            this.pn_Content.Size = new System.Drawing.Size(470, 380);
            this.pn_Content.TabIndex = 0;
            // 
            // pn_Child
            // 
            this.pn_Child.BackColor = System.Drawing.Color.Transparent;
            this.pn_Child.Controls.Add(this.err_NhapLaiMatKhau);
            this.pn_Child.Controls.Add(this.err_MatKhau);
            this.pn_Child.Controls.Add(this.err_TenTaiKhoan);
            this.pn_Child.Controls.Add(this.sp_Line2);
            this.pn_Child.Controls.Add(this.bt_HuyBo);
            this.pn_Child.Controls.Add(this.sp_Line1);
            this.pn_Child.Controls.Add(this.bt_ThemTaiKhoan);
            this.pn_Child.Controls.Add(this.txt_NhapLaiMatKhau);
            this.pn_Child.Controls.Add(this.txt_MatKhau);
            this.pn_Child.Controls.Add(this.txt_TenTaiKhoan);
            this.pn_Child.Controls.Add(this.lb_QuyenHan);
            this.pn_Child.Controls.Add(this.cbb_QuyenHan);
            this.pn_Child.Controls.Add(this.lb_NhapLaiMatKhau);
            this.pn_Child.Controls.Add(this.lb_MatKhau);
            this.pn_Child.Controls.Add(this.lb_TenTaiKhoan);
            this.pn_Child.Controls.Add(this.title_TaoTaiKhoan);
            this.pn_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Child.Location = new System.Drawing.Point(0, 0);
            this.pn_Child.Name = "pn_Child";
            this.pn_Child.Size = new System.Drawing.Size(470, 380);
            this.pn_Child.TabIndex = 0;
            // 
            // title_TaoTaiKhoan
            // 
            this.title_TaoTaiKhoan.AutoSize = true;
            this.title_TaoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_TaoTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.title_TaoTaiKhoan.Location = new System.Drawing.Point(146, 12);
            this.title_TaoTaiKhoan.Name = "title_TaoTaiKhoan";
            this.title_TaoTaiKhoan.Size = new System.Drawing.Size(178, 31);
            this.title_TaoTaiKhoan.TabIndex = 0;
            this.title_TaoTaiKhoan.Text = "Tạo tài khoản";
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(55, 91);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(110, 19);
            this.lb_TenTaiKhoan.TabIndex = 1;
            this.lb_TenTaiKhoan.Text = "Tên tài khoản :";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_MatKhau.Location = new System.Drawing.Point(81, 143);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(84, 19);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu :";
            // 
            // lb_NhapLaiMatKhau
            // 
            this.lb_NhapLaiMatKhau.AutoSize = true;
            this.lb_NhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_NhapLaiMatKhau.Location = new System.Drawing.Point(25, 195);
            this.lb_NhapLaiMatKhau.Name = "lb_NhapLaiMatKhau";
            this.lb_NhapLaiMatKhau.Size = new System.Drawing.Size(140, 19);
            this.lb_NhapLaiMatKhau.TabIndex = 3;
            this.lb_NhapLaiMatKhau.Text = "Nhập lại mật khẩu :";
            // 
            // cbb_QuyenHan
            // 
            this.cbb_QuyenHan.BackColor = System.Drawing.Color.Transparent;
            this.cbb_QuyenHan.BorderRadius = 10;
            this.cbb_QuyenHan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_QuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_QuyenHan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_QuyenHan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_QuyenHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_QuyenHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbb_QuyenHan.ItemHeight = 30;
            this.cbb_QuyenHan.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbb_QuyenHan.Location = new System.Drawing.Point(165, 238);
            this.cbb_QuyenHan.Name = "cbb_QuyenHan";
            this.cbb_QuyenHan.Size = new System.Drawing.Size(249, 36);
            this.cbb_QuyenHan.TabIndex = 5;
            // 
            // lb_QuyenHan
            // 
            this.lb_QuyenHan.AutoSize = true;
            this.lb_QuyenHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuyenHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_QuyenHan.Location = new System.Drawing.Point(75, 247);
            this.lb_QuyenHan.Name = "lb_QuyenHan";
            this.lb_QuyenHan.Size = new System.Drawing.Size(90, 19);
            this.lb_QuyenHan.TabIndex = 6;
            this.lb_QuyenHan.Text = "Quyền hạn :";
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.BorderRadius = 10;
            this.txt_TenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenTaiKhoan.DefaultText = "";
            this.txt_TenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(165, 82);
            this.txt_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.PasswordChar = '\0';
            this.txt_TenTaiKhoan.PlaceholderText = "";
            this.txt_TenTaiKhoan.SelectedText = "";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(249, 36);
            this.txt_TenTaiKhoan.TabIndex = 7;
            this.txt_TenTaiKhoan.TextChanged += new System.EventHandler(this.txt_TenTaiKhoan_TextChanged);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderRadius = 10;
            this.txt_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhau.DefaultText = "";
            this.txt_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Location = new System.Drawing.Point(165, 134);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '\0';
            this.txt_MatKhau.PlaceholderText = "";
            this.txt_MatKhau.SelectedText = "";
            this.txt_MatKhau.Size = new System.Drawing.Size(249, 36);
            this.txt_MatKhau.TabIndex = 8;
            // 
            // txt_NhapLaiMatKhau
            // 
            this.txt_NhapLaiMatKhau.BorderRadius = 10;
            this.txt_NhapLaiMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NhapLaiMatKhau.DefaultText = "";
            this.txt_NhapLaiMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NhapLaiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NhapLaiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NhapLaiMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NhapLaiMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_NhapLaiMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NhapLaiMatKhau.Location = new System.Drawing.Point(165, 186);
            this.txt_NhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NhapLaiMatKhau.Name = "txt_NhapLaiMatKhau";
            this.txt_NhapLaiMatKhau.PasswordChar = '\0';
            this.txt_NhapLaiMatKhau.PlaceholderText = "";
            this.txt_NhapLaiMatKhau.SelectedText = "";
            this.txt_NhapLaiMatKhau.Size = new System.Drawing.Size(249, 36);
            this.txt_NhapLaiMatKhau.TabIndex = 9;
            // 
            // bt_ThemTaiKhoan
            // 
            this.bt_ThemTaiKhoan.BorderRadius = 15;
            this.bt_ThemTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_ThemTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_ThemTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_ThemTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_ThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.bt_ThemTaiKhoan.Image = global::GUI_ManagementKaraoke.Properties.Resources.create;
            this.bt_ThemTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ThemTaiKhoan.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_ThemTaiKhoan.Location = new System.Drawing.Point(248, 315);
            this.bt_ThemTaiKhoan.Name = "bt_ThemTaiKhoan";
            this.bt_ThemTaiKhoan.Size = new System.Drawing.Size(180, 45);
            this.bt_ThemTaiKhoan.TabIndex = 11;
            this.bt_ThemTaiKhoan.Text = "Thêm tài khoản";
            this.bt_ThemTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ThemTaiKhoan.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_ThemTaiKhoan.Click += new System.EventHandler(this.bt_ThemTaiKhoan_Click);
            // 
            // sp_Line1
            // 
            this.sp_Line1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line1.Location = new System.Drawing.Point(69, 46);
            this.sp_Line1.Name = "sp_Line1";
            this.sp_Line1.Size = new System.Drawing.Size(333, 10);
            this.sp_Line1.TabIndex = 12;
            // 
            // bt_HuyBo
            // 
            this.bt_HuyBo.BorderRadius = 15;
            this.bt_HuyBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_HuyBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_HuyBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_HuyBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_HuyBo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HuyBo.ForeColor = System.Drawing.Color.White;
            this.bt_HuyBo.Image = global::GUI_ManagementKaraoke.Properties.Resources.cancel;
            this.bt_HuyBo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_HuyBo.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_HuyBo.Location = new System.Drawing.Point(43, 315);
            this.bt_HuyBo.Name = "bt_HuyBo";
            this.bt_HuyBo.Size = new System.Drawing.Size(180, 45);
            this.bt_HuyBo.TabIndex = 13;
            this.bt_HuyBo.Text = "Huỷ bỏ";
            this.bt_HuyBo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_HuyBo.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_HuyBo.Click += new System.EventHandler(this.bt_HuyBo_Click);
            // 
            // sp_Line2
            // 
            this.sp_Line2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line2.Location = new System.Drawing.Point(69, 294);
            this.sp_Line2.Name = "sp_Line2";
            this.sp_Line2.Size = new System.Drawing.Size(333, 10);
            this.sp_Line2.TabIndex = 14;
            // 
            // err_TenTaiKhoan
            // 
            this.err_TenTaiKhoan.AutoSize = true;
            this.err_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_TenTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.err_TenTaiKhoan.Location = new System.Drawing.Point(421, 88);
            this.err_TenTaiKhoan.Name = "err_TenTaiKhoan";
            this.err_TenTaiKhoan.Size = new System.Drawing.Size(21, 24);
            this.err_TenTaiKhoan.TabIndex = 15;
            this.err_TenTaiKhoan.Text = "*";
            this.err_TenTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.err_TenTaiKhoan.Visible = false;
            this.err_TenTaiKhoan.MouseHover += new System.EventHandler(this.err_TenTaiKhoan_MouseHover);
            // 
            // err_MatKhau
            // 
            this.err_MatKhau.AutoSize = true;
            this.err_MatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.err_MatKhau.Location = new System.Drawing.Point(422, 140);
            this.err_MatKhau.Name = "err_MatKhau";
            this.err_MatKhau.Size = new System.Drawing.Size(21, 24);
            this.err_MatKhau.TabIndex = 16;
            this.err_MatKhau.Text = "*";
            this.err_MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.err_MatKhau.Visible = false;
            // 
            // err_NhapLaiMatKhau
            // 
            this.err_NhapLaiMatKhau.AutoSize = true;
            this.err_NhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_NhapLaiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.err_NhapLaiMatKhau.Location = new System.Drawing.Point(422, 192);
            this.err_NhapLaiMatKhau.Name = "err_NhapLaiMatKhau";
            this.err_NhapLaiMatKhau.Size = new System.Drawing.Size(21, 24);
            this.err_NhapLaiMatKhau.TabIndex = 17;
            this.err_NhapLaiMatKhau.Text = "*";
            this.err_NhapLaiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.err_NhapLaiMatKhau.Visible = false;
            // 
            // tt_HienThiLoi
            // 
            this.tt_HienThiLoi.AllowLinksHandling = true;
            this.tt_HienThiLoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_HienThiLoi.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(494, 404);
            this.Controls.Add(this.pn_Content);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán hát karaoke | Minh Đức";
            this.pn_Content.ResumeLayout(false);
            this.pn_Child.ResumeLayout(false);
            this.pn_Child.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_Content;
        private Guna.UI2.WinForms.Guna2Panel pn_Child;
        private Guna.UI2.WinForms.Guna2Separator sp_Line1;
        private Guna.UI2.WinForms.Guna2Button bt_ThemTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txt_NhapLaiMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_MatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label lb_QuyenHan;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_QuyenHan;
        private System.Windows.Forms.Label lb_NhapLaiMatKhau;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label title_TaoTaiKhoan;
        private Guna.UI2.WinForms.Guna2Separator sp_Line2;
        private Guna.UI2.WinForms.Guna2Button bt_HuyBo;
        private System.Windows.Forms.Label err_NhapLaiMatKhau;
        private System.Windows.Forms.Label err_MatKhau;
        private System.Windows.Forms.Label err_TenTaiKhoan;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tt_HienThiLoi;
    }
}