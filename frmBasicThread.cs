namespace TanghalLab
{
    public partial class frmBasicThread : Form
    {
        Thread threadA = null!;
        Thread threadB = null!;

        public frmBasicThread()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            label1.Text = "-Before starting thread-";

            Console.WriteLine("-Before starting thread-");

            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread1);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "-End of Thread-";

            Console.WriteLine("-End of Thread-");
        }
    }
}
    
