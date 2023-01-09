namespace WebBrowser
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.textBoxLHS = new System.Windows.Forms.TextBox();
            this.textBoxRHS = new System.Windows.Forms.TextBox();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(0, 1);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(570, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://google.com";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(576, -2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(87, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // textBoxLHS
            // 
            this.textBoxLHS.Location = new System.Drawing.Point(12, 442);
            this.textBoxLHS.Name = "textBoxLHS";
            this.textBoxLHS.Size = new System.Drawing.Size(100, 20);
            this.textBoxLHS.TabIndex = 3;
            // 
            // textBoxRHS
            // 
            this.textBoxRHS.Location = new System.Drawing.Point(134, 442);
            this.textBoxRHS.Name = "textBoxRHS";
            this.textBoxRHS.Size = new System.Drawing.Size(100, 20);
            this.textBoxRHS.TabIndex = 4;
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(73, 478);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(55, 23);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(12, 478);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(55, 23);
            this.plusButton.TabIndex = 6;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(134, 478);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(55, 23);
            this.multButton.TabIndex = 7;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(195, 478);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(55, 23);
            this.divButton.TabIndex = 8;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(704, 601);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 537);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "output";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Convert F to C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Convert C to F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 601);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.textBoxRHS);
            this.Controls.Add(this.textBoxLHS);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Ben\'s Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox textBoxLHS;
        private System.Windows.Forms.TextBox textBoxRHS;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

