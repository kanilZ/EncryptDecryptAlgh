﻿namespace ShyfryLab1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextOpen = new System.Windows.Forms.RichTextBox();
            this.richTextEncrypt = new System.Windows.Forms.RichTextBox();
            this.richTextDecrypt = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.методиШифруванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsezarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перестановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкритий текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зашифрований текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Розшифрований текст";
            // 
            // richTextOpen
            // 
            this.richTextOpen.Location = new System.Drawing.Point(33, 84);
            this.richTextOpen.Name = "richTextOpen";
            this.richTextOpen.Size = new System.Drawing.Size(182, 145);
            this.richTextOpen.TabIndex = 6;
            this.richTextOpen.Text = "";
            // 
            // richTextEncrypt
            // 
            this.richTextEncrypt.Location = new System.Drawing.Point(305, 84);
            this.richTextEncrypt.Name = "richTextEncrypt";
            this.richTextEncrypt.ReadOnly = true;
            this.richTextEncrypt.Size = new System.Drawing.Size(182, 145);
            this.richTextEncrypt.TabIndex = 7;
            this.richTextEncrypt.Text = "";
            // 
            // richTextDecrypt
            // 
            this.richTextDecrypt.Location = new System.Drawing.Point(597, 84);
            this.richTextDecrypt.Name = "richTextDecrypt";
            this.richTextDecrypt.ReadOnly = true;
            this.richTextDecrypt.Size = new System.Drawing.Size(182, 145);
            this.richTextDecrypt.TabIndex = 8;
            this.richTextDecrypt.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(643, 255);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 39);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистити все";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(64, 255);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(125, 39);
            this.buttonEncrypt.TabIndex = 9;
            this.buttonEncrypt.Text = "Зашифрувати";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(341, 255);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(115, 39);
            this.buttonDecrypt.TabIndex = 10;
            this.buttonDecrypt.Text = "Розшифрувати";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методиШифруванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // методиШифруванняToolStripMenuItem
            // 
            this.методиШифруванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsezarToolStripMenuItem,
            this.zaminaToolStripMenuItem,
            this.перестановкаToolStripMenuItem});
            this.методиШифруванняToolStripMenuItem.Name = "методиШифруванняToolStripMenuItem";
            this.методиШифруванняToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.методиШифруванняToolStripMenuItem.Text = "Методи шифрування";
            // 
            // tsezarToolStripMenuItem
            // 
            this.tsezarToolStripMenuItem.Name = "tsezarToolStripMenuItem";
            this.tsezarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tsezarToolStripMenuItem.Text = "Цезаря";
            // 
            // zaminaToolStripMenuItem
            // 
            this.zaminaToolStripMenuItem.Name = "zaminaToolStripMenuItem";
            this.zaminaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zaminaToolStripMenuItem.Text = "Заміни";
            // 
            // перестановкаToolStripMenuItem
            // 
            this.перестановкаToolStripMenuItem.Name = "перестановкаToolStripMenuItem";
            this.перестановкаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.перестановкаToolStripMenuItem.Text = "Перестановка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextDecrypt);
            this.Controls.Add(this.richTextEncrypt);
            this.Controls.Add(this.richTextOpen);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Shyfrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextOpen;
        private System.Windows.Forms.RichTextBox richTextEncrypt;
        private System.Windows.Forms.RichTextBox richTextDecrypt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem методиШифруванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsezarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перестановкаToolStripMenuItem;
    }
}

