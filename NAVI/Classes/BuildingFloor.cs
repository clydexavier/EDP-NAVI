using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class BuildingFloor
    {
        public Image BuildingImage { get; set; }
        public string Name { get; set; }
        public List<CampusLocation> CampusLocations;
        public Dictionary<CampusLocation, List<CampusLocation>> AdjacencyList;

        public string Description { get; set; }
        public string Credits { get; set; }
        public List<string> Tags;

        public List<BuildingConnection> BuildingConnections;
            
        public BuildingFloor(Image image, string name, string description, string credits) 
        {
            this.BuildingImage = image;
            this.Name = name;
            this.Credits= credits;
            this.CampusLocations = new List<CampusLocation>();
            this.AdjacencyList = new Dictionary<CampusLocation, List<CampusLocation>>();

            this.Description = description;
            this.Tags = new List<string>();
            this.BuildingConnections = new List<BuildingConnection>();
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is BuildingFloor f && f.Name.Equals(this.Name);
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
