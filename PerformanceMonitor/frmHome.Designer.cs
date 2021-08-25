
namespace PerformanceMonitor
{
    partial class frmHome
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
            this.lblSpeech = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpeech
            // 
            this.lblSpeech.AutoSize = true;
            this.lblSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeech.Location = new System.Drawing.Point(51, 85);
            this.lblSpeech.Name = "lblSpeech";
            this.lblSpeech.Size = new System.Drawing.Size(132, 47);
            this.lblSpeech.TabIndex = 0;
            this.lblSpeech.Text = "label1";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 255);
            this.Controls.Add(this.lblSpeech);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeech;
    }
}

