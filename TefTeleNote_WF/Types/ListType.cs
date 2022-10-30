using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Operators
{
    public class ListType<T> : List<T>
    {
        //public int Length
        //{
        //    get
        //    {
        //        return _lenght;
        //    }
        //}
        //private int _lenght;
        //public T[] Data { get; set; }


        //ListType()
        //{
        //    this.Data = new T[0];
        //    _lenght = 0;
        //}

        //ListType(params T[] values)
        //{
        //    int _counter = 0;
        //    this.Data = new T[values.Length];
        //    foreach (var v in values)
        //    {
        //        Data[_counter++] = v;
        //    }
        //    _lenght = _counter;
        //}

        //public void Reset()
        //{
        //    this.Data = new T[0];
        //    _lenght = 0;
        //}
        //public void Add(T value)
        //{
        //    T[] newData = new T[++_lenght];
        //    int _counter = 0;
        //    foreach (T v in Data)
        //    {
        //        newData[_counter] = Data[_counter++];
        //    }
        //    newData[Data.Length] = value;
        //    this.Data = newData;
        //}
        //public int RemoveAt(int index)
        //{
        //    if (index < Data.Length)
        //    {
        //        T[] newData = new T[--_lenght];
        //        int _counter = 0;
        //        int _counter2 = 0;
        //        foreach (T v in Data)
        //        {
        //            if (_counter != index)
        //            {
        //                newData[_counter2] = Data[_counter]; 
        //                _counter++;
        //            }
        //            _counter2++;
        //        }
        //        Data = newData;
        //        return index;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

    }
}
