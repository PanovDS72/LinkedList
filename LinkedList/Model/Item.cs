using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    /// <summary>
    /// Элемент списка.
    /// </summary>    
    public class Item<T>
    {        
        private T data = default(T);

        /// <summary>
        /// Следующий элемент списка.
        /// </summary>
        public Item<T> Next { get; set; }

        /// <summary>
        /// Данные хранимые в элементе списка.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
