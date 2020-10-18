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
    public partial class Milk : Form
    {
        public Milk()
        {
            InitializeComponent();
        }

        private void butMDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";
                string Query = "select * from drink;";
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

        private void butMAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "insert into drink(d_name,d_price) " +
                    "values('" + this.txtMName.Text + "','" + this.txtMPrice.Text + "');";

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

        private void butMEdit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";


                string Query = "update drink set d_name='" + this.txtMName.Text + "',d_price='" + this.txtMPrice.Text + "'" + "' where d_id'" + this.txtMId.Text + "';";


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

        private void butMDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "delete from drink where d_name'" + this.txtMName.Text + "',d_price'" + this.txtMPrice.Text + "';";

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";


                string Query = "update drink set d_name='" + this.txtMName.Text + "',d_price='" + this.txtMPrice.Text + "'" + "' where d_id'" + this.txtMId.Text + "';";


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

        private void butMNext_Click(object sender, EventArgs e)
        {
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
}
