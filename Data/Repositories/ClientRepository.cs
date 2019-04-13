using System;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class ClientRepository
    {
        private string _createClient = @"INSERT INTO Client 
                                        (IdentityCard,FirstName,LastName,TownId,Street,StreetNumber,PostalCode,PhoneNumber,Email)
                                        output inserted.Id
                                        VALUES (@identityCard,@firstName,@lastName,@town,@street,@streetNumber,@postalCode,@phoneNumber,@email);";


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
    }
}
