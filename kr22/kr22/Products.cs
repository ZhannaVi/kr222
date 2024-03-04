using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
//using System.Collections.Generic;
//using System.Windows.Forms;
//using Excel = Microsoft.Office.Interop.Excel;       // EXCEL APPLICATION.
//using System.Drawing;

namespace kr22
{
    public partial class Products : Form
    {
        DataSet ds;
        public Products()
        {
            InitializeComponent();
            //btncheck.Click += new EventHandler(btncheck_Click);
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.AllowUserToAddRows = false;
            //ds = new DataSet();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnhome2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            DialogResult result= form1.ShowDialog();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[2].Name = "Age";
            string[] row;
            string[] rowData =
            {
                    "Leage of legends","free","12+",
                    "The Sims 4","1400rub","18+",
                    "WorldOfTanks","free","18+"
                };
            for (int i = 0; i < rowData.Length; i += 3)
            {
                row = new string[]
                {
                    rowData[i],rowData[i+1],rowData[i+2]
                };
            }
               
            while (dataGridView1.Rows.Count <= 2)
            {
              dataGridView1.Rows.Add();
               
                    //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            


            //table = new DataTable("Leage of Legends");
            //DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            //row["name"] = "1";
            //row["price"] = 13;
            //row["age"] = 2;
            //ds.Tables[0].Rows.Add(row);
            //dataGridView1.DataSource = ds.Tables[0];
            //ds.Tables[0].Rows.Add(row);

        }
    }

}
