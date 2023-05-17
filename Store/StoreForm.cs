using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class StoreForm : Form
    {
        


        public StoreForm()
        {
            InitializeComponent();
            listBoxPrint.Text = "";           
        }

        Store store = new Store();
        
        public void ShowMessage(string s)
        {
            MessageBox.Show(s);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            store.MessageEvent += ShowMessage;
            AddForm af = new AddForm();

            af.LoadForAdd = null;

            af.ShowDialog();

            if (af.LoadForAdd != null)
            {
                store.AddProduct(af.LoadForAdd);
            }
                                 
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            listBoxPrint.Items.Clear();
            
            List<Load> currentLoads = new List<Load>();
            currentLoads = store.GetLoads();
            foreach (var item in currentLoads)
            {
                listBoxPrint.Items.Add(item.Info());                
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadForm lf = new LoadForm();
     
            int currentIdSearch = Convert.ToInt32(numericUpDownIdForFind.Value);

            Load currentLoad = new Load();

            try
            {
                currentLoad = store.SearchID(currentIdSearch);
                
                lf.LoadParameters = currentLoad.Id.ToString();
                lf.LoadParameters = currentLoad.Name;
                lf.LoadParameters = currentLoad.Area.ToString();
                lf.LoadParameters = currentLoad.Date.ToString();
                lf.LoadParameters = currentLoad.StorageCost.ToString();
                lf.LoadParameters = currentLoad.Category;

                lf.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Товара с данным id не найдено");
            }     
        }

        public DateTime Date()
        {
            return dateTimePickerForCalculate.Value;
        }

        public int AmountOfMoneyMethod()
        {
            Load load = store.SearchID(Convert.ToInt32(numericUpDownIdForDelete.Value));

            var diferent = dateTimePickerForCalculate.Value - load.Date;

            return Convert.ToInt32(diferent.Days * load.StorageCost);
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int currentIdDelete = Convert.ToInt32(numericUpDownIdForDelete.Value);

            store.MessageEvent += ShowMessage;

            store.dataEvent += Date;

            store.amountOfMoneyEvent += AmountOfMoneyMethod;

            
            store.DeleteProduct(currentIdDelete);
        }

        private void buttonAmountOfMoney_Click(object sender, EventArgs e)
        {
            try
            {                
                int currentIdSearch = Convert.ToInt32(numericUpDownIdForSIzeMoney.Value);

                Load currentLoad = new Load();

                currentLoad = store.SearchID(currentIdSearch);

                var diferent = dateTimePickerForCalculate.Value - currentLoad.Date;
                

                textBoxAmountOfMoney.Text = (diferent.Days * currentLoad.StorageCost).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка, попробуйте снова");
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (var fileReader = new StreamReader("add.txt"))
                {
                    while (!fileReader.EndOfStream)
                    {
                        int id = Convert.ToInt32(fileReader.ReadLine());
                        string name = fileReader.ReadLine();
                        int area = Convert.ToInt32(fileReader.ReadLine());
                        DateTime date = Convert.ToDateTime(fileReader.ReadLine());
                        int storageCost = Convert.ToInt32(fileReader.ReadLine());
                        string category = fileReader.ReadLine();
                        store.AddProduct(new Load(id, name, area, date, storageCost, category));
                    }                    
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения из файла");
            }
        }

        private void buttonFileWrite_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fileWriter = new StreamWriter("add.txt", false))
                {

                    List<Load> current = store.GetLoads();

                    for (int i = 0; i < store.GetLoads().Count; i++)
                    {
                        
                        fileWriter.WriteLine(current[i].Id.ToString());
                        fileWriter.WriteLine(current[i].Name);
                        fileWriter.WriteLine(current[i].Area);
                        fileWriter.WriteLine(current[i].Date);
                        fileWriter.WriteLine(current[i].StorageCost);
                        fileWriter.WriteLine(current[i].Category);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка чтения из файла");
            }
        }



        private void buttonGroupByCategory_Click(object sender, EventArgs e)
        {
            listBoxPrint.Items.Clear();

            var storeGroup =store.GetLoads().GroupBy(load => load.Category);
                   
            foreach (var group in storeGroup)
            {
                foreach (var item in group)
                {
                    listBoxPrint.Items.Add(item.Info());
                }
            }
        }

        private void buttonSearchName_Click(object sender, EventArgs e)
        {

            listBoxPrint.Items.Clear();

            string currentNameSearch = textBoxForFindName.Text;

            try
            {
                List<Load> currentLoads = new List<Load>();

                currentLoads = store.SearchName(currentNameSearch);

                foreach (var item in currentLoads)
                {
                    listBoxPrint.Items.Add(item.Info());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Товара с данным id не найдено");
            }
        }

        public void MethodForAddForm(Load load)
        {
            store.AddProduct(load);
        }
    }
}
