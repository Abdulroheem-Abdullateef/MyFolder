using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericList<T>
    {
        IList<T> List = new List<T>();
        public void Add(T item)
        {
            List.Add(item);
        }

        public int Count()
        {
            return List.Count();
        }
    }
}
