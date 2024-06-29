using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PortBox.DataSource = SerialPort.GetPortNames();//Quét các cổng Serial đang hoạt động lên ComboBox1
            List<string> GiaTri = new List<string>()
            { "300",
            "1200",
            "2400",
            "9600",
            "11500",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",};
            BaudBox.DataSource = GiaTri;
                        BaudBox.Text = "9600";
        }

        private void BTConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) // Nếu đối tượng serialPort1 chưa được mở , sau khi nhấn button 1 thỳ…
            {
                BTConnect.Text = ("Disconnect");
                BTConnect.BackColor = Color.Firebrick;
                serialPort1.PortName = PortBox.Text;//cổng serialPort1 = ComboBox mà bạn đang chọn
                serialPort1.Open();// Mở cổng serialPort1



            }
            else if (serialPort1.IsOpen)
            {
                BTConnect.Text = ("Connect");
                BTConnect.BackColor = Color.SeaGreen;
                serialPort1.Close();
            }
        }


        private void OnLed_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");//Nếu button2 được nhấn,gửi byte “1” đến cổng serialPort1
        }

        private void OffLed_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");//gửi byte “0” đến cổng serialPort1
        }
        private void OnFan_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4");//Gửi tín hiệu bật quạt
        }

        private void OffFan_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");//Tắt quạt
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                label6.Text = ("Disconnect");
                label7.Text = ("Disconnect");
                pictureBox1.BackColor = Color.Red;
                pictureBox2.BackColor = Color.Red;
                //Nếu Timer được làm mới, Cổng serialPort1 chưa được mở thì thay đổi Text trong button1, label3…đổi màu text label3 thành màu đỏ 
            }
            else if (serialPort1.IsOpen)
            {
                label6.Text = ("Connect");
                label7.Text = ("Connect");
                pictureBox1.BackColor = Color.Green;
                pictureBox2.BackColor = Color.Green;
                //Nếu Timer được làm mới, Cổng serialPort1 đã mở thì thay đổi Text trong button1, label3…đổi màu text label3 thành màu xanh

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }


        private void timer3_Tick_1(object sender, EventArgs e)
        {
        if(serialPort1.IsOpen) 
            {
                String data = serialPort1.ReadLine();
                if (data.StartsWith("#"))
                {
                    string[] value = data.Split('#');
                    nt.Text = $" {value[1]}";
                    dm.Text = $"{value[2]}";
                }
            }
        }


    }
}
