using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class BuildingConnection
    {
        public Tuple<BuildingFloor, CampusLocation> PortalA;
        public Tuple<BuildingFloor, CampusLocation> PortalB;

        public BuildingConnection(BuildingFloor floorA, CampusLocation locA, BuildingFloor floorB, CampusLocation locB)
        {
            this.PortalA = new Tuple<BuildingFloor, CampusLocation>(floorA, locA);
            this.PortalB = new Tuple<BuildingFloor, CampusLocation>(floorB, locB);
        }

        public bool IsConnected(BuildingFloor buildingFloor)
        {
            return PortalA.Item1.Equals(buildingFloor) || PortalB.Item1.Equals(buildingFloor);
        }

        public bool IsConnected(CampusLocation campusLocation)
        {
            return PortalA.Item2.Equals(campusLocation) || PortalB.Item2.Equals(campusLocation);
        }

        public Tuple<BuildingFloor, CampusLocation>? GetBuildingFloor(CampusLocation campusLocation)
        {
            if (this.PortalA.Item2.Equals(campusLocation)) return this.PortalB;
            else if (this.PortalB.Item2.Equals(campusLocation)) return this.PortalA;
            else return null;
        }
    }
}
