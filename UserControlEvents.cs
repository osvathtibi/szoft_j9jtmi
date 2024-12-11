using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_3.Data;

namespace ZH3_3
{
    public partial class UserControlEvents : UserControl
    {
        sportEventDbContext context = new sportEventDbContext();
        public UserControlEvents()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlEvents_Load(object sender, EventArgs e)
        {
            eventsBindingSource.DataSource = context.Events.ToList();
            foreach (var sor in context.Events)
            {
                string szoveg = $"{sor.Name},{sor.EventId}, {sor.EventDate}";
                listBox1.Items.Add(szoveg);

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (eventsBindingSource != null)
            {
                if (MessageBox.Show("Biztosan törli?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    eventsBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
