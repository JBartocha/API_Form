using ApiStoreTest;
using Azure.Core;
using Microsoft.Data.SqlClient;
using QuizApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Form
{
    internal static class Database_FillWithAPI_Data
    {
        private readonly static string _connectionString;
        static Database_FillWithAPI_Data()
        {
            _connectionString = ConnectionString.Get();
        }
        public static void FillDatabaseWithZasilkovnaData(ZasilkovnaJsonModel zasilkovnaRoots)
        {
            foreach (var pickupPoint in zasilkovnaRoots.Data.Values)
            {
                // Insert the pickup point into the database and get its ID
                int pickupPointId = InsertPickupPoint(pickupPoint);
                InsertPhotos(pickupPoint.Photos, pickupPointId);
                int openingHoursId = InsertOpeningHours(pickupPoint.OpeningHours, pickupPointId);

                if (pickupPoint.OpeningHours.Exceptions?.Exception != null)
                {
                    foreach (var ex in pickupPoint.OpeningHours.Exceptions.Exception)
                    {
                        InsertOpeningHoursExceptions(ex, openingHoursId);
                    }
                }
            }
        }

        private static int InsertOpeningHoursExceptions(ExceptionDay exception, int openingHoursId)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "INSERT INTO OpeningHoursExceptions (OHE_OHGROUP_ID, date, hours) " +
                               "VALUES (@OHE_OHGROUP_ID, @Date, @Hours);";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OHE_OHGROUP_ID", openingHoursId);
                command.Parameters.AddWithValue("@Date", exception.Date);
                command.Parameters.AddWithValue("@Hours", exception.Hours);
                command.ExecuteNonQuery();
                return openingHoursId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting opening hours exceptions: {ex.Message}");
                throw new Exception("Error inserting opening hours exceptions into database", ex);
            }
        }

        private static int InsertOpeningHours(OpeningHours openingHours, int pickupPointId)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "INSERT INTO openingHours (PP_ID, compactShort, compactLong, tableLong, " +
                    "monday, tuesday, wednesday, thursday, friday, saturday, sunday) " +
                    "VALUES (@PP_ID, @CompactShort, @CompactLong, @TableLong, @Monday, @Tuesday, @Wednesday, " +
                    "@Thursday, @Friday, @Saturday, @Sunday);" +
                    "SELECT SCOPE_IDENTITY();";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PP_ID", pickupPointId);
                command.Parameters.AddWithValue("@CompactShort", openingHours.CompactShort ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CompactLong", openingHours.CompactLong ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TableLong", openingHours.TableLong);
                command.Parameters.AddWithValue("@Monday", openingHours.Regular.Monday);
                command.Parameters.AddWithValue("@Tuesday", openingHours.Regular.Tuesday);
                command.Parameters.AddWithValue("@Wednesday", openingHours.Regular.Wednesday);
                command.Parameters.AddWithValue("@Thursday", openingHours.Regular.Thursday);
                command.Parameters.AddWithValue("@Friday", openingHours.Regular.Friday);
                command.Parameters.AddWithValue("@Saturday", openingHours.Regular.Saturday);
                command.Parameters.AddWithValue("@Sunday", openingHours.Regular.Sunday);
                object result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting opening hours: {ex.Message}");
                throw new Exception("Error inserting opening hours into database", ex);
            }
        }

        private static void InsertPhotos(List<Photo> photos, int pickupPointId)
        {
            foreach (Photo photo in photos) {
                try
                {
                    using var connection = new SqlConnection(_connectionString);
                    connection.Open();
                    string query = "INSERT INTO photos (PhotosGroup_ID, thumbnail, normal) " +
                                   "VALUES (@PhotosGroup_ID, @Thumbnail, @Normal);";
                    using var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PhotosGroup_ID", pickupPointId);
                    command.Parameters.AddWithValue("@Thumbnail", photo.Thumbnail);
                    command.Parameters.AddWithValue("@Normal", photo.Normal);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while inserting into table photos: {ex.Message}");
                }
            }
        }

        private static int InsertPickupPoint(PickupPoint pickupPoint)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                string query = "INSERT INTO PickupPoint (PP_ID, name, nameStreet, special, " +
                    "place, street, city, zip, country, currency, directions, directionsCar," +
                    "directionsPublic,wheelchairAccesible, latitude, longitude, url," +
                    "dressingRoom, claimAssistant, packetConsignment, maxWeight, labelRouting," +
                    "labelName) " +
                    "VALUES (@PP_ID, @name, @nameStreet, @special, " +
                    "@place, @street, @city, @zip, @country, @currency, @directions, @directionsCar," +
                    "@directionsPublic,@wheelchairAccesible, @latitude, @longitude, @url," +
                    "@dressingRoom, @claimAssistant, @packetConsignment, @maxWeight, @labelRouting," +
                    "@labelName);" +
                        "SELECT SCOPE_IDENTITY();";
                using var command = new SqlCommand(query, connection);
                
                //Debug.WriteLine(pickupPoint.DressingRoom + " " + pickupPoint.ClaimAssistant + " " + pickupPoint.PacketConsignment);
                command.Parameters.AddWithValue("@PP_ID", pickupPoint.Id);
                command.Parameters.AddWithValue("@name", pickupPoint.Name);
                command.Parameters.AddWithValue("@nameStreet", pickupPoint.NameStreet);
                command.Parameters.AddWithValue("@special", pickupPoint.Special ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@place", pickupPoint.Place);
                command.Parameters.AddWithValue("@street", pickupPoint.Street);
                command.Parameters.AddWithValue("@city", pickupPoint.City);
                command.Parameters.AddWithValue("@zip", pickupPoint.Zip);
                command.Parameters.AddWithValue("@country", pickupPoint.Country);
                command.Parameters.AddWithValue("@currency",    pickupPoint.Currency);
                command.Parameters.AddWithValue("@directions", pickupPoint.Directions ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@directionsCar", pickupPoint.DirectionsCar ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@directionsPublic", pickupPoint.DirectionsPublic ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@wheelchairAccesible", pickupPoint.WheelchairAccessible);
                command.Parameters.AddWithValue("@latitude", pickupPoint.Latitude);
                command.Parameters.AddWithValue("@longitude", pickupPoint.Longitude);
                command.Parameters.AddWithValue("@url", pickupPoint.Url);
                command.Parameters.AddWithValue("@dressingRoom", pickupPoint.DressingRoom);
                command.Parameters.AddWithValue("@claimAssistant", pickupPoint.ClaimAssistant);
                command.Parameters.AddWithValue("@packetConsignment", pickupPoint.PacketConsignment);
                command.Parameters.AddWithValue("@maxWeight", pickupPoint.MaxWeight);
                command.Parameters.AddWithValue("@labelRouting", pickupPoint.LabelRouting);
                command.Parameters.AddWithValue("@labelName", pickupPoint.LabelName);

                object result = command.ExecuteScalar();
                int IDAnswer = Convert.ToInt32(result);
                return IDAnswer;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in method InsertPickupPoint: {ex.Message}");
                throw new Exception("Error inserting PickupPoint into database", ex);
            }
        }
    }

}