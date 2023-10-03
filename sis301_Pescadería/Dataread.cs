using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BaseData;

namespace sis301_Pescadería
{
    class Dataread
    {
        public Dataread()
        {
            BD = new Dataset();
        }

        private Dataset BD;

        public void Loadtable(DataGridView dtgv,string Consult)
        {
            MySqlDataReader read = BD.dataconsult(Consult);
            DataGridView DG = dtgv;
            DG.Rows.Clear();
            DG.Columns.Clear();
            int count = 0;
            while (read.Read())
            {
                if (count == 0)
                {
                    for (int cr = 0; cr < read.FieldCount; cr++)
                    {
                        DG.Columns.Add("Column" + cr, read.GetName(cr));
                    }
                }
                DG.Rows.Add();
                for (int ca = 0; ca < read.FieldCount; ca++)
                {
                    DG.Rows[count].Cells[ca].Value = read.GetString(ca);
                }
                count++;
            }
            DG.AutoResizeColumns();
            BD.ConnectionClose();
        }
    }
}
