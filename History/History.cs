using System;
using System.Collections;
using System.Collections.Generic;

namespace HistoryCollections
{
    public class History<T> : IEnumerable<T>
    {
        private int size;
        public T[] array;

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

            if (current < size - 1)
            {
                current++;
                array[current] = item;
            }
            else
            {
                T[] tempArray = new T[size];
                T tempObj = array[0];
                for (int i = 0; i < current; i++)
                {
                    tempArray[i] = array[i + 1];
                }
                array = tempArray;
                array[current] = item;
                if (tempObj is IDisposable)
                {
                    ((IDisposable)tempObj).Dispose();
                    //Console.WriteLine("Dispose");
                }
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
                //Console.WriteLine("Dispose");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new HistoryEnum<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new HistoryEnum<T>(this);
        }

        class HistoryEnum<T> : IEnumerator<T>
        {
            History<T> his;

            public HistoryEnum(History<T> his)
            {
                this.his = his;
            }
            int pos = -1;
            public T Current
            {
                get
                {
                    return his.array[pos];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                pos++;
                if (pos < his.array.Length && his.array[pos] != null)
                {
                    return true;
                }
                else
                {
                    Reset();
                    return false;
                }
            }

            public void Reset()
            {
                pos = -1;
            }
        }
    }


    
}
