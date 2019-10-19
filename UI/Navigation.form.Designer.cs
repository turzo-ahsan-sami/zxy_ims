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
            this.navFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.productcategoryButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.navFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navFlowLayoutPanel
            // 
            this.navFlowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.navFlowLayoutPanel.Controls.Add(this.homeButton);
            this.navFlowLayoutPanel.Controls.Add(this.productcategoryButton);
            this.navFlowLayoutPanel.Controls.Add(this.productButton);
            this.navFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.navFlowLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.navFlowLayoutPanel.Name = "navFlowLayoutPanel";
            this.navFlowLayoutPanel.Size = new System.Drawing.Size(82, 641);
            this.navFlowLayoutPanel.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // productcategoryButton
            // 
            this.productcategoryButton.Location = new System.Drawing.Point(3, 32);
            this.productcategoryButton.Name = "productcategoryButton";
            this.productcategoryButton.Size = new System.Drawing.Size(75, 23);
            this.productcategoryButton.TabIndex = 0;
            this.productcategoryButton.Text = "Category";
            this.productcategoryButton.UseVisualStyleBackColor = true;
            this.productcategoryButton.Click += new System.EventHandler(this.productcategoryButton_Click);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(3, 61);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(75, 23);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.navFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Navigation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation";
            this.TopMost = true;
            this.navFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel navFlowLayoutPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button productcategoryButton;
        private System.Windows.Forms.Button productButton;
    }
}