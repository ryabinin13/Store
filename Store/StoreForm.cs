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
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Load load = new Load();

            try
            {                
                load.Id = Convert.ToInt32(numericUpDownIdForAdd.Value);
                load.Name = textBoxName.Text;            
                load.Area = Convert.ToInt32(numericUpDownAreaForAdd.Value);
                load.Date = dateTimePickerForAdd.Value;                
                load.StorageCost = Convert.ToInt32(numericUpDownCostForAdd.Value);
                load.Category = comboBoxCategoryForAdd.Text;
                store.AddProduct(load);
                numericUpDownIdForAdd.Value++;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, введите еще раз");
            }
                       
            textBoxName.Text = "";            
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {            
            int currentIdDelete = Convert.ToInt32(numericUpDownIdForDelete.Value);
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
    }
}
