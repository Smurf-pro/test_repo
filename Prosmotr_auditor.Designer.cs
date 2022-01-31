namespace Proizvidstvennaya_practika
{
    partial class Prosmotr_auditor
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.prosmotr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eksport = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(974, 12);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(113, 62);
            this.nazad.TabIndex = 13;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Склад"});
            this.comboBox2.Location = new System.Drawing.Point(996, 213);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // prosmotr
            // 
            this.prosmotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prosmotr.Location = new System.Drawing.Point(1015, 295);
            this.prosmotr.Name = "prosmotr";
            this.prosmotr.Size = new System.Drawing.Size(163, 64);
            this.prosmotr.TabIndex = 16;
            this.prosmotr.Text = "Посмотреть";
            this.prosmotr.UseVisualStyleBackColor = true;
            this.prosmotr.Click += new System.EventHandler(this.prosmotr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(990, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1043, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Аудитория";
            // 
            // eksport
            // 
            this.eksport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eksport.Location = new System.Drawing.Point(380, 409);
            this.eksport.Name = "eksport";
            this.eksport.Size = new System.Drawing.Size(175, 51);
            this.eksport.TabIndex = 34;
            this.eksport.Text = "Экспорт";
            this.eksport.UseVisualStyleBackColor = true;
            this.eksport.Click += new System.EventHandler(this.eksport_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(1093, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(113, 62);
            this.close.TabIndex = 35;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Prosmotr_auditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 472);
            this.Controls.Add(this.close);
            this.Controls.Add(this.eksport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prosmotr);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prosmotr_auditor";
            this.Text = "Prosmotr_auditor";
            this.Load += new System.EventHandler(this.Prosmotr_auditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button prosmotr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button eksport;
        private System.Windows.Forms.Button close;
    }
}