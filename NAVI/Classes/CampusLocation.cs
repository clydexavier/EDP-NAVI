using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NAVI.Classes
{
    public class CampusLocation
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public PointF Location { get; set; }
        public LocationType LocationType { get; set; }

        public CampusLocation(string name, string displayName, PointF location, LocationType locationType)
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.Location = location;
            this.LocationType = locationType;
        }
        public override string ToString()
        {
            return this.DisplayName;
        }

    }
}
