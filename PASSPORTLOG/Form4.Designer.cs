namespace PASSPORTLOG
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userDataSet = new PASSPORTLOG.userDataSet();
            this.musteri1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteri1TableAdapter = new PASSPORTLOG.userDataSetTableAdapters.musteri1TableAdapter();
            this.madiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpasaportnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpbaslangicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpbitisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmakamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mseyahatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrandevuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mulkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madiDataGridViewTextBoxColumn,
            this.msoyadiDataGridViewTextBoxColumn,
            this.mdogumtarihiDataGridViewTextBoxColumn,
            this.mtcDataGridViewTextBoxColumn,
            this.mgsmDataGridViewTextBoxColumn,
            this.mpasaportnoDataGridViewTextBoxColumn,
            this.mpbaslangicDataGridViewTextBoxColumn,
            this.mpbitisDataGridViewTextBoxColumn,
            this.mmakamDataGridViewTextBoxColumn,
            this.mseyahatDataGridViewTextBoxColumn,
            this.mrandevuDataGridViewTextBoxColumn,
            this.mulkeDataGridViewTextBoxColumn,
            this.madresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteri1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 626);
            this.dataGridView1.TabIndex = 0;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "userDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteri1BindingSource
            // 
            this.musteri1BindingSource.DataMember = "musteri1";
            this.musteri1BindingSource.DataSource = this.userDataSet;
            // 
            // musteri1TableAdapter
            // 
            this.musteri1TableAdapter.ClearBeforeFill = true;
            // 
            // madiDataGridViewTextBoxColumn
            // 
            this.madiDataGridViewTextBoxColumn.DataPropertyName = "m_adi";
            this.madiDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.madiDataGridViewTextBoxColumn.Name = "madiDataGridViewTextBoxColumn";
            this.madiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msoyadiDataGridViewTextBoxColumn
            // 
            this.msoyadiDataGridViewTextBoxColumn.DataPropertyName = "m_soyadi";
            this.msoyadiDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.msoyadiDataGridViewTextBoxColumn.Name = "msoyadiDataGridViewTextBoxColumn";
            this.msoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdogumtarihiDataGridViewTextBoxColumn
            // 
            this.mdogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "m_dogumtarihi";
            this.mdogumtarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.mdogumtarihiDataGridViewTextBoxColumn.Name = "mdogumtarihiDataGridViewTextBoxColumn";
            this.mdogumtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mtcDataGridViewTextBoxColumn
            // 
            this.mtcDataGridViewTextBoxColumn.DataPropertyName = "m_tc";
            this.mtcDataGridViewTextBoxColumn.HeaderText = "T.C Kimlik No";
            this.mtcDataGridViewTextBoxColumn.Name = "mtcDataGridViewTextBoxColumn";
            this.mtcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mgsmDataGridViewTextBoxColumn
            // 
            this.mgsmDataGridViewTextBoxColumn.DataPropertyName = "m_gsm";
            this.mgsmDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.mgsmDataGridViewTextBoxColumn.Name = "mgsmDataGridViewTextBoxColumn";
            this.mgsmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpasaportnoDataGridViewTextBoxColumn
            // 
            this.mpasaportnoDataGridViewTextBoxColumn.DataPropertyName = "m_pasaportno";
            this.mpasaportnoDataGridViewTextBoxColumn.HeaderText = "Pasaport No";
            this.mpasaportnoDataGridViewTextBoxColumn.Name = "mpasaportnoDataGridViewTextBoxColumn";
            this.mpasaportnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpbaslangicDataGridViewTextBoxColumn
            // 
            this.mpbaslangicDataGridViewTextBoxColumn.DataPropertyName = "m_pbaslangic";
            this.mpbaslangicDataGridViewTextBoxColumn.HeaderText = "Pasaport Başlangıç Tarihi";
            this.mpbaslangicDataGridViewTextBoxColumn.Name = "mpbaslangicDataGridViewTextBoxColumn";
            this.mpbaslangicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mpbitisDataGridViewTextBoxColumn
            // 
            this.mpbitisDataGridViewTextBoxColumn.DataPropertyName = "m_pbitis";
            this.mpbitisDataGridViewTextBoxColumn.HeaderText = "Pasaport Bitiş Tarihi";
            this.mpbitisDataGridViewTextBoxColumn.Name = "mpbitisDataGridViewTextBoxColumn";
            this.mpbitisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mmakamDataGridViewTextBoxColumn
            // 
            this.mmakamDataGridViewTextBoxColumn.DataPropertyName = "m_makam";
            this.mmakamDataGridViewTextBoxColumn.HeaderText = "Verildiği Makam";
            this.mmakamDataGridViewTextBoxColumn.Name = "mmakamDataGridViewTextBoxColumn";
            this.mmakamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mseyahatDataGridViewTextBoxColumn
            // 
            this.mseyahatDataGridViewTextBoxColumn.DataPropertyName = "m_seyahat";
            this.mseyahatDataGridViewTextBoxColumn.HeaderText = "Seyahat Tarihi";
            this.mseyahatDataGridViewTextBoxColumn.Name = "mseyahatDataGridViewTextBoxColumn";
            this.mseyahatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mrandevuDataGridViewTextBoxColumn
            // 
            this.mrandevuDataGridViewTextBoxColumn.DataPropertyName = "m_randevu";
            this.mrandevuDataGridViewTextBoxColumn.HeaderText = "Randevu Tarihi";
            this.mrandevuDataGridViewTextBoxColumn.Name = "mrandevuDataGridViewTextBoxColumn";
            this.mrandevuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mulkeDataGridViewTextBoxColumn
            // 
            this.mulkeDataGridViewTextBoxColumn.DataPropertyName = "m_ulke";
            this.mulkeDataGridViewTextBoxColumn.HeaderText = "Başvurulacak Ülke";
            this.mulkeDataGridViewTextBoxColumn.Name = "mulkeDataGridViewTextBoxColumn";
            this.mulkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // madresDataGridViewTextBoxColumn
            // 
            this.madresDataGridViewTextBoxColumn.DataPropertyName = "m_adres";
            this.madresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.madresDataGridViewTextBoxColumn.Name = "madresDataGridViewTextBoxColumn";
            this.madresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 627);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteri1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private userDataSet userDataSet;
        private System.Windows.Forms.BindingSource musteri1BindingSource;
        private userDataSetTableAdapters.musteri1TableAdapter musteri1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn madiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpasaportnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpbaslangicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpbitisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmakamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mseyahatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrandevuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mulkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madresDataGridViewTextBoxColumn;
    }
}