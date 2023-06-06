using NAVI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVI
{
    public partial class AddCampusLocation : Form
    {
        public CampusLocation CampusLocation;
        public PointF PointLocation;


        public AddCampusLocation()
        {
            InitializeComponent();
            ComboBoxLocationType.SelectedIndex = 1;
            this.PointLocation = PointF.Empty;
        }

        private void ButtonCampusLocationSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLocationName.Text))
            {
                MessageBox.Show("Enter the campus location name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxDisplay.Text))
            {
                MessageBox.Show("Enter the campus location display name.");
                return;
            }
            
            this.CampusLocation = new CampusLocation(TextBoxLocationName.Text, TextBoxDisplay.Text, this.PointLocation, ComboBoxLocationType.SelectedIndex == 0? LocationType.MAIN: LocationType.SUB);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        public void Clear()
        {
            this.CampusLocation = null;
            TextBoxLocationName.Text = string.Empty;
            TextBoxDisplay.Text = string.Empty;
            ComboBoxLocationType.SelectedIndex = 1;
            
        }

        private void AddCampusLocation_VisibleChanged(object sender, EventArgs e)
        {
            LabelLocationValue.Text = this.PointLocation.ToString();
        }
    }
}
