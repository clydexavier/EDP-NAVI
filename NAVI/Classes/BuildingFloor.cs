using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Drawing;

namespace NAVI.Classes
{
    public class BuildingFloor
    {
        [JsonIgnore]
        public Image BuildingImage { get; set; }
        public byte[]? ImageData;
        public string Name { get; set; }
        public List<CampusLocation> CampusLocations;

        public Dictionary<string, List<Tuple<string, double>>> AdjacencyList;

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
            this.AdjacencyList = new Dictionary<string, List<Tuple<string, double>>>();

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
