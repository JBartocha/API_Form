using ApiStoreTest;
using Microsoft.Data.SqlClient;
using QuizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Form
{
    internal static class Database_Update_Operations
    {
        private readonly static string _connectionString;

        static Database_Update_Operations()
        {
            _connectionString = ConnectionString.Get();
        }

        public static void AddPhotosByGroupIds(int PhotosGroup_ID, List<Photo> photos)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var photo in photos)
                        {
                            using (var cmd = new SqlCommand(
                                @"INSERT INTO photos (PhotosGroup_ID, thumbnail, normal) 
                                  VALUES (@PhotosGroup_ID, @Thumbnail, @Normal)",
                                connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@PhotosGroup_ID", PhotosGroup_ID);
                                cmd.Parameters.AddWithValue("@Thumbnail", photo.Thumbnail ?? string.Empty);
                                cmd.Parameters.AddWithValue("@Normal", photo.Normal ?? string.Empty);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void DeletePhotosByGroupIds(int PhotosGroup_ID, List<Photo> photos)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var photo in photos)
                        {
                            using var cmd = new SqlCommand(
                                @"DELETE FROM photos 
                                  WHERE PhotosGroup_ID = @PhotosGroup_ID AND thumbnail = @Thumbnail",
                                connection, transaction);
                            cmd.Parameters.AddWithValue("@PhotosGroup_ID", PhotosGroup_ID);
                            cmd.Parameters.AddWithValue("@Thumbnail", photo.Thumbnail ?? string.Empty);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void UpdatePhotosByGroupIds(int PhotosGroup_ID, List<Photo> changedPhotos)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete all existing photos for this group
                        using (var deleteCmd = new SqlCommand(
                            "DELETE FROM photos WHERE PhotosGroup_ID = @PhotosGroup_ID", connection, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@PhotosGroup_ID", PhotosGroup_ID);
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Insert all new/changed photos
                        foreach (var photo in changedPhotos)
                        {
                            using (var insertCmd = new SqlCommand(
                                "INSERT INTO photos (PhotosGroup_ID, thumbnail, normal) VALUES (@PhotosGroup_ID, @Thumbnail, @Normal)",
                                connection, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@PhotosGroup_ID", PhotosGroup_ID);
                                insertCmd.Parameters.AddWithValue("@Thumbnail", photo.Thumbnail ?? string.Empty);
                                insertCmd.Parameters.AddWithValue("@Normal", photo.Normal ?? string.Empty);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void UpdateopeningHoursExceptions(int OHE_OHGROUP_ID, List<ExceptionDay> exceptionDays)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete existing exceptions for the group ID
                        using (var deleteCmd = new SqlCommand(
                            @"DELETE FROM OpeningHoursExceptions 
                              WHERE OHE_OHGROUP_ID = @OHE_OHGROUP_ID", connection, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@OHE_OHGROUP_ID", OHE_OHGROUP_ID);
                            deleteCmd.ExecuteNonQuery();
                        }
                        // Insert new exceptions
                        foreach (var exception in exceptionDays)
                        {
                            using (var insertCmd = new SqlCommand(
                                @"INSERT INTO OpeningHoursExceptions (OHE_OHGROUP_ID, date, hours) 
                                  VALUES (@OHE_OHGROUP_ID, @Date, @Hours)", connection, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@OHE_OHGROUP_ID", OHE_OHGROUP_ID);
                                insertCmd.Parameters.AddWithValue("@Date", exception.Date);
                                insertCmd.Parameters.AddWithValue("@Hours", exception.Hours ?? string.Empty);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void AddopeningHoursExceptions(int OHE_OHGROUP_ID, List<ExceptionDay> exceptionDays)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var exception in exceptionDays)
                        {
                            using (var cmd = new SqlCommand(
                                @"INSERT INTO OpeningHoursExceptions (OHE_OHGROUP_ID, date, hours) 
                                  VALUES (@OHE_OHGROUP_ID, @Date, @Hours)", connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@OHE_OHGROUP_ID", OHE_OHGROUP_ID);
                                cmd.Parameters.AddWithValue("@Date", exception.Date);
                                cmd.Parameters.AddWithValue("@Hours", exception.Hours ?? string.Empty);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void DeleteopeningHoursExceptions(int OHE_OHGROUP_ID, List<ExceptionDay> exceptionDays)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var exception in exceptionDays)
                        {
                            using (var cmd = new SqlCommand(
                                @"DELETE FROM OpeningHoursExceptions 
                                  WHERE OHE_OHGROUP_ID = @OHE_OHGROUP_ID AND date = @Date", connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@OHE_OHGROUP_ID", OHE_OHGROUP_ID);
                                cmd.Parameters.AddWithValue("@Date", exception.Date);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static void UpdatePickupPoint(int PickupPoint_ID, PickupPoint pickupPoint)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update PickupPoint details
                        using (var cmd = new SqlCommand(
                            @"UPDATE PickupPoint 
                              SET name = @Name, nameStreet = @NameStreet, special = @Special, place = @Place,
                                  street = @Street, city = @City, 
                                  zip = @Zip, country = @Country, currency = @Currency, 
                                  directions = @Directions, directionsCar = @DirectionsCar, 
                                  directionsPublic = @DirectionsPublic, wheelchairAccesible = @WheelchairAccessible, 
                                  latitude = @Latitude, longitude = @Longitude, url = @Url, 
                                  dressingRoom = @DressingRoom, claimAssistant = @ClaimAssistant, 
                                  packetConsignment = @PacketConsignment, maxWeight = @MaxWeight, 
                                  labelRouting = @LabelRouting, labelName = @LabelName 
                              WHERE PickupPoint_ID = @PickupPoint_ID", connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PickupPoint_ID", PickupPoint_ID);
                            cmd.Parameters.AddWithValue("@Name", pickupPoint.Name ?? string.Empty);
                            cmd.Parameters.AddWithValue("@NameStreet", pickupPoint.NameStreet ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Special", pickupPoint.Special ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Place", pickupPoint.Place ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Street", pickupPoint.Street ?? string.Empty);
                            cmd.Parameters.AddWithValue("@City", pickupPoint.City ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Zip", pickupPoint.Zip ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Country", pickupPoint.Country ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Currency", pickupPoint.Currency ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Directions", pickupPoint.Directions ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@DirectionsCar", pickupPoint.DirectionsCar ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@DirectionsPublic", pickupPoint.DirectionsPublic ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@WheelchairAccessible", pickupPoint.WheelchairAccessible ?? string.Empty);
                            cmd.Parameters.AddWithValue("@Latitude", pickupPoint.Latitude);
                            cmd.Parameters.AddWithValue("@Longitude", pickupPoint.Longitude);
                            cmd.Parameters.AddWithValue("@Url", pickupPoint.Url ?? string.Empty);
                            cmd.Parameters.AddWithValue("@DressingRoom", pickupPoint.DressingRoom);
                            cmd.Parameters.AddWithValue("@ClaimAssistant", pickupPoint.ClaimAssistant);
                            cmd.Parameters.AddWithValue("@PacketConsignment", pickupPoint.PacketConsignment);
                            cmd.Parameters.AddWithValue("@MaxWeight", pickupPoint.MaxWeight);
                            cmd.Parameters.AddWithValue("@LabelRouting", pickupPoint.LabelRouting ?? string.Empty);
                            cmd.Parameters.AddWithValue("@LabelName", pickupPoint.LabelName ?? string.Empty);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred while updating PickupPoint: {ex.Message}");
                        throw;
                    }

                    try
                    {
                        using (var cmd = new SqlCommand(
                            @"UPDATE openingHours 
                              SET compactShort = @CompactShort, compactLong = @CompactLong, tableLong = @TableLong 
                              WHERE PP_ID = @PickupPoint_ID", connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@PickupPoint_ID", PickupPoint_ID);
                            cmd.Parameters.AddWithValue("@CompactShort", pickupPoint.OpeningHours.CompactShort ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@CompactLong", pickupPoint.OpeningHours.CompactLong ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@TableLong", pickupPoint.OpeningHours.TableLong ?? string.Empty);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred while updating openingHours: {ex.Message}");
                        throw;
                    }

                    transaction.Commit();
                }
                connection.Close();
                MessageBox.Show("PickupPoint updated successfully.");
            }
        }
    }
}
