namespace NameFormatter
{
    partial class NameFormatterForm
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
            preferredTitle = new ComboBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            programName_label = new Label();
            submitBtn = new Button();
            lstResults = new ListBox();
            formattedNames = new Label();
            SuspendLayout();
            // 
            // preferredTitle
            // 
            preferredTitle.FormattingEnabled = true;
            preferredTitle.Items.AddRange(new object[] { "Mr.", "Mrs.", "Ms.", "Dr.", "Jr." });
            preferredTitle.Location = new Point(12, 81);
            preferredTitle.Name = "preferredTitle";
            preferredTitle.Size = new Size(109, 23);
            preferredTitle.TabIndex = 0;
            preferredTitle.Text = "Preferred Title";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 124);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(289, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(12, 173);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtMiddleName.Size = new Size(289, 23);
            txtMiddleName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 219);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(289, 23);
            txtLastName.TabIndex = 3;
            // 
            // programName_label
            // 
            programName_label.AutoSize = true;
            programName_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            programName_label.Location = new Point(12, 31);
            programName_label.Name = "programName_label";
            programName_label.Size = new Size(158, 25);
            programName_label.TabIndex = 4;
            programName_label.Text = "Name Formatter";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.Highlight;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.ForeColor = SystemColors.ControlLightLight;
            submitBtn.Location = new Point(14, 258);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 30);
            submitBtn.TabIndex = 5;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // lstResults
            // 
            lstResults.BorderStyle = BorderStyle.None;
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(18, 336);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(283, 120);
            lstResults.TabIndex = 6;
            lstResults.Visible = false;
            // 
            // formattedNames
            // 
            formattedNames.AutoSize = true;
            formattedNames.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            formattedNames.Location = new Point(14, 304);
            formattedNames.Name = "formattedNames";
            formattedNames.Size = new Size(110, 15);
            formattedNames.TabIndex = 7;
            formattedNames.Text = "Formatted Names:";
            // 
            // NameFormatterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 506);
            Controls.Add(formattedNames);
            Controls.Add(lstResults);
            Controls.Add(submitBtn);
            Controls.Add(programName_label);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(preferredTitle);
            Name = "NameFormatterForm";
            Text = "Name Formatter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox preferredTitle;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private Label programName_label;
        private Button submitBtn;
        private ListBox lstResults;
        private Label formattedNames;
    }
}
