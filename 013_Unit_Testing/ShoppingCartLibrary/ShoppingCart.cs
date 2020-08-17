using System;
using System.Collections.Generic;

namespace ShoppingCartLibrary
{
    /// <summary>
    /// ShoppingCart - Корзина
    /// </summary>
    [Serializable]
    public class ShoppingCart : IDisposable
    {
        public List<Item> Items = new List<Item>();

        /// <summary>
        /// Количество покупок
        /// </summary>
        public int Count
        {
            get { return Items.Count; }
        }

        /// <summary>
        /// Метод для добавления покупок
        /// </summary>
        /// <param name="item"></param>
        public void Add(Item item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Метод для очистки ресурсов
        /// </summary>
        public void Dispose()
        {
            // cleanup code
        }

        /// <summary>
        /// Метод для удаления елемента из корззины
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }
    }

    /// <summary>
    /// Елемент 
    /// </summary>
    [Serializable]
    public class Item
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }
    }
}
