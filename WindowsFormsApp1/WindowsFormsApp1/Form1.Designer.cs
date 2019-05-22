namespace WindowsFormsApp1
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
            this.sumar = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(190, 135);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(75, 23);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(501, 135);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 1;
            this.suma.Text = "suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button suma;
    }
}

