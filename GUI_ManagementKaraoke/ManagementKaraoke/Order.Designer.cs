namespace GUI_ManagementKaraoke.ManagementKaraoke
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.title_Order = new System.Windows.Forms.Label();
            this.so_Line2 = new Guna.UI2.WinForms.Guna2Separator();
            this.lb_LoaiHang = new System.Windows.Forms.Label();
            this.lb_MatHang = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.nud_SoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_DichVu = new System.Windows.Forms.Label();
            this.ck_GoiDichVu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sp_Line3 = new Guna.UI2.WinForms.Guna2Separator();
            this.txt_LoaiHang = new System.Windows.Forms.Label();
            this.bt_HuyBo = new Guna.UI2.WinForms.Guna2Button();
            this.txt_MatHang = new System.Windows.Forms.Label();
            this.cbb_DichVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bt_DatHang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_Reload = new Guna.UI2.WinForms.Guna2Button();
            this.lb_TimKiem = new System.Windows.Forms.Label();
            this.dgv_DanhSachMatHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.sp_Line1 = new Guna.UI2.WinForms.Guna2Separator();
            this.title_DanhSachMatHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // title_Order
            // 
            this.title_Order.AutoSize = true;
            this.title_Order.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.title_Order.Location = new System.Drawing.Point(131, 11);
            this.title_Order.Name = "title_Order";
            this.title_Order.Size = new System.Drawing.Size(86, 31);
            this.title_Order.TabIndex = 0;
            this.title_Order.Text = "Order";
            // 
            // so_Line2
            // 
            this.so_Line2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.so_Line2.Location = new System.Drawing.Point(44, 48);
            this.so_Line2.Name = "so_Line2";
            this.so_Line2.Size = new System.Drawing.Size(261, 10);
            this.so_Line2.TabIndex = 1;
            // 
            // lb_LoaiHang
            // 
            this.lb_LoaiHang.AutoSize = true;
            this.lb_LoaiHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_LoaiHang.Location = new System.Drawing.Point(64, 75);
            this.lb_LoaiHang.Name = "lb_LoaiHang";
            this.lb_LoaiHang.Size = new System.Drawing.Size(84, 19);
            this.lb_LoaiHang.TabIndex = 2;
            this.lb_LoaiHang.Text = "Loại hàng :";
            // 
            // lb_MatHang
            // 
            this.lb_MatHang.AutoSize = true;
            this.lb_MatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_MatHang.Location = new System.Drawing.Point(65, 120);
            this.lb_MatHang.Name = "lb_MatHang";
            this.lb_MatHang.Size = new System.Drawing.Size(83, 19);
            this.lb_MatHang.TabIndex = 3;
            this.lb_MatHang.Text = "Mặt hàng :";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_SoLuong.Location = new System.Drawing.Point(70, 165);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(78, 19);
            this.lb_SoLuong.TabIndex = 4;
            this.lb_SoLuong.Text = "Số lượng :";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nud_SoLuong.BorderRadius = 15;
            this.nud_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.nud_SoLuong.Location = new System.Drawing.Point(155, 159);
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(127, 36);
            this.nud_SoLuong.TabIndex = 8;
            this.nud_SoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(582, 11);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(348, 464);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lb_DichVu);
            this.guna2Panel2.Controls.Add(this.ck_GoiDichVu);
            this.guna2Panel2.Controls.Add(this.sp_Line3);
            this.guna2Panel2.Controls.Add(this.txt_LoaiHang);
            this.guna2Panel2.Controls.Add(this.bt_HuyBo);
            this.guna2Panel2.Controls.Add(this.txt_MatHang);
            this.guna2Panel2.Controls.Add(this.cbb_DichVu);
            this.guna2Panel2.Controls.Add(this.title_Order);
            this.guna2Panel2.Controls.Add(this.so_Line2);
            this.guna2Panel2.Controls.Add(this.lb_LoaiHang);
            this.guna2Panel2.Controls.Add(this.lb_MatHang);
            this.guna2Panel2.Controls.Add(this.nud_SoLuong);
            this.guna2Panel2.Controls.Add(this.lb_SoLuong);
            this.guna2Panel2.Controls.Add(this.bt_DatHang);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(348, 464);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lb_DichVu
            // 
            this.lb_DichVu.AutoSize = true;
            this.lb_DichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_DichVu.Location = new System.Drawing.Point(40, 254);
            this.lb_DichVu.Name = "lb_DichVu";
            this.lb_DichVu.Size = new System.Drawing.Size(69, 19);
            this.lb_DichVu.TabIndex = 7;
            this.lb_DichVu.Text = "Dịch vụ :";
            // 
            // ck_GoiDichVu
            // 
            this.ck_GoiDichVu.AutoSize = true;
            this.ck_GoiDichVu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_GoiDichVu.CheckedState.BorderRadius = 2;
            this.ck_GoiDichVu.CheckedState.BorderThickness = 0;
            this.ck_GoiDichVu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ck_GoiDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_GoiDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.ck_GoiDichVu.Location = new System.Drawing.Point(68, 218);
            this.ck_GoiDichVu.Name = "ck_GoiDichVu";
            this.ck_GoiDichVu.Size = new System.Drawing.Size(103, 23);
            this.ck_GoiDichVu.TabIndex = 13;
            this.ck_GoiDichVu.Text = "Gọi dịch vụ";
            this.ck_GoiDichVu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_GoiDichVu.UncheckedState.BorderRadius = 2;
            this.ck_GoiDichVu.UncheckedState.BorderThickness = 0;
            this.ck_GoiDichVu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ck_GoiDichVu.CheckedChanged += new System.EventHandler(this.ck_GoiDichVu_CheckedChanged);
            // 
            // sp_Line3
            // 
            this.sp_Line3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line3.Location = new System.Drawing.Point(44, 339);
            this.sp_Line3.Name = "sp_Line3";
            this.sp_Line3.Size = new System.Drawing.Size(261, 10);
            this.sp_Line3.TabIndex = 13;
            // 
            // txt_LoaiHang
            // 
            this.txt_LoaiHang.AutoSize = true;
            this.txt_LoaiHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_LoaiHang.Location = new System.Drawing.Point(155, 75);
            this.txt_LoaiHang.Name = "txt_LoaiHang";
            this.txt_LoaiHang.Size = new System.Drawing.Size(129, 19);
            this.txt_LoaiHang.TabIndex = 12;
            this.txt_LoaiHang.Text = "..............................";
            // 
            // bt_HuyBo
            // 
            this.bt_HuyBo.BorderRadius = 20;
            this.bt_HuyBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_HuyBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_HuyBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_HuyBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_HuyBo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_HuyBo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.bt_HuyBo.ForeColor = System.Drawing.Color.White;
            this.bt_HuyBo.Image = global::GUI_ManagementKaraoke.Properties.Resources.cancel;
            this.bt_HuyBo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_HuyBo.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_HuyBo.Location = new System.Drawing.Point(17, 370);
            this.bt_HuyBo.Name = "bt_HuyBo";
            this.bt_HuyBo.Size = new System.Drawing.Size(140, 67);
            this.bt_HuyBo.TabIndex = 10;
            this.bt_HuyBo.Text = "Huỷ bỏ";
            this.bt_HuyBo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_HuyBo.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_HuyBo.Click += new System.EventHandler(this.bt_HuyBo_Click);
            // 
            // txt_MatHang
            // 
            this.txt_MatHang.AutoSize = true;
            this.txt_MatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_MatHang.Location = new System.Drawing.Point(155, 120);
            this.txt_MatHang.Name = "txt_MatHang";
            this.txt_MatHang.Size = new System.Drawing.Size(129, 19);
            this.txt_MatHang.TabIndex = 9;
            this.txt_MatHang.Text = "..............................";
            // 
            // cbb_DichVu
            // 
            this.cbb_DichVu.BackColor = System.Drawing.Color.Transparent;
            this.cbb_DichVu.BorderRadius = 10;
            this.cbb_DichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_DichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DichVu.Enabled = false;
            this.cbb_DichVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DichVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.cbb_DichVu.ItemHeight = 30;
            this.cbb_DichVu.Location = new System.Drawing.Point(35, 279);
            this.cbb_DichVu.Name = "cbb_DichVu";
            this.cbb_DichVu.Size = new System.Drawing.Size(279, 36);
            this.cbb_DichVu.TabIndex = 9;
            this.cbb_DichVu.SelectedIndexChanged += new System.EventHandler(this.cbb_DichVu_SelectedIndexChanged);
            // 
            // bt_DatHang
            // 
            this.bt_DatHang.BorderRadius = 20;
            this.bt_DatHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_DatHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_DatHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_DatHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_DatHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_DatHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DatHang.ForeColor = System.Drawing.Color.White;
            this.bt_DatHang.Image = global::GUI_ManagementKaraoke.Properties.Resources.order;
            this.bt_DatHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_DatHang.ImageOffset = new System.Drawing.Point(10, 0);
            this.bt_DatHang.Location = new System.Drawing.Point(192, 370);
            this.bt_DatHang.Name = "bt_DatHang";
            this.bt_DatHang.Size = new System.Drawing.Size(140, 67);
            this.bt_DatHang.TabIndex = 7;
            this.bt_DatHang.Text = "Đặt hàng";
            this.bt_DatHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_DatHang.TextOffset = new System.Drawing.Point(15, 0);
            this.bt_DatHang.Click += new System.EventHandler(this.bt_DatHang_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.CustomizableEdges.BottomRight = false;
            this.guna2Panel3.CustomizableEdges.TopRight = false;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.guna2Panel3.Location = new System.Drawing.Point(12, 11);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(564, 464);
            this.guna2Panel3.TabIndex = 12;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.Controls.Add(this.bt_Reload);
            this.guna2Panel4.Controls.Add(this.lb_TimKiem);
            this.guna2Panel4.Controls.Add(this.dgv_DanhSachMatHang);
            this.guna2Panel4.Controls.Add(this.txt_TimKiem);
            this.guna2Panel4.Controls.Add(this.sp_Line1);
            this.guna2Panel4.Controls.Add(this.title_DanhSachMatHang);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(564, 464);
            this.guna2Panel4.TabIndex = 0;
            // 
            // bt_Reload
            // 
            this.bt_Reload.BorderRadius = 10;
            this.bt_Reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.bt_Reload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Reload.ForeColor = System.Drawing.Color.White;
            this.bt_Reload.Image = global::GUI_ManagementKaraoke.Properties.Resources.refresh;
            this.bt_Reload.ImageOffset = new System.Drawing.Point(1, 0);
            this.bt_Reload.Location = new System.Drawing.Point(471, 61);
            this.bt_Reload.Name = "bt_Reload";
            this.bt_Reload.Size = new System.Drawing.Size(57, 45);
            this.bt_Reload.TabIndex = 17;
            this.bt_Reload.Click += new System.EventHandler(this.bt_Reload_Click);
            // 
            // lb_TimKiem
            // 
            this.lb_TimKiem.AutoSize = true;
            this.lb_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lb_TimKiem.Location = new System.Drawing.Point(34, 75);
            this.lb_TimKiem.Name = "lb_TimKiem";
            this.lb_TimKiem.Size = new System.Drawing.Size(81, 19);
            this.lb_TimKiem.TabIndex = 16;
            this.lb_TimKiem.Text = "Tìm kiếm :";
            // 
            // dgv_DanhSachMatHang
            // 
            this.dgv_DanhSachMatHang.AllowUserToAddRows = false;
            this.dgv_DanhSachMatHang.AllowUserToDeleteRows = false;
            this.dgv_DanhSachMatHang.AllowUserToResizeColumns = false;
            this.dgv_DanhSachMatHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgv_DanhSachMatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachMatHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DanhSachMatHang.ColumnHeadersHeight = 60;
            this.dgv_DanhSachMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachMatHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DanhSachMatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgv_DanhSachMatHang.Location = new System.Drawing.Point(15, 116);
            this.dgv_DanhSachMatHang.Name = "dgv_DanhSachMatHang";
            this.dgv_DanhSachMatHang.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachMatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DanhSachMatHang.RowHeadersVisible = false;
            this.dgv_DanhSachMatHang.RowTemplate.Height = 50;
            this.dgv_DanhSachMatHang.Size = new System.Drawing.Size(534, 325);
            this.dgv_DanhSachMatHang.TabIndex = 15;
            this.dgv_DanhSachMatHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgv_DanhSachMatHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgv_DanhSachMatHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DanhSachMatHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachMatHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachMatHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DanhSachMatHang.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.dgv_DanhSachMatHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DanhSachMatHang.ThemeStyle.HeaderStyle.Height = 60;
            this.dgv_DanhSachMatHang.ThemeStyle.ReadOnly = true;
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.Height = 50;
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgv_DanhSachMatHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_DanhSachMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMatHang_CellClick);
            this.dgv_DanhSachMatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DanhSachMatHang_CellFormatting);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderRadius = 10;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(122, 62);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PasswordChar = '\0';
            this.txt_TimKiem.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.PlaceholderText = "Nhập tên mặt hàng muốn tìm kiếm ...........";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(331, 45);
            this.txt_TimKiem.TabIndex = 14;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // sp_Line1
            // 
            this.sp_Line1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.sp_Line1.Location = new System.Drawing.Point(38, 45);
            this.sp_Line1.Name = "sp_Line1";
            this.sp_Line1.Size = new System.Drawing.Size(461, 10);
            this.sp_Line1.TabIndex = 13;
            // 
            // title_DanhSachMatHang
            // 
            this.title_DanhSachMatHang.AutoSize = true;
            this.title_DanhSachMatHang.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_DanhSachMatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.title_DanhSachMatHang.Location = new System.Drawing.Point(171, 11);
            this.title_DanhSachMatHang.Name = "title_DanhSachMatHang";
            this.title_DanhSachMatHang.Size = new System.Drawing.Size(253, 31);
            this.title_DanhSachMatHang.TabIndex = 0;
            this.title_DanhSachMatHang.Text = "Danh sách mặt hàng";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(942, 487);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán hát karaoke | Minh Đức";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_Order;
        private Guna.UI2.WinForms.Guna2Separator so_Line2;
        private System.Windows.Forms.Label lb_LoaiHang;
        private System.Windows.Forms.Label lb_MatHang;
        private System.Windows.Forms.Label lb_SoLuong;
        private Guna.UI2.WinForms.Guna2Button bt_DatHang;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_SoLuong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label txt_LoaiHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label txt_MatHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lb_TimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DanhSachMatHang;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Separator sp_Line1;
        private System.Windows.Forms.Label title_DanhSachMatHang;
        private Guna.UI2.WinForms.Guna2Separator sp_Line3;
        private Guna.UI2.WinForms.Guna2Button bt_Reload;
        private System.Windows.Forms.Label lb_DichVu;
        private Guna.UI2.WinForms.Guna2Button bt_HuyBo;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_DichVu;
        private Guna.UI2.WinForms.Guna2CheckBox ck_GoiDichVu;
    }
}