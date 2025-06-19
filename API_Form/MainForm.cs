using ApiStoreTest;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace API_Form
{
    public partial class MainForm : Form
    {
        private static readonly string ApiUrl = "https://www.zasilkovna.cz/api/v3/41494564a70d6de6/branch.json";

        //private string _JsonFileName = "Zasilkovna-Go-balik-cz.json"; // File name for Zasilkovna data
        private string _JsonFileName = "Zasilkovna-Go-balik-cz.json"; // File name for Zasilkovna data


        public MainForm()
        {
            InitializeComponent();

            //Debug.WriteLine(testPoint.Id);
            //Debug.WriteLine(Convert.ToInt32(testPoint.Id));
        }

        private ZasilkovnaJsonModel GetZasilkovnaData()
        {
            ZasilkovnaJsonModel _zasilkovnaRoots;
            if (!File.Exists(_JsonFileName))
            {
                MessageBox.Show($"File not found: {_JsonFileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FileNotFoundException($"The file {_JsonFileName} does not exist.");
            }

            string json = File.ReadAllText(_JsonFileName);
            //tring currentDirectory = Environment.CurrentDirectory;
            //Debug.WriteLine(currentDirectory);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            try
            {
                var deserializedSettings = JsonSerializer.Deserialize<ZasilkovnaJsonModel>(json, options);
                Debug.WriteLine(deserializedSettings?.Data?.Count ?? 0);
                if (deserializedSettings != null)
                {
                    _zasilkovnaRoots = deserializedSettings;
                    return _zasilkovnaRoots; // Successfully deserialized, exit the method
                }
                else
                    throw new Exception("Failed to deserialize settings.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing JSON data", ex);
            }
        }

        private async Task<string> GetJsonFromUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private async void LoadAPIString(string APIUrl)
        {
            string jsonString = await GetJsonFromUrlAsync(APIUrl);
            //Debug.WriteLine(jsonString);
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void button_Erase_DB_and_load_API_data_to_DB_Click(object sender, EventArgs e)
        {
            this.Hide(); //TODO - co s tímto?

            ZasilkovnaJsonModel _zasilkovnaRoots = new ZasilkovnaJsonModel();
            LoadAPIString(ApiUrl);
            _zasilkovnaRoots = GetZasilkovnaData();

            Database_FillWithAPI_Data.FillDatabaseWithZasilkovnaData(_zasilkovnaRoots);
        }

        private void button_Search_Zasilkovna_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form SearchForm = new SearchForm())
            {
                SearchForm.ShowDialog();
            }
            this.Show();
        }

        private void button_sync_Data_Click(object sender, EventArgs e)
        {
            ZasilkovnaJsonModel _zasilkovnaRoots = new ZasilkovnaJsonModel();
            LoadAPIString(ApiUrl);
            _zasilkovnaRoots = GetZasilkovnaData();
            SynchronizeDatabaseWithCurrentZasilkovnaData.DeleteAllRowsAndResetIdentities();
            Database_FillWithAPI_Data.FillDatabaseWithZasilkovnaData(_zasilkovnaRoots);
        }
    }
}
