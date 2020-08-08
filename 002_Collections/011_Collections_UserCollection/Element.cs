namespace _011_Collections_UserCollection
{
    /// <summary>
    /// class Element
    /// </summary>
    public class Element
    {
        // Закрытие поля класс Element
        private string name;
        private int field1;
        private int field2;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Element(string s, int a, int b)
        {
            name = s;
            field1 = a;
            field2 = b;
        }

        // Свойства.
        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }

        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
