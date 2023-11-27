using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    [DataContract]
    public class Snacks : BaseEntity
    {
        private string snacksName;
        public string SnacksName
        {
            get { return snacksName; }
            set { snacksName = value; }
        }

    }

    [CollectionDataContract]
    public class SnacksList : List<Snacks>
    {
        public SnacksList() { } //בנאי ברירת מחדל
        public SnacksList(IEnumerable<Snacks> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public SnacksList(IEnumerable<BaseEntity> list) :
            base(list.Cast<Snacks>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }
}
