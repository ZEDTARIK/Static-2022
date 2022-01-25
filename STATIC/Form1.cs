namespace STATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // static keyword : can acces direct from class 
            // static can be use in variable / method , class 
            Student.Name = "Name Static";
            Student.getNoteStudent();
        }
    }
}