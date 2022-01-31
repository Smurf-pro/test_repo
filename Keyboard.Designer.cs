namespace Proizvidstvennaya_practika
{
    partial class Keyboard
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
            this.label4 = new System.Windows.Forms.Label();
            this.interfacee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.type_keybord = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1130, 546);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 59);
            this.nazad.TabIndex = 41;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1056, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Тип клавиатуры";
            // 
            // interfacee
            // 
            this.interfacee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interfacee.FormattingEnabled = true;
            this.interfacee.Items.AddRange(new object[] {
            "PS/2  ",
            "USB  ",
            "Беспроводной"});
            this.interfacee.Location = new System.Drawing.Point(1026, 286);
            this.interfacee.Name = "interfacee";
            this.interfacee.Size = new System.Drawing.Size(213, 33);
            this.interfacee.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1003, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Интерфейс подключения";
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1026, 203);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(213, 30);
            this.nazv.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1080, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Название";
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(1026, 131);
            this.ser.MaxLength = 10;
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(213, 30);
            this.ser.TabIndex = 34;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(1003, 422);
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
            this.label1.Location = new System.Drawing.Point(1038, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Серийный номер";
            // 
            // type_keybord
            // 
            this.type_keybord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_keybord.FormattingEnabled = true;
            this.type_keybord.Items.AddRange(new object[] {
            "мембранная",
            "механическая",
            "полумеханическая"});
            this.type_keybord.Location = new System.Drawing.Point(1026, 365);
            this.type_keybord.Name = "type_keybord";
            this.type_keybord.Size = new System.Drawing.Size(217, 33);
            this.type_keybord.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(480, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Добавление клавиатуры";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 516);
            this.dataGridView1.TabIndex = 44;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 100;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 617);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type_keybord);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interfacee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Keyboard";
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.Keyboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox interfacee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_keybord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close;
    }
}