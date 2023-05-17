using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class AddForm : Form
    {
        public Load LoadForAdd { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StoreForm sf = new StoreForm();

            Load load = new Load();

            load.Id = Convert.ToInt32(numericUpDownIdForAdd.Value);
            load.Name = textBoxName.Text;
            load.Area = Convert.ToInt32(numericUpDownAreaForAdd.Value);
            load.Date = dateTimePickerForAdd.Value;
            load.StorageCost = Convert.ToInt32(numericUpDownCostForAdd.Value);
            load.Category = comboBoxCategoryForAdd.Text;            
            numericUpDownIdForAdd.Value++;

            LoadForAdd = load;

            //sf.MethodForAddForm(load);


            this.Close();
            
        }
    }
}
