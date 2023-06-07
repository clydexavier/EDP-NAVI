using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAVI.Classes
{
    public class CampusLocationConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is CampusLocation)
            {
                CampusLocation campusLocation = (CampusLocation)value;
                return campusLocation.ToString(); // Convert to string representation
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                string stringValue = (string)value;
                
                CampusLocation campusLocation = ParseCampusLocation(stringValue);
                return campusLocation;
                // Implement logic to convert from string representation to CampusLocation object
                // Return the resulting CampusLocation object
            }
            return base.ConvertFrom(context, culture, value);
        }
        private CampusLocation ParseCampusLocation(String s )
        {
            return new CampusLocation("", "", new PointF(0, 0), LocationType.MAIN);
        }
    }
}
