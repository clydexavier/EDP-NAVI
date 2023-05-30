using NAVI.Classes;

namespace NAVI
{
    public partial class MainForm : Form
    {
        public static AddBuildingFloor abf = new AddBuildingFloor();
        public static AddCampusLocation acl = new AddCampusLocation();

        public List<BuildingFloor> BuildingFloors;
        private BuildingFloor FocusBuildingFloor;

        public List<SelectableCampusLocation> PictureBoxesCampusLocations;

        public MainForm()
        {
            InitializeComponent();
            this.BuildingFloors = new List<BuildingFloor>();
            this.PictureBoxesCampusLocations = new List<SelectableCampusLocation>();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(abf.ShowDialog() == DialogResult.OK) 
            {
                this.BuildingFloors.Add(abf.BuildingFloor);
                abf.Clear();

                ListBoxBuildingFloors.Items.Clear();
                foreach(BuildingFloor bf in BuildingFloors) ListBoxBuildingFloors.Items.Add(bf);
            }
        }

        private void ListBoxBuildingFloors_DoubleClick(object sender, EventArgs e)
        {

            if (ListBoxBuildingFloors.SelectedItem != null)
            {
                TabControl.TabPages[1].Text = (((BuildingFloor)ListBoxBuildingFloors.SelectedItem).Name);

                this.FocusBuildingFloor = ((BuildingFloor)ListBoxBuildingFloors.SelectedItem);


                PictureBoxBldgImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxBldgImage.Image = ((BuildingFloor)ListBoxBuildingFloors.SelectedItem).BuildingImage;
            }
        }

        private void MSItemCampusLocationAdd_Click(object sender, EventArgs e)
        {
            this.MSItemCampusLocationAdd.Checked = !this.MSItemCampusLocationAdd.Checked;
        }

        private void PictureBoxBldgImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (!MSItemCampusLocationAdd.Checked) return;

            float scale = PictureBoxBldgImage.Width * 0.025f / 2;
            PointF corrected = new PointF(e.Location.X - scale, e.Location.Y - scale);
            acl.PointLocation = corrected;

            if(acl.ShowDialog() == DialogResult.OK)
            {
                this.FocusBuildingFloor.CampusLocations.Add(acl.CampusLocation);
                SelectableCampusLocation scl = new SelectableCampusLocation(acl.CampusLocation);
                this.PictureBoxesCampusLocations.Add(scl);
                acl.Clear();

                ListBoxCampusLocations.Items.Clear();
                foreach(CampusLocation cl in this.FocusBuildingFloor.CampusLocations) ListBoxCampusLocations.Items.Add(cl);

                this.UpdateBuildingFloor();

            }
        }

        private void UpdateBuildingFloor()
        {
            int scale = (int)(PictureBoxBldgImage.Width * 0.025f / 2);
            PictureBoxBldgImage.Controls.Clear();

            foreach (SelectableCampusLocation scl in PictureBoxesCampusLocations)
            {
                scl.Size = new Size(scale, scale);
                PictureBoxBldgImage.Controls.Add(scl);
            }

        }
    }
}