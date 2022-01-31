namespace Proizvidstvennaya_practika
{
    partial class Mouse
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
            this.interface_mouse = new System.Windows.Forms.ComboBox();
            this.type_connect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.max_ras_datchika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // interface_mouse
            // 
            this.interface_mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interface_mouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interface_mouse.FormattingEnabled = true;
            this.interface_mouse.Items.AddRange(new object[] {
            "USB",
            "micro USB",
            "PS/2",
            "AT (DIN)",
            "COM (Serial)",
            "Bluetooth",
            "ИК-порт"});
            this.interface_mouse.Location = new System.Drawing.Point(1015, 258);
            this.interface_mouse.Name = "interface_mouse";
            this.interface_mouse.Size = new System.Drawing.Size(232, 33);
            this.interface_mouse.TabIndex = 73;
            // 
            // type_connect
            // 
            this.type_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_connect.FormattingEnabled = true;
            this.type_connect.Items.AddRange(new object[] {
            "Проводная",
            "Беспроводная"});
            this.type_connect.Location = new System.Drawing.Point(1015, 333);
            this.type_connect.Name = "type_connect";
            this.type_connect.Size = new System.Drawing.Size(232, 33);
            this.type_connect.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(965, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 71;
            this.label6.Text = "Макс. разрешение датчика, dpi";
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1130, 536);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 69);
            this.nazad.TabIndex = 70;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1027, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Интерфейс мыши";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1042, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Тип соединения";
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1015, 189);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(196, 30);
            this.nazv.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1069, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Название";
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(1015, 125);
            this.ser.MaxLength = 10;
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(188, 30);
            this.ser.TabIndex = 65;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(1003, 452);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(260, 69);
            this.add.TabIndex = 64;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1027, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Серийный номер";
            // 
            // max_ras_datchika
            // 
            this.max_ras_datchika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_ras_datchika.Location = new System.Drawing.Point(1015, 411);
            this.max_ras_datchika.MaxLength = 5;
            this.max_ras_datchika.Name = "max_ras_datchika";
            this.max_ras_datchika.Size = new System.Drawing.Size(237, 30);
            this.max_ras_datchika.TabIndex = 74;
            this.max_ras_datchika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mouse_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 32);
            this.label7.TabIndex = 75;
            this.label7.Text = "Добавление мышки";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 102;
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
            this.dataGridView1.Size = new System.Drawing.Size(942, 516);
            this.dataGridView1.TabIndex = 103;
            // 
            // Mouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.max_ras_datchika);
            this.Controls.Add(this.interface_mouse);
            this.Controls.Add(this.type_connect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Mouse";
            this.Text = "Mouse";
            this.Load += new System.EventHandler(this.Mouse_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mouse_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox interface_mouse;
        private System.Windows.Forms.ComboBox type_connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_ras_datchika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}