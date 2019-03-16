using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlLibrary;

namespace SqlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlManager sqlManager = new SqlManager();
        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TutorialDatabase_data.mdf;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlManager.CreateDatabase("TutorialDatabase", "", "");

            List<string> List_of_Coloumns = new List<string>();
            List_of_Coloumns.Add("[index] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY ");
            List_of_Coloumns.Add("[FirstName] [varchar](100) NULL");
            List_of_Coloumns.Add("[LastName] [varchar](100) NULL");
            List_of_Coloumns.Add("[Adress] [varchar](100) NULL");
            List_of_Coloumns.Add("[RFID] [varchar](100) NULL");

            sqlManager.CreateTable("Employees", List_of_Coloumns, ConnString);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            List<Tuple<dynamic, dynamic>> ColoumnName_ValueToInsert = new List<Tuple<dynamic, dynamic>>();
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("FirstName", txt_FirstName.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("LastName", txt_LastName.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("Adress", txt_Adress.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("RFID", txt_UID.Text));
            sqlManager.Insert(ColoumnName_ValueToInsert, "Employees", ConnString);

            
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Adress.Text = "";
            txt_UID.Text = "";
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlConnection con = null;

            try
            {
                string query = "SELECT * FROM Employees";

                con = new SqlConnection(ConnString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                employees.Clear();
                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt16(dr["index"]);
                    employee.FirstName = dr["FirstName"].ToString();
                    employee.LastName = dr["LastName"].ToString();
                    employee.Adress = dr["Adress"].ToString();
                    employee.RFID = dr["RFID"].ToString();
                    employees.Add(employee);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return employees;
        }

        List<Employee> employees = new List<Employee>();

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = sqlManager.BindGridView("Employees", ConnString);
            comboBox1.DataSource = GetEmployees();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = comboBox1.SelectedItem as Employee;
            txt_ID_1.Text = employee.Id.ToString();
            txt_FirstName_1.Text = employee.FirstName;
            txt_LastName_1.Text = employee.LastName;
            txt_Adress_1.Text = employee.Adress;
            txt_UID_1.Text = employee.RFID;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            List<Tuple<dynamic, dynamic>> ColoumnName_ValueToInsert = new List<Tuple<dynamic, dynamic>>();
            List<Tuple<dynamic, dynamic>> ColoumnName_ValueToMatch = new List<Tuple<dynamic, dynamic>>();
            ColoumnName_ValueToMatch.Add(new Tuple<dynamic, dynamic>("index", Convert.ToInt16(txt_ID_1.Text)));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("FirstName", txt_FirstName_1.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("LastName", txt_LastName_1.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("Adress", txt_Adress_1.Text));
            ColoumnName_ValueToInsert.Add(new Tuple<dynamic, dynamic>("RFID", txt_UID_1.Text));


            sqlManager.Update(ColoumnName_ValueToInsert, ColoumnName_ValueToMatch, "Employees", ConnString);



        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<Tuple<dynamic, dynamic>> ColoumnName_ValueToMatch = new List<Tuple<dynamic, dynamic>>();
            ColoumnName_ValueToMatch.Add(new Tuple<dynamic, dynamic>("index", Convert.ToInt16(txt_ID_1.Text)));
            sqlManager.Delete(ColoumnName_ValueToMatch, "Employees", ConnString);
        }

        private void btn_CreateBackup_Click(object sender, EventArgs e)
        {
            sqlManager.Backup(ConnString);
        }

        private void btn_LoadBackup_Click(object sender, EventArgs e)
        {
            sqlManager.Restore(ConnString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlManager.ExecuteSqlCommand(txt_ExecuteCmd.Text, ConnString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlManager.DeleteDatabase("TutorialDatabase", ConnString);
        }
    }
}
