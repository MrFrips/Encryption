﻿namespace encryption
{
    partial class Key
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key));
            this.StringBox = new System.Windows.Forms.TextBox();
            this.TextFormKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InOutPutDataError = new System.Windows.Forms.ErrorProvider(this.components);
            this.CloseThisForm = new System.Windows.Forms.Button();
            this.infoFormKey = new System.Windows.Forms.Label();
            this.СolumnBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InOutPutDataError)).BeginInit();
            this.SuspendLayout();
            // 
            // StringBox
            // 
            this.StringBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StringBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StringBox.ForeColor = System.Drawing.SystemColors.Info;
            this.StringBox.Location = new System.Drawing.Point(93, 36);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(110, 29);
            this.StringBox.TabIndex = 0;
            this.StringBox.TextChanged += new System.EventHandler(this.StringBox_TextChanged);
            this.StringBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringBox_KeyPress);
            // 
            // TextFormKey
            // 
            this.TextFormKey.AutoSize = true;
            this.TextFormKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFormKey.ForeColor = System.Drawing.Color.White;
            this.TextFormKey.Location = new System.Drawing.Point(45, 9);
            this.TextFormKey.Name = "TextFormKey";
            this.TextFormKey.Size = new System.Drawing.Size(148, 24);
            this.TextFormKey.TabIndex = 1;
            this.TextFormKey.Text = "Введите ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Столбец";
            // 
            // InOutPutDataError
            // 
            this.InOutPutDataError.ContainerControl = this;
            this.InOutPutDataError.Icon = ((System.Drawing.Icon)(resources.GetObject("InOutPutDataError.Icon")));
            // 
            // CloseThisForm
            // 
            this.CloseThisForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CloseThisForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseThisForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseThisForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CloseThisForm.ForeColor = System.Drawing.Color.White;
            this.CloseThisForm.Location = new System.Drawing.Point(12, 191);
            this.CloseThisForm.Name = "CloseThisForm";
            this.CloseThisForm.Size = new System.Drawing.Size(212, 28);
            this.CloseThisForm.TabIndex = 3;
            this.CloseThisForm.Text = "Сохранить ключ?";
            this.CloseThisForm.UseVisualStyleBackColor = false;
            this.CloseThisForm.Click += new System.EventHandler(this.CloseThisForm_Click);
            // 
            // infoFormKey
            // 
            this.infoFormKey.AutoSize = true;
            this.infoFormKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoFormKey.ForeColor = System.Drawing.Color.White;
            this.infoFormKey.Location = new System.Drawing.Point(63, 168);
            this.infoFormKey.Name = "infoFormKey";
            this.infoFormKey.Size = new System.Drawing.Size(117, 20);
            this.infoFormKey.TabIndex = 4;
            this.infoFormKey.Text = "Какое-то info";
            // 
            // СolumnBox
            // 
            this.СolumnBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.СolumnBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.СolumnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.СolumnBox.ForeColor = System.Drawing.SystemColors.Info;
            this.СolumnBox.Location = new System.Drawing.Point(93, 71);
            this.СolumnBox.Name = "СolumnBox";
            this.СolumnBox.Size = new System.Drawing.Size(110, 29);
            this.СolumnBox.TabIndex = 0;
            this.СolumnBox.TextChanged += new System.EventHandler(this.StringBox_TextChanged);
            this.СolumnBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.СolumnBox_KeyPress);
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(236, 231);
            this.Controls.Add(this.infoFormKey);
            this.Controls.Add(this.CloseThisForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextFormKey);
            this.Controls.Add(this.СolumnBox);
            this.Controls.Add(this.StringBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Key";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Key_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.InOutPutDataError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringBox;
        private System.Windows.Forms.Label TextFormKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider InOutPutDataError;
        private System.Windows.Forms.Button CloseThisForm;
        private System.Windows.Forms.Label infoFormKey;
        private System.Windows.Forms.TextBox СolumnBox;
    }
}