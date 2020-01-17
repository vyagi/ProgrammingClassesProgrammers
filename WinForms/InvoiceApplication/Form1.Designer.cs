namespace InvoiceApplication
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
            this.byNamesButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.byMonthsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byNamesButton
            // 
            this.byNamesButton.Location = new System.Drawing.Point(13, 13);
            this.byNamesButton.Name = "byNamesButton";
            this.byNamesButton.Size = new System.Drawing.Size(75, 23);
            this.byNamesButton.TabIndex = 0;
            this.byNamesButton.Text = "By names";
            this.byNamesButton.UseVisualStyleBackColor = true;
            this.byNamesButton.Click += new System.EventHandler(this.byNameButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(13, 43);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(775, 394);
            this.resultListBox.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(265, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(346, 18);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "label1";
            // 
            // byMonthsButton
            // 
            this.byMonthsButton.Location = new System.Drawing.Point(95, 12);
            this.byMonthsButton.Name = "byMonthsButton";
            this.byMonthsButton.Size = new System.Drawing.Size(75, 23);
            this.byMonthsButton.TabIndex = 4;
            this.byMonthsButton.Text = "By months";
            this.byMonthsButton.UseVisualStyleBackColor = true;
            this.byMonthsButton.Click += new System.EventHandler(this.byMonthsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.byMonthsButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.byNamesButton);
            this.Name = "Form1";
            this.Text = "Invoice manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button byNamesButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button byMonthsButton;
    }
}

