namespace Proizvidstvennaya_practika
{
    partial class Auditorii
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.nom_aud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.floor = new System.Windows.Forms.TextBox();
            this.eksport = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.Location = new System.Drawing.Point(598, 12);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(142, 62);
            this.nazad.TabIndex = 12;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(488, 406);
            this.dataGridView1.TabIndex = 13;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(657, 305);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(142, 62);
            this.add.TabIndex = 14;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // nom_aud
            // 
            this.nom_aud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nom_aud.Location = new System.Drawing.Point(641, 156);
            this.nom_aud.MaxLength = 4;
            this.nom_aud.Name = "nom_aud";
            this.nom_aud.Size = new System.Drawing.Size(169, 30);
            this.nom_aud.TabIndex = 15;
            this.nom_aud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nom_aud_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(640, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер аудитории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(697, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Этаж";
            // 
            // floor
            // 
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor.Location = new System.Drawing.Point(641, 241);
            this.floor.MaxLength = 1;
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(169, 30);
            this.floor.TabIndex = 18;
            this.floor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.floor_KeyPress);
            // 
            // eksport
            // 
            this.eksport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eksport.Location = new System.Drawing.Point(175, 444);
            this.eksport.Name = "eksport";
            this.eksport.Size = new System.Drawing.Size(142, 62);
            this.eksport.TabIndex = 34;
            this.eksport.Text = "Экспорт";
            this.eksport.UseVisualStyleBackColor = true;
            this.eksport.Click += new System.EventHandler(this.eksport_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(759, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(142, 62);
            this.close.TabIndex = 35;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Auditorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Controls.Add(this.close);
            this.Controls.Add(this.eksport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom_aud);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nazad);
            this.Name = "Auditorii";
            this.Text = "Auditorii";
            this.Load += new System.EventHandler(this.Auditorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox nom_aud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.Button eksport;
        private System.Windows.Forms.Button close;
    }
}