using Lab1;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n= Int32.Parse(numberOfItemsBox.Text);
                numberOfItemsBox.BackColor = Color.White;
            }
            catch
            {
                numberOfItemsBox.BackColor = Color.Red;
            }

            int seed = 0;
            try
            {
                seed = Int32.Parse(seedBox.Text);
                seedBox.BackColor = Color.White;
            }
            catch
            {
                seedBox.BackColor = Color.Red;
            }

            int capacity = 0;
            try
            {
                capacity = Int32.Parse(capacityBox.Text);
                capacityBox.BackColor = Color.White;
            }
            catch
            {
                capacityBox.BackColor = Color.Red;
            }

            Problem problem = new Problem(n, seed);
            Result r = problem.solve(capacity);
            resultBox.AppendText("Result\r\n");
            resultBox.AppendText(r.ToString());
            resultBox.AppendText("\r\n\r\nTotal value: " + r.total_value);
            resultBox.AppendText("\r\nTotal weight: " + r.total_weight);

            //resultBox.Text = "Result" + r.ToString() + "Total value: " + r.total_value + "Total weight: " + r.total_weight;
            problemBox.Text = problem.ToString();
            //Console.Write(problem.ToString());
            //Console.WriteLine("Result");
            //Console.Write(r.ToString());
            //Console.WriteLine("Total value: " + r.total_value);
            //Console.WriteLine("Total weight: " + r.total_weight);
        }
    }
}
