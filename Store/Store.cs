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

        public delegate void Message(string message);

        public event Message MessageEvent;

        public void AddProduct(Load load)
        {
            foreach (var item in loads)
            {
                if (item.Id == load.Id)
                {
                    MessageEvent?.Invoke("ошибка, такой id уже существует");
                    return;
                    //throw new Exception("идентификатор товара не может совпадать");
                }
            }
            loads.Add(load);
            MessageEvent?.Invoke($"добавлен товар с id: {load.Id}");
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
        public delegate DateTime data();

        public event data dataEvent;

        public delegate int amountOfMoney();

        public event amountOfMoney amountOfMoneyEvent;
        public void DeleteProduct(int id)
        {
            foreach (var item in loads)
            {
                if (item.Id == id)
                {
                    
                    MessageEvent?.Invoke($"Отправлен товар с id {item.Id}" + '\n' +
                                         $"Дата отпраки: {dataEvent?.Invoke()}" + '\n' + 
                                         $"Стоимость хранения груза {amountOfMoneyEvent?.Invoke()}");
                    loads.Remove(item);
                    break;
                }
            }
        }

        

    }
}
