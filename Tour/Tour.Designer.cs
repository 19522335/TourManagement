namespace Tour
{
    partial class Tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tour));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_trip = new System.Windows.Forms.DataGridView();
            this.identify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongVeMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbTTransporation = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.rdbPromotional = new System.Windows.Forms.RadioButton();
            this.rdbRegular = new System.Windows.Forms.RadioButton();
            this.tb_idtrip = new System.Windows.Forms.TextBox();
            this.idTuyencb = new System.Windows.Forms.ComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_idtrip = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_dptime = new System.Windows.Forms.Label();
            this.lb_dpdate = new System.Windows.Forms.Label();
            this.lb_idtour = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gotoregistbtn = new System.Windows.Forms.Button();
            this.backtoroutebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_trip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 491);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 311);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour list";
            // 
            // dgv_trip
            // 
            this.dgv_trip.AllowUserToAddRows = false;
            this.dgv_trip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_trip.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identify,
            this.MaTuyen,
            this.MaChuyen,
            this.ThoiGianKhoiHanh,
            this.PhuongTien,
            this.SoLuongVeMax,
            this.TenLoaiChuyen,
            this.GiaVe});
            this.dgv_trip.Location = new System.Drawing.Point(19, 27);
            this.dgv_trip.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_trip.Name = "dgv_trip";
            this.dgv_trip.ReadOnly = true;
            this.dgv_trip.RowHeadersWidth = 51;
            this.dgv_trip.Size = new System.Drawing.Size(1049, 277);
            this.dgv_trip.TabIndex = 1;
            this.dgv_trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trip_CellClick_1);
            // 
            // identify
            // 
            this.identify.DataPropertyName = "ID";
            this.identify.HeaderText = "ID";
            this.identify.MinimumWidth = 6;
            this.identify.Name = "identify";
            this.identify.ReadOnly = true;
            this.identify.Visible = false;
            // 
            // MaTuyen
            // 
            this.MaTuyen.DataPropertyName = "MaTuyen";
            this.MaTuyen.HeaderText = "Route ID";
            this.MaTuyen.MinimumWidth = 6;
            this.MaTuyen.Name = "MaTuyen";
            this.MaTuyen.ReadOnly = true;
            // 
            // MaChuyen
            // 
            this.MaChuyen.DataPropertyName = "MaChuyen";
            this.MaChuyen.HeaderText = "Tour ID";
            this.MaChuyen.MinimumWidth = 6;
            this.MaChuyen.Name = "MaChuyen";
            this.MaChuyen.ReadOnly = true;
            // 
            // ThoiGianKhoiHanh
            // 
            this.ThoiGianKhoiHanh.DataPropertyName = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.HeaderText = "Departure time";
            this.ThoiGianKhoiHanh.MinimumWidth = 6;
            this.ThoiGianKhoiHanh.Name = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.ReadOnly = true;
            // 
            // PhuongTien
            // 
            this.PhuongTien.DataPropertyName = "PhuongTien";
            this.PhuongTien.HeaderText = "Transportation";
            this.PhuongTien.MinimumWidth = 6;
            this.PhuongTien.Name = "PhuongTien";
            this.PhuongTien.ReadOnly = true;
            // 
            // SoLuongVeMax
            // 
            this.SoLuongVeMax.DataPropertyName = "SoLuongVeMax";
            this.SoLuongVeMax.HeaderText = "Amount";
            this.SoLuongVeMax.MinimumWidth = 6;
            this.SoLuongVeMax.Name = "SoLuongVeMax";
            this.SoLuongVeMax.ReadOnly = true;
            // 
            // TenLoaiChuyen
            // 
            this.TenLoaiChuyen.DataPropertyName = "TenLoaiChuyen";
            this.TenLoaiChuyen.HeaderText = "Type of Tour";
            this.TenLoaiChuyen.MinimumWidth = 6;
            this.TenLoaiChuyen.Name = "TenLoaiChuyen";
            this.TenLoaiChuyen.ReadOnly = true;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Price";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(701, 444);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(369, 34);
            this.tb_search.TabIndex = 19;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.cbTTransporation);
            this.groupBox2.Controls.Add(this.tb_price);
            this.groupBox2.Controls.Add(this.rdbPromotional);
            this.groupBox2.Controls.Add(this.rdbRegular);
            this.groupBox2.Controls.Add(this.tb_idtrip);
            this.groupBox2.Controls.Add(this.idTuyencb);
            this.groupBox2.Controls.Add(this.panel14);
            this.groupBox2.Controls.Add(this.panel13);
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_idtrip);
            this.groupBox2.Controls.Add(this.lb_price);
            this.groupBox2.Controls.Add(this.lb_dptime);
            this.groupBox2.Controls.Add(this.lb_dpdate);
            this.groupBox2.Controls.Add(this.lb_idtour);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1073, 294);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour details";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(456, 223);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(45, 30);
            this.tbAmount.TabIndex = 37;
            this.tbAmount.Enter += new System.EventHandler(this.cbHour_Enter);
            // 
            // cbTTransporation
            // 
            this.cbTTransporation.BackColor = System.Drawing.SystemColors.Window;
            this.cbTTransporation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTTransporation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTTransporation.FormattingEnabled = true;
            this.cbTTransporation.Items.AddRange(new object[] {
            "Plane",
            "Passenger Car",
            "Boat",
            "Train"});
            this.cbTTransporation.Location = new System.Drawing.Point(183, 219);
            this.cbTTransporation.Margin = new System.Windows.Forms.Padding(4);
            this.cbTTransporation.Name = "cbTTransporation";
            this.cbTTransporation.Size = new System.Drawing.Size(192, 30);
            this.cbTTransporation.TabIndex = 33;
            this.cbTTransporation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbTTransporation.Enter += new System.EventHandler(this.cbTTransporation_Enter);
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(717, 223);
            this.tb_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_price.MaxLength = 25;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(271, 30);
            this.tb_price.TabIndex = 17;
            this.tb_price.Enter += new System.EventHandler(this.tb_price_Enter);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // rdbPromotional
            // 
            this.rdbPromotional.AutoSize = true;
            this.rdbPromotional.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPromotional.Location = new System.Drawing.Point(328, 162);
            this.rdbPromotional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPromotional.Name = "rdbPromotional";
            this.rdbPromotional.Size = new System.Drawing.Size(128, 26);
            this.rdbPromotional.TabIndex = 36;
            this.rdbPromotional.Text = "Promotional";
            this.rdbPromotional.UseVisualStyleBackColor = true;
            this.rdbPromotional.Enter += new System.EventHandler(this.rdbPromotional_Enter);
            // 
            // rdbRegular
            // 
            this.rdbRegular.AutoSize = true;
            this.rdbRegular.Checked = true;
            this.rdbRegular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRegular.Location = new System.Drawing.Point(171, 164);
            this.rdbRegular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbRegular.Name = "rdbRegular";
            this.rdbRegular.Size = new System.Drawing.Size(93, 26);
            this.rdbRegular.TabIndex = 35;
            this.rdbRegular.TabStop = true;
            this.rdbRegular.Text = "Regular";
            this.rdbRegular.UseVisualStyleBackColor = true;
            this.rdbRegular.Enter += new System.EventHandler(this.rdbRegular_Enter);
            // 
            // tb_idtrip
            // 
            this.tb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idtrip.Location = new System.Drawing.Point(171, 101);
            this.tb_idtrip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idtrip.MaxLength = 15;
            this.tb_idtrip.Name = "tb_idtrip";
            this.tb_idtrip.Size = new System.Drawing.Size(331, 30);
            this.tb_idtrip.TabIndex = 1;
            this.tb_idtrip.Enter += new System.EventHandler(this.tb_idtrip_Enter);
            // 
            // idTuyencb
            // 
            this.idTuyencb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idTuyencb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTuyencb.FormattingEnabled = true;
            this.idTuyencb.Location = new System.Drawing.Point(171, 47);
            this.idTuyencb.Margin = new System.Windows.Forms.Padding(4);
            this.idTuyencb.Name = "idTuyencb";
            this.idTuyencb.Size = new System.Drawing.Size(331, 30);
            this.idTuyencb.TabIndex = 29;
            this.idTuyencb.Enter += new System.EventHandler(this.idTuyencb_Enter);
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Controls.Add(this.cbMinute);
            this.panel14.Location = new System.Drawing.Point(889, 166);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(59, 30);
            this.panel14.TabIndex = 46;
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            this.cbMinute.Location = new System.Drawing.Point(-3, -2);
            this.cbMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(56, 30);
            this.cbMinute.TabIndex = 19;
            this.cbMinute.SelectedIndexChanged += new System.EventHandler(this.cbMinute_SelectedIndexChanged);
            this.cbMinute.Enter += new System.EventHandler(this.cbMinute_Enter);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.cbHour);
            this.panel13.Location = new System.Drawing.Point(719, 165);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(57, 30);
            this.panel13.TabIndex = 42;
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
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
            this.cbHour.Location = new System.Drawing.Point(-3, -4);
            this.cbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(56, 30);
            this.cbHour.TabIndex = 19;
            this.cbHour.Enter += new System.EventHandler(this.cbHour_Enter);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.dtpKhoiHanh);
            this.panel11.Location = new System.Drawing.Point(717, 102);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(332, 30);
            this.panel11.TabIndex = 41;
            // 
            // dtpKhoiHanh
            // 
            this.dtpKhoiHanh.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKhoiHanh.Location = new System.Drawing.Point(-1, -4);
            this.dtpKhoiHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKhoiHanh.Name = "dtpKhoiHanh";
            this.dtpKhoiHanh.Size = new System.Drawing.Size(331, 30);
            this.dtpKhoiHanh.TabIndex = 30;
            this.dtpKhoiHanh.Enter += new System.EventHandler(this.dtpKhoiHanh_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(995, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ticket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Transportation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Type of travel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Minute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hour";
            // 
            // lb_idtrip
            // 
            this.lb_idtrip.AutoSize = true;
            this.lb_idtrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtrip.Location = new System.Drawing.Point(9, 103);
            this.lb_idtrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idtrip.Name = "lb_idtrip";
            this.lb_idtrip.Size = new System.Drawing.Size(72, 22);
            this.lb_idtrip.TabIndex = 20;
            this.lb_idtrip.Text = "Tour ID";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(611, 225);
            this.lb_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(52, 22);
            this.lb_price.TabIndex = 5;
            this.lb_price.Text = "Price";
            // 
            // lb_dptime
            // 
            this.lb_dptime.AutoSize = true;
            this.lb_dptime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dptime.Location = new System.Drawing.Point(560, 164);
            this.lb_dptime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dptime.Name = "lb_dptime";
            this.lb_dptime.Size = new System.Drawing.Size(128, 22);
            this.lb_dptime.TabIndex = 3;
            this.lb_dptime.Text = "Departure time";
            // 
            // lb_dpdate
            // 
            this.lb_dpdate.AutoSize = true;
            this.lb_dpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dpdate.Location = new System.Drawing.Point(560, 101);
            this.lb_dpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dpdate.Name = "lb_dpdate";
            this.lb_dpdate.Size = new System.Drawing.Size(127, 22);
            this.lb_dpdate.TabIndex = 2;
            this.lb_dpdate.Text = "Departure date";
            // 
            // lb_idtour
            // 
            this.lb_idtour.AutoSize = true;
            this.lb_idtour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idtour.Location = new System.Drawing.Point(9, 50);
            this.lb_idtour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idtour.Name = "lb_idtour";
            this.lb_idtour.Size = new System.Drawing.Size(81, 22);
            this.lb_idtour.TabIndex = 0;
            this.lb_idtour.Text = "Route ID";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Tour.Properties.Resources.addp;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(35, 437);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 47);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "   ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Tour.Properties.Resources.deleteicon;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(332, 437);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 47);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = global::Tour.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(491, 437);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "  EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImage = global::Tour.Properties.Resources.Btn3;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::Tour.Properties.Resources.update;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(176, 437);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(133, 47);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tour.Properties.Resources.Tour1;
            this.panel1.Controls.Add(this.gotoregistbtn);
            this.panel1.Controls.Add(this.backtoroutebtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 95);
            this.panel1.TabIndex = 47;
            // 
            // gotoregistbtn
            // 
            this.gotoregistbtn.BackColor = System.Drawing.Color.Transparent;
            this.gotoregistbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gotoregistbtn.BackgroundImage")));
            this.gotoregistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gotoregistbtn.FlatAppearance.BorderSize = 0;
            this.gotoregistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotoregistbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoregistbtn.Location = new System.Drawing.Point(892, 15);
            this.gotoregistbtn.Margin = new System.Windows.Forms.Padding(4);
            this.gotoregistbtn.Name = "gotoregistbtn";
            this.gotoregistbtn.Size = new System.Drawing.Size(232, 55);
            this.gotoregistbtn.TabIndex = 10;
            this.gotoregistbtn.Text = "Go to Ticket Register";
            this.gotoregistbtn.UseVisualStyleBackColor = true;
            this.gotoregistbtn.Click += new System.EventHandler(this.gotoregistbtn_Click);
            // 
            // backtoroutebtn
            // 
            this.backtoroutebtn.BackColor = System.Drawing.Color.Transparent;
            this.backtoroutebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backtoroutebtn.BackgroundImage")));
            this.backtoroutebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoroutebtn.FlatAppearance.BorderSize = 0;
            this.backtoroutebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtoroutebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoroutebtn.Location = new System.Drawing.Point(4, 15);
            this.backtoroutebtn.Margin = new System.Windows.Forms.Padding(4);
            this.backtoroutebtn.Name = "backtoroutebtn";
            this.backtoroutebtn.Size = new System.Drawing.Size(164, 55);
            this.backtoroutebtn.TabIndex = 10;
            this.backtoroutebtn.Text = "Back to Route";
            this.backtoroutebtn.UseVisualStyleBackColor = true;
            this.backtoroutebtn.Click += new System.EventHandler(this.backtoroutebtn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(149, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(795, 94);
            this.label8.TabIndex = 44;
            this.label8.Text = "TOUR MANAGEMENT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1124, 807);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.TRIPManageTour_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trip)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dgv_trip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button backtoroutebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button gotoregistbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbTTransporation;
        private System.Windows.Forms.RadioButton rdbRegular;
        private System.Windows.Forms.RadioButton rdbPromotional;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker dtpKhoiHanh;
        private System.Windows.Forms.TextBox tb_idtrip;
        private System.Windows.Forms.ComboBox idTuyencb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_idtrip;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_dptime;
        private System.Windows.Forms.Label lb_dpdate;
        private System.Windows.Forms.Label lb_idtour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identify;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongVeMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
    }
}