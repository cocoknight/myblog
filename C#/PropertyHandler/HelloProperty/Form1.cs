using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HelloProperty
{
    public partial class Form1 : Form
    {
        BankCustomer _bankCustomer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resources Folder가 없으면, 해당 폴더를 만들고 거기에 이미지를 추가
            //project이름에 마우스 오른쪽 클릭 - 새폴더 - Resources 이름 입력
            //Resources폴더에 기존항목 추가로 필요한 이미지를 추가 하면 된다.

            pictureBox1.Image = Properties.Resources.myasset;
            pictureBox2.Image = Properties.Resources.customer;
            pictureBox3.Image = Properties.Resources.customer;

            _bankCustomer = new BankCustomer();

            //여기서 값을 출력해보자.
            Debug.WriteLine(string.Format("Full Stacktrace: {0}", _bankCustomer.Custmer2Asset.ToString()));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = 50000;
            //_bankCustomer.setCustomer1Assets(money);
            _bankCustomer.Custmer1Asset = money;
            depositMessage("customer1", money);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int currentAsset =_bankCustomer.getCustomer1Assets();
            int currentAsset = _bankCustomer.Custmer1Asset;
            withdrawMessage("customer1", currentAsset);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int money = 70000;
            //_bankCustomer.setCustomer2Assets(money);
            _bankCustomer.Custmer2Asset = money;
            depositMessage("customer2", money);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int currentAsset = _bankCustomer.getCustomer2Assets();
            int currentAsset = _bankCustomer.Custmer2Asset;
            withdrawMessage("customer2", currentAsset);
        }


        void depositMessage(string customer,int money)
        {
            System.Windows.Forms.MessageBox.Show(customer+"님이 "+money.ToString()+
                          " 을 입금 하였습니다.",
                          "Message",
                          System.Windows.Forms.MessageBoxButtons.OK,
                          System.Windows.Forms.MessageBoxIcon.Information);
        }

        void withdrawMessage(string customer,int money)
        {
            System.Windows.Forms.MessageBox.Show(customer + "님이 " + money.ToString() +
                          " 을 출금 하였습니다.",
                          "Message",
                          System.Windows.Forms.MessageBoxButtons.OK,
                          System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
