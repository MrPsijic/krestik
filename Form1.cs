namespace krestik
{
    public partial class Form1 : Form
    {
        int hod = 0;
        string p;

        public Form1()
        {
            InitializeComponent();
            panel1.BackgroundImage = Properties.Resources.X;
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (hod % 2 == 0)
            {
                p = (sender as Button).Name;
                sender.GetType().GetProperty("Text").SetValue(sender, "X");
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                panel1.BackgroundImage = Properties.Resources.O;

            }
            else
            {
                p = (sender as Button).Name;
                sender.GetType().GetProperty("Text").SetValue(sender, "O");
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                panel1.BackgroundImage = Properties.Resources.X;
            }
          

        
            hod = hod + 1;
            label3.Text = hod.ToString();
            if (hod > 4) check();

            
        }

        private void check()
        {
           
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
                winner();
            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
                winner();
            if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
                winner();
            if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
                winner();
            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
                winner();
            if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
                winner();
            if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
                winner();
            if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
                winner();

        }

        private void winner()
        {
            if (hod == 5 | hod == 7 | hod == 9)
                textBox1.Text = "Победил X" ;
            else textBox1.Text = "Победил O" ;
            panel2.Enabled = false ;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hod = 0;
            label3.Text = hod.ToString();
            panel2.Enabled = true;
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            panel1.BackgroundImage = Properties.Resources.X;
        }

        
    }
}
