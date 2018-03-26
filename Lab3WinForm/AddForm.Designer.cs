namespace Lab3WinForm
{
    partial class AddForm
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
            this.AbilitiesList = new System.Windows.Forms.CheckedListBox();
            this.RealName = new System.Windows.Forms.TextBox();
            this.SuperName = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.SuperNameLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbilitiesList
            // 
            this.AbilitiesList.FormattingEnabled = true;
            this.AbilitiesList.Location = new System.Drawing.Point(514, 39);
            this.AbilitiesList.Name = "AbilitiesList";
            this.AbilitiesList.Size = new System.Drawing.Size(218, 151);
            this.AbilitiesList.TabIndex = 0;
            this.AbilitiesList.SelectedIndexChanged += new System.EventHandler(this.AbilitiesList_SelectedIndexChanged);
            // 
            // RealName
            // 
            this.RealName.Location = new System.Drawing.Point(40, 39);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(100, 26);
            this.RealName.TabIndex = 1;
            this.RealName.TextChanged += new System.EventHandler(this.RealName_TextChanged);
            // 
            // SuperName
            // 
            this.SuperName.Location = new System.Drawing.Point(40, 93);
            this.SuperName.Name = "SuperName";
            this.SuperName.Size = new System.Drawing.Size(100, 26);
            this.SuperName.TabIndex = 2;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(40, 153);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 26);
            this.City.TabIndex = 3;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(40, 216);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 26);
            this.Age.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(36, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // SuperNameLabel
            // 
            this.SuperNameLabel.AutoSize = true;
            this.SuperNameLabel.Location = new System.Drawing.Point(36, 70);
            this.SuperNameLabel.Name = "SuperNameLabel";
            this.SuperNameLabel.Size = new System.Drawing.Size(94, 20);
            this.SuperNameLabel.TabIndex = 6;
            this.SuperNameLabel.Text = "SuperName";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(40, 126);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 7;
            this.CityLabel.Text = "City";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(40, 186);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Age";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(40, 394);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 44);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(211, 394);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(179, 44);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.SuperNameLabel);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.City);
            this.Controls.Add(this.SuperName);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.AbilitiesList);
            this.Name.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AbilitiesList;
        private System.Windows.Forms.TextBox RealName;
        private System.Windows.Forms.TextBox SuperName;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label SuperNameLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}