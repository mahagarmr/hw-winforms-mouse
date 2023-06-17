namespace hw_winforms_mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"X: {e.X}";
            label2.Text = $"Y: {e.Y}";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show($"{e.KeyChar}");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(
                $"{e.Button} Click",
                "Mouse Click",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}