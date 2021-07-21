
namespace karlstad
{
    partial class miniräknare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniräknare));
            this.btnDela = new System.Windows.Forms.Button();
            this.btnGånger = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.buttonPunkt = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDela
            // 
            this.btnDela.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDela.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDela.Location = new System.Drawing.Point(266, 272);
            this.btnDela.Name = "btnDela";
            this.btnDela.Size = new System.Drawing.Size(72, 52);
            this.btnDela.TabIndex = 1;
            this.btnDela.Text = "/";
            this.btnDela.UseVisualStyleBackColor = false;
            this.btnDela.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnGånger
            // 
            this.btnGånger.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGånger.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGånger.Location = new System.Drawing.Point(266, 214);
            this.btnGånger.Name = "btnGånger";
            this.btnGånger.Size = new System.Drawing.Size(72, 52);
            this.btnGånger.TabIndex = 2;
            this.btnGånger.Text = "x";
            this.btnGånger.UseVisualStyleBackColor = false;
            this.btnGånger.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMinus.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(266, 156);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(72, 52);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPlus.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(266, 98);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(72, 52);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEqual.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(346, 214);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(72, 110);
            this.btnEqual.TabIndex = 5;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn9.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(186, 98);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 52);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn6.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(186, 156);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 52);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn3.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(186, 214);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 52);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn0.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(26, 272);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(152, 52);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn8.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(106, 98);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 52);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn5.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(106, 156);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 52);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn2.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(106, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 52);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumEvent);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnC.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(346, 98);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(72, 52);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn4.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(26, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 52);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn7.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(26, 98);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 52);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumEvent);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(26, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(204, 32);
            this.txtResult.TabIndex = 16;
            this.txtResult.Text = "0";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn1.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(26, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 52);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumEvent);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(23, 32);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 18;
            // 
            // buttonPunkt
            // 
            this.buttonPunkt.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonPunkt.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunkt.Location = new System.Drawing.Point(186, 272);
            this.buttonPunkt.Name = "buttonPunkt";
            this.buttonPunkt.Size = new System.Drawing.Size(73, 52);
            this.buttonPunkt.TabIndex = 19;
            this.buttonPunkt.Text = ".";
            this.buttonPunkt.UseVisualStyleBackColor = false;
            this.buttonPunkt.Click += new System.EventHandler(this.buttonPunkt_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCE.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(346, 156);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(73, 52);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // miniräknare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 344);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.buttonPunkt);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnGånger);
            this.Controls.Add(this.btnDela);
            this.Name = "miniräknare";
            this.Text = "miniräknare";
            this.Load += new System.EventHandler(this.miniräknare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDela;
        private System.Windows.Forms.Button btnGånger;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button buttonPunkt;
        private System.Windows.Forms.Button btnCE;
    }
}