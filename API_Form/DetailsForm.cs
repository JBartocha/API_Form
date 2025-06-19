using ApiStoreTest;
using Microsoft.Web.WebView2.WinForms;
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
    public partial class DetailsForm : Form
    {
        private readonly PickupPoint _pickupPointOriginal;
        private RegularHours regularHoursChanged = new();

        public DetailsForm()
        {
            InitializeComponent();
            _pickupPointOriginal = new PickupPoint();
        }

        public DetailsForm(PickupPoint pickupPoint)
        {
            InitializeComponent();

            _pickupPointOriginal = pickupPoint ?? throw new ArgumentNullException(nameof(pickupPoint), "PickupPoint cannot be null.");

            fillComponentsWithData(_pickupPointOriginal);
        }

        private void fillComponentsWithData(PickupPoint PP)
        {
            textBox_PP_ID.Text = PP.Id.ToString();
            richTextBox_name.Text = PP.Name;
            AdjustRichTextBoxHeightAndPosition(richTextBox_name, true);
            richTextBox_nameStreet.Text = PP.NameStreet;
            AdjustRichTextBoxHeightAndPosition(richTextBox_nameStreet, true);
            richTextBox_special.Text = PP.Special;
            AdjustRichTextBoxHeightAndPosition(richTextBox_special, true);
            textBox_place.Text = PP.Place;
            textBox_street.Text = PP.Street;
            textBox_city.Text = PP.City;
            textBox_zip.Text = PP.Zip;
            textBox_country.Text = PP.Country;
            textBox_currency.Text = PP.Currency;
            richTextBox_directions.Text = PP.Directions ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_directions, true);
            richTextBox_directionsCar.Text = PP.DirectionsCar ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_directionsCar, true);
            richTextBox_directionsPublic.Text = PP.DirectionsPublic ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_directionsPublic, true);
            textBox_wheelchairAccesible.Text = PP.WheelchairAccessible;
            textBox_latitude.Text = PP.Latitude.ToString("F6"); // Format to 6 decimal places
            textBox_longitude.Text = PP.Longitude.ToString("F6"); // Format to 6 decimal places
            checkBox_dressingroom.Checked = PP.DressingRoom;
            checkBox_claimAssistant.Checked = PP.ClaimAssistant;
            checkBox_packetConsignment.Checked = PP.PacketConsignment;
            textBox_maxWeight.Text = PP.MaxWeight.ToString();
            textBox_labelRouting.Text = PP.LabelRouting;
            richTextBox_labelName.Text = PP.LabelName;
            AdjustRichTextBoxHeightAndPosition(richTextBox_labelName, true);
            richTextBox_compactShort.Text = PP.OpeningHours.CompactShort ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_compactShort, true);
            richTextBox_compactLong.Text = PP.OpeningHours.CompactLong ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_compactLong, true);
            richTextBox_tableLong.Text = PP.OpeningHours.TableLong ?? string.Empty;
            AdjustRichTextBoxHeightAndPosition(richTextBox_tableLong, true);

            // Fixing the issue by iterating over the Exception list in the Exceptions class
            PP.OpeningHours?.Exceptions?.Exception?.ForEach(exception =>
            {
                dataGridView_openingHoursExceptions.Rows.Add(
                    exception.Date.ToString("dd/MM/yyyy"),
                    exception.Hours
                );
            });
            //ResizeDataGridViewToFitRows(dataGridView_openingHoursExceptions);
            AdjustControlHeightAndPosition(dataGridView_openingHoursExceptions, false);

            dataGridView_openingHours.Rows.Add("monday", PP.OpeningHours?.Regular?.Monday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("tuesday", PP.OpeningHours?.Regular?.Tuesday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("wednesday", PP.OpeningHours?.Regular?.Wednesday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("thursday", PP.OpeningHours?.Regular?.Thursday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("friday", PP.OpeningHours?.Regular?.Friday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("saturday", PP.OpeningHours?.Regular?.Saturday ?? string.Empty);
            dataGridView_openingHours.Rows.Add("sunday", PP.OpeningHours?.Regular?.Sunday ?? string.Empty);
            //ResizeDataGridViewToFitRows(dataGridView_openingHours);
            AdjustControlHeightAndPosition(dataGridView_openingHours, false);

            PP.Photos?.ForEach(photo =>
            {
                dataGridView_photos.Rows.Add(photo.Thumbnail, photo.Normal);
            });
            //ResizeDataGridViewToFitRows(dataGridView_photos);
            AdjustControlHeightAndPosition(dataGridView_photos, false);
        }

        private void AdjustRichTextBoxHeightAndPosition(RichTextBox richTextBox, bool leftSide)
        {
            int originalHeight = richTextBox.Height;
            int margin = richTextBox.Height - richTextBox.ClientSize.Height;
            int requiredHeight = TextRenderer.MeasureText(
                richTextBox.Text + "\n",
                richTextBox.Font,
                new Size(richTextBox.ClientSize.Width, int.MaxValue),
                TextFormatFlags.WordBreak
            ).Height + margin;

            if (requiredHeight > originalHeight)
            {
                int heightDiff = requiredHeight - originalHeight;
                richTextBox.Height = requiredHeight;

                // Move controls below the richTextBox down
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Top > richTextBox.Top && (leftSide ?
                        ctrl.Left < (this.Width / 2) : ctrl.Left >= (this.Width / 2)))
                    {
                        ctrl.Top += heightDiff;
                    }
                }
            }
        }

        private void AdjustControlHeightAndPosition(Control control, bool leftSide)
        {
            int originalHeight = control.Height;
            int requiredHeight = originalHeight;

            if (control is RichTextBox richTextBox)
            {
                int margin = richTextBox.Height - richTextBox.ClientSize.Height;
                requiredHeight = TextRenderer.MeasureText(
                    richTextBox.Text + "\n",
                    richTextBox.Font,
                    new Size(richTextBox.ClientSize.Width, int.MaxValue),
                    TextFormatFlags.WordBreak
                ).Height + margin;
            }
            else if (control is DataGridView dgv)
            {
                int totalRowHeight = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    totalRowHeight += row.Height;
                }
                int headerHeight = dgv.ColumnHeadersVisible ? dgv.ColumnHeadersHeight : 0;
                int margin = 2;
                requiredHeight = totalRowHeight + headerHeight + margin;
            }

            if (requiredHeight > originalHeight)
            {
                int heightDiff = requiredHeight - originalHeight;
                control.Height = requiredHeight;

                // Move controls below the current control down
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Top > control.Top && (leftSide ?
                        ctrl.Left < (this.Width / 2) : ctrl.Left >= (this.Width / 2)))
                    {
                        ctrl.Top += heightDiff;
                    }
                }
            }
        }



        private void button_zpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            fillComponentsWithData(_pickupPointOriginal);
        }

        private void button_Uloz_Zmeny_Click(object sender, EventArgs e)
        {
            PickupPoint current = new PickupPoint();

            current.Id = int.TryParse(textBox_PP_ID.Text, out int id) ? id : 0;
            current.Name = richTextBox_name.Text.Trim();
            current.NameStreet = richTextBox_nameStreet.Text.Trim();
            current.Special = richTextBox_special.Text.Trim();
            current.Place = textBox_place.Text.Trim();
            current.Street = textBox_street.Text.Trim();
            current.City = textBox_city.Text.Trim();
            current.Zip = textBox_zip.Text.Trim();
            current.Country = textBox_country.Text.Trim();
            current.Currency = textBox_currency.Text.Trim();
            current.Directions = richTextBox_directions.Text.Trim();
            current.DirectionsCar = richTextBox_directionsCar.Text.Trim();
            current.DirectionsPublic = richTextBox_directionsPublic.Text.Trim();
            current.WheelchairAccessible = textBox_wheelchairAccesible.Text.Trim();
            current.Latitude = double.TryParse(textBox_latitude.Text, out double latitude) ? latitude : 0.0;
            current.Longitude = double.TryParse(textBox_longitude.Text, out double longitude) ? longitude : 0.0;
            current.DressingRoom = checkBox_dressingroom.Checked;
            current.ClaimAssistant = checkBox_claimAssistant.Checked;
            current.PacketConsignment = checkBox_packetConsignment.Checked;
            current.MaxWeight = int.TryParse(textBox_maxWeight.Text, out int maxWeight) ? maxWeight : 0;
            current.LabelRouting = textBox_labelRouting.Text.Trim();
            current.LabelName = richTextBox_labelName.Text.Trim();

            // Update the LINQ query to ensure the list does not contain null values
            var exceptionDays = dataGridView_openingHoursExceptions.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row =>
                {
                    var dateString = row.Cells[0].Value?.ToString();
                    var hours = row.Cells[1].Value?.ToString() ?? string.Empty;

                    // Parse the date (assuming format "dd/MM/yyyy")
                    if (DateOnly.TryParseExact(dateString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var date))
                    {
                        return new ExceptionDay
                        {
                            Date = date,
                            Hours = hours
                        };
                    }
                    return null;
                })
                .Where(x => x != null) // Filter out null values
                .Cast<ExceptionDay>() // Cast to non-nullable type
                .ToList();

            var photos = dataGridView_photos.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new Photo
                {
                    Thumbnail = row.Cells[0].Value?.ToString() ?? string.Empty,
                    Normal = row.Cells[1].Value?.ToString() ?? string.Empty
                })
                .ToList();
            current.Photos = photos;

            current.OpeningHours = new OpeningHours
            {
                CompactShort = richTextBox_compactShort.Text.Trim(),
                CompactLong = richTextBox_compactLong.Text.Trim(),
                TableLong = richTextBox_tableLong.Text.Trim(),
                Regular = new RegularHours
                {
                    Monday = dataGridView_openingHours.Rows[0].Cells[1].Value?.ToString() ?? string.Empty,
                    Tuesday = dataGridView_openingHours.Rows[1].Cells[1].Value?.ToString() ?? string.Empty,
                    Wednesday = dataGridView_openingHours.Rows[2].Cells[1].Value?.ToString() ?? string.Empty,
                    Thursday = dataGridView_openingHours.Rows[3].Cells[1].Value?.ToString() ?? string.Empty,
                    Friday = dataGridView_openingHours.Rows[4].Cells[1].Value?.ToString() ?? string.Empty,
                    Saturday = dataGridView_openingHours.Rows[5].Cells[1].Value?.ToString() ?? string.Empty,
                    Sunday = dataGridView_openingHours.Rows[6].Cells[1].Value?.ToString() ?? string.Empty
                },
                Exceptions = new Exceptions
                {
                    Exception = exceptionDays
                }
            };
        }

        private void button_Show_On_Map_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show(
                "Zobrazit mapu ve Formuláři?",
                "Ano",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result1 == DialogResult.Yes)
            {
                showleafletjsMapForm();
            }

            var result2 = MessageBox.Show(
                "Zobrazit mapu v prohlížeči?",
                "Ano",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result2 == DialogResult.Yes)
            {
                double latitude, longitude;
                if (double.TryParse(textBox_latitude.Text, out latitude) && double.TryParse(textBox_longitude.Text, out longitude))
                {
                    Debug.WriteLine("latitude:" + latitude + ", longitude:" + longitude);
                    string url = $"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}";
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Invalid latitude or longitude values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void showleafletjsMapForm()
        {
            double latitude, longitude;
            string popup = richTextBox_name.Text;

            //TODO - ne zrovna nejlepší řešení když je zeměpisná šířka a delka prázdná
            latitude = double.TryParse(textBox_latitude.Text, out latitude) ? latitude : 0.0;
            longitude = double.TryParse(textBox_longitude.Text, out longitude) ? longitude : 0.0;

            this.Hide();
            using (Form MapForm = new MapForm(latitude, longitude, popup))
            {
                MapForm.ShowDialog();
            }
            this.Show();
        }
    }
}