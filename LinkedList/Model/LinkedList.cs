using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>  
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов в списке.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Создать пустой список.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создать список с начальным элементом.
        /// </summary>       
        public LinkedList(T data)
        {            
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в конец списка.
        /// </summary>     
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
                SetHeadAndTail(data);
        }

        /// <summary>
        /// Удалить первое вхождение данных в список.
        /// </summary>        
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
                SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в начало списка.
        /// </summary>        
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            {
                item.Next = Head;
            };

            Head = item;
            Count++;
        }

        /// <summary>
        /// Вставить данные после значения в списке.
        /// </summary>
        /// <param name="target">значение</param>
        /// <param name="data">данные</param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {                
                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }            
        }

        /// <summary>
        /// Отчистить список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка.
        /// </summary>       
        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List " + Count + " элементов";
        }
    }
}
