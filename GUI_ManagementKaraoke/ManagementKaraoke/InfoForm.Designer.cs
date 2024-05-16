namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    partial class InfoForm
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
            this.pn_info = new Guna.UI2.WinForms.Guna2Panel();
            this.cbb_TimKiemTheo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_TimKiemTheo = new System.Windows.Forms.Label();
            this.lb_infoFrm = new System.Windows.Forms.Label();
            this.label_ChucNang = new System.Windows.Forms.Label();
            this.pn_container_search = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_ThongTinTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_info.SuspendLayout();
            this.pn_container_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_info
            // 
            this.pn_info.Controls.Add(this.cbb_TimKiemTheo);
            this.pn_info.Controls.Add(this.label_TimKiemTheo);
            this.pn_info.Controls.Add(this.lb_infoFrm);
            this.pn_info.Controls.Add(this.label_ChucNang);
            this.pn_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_info.Location = new System.Drawing.Point(0, 0);
            this.pn_info.Name = "pn_info";
            this.pn_info.Size = new System.Drawing.Size(318, 73);
            this.pn_info.TabIndex = 0;
            // 
            // cbb_TimKiemTheo
            // 
            this.cbb_TimKiemTheo.BackColor = System.Drawing.Color.Transparent;
            this.cbb_TimKiemTheo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.cbb_TimKiemTheo.BorderThickness = 0;
            this.cbb_TimKiemTheo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_TimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TimKiemTheo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.cbb_TimKiemTheo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.cbb_TimKiemTheo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.cbb_TimKiemTheo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TimKiemTheo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbb_TimKiemTheo.ItemHeight = 30;
            this.cbb_TimKiemTheo.Location = new System.Drawing.Point(128, 30);
            this.cbb_TimKiemTheo.Name = "cbb_TimKiemTheo";
            this.cbb_TimKiemTheo.Size = new System.Drawing.Size(182, 36);
            this.cbb_TimKiemTheo.TabIndex = 4;
            // 
            // label_TimKiemTheo
            // 
            this.label_TimKiemTheo.AutoSize = true;
            this.label_TimKiemTheo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimKiemTheo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.label_TimKiemTheo.Location = new System.Drawing.Point(9, 36);
            this.label_TimKiemTheo.Name = "label_TimKiemTheo";
            this.label_TimKiemTheo.Size = new System.Drawing.Size(118, 19);
            this.label_TimKiemTheo.TabIndex = 3;
            this.label_TimKiemTheo.Text = "Tìm kiếm theo : ";
            // 
            // lb_infoFrm
            // 
            this.lb_infoFrm.AutoSize = true;
            this.lb_infoFrm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoFrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_infoFrm.Location = new System.Drawing.Point(95, 10);
            this.lb_infoFrm.Name = "lb_infoFrm";
            this.lb_infoFrm.Size = new System.Drawing.Size(49, 19);
            this.lb_infoFrm.TabIndex = 1;
            this.lb_infoFrm.Text = "..........";
            this.lb_infoFrm.TextChanged += new System.EventHandler(this.lb_infoFrm_TextChanged);
            // 
            // label_ChucNang
            // 
            this.label_ChucNang.AutoSize = true;
            this.label_ChucNang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.label_ChucNang.Location = new System.Drawing.Point(12, 10);
            this.label_ChucNang.Name = "label_ChucNang";
            this.label_ChucNang.Size = new System.Drawing.Size(87, 17);
            this.label_ChucNang.TabIndex = 0;
            this.label_ChucNang.Text = "Chức năng :";
            // 
            // pn_container_search
            // 
            this.pn_container_search.Controls.Add(this.bt_TimKiem);
            this.pn_container_search.Controls.Add(this.txt_ThongTinTimKiem);
            this.pn_container_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container_search.Location = new System.Drawing.Point(318, 0);
            this.pn_container_search.Name = "pn_container_search";
            this.pn_container_search.Size = new System.Drawing.Size(539, 73);
            this.pn_container_search.TabIndex = 1;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_TimKiem.Animated = true;
            this.bt_TimKiem.BorderRadius = 20;
            this.bt_TimKiem.CustomizableEdges.BottomLeft = false;
            this.bt_TimKiem.CustomizableEdges.TopLeft = false;
            this.bt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_TimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.bt_TimKiem.Image = global::GUI_ManagementKaraoke.Properties.Resources.search;
            this.bt_TimKiem.Location = new System.Drawing.Point(451, 12);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(52, 48);
            this.bt_TimKiem.TabIndex = 1;
            this.bt_TimKiem.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txt_ThongTinTimKiem
            // 
            this.txt_ThongTinTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ThongTinTimKiem.BorderRadius = 20;
            this.txt_ThongTinTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThongTinTimKiem.DefaultText = "";
            this.txt_ThongTinTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThongTinTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThongTinTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThongTinTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThongTinTimKiem.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_ThongTinTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThongTinTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThongTinTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThongTinTimKiem.Location = new System.Drawing.Point(36, 12);
            this.txt_ThongTinTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ThongTinTimKiem.Name = "txt_ThongTinTimKiem";
            this.txt_ThongTinTimKiem.PasswordChar = '\0';
            this.txt_ThongTinTimKiem.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThongTinTimKiem.PlaceholderText = "Nhập thông tin muốn tìm kiếm ....";
            this.txt_ThongTinTimKiem.SelectedText = "";
            this.txt_ThongTinTimKiem.Size = new System.Drawing.Size(466, 48);
            this.txt_ThongTinTimKiem.TabIndex = 0;
            this.txt_ThongTinTimKiem.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(857, 73);
            this.Controls.Add(this.pn_container_search);
            this.Controls.Add(this.pn_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.pn_info.ResumeLayout(false);
            this.pn_info.PerformLayout();
            this.pn_container_search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_info;
        private System.Windows.Forms.Label label_ChucNang;
        private Guna.UI2.WinForms.Guna2Panel pn_container_search;
        private Guna.UI2.WinForms.Guna2Button bt_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThongTinTimKiem;
        private System.Windows.Forms.Label lb_infoFrm;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_TimKiemTheo;
        private System.Windows.Forms.Label label_TimKiemTheo;
    }
}