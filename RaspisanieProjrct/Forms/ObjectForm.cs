using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RaspisanieProjrct.Forms
{
    public class ObjectForm : Form
    {
        protected void FillComboBox(ComboBox cb, string sqlCommand)
        {
            DataTable dataTable = DBMethods.GetTableCommand(sqlCommand);
            cb.Items.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (object cell in dataRow.ItemArray)
                {
                    cb.Items.Add(cell);
                }
            }
        }
    }
}
