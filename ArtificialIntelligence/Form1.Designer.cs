namespace ArtificialIntelligence
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
            this.binary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizetxt = new System.Windows.Forms.TextBox();
            this.lengthtxt = new System.Windows.Forms.TextBox();
            this.resualttxt = new System.Windows.Forms.TextBox();
            this.evabu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.evatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fittxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectbu = new System.Windows.Forms.Button();
            this.selecttxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.childtxt = new System.Windows.Forms.TextBox();
            this.crossoverbu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mutationbu = new System.Windows.Forms.Button();
            this.mutatintxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binary
            // 
            this.binary.Location = new System.Drawing.Point(87, 133);
            this.binary.Margin = new System.Windows.Forms.Padding(4);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(141, 51);
            this.binary.TabIndex = 0;
            this.binary.Text = "Binary";
            this.binary.UseVisualStyleBackColor = true;
            this.binary.Click += new System.EventHandler(this.binary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Length";
            // 
            // sizetxt
            // 
            this.sizetxt.Location = new System.Drawing.Point(171, 11);
            this.sizetxt.Margin = new System.Windows.Forms.Padding(4);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(148, 32);
            this.sizetxt.TabIndex = 3;
            // 
            // lengthtxt
            // 
            this.lengthtxt.Location = new System.Drawing.Point(171, 75);
            this.lengthtxt.Margin = new System.Windows.Forms.Padding(4);
            this.lengthtxt.Name = "lengthtxt";
            this.lengthtxt.Size = new System.Drawing.Size(148, 32);
            this.lengthtxt.TabIndex = 4;
            // 
            // resualttxt
            // 
            this.resualttxt.Location = new System.Drawing.Point(543, 12);
            this.resualttxt.Margin = new System.Windows.Forms.Padding(4);
            this.resualttxt.Multiline = true;
            this.resualttxt.Name = "resualttxt";
            this.resualttxt.Size = new System.Drawing.Size(220, 171);
            this.resualttxt.TabIndex = 5;
            // 
            // evabu
            // 
            this.evabu.Location = new System.Drawing.Point(87, 224);
            this.evabu.Margin = new System.Windows.Forms.Padding(4);
            this.evabu.Name = "evabu";
            this.evabu.Size = new System.Drawing.Size(141, 60);
            this.evabu.TabIndex = 6;
            this.evabu.Text = "Evaluation";
            this.evabu.UseVisualStyleBackColor = true;
            this.evabu.Click += new System.EventHandler(this.evabu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "initial Resualt";
            // 
            // evatxt
            // 
            this.evatxt.Location = new System.Drawing.Point(543, 209);
            this.evatxt.Margin = new System.Windows.Forms.Padding(4);
            this.evatxt.Multiline = true;
            this.evatxt.Name = "evatxt";
            this.evatxt.Size = new System.Drawing.Size(220, 171);
            this.evatxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Evaluation Resault";
            // 
            // fittxt
            // 
            this.fittxt.Location = new System.Drawing.Point(543, 391);
            this.fittxt.Margin = new System.Windows.Forms.Padding(4);
            this.fittxt.Multiline = true;
            this.fittxt.Name = "fittxt";
            this.fittxt.Size = new System.Drawing.Size(220, 171);
            this.fittxt.TabIndex = 10;
            this.fittxt.TextChanged += new System.EventHandler(this.fittxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 468);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "fitness Resualt";
            // 
            // selectbu
            // 
            this.selectbu.Location = new System.Drawing.Point(87, 329);
            this.selectbu.Margin = new System.Windows.Forms.Padding(4);
            this.selectbu.Name = "selectbu";
            this.selectbu.Size = new System.Drawing.Size(141, 60);
            this.selectbu.TabIndex = 12;
            this.selectbu.Text = "Select";
            this.selectbu.UseVisualStyleBackColor = true;
            this.selectbu.Click += new System.EventHandler(this.selectbu_Click);
            // 
            // selecttxt
            // 
            this.selecttxt.Location = new System.Drawing.Point(543, 570);
            this.selecttxt.Margin = new System.Windows.Forms.Padding(4);
            this.selecttxt.Multiline = true;
            this.selecttxt.Name = "selecttxt";
            this.selecttxt.Size = new System.Drawing.Size(220, 171);
            this.selecttxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 630);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(771, 570);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 171);
            this.textBox1.TabIndex = 15;
            // 
            // childtxt
            // 
            this.childtxt.Location = new System.Drawing.Point(879, 16);
            this.childtxt.Margin = new System.Windows.Forms.Padding(4);
            this.childtxt.Multiline = true;
            this.childtxt.Name = "childtxt";
            this.childtxt.Size = new System.Drawing.Size(220, 171);
            this.childtxt.TabIndex = 16;
            // 
            // crossoverbu
            // 
            this.crossoverbu.Location = new System.Drawing.Point(87, 418);
            this.crossoverbu.Margin = new System.Windows.Forms.Padding(4);
            this.crossoverbu.Name = "crossoverbu";
            this.crossoverbu.Size = new System.Drawing.Size(141, 60);
            this.crossoverbu.TabIndex = 17;
            this.crossoverbu.Text = "crossover1x";
            this.crossoverbu.UseVisualStyleBackColor = true;
            this.crossoverbu.Click += new System.EventHandler(this.crossoverbu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "crossover";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "crossover2x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mutationbu
            // 
            this.mutationbu.Location = new System.Drawing.Point(87, 555);
            this.mutationbu.Margin = new System.Windows.Forms.Padding(4);
            this.mutationbu.Name = "mutationbu";
            this.mutationbu.Size = new System.Drawing.Size(141, 60);
            this.mutationbu.TabIndex = 20;
            this.mutationbu.Text = "Mutation1x";
            this.mutationbu.UseVisualStyleBackColor = true;
            this.mutationbu.Click += new System.EventHandler(this.mutationbu_Click);
            // 
            // mutatintxt
            // 
            this.mutatintxt.Location = new System.Drawing.Point(879, 218);
            this.mutatintxt.Margin = new System.Windows.Forms.Padding(4);
            this.mutatintxt.Multiline = true;
            this.mutatintxt.Name = "mutatintxt";
            this.mutatintxt.Size = new System.Drawing.Size(220, 171);
            this.mutatintxt.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mutation";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(879, 397);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 171);
            this.textBox2.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 623);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 60);
            this.button2.TabIndex = 24;
            this.button2.Text = "Mutation2x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(780, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "new pop";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 691);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 60);
            this.button3.TabIndex = 26;
            this.button3.Text = "New pop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 856);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mutatintxt);
            this.Controls.Add(this.mutationbu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crossoverbu);
            this.Controls.Add(this.childtxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selecttxt);
            this.Controls.Add(this.selectbu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fittxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.evabu);
            this.Controls.Add(this.resualttxt);
            this.Controls.Add(this.lengthtxt);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binary);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button binary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizetxt;
        private System.Windows.Forms.TextBox lengthtxt;
        private System.Windows.Forms.TextBox resualttxt;
        private System.Windows.Forms.Button evabu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox evatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fittxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectbu;
        private System.Windows.Forms.TextBox selecttxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox childtxt;
        private System.Windows.Forms.Button crossoverbu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mutationbu;
        private System.Windows.Forms.TextBox mutatintxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}

