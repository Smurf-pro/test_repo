namespace Proizvidstvennaya_practika
{
    partial class Printer
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
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.ser = new System.Windows.Forms.TextBox();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cvet = new System.Windows.Forms.ComboBox();
            this.maxformat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxSpeed = new System.Windows.Forms.TextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1051, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серийный номер";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(1025, 501);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(218, 77);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(1034, 173);
            this.ser.MaxLength = 10;
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(196, 30);
            this.ser.TabIndex = 3;
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1034, 112);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(196, 30);
            this.nazv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1088, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1069, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип принтера";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Матричный",
            "Струйный",
            "Лазерный"});
            this.type.Location = new System.Drawing.Point(1034, 237);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(196, 33);
            this.type.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1049, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цветность печати";
            // 
            // cvet
            // 
            this.cvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvet.FormattingEnabled = true;
            this.cvet.Items.AddRange(new object[] {
            "Монохромная",
            "Цветная"});
            this.cvet.Location = new System.Drawing.Point(1034, 312);
            this.cvet.Name = "cvet";
            this.cvet.Size = new System.Drawing.Size(196, 33);
            this.cvet.TabIndex = 9;
            // 
            // maxformat
            // 
            this.maxformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxformat.FormattingEnabled = true;
            this.maxformat.Items.AddRange(new object[] {
            "A3",
            "А4",
            "A6",
            "не стандартный"});
            this.maxformat.Location = new System.Drawing.Point(1034, 462);
            this.maxformat.Name = "maxformat";
            this.maxformat.Size = new System.Drawing.Size(196, 33);
            this.maxformat.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(964, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Максимальный формат печати";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(956, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Макс. скорость печати лист/мин\r\n";
            // 
            // maxSpeed
            // 
            this.maxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxSpeed.Location = new System.Drawing.Point(1034, 386);
            this.maxSpeed.MaxLength = 3;
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(196, 30);
            this.maxSpeed.TabIndex = 14;
            this.maxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxSpeed_KeyPress);
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1142, 605);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 58);
            this.nazad.TabIndex = 15;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 32);
            this.label7.TabIndex = 76;
            this.label7.Text = "Добавление принтера";
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
            this.dataGridView1.Size = new System.Drawing.Size(942, 564);
            this.dataGridView1.TabIndex = 104;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 105;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 675);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxformat);
            this.Controls.Add(this.cvet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Printer";
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.Printer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cvet;
        private System.Windows.Forms.ComboBox maxformat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxSpeed;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
    }
}