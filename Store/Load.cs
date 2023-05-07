using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Load
    {
        public Load()
        {

        }
        public Load(int id, string name, int area, DateTime date, int storageCost, string category)
        {
            Id = id;
            Name = name;
            Area = area;
            Date = date;
            StorageCost = storageCost;
            Category = category;
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Area { get; set; }
        public DateTime Date { get; set; }
        public int StorageCost { get; set; }
        public string Category { get; set; }

        public string Info()
        {
            return Id + "\t" + Name + "\t" + Category;
        }
    }
}
