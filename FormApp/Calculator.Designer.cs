namespace FormApp
{
    partial class Calculator
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
            System.Windows.Forms.Button n3;
            System.Windows.Forms.Button add;
            System.Windows.Forms.Button equal;
            System.Windows.Forms.Button div;
            System.Windows.Forms.Button mul;
            System.Windows.Forms.Button sub;
            System.Windows.Forms.Button changeSign;
            System.Windows.Forms.Button Dot_Click;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nc = new System.Windows.Forms.Button();
            n3 = new System.Windows.Forms.Button();
            add = new System.Windows.Forms.Button();
            equal = new System.Windows.Forms.Button();
            div = new System.Windows.Forms.Button();
            mul = new System.Windows.Forms.Button();
            sub = new System.Windows.Forms.Button();
            changeSign = new System.Windows.Forms.Button();
            Dot_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n3
            // 
            n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n3.Location = new System.Drawing.Point(129, 231);
            n3.Name = "n3";
            n3.Size = new System.Drawing.Size(68, 60);
            n3.TabIndex = 5;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += new System.EventHandler(this.N3_click);
            // 
            // add
            // 
            add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            add.Location = new System.Drawing.Point(193, 231);
            add.Name = "add";
            add.Size = new System.Drawing.Size(68, 60);
            add.TabIndex = 11;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += new System.EventHandler(this.Add_click);
            // 
            // equal
            // 
            equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equal.Location = new System.Drawing.Point(193, 287);
            equal.Name = "equal";
            equal.Size = new System.Drawing.Size(68, 60);
            equal.TabIndex = 12;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += new System.EventHandler(this.Equal_click);
            // 
            // div
            // 
            div.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            div.Location = new System.Drawing.Point(193, 62);
            div.Name = "div";
            div.Size = new System.Drawing.Size(68, 60);
            div.TabIndex = 13;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += new System.EventHandler(this.Div_Click);
            // 
            // mul
            // 
            mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mul.Location = new System.Drawing.Point(193, 119);
            mul.Name = "mul";
            mul.Size = new System.Drawing.Size(68, 60);
            mul.TabIndex = 14;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            mul.Click += new System.EventHandler(this.Mul_click);
            // 
            // sub
            // 
            sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sub.Location = new System.Drawing.Point(193, 174);
            sub.Name = "sub";
            sub.Size = new System.Drawing.Size(68, 60);
            sub.TabIndex = 15;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += new System.EventHandler(this.Sub_click);
            // 
            // changeSign
            // 
            changeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            changeSign.Location = new System.Drawing.Point(129, 62);
            changeSign.Name = "changeSign";
            changeSign.Size = new System.Drawing.Size(68, 60);
            changeSign.TabIndex = 17;
            changeSign.Text = "+/-";
            changeSign.UseVisualStyleBackColor = true;
            changeSign.Click += new System.EventHandler(this.Change_Sign);
            // 
            // Dot_Click
            // 
            Dot_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Dot_Click.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            Dot_Click.Location = new System.Drawing.Point(129, 287);
            Dot_Click.Name = "Dot_Click";
            Dot_Click.Size = new System.Drawing.Size(68, 60);
            Dot_Click.TabIndex = 18;
            Dot_Click.Text = ".";
            Dot_Click.UseVisualStyleBackColor = true;
            Dot_Click.Click += new System.EventHandler(this.Dot_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 56);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(0, 231);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(68, 60);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.N1_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(129, 174);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(68, 60);
            this.n6.TabIndex = 2;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.N6_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(65, 174);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(68, 60);
            this.n5.TabIndex = 3;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.N5_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(0, 174);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(68, 60);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.N4_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(65, 231);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(68, 60);
            this.n2.TabIndex = 6;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.N2_click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(129, 119);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(68, 60);
            this.n9.TabIndex = 7;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.N9_click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(65, 119);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(68, 60);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.N8_click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(0, 119);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(68, 60);
            this.n7.TabIndex = 9;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.N7_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(0, 287);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(133, 60);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.N0_Click);
            // 
            // nc
            // 
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(0, 62);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(133, 60);
            this.nc.TabIndex = 16;
            this.nc.Text = "C";
            this.nc.UseVisualStyleBackColor = true;
            this.nc.Click += new System.EventHandler(this.Nc_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 346);
            this.Controls.Add(Dot_Click);
            this.Controls.Add(changeSign);
            this.Controls.Add(this.nc);
            this.Controls.Add(sub);
            this.Controls.Add(mul);
            this.Controls.Add(div);
            this.Controls.Add(equal);
            this.Controls.Add(add);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n2);
            this.Controls.Add(n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button nc;
    }
}

