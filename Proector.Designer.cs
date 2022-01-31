namespace Proizvidstvennaya_practika
{
    partial class Proector
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
            this.pik_yarkost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sootnoshenie_storon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serNom = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rassh1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rassh2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1142, 605);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 58);
            this.nazad.TabIndex = 30;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // pik_yarkost
            // 
            this.pik_yarkost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pik_yarkost.Location = new System.Drawing.Point(1032, 269);
            this.pik_yarkost.MaxLength = 5;
            this.pik_yarkost.Name = "pik_yarkost";
            this.pik_yarkost.Size = new System.Drawing.Size(194, 30);
            this.pik_yarkost.TabIndex = 29;
            this.pik_yarkost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pik_yarkost_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1023, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Пиковая яркость, лм";
            // 
            // sootnoshenie_storon
            // 
            this.sootnoshenie_storon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sootnoshenie_storon.FormattingEnabled = true;
            this.sootnoshenie_storon.Items.AddRange(new object[] {
            "1.2:1 ",
            "1.6:1 ",
            "15:10 ",
            "15:9 ",
            "16:10 ",
            "16:9 ",
            "1:1 ",
            "21:9 ",
            "4:3"});
            this.sootnoshenie_storon.Location = new System.Drawing.Point(1032, 350);
            this.sootnoshenie_storon.Name = "sootnoshenie_storon";
            this.sootnoshenie_storon.Size = new System.Drawing.Size(199, 33);
            this.sootnoshenie_storon.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(991, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Соотношение сторон экрана";
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1030, 134);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(196, 30);
            this.nazv.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1084, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название";
            // 
            // serNom
            // 
            this.serNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serNom.Location = new System.Drawing.Point(1030, 195);
            this.serNom.MaxLength = 10;
            this.serNom.Name = "serNom";
            this.serNom.Size = new System.Drawing.Size(196, 30);
            this.serNom.TabIndex = 19;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(1032, 491);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(214, 78);
            this.add.TabIndex = 18;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1047, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Серийный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1075, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Разрешение";
            // 
            // rassh1
            // 
            this.rassh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rassh1.Location = new System.Drawing.Point(1034, 425);
            this.rassh1.MaxLength = 4;
            this.rassh1.Name = "rassh1";
            this.rassh1.Size = new System.Drawing.Size(88, 30);
            this.rassh1.TabIndex = 32;
            this.rassh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pik_yarkost_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1128, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "x";
            // 
            // rassh2
            // 
            this.rassh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rassh2.Location = new System.Drawing.Point(1154, 425);
            this.rassh2.MaxLength = 4;
            this.rassh2.Name = "rassh2";
            this.rassh2.Size = new System.Drawing.Size(88, 30);
            this.rassh2.TabIndex = 34;
            this.rassh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pik_yarkost_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 32);
            this.label7.TabIndex = 77;
            this.label7.Text = "Добавление проектора";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 106;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(951, 564);
            this.dataGridView1.TabIndex = 107;
            // 
            // Proector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rassh2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rassh1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.pik_yarkost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sootnoshenie_storon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serNom);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Proector";
            this.Text = "Proector";
            this.Load += new System.EventHandler(this.Proector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.TextBox pik_yarkost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sootnoshenie_storon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serNom;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rassh1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rassh2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}