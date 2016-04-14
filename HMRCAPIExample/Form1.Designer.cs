namespace HMRCAPIExample
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
            this.cmdHelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHelloWorld
            // 
            this.cmdHelloWorld.Location = new System.Drawing.Point(421, 434);
            this.cmdHelloWorld.Name = "cmdHelloWorld";
            this.cmdHelloWorld.Size = new System.Drawing.Size(131, 37);
            this.cmdHelloWorld.TabIndex = 0;
            this.cmdHelloWorld.Text = "Hello World";
            this.cmdHelloWorld.UseVisualStyleBackColor = true;
            this.cmdHelloWorld.Click += new System.EventHandler(this.cmdHelloWorld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(564, 568);
            this.Controls.Add(this.cmdHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdHelloWorld;
    }
}

