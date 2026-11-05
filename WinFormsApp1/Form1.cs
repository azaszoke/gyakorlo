namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(cbxProfession.Text))
            {
                MessageBox.Show("Add meg a nevet és a foglalkozást.");
                return;
            }

            lbxLista.Items.Add(
                $"Név: {tbxName.Text}, Életkor: {numAge.Value}, Foglalkozás: {cbxProfession.Text}");

            tbxName.Clear();
            cbxProfession.SelectedIndex = -1;
            numAge.Value = numAge.Minimum;
        }

        private void LbxLista_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
        }

        private void lbxLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
