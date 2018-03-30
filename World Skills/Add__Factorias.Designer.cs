namespace World_Skills
{
    partial class Add__Factorias
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
            this.Log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySQLDataSet = new World_Skills.MySQLDataSet();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тканиTableAdapter = new World_Skills.MySQLDataSetTableAdapters.ТканиTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(372, 163);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(226, 29);
            this.Log.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поставщик";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(212, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 157);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataSource = this.тканиBindingSource;
            this.Column1.DisplayMember = "Артикул";
            this.Column1.HeaderText = "Артикуль";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // тканиBindingSource
            // 
            this.тканиBindingSource.DataMember = "Ткани";
            this.тканиBindingSource.DataSource = this.mySQLDataSet;
            // 
            // mySQLDataSet
            // 
            this.mySQLDataSet.DataSetName = "MySQLDataSet";
            this.mySQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Длинна";
            this.Column2.Name = "Column2";
            // 
            // тканиTableAdapter
            // 
            this.тканиTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Добавить к учету";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Enter += new System.EventHandler(this.button_MouseEnter);
            this.button3.Leave += new System.EventHandler(this.button_MouseLeave);
            this.button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // Add__Factorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Add__Factorias";
            this.Text = "Добавление тканей";
            this.Load += new System.EventHandler(this.Add__Factorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySQLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySQLDataSet mySQLDataSet;
        private System.Windows.Forms.BindingSource тканиBindingSource;
        private MySQLDataSetTableAdapters.ТканиTableAdapter тканиTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button3;
    }
}