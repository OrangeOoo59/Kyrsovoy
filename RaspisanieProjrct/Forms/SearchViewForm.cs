using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspisanieProjrct.Forms
{
    public partial class SearchViewForm : ObjectForm
    {
        public SearchViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            FillComboBox(cbWeek, QueryDB.Query["RomeWeek"]);
            FillComboBox(cbDay, QueryDB.Query["DayWeek"]);
            FillComboBox(cbGroup, QueryDB.Query["AbbrevGroup"]);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectString = "select * from vRaspisanieCP041 where name_rome_week like '" + cbWeek.Text + "' and name_day like '" + cbDay.Text + "%' order by index_day, index_pair";
                DataTable dataTable = DBMethods.GetTableCommand(SelectString);

                Form View = new ViewForm(dataTable);
                View.MdiParent = Application.OpenForms["StartForm"];
                View.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("На данный день нет занятий", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //foreach (DataRow dataRow in dataTable.Rows)
            //{
            //    foreach (object cell in dataRow.ItemArray)
            //    {
            //        Console.Write(cell + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
