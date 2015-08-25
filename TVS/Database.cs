using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    Debug.WriteLine("Oracle sucks!: {0}", e.Message);
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
    }
}