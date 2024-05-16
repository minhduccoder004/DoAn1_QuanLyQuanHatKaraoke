namespace GUI_ManagementKaraoke.NguoiDung
{
    partial class DangKy
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.lb_XacNhanMK = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_XNMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_DangKy = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lb_Title.Location = new System.Drawing.Point(58, 36);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(178, 31);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Tạo tài khoản";
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(46, 79);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(80, 15);
            this.lb_TenTaiKhoan.TabIndex = 1;
            this.lb_TenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lb_MatKhau.Location = new System.Drawing.Point(46, 205);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(58, 15);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật khẩu";
            // 
            // lb_XacNhanMK
            // 
            this.lb_XacNhanMK.AutoSize = true;
            this.lb_XacNhanMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_XacNhanMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lb_XacNhanMK.Location = new System.Drawing.Point(46, 268);
            this.lb_XacNhanMK.Name = "lb_XacNhanMK";
            this.lb_XacNhanMK.Size = new System.Drawing.Size(109, 15);
            this.lb_XacNhanMK.TabIndex = 3;
            this.lb_XacNhanMK.Text = "Xác nhận mật khẩu";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lb_Email.Location = new System.Drawing.Point(46, 142);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(35, 15);
            this.lb_Email.TabIndex = 4;
            this.lb_Email.Text = "Email";
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.BorderRadius = 15;
            this.txt_TenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenTaiKhoan.DefaultText = "";
            this.txt_TenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(49, 95);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.PasswordChar = '\0';
            this.txt_TenTaiKhoan.PlaceholderText = "";
            this.txt_TenTaiKhoan.SelectedText = "";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(200, 36);
            this.txt_TenTaiKhoan.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderRadius = 15;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(49, 158);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(200, 36);
            this.txt_Email.TabIndex = 6;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderRadius = 15;
            this.txt_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MatKhau.DefaultText = "";
            this.txt_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MatKhau.Location = new System.Drawing.Point(49, 221);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '\0';
            this.txt_MatKhau.PlaceholderText = "";
            this.txt_MatKhau.SelectedText = "";
            this.txt_MatKhau.Size = new System.Drawing.Size(200, 36);
            this.txt_MatKhau.TabIndex = 7;
            // 
            // txt_XNMatKhau
            // 
            this.txt_XNMatKhau.BorderRadius = 15;
            this.txt_XNMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_XNMatKhau.DefaultText = "";
            this.txt_XNMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_XNMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_XNMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_XNMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_XNMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_XNMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XNMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_XNMatKhau.Location = new System.Drawing.Point(49, 284);
            this.txt_XNMatKhau.Name = "txt_XNMatKhau";
            this.txt_XNMatKhau.PasswordChar = '\0';
            this.txt_XNMatKhau.PlaceholderText = "";
            this.txt_XNMatKhau.SelectedText = "";
            this.txt_XNMatKhau.Size = new System.Drawing.Size(200, 36);
            this.txt_XNMatKhau.TabIndex = 8;
            // 
            // bt_DangKy
            // 
            this.bt_DangKy.Animated = true;
            this.bt_DangKy.BorderRadius = 20;
            this.bt_DangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_DangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_DangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_DangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_DangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bt_DangKy.Location = new System.Drawing.Point(49, 337);
            this.bt_DangKy.Name = "bt_DangKy";
            this.bt_DangKy.Size = new System.Drawing.Size(200, 45);
            this.bt_DangKy.TabIndex = 9;
            this.bt_DangKy.Text = "Đăng ký";
            this.bt_DangKy.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(294, 416);
            this.Controls.Add(this.bt_DangKy);
            this.Controls.Add(this.txt_XNMatKhau);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_TenTaiKhoan);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_XacNhanMK);
            this.Controls.Add(this.lb_MatKhau);
            this.Controls.Add(this.lb_TenTaiKhoan);
            this.Controls.Add(this.lb_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_XacNhanMK;
        private System.Windows.Forms.Label lb_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_MatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_XNMatKhau;
        private Guna.UI2.WinForms.Guna2Button bt_DangKy;
    }
}