namespace NAVI
{
    partial class AddBuildingFloor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxBldgFlrName = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RichTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxTags = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBrowseImage = new System.Windows.Forms.Button();
            this.LabelImageStatus = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Floor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // TextBoxBldgFlrName
            // 
            this.TextBoxBldgFlrName.Location = new System.Drawing.Point(172, 27);
            this.TextBoxBldgFlrName.Name = "TextBoxBldgFlrName";
            this.TextBoxBldgFlrName.Size = new System.Drawing.Size(263, 23);
            this.TextBoxBldgFlrName.TabIndex = 2;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(172, 68);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(263, 23);
            this.TextBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credits";
            // 
            // RichTextBoxCredits
            // 
            this.RichTextBoxCredits.Location = new System.Drawing.Point(31, 189);
            this.RichTextBoxCredits.Name = "RichTextBoxCredits";
            this.RichTextBoxCredits.Size = new System.Drawing.Size(411, 117);
            this.RichTextBoxCredits.TabIndex = 5;
            this.RichTextBoxCredits.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tags (separate by comma)";
            // 
            // TextBoxTags
            // 
            this.TextBoxTags.Location = new System.Drawing.Point(31, 355);
            this.TextBoxTags.Name = "TextBoxTags";
            this.TextBoxTags.Size = new System.Drawing.Size(410, 23);
            this.TextBoxTags.TabIndex = 7;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(31, 401);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(411, 23);
            this.ButtonSubmit.TabIndex = 8;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Image:";
            // 
            // ButtonBrowseImage
            // 
            this.ButtonBrowseImage.Location = new System.Drawing.Point(172, 109);
            this.ButtonBrowseImage.Name = "ButtonBrowseImage";
            this.ButtonBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseImage.TabIndex = 10;
            this.ButtonBrowseImage.Text = "Browse...";
            this.ButtonBrowseImage.UseVisualStyleBackColor = true;
            this.ButtonBrowseImage.Click += new System.EventHandler(this.ButtonBrowseImage_Click);
            // 
            // LabelImageStatus
            // 
            this.LabelImageStatus.AutoSize = true;
            this.LabelImageStatus.Location = new System.Drawing.Point(253, 113);
            this.LabelImageStatus.Name = "LabelImageStatus";
            this.LabelImageStatus.Size = new System.Drawing.Size(59, 15);
            this.LabelImageStatus.TabIndex = 11;
            this.LabelImageStatus.Text = "No Image";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // AddBuildingFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 446);
            this.Controls.Add(this.LabelImageStatus);
            this.Controls.Add(this.ButtonBrowseImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextBoxTags);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RichTextBoxCredits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxBldgFlrName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBuildingFloor";
            this.Text = "AddBuildingFloor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxBldgFlrName;
        private TextBox TextBoxDescription;
        private Label label3;
        private RichTextBox RichTextBoxCredits;
        private Label label4;
        private TextBox TextBoxTags;
        private Button ButtonSubmit;
        private Label label5;
        private Button ButtonBrowseImage;
        private Label LabelImageStatus;
        private OpenFileDialog ofd;
    }
}