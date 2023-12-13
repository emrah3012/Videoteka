namespace VideotekaUI
{
    partial class MainForm
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
            this.lblDobrodosao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDobrodosao
            // 
            this.lblDobrodosao.AutoSize = true;
            this.lblDobrodosao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosao.Location = new System.Drawing.Point(128, 146);
            this.lblDobrodosao.Name = "lblDobrodosao";
            this.lblDobrodosao.Size = new System.Drawing.Size(70, 26);
            this.lblDobrodosao.TabIndex = 0;
            this.lblDobrodosao.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.lblDobrodosao);
            this.Name = "MainForm";
            this.Text = "Glavna forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosao;
    }
}

