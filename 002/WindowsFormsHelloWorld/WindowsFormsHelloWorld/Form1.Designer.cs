namespace WindowsFormsHelloWorld
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
            this.textBoxShowHello = new System.Windows.Forms.TextBox();
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowHello
            // 
            this.textBoxShowHello.Location = new System.Drawing.Point(0, 0);
            this.textBoxShowHello.Name = "textBoxShowHello";
            this.textBoxShowHello.Size = new System.Drawing.Size(284, 21);
            this.textBoxShowHello.TabIndex = 0;
            this.textBoxShowHello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(0, 28);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(284, 23);
            this.buttonSayHello.TabIndex = 1;
            this.buttonSayHello.Text = "Click Me";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSayHello);
            this.Controls.Add(this.textBoxShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowHello;
        private System.Windows.Forms.Button buttonSayHello;
    }
}

