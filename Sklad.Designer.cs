namespace Proizvidstvennaya_practika
{
    partial class Sklad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazad = new System.Windows.Forms.Button();
            this.New_oborud = new System.Windows.Forms.Button();
            this.filtr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.peremestit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.refr = new System.Windows.Forms.Button();
            this.vse_oborudovanie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.eksport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 509);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(945, 12);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(94, 59);
            this.nazad.TabIndex = 12;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // New_oborud
            // 
            this.New_oborud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_oborud.Location = new System.Drawing.Point(732, 310);
            this.New_oborud.Name = "New_oborud";
            this.New_oborud.Size = new System.Drawing.Size(344, 65);
            this.New_oborud.TabIndex = 13;
            this.New_oborud.Text = "Добавить оборудование на склад";
            this.New_oborud.UseVisualStyleBackColor = true;
            this.New_oborud.Click += new System.EventHandler(this.New_oborud_Click);
            // 
            // filtr
            // 
            this.filtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtr.Location = new System.Drawing.Point(281, 12);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(197, 59);
            this.filtr.TabIndex = 14;
            this.filtr.Text = "Фильтровать по типу оборудования";
            this.filtr.UseVisualStyleBackColor = true;
            this.filtr.Click += new System.EventHandler(this.filtr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Принтер",
            "Проектор",
            "Акустическая система",
            "Монитор",
            "Сканер",
            "Клавиатура",
            "Мышка",
            "Компьютер"});
            this.comboBox1.Location = new System.Drawing.Point(12, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(699, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Переместить оборудование в аудиторию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(955, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Аудитория";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(674, 491);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(920, 491);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 24);
            this.comboBox3.TabIndex = 22;
            // 
            // peremestit
            // 
            this.peremestit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.peremestit.Location = new System.Drawing.Point(827, 539);
            this.peremestit.Name = "peremestit";
            this.peremestit.Size = new System.Drawing.Size(166, 60);
            this.peremestit.TabIndex = 23;
            this.peremestit.Text = "Переместить";
            this.peremestit.UseVisualStyleBackColor = true;
            this.peremestit.Click += new System.EventHandler(this.peremestit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(727, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Удаление оборудования со склада";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(798, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Инвентарный номер";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(817, 213);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(154, 60);
            this.delete.TabIndex = 27;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // refr
            // 
            this.refr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refr.Location = new System.Drawing.Point(682, 13);
            this.refr.Name = "refr";
            this.refr.Size = new System.Drawing.Size(242, 58);
            this.refr.TabIndex = 28;
            this.refr.Text = "Обновить/Сбросить";
            this.refr.UseVisualStyleBackColor = true;
            this.refr.Click += new System.EventHandler(this.refr_Click);
            // 
            // vse_oborudovanie
            // 
            this.vse_oborudovanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vse_oborudovanie.Location = new System.Drawing.Point(505, 13);
            this.vse_oborudovanie.Name = "vse_oborudovanie";
            this.vse_oborudovanie.Size = new System.Drawing.Size(144, 58);
            this.vse_oborudovanie.TabIndex = 29;
            this.vse_oborudovanie.Text = "Показать все оборудвание";
            this.vse_oborudovanie.UseVisualStyleBackColor = true;
            this.vse_oborudovanie.Click += new System.EventHandler(this.vse_oborudovanie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(670, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Инвентарный номер";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(781, 183);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(221, 24);
            this.comboBox4.TabIndex = 32;
            // 
            // eksport
            // 
            this.eksport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eksport.Location = new System.Drawing.Point(187, 593);
            this.eksport.Name = "eksport";
            this.eksport.Size = new System.Drawing.Size(175, 51);
            this.eksport.TabIndex = 33;
            this.eksport.Text = "Экспорт";
            this.eksport.UseVisualStyleBackColor = true;
            this.eksport.Click += new System.EventHandler(this.eksport_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1060, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 34;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eksport);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vse_oborudovanie);
            this.Controls.Add(this.refr);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peremestit);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filtr);
            this.Controls.Add(this.New_oborud);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sklad";
            this.Text = "Sklad";
            this.Load += new System.EventHandler(this.Sklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button New_oborud;
        private System.Windows.Forms.Button filtr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button peremestit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button refr;
        private System.Windows.Forms.Button vse_oborudovanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button eksport;
        private System.Windows.Forms.Button button1;
    }
}