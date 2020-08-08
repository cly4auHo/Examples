using System;
using System.Data;
using System.Windows.Forms;

namespace _034_Load_from_Excsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ для загрузки данных";
            
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +ofd.FileName + ";Extended Properties='Excel 12.0 XML;HDR=YES;IMEX=1';";

            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(constr);
            connection.Open();

            DataSet dataSet = new DataSet();

            DataTable schemaTable = connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, 
                new object[] { null, null, null, "TABLE" });
            
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
            
            string select = string.Format("SELECT * FROM [{0}]", sheet1);

            System.Data.OleDb.OleDbDataAdapter ad = new System.Data.OleDb.OleDbDataAdapter(select, connection);
            ad.Fill(dataSet);
            
            DataTable dataTable = dataSet.Tables[0];
            
            connection.Close();
            connection.Dispose();
            
            dataGridView1.DataSource = dataTable;
        }
    }
}
