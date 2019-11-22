namespace FAsyncAwaitGUI
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
            this.bDoSomething = new System.Windows.Forms.Button();
            this.bDoSomethingThread = new System.Windows.Forms.Button();
            this.bDoSomethingAsync = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bDoSomething
            // 
            this.bDoSomething.Location = new System.Drawing.Point(10, 10);
            this.bDoSomething.Margin = new System.Windows.Forms.Padding(1);
            this.bDoSomething.Name = "bDoSomething";
            this.bDoSomething.Size = new System.Drawing.Size(190, 34);
            this.bDoSomething.TabIndex = 0;
            this.bDoSomething.Text = "Do Something";
            this.bDoSomething.UseVisualStyleBackColor = true;
            this.bDoSomething.Click += new System.EventHandler(this.bDoSomething_Click);
            // 
            // bDoSomethingThread
            // 
            this.bDoSomethingThread.Location = new System.Drawing.Point(10, 56);
            this.bDoSomethingThread.Margin = new System.Windows.Forms.Padding(1);
            this.bDoSomethingThread.Name = "bDoSomethingThread";
            this.bDoSomethingThread.Size = new System.Drawing.Size(190, 34);
            this.bDoSomethingThread.TabIndex = 1;
            this.bDoSomethingThread.Text = "Do Something Thread";
            this.bDoSomethingThread.UseVisualStyleBackColor = true;
            this.bDoSomethingThread.Click += new System.EventHandler(this.bDoSomethingThread_Click);
            // 
            // bDoSomethingAsync
            // 
            this.bDoSomethingAsync.Location = new System.Drawing.Point(10, 108);
            this.bDoSomethingAsync.Margin = new System.Windows.Forms.Padding(1);
            this.bDoSomethingAsync.Name = "bDoSomethingAsync";
            this.bDoSomethingAsync.Size = new System.Drawing.Size(190, 34);
            this.bDoSomethingAsync.TabIndex = 2;
            this.bDoSomethingAsync.Text = "Do Something Async";
            this.bDoSomethingAsync.UseVisualStyleBackColor = true;
            this.bDoSomethingAsync.Click += new System.EventHandler(this.bDoSomethingAsync_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResult.Location = new System.Drawing.Point(12, 166);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(87, 29);
            this.lResult.TabIndex = 3;
            this.lResult.Text = "lResult";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 221);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bDoSomethingAsync);
            this.Controls.Add(this.bDoSomethingThread);
            this.Controls.Add(this.bDoSomething);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "Async-Await in GUI apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDoSomething;
        private System.Windows.Forms.Button bDoSomethingThread;
        private System.Windows.Forms.Button bDoSomethingAsync;
        private System.Windows.Forms.Label lResult;
    }
}

