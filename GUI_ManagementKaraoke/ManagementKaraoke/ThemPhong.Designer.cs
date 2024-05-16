namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    partial class ThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhong));
            this.pn_Container = new Guna.UI2.WinForms.Guna2Panel();
            this.pn_Child = new Guna.UI2.WinForms.Guna2Panel();
            this.sp_Line2 = new Guna.UI2.WinForms.Guna2Separator();
            this.bt_XacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_TrangThaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_LoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_TenPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_TrangThaiPhong = new System.Windows.Forms.Label();
            this.lb_TenPhong = new System.Windows.Forms.Label();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.sp_Line1 = new Guna.UI2.WinForms.Guna2Separator();
            this.title_ThemPhong = new System.Windows.Forms.Label();
            this.pn_Container.SuspendLayout();
            this.pn_Child.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Container
            // 
            this.pn_Container.BorderRadius = 30;
            this.pn_Container.Controls.Add(this.pn_Child);
            this.pn_Container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.pn_Container.Location = new System.Drawing.Point(12, 12);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(461, 385);
            this.pn_Container.TabIndex = 0;
            // 
            // pn_Child
            // 
            this.pn_Child.BackColor = System.Drawing.Color.Transparent;
            this.pn_Child.Controls.Add(this.sp_Line2);
            this.pn_Child.Controls.Add(this.bt_XacNhan);
            this.pn_Child.Controls.Add(this.bt_Cancel);
            this.pn_Child.Controls.Add(this.cbb_TrangThaiPhong);
            this.pn_Child.Controls.Add(this.cbb_LoaiPhong);
            this.pn_Child.Controls.Add(this.txt_TenPhong);
            this.pn_Child.Controls.Add(this.lb_TrangThaiPhong);
            this.pn_Child.Controls.Add(this.lb_TenPhong);
            this.pn_Child.Controls.Add(this.lb_LoaiPhong);
            this.pn_Child.Controls.Add(this.sp_Line1);
            this.pn_Child.Controls.Add(this.title_ThemPhong);
            this.pn_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Child.Location = new System.Drawing.Point(0, 0);
            this.pn_Child.Name = "pn_Child";
            this.pn_Child.Size = new System.Drawing.Size(461, 385);
            this.pn_Child.TabIndex = 0;
            // 
            // sp_Line2
            // 
            this.sp_Line2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line2.Location = new System.Drawing.Point(69, 265);
            this.sp_Line2.Name = "sp_Line2";
            this.sp_Line2.Size = new System.Drawing.Size(322, 10);
            this.sp_Line2.TabIndex = 10;
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.Animated = true;
            this.bt_XacNhan.BorderRadius = 20;
            this.bt_XacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_XacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_XacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_XacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_XacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_XacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_XacNhan.ForeColor = System.Drawing.Color.White;
            this.bt_XacNhan.Image = global::GUI_ManagementKaraoke.Properties.Resources.done;
            this.bt_XacNhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_XacNhan.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_XacNhan.Location = new System.Drawing.Point(246, 294);
            this.bt_XacNhan.Name = "bt_XacNhan";
            this.bt_XacNhan.Size = new System.Drawing.Size(180, 64);
            this.bt_XacNhan.TabIndex = 9;
            this.bt_XacNhan.Text = "Xác nhận";
            this.bt_XacNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_XacNhan.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_XacNhan.Click += new System.EventHandler(this.bt_XacNhan_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Animated = true;
            this.bt_Cancel.BorderRadius = 20;
            this.bt_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.White;
            this.bt_Cancel.Image = global::GUI_ManagementKaraoke.Properties.Resources.cancel;
            this.bt_Cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_Cancel.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_Cancel.Location = new System.Drawing.Point(34, 294);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(180, 64);
            this.bt_Cancel.TabIndex = 8;
            this.bt_Cancel.Text = "Huỷ bỏ";
            this.bt_Cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_Cancel.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // cbb_TrangThaiPhong
            // 
            this.cbb_TrangThaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbb_TrangThaiPhong.BorderRadius = 15;
            this.cbb_TrangThaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_TrangThaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_TrangThaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_TrangThaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbb_TrangThaiPhong.ItemHeight = 30;
            this.cbb_TrangThaiPhong.Location = new System.Drawing.Point(197, 200);
            this.cbb_TrangThaiPhong.Name = "cbb_TrangThaiPhong";
            this.cbb_TrangThaiPhong.Size = new System.Drawing.Size(199, 36);
            this.cbb_TrangThaiPhong.TabIndex = 7;
            // 
            // cbb_LoaiPhong
            // 
            this.cbb_LoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbb_LoaiPhong.BorderRadius = 15;
            this.cbb_LoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_LoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_LoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbb_LoaiPhong.ItemHeight = 30;
            this.cbb_LoaiPhong.Location = new System.Drawing.Point(197, 90);
            this.cbb_LoaiPhong.Name = "cbb_LoaiPhong";
            this.cbb_LoaiPhong.Size = new System.Drawing.Size(199, 36);
            this.cbb_LoaiPhong.TabIndex = 6;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.BorderRadius = 15;
            this.txt_TenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenPhong.DefaultText = "";
            this.txt_TenPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_TenPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenPhong.Location = new System.Drawing.Point(197, 142);
            this.txt_TenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.PasswordChar = '\0';
            this.txt_TenPhong.PlaceholderText = "";
            this.txt_TenPhong.SelectedText = "";
            this.txt_TenPhong.Size = new System.Drawing.Size(199, 41);
            this.txt_TenPhong.TabIndex = 5;
            // 
            // lb_TrangThaiPhong
            // 
            this.lb_TrangThaiPhong.AutoSize = true;
            this.lb_TrangThaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrangThaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_TrangThaiPhong.Location = new System.Drawing.Point(61, 209);
            this.lb_TrangThaiPhong.Name = "lb_TrangThaiPhong";
            this.lb_TrangThaiPhong.Size = new System.Drawing.Size(130, 19);
            this.lb_TrangThaiPhong.TabIndex = 4;
            this.lb_TrangThaiPhong.Text = "Trạng thái phòng :";
            // 
            // lb_TenPhong
            // 
            this.lb_TenPhong.AutoSize = true;
            this.lb_TenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_TenPhong.Location = new System.Drawing.Point(103, 153);
            this.lb_TenPhong.Name = "lb_TenPhong";
            this.lb_TenPhong.Size = new System.Drawing.Size(88, 19);
            this.lb_TenPhong.TabIndex = 3;
            this.lb_TenPhong.Text = "Tên phòng :";
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.AutoSize = true;
            this.lb_LoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_LoaiPhong.Location = new System.Drawing.Point(99, 99);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(92, 19);
            this.lb_LoaiPhong.TabIndex = 2;
            this.lb_LoaiPhong.Text = "Loại phòng :";
            // 
            // sp_Line1
            // 
            this.sp_Line1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line1.Location = new System.Drawing.Point(69, 50);
            this.sp_Line1.Name = "sp_Line1";
            this.sp_Line1.Size = new System.Drawing.Size(322, 10);
            this.sp_Line1.TabIndex = 1;
            // 
            // title_ThemPhong
            // 
            this.title_ThemPhong.AutoSize = true;
            this.title_ThemPhong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_ThemPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.title_ThemPhong.Location = new System.Drawing.Point(161, 18);
            this.title_ThemPhong.Name = "title_ThemPhong";
            this.title_ThemPhong.Size = new System.Drawing.Size(139, 26);
            this.title_ThemPhong.TabIndex = 0;
            this.title_ThemPhong.Text = "Thêm phòng";
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(485, 409);
            this.Controls.Add(this.pn_Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phòng";
            this.Load += new System.EventHandler(this.ThemPhong_Load);
            this.pn_Container.ResumeLayout(false);
            this.pn_Child.ResumeLayout(false);
            this.pn_Child.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_Container;
        private Guna.UI2.WinForms.Guna2Panel pn_Child;
        private Guna.UI2.WinForms.Guna2Separator sp_Line1;
        private System.Windows.Forms.Label title_ThemPhong;
        private System.Windows.Forms.Label lb_TrangThaiPhong;
        private System.Windows.Forms.Label lb_TenPhong;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private Guna.UI2.WinForms.Guna2Separator sp_Line2;
        private Guna.UI2.WinForms.Guna2Button bt_XacNhan;
        private Guna.UI2.WinForms.Guna2Button bt_Cancel;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_TrangThaiPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_LoaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenPhong;
    }
}