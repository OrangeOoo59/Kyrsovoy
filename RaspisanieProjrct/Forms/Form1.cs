using RaspisanieProjrct.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspisanieProjrct
{
    public partial class Form1 : ObjectForm
    {
        private long IndexEdit;
        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
            bEditSubject.Visible = false;
        }
        public Form1(long IndexEdit, DataGridViewCellCollection Cells)
        {
            InitializeComponent();
            LoadComboBox();
            this.IndexEdit = IndexEdit;
            bAddSubject.Visible = false;
            ComboLoad(cbGroup, (string)Cells[0].Value);
            ComboLoad(cbWeek, (string)Cells[1].Value);
            ComboLoad(cbDay, (string)Cells[2].Value);
            ComboLoad(cbPair, (string)Cells[3].Value);
            ComboLoad(cbTypePair, (string)Cells[8].Value);
            ComboLoad(cbSubject, (string)Cells[10].Value);
            ComboLoad(cbProfessor, (string)Cells[9].Value);
        }
        private void ComboLoad(ComboBox cb, string Data)
        {
            for (int i=0; i<cb.Items.Count; i++)
            {
                if ((string)cb.Items[i] == Data)
                {
                    cb.SelectedIndex = i;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbWeek.Text = (string)cbWeek.Items[0];
        }
        private void LoadComboBox()
        {
            FillComboBox(cbWeek, QueryDB.Query["RomeWeek"]);
            FillComboBox(cbDay, QueryDB.Query["DayWeek"]);
            FillComboBox(cbGroup, QueryDB.Query["AbbrevGroup"]);
            FillComboBox(cbProfessor, QueryDB.Query["Professor"]);
            FillComboBox(cbSubject, QueryDB.Query["Subject"]);
            FillComboBox(cbPair, QueryDB.Query["TimePair"]);
            FillComboBox(cbTypePair, QueryDB.Query["TypeSubject"]);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(cbTypePair.Text == "" || cbWeek.Text == "" ||
                cbSubject.Text == "" || cbProfessor.Text == "" ||
                cbPair.Text == "" || cbGroup.Text == "" ||
                cbDay.Text == ""))
            {
                string sqlSubject = "insert into timeTable " +
                                "select g.index_group, " +
                                "w.index_week, " +
                                "d.index_day, " +
                                "t.index_pair, " +
                                "s.index_subject, " +
                                "ts.index_type_subject, " +
                                "p.index_professor " +
                                "from tableGroup as g, " +
                                "tableWeek as w, " +
                                "tableDayWeek as d, " +
                                "tableTimePair as t, " +
                                "tableSubject as s, " +
                                "tableTypeSubject as ts, " +
                                "tableProfessor as p " +
                                "where g.abbrev_group = '" + cbGroup.Text + "' and " +
                                "w.name_rome_week = '" + cbWeek.Text + "' and " +
                                "d.name_day = '" + cbDay.Text + "' and " +
                                "t.description_pair = '" + cbPair.Text + "' and " +
                                "s.name_subject = '" + cbSubject.Text + "' and " +
                                "ts.name_type_subject = '" + cbTypePair.Text + "' and " +
                                "p.name_professor = '" + cbProfessor.Text + "'";
                try
                {
                    DBMethods.ExecuteSqlCommand(sqlSubject);
                    MessageBox.Show("Занятие добавлено", "Действие принято", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Выбранное вами время занято другим занятием", "Действие отклонено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void OutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bEditSubject_Click(object sender, EventArgs e)
        {
            if (!(cbTypePair.Text == "" || cbWeek.Text == "" ||
                cbSubject.Text == "" || cbProfessor.Text == "" ||
                cbPair.Text == "" || cbGroup.Text == "" ||
                cbDay.Text == ""))
            {
                string sqlUpdateSubject = "update timeTable " +
                    "set index_group = (select g.index_group from tableGroup as g where g.abbrev_group = '" + cbGroup.Text + "'), " +
                    "index_week = (select rw.index_week from tableWeek as rw where rw.name_rome_week = '" + cbWeek.Text + "'), " +
                    "index_day_week = (select dw.index_day from tableDayWeek dw where dw.name_day = '" + cbDay.Text + "'), " +
                    "index_time_pair = (select index_pair from tableTimePair where description_pair = '" + cbPair.Text + "'), " +
                    "index_subject = (select index_subject from tableSubject where name_subject = '" + cbSubject.Text + "'), " +
                    "index_type_subject = (select index_type_subject from tableTypeSubject where name_type_subject = '" + cbTypePair.Text + "'), " +
                    "index_professor = (select index_professor from tableProfessor where name_professor = '" + cbProfessor.Text + "') " +
                    "where id = " + IndexEdit;
                try
                {
                    DBMethods.ExecuteSqlCommand(sqlUpdateSubject);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Выбранное вами время занято другим занятием " + ex.Message, "Действие отклонено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
