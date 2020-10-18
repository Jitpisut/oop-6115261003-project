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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void butPDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";
                string Query = "select * from personnel;";
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

        private void butPAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "insert into personnel(p_frist_name,p_last_name,p_nick_name,p_age,p_phone,p_address) " +
                    "values('" + this.txtPfn.Text + "','" + this.txtPln.Text + "','" + this.txtPnn.Text + "','" + this.txtPAge.Text + "','" + this.txtPPhone.Text + "','" + this.txtPAddress.Text + "');";

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

        private void butPEdit_Click(object sender, EventArgs e)
        {
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";


                string Query = "update personnel set p_frist_name='" + this.txtPfn.Text + "',p_last_name='" + this.txtPln.Text + "',p_nick_name='" + this.txtPnn.Text + "',p_age='" + this.txtPAge.Text + "',p_phone='" + this.txtPPhone.Text + "',p_address='" + this.txtPAddress.Text + "'" + "' where p_id'" + this.txtPId.Text + "';";


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

        private void butPDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=miloku";

                string Query = "delete from personnel where p_frist_name'" + this.txtPfn.Text + "',p_last_name'" + this.txtPln.Text + "',p_nick_name'" + this.txtPnn.Text + "',p_age'" + this.txtPAge.Text + "',p_phone'" + this.txtPPhone.Text + "',p_address'" + this.txtPAddress.Text + "';";

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

        private void butPNext_Click(object sender, EventArgs e)
        {
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
        }
    }
}
