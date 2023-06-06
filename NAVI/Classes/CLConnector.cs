using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class CLConnector
    {
        private static List<CampusLocation> CampusLocations = new List<CampusLocation>();
        public static BuildingFloor BldgFlr;

        public static bool AddCampusLocation(CampusLocation campusLocation)
        {
            if (CampusLocations.Count > 1) return false;
            
            CampusLocations.Add(campusLocation);
            return true;
        }
       /* public static bool Connect()
        {
            if(CampusLocations.Count != 2) return false;

            if (!BldgFlr.AdjacencyList.ContainsKey(CampusLocations[0]))
                BldgFlr.AdjacencyList.Add(CampusLocations[0], new List<CampusLocation>());
            if(!BldgFlr.AdjacencyList.ContainsKey(CampusLocations[1]))
                BldgFlr.AdjacencyList.Add(CampusLocations[1], new List<CampusLocation>());
           
            BldgFlr.AdjacencyList[CampusLocations[0]].Add(CampusLocations[1]);
            BldgFlr.AdjacencyList[CampusLocations[1]].Add(CampusLocations[0]);

            return true;
        }*/

        public static Tuple<CampusLocation, CampusLocation>? GetCampusLocations()
        {
            if (CampusLocations.Count != 2) return null;
            return new Tuple<CampusLocation, CampusLocation>(CampusLocations[0], CampusLocations[1]);
        }

        public static void Remove(CampusLocation cl)
        {
            CampusLocations.Remove(cl);
        }

        public static void Clear()
        {
            CampusLocations.Clear();    
        }
        
    }
}
