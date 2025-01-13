using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Restaurant
{
    public partial class Form1 : Form
    {
        // Connection string to connect to the MySQL database
        private string connectionString = "Server=localhost;Database=RestaurantDB;User ID=root;Password=killgrave;";

        public Form1()
        {
            InitializeComponent();

            // Ensure SelectionMode is properly set
            listBoxMenu.SelectionMode = SelectionMode.MultiExtended;

            // Attach the event handler for selection changes
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;

        }






        private int selectedId; // Store the selected ID globally




        private void LoadCustomerData(int id)
        {
            string query = "SELECT CustomerID, Name, Phone, Email, Address FROM customers WHERE CustomerID = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate text boxes with the selected customer's data
                        textBoxName.Text = reader["Name"].ToString();
                        textBoxPhone.Text = reader["Phone"].ToString();
                        textBoxEmail.Text = reader["Email"].ToString();
                        textBoxAddress.Text = reader["Address"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Similar methods for Menu, Orders, and OrderDetails
        private void LoadMenuData(int id)
        {
            string query = "SELECT MenuID, Name, Price FROM menu WHERE MenuID = @id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Similarly for 'orders' and 'orderdetails' (you can customize the fields based on your requirements)




















        private void PopulateMenuItems()
        {
            string query = "SELECT MenuID, Name, Price FROM menu;"; // Query to fetch menu items

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Clear the list box
                    listBoxMenu.Items.Clear();

                    // Populate the list box with menu items
                    while (reader.Read())
                    {
                        var menuItem = new MenuItem
                        {
                            MenuID = reader.GetInt32("MenuID"),
                            Name = reader.GetString("Name"),
                            Price = reader.GetDouble("Price")
                        };
                        listBoxMenu.Items.Add(menuItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading menu items: {ex.Message}");
                }
            }
        }







        // Add customers to ComboBox
        private void PopulateComboBoxCustomers()
        {
            comboBoxCustomers.Items.Clear(); // Clear the ComboBox before adding new items
            string query = "SELECT CustomerID, Name FROM customers"; // Query to get all customer names

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // If no customers found, show an error
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No customers found in the database.");
                    }

                    // Add customers to ComboBox
                    foreach (DataRow row in dataTable.Rows)
                    {
                        comboBoxCustomers.Items.Add(new Customer
                        {
                            CustomerID = Convert.ToInt32(row["CustomerID"]),
                            Name = row["Name"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



        // When the form loads, populate the ComboBox with table names and customers
        private void Form1_Load(object sender, EventArgs e)
        {


            ToolStrip toolStrip = new ToolStrip();

            // Add a ToolStripButton
            ToolStripButton btnOpenWindow = new ToolStripButton("About Me");
            toolStrip.Items.Add(btnOpenWindow);

            // Attach the Click event
            btnOpenWindow.Click += toolStripButton1_Click;

            // Add the ToolStrip to the form
            this.Controls.Add(toolStrip);

            // Add table names to the ComboBox
            comboBoxTables.Items.Add("customers");
            comboBoxTables.Items.Add("menu");
            comboBoxTables.Items.Add("orders");
            comboBoxTables.Items.Add("orderdetails");

            // Optionally, set the first item as the default selection
            if (comboBoxTables.Items.Count > 0)
                comboBoxTables.SelectedIndex = 0; // Select the first table by default



        }

        // When button1 is clicked, test the database connection
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    // If connection fails, show the error
                    MessageBox.Show($"Connection failed: {ex.Message}");
                }
            }
        }

        // When button2 is clicked, load the data from the selected table
        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a table is selected
            if (comboBoxTables.SelectedItem == null)
            {
                MessageBox.Show("Please select a table first!");
                return;
            }

            // Get the selected table name
            string selectedTable = comboBoxTables.SelectedItem.ToString();

            // Query to fetch data from the selected table
            string query = $"SELECT * FROM {selectedTable};"; // Dynamic table selection

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a data adapter to execute the query
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                    // Create a DataTable to hold the query results
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the query results
                    dataAdapter.Fill(dataTable);

                    // Clear the DataGridView before displaying new data
                    dataGridView1.DataSource = null;

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Inform the user
                    MessageBox.Show($"Data from {selectedTable} loaded successfully!");
                }
                catch (Exception ex)
                {
                    // If an error occurs, show the error message
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            panelAddCustomer.Visible = true;
            panelCreateOrder.Visible = false;
        }

        private void savecustomerbutton_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string phone = Phone.Text;
            string email = Email.Text;
            string address = Address.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            string query = "INSERT INTO customers (Name, Phone, Email, Address) VALUES (@name, @phone, @email, @address);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@address", address);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!");
                        Name.Clear();
                        Phone.Clear();
                        Email.Clear();
                        Address.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (listBoxMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one menu item.");
                return;
            }

            int customerId = ((Customer)comboBoxCustomers.SelectedItem).CustomerID;
            double totalAmount = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    // Insert into orders table
                    string orderQuery = "INSERT INTO orders (CustomerID, OrderDate, TotalAmount) VALUES (@customerId, NOW(), @totalAmount);";
                    MySqlCommand orderCommand = new MySqlCommand(orderQuery, connection, transaction);

                    orderCommand.Parameters.AddWithValue("@customerId", customerId);

                    // Placeholder for total amount
                    orderCommand.Parameters.AddWithValue("@totalAmount", 0); // This will be updated later
                    orderCommand.ExecuteNonQuery();

                    // Get the generated OrderID
                    long orderId = orderCommand.LastInsertedId;

                    // Insert into orderdetails table
                    foreach (MenuItem selectedItem in listBoxMenu.SelectedItems)
                    {
                        int quantity = (int)numericUpDownQuantity.Value; // Get the quantity for this item
                        double subtotal = selectedItem.Price * quantity;

                        totalAmount += subtotal;

                        string detailQuery = "INSERT INTO orderdetails (OrderID, MenuID, Quantity, Subtotal) VALUES (@orderId, @menuId, @quantity, @subtotal);";
                        MySqlCommand detailCommand = new MySqlCommand(detailQuery, connection, transaction);

                        detailCommand.Parameters.AddWithValue("@orderId", orderId);
                        detailCommand.Parameters.AddWithValue("@menuId", selectedItem.MenuID);
                        detailCommand.Parameters.AddWithValue("@quantity", quantity);
                        detailCommand.Parameters.AddWithValue("@subtotal", subtotal);

                        detailCommand.ExecuteNonQuery();
                    }

                    // Update the total amount in the orders table
                    string updateOrderQuery = "UPDATE orders SET TotalAmount = @totalAmount WHERE OrderID = @orderId;";
                    MySqlCommand updateOrderCommand = new MySqlCommand(updateOrderQuery, connection, transaction);
                    updateOrderCommand.Parameters.AddWithValue("@totalAmount", totalAmount);
                    updateOrderCommand.Parameters.AddWithValue("@orderId", orderId);
                    updateOrderCommand.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show($"Order saved successfully! Total Amount: {totalAmount:C}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving order: {ex.Message}");
                }
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            panelAddCustomer.Visible = false;
            panelCreateOrder.Visible = true;


            PopulateComboBoxCustomers();
            PopulateMenuItems(); // Populate the ListBox with menu items
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            panelAddCustomer.Visible = false;
            panelCreateOrder.Visible = false;

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            double totalPrice = 0;

            // Calculate total price of selected items
            foreach (MenuItem selectedItem in listBoxMenu.SelectedItems)
            {
                totalPrice += selectedItem.Price;
            }

            // Display the total price in the label
            labelItemPrice.Text = $"Total Price: {totalPrice:C}"; // Format price as currency
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (listBoxData.SelectedItem == null)
            {
                MessageBox.Show("Please select a row to delete!");
                return;
            }

            // Extract the ID from the selected item in the ListBox
            string selectedItem = listBoxData.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            int id = Convert.ToInt32(parts[0].Trim());  // Assuming ID is the first part

            string tableName = comboBoxTables.SelectedItem.ToString();
            string idColumn = "";
            string deleteQuery = "";

            // Determine the table and column for deletion
            switch (tableName)
            {
                case "customers":
                    idColumn = "CustomerID";
                    // First, delete any dependent rows from the orders table
                    deleteQuery = "DELETE FROM orders WHERE CustomerID = @id"; // Deleting orders first
                    ExecuteQuery(deleteQuery, id);
                    break;
                case "menu":
                    idColumn = "MenuID";
                    break;
                case "orders":
                    idColumn = "OrderID";
                    break;
                case "orderdetails":
                    idColumn = "OrderDetailID";
                    break;
                default:
                    MessageBox.Show("Table not recognized.");
                    return;
            }

            // Now delete the row from the selected table
            deleteQuery = $"DELETE FROM {tableName} WHERE {idColumn} = @id";  // Assumes the primary key column
            ExecuteQuery(deleteQuery, id);

            // Refresh the ListBox after deletion
            buttonLoadData_Click_1(sender, e);

            MessageBox.Show("Row deleted successfully!");
        }

        private void ExecuteQuery(string query, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        // Customer class to hold customer data
        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Display name in ComboBox
            }
        }
        public class MenuItem
        {
            public int MenuID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

            public override string ToString()
            {
                return Name; // Display the item's name in the ListBox
            }
        }

        private void buttonLoadData_Click_1(object sender, EventArgs e)
        {
            if (comboBoxTables.SelectedItem == null)
            {
                MessageBox.Show("Please select a table first!");
                return;
            }

            string selectedTable = comboBoxTables.SelectedItem.ToString();
            string query = $"SELECT * FROM {selectedTable};"; // Dynamic table selection

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Clear the ListBox before adding new items
                    listBoxData.Items.Clear();

                    // Handle table-specific column names for display
                    string idColumn = "";
                    string nameColumn = "";

                    switch (selectedTable)
                    {
                        case "customers":
                            idColumn = "CustomerID";
                            nameColumn = "Name";
                            break;
                        case "menu":
                            idColumn = "MenuID";
                            nameColumn = "Name";
                            break;
                        case "orders":
                            idColumn = "OrderID";
                            nameColumn = "OrderDate";
                            break;
                        case "orderdetails":
                            idColumn = "OrderDetailID";
                            nameColumn = "MenuID"; // You may want to show a different column in orderdetails
                            break;
                        default:
                            MessageBox.Show("Table not recognized.");
                            return;
                    }

                    // Populate the ListBox with data from the selected table
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string displayText = $"{row[idColumn]} - {row[nameColumn]}";  // Customize based on your columns
                        listBoxData.Items.Add(displayText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim(); // Assuming a TextBox for search input
            string query = "SELECT CustomerID, Name FROM customers WHERE Name LIKE @name";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", $"%{searchText}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    listBoxsearch.DataSource = table;          // Set the data source to the DataTable
                    listBoxsearch.DisplayMember = "Name";      // The column to display in the ListBox
                    listBoxsearch.ValueMember = "CustomerID";  // The column containing the ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private List<string> SearchDatabase(string query, string searchTerm)
        {
            List<string> results = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    MySqlDataReader reader = command.ExecuteReader();

                    // Add each result to the list
                    while (reader.Read())
                    {
                        string row = $"{reader[0]} - {reader[1]}"; // Customize as needed
                        results.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            return results;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // Ensure that 'selectedId' is not the default value (e.g., 0 or -1)
            if (selectedId > 0)
            {
                string query = "UPDATE customers SET Name = @name, Phone = @phone, Email = @email, Address = @address WHERE CustomerID = @id";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", textBoxName.Text);
                        command.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                        command.Parameters.AddWithValue("@id", selectedId); // Use the stored selectedId
                        command.ExecuteNonQuery();

                        MessageBox.Show("Changes saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid customer first.");
            }
        }

        private void listBoxsearch_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBoxsearch.SelectedValue != null)
            {
                // Safely cast the selected value to an integer
                selectedId = Convert.ToInt32(listBoxsearch.SelectedValue);
                LoadCustomerData(selectedId); // Use the selected ID to load customer data
            }
            else
            {
                MessageBox.Show("No valid customer selected.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelAddCustomer.Visible = false;
            panelCreateOrder.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Open the new form
            Form2 newForm = new Form2();
            newForm.Show(); // Use ShowDialog() if you want it to be modal
        }
    }


    



}