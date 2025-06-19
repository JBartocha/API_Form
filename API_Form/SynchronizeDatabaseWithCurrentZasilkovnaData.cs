using Microsoft.Data.SqlClient;
using QuizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Form
{
    internal class SynchronizeDatabaseWithCurrentZasilkovnaData
    {
        private readonly static string _connectionString;

        // Static constructor to initialize the static readonly field
        static SynchronizeDatabaseWithCurrentZasilkovnaData()
        {
            _connectionString = ConnectionString.Get();
            DeleteAllRowsAndResetIdentities();
        }

        public static void DeleteAllRowsAndResetIdentities()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Disable foreign key constraints
                        using (var cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'", connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Delete data from all tables
                        using (var cmd = new SqlCommand(@"
                            DELETE FROM [Photo];
                            DELETE FROM [OpeningHoursExceptions];
                            DELETE FROM [OpeningHours];
                            DELETE FROM [PickupPoint];
                        ", connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Reset identity columns
                        using (var cmd = new SqlCommand(@"
                            DBCC CHECKIDENT ('Photo', RESEED, 0);
                            DBCC CHECKIDENT ('OpeningHoursExceptions', RESEED, 0);
                            DBCC CHECKIDENT ('OpeningHours', RESEED, 0);
                            DBCC CHECKIDENT ('PickupPoint', RESEED, 0);
                        ", connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Re-enable foreign key constraints
                        using (var cmd = new SqlCommand("EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'", connection, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while deleting rows and resetting identities in the database.");
                    }
                }
            }
        }

    }
}
