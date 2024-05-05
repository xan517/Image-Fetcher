
namespace Image_Fetcher
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
            this.alchemyPathButton = new System.Windows.Forms.Button();
            this.alchemyBox = new System.Windows.Forms.TextBox();
            this.scrapeBox = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cookingBox = new System.Windows.Forms.TextBox();
            this.cookingPathButton = new System.Windows.Forms.Button();
            this.guildBox = new System.Windows.Forms.TextBox();
            this.processingBox = new System.Windows.Forms.TextBox();
            this.workloadBox = new System.Windows.Forms.TextBox();
            this.guildPathButton = new System.Windows.Forms.Button();
            this.processingButton = new System.Windows.Forms.Button();
            this.workloadPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alchemyPathButton
            // 
            this.alchemyPathButton.Location = new System.Drawing.Point(349, 12);
            this.alchemyPathButton.Name = "alchemyPathButton";
            this.alchemyPathButton.Size = new System.Drawing.Size(75, 23);
            this.alchemyPathButton.TabIndex = 0;
            this.alchemyPathButton.Text = "Alchemy";
            this.alchemyPathButton.UseVisualStyleBackColor = true;
            this.alchemyPathButton.Click += new System.EventHandler(this.alchemyPathButton_Click);
            // 
            // alchemyBox
            // 
            this.alchemyBox.Location = new System.Drawing.Point(12, 12);
            this.alchemyBox.Name = "alchemyBox";
            this.alchemyBox.Size = new System.Drawing.Size(331, 20);
            this.alchemyBox.TabIndex = 1;
            this.alchemyBox.Text = "Path";
            this.alchemyBox.TextChanged += new System.EventHandler(this.alchemyBox_TextChanged);
            // 
            // scrapeBox
            // 
            this.scrapeBox.Location = new System.Drawing.Point(713, 193);
            this.scrapeBox.Name = "scrapeBox";
            this.scrapeBox.Size = new System.Drawing.Size(75, 23);
            this.scrapeBox.TabIndex = 2;
            this.scrapeBox.Text = "Scrape";
            this.scrapeBox.UseVisualStyleBackColor = true;
            this.scrapeBox.Click += new System.EventHandler(this.scrapeBox_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 164);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // cookingBox
            // 
            this.cookingBox.Location = new System.Drawing.Point(12, 38);
            this.cookingBox.Name = "cookingBox";
            this.cookingBox.Size = new System.Drawing.Size(331, 20);
            this.cookingBox.TabIndex = 4;
            this.cookingBox.Text = "Path";
            this.cookingBox.TextChanged += new System.EventHandler(this.cookingBox_TextChanged);
            // 
            // cookingPathButton
            // 
            this.cookingPathButton.Location = new System.Drawing.Point(349, 36);
            this.cookingPathButton.Name = "cookingPathButton";
            this.cookingPathButton.Size = new System.Drawing.Size(75, 23);
            this.cookingPathButton.TabIndex = 5;
            this.cookingPathButton.Text = "Cooking";
            this.cookingPathButton.UseVisualStyleBackColor = true;
            this.cookingPathButton.Click += new System.EventHandler(this.cookingPathButton_Click);
            // 
            // guildBox
            // 
            this.guildBox.Location = new System.Drawing.Point(12, 64);
            this.guildBox.Name = "guildBox";
            this.guildBox.Size = new System.Drawing.Size(331, 20);
            this.guildBox.TabIndex = 6;
            this.guildBox.Text = "Path";
            this.guildBox.TextChanged += new System.EventHandler(this.guildBox_TextChanged);
            // 
            // processingBox
            // 
            this.processingBox.Location = new System.Drawing.Point(12, 90);
            this.processingBox.Name = "processingBox";
            this.processingBox.Size = new System.Drawing.Size(331, 20);
            this.processingBox.TabIndex = 7;
            this.processingBox.Text = "Path";
            this.processingBox.TextChanged += new System.EventHandler(this.processingBox_TextChanged);
            // 
            // workloadBox
            // 
            this.workloadBox.Location = new System.Drawing.Point(12, 116);
            this.workloadBox.Name = "workloadBox";
            this.workloadBox.Size = new System.Drawing.Size(331, 20);
            this.workloadBox.TabIndex = 8;
            this.workloadBox.Text = "Path";
            this.workloadBox.TextChanged += new System.EventHandler(this.workloadBox_TextChanged);
            // 
            // guildPathButton
            // 
            this.guildPathButton.Location = new System.Drawing.Point(349, 61);
            this.guildPathButton.Name = "guildPathButton";
            this.guildPathButton.Size = new System.Drawing.Size(75, 23);
            this.guildPathButton.TabIndex = 9;
            this.guildPathButton.Text = "Guild";
            this.guildPathButton.UseVisualStyleBackColor = true;
            this.guildPathButton.Click += new System.EventHandler(this.guildPathButton_Click);
            // 
            // processingButton
            // 
            this.processingButton.Location = new System.Drawing.Point(349, 87);
            this.processingButton.Name = "processingButton";
            this.processingButton.Size = new System.Drawing.Size(75, 23);
            this.processingButton.TabIndex = 10;
            this.processingButton.Text = "Processing";
            this.processingButton.UseVisualStyleBackColor = true;
            this.processingButton.Click += new System.EventHandler(this.processingButton_Click);
            // 
            // workloadPathButton
            // 
            this.workloadPathButton.Location = new System.Drawing.Point(349, 113);
            this.workloadPathButton.Name = "workloadPathButton";
            this.workloadPathButton.Size = new System.Drawing.Size(75, 23);
            this.workloadPathButton.TabIndex = 11;
            this.workloadPathButton.Text = "Workload";
            this.workloadPathButton.UseVisualStyleBackColor = true;
            this.workloadPathButton.Click += new System.EventHandler(this.workloadPathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 228);
            this.Controls.Add(this.workloadPathButton);
            this.Controls.Add(this.processingButton);
            this.Controls.Add(this.guildPathButton);
            this.Controls.Add(this.workloadBox);
            this.Controls.Add(this.processingBox);
            this.Controls.Add(this.guildBox);
            this.Controls.Add(this.cookingPathButton);
            this.Controls.Add(this.cookingBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.scrapeBox);
            this.Controls.Add(this.alchemyBox);
            this.Controls.Add(this.alchemyPathButton);
            this.Name = "Form1";
            this.Text = "Image Fetcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alchemyPathButton;
        private System.Windows.Forms.TextBox alchemyBox;
        private System.Windows.Forms.Button scrapeBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox cookingBox;
        private System.Windows.Forms.Button cookingPathButton;
        private System.Windows.Forms.TextBox guildBox;
        private System.Windows.Forms.TextBox processingBox;
        private System.Windows.Forms.TextBox workloadBox;
        private System.Windows.Forms.Button guildPathButton;
        private System.Windows.Forms.Button processingButton;
        private System.Windows.Forms.Button workloadPathButton;
    }
}

