using ApiStoreTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Form
{
    public partial class SearchForm : Form
    {
        List<PickupPoint> results = new();

        public SearchForm()
        {
            InitializeComponent();

            foreach (string column in Database_Search_Operations.allowedColumns)
            {
                comboBox_Search_Criteria.Items.Add(column);
            }
            comboBox_Search_Criteria.SelectedIndex = 0; // Set default selection to the first item
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchString = textBox_SearchText.Text;
            // Not needed: combobox always has a selected item due to default selection
            if (comboBox_Search_Criteria.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid search criteria.");
                return;
            }

            switch (comboBox_Search_Criteria.SelectedItem.ToString())
            {
                case "PP_ID":
                    try
                    {
                        results = Database_Search_Operations.SearchByColumn("PP_ID", searchString, typeof(int));
                        Debug.WriteLine("Searching by ID: " + searchString);
                        //Database_Search_Operations.SearchById(ID);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter a valid integer ID.");
                        return;
                    }
                    break;
                case "name":
                    results = Database_Search_Operations.SearchByColumn("name", searchString, typeof(string));
                    break;
                case "nameStreet":
                    results = Database_Search_Operations.SearchByColumn("nameStreet", searchString, typeof(string));
                    break;
                case "special":
                    results = Database_Search_Operations.SearchByColumn("special", searchString, typeof(string));
                    break;
                case "place":
                    results = Database_Search_Operations.SearchByColumn("place", searchString, typeof(string));
                    break;
                case "street":
                    results = Database_Search_Operations.SearchByColumn("street", searchString, typeof(string));
                    break;
                case "city":
                    results = Database_Search_Operations.SearchByColumn("city", searchString, typeof(string));
                    break;
                case "zip":
                    results = Database_Search_Operations.SearchByColumn("zip", searchString, typeof(string));
                    break;
                case "country":
                    results = Database_Search_Operations.SearchByColumn("country", searchString, typeof(string));
                    break;
                case "currency":
                    results = Database_Search_Operations.SearchByColumn("currency", searchString, typeof(string));
                    break;
                case "directions":
                    results = Database_Search_Operations.SearchByColumn("directions", searchString, typeof(string));
                    break;
                case "directionsCar":
                    results = Database_Search_Operations.SearchByColumn("directionsCar", searchString, typeof(string));
                    break;
                case "directionsPublic":
                    results = Database_Search_Operations.SearchByColumn("directionsPublic", searchString, typeof(string));
                    break;
                case "wheelchairAccesible":
                    results = Database_Search_Operations.SearchByColumn("wheelchairAccesible", searchString, typeof(string));
                    break;
                case "latitude":
                    if (!double.TryParse(searchString, out double latitudeValue))
                    {
                        MessageBox.Show("Please enter a valid latitude value.");
                        return;
                    }
                    results = Database_Search_Operations.SearchByColumn("latitude", searchString, typeof(double));
                    break;
                case "longitude":
                    if (!double.TryParse(searchString, out double longitudeValue))
                    {
                        MessageBox.Show("Please enter a valid longitude value.");
                        return;
                    }
                    results = Database_Search_Operations.SearchByColumn("longitude", searchString, typeof(double));
                    break;
                case "url":
                    results = Database_Search_Operations.SearchByColumn("url", searchString, typeof(string));
                    break;
                case "dressingRoom":
                    results = Database_Search_Operations.SearchByColumn("dressingRoom", searchString, typeof(string));
                    break;
                case "labelRouting":
                    results = Database_Search_Operations.SearchByColumn("labelRouting", searchString, typeof(string));
                    break;
                case "labelName":
                    results = Database_Search_Operations.SearchByColumn("labelName", searchString, typeof(string));
                    break;
                default:
                    MessageBox.Show("Please select a valid search criteria.");
                    break;
            }
            FilllistViewWithData(results);
            Debug.WriteLine($"Search results count: {results.Count}");
        }

        private void FilllistViewWithData(List<PickupPoint> results)
        {
            listView.Items.Clear(); // Clear previous results
            foreach (var point in results)
            {
                ListViewItem item = new ListViewItem(point.Id.ToString());
                item.SubItems.Add(point.Name);
                item.SubItems.Add(point.NameStreet);
                item.SubItems.Add(point.Place);
                item.SubItems.Add(point.Street);
                item.SubItems.Add(point.City);
                item.SubItems.Add(point.Zip);
                item.SubItems.Add(point.Country);
                //item.SubItems.Add(point.Directions ?? "N/A");
                //item.SubItems.Add(point.DirectionsCar ?? "N/A");
                //item.SubItems.Add(point.DirectionsPublic ?? "N/A");
                item.SubItems.Add(point.WheelchairAccessible);
                item.SubItems.Add(point.Latitude.ToString());
                item.SubItems.Add(point.Longitude.ToString());
                item.SubItems.Add(point.Url);
                item.SubItems.Add(point.DressingRoom.ToString());
                item.SubItems.Add(point.LabelRouting);
                item.SubItems.Add(point.LabelName);
                listView.Items.Add(item);
            }
            //listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //AddButtonsForListViewItems(); // Add buttons after filling the ListView
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            //Debug.WriteLine("Selected item:");
            //Debug.WriteLine(listView.SelectedItems.Count > 0 ? listView.SelectedItems[0].Text : "No item selected");
            
            int selectedId = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);
            PickupPoint? selectedPickupPoint = results.FirstOrDefault(p => p.Id == selectedId);
            if (selectedPickupPoint == null)
            {
                MessageBox.Show("No matching PickupPoint found.");
                return;
            }

            this.Hide();
            using (Form DetailsForm = new DetailsForm(selectedPickupPoint))
            {
                DetailsForm.ShowDialog();
            }
            this.Show();
        }
    }
}
