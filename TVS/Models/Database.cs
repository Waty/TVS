using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Oracle.ManagedDataAccess.Client;

namespace TVS.Models
{
    /// <summary>
    ///     A static class to that provides acces to the database hosted on athena
    /// </summary>
    public static class Database
    {
        /// <summary>
        ///     Gets a new <see cref="OracleConnection" /> instance
        /// </summary>
        /// <returns>
        ///     A new <see cref="OracleConnection" /> with a correct <see cref="OracleConnection.ConnectionString" />
        /// </returns>
        private static OracleConnection GetConnection()
        {
            const string str = "User Id=dbi326436;Password=UR5Q9cjwLZ;Data Source=fhictora01.fhict.local:1521/fhictora";
            return new OracleConnection(str);
        }

        /// <summary>
        ///     Executes an query and parses the resul table with a custom function
        /// </summary>
        /// <typeparam name="TResult">The type of the data that is read by the given func</typeparam>
        /// <param name="query">The query that will be executed on the database server</param>
        /// <param name="func">The function that will be called for every row in the returned table</param>
        /// <returns>An IEnumerable of type TResult/></returns>
        private static IEnumerable<TResult> ExecuteReader<TResult>(string query, Func<OracleDataReader, TResult> func)
        {
            var s = new Stopwatch();
            s.Start();
            using (OracleConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Failed to open the database connection!\n" + e);
                    yield break;
                }

                using (var cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return func(reader);
                        }
                    }
                }
            }
            s.Stop();
            Debug.WriteLine("Executed query {0} in {1}ms", query, s.ElapsedMilliseconds);
        }

        /// <summary>
        ///     Executes an query on the remote database and returns the number of updated rows
        /// </summary>
        /// <param name="query">query to execute on the database</param>
        /// <param name="commit">if commit is true, the database will execute an COMMIT statement after the query</param>
        /// <returns>The number of updated rows</returns>
        /// <exception cref="OracleException" />
        private static int ExecuteNonQuery(string query, bool commit = true)
        {
            var result = 0;
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    using (var cmd = new OracleCommand(query, con))
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    if (commit)
                    {
                        using (var cmd = new OracleCommand("COMMIT", con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Failed to execute query '{0}':\n{1}", query, e.Message);
            }
            return result;
        }

        /// <summary>
        ///     Executes a scalar function
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The first collumn of th first row of the results</returns>
        private static object ExecuteScalar(string query)
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    con.Open();
                    using (var cmd = new OracleCommand(query, con))
                    {
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Failed to execute query '{query}':");
                Debug.WriteLine(e);
            }
            return null;
        }

        /// <summary>
        ///     Finds the Employee with the matching username/password combo
        /// </summary>
        /// <param name="username">The username to login</param>
        /// <param name="password">The password to login</param>
        /// <returns>The function of the employee or null if the login attempt failed</returns>
        public static Medewerker Login(string username, string password)
        {
            string query =
                "SELECT Id, \"Functie_ID\", \"Naam\" FROM Medewerker " +
                $"WHERE \"Naam\" = '{username}' AND \"Wachtwoord\" = '{password}'";

            return ExecuteReader(query, reader => new Medewerker
            {
                Id = Convert.ToInt32(reader["Id"]),
                Naam = Convert.ToString(reader["Naam"]),
                Functie = (Medewerker.FunctieType) Convert.ToInt32(reader["Functie_Id"])
            }).SingleOrDefault();
        }

        /// <summary>
        ///     Retrieves all the trams from the database
        /// </summary>
        /// <returns>All trams</returns>
        public static IEnumerable<Tram> GetAllTrams()
        {
            return ExecuteReader("SELECT * FROM tram", reader => new Tram
            {
                Id = Convert.ToInt32(reader["ID"]),
                RemiseId = Convert.ToInt32(reader["Remise_ID_Standplaats"]),
                TramTypeId = Convert.ToInt32(reader["Tramtype_ID"]),
                Nummer = Convert.ToInt32(reader["Nummer"]),
                Lengte = Convert.ToInt32(reader["Lengte"]),
                Vervuild = Convert.ToBoolean(reader["Vervuild"]),
                Defect = Convert.ToBoolean(reader["Defect"]),
                ConducteurGeschikt = Convert.ToBoolean(reader["ConducteurGeschikt"]),
                Beschikbaar = Convert.ToBoolean(reader["Beschikbaar"])
            });
        }

        /// <summary>
        ///     Stores the <see cref="Schoonmaak" /> in the database
        /// </summary>
        /// <param name="s">the cleanup to be stored</param>
        public static void SaveCleanup(Schoonmaak s)
        {
            string query = "INSERT INTO schoonmaak (ID, MEDEWERKERID, TRAMID, DATUM, TYPE) " +
                           $"VALUES (NULL, {s.Medewerker.Id}, {s.Tram.Id}, '{s.Date:dd-MM-yy}', {s.Type:D})";

            ExecuteNonQuery(query);

            query = "UPDATE TRAM SET \"Vervuild\" = 0 WHERE ID = " + s.Tram.Id;
            ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Sets the "Vervuild" to true
        /// </summary>
        public static int SetVervuild(int nummer)
        {
            string query = "UPDATE Tram SET \"Vervuild\" = 1 WHERE \"Nummer\" = " + nummer;
            return ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Sets "Defect" to true
        /// </summary>
        /// <param name="number"></param>
        public static void SetBroken(int number)
        {
            string query = "UPDATE Tram SET \"Defect\" = 1 WHERE \"Nummer\" = " + number;
            ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Retrieves the ID, name and functie of all medewerkers
        /// </summary>
        public static IEnumerable<Medewerker> GetAllMedewerkers()
        {
            return ExecuteReader("SELECT Id, \"Functie_ID\", \"Naam\" FROM Medewerker", reader => new Medewerker
            {
                Id = Convert.ToInt32(reader["Id"]),
                Naam = Convert.ToString(reader["Naam"]),
                Functie = (Medewerker.FunctieType) Convert.ToInt32(reader["Functie_Id"])
            });
        }

        /// <summary>
        ///     Retrieves whether chosen railway is blocked
        /// </summary>
        /// <param name="number"></param>
        public static bool IsRailBlocked(int number)
        {
            string query = "SELECT Geblokkeerd FROM Spoor Where \"Nummer\" = " + number;
            return Convert.ToBoolean(ExecuteScalar(query));
        }

        /// <summary>
        ///     Blocks or Unblocks a railway
        /// </summary>
        /// <param name="railNumber">The number of the rails that gets toggled</param>
        /// <param name="enabled">The status the rails gets toggle to</param>
        public static int ToggleRailBlock(int railNumber, bool enabled)
        {
            string query = $"UPDATE Spoor SET Geblokkeerd = {Convert.ToInt32(enabled)} WHERE \"Nummer\" = {railNumber}";
            return ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Retrieves all the tramtypes from the database
        /// </summary>
        public static IEnumerable<TramType> GetTramtypes()
        {
            const string query = "SELECT * FROM Tramtype";
            return ExecuteReader(query, reader => new TramType
            {
                Id = Convert.ToInt32(reader["ID"]),
                Omschrijving = Convert.ToString(reader["Omschrijving"])
            });
        }

        /// <summary>
        ///     Adds a new tram to the database
        /// </summary>
        public static void NewTram(int remiseid, int typeid, int nummer, int lengte, int geschikt, int beschikbaar)
        {
            string query = "INSERT INTO Tram values ('null', " + remiseid + ", " + typeid + ", " + nummer + ", " +
                           lengte +
                           ",'0','0'," + geschikt + "," + beschikbaar + ")";

            ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Updates the tram with the provided info
        /// </summary>
        /// <param name="tram"></param>
        public static int UpdateTram(Tram tram)
        {
            string query =
                $"UPDATE Tram SET \"Nummer\" = {tram.Nummer}, \"Lengte\" = {tram.Lengte}, " +
                $"\"Vervuild\" = {Convert.ToInt32(tram.Vervuild)}, \"Defect\" = {Convert.ToInt32(tram.Defect)}, " +
                $"\"ConducteurGeschikt\" = {Convert.ToInt32(tram.ConducteurGeschikt)}, \"Beschikbaar\" = {Convert.ToInt32(tram.Beschikbaar)}, " +
                $"\"Tramtype_ID\" = {tram.TramTypeId}, \"Remise_ID_Standplaats\" = {tram.RemiseId} WHERE Id = {tram.Id}";

            return ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Stores the maintenance in the database
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int SaveMaintenance(Maintenance m)
        {
            string query = "INSERT INTO Maintenance (Id, Datum,Type,TramId,MedewerkerId)" +
                           $"VALUES(NULL, '{m.Date:dd-MM-yy}',{Convert.ToInt32(m.Type)},{m.Tram.Id},{m.Medewerker.Id})";

            return ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Retrieves the maintenance history
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Maintenance> GetMaintenanceHistory()
        {
            var query = "SELECT * FROM Maintenance";
            List<Medewerker> mederwerkers = GetAllMedewerkers().ToList();
            List<Tram> trams = GetAllTrams().ToList();
            return ExecuteReader(query, reader => new Maintenance
            {
                Medewerker = mederwerkers.FirstOrDefault(m => m.Id == Convert.ToInt32(reader["Medewerkerid"])),
                Type = (Maintenance.MaintenanceType) Convert.ToInt32(reader["Type"]),
                Date = Convert.ToDateTime(reader["Datum"]),
                Tram = trams.FirstOrDefault(t => t.Id == Convert.ToInt32(reader["Tramid"]))
            });
        }

        /// <summary>
        ///     Retrieves the cleaning history
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Schoonmaak> GetCleaningHistory()
        {
            List<Medewerker> mederwerkers = GetAllMedewerkers().ToList();
            List<Tram> trams = GetAllTrams().ToList();

            return ExecuteReader("SELECT * FROM Schoonmaak", reader => new Schoonmaak
            {
                Medewerker = mederwerkers.FirstOrDefault(m => m.Id == Convert.ToInt32(reader["Medewerkerid"])),
                Type = (Schoonmaak.SchoonmaakType) Convert.ToInt32(reader["Type"]),
                Date = Convert.ToDateTime(reader["Datum"]),
                Tram = trams.FirstOrDefault(t => t.Id == Convert.ToInt32(reader["Tramid"]))
            });
        }


        /// <summary>
        ///     Checks whether tram is in Remise
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsInRemise(int id)
        {
            string query = "SELECT COUNT(*) FROM Sector Where \"Tram_ID\" = " + id;
            return Convert.ToInt32(ExecuteScalar(query)) > 0;
        }

        /// <summary>
        ///     Retrieves whether chosen railway is available
        /// </summary>
        /// <param name="number"></param>
        public static bool IsRailAvailable(int number)
        {
            string query = "SELECT \"Beschikbaar\" FROM Spoor Where \"Nummer\" = " + number;
            return Convert.ToBoolean(ExecuteScalar(query));
        }

        /// <summary>
        ///     Creates a new sector
        /// </summary>
        public static int CreateSector(int spoor, int tram)
        {
            string query = "Select COUNT(*) FROM Sector WHERE \"Spoor_ID\" = " + spoor;
            int nummer = Convert.ToInt32(ExecuteScalar(query)) + 1;
            query =
                "INSERT INTO Sector( \"ID\", \"Spoor_ID\", \"Tram_ID\", \"Nummer\", \"Beschikbaar\", \"Blokkade\") " +
                $"values(null, {spoor}, {tram}, {nummer}, 0, 0 )";
            return ExecuteNonQuery(query);
        }

        /// <summary>
        ///     Retrieves all tracks
        /// </summary>
        /// <returns>   Returns all tracks  </returns>
        public static IEnumerable<Spoor> GetAllTracks()
        {
            return ExecuteReader("SELECT * FROM Spoor", reader => new Spoor(reader));
        }

        /// <summary>
        ///     Retrieves the empty tracks
        /// </summary>
        public static IEnumerable<Spoor> GetSelectedTracks(int number)
        {
            string query = "SELECT * FROM spoor " +
                           "WHERE (SELECT count(*) FROM sector WHERE  sector.\"Spoor_ID\" = spoor.ID)= " + number;
            return ExecuteReader(query, reader => new Spoor(reader));
        }

        /// <summary>
        ///     Retrieves sector for chosen tram
        /// </summary>
        /// <param name="tramId"></param>
        /// <returns></returns>
        public static Sector GetSector(int tramId)
        {
            string query = "SELECT * FROM Sector WHERE \"Tram_ID\" = " + tramId;
            return ExecuteReader(query, reader => new Sector
            { 
                    SpoorId = Convert.ToInt32(reader["Spoor_ID"]),
                    TramId = Convert.ToInt32(reader["Tram_ID"]),
                    Nummer = Convert.ToInt32(reader["Nummer"]),
                    Beschikbaar = Convert.ToBoolean(reader["Beschikbaar"]),
                    Blokkade = Convert.ToBoolean(reader["Blokkade"])
            }).First();
        }
    }
}