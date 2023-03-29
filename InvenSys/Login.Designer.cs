namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cntlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntlogin
            // 
            this.cntlogin.BackColor = System.Drawing.Color.LemonChiffon;
            this.cntlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntlogin.BackgroundImage")));
            this.cntlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cntlogin.Location = new System.Drawing.Point(663, 510);
            this.cntlogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cntlogin.Name = "cntlogin";
            this.cntlogin.Size = new System.Drawing.Size(245, 42);
            this.cntlogin.TabIndex = 0;
            this.cntlogin.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1368, 770);
            this.Controls.Add(this.cntlogin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Dagsen Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cntlogin;

    }
}
    