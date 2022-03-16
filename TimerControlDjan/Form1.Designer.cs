namespace TimerControlDjan
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
            this.btnAddTimerDjan = new System.Windows.Forms.Button();
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAddTimerDjan
            // 
            this.btnAddTimerDjan.Location = new System.Drawing.Point(13, 13);
            this.btnAddTimerDjan.Name = "btnAddTimerDjan";
            this.btnAddTimerDjan.Size = new System.Drawing.Size(75, 23);
            this.btnAddTimerDjan.TabIndex = 1;
            this.btnAddTimerDjan.Text = "Add Timer";
            this.btnAddTimerDjan.UseVisualStyleBackColor = true;
            this.btnAddTimerDjan.Click += new System.EventHandler(this.btnAddTimerDjan_Click);
            // 
            // Flow
            // 
            this.Flow.Location = new System.Drawing.Point(134, 12);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(654, 426);
            this.Flow.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Flow);
            this.Controls.Add(this.btnAddTimerDjan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddTimerDjan;
        private System.Windows.Forms.FlowLayoutPanel Flow;
    }
}

