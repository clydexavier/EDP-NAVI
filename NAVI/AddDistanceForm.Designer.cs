namespace NAVI
{
    partial class AddDistanceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.LabelCampusLocation1 = new System.Windows.Forms.Label();
            this.LabelCampusLocation2 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.NUDWholeNumber = new System.Windows.Forms.NumericUpDown();
            this.NUDDecimal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDWholeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campus Location 1: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campus Location 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance (m): ";
            // 
            // LabelCampusLocation1
            // 
            this.LabelCampusLocation1.AutoSize = true;
            this.LabelCampusLocation1.Location = new System.Drawing.Point(189, 45);
            this.LabelCampusLocation1.Name = "LabelCampusLocation1";
            this.LabelCampusLocation1.Size = new System.Drawing.Size(38, 15);
            this.LabelCampusLocation1.TabIndex = 3;
            this.LabelCampusLocation1.Text = "label4";
            // 
            // LabelCampusLocation2
            // 
            this.LabelCampusLocation2.AutoSize = true;
            this.LabelCampusLocation2.Location = new System.Drawing.Point(189, 80);
            this.LabelCampusLocation2.Name = "LabelCampusLocation2";
            this.LabelCampusLocation2.Size = new System.Drawing.Size(38, 15);
            this.LabelCampusLocation2.TabIndex = 4;
            this.LabelCampusLocation2.Text = "label5";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(42, 162);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(301, 23);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.VisibleChanged += new System.EventHandler(this.ButtonSubmit_VisibleChanged);
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // NUDWholeNumber
            // 
            this.NUDWholeNumber.Location = new System.Drawing.Point(189, 110);
            this.NUDWholeNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUDWholeNumber.Name = "NUDWholeNumber";
            this.NUDWholeNumber.Size = new System.Drawing.Size(66, 23);
            this.NUDWholeNumber.TabIndex = 7;
            // 
            // NUDDecimal
            // 
            this.NUDDecimal.Location = new System.Drawing.Point(277, 110);
            this.NUDDecimal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUDDecimal.Name = "NUDDecimal";
            this.NUDDecimal.Size = new System.Drawing.Size(66, 23);
            this.NUDDecimal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = ".";
            // 
            // AddDistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUDDecimal);
            this.Controls.Add(this.NUDWholeNumber);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.LabelCampusLocation2);
            this.Controls.Add(this.LabelCampusLocation1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDistanceForm";
            this.Text = "AddDistanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.NUDWholeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label LabelCampusLocation1;
        private Label LabelCampusLocation2;
        private Button ButtonSubmit;
        private NumericUpDown NUDWholeNumber;
        private NumericUpDown NUDDecimal;
        private Label label4;
    }
}