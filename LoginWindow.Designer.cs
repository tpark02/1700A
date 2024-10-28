namespace Serial_Communication
{
    partial class LoginWindow
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
            this.msgLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.Location = new System.Drawing.Point(41, 125);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(310, 27);
            this.msgLabel.TabIndex = 9;
            this.msgLabel.Text = "The Password is not matched";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the PASSWORD";
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(46, 158);
            this.signInButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(294, 51);
            this.signInButton.TabIndex = 7;
            this.signInButton.Text = "Enter";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            this.signInButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passWordTextBox.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTextBox.Location = new System.Drawing.Point(46, 56);
            this.passWordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(294, 49);
            this.passWordTextBox.TabIndex = 6;
            this.passWordTextBox.UseSystemPasswordChar = true;
            this.passWordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 238);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passWordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passWordTextBox;
    }
}