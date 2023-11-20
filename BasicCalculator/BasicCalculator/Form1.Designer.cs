namespace BasicCalculator
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.bntCompute = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(97, 69);
            this.Num1.Multiline = true;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(177, 26);
            this.Num1.TabIndex = 0;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(97, 128);
            this.Num2.Multiline = true;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(177, 26);
            this.Num2.TabIndex = 1;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(152, 101);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(65, 21);
            this.cbOperator.TabIndex = 2;
            // 
            // bntCompute
            // 
            this.bntCompute.Location = new System.Drawing.Point(142, 289);
            this.bntCompute.Name = "bntCompute";
            this.bntCompute.Size = new System.Drawing.Size(94, 23);
            this.bntCompute.TabIndex = 3;
            this.bntCompute.Text = "Compute";
            this.bntCompute.UseVisualStyleBackColor = true;
            this.bntCompute.Click += new System.EventHandler(this.bntCompute_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(85, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.BackColor = System.Drawing.Color.Black;
            this.totallbl.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totallbl.Location = new System.Drawing.Point(83, 213);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(0, 27);
            this.totallbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(367, 324);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bntCompute);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button bntCompute;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totallbl;
    }
}

