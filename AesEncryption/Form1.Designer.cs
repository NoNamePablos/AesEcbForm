namespace AesEncryption
{
    partial class AesEncryption
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВыводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЗашифрованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSizeKey = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEnccrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxTextClose = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxTextEnter = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxInition = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(12, 55);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(267, 20);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКлючToolStripMenuItem,
            this.сохранитьТекстToolStripMenuItem,
            this.сохранитьВыводToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКлючToolStripMenuItem
            // 
            this.сохранитьКлючToolStripMenuItem.Name = "сохранитьКлючToolStripMenuItem";
            this.сохранитьКлючToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКлючToolStripMenuItem.Text = "Сохранить ключ";
            this.сохранитьКлючToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКлючToolStripMenuItem_Click);
            // 
            // сохранитьТекстToolStripMenuItem
            // 
            this.сохранитьТекстToolStripMenuItem.Name = "сохранитьТекстToolStripMenuItem";
            this.сохранитьТекстToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьТекстToolStripMenuItem.Text = "Сохранить текст";
            this.сохранитьТекстToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТекстToolStripMenuItem_Click);
            // 
            // сохранитьВыводToolStripMenuItem
            // 
            this.сохранитьВыводToolStripMenuItem.Name = "сохранитьВыводToolStripMenuItem";
            this.сохранитьВыводToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьВыводToolStripMenuItem.Text = "Сохранить вывод";
            this.сохранитьВыводToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВыводToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКлючToolStripMenuItem,
            this.загрузитьТекстToolStripMenuItem,
            this.загрузитьЗашифрованныйТекстToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // загрузитьКлючToolStripMenuItem
            // 
            this.загрузитьКлючToolStripMenuItem.Name = "загрузитьКлючToolStripMenuItem";
            this.загрузитьКлючToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.загрузитьКлючToolStripMenuItem.Text = "Загрузить ключ";
            this.загрузитьКлючToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКлючToolStripMenuItem_Click);
            // 
            // загрузитьТекстToolStripMenuItem
            // 
            this.загрузитьТекстToolStripMenuItem.Name = "загрузитьТекстToolStripMenuItem";
            this.загрузитьТекстToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.загрузитьТекстToolStripMenuItem.Text = "Загрузить текст";
            this.загрузитьТекстToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТекстToolStripMenuItem_Click);
            // 
            // загрузитьЗашифрованныйТекстToolStripMenuItem
            // 
            this.загрузитьЗашифрованныйТекстToolStripMenuItem.Name = "загрузитьЗашифрованныйТекстToolStripMenuItem";
            this.загрузитьЗашифрованныйТекстToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.загрузитьЗашифрованныйТекстToolStripMenuItem.Text = "Загрузить зашифрованный текст";
            this.загрузитьЗашифрованныйТекстToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЗашифрованныйТекстToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер ключа";
            // 
            // comboBoxSizeKey
            // 
            this.comboBoxSizeKey.Enabled = false;
            this.comboBoxSizeKey.FormattingEnabled = true;
            this.comboBoxSizeKey.Location = new System.Drawing.Point(131, 89);
            this.comboBoxSizeKey.Name = "comboBoxSizeKey";
            this.comboBoxSizeKey.Size = new System.Drawing.Size(194, 21);
            this.comboBoxSizeKey.TabIndex = 5;
            this.comboBoxSizeKey.Text = "Размер ключа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEnccrypt);
            this.groupBox1.Controls.Add(this.buttonDecrypt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // buttonEnccrypt
            // 
            this.buttonEnccrypt.Location = new System.Drawing.Point(6, 41);
            this.buttonEnccrypt.Name = "buttonEnccrypt";
            this.buttonEnccrypt.Size = new System.Drawing.Size(298, 48);
            this.buttonEnccrypt.TabIndex = 2;
            this.buttonEnccrypt.Text = "Шифрование";
            this.buttonEnccrypt.UseVisualStyleBackColor = true;
            this.buttonEnccrypt.Click += new System.EventHandler(this.buttonEnccrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(6, 108);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(298, 48);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Дешифрование";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.richTextBoxTextClose);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTextBoxTextEnter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(346, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 444);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с текстом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вывод";
            // 
            // richTextBoxTextClose
            // 
            this.richTextBoxTextClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTextClose.Location = new System.Drawing.Point(6, 259);
            this.richTextBoxTextClose.Name = "richTextBoxTextClose";
            this.richTextBoxTextClose.Size = new System.Drawing.Size(381, 179);
            this.richTextBoxTextClose.TabIndex = 2;
            this.richTextBoxTextClose.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ввод";
            // 
            // richTextBoxTextEnter
            // 
            this.richTextBoxTextEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTextEnter.Location = new System.Drawing.Point(6, 45);
            this.richTextBoxTextEnter.Name = "richTextBoxTextEnter";
            this.richTextBoxTextEnter.Size = new System.Drawing.Size(381, 188);
            this.richTextBoxTextEnter.TabIndex = 0;
            this.richTextBoxTextEnter.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 20);
            this.button3.TabIndex = 8;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxInition);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(15, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 185);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начальные данные";
            // 
            // richTextBoxInition
            // 
            this.richTextBoxInition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInition.Location = new System.Drawing.Point(6, 28);
            this.richTextBoxInition.Name = "richTextBoxInition";
            this.richTextBoxInition.Size = new System.Drawing.Size(298, 151);
            this.richTextBoxInition.TabIndex = 1;
            this.richTextBoxInition.Text = "";
            // 
            // AesEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSizeKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AesEncryption";
            this.Text = "AesEncryption";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSizeKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnccrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxTextClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxTextEnter;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВыводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТекстToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxInition;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЗашифрованныйТекстToolStripMenuItem;
    }
}

