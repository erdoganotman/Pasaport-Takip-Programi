namespace PASSPORTLOG
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almanyaEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amerikaEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italyaEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingiltereEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fransaEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hollandaEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yunanEvrakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpasaportnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpbaslangicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpbitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmakamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mseyahatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet1 = new PASSPORTLOG.userDataSet();
            this.musteri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.musteri1TableAdapter1 = new PASSPORTLOG.userDataSetTableAdapters.musteri1TableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBulToolStripMenuItem,
            this.müşteriBilgileriniDüzenleToolStripMenuItem,
            this.kayıtBulToolStripMenuItem,
            this.randevuBulToolStripMenuItem,
            this.evrakListesiToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriBulToolStripMenuItem
            // 
            this.müşteriBulToolStripMenuItem.Name = "müşteriBulToolStripMenuItem";
            this.müşteriBulToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.müşteriBulToolStripMenuItem.Text = "Kayıt Oluştur";
            this.müşteriBulToolStripMenuItem.Click += new System.EventHandler(this.müşteriBulToolStripMenuItem_Click);
            // 
            // müşteriBilgileriniDüzenleToolStripMenuItem
            // 
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Name = "müşteriBilgileriniDüzenleToolStripMenuItem";
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Text = "Kayıt Düzenle";
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // kayıtBulToolStripMenuItem
            // 
            this.kayıtBulToolStripMenuItem.Name = "kayıtBulToolStripMenuItem";
            this.kayıtBulToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.kayıtBulToolStripMenuItem.Text = "Kayıtları Listele";
            this.kayıtBulToolStripMenuItem.Click += new System.EventHandler(this.kayıtBulToolStripMenuItem_Click);
            // 
            // randevuBulToolStripMenuItem
            // 
            this.randevuBulToolStripMenuItem.Name = "randevuBulToolStripMenuItem";
            this.randevuBulToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.randevuBulToolStripMenuItem.Text = "Randevu Bul";
            // 
            // evrakListesiToolStripMenuItem
            // 
            this.evrakListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almanyaEvrakListesiToolStripMenuItem,
            this.amerikaEvrakListesiToolStripMenuItem,
            this.italyaEvrakListesiToolStripMenuItem,
            this.ingiltereEvrakListesiToolStripMenuItem,
            this.fransaEvrakListesiToolStripMenuItem,
            this.hollandaEvrakListesiToolStripMenuItem,
            this.yunanEvrakListesiToolStripMenuItem});
            this.evrakListesiToolStripMenuItem.Name = "evrakListesiToolStripMenuItem";
            this.evrakListesiToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.evrakListesiToolStripMenuItem.Text = "Evrak Listesi";
            // 
            // almanyaEvrakListesiToolStripMenuItem
            // 
            this.almanyaEvrakListesiToolStripMenuItem.Name = "almanyaEvrakListesiToolStripMenuItem";
            this.almanyaEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.almanyaEvrakListesiToolStripMenuItem.Text = "Almanya Evrak Listesi";
            // 
            // amerikaEvrakListesiToolStripMenuItem
            // 
            this.amerikaEvrakListesiToolStripMenuItem.Name = "amerikaEvrakListesiToolStripMenuItem";
            this.amerikaEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.amerikaEvrakListesiToolStripMenuItem.Text = "Amerika Evrak Listesi";
            // 
            // italyaEvrakListesiToolStripMenuItem
            // 
            this.italyaEvrakListesiToolStripMenuItem.Name = "italyaEvrakListesiToolStripMenuItem";
            this.italyaEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.italyaEvrakListesiToolStripMenuItem.Text = "İtalya Evrak Listesi";
            // 
            // ingiltereEvrakListesiToolStripMenuItem
            // 
            this.ingiltereEvrakListesiToolStripMenuItem.Name = "ingiltereEvrakListesiToolStripMenuItem";
            this.ingiltereEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ingiltereEvrakListesiToolStripMenuItem.Text = "İngiltere Evrak Listesi";
            // 
            // fransaEvrakListesiToolStripMenuItem
            // 
            this.fransaEvrakListesiToolStripMenuItem.Name = "fransaEvrakListesiToolStripMenuItem";
            this.fransaEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fransaEvrakListesiToolStripMenuItem.Text = "Fransa Evrak Listesi";
            // 
            // hollandaEvrakListesiToolStripMenuItem
            // 
            this.hollandaEvrakListesiToolStripMenuItem.Name = "hollandaEvrakListesiToolStripMenuItem";
            this.hollandaEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.hollandaEvrakListesiToolStripMenuItem.Text = "Hollanda Evrak Listesi";
            // 
            // yunanEvrakListesiToolStripMenuItem
            // 
            this.yunanEvrakListesiToolStripMenuItem.Name = "yunanEvrakListesiToolStripMenuItem";
            this.yunanEvrakListesiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.yunanEvrakListesiToolStripMenuItem.Text = "Yunan Evrak Listesi";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(453, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 489);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yarının İşleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.mdogumtarihiDataGridViewTextBoxColumn,
            this.mtcDataGridViewTextBoxColumn,
            this.mpasaportnoDataGridViewTextBoxColumn,
            this.mpbaslangicDataGridViewTextBoxColumn,
            this.mpbitisDataGridViewTextBoxColumn,
            this.mmakamDataGridViewTextBoxColumn,
            this.mseyahatDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.madresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteri1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "m_adi";
            this.dataGridViewTextBoxColumn1.HeaderText = "m_adi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "m_soyadi";
            this.dataGridViewTextBoxColumn2.HeaderText = "m_soyadi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // mdogumtarihiDataGridViewTextBoxColumn
            // 
            this.mdogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "m_dogumtarihi";
            this.mdogumtarihiDataGridViewTextBoxColumn.HeaderText = "m_dogumtarihi";
            this.mdogumtarihiDataGridViewTextBoxColumn.Name = "mdogumtarihiDataGridViewTextBoxColumn";
            this.mdogumtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtcDataGridViewTextBoxColumn
            // 
            this.mtcDataGridViewTextBoxColumn.DataPropertyName = "m_tc";
            this.mtcDataGridViewTextBoxColumn.HeaderText = "m_tc";
            this.mtcDataGridViewTextBoxColumn.Name = "mtcDataGridViewTextBoxColumn";
            this.mtcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpasaportnoDataGridViewTextBoxColumn
            // 
            this.mpasaportnoDataGridViewTextBoxColumn.DataPropertyName = "m_pasaportno";
            this.mpasaportnoDataGridViewTextBoxColumn.HeaderText = "m_pasaportno";
            this.mpasaportnoDataGridViewTextBoxColumn.Name = "mpasaportnoDataGridViewTextBoxColumn";
            this.mpasaportnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpbaslangicDataGridViewTextBoxColumn
            // 
            this.mpbaslangicDataGridViewTextBoxColumn.DataPropertyName = "m_pbaslangic";
            this.mpbaslangicDataGridViewTextBoxColumn.HeaderText = "m_pbaslangic";
            this.mpbaslangicDataGridViewTextBoxColumn.Name = "mpbaslangicDataGridViewTextBoxColumn";
            this.mpbaslangicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpbitisDataGridViewTextBoxColumn
            // 
            this.mpbitisDataGridViewTextBoxColumn.DataPropertyName = "m_pbitis";
            this.mpbitisDataGridViewTextBoxColumn.HeaderText = "m_pbitis";
            this.mpbitisDataGridViewTextBoxColumn.Name = "mpbitisDataGridViewTextBoxColumn";
            this.mpbitisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mmakamDataGridViewTextBoxColumn
            // 
            this.mmakamDataGridViewTextBoxColumn.DataPropertyName = "m_makam";
            this.mmakamDataGridViewTextBoxColumn.HeaderText = "m_makam";
            this.mmakamDataGridViewTextBoxColumn.Name = "mmakamDataGridViewTextBoxColumn";
            this.mmakamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mseyahatDataGridViewTextBoxColumn
            // 
            this.mseyahatDataGridViewTextBoxColumn.DataPropertyName = "m_seyahat";
            this.mseyahatDataGridViewTextBoxColumn.HeaderText = "m_seyahat";
            this.mseyahatDataGridViewTextBoxColumn.Name = "mseyahatDataGridViewTextBoxColumn";
            this.mseyahatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "m_randevu";
            this.dataGridViewTextBoxColumn3.HeaderText = "m_randevu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "m_ulke";
            this.dataGridViewTextBoxColumn4.HeaderText = "m_ulke";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "m_gsm";
            this.dataGridViewTextBoxColumn5.HeaderText = "m_gsm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // madresDataGridViewTextBoxColumn
            // 
            this.madresDataGridViewTextBoxColumn.DataPropertyName = "m_adres";
            this.madresDataGridViewTextBoxColumn.HeaderText = "m_adres";
            this.madresDataGridViewTextBoxColumn.Name = "madresDataGridViewTextBoxColumn";
            this.madresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteri1BindingSource1
            // 
            this.musteri1BindingSource1.DataMember = "musteri1";
            this.musteri1BindingSource1.DataSource = this.userDataSet1;
            // 
            // userDataSet1
            // 
            this.userDataSet1.DataSetName = "userDataSet";
            this.userDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarm Kur";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Alarmı Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarm Kuruldu";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(284, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alarmı Kur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm İçin Saat Seçiniz";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 114);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Günlük Döviz Kuru";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 211);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // musteri1TableAdapter1
            // 
            this.musteri1TableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kdv Hesaplanacak Rakamı Giriniz :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Pasaport Takip Programı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtBulToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource musteri1BindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn mrandevuDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem almanyaEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amerikaEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italyaEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingiltereEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fransaEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hollandaEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yunanEvrakListesiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private userDataSet userDataSet1;
        private System.Windows.Forms.BindingSource musteri1BindingSource1;
        private userDataSetTableAdapters.musteri1TableAdapter musteri1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpasaportnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpbaslangicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpbitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmakamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mseyahatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn madresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}