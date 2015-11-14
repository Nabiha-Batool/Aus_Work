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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        DataTable dt = new DataTable();
       
        //int i, j;
       
        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime lvd = this.LastVisitDate.Value;
                DateTime lsd = this.LastServiceDate.Value;
                DateTime dob = this.DateOfBirth.Value;
                string myConn = "datasource=localhost;port=3306;username='root';password=''";
                string Querry = "insert into aus_work.user (FirstName,LastName,PreferedName,DateOfBirth,Address,"+
                                 "Suburb,State,PostCode,Country,HomePhone,WorkPhone,Mobile,Fax,Email,SkinType,"+
                                 "FacialType,HairType,LastServiceDate,LastVisitDate,LastColorNumber,ProductBuy1,"+
                                 "ProductBuy2,DiscountGiven,SpecialTreatment,Allergies) values('"
                                +this.FirstName.Text+"','"+this.LastName.Text+"','"+this.PreferedName.Text+"','"
                                +dob.ToString("dd-MM-yyyy")+"','"+this.Address.Text+"','"+this.Suburb.Text+"','"
                                +this.State.Text+"','"+this.PostCode.Text+"','"+this.Country.Text+"','"
                                +this.HomePhone.Text+"','"+this.WorkPhone.Text+"','"+this.Mobile.Text+"','"
                                +this.FaxNumber.Text+"','"+this.EmailId.Text+"','"+this.SkinType.Text+"','"
                                +this.FacialType.Text+"','"+this.HairType.Text+"','"+lsd.ToString("dd-MM-yyyy")+"','"
                                +lvd.ToString("dd-MM-yyyy")+"','"+this.LastColorNumber.Text+"','"+this.ProductBuy1.Text+
                                "','"+this.ProductBuy2.Text+"','"+this.DiscountGiven.Text+"','"+this.SpecialTreatment.Text
                                +"','"+this.Allergies.Text+"');";
                MySqlConnection conn = new MySqlConnection(myConn);
                /*MySqlDataAdapter myDataadapter = new MySqlDataAdapter();
                myDataadapter.SelectCommand = new MySqlCommand(Querry, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataadapter);*/
                MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
                MySqlDataReader datareader;
                conn.Open();
                datareader = cmddatabase.ExecuteReader();
                MessageBox.Show("datasaved");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Close();
            

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
            Form2 searcheddata = new Form2();
            searcheddata.Show();
            /*try
            {
                int userid = System.Convert.ToInt16(this.SearchLabel.Text);
                //DateTime dob = System.Convert.ToDateTime(this.SearchLabel.Text);
                string myConn = "datasource=localhost;port=3306;username='root';password=''";
                string Querry = "select * from aus_work.user where FirstName='" 
                                + this.SearchLabel.Text + "'or LastName='" + this.SearchLabel.Text + 
                                "'or IdNo='" + userid + "';";
                MySqlConnection conn = new MySqlConnection(myConn);
                /*MySqlDataAdapter myDataadapter = new MySqlDataAdapter();
                myDataadapter.SelectCommand = new MySqlCommand(Querry, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataadapter);
                MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
                MySqlDataReader datareader;
                conn.Open();
                datareader = cmddatabase.ExecuteReader();
                if (datareader != null)
                {
                    

                    //MessageBox.Show("data Found");
                }
                else
                {
                    MessageBox.Show("data NOT Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();*/
        }

        

        
    }
}
