using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Data;
using System.Net.Http.Headers; // Data Provider

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
        static void UpdataContact(int ContactIDToUpdate , stContact contactInfo)
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

            command.Parameters.AddWithValue("@ContactID", ContactIDToUpdate);
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
                    Console.WriteLine("Failed to update Contact");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DeleteContact(int ContactIDToDelete)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"Delete from  Contacts 
                              where ContactID = @ContactID ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactIDToDelete);
         

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Record Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to Delete Contact");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void DeleteContactsUseIn(string Contacts)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string Query = @"Delete from  Contacts 
                              where ContactID in (" + Contacts +")";

            SqlCommand command = new SqlCommand(Query, connection);
         

            try
            {
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    Console.WriteLine("Record Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Failed to Delete Contact");
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

            //UpdataContact(1, contactInfo);

            //DeleteContact(1);

            //DeleteContactsUseIn("9,8");


            //DataTable
            DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");

            EmployeesDataTable.Columns.Add("ID" , typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "Mohamed Mostafa", "Egypt", 10000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Ahmed Ali", "US", 8500, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Omar Hassan", "UK", 12000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Youssef Mahmoud", "Egypt", 9500, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Mostafa Ibrahim", "US", 11000, DateTime.Now);


            int EmployeesCount = 0;
            double TotalSalaly = 0;
            double AverageSalaly = 0;
            double MinSalaly = 0;
            double MaxSalaly = 0;

            EmployeesCount = EmployeesDataTable.Rows.Count;
            TotalSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Sum(Salary)", string.Empty));
            AverageSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Avg(Salary)", string.Empty));
            MinSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", string.Empty));
            MaxSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", string.Empty));

            foreach (DataRow Row in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID: {0}   Name: {1}       Country: {2}         Salary: {3}           Date: {4}", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);
            }

            Console.WriteLine();

            Console.WriteLine("Employees Count: " + EmployeesCount);
            Console.WriteLine("Total Salary: " + TotalSalaly);
            Console.WriteLine("Average Salary: " + AverageSalaly);
            Console.WriteLine("Minimum Salary: " + MinSalaly);
            Console.WriteLine("Maximum Salary: " + MaxSalaly);


            //Filter 
            DataRow[] ResultRows = EmployeesDataTable.Select("Country = 'Egypt' or Country = 'US'");

            Console.WriteLine("\nAfter Filter..... \n");
            foreach (DataRow row in ResultRows)
            {
                Console.WriteLine("ID: {0}   Name: {1}       Country: {2}         Salary: {3}           Date: {4}", row[0], row[1], row[2], row[3], row[4]);
            }

            EmployeesCount = ResultRows.Count();
            TotalSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Sum(Salary)", "Country = 'Egypt' or Country = 'US'"));
            AverageSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Avg(Salary)", "Country = 'Egypt' or Country = 'US'"));
            MinSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country = 'Egypt' or Country = 'US'"));
            MaxSalaly = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country = 'Egypt' or Country = 'US'"));

            Console.WriteLine();

            Console.WriteLine("Employees Count: " + EmployeesCount);
            Console.WriteLine("Total Salary: " + TotalSalaly);
            Console.WriteLine("Average Salary: " + AverageSalaly);
            Console.WriteLine("Minimum Salary: " + MinSalaly);
            Console.WriteLine("Maximum Salary: " + MaxSalaly);


            // Sorting 

            Console.WriteLine();
            EmployeesDataTable.DefaultView.Sort = "Name Asc";
            EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();

            //EmployeesDataTable.DefaultView.Sort = "ID desc";
            //EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();

            Console.WriteLine("\nAfter Sorting By ID DESC..... \n");
            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine(" ID: {0}\n Name: {1}\n Country: {2}\n Salary: {3}\n Date: {4}\n", row[0], row[1], row[2], row[3], row[4]);
            }


            //Delete
            DataRow[] rows = EmployeesDataTable.Select("ID = 3");
            foreach(var row in rows)
            {
                row.Delete();
            }
            EmployeesDataTable.AcceptChanges();

            Console.WriteLine("\nAfter Delete By ID..... \n");
            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n", row[0], row[1], row[2], row[3], row[4]);
            }


            //Update 
            DataRow[] Rows = EmployeesDataTable.Select("ID = 1");
            foreach(var row in Rows)
            {
                row["Name"] = "KOKO";
            }
            EmployeesDataTable.AcceptChanges();

            Console.WriteLine("\nAfter Update By ID ..... \n");
            foreach (DataRow row in EmployeesDataTable.Rows)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n", row[0], row[1], row[2], row[3], row[4]);
            }

            //Clear all Data
            //EmployeesDataTable.Clear();


            // Create Primary Key
            DataColumn[] PrimaryKeyColumn = new DataColumn[1]; // only one PrimaryKey
            PrimaryKeyColumn[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey = PrimaryKeyColumn;


            // Autoincrement and Others
            DataTable dtPersonTable = new DataTable("dtPersonTable");
            DataColumn dtColumn = new DataColumn();

            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;

            dtColumn.Caption = "PersonID";
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            dtPersonTable.Columns.Add(dtColumn);


            dtColumn = new DataColumn();

            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dtColumn.Caption = "Name";
            dtPersonTable.Columns.Add(dtColumn);

            DataColumn[] PrimaryKeyColumnPerson = new DataColumn[1];
            PrimaryKeyColumnPerson[0] = dtPersonTable.Columns["ID"];
            dtPersonTable.PrimaryKey = PrimaryKeyColumnPerson;

            dtPersonTable.Rows.Add(null, "Mohamed Mostafa");
            dtPersonTable.Rows.Add(null, "Ali Mostafa");
            dtPersonTable.Rows.Add(null, "Marwan Mostafa");
            dtPersonTable.Rows.Add(null, "Hamada Mostafa");
            dtPersonTable.Rows.Add(null, "KoKo Mostafa");

            Console.WriteLine("\nDtPreson  ..... \n");
            foreach (DataRow row in dtPersonTable.Rows)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t", row[0], row[1]);
            }


            // Dataview 
            Console.WriteLine();

            DataView EmployeesDataView = EmployeesDataTable.DefaultView;
            for (int i = 0; i < EmployeesDataView.Count; i++)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n",
                    EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
            }

            //Filter DataView

            Console.WriteLine();
            Console.WriteLine("After Filer......");
            EmployeesDataView.RowFilter = "Country = 'Egypt'";
            for (int i = 0; i < EmployeesDataView.Count; i++)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n",
                    EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
            }


            //Sorting DataView

            Console.WriteLine();
            Console.WriteLine("After Sorting......");
            EmployeesDataView.Sort = "Name ASC";
            for (int i = 0; i < EmployeesDataView.Count; i++)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n",
                    EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
            }


            //DataSet

            Console.WriteLine();
            Console.WriteLine("Create DataSet......");

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(EmployeesDataTable);
            dataSet.Tables.Add(dtPersonTable);

            Console.WriteLine("\nEmployeesDataTable  ..... \n");
            foreach (DataRow row in dataSet.Tables["EmployeesDataTable"].Rows)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date: {4}\n", row[0], row[1], row[2], row[3], row[4]);
            }

            Console.WriteLine("\nDtPreson  ..... \n");
            foreach (DataRow row in dataSet.Tables["dtPersonTable"].Rows)
            {
                Console.WriteLine(" ID: {0}\t Name: {1}\t", row[0], row[1]);
            }



            Console.ReadKey();
        }
    }
}
