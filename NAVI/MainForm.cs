using NAVI.Classes;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAVI
{
    public partial class MainForm : Form
    {
        public static AddBuildingFloor abf = new AddBuildingFloor();
        public static AddCampusLocation acl = new AddCampusLocation();
        public static AddDistanceForm adf = new AddDistanceForm();

        public List<BuildingFloor> BuildingFloors;
        private BuildingFloor FocusBuildingFloor;

        public List<SelectableCampusLocation> PictureBoxesCampusLocations;
        public List<Label> LabelCampusLocations;
        public List<Tuple<PointF, PointF>> Paths;

        public MainForm()
        {
            InitializeComponent();
            this.BuildingFloors = new List<BuildingFloor>();
            this.PictureBoxesCampusLocations = new List<SelectableCampusLocation>();
            this.Paths = new List<Tuple<PointF, PointF>>();
            this.Paths = new List<Tuple<PointF, PointF>>();
            this.LabelCampusLocations = new List<Label>();
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

                
                PictureBoxBldgImage.SizeMode = PictureBoxSizeMode.Normal;
                PictureBoxBldgImage.Image = ((BuildingFloor)ListBoxBuildingFloors.SelectedItem).BuildingImage;
                PictureBoxBldgImage.Width = PictureBoxBldgImage.Image.Width;
                PictureBoxBldgImage.Height = PictureBoxBldgImage.Image.Height;

                PanelMap.AutoScrollMinSize = new Size(PictureBoxBldgImage.Image.Width, PictureBoxBldgImage.Image.Height);


                CLConnector.BldgFlr = this.FocusBuildingFloor;
            }
        }

        private void MSItemCampusLocationAdd_Click(object sender, EventArgs e)
        {
            this.MSItemCampusLocationAdd.Checked = !this.MSItemCampusLocationAdd.Checked;
        }

        private void PictureBoxBldgImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (!MSItemCampusLocationAdd.Checked) return;

            

            //int scale = (int)(PictureBoxBldgImage.Width * 0.025 / 2);
            //PointF corrected = new PointF((float)e.Location.X / PictureBoxBldgImage.Width * this.FocusBuildingFloor.BuildingImage.Width, (float)e.Location.Y / PictureBoxBldgImage.Height * this.FocusBuildingFloor.BuildingImage.Height);

            //oint UILoc = new Point(e.Location.X, e.Location.Y);
            
            acl.PointLocation = e.Location;

            

            if(acl.ShowDialog() == DialogResult.OK)
            {
                this.FocusBuildingFloor.CampusLocations.Add(acl.CampusLocation);
                SelectableCampusLocation scl = new SelectableCampusLocation(acl.CampusLocation, this.FocusBuildingFloor);
                scl.Location = e.Location;
                PanelMap.Controls.Add(scl);

                Label l = new Label();
                l.Text = scl.CampusLocation.DisplayName;
                l.Location = new Point(scl.Location.X + 2, scl.Location.Y);
                this.PictureBoxesCampusLocations.Add(scl);
                this.LabelCampusLocations.Add(l);

                
                acl.Clear();

                //Update list of names of  campus locations
                ListBoxCampusLocations.Items.Clear();
                foreach(CampusLocation cl in this.FocusBuildingFloor.CampusLocations) ListBoxCampusLocations.Items.Add(cl);

                this.Invalidate();
            }
        }

        private void UpdateBuildingFloor()
        {

            //int scale = (int)(PictureBoxBldgImage.Width * 0.015f / 2);
            PictureBoxBldgImage.Controls.Clear();

            for (int i = 0; i < PictureBoxesCampusLocations.Count; i++)
            {
                PictureBoxesCampusLocations[i].Size = new Size(10, 10);
                PanelMap.Controls.Add(PictureBoxesCampusLocations[i]);
                PanelMap.Controls.Add(LabelCampusLocations[i]);
               /* Graphics.FromImage(PictureBoxBldgImage.Image).DrawString(scl.CampusLocation.DisplayName, new Font(this.Font.FontFamily, 20), Brushes.Black, new PointF(scl.Location.X+ 1, scl.Location.Y));*/

            }
            foreach(var x in Paths)
            {
                Pen p = new Pen(Brushes.Blue, 5);
                Graphics.FromImage(PictureBoxBldgImage.Image).DrawLine(p, x.Item1, x.Item2);
            }

            PictureBoxBldgImage.SendToBack();
            PictureBoxBldgImage.Invalidate();
        }

        private void MSItemCampusLocationConnect_Click(object sender, EventArgs e)
        {
            var x = CLConnector.GetCampusLocations();
            if (x != null)
            {
                adf.AdjacencyData = x;
                if(adf.ShowDialog() == DialogResult.OK) 
                {
                    if (!CLConnector.BldgFlr.AdjacencyList.ContainsKey(adf.AdjacencyData.Item1))
                        CLConnector.BldgFlr.AdjacencyList.Add(adf.AdjacencyData.Item1, new List<Tuple<CampusLocation, double>>());
                    if (!CLConnector.BldgFlr.AdjacencyList.ContainsKey(adf.AdjacencyData.Item2))
                        CLConnector.BldgFlr.AdjacencyList.Add(adf.AdjacencyData.Item2, new List<Tuple<CampusLocation, double>>());

                    CLConnector.BldgFlr.AdjacencyList[adf.AdjacencyData.Item1].Add(new Tuple<CampusLocation, double>(adf.AdjacencyData.Item2, adf.Distance));
                    CLConnector.BldgFlr.AdjacencyList[adf.AdjacencyData.Item2].Add(new Tuple<CampusLocation, double>(adf.AdjacencyData.Item1, adf.Distance));

                    Paths.Add(new Tuple<PointF, PointF>(adf.AdjacencyData.Item1.Location, adf.AdjacencyData.Item2.Location));

                    this.Invalidate();

                    
                }
            }
            else
                MessageBox.Show("Must select 2 campus locations.");
            
        }

        private void MSItemCampusLocationClear_Click(object sender, EventArgs e)
        {
            foreach(var x in PictureBoxesCampusLocations) 
                x.Reset();
        }

        private void PictureBoxBldgImage_Paint(object sender, PaintEventArgs e)
        {
            this.UpdateBuildingFloor();
        }
    }
}