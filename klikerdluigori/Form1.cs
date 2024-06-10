using System.Reflection.Emit;
using System.Security.Policy;
using System.Windows.Forms;

namespace klikerdluigori
{
    public partial class Form1 : Form
    {
        XER xer = new XER();
        public Form1()
        {
            InitializeComponent();
            //timer1.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resource1.kot;
            xer.Start(timer1, 3, Shownax);
        }
        private void Shownax()
        {
            pictureBox1.Image = Resource1.malkot;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            xer.Tick();
        }
    }
}
