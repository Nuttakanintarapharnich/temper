namespace Winอุณภูมิ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butomแปลง_Click(object sender, EventArgs e)
        {
            string userinput = boxc.Text;
            double duserinput = 0.0;//ตัวเเปรที่เซตไหม่เป็น0.0
            double.TryParse(userinput, out duserinput);//คำสั่งเเปลงตัวแปรตัวอักษรมาไส่ตัวเเปรที่ 2ชื่อduserinput

            double f = duserinput * 1.8 + 32;//คำสั่งคำนวน
                                             //MessageBox.Show("you clik"); กล่่องเด้ง
            boxf.Text = f.ToString();//คำสัังเเสดงค่า f จากduserinput เเละเเปลงเป็นตัวหนังสือ string()
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = boxf.Text;
            double duserinput = 0.0;
            double.TryParse(userinput, out duserinput);

            double c = 0.555555555 * (duserinput - 32)  ;

            boxc.Text = c.ToString();
        }
    }
}