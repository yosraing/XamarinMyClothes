//using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MapApp.Utilitaire
{
    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
