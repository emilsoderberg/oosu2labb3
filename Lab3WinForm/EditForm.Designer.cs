namespace Lab3WinForm
{
    partial class EditForm
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
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.SuperNameLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.SuperName = new System.Windows.Forms.TextBox();
            this.RealName = new System.Windows.Forms.TextBox();
            this.AbilitiesList = new System.Windows.Forms.CheckedListBox();
            this.AbilityListView = new System.Windows.Forms.ListView();
            this.OriginalName = new System.Windows.Forms.Label();
            this.OriginalSuperName = new System.Windows.Forms.Label();
            this.OriginalCity = new System.Windows.Forms.Label();
            this.OriginalAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(16, 200);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 20);
            this.AgeLabel.TabIndex = 17;
            this.AgeLabel.Text = "Age";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(16, 140);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 16;
            this.CityLabel.Text = "City";
            // 
            // SuperNameLabel
            // 
            this.SuperNameLabel.AutoSize = true;
            this.SuperNameLabel.Location = new System.Drawing.Point(12, 84);
            this.SuperNameLabel.Name = "SuperNameLabel";
            this.SuperNameLabel.Size = new System.Drawing.Size(94, 20);
            this.SuperNameLabel.TabIndex = 15;
            this.SuperNameLabel.Text = "SuperName";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 23);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 14;
            this.Name.Text = "Name";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(16, 230);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 26);
            this.Age.TabIndex = 13;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(16, 167);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 26);
            this.City.TabIndex = 12;
            // 
            // SuperName
            // 
            this.SuperName.Location = new System.Drawing.Point(16, 107);
            this.SuperName.Name = "SuperName";
            this.SuperName.Size = new System.Drawing.Size(100, 26);
            this.SuperName.TabIndex = 11;
            // 
            // RealName
            // 
            this.RealName.Location = new System.Drawing.Point(16, 53);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(100, 26);
            this.RealName.TabIndex = 10;
            this.RealName.TextChanged += new System.EventHandler(this.RealName_TextChanged);
            // 
            // AbilitiesList
            // 
            this.AbilitiesList.FormattingEnabled = true;
            this.AbilitiesList.Location = new System.Drawing.Point(490, 53);
            this.AbilitiesList.Name = "AbilitiesList";
            this.AbilitiesList.Size = new System.Drawing.Size(218, 151);
            this.AbilitiesList.TabIndex = 9;
            // 
            // AbilityListView
            // 
            this.AbilityListView.Location = new System.Drawing.Point(490, 314);
            this.AbilityListView.Name = "AbilityListView";
            this.AbilityListView.Size = new System.Drawing.Size(218, 97);
            this.AbilityListView.TabIndex = 18;
            this.AbilityListView.UseCompatibleStateImageBehavior = false;
            // 
            // OriginalName
            // 
            this.OriginalName.AutoSize = true;
            this.OriginalName.Location = new System.Drawing.Point(269, 314);
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.Size = new System.Drawing.Size(51, 20);
            this.OriginalName.TabIndex = 19;
            this.OriginalName.Text = "label1";
            // 
            // OriginalSuperName
            // 
            this.OriginalSuperName.AutoSize = true;
            this.OriginalSuperName.Location = new System.Drawing.Point(269, 361);
            this.OriginalSuperName.Name = "OriginalSuperName";
            this.OriginalSuperName.Size = new System.Drawing.Size(51, 20);
            this.OriginalSuperName.TabIndex = 20;
            this.OriginalSuperName.Text = "label2";
            // 
            // OriginalCity
            // 
            this.OriginalCity.AutoSize = true;
            this.OriginalCity.Location = new System.Drawing.Point(378, 314);
            this.OriginalCity.Name = "OriginalCity";
            this.OriginalCity.Size = new System.Drawing.Size(51, 20);
            this.OriginalCity.TabIndex = 21;
            this.OriginalCity.Text = "label3";
            // 
            // OriginalAge
            // 
            this.OriginalAge.AutoSize = true;
            this.OriginalAge.Location = new System.Drawing.Point(378, 361);
            this.OriginalAge.Name = "OriginalAge";
            this.OriginalAge.Size = new System.Drawing.Size(51, 20);
            this.OriginalAge.TabIndex = 22;
            this.OriginalAge.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Original Stats:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(182, 394);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(179, 44);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 394);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(165, 44);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OriginalAge);
            this.Controls.Add(this.OriginalCity);
            this.Controls.Add(this.OriginalSuperName);
            this.Controls.Add(this.OriginalName);
            this.Controls.Add(this.AbilityListView);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.SuperNameLabel);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.City);
            this.Controls.Add(this.SuperName);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.AbilitiesList);
            this.Name.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label SuperNameLabel;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox SuperName;
        private System.Windows.Forms.TextBox RealName;
        private System.Windows.Forms.CheckedListBox AbilitiesList;
        private System.Windows.Forms.ListView AbilityListView;
        private System.Windows.Forms.Label OriginalName;
        private System.Windows.Forms.Label OriginalSuperName;
        private System.Windows.Forms.Label OriginalCity;
        private System.Windows.Forms.Label OriginalAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
    }
}