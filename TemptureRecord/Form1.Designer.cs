
namespace TemptureRecord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsign = new System.Windows.Forms.Button();
            this.txtTempture = new System.Windows.Forms.TextBox();
            this.cblistName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsign
            // 
            this.btnsign.Location = new System.Drawing.Point(12, 94);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(141, 35);
            this.btnsign.TabIndex = 0;
            this.btnsign.Text = "登記";
            this.btnsign.UseVisualStyleBackColor = true;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // txtTempture
            // 
            this.txtTempture.Location = new System.Drawing.Point(12, 49);
            this.txtTempture.Name = "txtTempture";
            this.txtTempture.Size = new System.Drawing.Size(141, 30);
            this.txtTempture.TabIndex = 2;
            // 
            // cblistName
            // 
            this.cblistName.FormattingEnabled = true;
            this.cblistName.Location = new System.Drawing.Point(12, 12);
            this.cblistName.Name = "cblistName";
            this.cblistName.Size = new System.Drawing.Size(182, 31);
            this.cblistName.TabIndex = 3;
            this.cblistName.SelectedIndexChanged += new System.EventHandler(this.cblistName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 144);
            this.Controls.Add(this.cblistName);
            this.Controls.Add(this.txtTempture);
            this.Controls.Add(this.btnsign);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.TextBox txtTempture;
        private System.Windows.Forms.ComboBox cblistName;
    }
}

