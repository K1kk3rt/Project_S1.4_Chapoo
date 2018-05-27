namespace Chapoo
{
    partial class Chapoo
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
            this.btn_testKeuken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_testKeuken
            // 
            this.btn_testKeuken.Location = new System.Drawing.Point(480, 344);
            this.btn_testKeuken.Name = "btn_testKeuken";
            this.btn_testKeuken.Size = new System.Drawing.Size(388, 150);
            this.btn_testKeuken.TabIndex = 0;
            this.btn_testKeuken.Text = "Test Keukenoverzicht";
            this.btn_testKeuken.UseVisualStyleBackColor = true;
            this.btn_testKeuken.Click += new System.EventHandler(this.btn_testKeuken_Click);
            // 
            // Chapoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.btn_testKeuken);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chapoo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_testKeuken;
    }
}

