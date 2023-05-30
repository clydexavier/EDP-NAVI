namespace NAVI
{
    partial class AddCampusLocation
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
            this.LabelCampusLocationName = new System.Windows.Forms.Label();
            this.TextBoxLocationName = new System.Windows.Forms.TextBox();
            this.LabelCampusLocationDisplayName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelIsMain = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxDisplay = new System.Windows.Forms.TextBox();
            this.ComboBoxLocationType = new System.Windows.Forms.ComboBox();
            this.LabelLocationValue = new System.Windows.Forms.Label();
            this.ButtonCampusLocationSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCampusLocationName
            // 
            this.LabelCampusLocationName.AutoSize = true;
            this.LabelCampusLocationName.Location = new System.Drawing.Point(30, 47);
            this.LabelCampusLocationName.Name = "LabelCampusLocationName";
            this.LabelCampusLocationName.Size = new System.Drawing.Size(141, 15);
            this.LabelCampusLocationName.TabIndex = 0;
            this.LabelCampusLocationName.Text = "Campus Location Name: ";
            // 
            // TextBoxLocationName
            // 
            this.TextBoxLocationName.Location = new System.Drawing.Point(177, 44);
            this.TextBoxLocationName.Name = "TextBoxLocationName";
            this.TextBoxLocationName.Size = new System.Drawing.Size(256, 23);
            this.TextBoxLocationName.TabIndex = 1;
            // 
            // LabelCampusLocationDisplayName
            // 
            this.LabelCampusLocationDisplayName.AutoSize = true;
            this.LabelCampusLocationDisplayName.Location = new System.Drawing.Point(30, 86);
            this.LabelCampusLocationDisplayName.Name = "LabelCampusLocationDisplayName";
            this.LabelCampusLocationDisplayName.Size = new System.Drawing.Size(86, 15);
            this.LabelCampusLocationDisplayName.TabIndex = 2;
            this.LabelCampusLocationDisplayName.Text = "Display Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // LabelIsMain
            // 
            this.LabelIsMain.AutoSize = true;
            this.LabelIsMain.Location = new System.Drawing.Point(30, 125);
            this.LabelIsMain.Name = "LabelIsMain";
            this.LabelIsMain.Size = new System.Drawing.Size(86, 15);
            this.LabelIsMain.TabIndex = 4;
            this.LabelIsMain.Text = "Location Type: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location: ";
            // 
            // TextBoxDisplay
            // 
            this.TextBoxDisplay.Location = new System.Drawing.Point(177, 78);
            this.TextBoxDisplay.Name = "TextBoxDisplay";
            this.TextBoxDisplay.Size = new System.Drawing.Size(256, 23);
            this.TextBoxDisplay.TabIndex = 6;
            // 
            // ComboBoxLocationType
            // 
            this.ComboBoxLocationType.FormattingEnabled = true;
            this.ComboBoxLocationType.Items.AddRange(new object[] {
            "Main Location",
            "Sub Location"});
            this.ComboBoxLocationType.Location = new System.Drawing.Point(177, 122);
            this.ComboBoxLocationType.Name = "ComboBoxLocationType";
            this.ComboBoxLocationType.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxLocationType.TabIndex = 7;
            // 
            // LabelLocationValue
            // 
            this.LabelLocationValue.AutoSize = true;
            this.LabelLocationValue.Location = new System.Drawing.Point(177, 172);
            this.LabelLocationValue.Name = "LabelLocationValue";
            this.LabelLocationValue.Size = new System.Drawing.Size(33, 15);
            this.LabelLocationValue.TabIndex = 8;
            this.LabelLocationValue.Text = "(0, 0)";
            // 
            // ButtonCampusLocationSubmit
            // 
            this.ButtonCampusLocationSubmit.Location = new System.Drawing.Point(30, 234);
            this.ButtonCampusLocationSubmit.Name = "ButtonCampusLocationSubmit";
            this.ButtonCampusLocationSubmit.Size = new System.Drawing.Size(403, 23);
            this.ButtonCampusLocationSubmit.TabIndex = 9;
            this.ButtonCampusLocationSubmit.Text = "Submit";
            this.ButtonCampusLocationSubmit.UseVisualStyleBackColor = true;
            this.ButtonCampusLocationSubmit.Click += new System.EventHandler(this.ButtonCampusLocationSubmit_Click);
            // 
            // AddCampusLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 286);
            this.Controls.Add(this.ButtonCampusLocationSubmit);
            this.Controls.Add(this.LabelLocationValue);
            this.Controls.Add(this.ComboBoxLocationType);
            this.Controls.Add(this.TextBoxDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelIsMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelCampusLocationDisplayName);
            this.Controls.Add(this.TextBoxLocationName);
            this.Controls.Add(this.LabelCampusLocationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCampusLocation";
            this.Text = "AddCampusLocation";
            this.VisibleChanged += new System.EventHandler(this.AddCampusLocation_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelCampusLocationName;
        private TextBox TextBoxLocationName;
        private Label LabelCampusLocationDisplayName;
        private Label label3;
        private Label LabelIsMain;
        private Label label5;
        private TextBox TextBoxDisplay;
        private ComboBox ComboBoxLocationType;
        private Label LabelLocationValue;
        private Button ButtonCampusLocationSubmit;
    }
}