
namespace variableSamp
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretaxtotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotDogsSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(106, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pretax total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(213, 156);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(63, 20);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(213, 120);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(63, 20);
            this.txtTax.TabIndex = 28;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPretaxtotal
            // 
            this.txtPretaxtotal.Location = new System.Drawing.Point(213, 83);
            this.txtPretaxtotal.Name = "txtPretaxtotal";
            this.txtPretaxtotal.Size = new System.Drawing.Size(63, 20);
            this.txtPretaxtotal.TabIndex = 27;
            this.txtPretaxtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtHamburgersSubtotal
            // 
            this.txtHamburgersSubtotal.Location = new System.Drawing.Point(213, 47);
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.ReadOnly = true;
            this.txtHamburgersSubtotal.Size = new System.Drawing.Size(63, 20);
            this.txtHamburgersSubtotal.TabIndex = 25;
            this.txtHamburgersSubtotal.TabStop = false;
            this.txtHamburgersSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "x $5.00 =";
            // 
            // txtHamburgers
            // 
            this.txtHamburgers.Location = new System.Drawing.Point(89, 47);
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.Size = new System.Drawing.Size(41, 20);
            this.txtHamburgers.TabIndex = 23;
            this.txtHamburgers.Text = "0";
            this.txtHamburgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hamburger";
            // 
            // txtHotDogsSubtotal
            // 
            this.txtHotDogsSubtotal.Location = new System.Drawing.Point(213, 14);
            this.txtHotDogsSubtotal.Name = "txtHotDogsSubtotal";
            this.txtHotDogsSubtotal.ReadOnly = true;
            this.txtHotDogsSubtotal.Size = new System.Drawing.Size(63, 20);
            this.txtHotDogsSubtotal.TabIndex = 21;
            this.txtHotDogsSubtotal.TabStop = false;
            this.txtHotDogsSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "x $4.00 =";
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.Location = new System.Drawing.Point(89, 14);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(41, 20);
            this.txtHotDogs.TabIndex = 19;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hot dogs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 255);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretaxtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotDogsSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretaxtotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotDogsSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.Label label1;
    }
}

