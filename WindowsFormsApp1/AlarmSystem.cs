using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AlarmSystem : Form
    {
        public AlarmSystem()
        {
            InitializeComponent();
        }

        private void BasicSituation_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“_16jailDataSet.criminalRewardsPunishmentTable”中。您可以根据需要移动或删除它。
            this.criminalRewardsPunishmentTableTableAdapter.Fill(this._16jailDataSet.criminalRewardsPunishmentTable);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
