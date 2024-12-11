using WinFormsAppZH3.EventModels;

namespace WinFormsAppZH3
{
    public partial class Form1 : Form
    {
        EventsContext context = new EventsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jegyBindingSource.DataSource = context.Jegy.ToList();
            vasarlobindingSource.DataSource = context.Vasarlo.ToList();
            rendezvenybindingSource.DataSource = context.Rendezveny.ToList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Kilépés megerõsítése", "Biztos ki akar lépni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
