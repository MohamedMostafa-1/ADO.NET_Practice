using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection.Emit; // Data Provider

namespace ADO.NET_Practice
{
    internal class Program
    {
        static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;"; 
        static void PrintAllContacts()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * From Contacts";

            SqlCommand command = new SqlCommand(Query , connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {FirstName}");
                    Console.WriteLine($"LastName: {LastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            };

        }
        static void PrintAllContactsWithFirstName(string FirstName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * From Contacts where FirstName = @FirstName ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {firstName}");
                    Console.WriteLine($"LastName: {lastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            }
            ;

        }
        static void PrintAllContactsWithFirstNameAndCountry(string FirstName , int CountryId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * From Contacts where FirstName = @FirstName and CountryID =@CountryId ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@CountryId", CountryId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {firstName}");
                    Console.WriteLine($"LastName: {lastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            }
            ;

        }

        static void SearchContactsStartsWith(string StartsWith) {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * from Contacts where FirstName LIKE '' + @StartsWith + '%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@StartsWith" , StartsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {firstName}");
                    Console.WriteLine($"LastName: {lastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            };
        

        }
        static void SearchContactsEndsWith(string EndsWith) {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * from Contacts where FirstName LIKE '%' + @EndsWith + '' ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@EndsWith" , EndsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {firstName}");
                    Console.WriteLine($"LastName: {lastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            };
        

        }
        static void SearchContainsWith(string ContainsWith) {
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select * from Contacts where FirstName LIKE '%' + @ContainsWith + '%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ContainsWith", ContainsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    Nullable<int> CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID: {ContactID}");
                    Console.WriteLine($"FirstName: {firstName}");
                    Console.WriteLine($"LastName: {lastName}");
                    Console.WriteLine($"Email: {Email}");
                    Console.WriteLine($"Phone: {Phone}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"CountryID: {CountryID}");
                    Console.WriteLine();

                }
                //Connection Pool is a cache reuseable Database
                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            };
        

        }
        static string GetFirstName(int contactID)
        {
            string FirstName = "";
            SqlConnection connection = new SqlConnection(connectionString);
            string Query = "select FirstName from Contacts where ContactID = @contactID ";
            SqlCommand command = new SqlCommand(Query ,connection);
            command.Parameters.AddWithValue("@contactID", contactID);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    FirstName = Result.ToString();
                }
                else
                {
                     FirstName  ="";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex.Message);
            }
            return FirstName;
        }

        public struct stContact
        {
            public int ID { get; set; }
            public string FirstName { get; set; } 
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }
        static bool FindContactID(int ContactID, ref stContact ContactInfo)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(connectionString);
            string Query = @"Select * From Contacts Where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ContactID" , ContactID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ContactInfo.ID = (int)reader["ContactID"];
                    ContactInfo.FirstName = (string)reader["FirstName"];
                    ContactInfo.LastName = (string)reader["LastName"];
                    ContactInfo.Email = (string)reader["Email"];
                    ContactInfo.Phone = (string)reader["Phone"];
                    ContactInfo.Address = (string)reader["Address"];
                    ContactInfo.CountryID = (int)reader["CountryID"];
                }
                else
                {
                   IsFound = false;
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Massege Error: " + ex.Message);
            }
            
            return IsFound;
        }

        static void AddNewContact(stContact newContact)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                             VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", newContact.FirstName);
            command.Parameters.AddWithValue("@LastName", newContact.LastName);
            command.Parameters.AddWithValue("@Email", newContact.Email);
            command.Parameters.AddWithValue("@Phone", newContact.Phone);
            command.Parameters.AddWithValue("@Address", newContact.Address);
            command.Parameters.AddWithValue("@CountryID", newContact.CountryID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                
                if(rowAffected > 0)
                {
                    Console.WriteLine("Add Contact Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to Add Contact");
                }

                connection.Close();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void UpdataContact(int ContactIDUpdate , stContact contactInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"UPDATE Contacts
                            SET FirstName = @FirstName
                                ,LastName = @LastName
                                ,Email = @Email
                                ,Phone = @Phone 
                                ,Address = @Address
                                ,CountryID = @CountryID
                            WHERE ContactID = @ContactID ";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ContactID", ContactIDUpdate);
            command.Parameters.AddWithValue("@FirstName", contactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", contactInfo.LastName);
            command.Parameters.AddWithValue("@Email", contactInfo.Email);
            command.Parameters.AddWithValue("@Phone", contactInfo.Phone);
            command.Parameters.AddWithValue("@Address", contactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", contactInfo.CountryID);

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Updata Contact Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to Add Contact");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            //PrintAllContacts();

            // Parameters
            //PrintAllContactsWithFirstName("jane");
            //PrintAllContactsWithFirstNameAndCountry("jane" , 1);

            //Like Parameters
            //SearchContactsStartsWith("j");
            //SearchContactsEndsWith("ne");
            //SearchContainsWith("ae");

            // Retrieve a Single Value (ExecuteScalar)
            //Console.WriteLine(GetFirstName(1));


            stContact Contact = new stContact();

            //if(FindContactID(2, ref Contact))
            //{
            //    Console.WriteLine($"ID: {Contact.ID}");
            //    Console.WriteLine($"First Name: {Contact.FirstName}");
            //    Console.WriteLine($"Last Name: {Contact.LastName}");
            //    Console.WriteLine($"Email: {Contact.Email}");
            //    Console.WriteLine($"Phone: {Contact.Phone}");
            //    Console.WriteLine($"Address: {Contact.Address}");
            //    Console.WriteLine($"CountryID: {Contact.CountryID}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}


            //Insert 
            stContact contactInfo = new stContact
            {
                FirstName = "Mohamed",
                LastName = "Mostafa",
                Email = "Emai@Gmail.com",
                Phone = "01010721434",
                Address = "New Assuit City",
                CountryID =1
            };

            //AddNewContact(contactInfo);

            UpdataContact(1, contactInfo);

            Console.ReadKey();
        }
    }
}
