using ApiStoreTest;
using Azure.Core;
using Microsoft.Data.SqlClient;
using QuizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace API_Form
{
    internal static class Database_Search_Operations
    {
        public static readonly HashSet<string> allowedColumns = new HashSet<string>
        {
            "PP_ID", "name", "nameStreet", "special", "place", "street", "city",
            "zip", "country", "currency", "directions", "directionsCar", "directionsPublic",
            "wheelchairAccesible", "latitude", "longitude", "url", "labelRouting", "labelName"
            // Add more allowed columns as needed
        };

        private readonly static string _connectionString;
        static Database_Search_Operations()
        {
            _connectionString = ConnectionString.Get();
        }

        private static List<Photo> GetPhotos(int PhotosGroup_ID)
        {
            var photos = new List<Photo>();
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "SELECT thumbnail, normal FROM photos WHERE PhotosGroup_ID = @PhotosGroup_ID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PhotosGroup_ID", PhotosGroup_ID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Photo photo = new Photo
                            {
                                Thumbnail = reader.GetString(reader.GetOrdinal("thumbnail")),
                                Normal = reader.GetString(reader.GetOrdinal("normal"))
                            };
                            photos.Add(photo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving photos: {ex.Message}");
                throw new Exception("Error retrieving photos from database", ex);
            }
            return photos;
        }

        private static Exceptions GetExceptions(int oh_ID)
        {
            Exceptions exceptions = new Exceptions();
            exceptions.Exception = new List<ExceptionDay>();
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                string query = "SELECT date, hours FROM OpeningHoursExceptions WHERE OHE_OHGROUP_ID = @oh_ID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@oh_ID", oh_ID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExceptionDay exceptionDay = new ExceptionDay
                            {
                                Date = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("date"))),
                                Hours = reader.GetString(reader.GetOrdinal("hours"))
                            };
                            exceptions.Exception.Add(exceptionDay);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving exceptions: {ex.Message}");
                throw new Exception("Error retrieving exceptions from database", ex);
            }
            return exceptions;
        }

        public static List<PickupPoint> SearchByColumn(string columnName, string value, Type valueType)
        {
            List<PickupPoint> pickupPoints = new List<PickupPoint>();

            // Validate column name to prevent SQL injection
            var allowedColumns = new HashSet<string>
    {
        "PP_ID", "name", "nameStreet", "special", "place", "street", "city",
        "zip", "country", "currency", "directions", "directionsCar", "directionsPublic",
        "wheelchairAccesible", "latitude", "longitude", "url", "dressingRoom", "claimAssistant",
        "packetConsignment", "maxWeight", "labelRouting", "labelName"
        // Add more allowed columns as needed
    };

            if (!allowedColumns.Contains(columnName))
                throw new ArgumentException("Invalid column name.");

            // Convert value to the correct type
            object typedValue = valueType switch
            {
                var t when t == typeof(int) => int.Parse(value),
                var t when t == typeof(bool) => bool.Parse(value),
                var t when t == typeof(double) => double.Parse(value),
                _ => value // treat as string by default
            };

            //string query = "SELECT * FROM PickupPoint WHERE City COLLATE Czech_CI_AI LIKE @city COLLATE Czech_CI_AI";
            string query = $@"
        SELECT openingHours.oh_ID, PickupPoint.PP_ID, name, nameStreet, special, place, street, city,
               zip, country, currency, directions, directionsCar, directionsPublic,
               wheelchairAccesible, latitude, longitude, url, dressingRoom, claimAssistant,
               packetConsignment, maxWeight, labelRouting, labelName,
               compactShort, compactLong, tableLong, monday, tuesday, wednesday, 
               thursday, friday, saturday, sunday
        FROM PickupPoint
        JOIN openingHours ON PickupPoint.PickupPoint_ID = openingHours.PP_ID ";

            if(valueType == typeof(string))
                query += $@" WHERE PickupPoint.{columnName} COLLATE Czech_CI_AI LIKE '%' + @value + '%' COLLATE Czech_CI_AI";
            else
                query += $@" WHERE PickupPoint.{columnName} = @value";


            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var command = new SqlCommand(query, connection);



            command.Parameters.AddWithValue("@value", typedValue);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                int oh_ID = reader.GetInt32(reader.GetOrdinal("oh_ID"));

                PickupPoint PP = new PickupPoint
                {
                    Id = reader.GetInt32(reader.GetOrdinal("PP_ID")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                    NameStreet = reader.GetString(reader.GetOrdinal("nameStreet")),
                    Special = reader.IsDBNull(reader.GetOrdinal("special")) ? null : reader.GetString(reader.GetOrdinal("special")),
                    Place = reader.GetString(reader.GetOrdinal("place")),
                    Street = reader.GetString(reader.GetOrdinal("street")),
                    City = reader.GetString(reader.GetOrdinal("city")),
                    Zip = reader.GetString(reader.GetOrdinal("zip")),
                    Country = reader.GetString(reader.GetOrdinal("country")),
                    Currency = reader.GetString(reader.GetOrdinal("currency")),
                    Directions = reader.IsDBNull(reader.GetOrdinal("directions")) ? null : reader.GetString(reader.GetOrdinal("directions")),
                    DirectionsCar = reader.IsDBNull(reader.GetOrdinal("directionsCar")) ? null : reader.GetString(reader.GetOrdinal("directionsCar")),
                    DirectionsPublic = reader.IsDBNull(reader.GetOrdinal("directionsPublic")) ? null : reader.GetString(reader.GetOrdinal("directionsPublic")),
                    WheelchairAccessible = reader.GetString(reader.GetOrdinal("wheelchairAccesible")),
                    Latitude = reader.IsDBNull(reader.GetOrdinal("latitude")) ? 0 : reader.GetDouble(reader.GetOrdinal("latitude")),
                    Longitude = reader.IsDBNull(reader.GetOrdinal("longitude")) ? 0 : reader.GetDouble(reader.GetOrdinal("longitude")),
                    Url = reader.IsDBNull(reader.GetOrdinal("url")) ? string.Empty : reader.GetString(reader.GetOrdinal("url")),
                    DressingRoom = reader.IsDBNull(reader.GetOrdinal("dressingRoom")) ? false : reader.GetBoolean(reader.GetOrdinal("dressingRoom")),
                    ClaimAssistant = reader.IsDBNull(reader.GetOrdinal("claimAssistant")) ? false : reader.GetBoolean(reader.GetOrdinal("claimAssistant")),
                    PacketConsignment = reader.IsDBNull(reader.GetOrdinal("packetConsignment")) ? false : reader.GetBoolean(reader.GetOrdinal("packetConsignment")),
                    MaxWeight = reader.IsDBNull(reader.GetOrdinal("maxWeight")) ? 0 : reader.GetInt32(reader.GetOrdinal("maxWeight")),
                    LabelRouting = reader.IsDBNull(reader.GetOrdinal("labelRouting")) ? string.Empty : reader.GetString(reader.GetOrdinal("labelRouting")),
                    LabelName = reader.IsDBNull(reader.GetOrdinal("labelName")) ? string.Empty : reader.GetString(reader.GetOrdinal("labelName")),
                };
                RegularHours regularHours = new RegularHours
                {
                    Monday = reader.GetString(reader.GetOrdinal("monday")),
                    Tuesday = reader.GetString(reader.GetOrdinal("tuesday")),
                    Wednesday = reader.GetString(reader.GetOrdinal("wednesday")),
                    Thursday = reader.GetString(reader.GetOrdinal("thursday")),
                    Friday = reader.GetString(reader.GetOrdinal("friday")),
                    Saturday = reader.GetString(reader.GetOrdinal("saturday")),
                    Sunday = reader.GetString(reader.GetOrdinal("sunday")),
                };
                OpeningHours openingHours = new OpeningHours
                {
                    CompactShort = reader.IsDBNull(reader.GetOrdinal("compactShort")) ? null : reader.GetString(reader.GetOrdinal("compactShort")),
                    CompactLong = reader.IsDBNull(reader.GetOrdinal("compactLong")) ? null : reader.GetString(reader.GetOrdinal("compactLong")),
                    TableLong = reader.GetString(reader.GetOrdinal("tableLong")),
                    Regular = regularHours,
                    Exceptions = GetExceptions(oh_ID) // Get exceptions for the PickupPoint
                };

                PP.OpeningHours = openingHours;
                List<Photo> photos = GetPhotos(PP.Id);
                PP.Photos = photos; // Assign the photos to the PickupPoint
                pickupPoints.Add(PP);
            }
            return pickupPoints;
        }
    }
}
