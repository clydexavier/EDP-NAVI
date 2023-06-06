using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class SelectableCampusLocation: PictureBox
    {
        public CampusLocation CampusLocation;
        public BuildingFloor BuildingFloor;

        public SelectableCampusLocation(CampusLocation campusLocation, BuildingFloor buildingFloor) 
        {
            this.BuildingFloor = buildingFloor;
            this.CampusLocation = campusLocation;

            if (CampusLocation.LocationType == LocationType.MAIN)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Green;
            this.Click += SelectableCampusLocation_Click;
        }

        private void SelectableCampusLocation_Click(object sender, EventArgs e)
        {
            if (CampusLocation == null) return;


            if (this.BackColor != Color.Yellow && CLConnector.AddCampusLocation(this.CampusLocation))
                this.BackColor = Color.Yellow;
            else
            {
                CLConnector.Remove(this.CampusLocation);
                if (CampusLocation.LocationType == LocationType.MAIN)
                    this.BackColor = Color.Red;
                else
                    this.BackColor = Color.Green;

            }
        }

        public void Reset()
        {
            CLConnector.Remove(this.CampusLocation);
            if (CampusLocation.LocationType == LocationType.MAIN)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Green;
        }

      
    }
}
