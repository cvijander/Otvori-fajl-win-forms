namespace Otvori_fajl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Odaberi tekstualni fajl (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string lokacija = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(lokacija);
            }
        }
    }
}