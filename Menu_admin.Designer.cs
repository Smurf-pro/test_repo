namespace Proizvidstvennaya_practika
{
    partial class Menu_admin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_admin));
            this.to_sklad = new System.Windows.Forms.Button();
            this.to_aud = new System.Windows.Forms.Button();
            this.see_obor_audit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.journal = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // to_sklad
            // 
            this.to_sklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_sklad.Location = new System.Drawing.Point(43, 12);
            this.to_sklad.Margin = new System.Windows.Forms.Padding(13);
            this.to_sklad.Name = "to_sklad";
            this.to_sklad.Size = new System.Drawing.Size(155, 76);
            this.to_sklad.TabIndex = 0;
            this.to_sklad.Text = "Склад";
            this.to_sklad.UseVisualStyleBackColor = true;
            this.to_sklad.Click += new System.EventHandler(this.to_sklad_Click);
            // 
            // to_aud
            // 
            this.to_aud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_aud.Location = new System.Drawing.Point(43, 423);
            this.to_aud.Margin = new System.Windows.Forms.Padding(13);
            this.to_aud.Name = "to_aud";
            this.to_aud.Size = new System.Drawing.Size(155, 77);
            this.to_aud.TabIndex = 1;
            this.to_aud.Text = "Добавить аудиторию";
            this.to_aud.UseVisualStyleBackColor = true;
            this.to_aud.Click += new System.EventHandler(this.to_aud_Click);
            // 
            // see_obor_audit
            // 
            this.see_obor_audit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.see_obor_audit.Location = new System.Drawing.Point(43, 114);
            this.see_obor_audit.Margin = new System.Windows.Forms.Padding(13);
            this.see_obor_audit.Name = "see_obor_audit";
            this.see_obor_audit.Size = new System.Drawing.Size(155, 77);
            this.see_obor_audit.TabIndex = 10;
            this.see_obor_audit.Text = "Просмотр аудиторий";
            this.see_obor_audit.UseVisualStyleBackColor = true;
            this.see_obor_audit.Click += new System.EventHandler(this.see_obor_audit_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.close.Location = new System.Drawing.Point(253, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(155, 76);
            this.close.TabIndex = 100;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // journal
            // 
            this.journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journal.Location = new System.Drawing.Point(43, 217);
            this.journal.Margin = new System.Windows.Forms.Padding(13);
            this.journal.Name = "journal";
            this.journal.Size = new System.Drawing.Size(155, 77);
            this.journal.TabIndex = 101;
            this.journal.Text = "Журналы";
            this.journal.UseVisualStyleBackColor = true;
            this.journal.Click += new System.EventHandler(this.journal_Click);
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users.Location = new System.Drawing.Point(43, 320);
            this.users.Margin = new System.Windows.Forms.Padding(13);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(155, 77);
            this.users.TabIndex = 102;
            this.users.Text = "Пользователи";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // Menu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 547);
            this.Controls.Add(this.users);
            this.Controls.Add(this.journal);
            this.Controls.Add(this.close);
            this.Controls.Add(this.see_obor_audit);
            this.Controls.Add(this.to_aud);
            this.Controls.Add(this.to_sklad);
            this.Name = "Menu_admin";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button to_sklad;
        private System.Windows.Forms.Button to_aud;
        private System.Windows.Forms.Button see_obor_audit;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button journal;
        private System.Windows.Forms.Button users;
    }
}