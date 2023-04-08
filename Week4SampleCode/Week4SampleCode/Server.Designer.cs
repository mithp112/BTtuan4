namespace Week4SampleCode
{
    partial class Server
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
            this.listenButton = new System.Windows.Forms.Button();
            this.logMsgBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(505, 62);
            this.listenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(121, 48);
            this.listenButton.TabIndex = 0;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // logMsgBox
            // 
            this.logMsgBox.Location = new System.Drawing.Point(15, 120);
            this.logMsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logMsgBox.Name = "logMsgBox";
            this.logMsgBox.Size = new System.Drawing.Size(610, 562);
            this.logMsgBox.TabIndex = 1;
            this.logMsgBox.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 703);
            this.Controls.Add(this.logMsgBox);
            this.Controls.Add(this.listenButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "Bai4_Server";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.RichTextBox logMsgBox;
    }
}