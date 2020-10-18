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

namespace oop_6115261003_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void butCDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "delete from customer where c_frist_name'" + this.txtCfn.Text + "',c_last_name'" + this.txtCln.Text + "',c_nick_name'" + this.txtCnn.Text + "',c_age'" + this.txtCAge.Text + "',c_phone'" + this.txtCPhone.Text + "',c_address'" + this.txtCAddress.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Deleted");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butCAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "insert into customer(c_frist_name,c_last_name,c_nick_name,c_age,c_phone,c_address) " +
                    "values('" + this.txtCfn.Text + "','" + this.txtCln.Text + "','" + this.txtCnn.Text + "','" + this.txtCAge.Text + "','" + this.txtCPhone.Text + "','" + this.txtCAddress.Text + "');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butCEdit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";


                string Query = "update customer set c_frist_name='" + this.txtCfn.Text + "',c_last_name='" + this.txtCln.Text + "',c_nick_name='" + this.txtCnn.Text + "',c_age='" + this.txtCAge.Text + "',c_phone='" + this.txtCPhone.Text + "',c_address='" + this.txtCAddress.Text + "'" + "' where c_id'" + this.txtCId.Text + "';";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Data Updated");

                while (MyReader2.Read())
                {



                }

                MyConn2.Close();//Connection closed here 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }

        private void butCDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";
                string Query = "select * from customer;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                dataGridView1.DataSource = dTable;



                // MyConn2.Close(); 

            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);

            }
        }
    }
}
