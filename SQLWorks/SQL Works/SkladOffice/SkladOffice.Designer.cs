
namespace SkladOffice
{
    partial class SkladOffice
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.nameStock = new System.Windows.Forms.TextBox();
            this.priseStock = new System.Windows.Forms.TextBox();
            this.qtyStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Справка за наличност";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кат. №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // idNumber
            // 
            this.idNumber.Location = new System.Drawing.Point(216, 127);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(100, 29);
            this.idNumber.TabIndex = 5;
            // 
            // nameStock
            // 
            this.nameStock.Location = new System.Drawing.Point(216, 193);
            this.nameStock.Name = "nameStock";
            this.nameStock.Size = new System.Drawing.Size(235, 29);
            this.nameStock.TabIndex = 6;
            // 
            // priseStock
            // 
            this.priseStock.Location = new System.Drawing.Point(216, 259);
            this.priseStock.Name = "priseStock";
            this.priseStock.Size = new System.Drawing.Size(100, 29);
            this.priseStock.TabIndex = 7;
            // 
            // qtyStock
            // 
            this.qtyStock.Location = new System.Drawing.Point(216, 325);
            this.qtyStock.Name = "qtyStock";
            this.qtyStock.Size = new System.Drawing.Size(100, 29);
            this.qtyStock.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "лв";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(511, 113);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(82, 44);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "PREV";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(635, 115);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 44);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(572, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SkladOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 396);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtyStock);
            this.Controls.Add(this.priseStock);
            this.Controls.Add(this.nameStock);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SkladOffice";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idNumber;
        private System.Windows.Forms.TextBox nameStock;
        private System.Windows.Forms.TextBox priseStock;
        private System.Windows.Forms.TextBox qtyStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
    }
}

