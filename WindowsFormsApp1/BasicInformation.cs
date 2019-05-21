using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BasicInformation : Form
    {
        public BasicInformation()
        {
            InitializeComponent();
        }
        //查询
        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true)
            {
                dataGridView1.DataSource = ButtonAction.GetAll();
            }
            if (string.IsNullOrEmpty(textBox1.Text) != true)//RFID
            {
                dataGridView1.DataSource = ButtonAction.GetRFIDNumber(textBox1.Text);

            }
            if (string.IsNullOrEmpty(textBox2.Text) != true)//name
            {
                dataGridView1.DataSource = ButtonAction.GetName(textBox2.Text);
            }
            if (string.IsNullOrEmpty(textBox3.Text) != true)//ID
            {
                dataGridView1.DataSource = ButtonAction.GetID(textBox3.Text);
            }
        }



        //删除
        private void Button2_Click(object sender, EventArgs e)
        {
            var cr = new CriminalBasicInfoTable();
            cr.criminalID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ButtonAction.Delete(cr);
            MessageBox.Show("删除成功!");
            dataGridView1.DataSource = ButtonAction.GetAll();
        }

        //保存//更新
        private void Button5_Click(object sender, EventArgs e)
        {
            var st = new CriminalBasicInfoTable();

            try
            {
                st.criminalID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                st.criminalName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                st.IDNumber = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                st.imprisonTime = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                st.imprisonReason = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                st.prisonTerm = float.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                st.RFIDNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                st.predecessorFileNumber = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                ButtonAction.Insert(st);

                var st2 = new CriminalBasicInfoTable
                {
                    criminalID = "null",
                    imprisonTime = DateTime.Parse("1900/01/01"),
                    prisonTerm = 0
                };
                ButtonAction.Insert(st2);

                MessageBox.Show("保存成功！");
                dataGridView1.DataSource = ButtonAction.GetAll();


            }
            catch (Exception)
            {
                try
                {
                    st.criminalID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    st.criminalName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    st.IDNumber = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    st.imprisonTime = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    st.imprisonReason = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    st.prisonTerm = float.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    st.RFIDNumber = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    st.predecessorFileNumber = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    ButtonAction.Update(st);
                    MessageBox.Show("保存成功！");
                    dataGridView1.DataSource = ButtonAction.GetAll();

                }
                catch (Exception)
                {
                    MessageBox.Show("请输入完整！");
                }

            }          
        }
    }
}
