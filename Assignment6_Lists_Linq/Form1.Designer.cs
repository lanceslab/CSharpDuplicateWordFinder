namespace Assignment6_Lists_Linq
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.buttonAllWords = new System.Windows.Forms.Button();
            this.buttonDuplicateWords = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type a sentence here.";
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Location = new System.Drawing.Point(63, 81);
            this.textBoxSentence.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.Size = new System.Drawing.Size(805, 22);
            this.textBoxSentence.TabIndex = 1;
            // 
            // buttonAllWords
            // 
            this.buttonAllWords.Location = new System.Drawing.Point(63, 138);
            this.buttonAllWords.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllWords.Name = "buttonAllWords";
            this.buttonAllWords.Size = new System.Drawing.Size(97, 52);
            this.buttonAllWords.TabIndex = 2;
            this.buttonAllWords.Text = "All Words";
            this.buttonAllWords.UseVisualStyleBackColor = true;
            this.buttonAllWords.Click += new System.EventHandler(this.buttonAllWords_Click);
            // 
            // buttonDuplicateWords
            // 
            this.buttonDuplicateWords.Location = new System.Drawing.Point(509, 138);
            this.buttonDuplicateWords.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDuplicateWords.Name = "buttonDuplicateWords";
            this.buttonDuplicateWords.Size = new System.Drawing.Size(100, 52);
            this.buttonDuplicateWords.TabIndex = 3;
            this.buttonDuplicateWords.Text = "Duplicate Words";
            this.buttonDuplicateWords.UseVisualStyleBackColor = true;
            this.buttonDuplicateWords.Click += new System.EventHandler(this.buttonDuplicateWords_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(169, 138);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 452);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(617, 138);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(251, 452);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 619);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDuplicateWords);
            this.Controls.Add(this.buttonAllWords);
            this.Controls.Add(this.textBoxSentence);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lance\'sLab - Finding duplicate words using Lists and LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.Button buttonAllWords;
        private System.Windows.Forms.Button buttonDuplicateWords;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

