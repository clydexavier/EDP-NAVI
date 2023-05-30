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
    public partial class AddBuildingFloor : Form
    {
        public BuildingFloor BuildingFloor;
        public AddBuildingFloor()
        {
            InitializeComponent();
        }

        private void ButtonBrowseImage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Map Image (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LabelImageStatus.Text = ofd.SafeFileName;
            }
        }

        public void Clear()
        {
            this.BuildingFloor = null;
            TextBoxBldgFlrName.Text = string.Empty;
            TextBoxDescription.Text = string.Empty;
            RichTextBoxCredits.Text = string.Empty;
            TextBoxTags.Text = string.Empty;

            ofd.FileName = string.Empty;
            LabelImageStatus.Text = "No Image";     
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextBoxBldgFlrName.Text))
            {
                MessageBox.Show("Enter a building name.");
                return;
            }
            if (!File.Exists(ofd.FileName))
            {
                MessageBox.Show("You must upload a building floor image file.");
                return;
            }

            this.BuildingFloor = new BuildingFloor(Image.FromFile(ofd.FileName), TextBoxBldgFlrName.Text, TextBoxDescription.Text, RichTextBoxCredits.Text);
            this.BuildingFloor.Tags = TextBoxTags.Text.Split(',').ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
