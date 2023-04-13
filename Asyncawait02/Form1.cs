namespace Asyncawait02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btniniciar_Click(object sender, EventArgs e)
        {
            ptbloading.Visible = true;
            await Task.Delay(TimeSpan.FromSeconds(5));
            ptbloading.Visible= false;  
        }
    }
}