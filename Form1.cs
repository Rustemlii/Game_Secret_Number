namespace Game_Secret_Number
{
    public partial class Form1 : Form
    {
        
        Random rnd = new Random();
        int say = 0;
        int a;
        public Form1()
        {
            a = rnd.Next(1, 100);

            InitializeComponent();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            say++;
            btn.Enabled = false;
            btn.BackColor = Color.Red;
            if (say != 6)
            {
                label1.Text = $"Cehd sayi:  {say}";
                if (say == 4)
                {
                    label1.BackColor = Color.Red;                
                }
                if (Convert.ToInt32(btn.Text) == a)
                {
                    btn.BackColor = Color.Green;
                    SecilenReqemLabel.Text = SecilenReqemLabel.Text + a.ToString();
                    MessageBox.Show("Tebrikler \n Dogru reqemi tapdiniz", "Win", MessageBoxButtons.OK);
                    Close();

                }
                else if (Convert.ToInt32(btn.Text) > a)
                {

                    MessageBox.Show("Asagi reqemlerden secin", "Texmin", MessageBoxButtons.OK);

                }
                else if (Convert.ToInt32(btn.Text) < a)
                {
                    MessageBox.Show("Yuxari reqemlerden secin", "Texmin", MessageBoxButtons.OK);

                }


            }
            else
            {
                SecilenReqemLabel.Text = SecilenReqemLabel.Text + a.ToString();
                MessageBox.Show("                      Oyun Bitdi \n Axtarishda olan reqemi tapa bilmediniz ):", "Teessuf", MessageBoxButtons.OK);
                Close();
            }






        }
    }
}
