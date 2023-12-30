using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        List<string> nums { get; set; }
        public Form1()
        {
            InitializeComponent();
            nums = new List<string>();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_res.Text += "0";
            nums.Add("0");
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_res.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_res.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_res.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_res.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_res.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_res.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_res.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_res.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_res.Text += "9";
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            tb_res.Text = "";
            nums.Add("+");
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            tb_res.Text = "";
            nums.Add("*");
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            tb_res.Text = "";
            nums.Add("-");
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            tb_res.Text = "";
            nums.Add("/");
        }

        private void btn_laydu_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            tb_res.Text = "";
            nums.Add("%");
        }
        private void btn_bang_Click(object sender, EventArgs e)
        {
            nums.Add(tb_res.Text);
            double res = 0;
            if (nums.Count > 0 && (nums.Count % 3 == 0 || nums.Count % 1 == 0))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == "+" || nums[i] == "-" || nums[i] == "/" || nums[i] == "*" || nums[i] == "%")
                    {
                        if(nums[i] == "+")
                        {
                            res += Double.Parse(nums[++i]);
                        } 
                        else if (nums[i] == "-")
                        {
                            res -= Double.Parse(nums[++i]);
                        }
                        else if (nums[i] == "*")
                        {
                            res *= Double.Parse(nums[++i]);
                        }
                        else if (nums[i] == "/")
                        {
                            res /= Double.Parse(nums[++i]);
                        }
                        else if (nums[i] == "%")
                        {
                            res %= Double.Parse(nums[++i]);
                        }    
                    }
                    else
                    {
                        res = Double.Parse(nums[i]);
                    }
                }
                tb_res.Text = res.ToString();
                nums.Clear();
            }
            else if (nums.Count == 0)
            {
                MessageBox.Show("Bạn chưa nhập gì cả", "Lưu ý", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng phép tính", "Lưu ý", MessageBoxButtons.OK);
            }    
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            nums.Clear();
            tb_res.Text = string.Empty;
        }

        private void btn_cham_Click(object sender, EventArgs e)
        {
            tb_res.Text += ".";
        }

        private void btn_1chia_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_res.Text))
            {
                double res = 1 / (Double.Parse(tb_res.Text));
                tb_res.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập gì cả", "Lưu ý", MessageBoxButtons.OK);
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_res.Text))
            {
                double res = Math.Sqrt(Double.Parse(tb_res.Text));
                tb_res.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập gì cả", "Lưu ý", MessageBoxButtons.OK);
            }
        }

        private void btn_amduong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_res.Text))
            {
                string temp = tb_res.Text;
                if (tb_res.Text[0] != '-')
                {
                    tb_res.Text = '-' + temp;
                }
                else
                {
                    tb_res.Text = temp.Substring(1);
                }
            }
            else MessageBox.Show("Bạn chưa nhập gì cả", "Lưu ý", MessageBoxButtons.OK);
        }
    }
}
