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
    public partial class UserControlEAP : UserControl
    {
        sportEventDbContext context = new sportEventDbContext();
        public UserControlEAP()
        {
            InitializeComponent();
        }

        private void UserControlEAP_Load(object sender, EventArgs e)
        {
            eventParticipantsBindingSource.DataSource = context.EventParticipants.ToList();
            eventsBindingSource.DataSource = context.Events.ToList();
            participantsBindingSource.DataSource = context.Participants.ToList();
            
        }
    }
}
