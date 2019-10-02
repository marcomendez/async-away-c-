namespace UI
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
            this.readFileBtn = new System.Windows.Forms.Button();
            this.lbl_view_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(239, 166);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(240, 74);
            this.readFileBtn.TabIndex = 0;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.ReadFileBtn_Click);
            this.readFileBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.readFileBtn_KeyDown);
            // 
            // lbl_view_text
            // 
            this.lbl_view_text.AutoSize = true;
            this.lbl_view_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view_text.Location = new System.Drawing.Point(127, 68);
            this.lbl_view_text.Name = "lbl_view_text";
            this.lbl_view_text.Size = new System.Drawing.Size(48, 29);
            this.lbl_view_text.TabIndex = 2;
            this.lbl_view_text.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = ".....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_view_text);
            this.Controls.Add(this.readFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Label lbl_view_text;
        private System.Windows.Forms.Label label1;
    }
}

