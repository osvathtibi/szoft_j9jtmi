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
    public partial class UserControlPart : UserControl
    {
        sportEventDbContext context = new sportEventDbContext();
        public UserControlPart()
        {
            InitializeComponent();
        }

        private void UserControlPart_Load(object sender, EventArgs e)
        {
            participantsBindingSource.DataSource = context.Participants.ToList();
        }
    }
}
