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
    public partial class ViewForm : Form
    {
        private const int height = 40;
        private DataTable sourceData;
        private DataTable OriginalData;
        public ViewForm(DataTable dataTable)
        {
            InitializeComponent();
            ResizeDataGrid();
            dataGrid.Location = new Point(0, 40);
            
            OriginalData = dataTable.Clone();

            lGroup.Text += dataTable.Rows[0][0];
            lWeek.Text += dataTable.Rows[0][1];
            sourceData = dataTable.Clone();
            LoadSourceData(dataTable);

            sourceData.Columns.Remove(sourceData.Columns[8]);
            sourceData.Columns.Remove(sourceData.Columns[3]);
            sourceData.Columns[2].ColumnName = "День недели";
            sourceData.Columns[3].ColumnName = "Время занятия";
            sourceData.Columns[4].ColumnName = "Занятие";
            sourceData.Columns[5].ColumnName = "Тип занятия";
            sourceData.Columns[6].ColumnName = "Преподаватель";

            dataGrid.DataSource = sourceData;
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[7].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
            dataGrid.Columns[10].Visible = false;
        }
        private void LoadSourceData(DataTable dataTable)
        {
            AddVoidDataRows(Convert.ToInt32(dataTable.Rows[0][3]) - 1);
            for (int i = 0; i < dataTable.Rows.Count - 1; i++)
            {
                sourceData.Rows.Add(dataTable.Rows[i].ItemArray);
                if (Convert.ToInt32(dataTable.Rows[i][8]) != Convert.ToInt32(dataTable.Rows[i + 1][8]))
                {

                    AddVoidDataRows(6 - Convert.ToInt32(dataTable.Rows[i][3]));
                    AddVoidDataRows(Convert.ToInt32(dataTable.Rows[i + 1][3]) - 1);
                }
            }
            sourceData.Rows.Add(dataTable.Rows[dataTable.Rows.Count - 1].ItemArray);
            AddVoidDataRows(6 - Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][3]));
        }
        private void AddVoidDataRows(int count)
        {
            while (count > 0)
            {
                sourceData.Rows.Add();
                count--;
            }
        }
        private void ViewForm_Load(object sender, EventArgs e)
        {

        }
        private void ViewForm_Resize(object sender, EventArgs e)
        {
            ResizeDataGrid();
        }
        private void ResizeDataGrid()
        {
            dataGrid.Size = this.ClientSize;
            dataGrid.Height -= height;
        }

        private void bRemovePair_Click(object sender, EventArgs e)
        {
            string sqlRemoove = "delete from timeTable where id = " + (long)dataGrid.SelectedRows[0].Cells[7].Value;
            try
            {
                DBMethods.ExecuteSqlCommand(sqlRemoove);
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбранная вами строка пуста " + ex.Message, "Действие отклонено", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUpdatePair_Click(object sender, EventArgs e)
        {
            try
            {
                long SelectedIndex = (long)(dataGrid.SelectedRows[0].Cells[7].Value);
                Form Edit = new Form1(SelectedIndex, dataGrid.SelectedRows[0].Cells);
                Edit.Show();
            }
            catch (System.InvalidCastException except)
            {
                MessageBox.Show("Выбрана строка без записи", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
