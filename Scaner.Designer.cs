namespace Proizvidstvennaya_practika
{
    partial class Scaner
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
            this.label6 = new System.Windows.Forms.Label();
            this.nazad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ser = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.type_scan = new System.Windows.Forms.ComboBox();
            this.dvustoron_pech = new System.Windows.Forms.ComboBox();
            this.max_format_origin = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1015, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Макс. формат оригинала";
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(1142, 605);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(133, 58);
            this.nazad.TabIndex = 56;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(996, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Двустороннее сканирование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1072, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Тип сканера";
            // 
            // nazv
            // 
            this.nazv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazv.Location = new System.Drawing.Point(1030, 134);
            this.nazv.MaxLength = 50;
            this.nazv.Name = "nazv";
            this.nazv.Size = new System.Drawing.Size(196, 30);
            this.nazv.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1084, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Название";
            // 
            // ser
            // 
            this.ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser.Location = new System.Drawing.Point(1030, 195);
            this.ser.MaxLength = 10;
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(196, 30);
            this.ser.TabIndex = 50;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(1020, 494);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(214, 78);
            this.add.TabIndex = 49;
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
            this.label1.TabIndex = 48;
            this.label1.Text = "Серийный номер";
            // 
            // type_scan
            // 
            this.type_scan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_scan.FormattingEnabled = true;
            this.type_scan.Items.AddRange(new object[] {
            "Протяжный",
            "Планшетный",
            "Слайд-сканер"});
            this.type_scan.Location = new System.Drawing.Point(1030, 267);
            this.type_scan.Name = "type_scan";
            this.type_scan.Size = new System.Drawing.Size(196, 33);
            this.type_scan.TabIndex = 59;
            // 
            // dvustoron_pech
            // 
            this.dvustoron_pech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvustoron_pech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dvustoron_pech.FormattingEnabled = true;
            this.dvustoron_pech.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.dvustoron_pech.Location = new System.Drawing.Point(1030, 352);
            this.dvustoron_pech.Name = "dvustoron_pech";
            this.dvustoron_pech.Size = new System.Drawing.Size(196, 33);
            this.dvustoron_pech.TabIndex = 60;
            // 
            // max_format_origin
            // 
            this.max_format_origin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.max_format_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max_format_origin.FormattingEnabled = true;
            this.max_format_origin.Items.AddRange(new object[] {
            "А6",
            "А5",
            "А4",
            "А3",
            "А2",
            "А1",
            "А0"});
            this.max_format_origin.Location = new System.Drawing.Point(1030, 446);
            this.max_format_origin.Name = "max_format_origin";
            this.max_format_origin.Size = new System.Drawing.Size(196, 33);
            this.max_format_origin.TabIndex = 61;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1130, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 59);
            this.close.TabIndex = 107;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 32);
            this.label7.TabIndex = 108;
            this.label7.Text = "Добавление сканера";
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
            this.dataGridView1.Size = new System.Drawing.Size(958, 564);
            this.dataGridView1.TabIndex = 109;
            // 
            // Scaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.close);
            this.Controls.Add(this.max_format_origin);
            this.Controls.Add(this.dvustoron_pech);
            this.Controls.Add(this.type_scan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Name = "Scaner";
            this.Text = "Scaner";
            this.Load += new System.EventHandler(this.Scaner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ser;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_scan;
        private System.Windows.Forms.ComboBox dvustoron_pech;
        private System.Windows.Forms.ComboBox max_format_origin;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}