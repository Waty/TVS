using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Oracle.ManagedDataAccess.Client;

namespace TVS
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
                TramTypeID = Convert.ToInt32(reader["Tramtype_ID"]),
                Nummer = Convert.ToInt32(reader["Nummer"]),
                Lengte = Convert.ToInt32(reader["Lengte"]),
                //TODO: Status
                Vervuild = Convert.ToBoolean(reader["Vervuild"]),
                Defect = Convert.ToBoolean(reader["Defect"]),
                ConductGeschikt = Convert.ToBoolean(reader["ConducteurGeschikt"]),
                Beschikbaar = Convert.ToBoolean(reader["Beschikbaar"])
            });
        }

        /// <summary>
        ///     Stores the <see cref="Schoonmaak" /> in the database
        /// </summary>
        /// <param name="s">the cleanup to be stored</param>
        public static void SaveCleanup(Schoonmaak s)
        {
            string query = "INSERT INTO schoonmaak (ID, MEDEWERKERID, TRAMID, DATUM) " +
                           $"VALUES (NULL, {s.Medewerker.Id}, {s.Tram.Id}, '{s.Date:dd-MM-yy}')";

            ExecuteNonQuery(query);

            query = "UPDATE TRAM SET \"Vervuild\" = 0 WHERE ID = " + s.Tram.Id;
            ExecuteNonQuery(query);
        }
    }
}