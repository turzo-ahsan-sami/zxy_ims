namespace ZXY_IMS.UI
{
    partial class Navigation
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
            this.productButton = new System.Windows.Forms.Button();
            this.productcategoryButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.navBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(0, 61);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(105, 23);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // productcategoryButton
            // 
            this.productcategoryButton.Location = new System.Drawing.Point(0, 32);
            this.productcategoryButton.Name = "productcategoryButton";
            this.productcategoryButton.Size = new System.Drawing.Size(105, 23);
            this.productcategoryButton.TabIndex = 0;
            this.productcategoryButton.Text = "Category";
            this.productcategoryButton.UseVisualStyleBackColor = true;
            this.productcategoryButton.Click += new System.EventHandler(this.productcategoryButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(0, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(105, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.navBarPanel.Controls.Add(this.homeButton);
            this.navBarPanel.Controls.Add(this.productcategoryButton);
            this.navBarPanel.Controls.Add(this.productButton);
            this.navBarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarPanel.Location = new System.Drawing.Point(1166, 10);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(108, 641);
            this.navBarPanel.TabIndex = 2;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(3, 11);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1161, 639);
            this.contentPanel.TabIndex = 3;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Navigation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation";
            this.TopMost = true;
            this.navBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button productcategoryButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel navBarPanel;
        private System.Windows.Forms.Panel contentPanel;
    }
}