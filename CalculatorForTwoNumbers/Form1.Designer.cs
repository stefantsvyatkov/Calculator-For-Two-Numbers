namespace WinFormControls
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
            this.firstNumBox = new System.Windows.Forms.TextBox();
            this.secondNumBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.ComboBox();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumBox
            // 
            this.firstNumBox.AccessibleName = "First number";
            this.firstNumBox.Location = new System.Drawing.Point(120, 50);
            this.firstNumBox.Name = "firstNumBox";
            this.firstNumBox.Size = new System.Drawing.Size(101, 20);
            this.firstNumBox.TabIndex = 0;
            // 
            // secondNumBox
            // 
            this.secondNumBox.AccessibleName = "Second number";
            this.secondNumBox.Location = new System.Drawing.Point(120, 100);
            this.secondNumBox.Name = "secondNumBox";
            this.secondNumBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculateButton.Location = new System.Drawing.Point(120, 200);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // operation
            // 
            this.operation.AccessibleName = " Operation";
            this.operation.Cursor = System.Windows.Forms.Cursors.Default;
            this.operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.operation.Location = new System.Drawing.Point(120, 150);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(121, 21);
            this.operation.TabIndex = 2;
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AccessibleName = "";
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(20, 50);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(64, 13);
            this.firstNumLabel.TabIndex = 5;
            this.firstNumLabel.Text = "First number";
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Location = new System.Drawing.Point(20, 100);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(82, 13);
            this.secondNumLabel.TabIndex = 7;
            this.secondNumLabel.Text = "Second number";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(20, 150);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(53, 13);
            this.operationLabel.TabIndex = 9;
            this.operationLabel.Text = "Operation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.secondNumLabel);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondNumBox);
            this.Controls.Add(this.firstNumBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator for two numbers";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNumBox;
        private System.Windows.Forms.TextBox secondNumBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Label operationLabel;
    }
}

