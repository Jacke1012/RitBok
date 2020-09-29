

using System;

namespace HistoryCollections
{
    public class History<T>
    {
        private int size;
        private T[] array;

        public int current = -1;

        private bool hasUndon = false;
        
        public History(int size)
        {
            this.size = size;
            array = new T[size];
        }

        public void Add(T item)
        {
            if (hasUndon)
            {
                RemoveExtra();
                hasUndon = false;
            }

            if (current < size-1)
            {
                current++;
                array[current] = item;
            }
            else
            {
                T[] tempArray = new T[size];
                for (int i = 0; i < current; i++)
                {
                    tempArray[i] = array[i + 1];
                }
                array = tempArray;
                array[current] = item;
            }



        }

        public bool Undo(out T item)
        {
            if (current > 0)
            {
                hasUndon = true;
                current--;
                item = array[current];
                return true;
            }
            else
            {
                item = default(T);
                return false;
            }
        }

        public bool Redo(out T item)
        {
            if (array[current + 1] != null)
            {
                current++;
                item = array[current];
                return true;
            }
            else
            {
                item = default(T);
                return false;
            }
        }

        private void RemoveExtra()
        {
            T[] tempArray = new T[size];
            T tempObj = array[0];
            for (int i = 0; i <= current; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
            if (tempObj is IDisposable)
            {
                ((IDisposable)tempObj).Dispose();
            }
        }
    }
}
