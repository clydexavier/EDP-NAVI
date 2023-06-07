namespace NAVI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buildingFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sabeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naviDataToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campusLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSItemCampusLocationAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MSItemCampusLocationConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MSItemCampusLocationClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListBoxBuildingFloors = new System.Windows.Forms.ListBox();
            this.TabBuildingFloor = new System.Windows.Forms.TabPage();
            this.PanelMap = new System.Windows.Forms.Panel();
            this.PictureBoxBldgImage = new System.Windows.Forms.PictureBox();
            this.PanelListBox = new System.Windows.Forms.Panel();
            this.ListBoxCampusLocations = new System.Windows.Forms.ListBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabBuildingFloor.SuspendLayout();
            this.PanelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBldgImage)).BeginInit();
            this.PanelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingFloorToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.campusLocationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buildingFloorToolStripMenuItem
            // 
            this.buildingFloorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.sabeToolStripMenuItem,
            this.openToolStripMenuItem});
            this.buildingFloorToolStripMenuItem.Name = "buildingFloorToolStripMenuItem";
            this.buildingFloorToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.buildingFloorToolStripMenuItem.Text = "Building Floor";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // sabeToolStripMenuItem
            // 
            this.sabeToolStripMenuItem.Name = "sabeToolStripMenuItem";
            this.sabeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sabeToolStripMenuItem.Text = "Save";
            this.sabeToolStripMenuItem.Click += new System.EventHandler(this.sabeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naviDataToolToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // naviDataToolToolStripMenuItem
            // 
            this.naviDataToolToolStripMenuItem.Name = "naviDataToolToolStripMenuItem";
            this.naviDataToolToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.naviDataToolToolStripMenuItem.Text = "Navi Data Tool";
            // 
            // campusLocationToolStripMenuItem
            // 
            this.campusLocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSItemCampusLocationAdd,
            this.MSItemCampusLocationConnect,
            this.MSItemCampusLocationClear});
            this.campusLocationToolStripMenuItem.Name = "campusLocationToolStripMenuItem";
            this.campusLocationToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.campusLocationToolStripMenuItem.Text = "Campus Location";
            // 
            // MSItemCampusLocationAdd
            // 
            this.MSItemCampusLocationAdd.Name = "MSItemCampusLocationAdd";
            this.MSItemCampusLocationAdd.Size = new System.Drawing.Size(152, 22);
            this.MSItemCampusLocationAdd.Text = "Add";
            this.MSItemCampusLocationAdd.Click += new System.EventHandler(this.MSItemCampusLocationAdd_Click);
            // 
            // MSItemCampusLocationConnect
            // 
            this.MSItemCampusLocationConnect.Name = "MSItemCampusLocationConnect";
            this.MSItemCampusLocationConnect.Size = new System.Drawing.Size(152, 22);
            this.MSItemCampusLocationConnect.Text = "Connect";
            this.MSItemCampusLocationConnect.Click += new System.EventHandler(this.MSItemCampusLocationConnect_Click);
            // 
            // MSItemCampusLocationClear
            // 
            this.MSItemCampusLocationClear.Name = "MSItemCampusLocationClear";
            this.MSItemCampusLocationClear.Size = new System.Drawing.Size(152, 22);
            this.MSItemCampusLocationClear.Text = "Clear Selection";
            this.MSItemCampusLocationClear.Click += new System.EventHandler(this.MSItemCampusLocationClear_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.TabBuildingFloor);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 426);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListBoxBuildingFloors);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Building Floors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListBoxBuildingFloors
            // 
            this.ListBoxBuildingFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxBuildingFloors.FormattingEnabled = true;
            this.ListBoxBuildingFloors.ItemHeight = 15;
            this.ListBoxBuildingFloors.Location = new System.Drawing.Point(3, 3);
            this.ListBoxBuildingFloors.Name = "ListBoxBuildingFloors";
            this.ListBoxBuildingFloors.Size = new System.Drawing.Size(786, 392);
            this.ListBoxBuildingFloors.TabIndex = 0;
            this.ListBoxBuildingFloors.DoubleClick += new System.EventHandler(this.ListBoxBuildingFloors_DoubleClick);
            // 
            // TabBuildingFloor
            // 
            this.TabBuildingFloor.Controls.Add(this.PanelMap);
            this.TabBuildingFloor.Controls.Add(this.PanelListBox);
            this.TabBuildingFloor.Location = new System.Drawing.Point(4, 24);
            this.TabBuildingFloor.Name = "TabBuildingFloor";
            this.TabBuildingFloor.Padding = new System.Windows.Forms.Padding(3);
            this.TabBuildingFloor.Size = new System.Drawing.Size(792, 398);
            this.TabBuildingFloor.TabIndex = 1;
            this.TabBuildingFloor.Text = "Building Floor";
            this.TabBuildingFloor.UseVisualStyleBackColor = true;
            // 
            // PanelMap
            // 
            this.PanelMap.AutoScroll = true;
            this.PanelMap.Controls.Add(this.PictureBoxBldgImage);
            this.PanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMap.Location = new System.Drawing.Point(3, 3);
            this.PanelMap.Name = "PanelMap";
            this.PanelMap.Size = new System.Drawing.Size(618, 392);
            this.PanelMap.TabIndex = 1;
            // 
            // PictureBoxBldgImage
            // 
            this.PictureBoxBldgImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxBldgImage.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBldgImage.Name = "PictureBoxBldgImage";
            this.PictureBoxBldgImage.Size = new System.Drawing.Size(618, 392);
            this.PictureBoxBldgImage.TabIndex = 0;
            this.PictureBoxBldgImage.TabStop = false;
            this.PictureBoxBldgImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxBldgImage_Paint);
            this.PictureBoxBldgImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxBldgImage_MouseClick);
            // 
            // PanelListBox
            // 
            this.PanelListBox.Controls.Add(this.ListBoxCampusLocations);
            this.PanelListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelListBox.Location = new System.Drawing.Point(621, 3);
            this.PanelListBox.Name = "PanelListBox";
            this.PanelListBox.Size = new System.Drawing.Size(168, 392);
            this.PanelListBox.TabIndex = 0;
            // 
            // ListBoxCampusLocations
            // 
            this.ListBoxCampusLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxCampusLocations.FormattingEnabled = true;
            this.ListBoxCampusLocations.ItemHeight = 15;
            this.ListBoxCampusLocations.Location = new System.Drawing.Point(0, 0);
            this.ListBoxCampusLocations.Name = "ListBoxCampusLocations";
            this.ListBoxCampusLocations.Size = new System.Drawing.Size(168, 392);
            this.ListBoxCampusLocations.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabBuildingFloor.ResumeLayout(false);
            this.PanelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBldgImage)).EndInit();
            this.PanelListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem buildingFloorToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem naviDataToolToolStripMenuItem;
        private TabControl TabControl;
        private TabPage tabPage1;
        private TabPage TabBuildingFloor;
        private ListBox ListBoxBuildingFloors;
        private OpenFileDialog ofd;
        private Panel PanelMap;
        private PictureBox PictureBoxBldgImage;
        private Panel PanelListBox;
        private ToolStripMenuItem campusLocationToolStripMenuItem;
        private ToolStripMenuItem MSItemCampusLocationAdd;
        private ListBox ListBoxCampusLocations;
        private ToolStripMenuItem MSItemCampusLocationConnect;
        private ToolStripMenuItem MSItemCampusLocationClear;
        private ToolStripMenuItem sabeToolStripMenuItem;
        private SaveFileDialog sfd;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}