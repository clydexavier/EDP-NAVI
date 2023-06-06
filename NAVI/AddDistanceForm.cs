using NAVI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVI
{
    public partial class AddDistanceForm : Form
    {
        public Tuple<CampusLocation, CampusLocation> AdjacencyData;
        public double Distance;
        public AddDistanceForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.Distance = Convert.ToDouble(NUDWholeNumber.Value +"." +NUDDecimal.Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonSubmit_VisibleChanged(object sender, EventArgs e)
        {
            if(AdjacencyData == null)
            {
                LabelCampusLocation1.Text = "null";
                LabelCampusLocation2.Text = "null";

            }
            else
            {
                LabelCampusLocation1.Text = AdjacencyData.Item1.DisplayName;
                LabelCampusLocation2.Text = AdjacencyData.Item2.DisplayName;
            }
        }

        
    }
}
