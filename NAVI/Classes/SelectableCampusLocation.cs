using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class SelectableCampusLocation: PictureBox
    {
        public CampusLocation CampusLocation;
        public SelectableCampusLocation(CampusLocation campusLocation) 
        {
            this.CampusLocation = campusLocation;
            this.Click += SelectableCampusLocation_Click;
        }

        private void SelectableCampusLocation_Click(object sender, EventArgs e)
        {
            if (CampusLocation == null) return;

            this.CreateGraphics().Clear(Color.Yellow);
        }

        public void Draw()
        {
            if (CampusLocation == null)
            {
                this.Visible = false;
                return;
            }
            else this.Visible = true;

            if(CampusLocation.LocationType == LocationType.MAIN) 
                this.CreateGraphics().Clear(Color.Red);
            else this.CreateGraphics().Clear(Color.Green);
        }
    }
}
