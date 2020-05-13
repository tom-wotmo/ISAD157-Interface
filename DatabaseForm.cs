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

namespace SOFT562Week18
{
    public partial class FacebookDatabase : Form
    {
        public FacebookDatabase()
        {
            InitializeComponent();
        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.user";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable userDataTable = new DataTable();
                    sqlDA.Fill(userDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewUser.DataSource = userDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            else if (comboBoxQueryChoice.SelectedIndex == 1)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.friendship";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable friendshipDataTable = new DataTable();
                    sqlDA.Fill(friendshipDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewFriendship.DataSource = friendshipDataTable;
                }
            }
            else if (comboBoxQueryChoice.SelectedIndex == 2)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.message";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable messageDataTable = new DataTable();
                    sqlDA.Fill(messageDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewMessage.DataSource = messageDataTable;
                }
            }
            else if (comboBoxQueryChoice.SelectedIndex == 3)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.message database";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable messageDatabaseDataTable = new DataTable();
                    sqlDA.Fill(messageDatabaseDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewMessageDatabase.DataSource = messageDatabaseDataTable;
                }
            } // End of private void comboBoxQueryChoice_SelectedIndexChanged
            else if (comboBoxQueryChoice.SelectedIndex == 4)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.education";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable educationDataTable = new DataTable();
                    sqlDA.Fill(educationDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewEducation.DataSource = educationDataTable;
                }
            }
            else if (comboBoxQueryChoice.SelectedIndex == 5)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_twhatmough.workplace";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable workplaceDataTable = new DataTable();
                    sqlDA.Fill(workplaceDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewWorkplace.DataSource = workplaceDataTable;
                }
            }
        }
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
