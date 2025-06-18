using Microsoft.VisualBasic.Logging;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Form
{
        public partial class MapForm : Form
        {
            private readonly WebView2 webView = new WebView2();

            public MapForm(double latitude, double longitude, string popup)
            {
                InitializeComponent();

                webView.Dock = DockStyle.Fill;
                this.Controls.Add(webView);

                // Call async loader after form is shown
                this.Shown += async (s, e) => await LoadMapAsync(latitude, longitude, popup);
            }

            private async Task LoadMapAsync(double latitude, double longitude, string popup)
            {
                string leafletHtml = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <meta charset=""utf-8"" />
                    <title>Simple Leaflet Map</title>
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet/dist/leaflet.css"" />
                    <style>
                        #map {{ width: 100vw; height: 100vh; }}
                        body {{ margin: 0; }}
                    </style>
                </head>
                <body>
                    <div id=""map""></div>
                    <script src=""https://unpkg.com/leaflet/dist/leaflet.js""></script>
                    <script>
                        // Initialize the map and set its view to a chosen geographical coordinates and zoom level
                        var map = L.map('map').setView([{latitude}, {longitude}], 15);

                        // Add a tile layer (the background map image) from OpenStreetMap
                        L.tileLayer('https://{{s}}.tile.openstreetmap.org/{{z}}/{{x}}/{{y}}.png', {{
                            maxZoom: 19,
                            attribution: '© OpenStreetMap'
                        }}).addTo(map);

                        // Add a marker at the specified coordinates
                        L.marker([{latitude}, {longitude}]).addTo(map)
                            .bindPopup('{popup}')
                            .openPopup();
                    </script>
                </body>
                </html>
                ";
            string tempFile = Path.Combine(Path.GetTempPath(), "leaflet_map.html");
                File.WriteAllText(tempFile, leafletHtml);

                await webView.EnsureCoreWebView2Async();
                webView.Source = new Uri(tempFile);
            }
        }
    }
