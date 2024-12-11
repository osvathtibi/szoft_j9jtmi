namespace ZH3_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlEvents userControlEvents = new UserControlEvents();
            panel1.Controls.Add(userControlEvents);
            userControlEvents.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztosan kilépsz?", "Kilépés megerõsítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void buttonPart_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlPart part = new UserControlPart();
            panel1.Controls.Add(part);
            part.Dock = DockStyle.Fill;
        }

        private void buttonEAP_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlEAP eAP = new UserControlEAP();
            panel1.Controls.Add(eAP);
            eAP.Dock = DockStyle.Fill;
        }
    }
}
