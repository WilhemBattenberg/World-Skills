namespace World_Skills
{
    partial class Storekeeper
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
            this.exit = new System.Windows.Forms.Button();
            this.tissue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(249, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 372);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход пользователя";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tissue
            // 
            this.tissue.Location = new System.Drawing.Point(40, 126);
            this.tissue.Name = "tissue";
            this.tissue.Size = new System.Drawing.Size(189, 59);
            this.tissue.TabIndex = 2;
            this.tissue.Text = "Список тканей";
            this.tissue.UseVisualStyleBackColor = true;
            this.tissue.Click += new System.EventHandler(this.tissue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Список фурнитуры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::World_Skills.Properties.Resources.logo_01;
            this.pictureBox1.Location = new System.Drawing.Point(82, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Storekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tissue);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Storekeeper";
            this.Text = "Кладовщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Storekeeper_FormClosing);
            this.Load += new System.EventHandler(this.Storekeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button tissue;
        private System.Windows.Forms.Button button1;
    }
}