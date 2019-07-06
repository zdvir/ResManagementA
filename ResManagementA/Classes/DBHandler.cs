using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ResManagement.Classes
{
    class DBHandler
    {
        private SqlConnection connection;
        private SqlCommand sqlcmd;

        private String USER_TABLE = "UserTable";
        private String ORDERS_TABLE = "OrdersTable";
        private String MODE_TABLE = "ModeTable";
        private String ORDERS_HISTORY_TABLE = "OrdersHistoryTable";

        public DBHandler()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=HP2560P-DVIR\DVIRSQL;Initial Catalog=Restaurant;Integrated Security=SSPI;";
                connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Can not open connection!" + exception);
            }
        }

        //Properties for Connection attribute
        public SqlConnection Connection { get => connection; set => connection = value; }

        //Get product list by table
        public List<Product> GetProductList(String tableName)
        {
            List<Product> list = new List<Product>();
            try
            {              
                sqlcmd = new SqlCommand("SELECT * FROM " + tableName, connection);
                SqlDataReader reader = sqlcmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Product(reader[0].ToString(), reader[1].ToString(), (Int32)reader[2], (Int32)reader[3], (byte[])reader[4]));
                }
                reader.Close();           
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return list;
        }

            //Update Product details by table
            public int UpdateProduct(String tableName, Product product)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "UPDATE " + tableName + " SET Quantity=@stocks, Price=@price, Image=@image WHERE ID=@id";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@id", product.Id));
                cmd.Parameters.Add(new SqlParameter("@stocks", product.Stocks));
                cmd.Parameters.Add(new SqlParameter("@price", product.Price));
                cmd.Parameters.Add(new SqlParameter("@image", product.Image));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return x;
        }

        //Create New user in DB - Admin or Employee
        public int CreateNewUser(User user)
        {
            String query;
            SqlCommand cmd;
            int x = 0;

            if (IsUserExists(user))
            {
                return x = 0;
            }

            try
            {
                query = "INSERT INTO " + USER_TABLE + " VALUES (@username,@password,@permission,@firstname,@lastname,@email,@phonenumber,@age)";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", user.UserName));
                cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                cmd.Parameters.Add(new SqlParameter("@permission", user.Permission));
                cmd.Parameters.Add(new SqlParameter("@firstname", user.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lastname", user.LastName));
                cmd.Parameters.Add(new SqlParameter("@email", user.Email));
                cmd.Parameters.Add(new SqlParameter("@phonenumber", user.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@age", user.Age));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return x;
        }

        //Check if User Exists in the DB
        public bool IsUserExists(User user)
        {
            String query;
            SqlCommand cmd;
            int x = 0;

            try
            {
                query = "SELECT COUNT(*) FROM " + USER_TABLE + " WHERE Username=@username";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", user.UserName));
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (x == 1)
                return true;
            else
                return false;
        }

        //Check if the username and password match to the DB registery
        public bool IsCorrectUsernameAndPassword(String username, String password)
        {
            String query;
            SqlCommand cmd;
            int x=0;
            try
            {

                query = "SELECT COUNT(*) FROM " + USER_TABLE + " WHERE username=@username AND password=@password";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                x = (int)cmd.ExecuteScalar();//get the first column in the first row
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            if (x == 1)
                return true;
            else
                return false;
        }

        //Get product list by table
        public List<User> GetUsersList()
        { 
            List<User> list = new List<User>();
            try
            {
                sqlcmd = new SqlCommand("SELECT * FROM " + USER_TABLE, connection);
                SqlDataReader reader = sqlcmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new User(reader[0].ToString(), reader[1].ToString(), (Int32)reader[2], reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), (Int32)reader[6], (Int32)reader[7]));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }

        //Update User details
        public int UpdateUser(User user)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "UPDATE " + USER_TABLE + " SET Password=@password, Permission=@permission, Firstname=@firstname, Lastname=@lastname, Email=@email, PhoneNumber=@phonenumber, Age=@age WHERE Username=@username";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", user.UserName));
                cmd.Parameters.Add(new SqlParameter("@password", user.Password));
                cmd.Parameters.Add(new SqlParameter("@permission", user.Permission));
                cmd.Parameters.Add(new SqlParameter("@firstname", user.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lastname", user.LastName));
                cmd.Parameters.Add(new SqlParameter("@email", user.Email));
                cmd.Parameters.Add(new SqlParameter("@phonenumber", user.PhoneNumber));
                cmd.Parameters.Add(new SqlParameter("@age", user.Age));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return x;
        }

        //Check if the current user is Admin or Employee
        public bool IsAdmin(String username)
        {
            String query;
            SqlCommand cmd;
            int permission = 0;
            try
            {
                query = "SELECT COUNT(*) FROM " + USER_TABLE + " WHERE Username=@username AND Permission=1";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", username));

                permission = (int)cmd.ExecuteScalar();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            if (permission == 1) // Admin=1, Employee=0
                return true;
            else
                return false;
        }

        //Create New Order in DB 
        public int CreateNewOrder(Order[] orderList)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                for (int i = 0; i < orderList.Length; i++)
                {
                    if (orderList[i] != null)
                    {
                        query = "INSERT INTO " + ORDERS_TABLE + " VALUES (@tableId,@employee,@productName,@quantity,@price)";
                        cmd = new SqlCommand(query, Connection);
                        cmd.Parameters.Add(new SqlParameter("@tableId", orderList[i].TableID));
                        cmd.Parameters.Add(new SqlParameter("@employee", orderList[i].Employee));
                        cmd.Parameters.Add(new SqlParameter("@productName", orderList[i].ProductName));
                        cmd.Parameters.Add(new SqlParameter("@quantity", orderList[i].Quantity));
                        cmd.Parameters.Add(new SqlParameter("@price", orderList[i].Price));
                        x = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return x;
        }

        //Create New Order in DB 
        public int ToOrdersHistory(int tableID)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "INSERT INTO " + ORDERS_HISTORY_TABLE + " SELECT * FROM " + ORDERS_TABLE + " WHERE TableID=@tableId";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@tableId", tableID));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return x;
        }

        //Return New User Object
        public User GetUserDetails(String username)
        {
            String query;
            SqlCommand cmd;
            User user = null;

            try
            {
                query = "SELECT * FROM " + USER_TABLE + " WHERE Username=@username";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", username));

                SqlDataReader reader = cmd.ExecuteReader();
       
                if (reader.Read())
                {
                    user = new User(username, reader[1].ToString(), (int)reader[2], reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), (int)reader[6], (int)reader[7]);
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return user;
        }
 
        //Delete User from Users List
        public int DeleteUser(String username)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "DELETE FROM " + USER_TABLE + " WHERE Username=@username";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@username", username));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return x;
        }

        //Delete Order in DB 
        public int DeleteOrder(int tableID)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "DELETE FROM " + ORDERS_TABLE + " WHERE TableID=@tableId";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@tableId", tableID));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return x;
        }
        
        //return Orders List
        public List<Order> GetOrdersList(int tableId)
        {
            List<Order> orderList = new List<Order>();
            String query;
            SqlCommand cmd;

            try
            {
                //Get all the Orders from the DB
                query = "SELECT * FROM " + ORDERS_TABLE + " WHERE TableID=@tableID";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@tableId", tableId));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orderList.Add(new Order(tableId, reader[1].ToString(),
                                            reader[2].ToString(), (int)reader[3], (int)reader[4]));
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return orderList;
        }

        //Return Table Mode (Free or Occupied)
        public String GetTableMode(int tableId)
        {
            String mode = null;
            String query;
            SqlCommand cmd;

            try
            {
                //Get the Table mode from the DB
                query = "SELECT * FROM " + MODE_TABLE + " WHERE TableID=@tableID";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@tableId", tableId));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mode = reader[1].ToString();
                    reader.Close();
                }
                //If it not appear at the DB - Create new row  
                else
                {
                    reader.Close();
                    query = "INSERT INTO " + MODE_TABLE + " VALUES (@tableId,@mode)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add(new SqlParameter("@tableId", tableId));
                    cmd.Parameters.Add(new SqlParameter("@mode", "NEW_ORDER"));
                    cmd.ExecuteNonQuery();
                    mode = "NEW_ORDER";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return mode;
        }

        //Update the Table Mode (Free -> Occupied OR Occupied -> Free)
        public void UpdateTableMode(int tableId, String tableMode)
        {
            String query;
            SqlCommand cmd;
            int x = 0;
            try
            {
                query = "UPDATE " + MODE_TABLE + " SET Mode=@mode WHERE TableID=@id";
                cmd = new SqlCommand(query, Connection);
                cmd.Parameters.Add(new SqlParameter("@id", tableId));
                cmd.Parameters.Add(new SqlParameter("@mode", tableMode));
                x = cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        //Returns the Order History List
        public List<Order> GetOrdersHistory()
        {
            List<Order> list = new List<Order>();
            String query;
            SqlCommand cmd;

            try
            {//Get all the Orders from the DB
                query = "SELECT * FROM " + ORDERS_HISTORY_TABLE;
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Order((int)reader[0], reader[1].ToString(),
                                            reader[2].ToString(), (int)reader[3], (int)reader[4]));
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return list;
        }


        public List<Order> GetOrdersCounting()
        {
            List<Order> list = new List<Order>();
            String query;
            SqlCommand cmd;

            try
            {
                //Get all the Orders from the DB
                query = "SELECT Product,Sum(Quantity),Price FROM " + ORDERS_HISTORY_TABLE + " GROUP BY Product,Price";
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Instead TableID I will save the quantity*price
                    list.Add(new Order(((int)reader[1]) * ((int)reader[2]), "", reader[0].ToString(), (int)reader[1], (int)reader[2]));
                }
                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return list;
        }

        //Returns The Sales grouped by Employes
        public List<Order> GetEmployeeSales()
        {
            List<Order> list = new List<Order>();
            String query;
            SqlCommand cmd;

            try
            {
                //Get all the Orders from the DB
                query = "SELECT Employee,Sum(Quantity),Sum(Price) FROM " + ORDERS_HISTORY_TABLE + " GROUP BY Employee";
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Order(0, reader[0].ToString(), "", (int)reader[1], (int)reader[2]));
                }

                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return list;
        }

        //Returns Sales Sorting by TableID order
        public List<Order> GetTableSales()
        {
            List<Order> list = new List<Order>();
            String query;
            SqlCommand cmd;

            try
            {
                //Get all the Orders from the DB
                query = "SELECT TableID,Sum(Quantity),Sum(Price) FROM " + ORDERS_HISTORY_TABLE + " GROUP BY TableID";
                cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Order((int)reader[0], "", "", (int)reader[1], (int)reader[2]));
                }

                reader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return list;
        }

    }
}
