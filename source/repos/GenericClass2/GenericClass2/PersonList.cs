using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class PersonList<T> where T : Person
    {
        IList<T> listofpersons = new List<T>();

        public T FindOldest()
        {
            var oldest = listofpersons.First();

            foreach (var item in listofpersons)
            {
                if (item.Age > oldest.Age)
                {
                    oldest = item;
                }
            }
            return oldest;
        }

        public void Add(T item)
        {
            listofpersons.Add(item);
        }

    }
}
