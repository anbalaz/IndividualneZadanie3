using Data.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private string _createClient = @"INSERT INTO Client 
                                        (IdentityCard,FirstName,LastName,TownId,Street,StreetNumber,PostalCode,PhoneNumber,Email)
                                        output inserted.Id
                                        VALUES (@identityCard,@firstName,@lastName,@town,@street,@streetNumber,@postalCode,@phoneNumber,@email);";

        private string _deleteClientById = @"DELETE FROM Client WHERE ID=@clientId;";
        private string _updateClientById = @"Update Client 
                                            SET TownId=@townId,
                                            	IdentityCard=@identityCard,
                                            	FirstName=@firstName,
                                            	LastName=@lastName,
                                            	Street=@street,
                                            	StreetNumber=@streetNumber,
                                            	PostalCode=@postalCode,
                                            	PhoneNumber=@phoneNumber,
                                            	Email=@email
                                            	WHERE Id=@id;";

        private string _getClientById = @"SELECT t.Id
                                		,t.Name
                                		,c.[Id]
                                		,[IdentityCard]
                                		,[FirstName]
                                		,[LastName]
                                		,[Street]
                                		,[StreetNumber]
                                		,[PostalCode]
                                		,[PhoneNumber]
                                		,[Email] FROM  Client as c
                                INNER JOIN BankAccount AS ba ON c.Id=ba.ClientId
                                INNER JOIN Town AS t ON c.TownId=t.Id
                                WHERE c.Id = @id;";
        private string _getClientSearch = @"SELECT c.[Id]
                                                  ,[IdentityCard]
                                            	  ,ba.IBAN
                                                  ,[FirstName]
                                                  ,[LastName]
                                                  ,t.Name
                                                  ,[Street]
                                                  ,[StreetNumber]
                                                  ,[PostalCode]
                                                  ,[PhoneNumber]
                                                  ,[Email] FROM  Client as c
                                            INNER JOIN BankAccount AS ba ON c.Id=ba.ClientId
                                            INNER JOIN Town AS t ON c.TownId=t.Id
                                           WHERE (LastName LIKE @searchString) OR (IdentityCard  LIKE @searchString) OR (ba.IBAN LIKE @searchString);";

        private string _getClientId = @"SELECT c.Id
                                		FROM  Client as c
                                        INNER JOIN BankAccount AS ba ON c.Id=ba.ClientId
                                        INNER JOIN Town AS t ON c.TownId=t.Id
                                        WHERE c.IdentityCard =@identityCard";

        private string _selectClientByIBAN = @" SELECT 
                                            	c.Id,
                                            	c.FirstName,
                                            	c.LastName
                                            	FROM Client as c
                                               INNER JOIN BankAccount as ba ON c.Id= ba.ClientId
                                               WHERE ba.IBAN =@IBAN;";

        private string _selectNewclients = @"SELECT  CONCAT(YEAR(ba.CreationAccountDate),'/',Format(ba.CreationAccountDate,'MMMM'))  as [YEAR/MONTH],
                                            COUNT(*) AS [COUNT] 
                                            FROM BankAccount AS ba
                                            where ba.CreationAccountDate >= DATEADD(MONTH,-6,GETDATE()) AND id <>1 AND TerminationDate IS Null
                                            GROUP BY  CONCAT(YEAR(ba.CreationAccountDate),'/',Format(ba.CreationAccountDate,'MMMM'))
                                            ORDER BY [YEAR/MONTH] ASC";

        public int CreateClient(string identityCard, string firstName, string lastName, int town, string street, string streetNumber, string postalCode, string phoneNumber, string email)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _createClient;
                        command.Parameters.Add("@identityCard", SqlDbType.VarChar).Value = identityCard;
                        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
                        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
                        command.Parameters.Add("@town", SqlDbType.Int).Value = town;
                        command.Parameters.Add("@street", SqlDbType.NVarChar).Value = street;
                        command.Parameters.Add("@streetNumber", SqlDbType.NVarChar).Value = streetNumber;
                        command.Parameters.Add("@postalCode", SqlDbType.VarChar).Value = postalCode;
                        command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

                        return Convert.ToInt32(command.ExecuteScalar());

                    }

                    catch (SqlException ex)
                    {

                        Console.WriteLine($"Exception occured: \n {ex}");
                        return 0;
                    }
                }

            }
        }

        public int DeleteClient(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _deleteClientById;
                        command.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;

                        return command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n {ex}");
                        return 0;
                    }
                }
            }
        }

        public Client SelectClientById(int clientId)
        {
            Client client = new Client();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _getClientById;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    Town town = new Town();
                                    town.Id = reader.GetInt32(0);
                                    town.Name = reader.GetString(1);
                                    client.Town = town;
                                    client.Id = reader.GetInt32(2);
                                    client.IdentityCard = reader.GetString(3);
                                    client.FirstName = reader.GetString(4);
                                    client.LastName = reader.GetString(5);
                                    client.Street = reader.GetString(6);
                                    client.StreetNumber = reader.GetString(7);
                                    client.PostalCode = reader.GetString(8);
                                    client.PhoneNumber = reader.GetString(9);
                                    client.Email = reader.GetString(10);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return client;
            }
        }

        public DataSet SelectClientSearch(string searchString)
        {
            DataSet ds = new DataSet();
            searchString = $"%{searchString}%";
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _getClientSearch;
                command.Parameters.Add("@searchString", SqlDbType.VarChar).Value = searchString;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "Clients");
                DataTable dt = ds.Tables["Clients"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
            }
        }

        public int SelectClientId(string identityCard)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _getClientId;
                    command.Parameters.Add("@identityCard", SqlDbType.VarChar).Value = identityCard;
                    try
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return 0;
            }
        }

        public int SelectClientUpdate(int clientId, int townId, string identityCard, string firstName, string lastName, string street, string streetNumber, string postalCode, string phoneNumber, string email)
        {
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = _updateClientById;
                        command.Parameters.Add("@id", SqlDbType.Int).Value = clientId;
                        command.Parameters.Add("@townId", SqlDbType.Int).Value = townId;
                        command.Parameters.Add("@identityCard", SqlDbType.VarChar).Value = identityCard;
                        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
                        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
                        command.Parameters.Add("@street", SqlDbType.NVarChar).Value = street;
                        command.Parameters.Add("@streetNumber", SqlDbType.NVarChar).Value = streetNumber;
                        command.Parameters.Add("@postalCode", SqlDbType.VarChar).Value = postalCode;
                        command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

                        return command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n {ex}");
                        return 0;
                    }
                }
            }
        }

        public Client SelectClientByIBAN(string IBAN)
        {
            Client client = new Client();
            using (SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = _selectClientByIBAN;
                    command.Parameters.Add("@IBAN", SqlDbType.VarChar).Value = IBAN;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            {
                                while (reader.Read())
                                {
                                    client.Id = reader.GetInt32(0);
                                    client.FirstName = reader.GetString(1);
                                    client.LastName = reader.GetString(2);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Exception occured: \n{ ex}");
                    }
                }
                return client;
            }
        }

        public DataSet SelectNewclients()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(RouteConst.CONNECTION_STRING);

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = _selectNewclients;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, "NewClients");
                DataTable dt = ds.Tables["NewClients"];

                return ds;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Exception occured: \n{ ex}");
                return ds;
            }
        }
    }
}