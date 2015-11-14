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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // 14
                DateTime lvd = this.LastVisitDate.Value;
                DateTime lsd = this.LastServiceDate.Value;
                DateTime dob = this.DateOfBirth.Value;
                string myConn = "datasource=localhost;port=3306;username='root';password=''";
                string Querry = "update aus_work.user set FirstName='"+ this.FirstName.Text + 
                                "',LastName='" + this.LastName.Text + 
                                "',PreferedName='"+ this.PreferedName.Text +
                                "',Address='" + this.Address.Text + 
                                "',Suburb='" + this.Suburb.Text +
                                "',State='"+ this.State.Text +
                                "',PostCode='" + this.PostCode.Text + 
                                "',Country='" + this.Country.Text + 
                                "',HomePhone='"+ this.HomePhone.Text + 
                                "',WorkPhone='" + this.WorkPhone.Text + 
                                "',Mobile='" + this.Mobile.Text +
                                "',Fax='" + this.FaxNumber.Text + 
                                "',Email='" + this.EmailId.Text + 
                                "',SkinType='" + this.SkinType.Text +
                                "',FacialType='" + this.FacialType.Text + 
                                "',HairType='" + this.HairType.Text +
                                "',DateOfBirth='" + dob.ToString("dd-MM-yyyy") +
                                "',LastServiceDate='" + lsd.ToString("dd-MM-yyyy") +
                                "',LastVisitDate='" + lvd.ToString("dd-MM-yyyy") + 
                                "',LastColorNumber='" + this.LastColorNumber.Text + 
                                "',ProductBuy1='" + this.ProductBuy1.Text +
                                "',ProductBuy2='" + this.ProductBuy2.Text + 
                                "',DiscountGiven='" + this.DiscountGiven.Text +
                                "',SpecialTreatment='" + this.SpecialTreatment.Text + 
                                "',Allergies='" + this.Allergies.Text + 
                                "' where IdNo='"+this.userid.Text+"';";
                MySqlConnection conn = new MySqlConnection(myConn);
                /*MySqlDataAdapter myDataadapter = new MySqlDataAdapter();
                myDataadapter.SelectCommand = new MySqlCommand(Querry, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataadapter);*/
                MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
                MySqlDataReader datareader;
                conn.Open();
                datareader = cmddatabase.ExecuteReader();
                MessageBox.Show("data Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {
            
            string myConn = "datasource=localhost;port=3306;username='root';password=''";
            string Querry = "select * from aus_work.user where IdNo= '"+this.userid.Text+"';";
            MySqlConnection conn = new MySqlConnection(myConn);
            //MySqlCommand cmddatabase = new MySqlCommand(Querry, conn);
            MySqlDataAdapter dataadap = new MySqlDataAdapter(Querry, conn);
            conn.Close();
            DataTable userdatatable = new DataTable();
            dataadap.Fill(userdatatable);
            FirstName.Text = userdatatable.Rows[0].ItemArray[1].ToString();
            LastName.Text = userdatatable.Rows[0].ItemArray[2].ToString();
            PreferedName.Text = userdatatable.Rows[0].ItemArray[3].ToString();
            
            Address.Text = userdatatable.Rows[0].ItemArray[4].ToString();
            Suburb.Text = userdatatable.Rows[0].ItemArray[5].ToString();
            State.Text = userdatatable.Rows[0].ItemArray[6].ToString();
            PostCode.Text = userdatatable.Rows[0].ItemArray[7].ToString();
            Country.Text = userdatatable.Rows[0].ItemArray[8].ToString();
            HomePhone.Text = userdatatable.Rows[0].ItemArray[9].ToString();
            WorkPhone.Text = userdatatable.Rows[0].ItemArray[10].ToString();
            Mobile.Text = userdatatable.Rows[0].ItemArray[11].ToString();
            FaxNumber.Text = userdatatable.Rows[0].ItemArray[12].ToString();
            EmailId.Text = userdatatable.Rows[0].ItemArray[13].ToString();
            SkinType.Text = userdatatable.Rows[0].ItemArray[14].ToString();
            HairType.Text = userdatatable.Rows[0].ItemArray[15].ToString();
            FacialType.Text = userdatatable.Rows[0].ItemArray[16].ToString();
            var dob = userdatatable.Rows[0].ItemArray[17].ToString();
            DateOfBirth.Value = System.Convert.ToDateTime(dob);
            
            var lsd = userdatatable.Rows[0].ItemArray[18].ToString();
            LastServiceDate.Value = System.Convert.ToDateTime(lsd);

            var lvd = userdatatable.Rows[0].ItemArray[19].ToString();
            LastVisitDate.Value = System.Convert.ToDateTime(lvd);

            LastColorNumber.Text = userdatatable.Rows[0].ItemArray[20].ToString();
            ProductBuy1.Text = userdatatable.Rows[0].ItemArray[21].ToString();
            ProductBuy2.Text = userdatatable.Rows[0].ItemArray[22].ToString();
            DiscountGiven.Text = userdatatable.Rows[0].ItemArray[23].ToString();
            SpecialTreatment.Text = userdatatable.Rows[0].ItemArray[24].ToString();
            Allergies.Text = userdatatable.Rows[0].ItemArray[25].ToString();

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        
    }
}
