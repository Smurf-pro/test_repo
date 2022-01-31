namespace Proizvidstvennaya_practika
{
    partial class Monitor
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
            this.nazad = new System.Windows.Forms.Button();
            this.diag_ekrana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.max_chastota_obnov = new System.Windows.Forms.TextBox();
            this.rassh2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rassh1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1130, 536);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 69);
            this.nazad.TabIndex = 41;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // diag_ekrana
            // 
            this.diag_ekrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diag_ekrana.Location = new System.Drawing.Point(955, 276);
            this.diag_ekrana.MaxLength = 3;
            this.diag_ekrana.Name = "diag_ekrana";
            this.diag_ekrana.Size = new System.Drawing.Size(304, 30);
            this.diag_ekrana.TabIndex = 40;
            this.diag_ekrana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diag_ekrana_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(983, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Диагональ экрана, дюймы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(966, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Макс. частота обновления, Гц";
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1015, 403);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(196, 30);
            this.nazv.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1068, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Название";
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(1028, 132);
            this.ser.MaxLength = 10;
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(188, 30);
            this.ser.TabIndex = 34;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(988, 449);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(260, 69);
            this.add.TabIndex = 33;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1040, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Серийный номер";
            // 
            // max_chastota_obnov
            // 
            this.max_chastota_obnov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_chastota_obnov.Location = new System.Drawing.Point(955, 201);
            this.max_chastota_obnov.MaxLength = 3;
            this.max_chastota_obnov.Name = "max_chastota_obnov";
            this.max_chastota_obnov.Size = new System.Drawing.Size(304, 30);
            this.max_chastota_obnov.TabIndex = 42;
            this.max_chastota_obnov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_chastota_obnov_KeyPress);
            // 
            // rassh2
            // 
            this.rassh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rassh2.Location = new System.Drawing.Point(1128, 337);
            this.rassh2.MaxLength = 4;
            this.rassh2.Name = "rassh2";
            this.rassh2.Size = new System.Drawing.Size(88, 30);
            this.rassh2.TabIndex = 46;
            this.rassh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_chastota_obnov_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1102, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "x";
            // 
            // rassh1
            // 
            this.rassh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rassh1.Location = new System.Drawing.Point(1008, 337);
            this.rassh1.MaxLength = 4;
            this.rassh1.Name = "rassh1";
            this.rassh1.Size = new System.Drawing.Size(88, 30);
            this.rassh1.TabIndex = 44;
            this.rassh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.max_chastota_obnov_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1058, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Разрешение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 32);
            this.label7.TabIndex = 47;
            this.label7.Text = "Добавление монитора";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 516);
            this.dataGridView1.TabIndex = 48;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 101;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 618);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rassh2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rassh1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.max_chastota_obnov);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.diag_ekrana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.TextBox diag_ekrana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_chastota_obnov;
        private System.Windows.Forms.TextBox rassh2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rassh1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
    }
}