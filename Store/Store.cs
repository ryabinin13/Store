using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        List<Load> loads = new List<Load>();

        

        public void AddProduct(Load load)
        {
            foreach (var item in loads)
            {
                if (item.Id == load.Id)
                {
                    throw new Exception("идентификатор товара не может совпадать");
                }
            }
            loads.Add(load);
        }

        public List<Load> GetLoads()
        {
            return loads;
        }
        
        public Load SearchID(int id)
        {
            return loads.Find(item => item.Id == id);
        }
        public List<Load> SearchName(string name)
        {
            return loads.FindAll(item => item.Name == name);
        }
        public void DeleteProduct(int id)
        {
            foreach (var item in loads)
            {
                if (item.Id == id)
                {
                    loads.Remove(item);
                    break;
                }
            }
        }

        

    }
}
