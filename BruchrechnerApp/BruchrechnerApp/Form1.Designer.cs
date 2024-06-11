namespace BruchrechnerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxZaehler1 = new System.Windows.Forms.TextBox();
            this.textBoxNenner1 = new System.Windows.Forms.TextBox();
            this.textBoxZaehler2 = new System.Windows.Forms.TextBox();
            this.textBoxNenner2 = new System.Windows.Forms.TextBox();
            this.textBoxErgebnisZaehler = new System.Windows.Forms.TextBox();
            this.textBoxErgebnisNenner = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxZaehler1
            // 
            this.textBoxZaehler1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZaehler1.Location = new System.Drawing.Point(93, 93);
            this.textBoxZaehler1.Multiline = true;
            this.textBoxZaehler1.Name = "textBoxZaehler1";
            this.textBoxZaehler1.Size = new System.Drawing.Size(126, 53);
            this.textBoxZaehler1.TabIndex = 0;
            this.textBoxZaehler1.TextChanged += new System.EventHandler(this.textBoxZaehler1_TextChanged);
            // 
            // textBoxNenner1
            // 
            this.textBoxNenner1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNenner1.Location = new System.Drawing.Point(93, 246);
            this.textBoxNenner1.Multiline = true;
            this.textBoxNenner1.Name = "textBoxNenner1";
            this.textBoxNenner1.Size = new System.Drawing.Size(126, 53);
            this.textBoxNenner1.TabIndex = 1;
            this.textBoxNenner1.TextChanged += new System.EventHandler(this.textBoxNenner1_TextChanged);
            // 
            // textBoxZaehler2
            // 
            this.textBoxZaehler2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZaehler2.Location = new System.Drawing.Point(474, 93);
            this.textBoxZaehler2.Multiline = true;
            this.textBoxZaehler2.Name = "textBoxZaehler2";
            this.textBoxZaehler2.Size = new System.Drawing.Size(126, 53);
            this.textBoxZaehler2.TabIndex = 2;
            // 
            // textBoxNenner2
            // 
            this.textBoxNenner2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNenner2.Location = new System.Drawing.Point(474, 246);
            this.textBoxNenner2.Multiline = true;
            this.textBoxNenner2.Name = "textBoxNenner2";
            this.textBoxNenner2.Size = new System.Drawing.Size(126, 53);
            this.textBoxNenner2.TabIndex = 3;
            // 
            // textBoxErgebnisZaehler
            // 
            this.textBoxErgebnisZaehler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxErgebnisZaehler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErgebnisZaehler.Location = new System.Drawing.Point(733, 93);
            this.textBoxErgebnisZaehler.Multiline = true;
            this.textBoxErgebnisZaehler.Name = "textBoxErgebnisZaehler";
            this.textBoxErgebnisZaehler.ReadOnly = true;
            this.textBoxErgebnisZaehler.Size = new System.Drawing.Size(169, 53);
            this.textBoxErgebnisZaehler.TabIndex = 4;
            this.textBoxErgebnisZaehler.TextChanged += new System.EventHandler(this.textBoxErgebnisZaehler_TextChanged);
            // 
            // textBoxErgebnisNenner
            // 
            this.textBoxErgebnisNenner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxErgebnisNenner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErgebnisNenner.Location = new System.Drawing.Point(733, 246);
            this.textBoxErgebnisNenner.Multiline = true;
            this.textBoxErgebnisNenner.Name = "textBoxErgebnisNenner";
            this.textBoxErgebnisNenner.ReadOnly = true;
            this.textBoxErgebnisNenner.Size = new System.Drawing.Size(169, 53);
            this.textBoxErgebnisNenner.TabIndex = 5;
            this.textBoxErgebnisNenner.TextChanged += new System.EventHandler(this.textBoxErgebnisNenner_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(273, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(273, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "^";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(354, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(354, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(354, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 40);
            this.button6.TabIndex = 12;
            this.button6.Text = "√";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerechnen.Location = new System.Drawing.Point(642, 175);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(49, 40);
            this.buttonBerechnen.TabIndex = 13;
            this.buttonBerechnen.Text = "=";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 392);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxErgebnisNenner);
            this.Controls.Add(this.textBoxErgebnisZaehler);
            this.Controls.Add(this.textBoxNenner2);
            this.Controls.Add(this.textBoxZaehler2);
            this.Controls.Add(this.textBoxNenner1);
            this.Controls.Add(this.textBoxZaehler1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bruchrechner App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZaehler1;
        private System.Windows.Forms.TextBox textBoxNenner1;
        private System.Windows.Forms.TextBox textBoxZaehler2;
        private System.Windows.Forms.TextBox textBoxNenner2;
        private System.Windows.Forms.TextBox textBoxErgebnisZaehler;
        private System.Windows.Forms.TextBox textBoxErgebnisNenner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonBerechnen;
    }
}

