
namespace OtoparkOtomasyon
{
    partial class Hizmet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otoparkDataSet = new OtoparkOtomasyon.otoparkDataSet();
            this.hizmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hizmetTableAdapter = new OtoparkOtomasyon.otoparkDataSetTableAdapters.hizmetTableAdapter();
            this.hizmetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracgirissaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.araccikissaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonelikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.abonelikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonelikTableAdapter = new OtoparkOtomasyon.otoparkDataSetTableAdapters.abonelikTableAdapter();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new OtoparkOtomasyon.otoparkDataSetTableAdapters.musteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hizmet ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hizmet Araç Giriş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hizmet Araç Çıkış:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hizmet Ücret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hizmet Abonelik:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hizmet Plaka:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hizmetidDataGridViewTextBoxColumn,
            this.aracgirissaatDataGridViewTextBoxColumn,
            this.araccikissaatDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.abonelikDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hizmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "otoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hizmetBindingSource
            // 
            this.hizmetBindingSource.DataMember = "hizmet";
            this.hizmetBindingSource.DataSource = this.otoparkDataSet;
            // 
            // hizmetTableAdapter
            // 
            this.hizmetTableAdapter.ClearBeforeFill = true;
            // 
            // hizmetidDataGridViewTextBoxColumn
            // 
            this.hizmetidDataGridViewTextBoxColumn.DataPropertyName = "hizmet_id";
            this.hizmetidDataGridViewTextBoxColumn.HeaderText = "hizmet_id";
            this.hizmetidDataGridViewTextBoxColumn.Name = "hizmetidDataGridViewTextBoxColumn";
            this.hizmetidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aracgirissaatDataGridViewTextBoxColumn
            // 
            this.aracgirissaatDataGridViewTextBoxColumn.DataPropertyName = "arac_giris_saat";
            this.aracgirissaatDataGridViewTextBoxColumn.HeaderText = "arac_giris_saat";
            this.aracgirissaatDataGridViewTextBoxColumn.Name = "aracgirissaatDataGridViewTextBoxColumn";
            // 
            // araccikissaatDataGridViewTextBoxColumn
            // 
            this.araccikissaatDataGridViewTextBoxColumn.DataPropertyName = "arac_cikis_saat";
            this.araccikissaatDataGridViewTextBoxColumn.HeaderText = "arac_cikis_saat";
            this.araccikissaatDataGridViewTextBoxColumn.Name = "araccikissaatDataGridViewTextBoxColumn";
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            // 
            // abonelikDataGridViewTextBoxColumn
            // 
            this.abonelikDataGridViewTextBoxColumn.DataPropertyName = "abonelik";
            this.abonelikDataGridViewTextBoxColumn.HeaderText = "abonelik";
            this.abonelikDataGridViewTextBoxColumn.Name = "abonelikDataGridViewTextBoxColumn";
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(125, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.musteriBindingSource;
            this.comboBox1.DisplayMember = "musteri_ad_soyad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "musteri_ad_soyad";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.abonelikBindingSource;
            this.comboBox2.DisplayMember = "abonelik_tipi";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "abonelik_tipi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(317, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(317, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(317, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 57);
            this.button3.TabIndex = 17;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // abonelikBindingSource
            // 
            this.abonelikBindingSource.DataMember = "abonelik";
            this.abonelikBindingSource.DataSource = this.otoparkDataSet;
            // 
            // abonelikTableAdapter
            // 
            this.abonelikTableAdapter.ClearBeforeFill = true;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.otoparkDataSet;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // Hizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hizmet";
            this.Text = "Hizmet";
            this.Load += new System.EventHandler(this.Hizmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource hizmetBindingSource;
        private otoparkDataSetTableAdapters.hizmetTableAdapter hizmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracgirissaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn araccikissaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonelikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource abonelikBindingSource;
        private otoparkDataSetTableAdapters.abonelikTableAdapter abonelikTableAdapter;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private otoparkDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
    }
}