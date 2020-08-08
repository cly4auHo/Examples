using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using XML;

namespace _001_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Тип для Сериализации и Десериализации
        // XmlSerializer требует указания информации о типе, 
        // представляющей класс, который необходимо сериализовать
        readonly XmlSerializer serializer = new XmlSerializer(typeof(MyClass));

        //Откуда серализуем
        MyClass instance1 = new MyClass();
        
        //Куда сериализуем
        MyClass instance2;

        // 1. СЕРИАЛИЗАЦИЯ.
        private void button1_Click(object sender, EventArgs e)
        {
            // Заполнение списка.
            for (int i = 0; i < 10; i++)
            {
                instance1.Items.Add("Element " + i); 
            }

            // Класс FileStream представляет возможности по считыванию 
            // из файла и записи в файл
            FileStream stream = new FileStream("Serialization.xml", 
                FileMode.Create, FileAccess.Write, FileShare.Read);

            // Сохраняем объект в XML-файле на диске(СЕРИАЛИЗАЦИЯ).
            // 1-й аргуммент экземпяр класса Stream
            // 2-й аргумент экземпяр класса для сереализации
            serializer.Serialize(stream, instance1);
            
            this.Text = "Объект сериализован!";

            //Закрывем файловый поток
            stream.Close();
        }

        // 2. ДЕСЕРИАЛИЗАЦИЯ.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Класс FileStream представляет возможности по считыванию 
                // из файла и записи в файл
                FileStream stream = new FileStream("Serialization.xml", 
                    FileMode.Open, 
                    FileAccess.Read, 
                    FileShare.Read);

                // Восстанавливаем объект из XML-файла.
                // аргумент - метода - файловій поток 
                instance2 = serializer.Deserialize(stream) as MyClass;
                this.Text = "Объект Десериализован!";

                textBox.Text = "ID        : " + instance2.ID + 
                                Environment.NewLine +
                                "Size     : " + instance2.Size + 
                                Environment.NewLine +
                                "Position : " + instance2.Position.ToString() 
                                + Environment.NewLine +
                                "List     : " + Environment.NewLine;

                foreach (string item in instance2.Items)
                {
                    textBox.Text += "\t" + item + Environment.NewLine;
                }

                textBox.Text += "Password: " + instance2.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
