
namespace kr22
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продукцияMenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsForYourMotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПшелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avtbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компуктерные игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palace Script MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 562);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = "Это тот магазин компукторных игр. \r\nВ который захочет вернуться даже твоя мама.\r\n" +
    " Забудь о том, что ты школьник \r\nи стань настоящим мужчиной\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продукцияMenToolStripMenuItem,
            this.contactsForYourMotherToolStripMenuItem,
            this.выгрузкаДанныхToolStripMenuItem,
            this.ПшелToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продукцияMenToolStripMenuItem
            // 
            this.продукцияMenToolStripMenuItem.Name = "продукцияMenToolStripMenuItem";
            this.продукцияMenToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.продукцияMenToolStripMenuItem.Text = "Продукция, men";
            this.продукцияMenToolStripMenuItem.Click += new System.EventHandler(this.продукцияMenToolStripMenuItem_Click);
            // 
            // contactsForYourMotherToolStripMenuItem
            // 
            this.contactsForYourMotherToolStripMenuItem.Name = "contactsForYourMotherToolStripMenuItem";
            this.contactsForYourMotherToolStripMenuItem.Size = new System.Drawing.Size(229, 29);
            this.contactsForYourMotherToolStripMenuItem.Text = "Contacts for your mother";
            this.contactsForYourMotherToolStripMenuItem.Click += new System.EventHandler(this.contactsForYourMotherToolStripMenuItem_Click);
            // 
            // выгрузкаДанныхToolStripMenuItem
            // 
            this.выгрузкаДанныхToolStripMenuItem.Name = "выгрузкаДанныхToolStripMenuItem";
            this.выгрузкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.выгрузкаДанныхToolStripMenuItem.Text = "Выгрузка данных";
            this.выгрузкаДанныхToolStripMenuItem.Visible = false;
            this.выгрузкаДанныхToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаДанныхToolStripMenuItem_Click);
            // 
            // ПшелToolStripMenuItem
            // 
            this.ПшелToolStripMenuItem.Name = "ПшелToolStripMenuItem";
            this.ПшелToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
            this.ПшелToolStripMenuItem.Text = "Пшел ";
            this.ПшелToolStripMenuItem.Click += new System.EventHandler(this.ПшелToolStripMenuItem_Click);
            // 
            // avtbtn
            // 
            this.avtbtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtbtn.Location = new System.Drawing.Point(182, 392);
            this.avtbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avtbtn.Name = "avtbtn";
            this.avtbtn.Size = new System.Drawing.Size(282, 94);
            this.avtbtn.TabIndex = 3;
            this.avtbtn.Text = "Авторизуйся или день будет грустным";
            this.avtbtn.UseVisualStyleBackColor = true;
            this.avtbtn.Click += new System.EventHandler(this.avtbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kr22.Properties.Resources.ed451409766d8f708464b42a9ac666ad;
            this.ClientSize = new System.Drawing.Size(680, 692);
            this.Controls.Add(this.avtbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem продукцияMenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsForYourMotherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПшелToolStripMenuItem;
        private System.Windows.Forms.Button avtbtn;
    }
}

