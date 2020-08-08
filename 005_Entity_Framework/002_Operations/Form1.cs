using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace _002_Operations
{
    public partial class Form1 : Form
    {
        private ProductDB db;
        public Form1()
        {
            InitializeComponent();

            Database.SetInitializer(new DropCreateDatabaseAlways<ProductDB>());
            db = new ProductDB();
        }

        /// <summary>
        ///Обработчик нажатия кнопки добавить
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Текстовые поля не заполнены !");
                return;
            }

            Product product = new Product
            {
                Name = textBox1.Text,
                Price = Convert.ToInt32(textBox2.Text),
                Manufacturer = textBox3.Text
            };

            db.Products.Add(product);

            db.SaveChanges();

            dataGridView1.Refresh();

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        /// <summary>
        /// Загрузка форми
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            db.Products.Load();
            dataGridView1.DataSource = db.Products.Local.ToBindingList();
            label4.Text = null;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (label4.Text == String.Empty) return;

            var id = Convert.ToInt32(label4.Text);
            var product = db.Products.Find(id);

            if (product == null) return;

            product.Name = textBox1.Text;
            product.Price = Convert.ToInt32(textBox2.Text);
            product.Manufacturer = textBox3.Text;

            db.Entry(product).State = EntityState.Modified;
            db.Products.AddOrUpdate(product);

            db.SaveChanges();

            dataGridView1.Refresh();
        }

        /// <summary>
        ///  Обработчик щелчка на строку таблицы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var product = dataGridView1.CurrentRow.DataBoundItem as Product;

            if (product == null) return;

            label4.Text = Convert.ToString(product.Id);
            textBox1.Text = product.Name;
            textBox2.Text = Convert.ToString(product.Price);
            textBox3.Text = Convert.ToString(product.Manufacturer);
        }

        /// <summary>
        /// Обработчик нажатия удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (label4.Text == String.Empty) return;

            var id = Convert.ToInt32(label4.Text);
            var product = db.Products.Find(id);

            db.Entry(product).State = EntityState.Deleted;
            db.Products.Remove(product);

            db.SaveChanges();

            dataGridView1.Refresh();
        }
    }
}
