﻿
namespace kr22
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pastxt = new System.Windows.Forms.TextBox();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnpas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Че смотришь, заходи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vineta BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vineta BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(82, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // pastxt
            // 
            this.pastxt.Location = new System.Drawing.Point(79, 556);
            this.pastxt.Name = "pastxt";
            this.pastxt.Size = new System.Drawing.Size(402, 20);
            this.pastxt.TabIndex = 1;
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(79, 368);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(402, 20);
            this.logintxt.TabIndex = 1;
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(505, 368);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(75, 23);
            this.btnlog.TabIndex = 2;
            this.btnlog.Text = "ok";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnpas
            // 
            this.btnpas.Location = new System.Drawing.Point(505, 553);
            this.btnpas.Name = "btnpas";
            this.btnpas.Size = new System.Drawing.Size(75, 23);
            this.btnpas.TabIndex = 2;
            this.btnpas.Text = "ok";
            this.btnpas.UseVisualStyleBackColor = true;
            this.btnpas.Click += new System.EventHandler(this.btnpas_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kr22.Properties.Resources._1641114113_17_abrakadabra_fun_p_kotik_za_kompom_42;
            this.ClientSize = new System.Drawing.Size(1492, 670);
            this.Controls.Add(this.btnpas);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.pastxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pastxt;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnpas;
    }
}