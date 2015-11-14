using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Aus_work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataViewControl();
            
            
        }
            DataTable userdatatable = new DataTable();
            

        public void DataViewControl()
        {
            string myConn = "datasource=localhost;port=3306;username='root';password=''";
            string Querry = "select * from aus_work.user;";
            MySqlConnection conn = new MySqlConnection(myConn);
            //MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
            MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
            conn.Close();
            DataTable userdatatablecontol = new DataTable();

            dataadap.Fill(userdatatablecontol);
            dataadap.Fill(userdatatable);
            dataGridView1.DataSource = userdatatablecontol;
        }

            
            
        
        private void Form2_Load(object sender, EventArgs e)
        {
           // Aus_work.Form1 form1 = new Aus_work.Form1();
            
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            if (this.SearchBox.Text != null)
            {
                
                string myConn = "datasource=localhost;port=3306;username='root';password=''";
                MySqlConnection conn = new MySqlConnection(myConn);

                if (this.SearchCatagoryBox.Text == "I'D")
                {
                    int userid = System.Convert.ToInt16(this.SearchBox.Text);
                    string Querry = "select * from aus_work.user where IdNo='" + userid + "';";
                    MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
                    conn.Close();
                    DataTable useriddatatable = new DataTable();
                    
                    dataadap.Fill(useriddatatable);
                    dataGridView1.DataSource = useriddatatable;
                }
                else if (this.SearchCatagoryBox.Text == "First Name")
                {
                    string Querry = "select * from aus_work.user where FirstName='"
                                        + this.SearchBox.Text + "';";
                    MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
                    conn.Close();
                    DataTable userfirstnamedatatable = new DataTable();
                    dataadap.Fill(userfirstnamedatatable);
                    dataGridView1.DataSource = userfirstnamedatatable;
                }
                else if (this.SearchCatagoryBox.Text == "Last Name")
                {
                    string Querry = "select * from aus_work.user where LastName='"
                                        + this.SearchBox.Text + "';";
                    MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
                    conn.Close();
                    DataTable userlastnamedatatable = new DataTable();
                    dataadap.Fill(userlastnamedatatable);
                    dataGridView1.DataSource = userlastnamedatatable;
                }
                else if (this.SearchCatagoryBox.Text == "Date Of Birth")
                {
                    DateTime dob = this.dateTimePicker1.Value;
                    string Querry = "select * from aus_work.user where DateOfBirth='" + dob.ToString("dd-MM-yyyy") + "';";
                    MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
                    conn.Close();
                    DataTable usedobrdatatable = new DataTable();
                    dataadap.Fill(usedobrdatatable);
                    dataGridView1.DataSource = usedobrdatatable;
                    
                   
                }

            }
            else
            {

            }
            
            
            

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
            
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            DataViewControl();
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            try
            {

                var rownumber = dataGridView1.CurrentCell.RowIndex;
                var userid = userdatatable.Rows[rownumber].ItemArray[0].ToString();
                int userdelid = System.Convert.ToInt16(userid);
                userdatatable.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                dataGridView1.DataSource = userdatatable;
                string myConn = "datasource=localhost;port=3306;username='root';password=''";
                MySqlConnection conn = new MySqlConnection(myConn);
                string Querry = "delete from aus_work.user where IdNo='" +userdelid+ "'; ";
               // MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
                
                
                
                
                MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
                MySqlDataReader datareader;
                conn.Open();
                datareader = cmddatabase.ExecuteReader();
                MessageBox.Show("Data Deleted");
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);

            }
        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.Show();
            
            DataViewControl();
            
        }

    }
}
