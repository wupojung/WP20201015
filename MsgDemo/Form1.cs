using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgDemo
{
    public partial class Form1 : Form
    {
        private int num = 2;
        public Form1()
        {
            InitializeComponent();
            //TODO: 
            num = new Random().Next(100);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                //提取輸入內容
                string input_str = tbInput.Text;
                //轉換int 
                int input_int = int.Parse(input_str);

                //TODO: 寫判斷邏輯
                if (input_int == num)
                {
                    //顯示內容
                    MessageBox.Show($"YES", "Random Num", MessageBoxButtons.OK);
                }
                else
                {
                    string msg = (input_int > num) ? "小一點" : "大一點";
                    //TODO: 提示: 大一點  小一點...
                    MessageBox.Show($"{msg}", "Random Num", MessageBoxButtons.OK);
                }

            }
            catch (Exception)
            {
                //錯誤提示
                MessageBox.Show($"不要亂輸入", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
