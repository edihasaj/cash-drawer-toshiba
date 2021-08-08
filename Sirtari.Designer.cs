namespace SirtariToshiba
{
    partial class Sirtari
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
            this.openCashDrawer = new System.Windows.Forms.Button();
            this.waitCashDrawerOpen = new System.Windows.Forms.Button();
            this.closeCashDrawer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openCashDrawer
            // 
            this.openCashDrawer.Location = new System.Drawing.Point(26, 20);
            this.openCashDrawer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openCashDrawer.Name = "openCashDrawer";
            this.openCashDrawer.Size = new System.Drawing.Size(154, 43);
            this.openCashDrawer.TabIndex = 0;
            this.openCashDrawer.Text = "Hap sirtarin";
            this.openCashDrawer.UseVisualStyleBackColor = true;
            this.openCashDrawer.Click += new System.EventHandler(this.openCashDrawer_Click);
            // 
            // waitCashDrawerOpen
            // 
            this.waitCashDrawerOpen.Location = new System.Drawing.Point(26, 74);
            this.waitCashDrawerOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.waitCashDrawerOpen.Name = "waitCashDrawerOpen";
            this.waitCashDrawerOpen.Size = new System.Drawing.Size(154, 43);
            this.waitCashDrawerOpen.TabIndex = 1;
            this.waitCashDrawerOpen.Text = "Prit mbylljen e sirtarit";
            this.waitCashDrawerOpen.UseVisualStyleBackColor = true;
            this.waitCashDrawerOpen.Click += new System.EventHandler(this.waitCashDrawerOpen_Click);
            // 
            // closeCashDrawer
            // 
            this.closeCashDrawer.Location = new System.Drawing.Point(26, 127);
            this.closeCashDrawer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeCashDrawer.Name = "closeCashDrawer";
            this.closeCashDrawer.Size = new System.Drawing.Size(154, 43);
            this.closeCashDrawer.TabIndex = 2;
            this.closeCashDrawer.Text = "Ndalo sirtarin";
            this.closeCashDrawer.UseVisualStyleBackColor = true;
            this.closeCashDrawer.Click += new System.EventHandler(this.closeCashDrawer_Click);
            // 
            // Sirtari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 189);
            this.Controls.Add(this.closeCashDrawer);
            this.Controls.Add(this.waitCashDrawerOpen);
            this.Controls.Add(this.openCashDrawer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sirtari";
            this.ShowIcon = false;
            this.Text = "Sirtari";
            this.Load += new System.EventHandler(this.Sirtari_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openCashDrawer;
        private System.Windows.Forms.Button waitCashDrawerOpen;
        private System.Windows.Forms.Button closeCashDrawer;
    }
}

