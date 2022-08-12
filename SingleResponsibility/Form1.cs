namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        //SingleResponsibility
        public Form1()
        {
            InitializeComponent();
        }
        public void TurnRight()
        {
            // sağa dön
        }
        public void TurnLeft()
        {
            // sola dön
        }
        public void GoStraight()
        {
             //düz git
        }
        public void GoPark()
        {
            TurnRight();
            GoStraight();
            GoStraight();
            TurnLeft();
            GoStraight();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GoPark();
        }
    }
}