namespace EQotd
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
            this.bGetQotd = new System.Windows.Forms.Button();
            this.lQotd = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bGetQotd
            // 
            this.bGetQotd.Location = new System.Drawing.Point(26, 28);
            this.bGetQotd.Name = "bGetQotd";
            this.bGetQotd.Size = new System.Drawing.Size(75, 23);
            this.bGetQotd.TabIndex = 0;
            this.bGetQotd.Text = "Get";
            this.bGetQotd.UseVisualStyleBackColor = true;
            this.bGetQotd.Click += new System.EventHandler(this.bGetQotd_Click);
            // 
            // lQotd
            // 
            this.lQotd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQotd.Location = new System.Drawing.Point(18, 89);
            this.lQotd.Name = "lQotd";
            this.lQotd.Size = new System.Drawing.Size(770, 248);
            this.lQotd.TabIndex = 1;
            this.lQotd.Text = "label1";
            this.lQotd.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(26, 63);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(762, 23);
            this.progressBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lQotd);
            this.Controls.Add(this.bGetQotd);
            this.Name = "MainForm";
            this.Text = "Quote of the Day";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGetQotd;
        private System.Windows.Forms.Label lQotd;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

