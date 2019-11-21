using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFull
{
    public partial class Form1 : Form
    {
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var selection = MessageBox.Show("Do you want to close?", "Calculator by DvL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            e.Cancel = (selection == DialogResult.Cancel);
        }

        // Nhóm nút bấm Số
        private void btnNum_Click(object sender, EventArgs e)
        {
            tbRes.Visible = false;
            tbInput.Visible = true;
            Button button = (Button)sender;

            // xử lý: nếu vừa chỉ ấn mỗi phép tính nâng cao, khi ấn số sẽ clear màn hình
            bool matchAdv = Regex.IsMatch(tbTemp.Text, "^[SE]");
            bool matchOpeator = Regex.IsMatch(tbTemp.Text, "^[SE][+-×÷]");
            if (matchAdv && !matchOpeator)
            {
                tbInput.Clear();
                tbTemp.Clear();
            }

            // xử lý sự kiện gõ bàn phím
            switch (button.Text)
            {
                case ".":
                    {
                        // mỗi số thập phân chỉ có 1 dấu '.' duy nhất
                        if (!tbInput.Text.Contains("."))
                        {
                            tbInput.Text += ".";
                        }
                        break;
                    }
                case "+/-":
                    {
                        // không cho phép nhấn khi input đang nhập chỉ có mỗi số 0
                        bool flag = false;
                        if (tbInput.Text.StartsWith("0") && tbInput.Text.Contains("."))
                        {
                            flag = true;
                        }
                        else
                        {
                            if (!tbInput.Text.StartsWith("0"))
                            {
                                flag = true;
                            }
                        }

                        if (flag)
                        {
                            if (tbInput.Text.StartsWith("-"))
                            {
                                tbInput.Text = tbInput.Text.Remove(0, 1);
                            }
                            else
                            {
                                tbInput.Text = tbInput.Text.Insert(0, "-");
                            }
                        }
                        break;
                    }
                case "0":
                    {
                        // Không cho phép nhập thêm số 0 nếu input hiện tại chỉ có mỗi số 0
                        if (!tbInput.Text.StartsWith("0"))
                        {
                            tbInput.Text += "0";
                        }
                        else
                        {
                            if (tbInput.Text.Contains("."))
                            {
                                tbInput.Text += "0";
                            }
                        }
                        break;
                    }
                default:
                    {
                        // Xử lý bắt các phím nhấn. Loại bỏ số 0 ở đầu
                        if (tbInput.Text.StartsWith("0") && !tbInput.Text.Contains("."))
                        {
                            tbInput.Clear();
                        }
                        tbInput.Text += button.Text;
                        break;
                    }
            }
        }

        // Nhóm nút bấm điều khiển
        private void btnController_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "OFF":
                    {
                        this.Close();
                        break;
                    }
                case "C":
                    {
                        tbRes.Text = "0";
                        tbInput.Text = "0";
                        tbTemp.Clear();
                        break;
                    }
                case "Backspace":
                    {
                        if (tbInput.Text.Length > 1)
                        {
                            tbInput.Text = tbInput.Text.Remove(tbInput.Text.Length - 1, 1);
                        }
                        else
                        {
                            tbInput.Text = "0";
                        }
                        break;
                    }
                case "=":
                    {
                        if(!String.IsNullOrEmpty(tbTemp.Text))
                        {
                            bool matchOperator = Regex.IsMatch(tbTemp.Text, "[+-×÷]$");
                            if (tbInput.Text == "" )
                            {
                                if (matchOperator)
                                {
                                    // Do Nothing
                                }
                                else
                                {
                                    string preFix = PreFixHeper.Infix2Prefix(tbTemp.Text);
                                    tbRes.Text = PreFixHeper.EvaluatePrefix(preFix).ToString();
                                }
                            }
                            else
                            {
                                tbTemp.Text = tbTemp.Text + tbInput.Text;
                                string preFix = PreFixHeper.Infix2Prefix(tbTemp.Text);
                                tbRes.Text = PreFixHeper.EvaluatePrefix(preFix).ToString();
                            }
                            tbRes.Visible = true;
                            tbInput.Visible = false;
                            tbInput.Clear();
                            tbTemp.Clear();
                        }
                        
                        break;
                    }
            }
        }

        // Nhóm nút bấm toán tử
        private void btnOperator_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                operation = button.Text;

                // Xử lý sự kiện: cho phép đổi phép tính nếu lỡ ấn nhầm.
                bool matchOperator = Regex.IsMatch(tbTemp.Text, "[+-×÷]$");
                bool isOperator = Regex.Match(tbTemp.Text, "[+-×÷]$").Success;
                // Input trống thì không cho nhấn dấu
                if (matchOperator && tbInput.Text == "" && operation != isOperator.ToString())
                {
                    tbTemp.Text = tbTemp.Text.Remove(tbTemp.Text.Length - 1, 1);
                }

                // Xử lý bị đè kết quả phép tính Advanced lên tbTemp
                bool matchAdv = Regex.IsMatch(tbTemp.Text, "[+-×÷][SE]");
                if (matchAdv)
                {
                    tbInput.Text = "";
                }

                bool HaveOperand = Regex.IsMatch(tbTemp.Text, "[0-9]");
                if (tbInput.Text == "" && !HaveOperand)
                {
                    // Do Nothing
                }
                else
                {
                    tbTemp.Text += tbInput.Text + operation;
                }
                
                tbInput.Clear();
            }
            catch
            {
                return;
            }
        }

        // Nhóm nút bấm tính toán nâng cao
        private void btnAdv_Click(object sender, EventArgs e)
        {
            // Xử lý bắt lỗi không có Input
            try
            {
                // xử lý: nếu vừa chỉ ấn mỗi phép tính nâng cao, khi ấn số sẽ clear màn hình
                bool matchAdv = Regex.IsMatch(tbTemp.Text, "^[SE]");
                if (matchAdv)
                {
                    tbTemp.Clear();
                }

                Button button = (Button)sender;

                #region Tính kiểu cũ (không hay)
                //switch (button.Text)
                //{
                //    case "Exp":
                //        {
                //            tbRes.Text = Math.Exp(double.Parse(tbInput.Text)).ToString();
                //            // trả về kết quả phép e mũ x;
                //            tbRes.Visible = true;
                //            tbInput.Visible = false;
                //            tbTemp.Text += "Exp(" + tbInput.Text + ")";
                //            tbInput.Text = tbRes.Text;
                //            break;
                //        }
                //    case "Sqr":
                //        {
                //            tbRes.Text = (double.Parse(tbInput.Text) * double.Parse(tbInput.Text)).ToString();
                //            // trả về kết quả phép tính x bình phương
                //            tbRes.Visible = true;
                //            tbInput.Visible = false;
                //            tbTemp.Text += "Sqr(" + tbInput.Text + ")";
                //            tbInput.Text = tbRes.Text;
                //            break;
                //        }
                //    case "Sqrt":
                //        {
                //            tbRes.Text = Math.Sqrt(double.Parse(tbInput.Text)).ToString();
                //            // trả về kết quả phép tính căn bậc hai của x
                //            tbRes.Visible = true;
                //            tbInput.Visible = false;
                //            tbTemp.Text += "Sqrt(" + tbInput.Text + ")";
                //            tbInput.Text = tbRes.Text;
                //            break;
                //        }
                //}
                #endregion

                // Nếu input trống thì không cho nhấn Sqrt, Sqr, Exp
                if (!String.IsNullOrEmpty(tbInput.Text))
                {
                    tbTemp.Text += button.Text + "(" + tbInput.Text + ")";
                    tbInput.Clear();
                }
            }
            catch
            {
                return;
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("VL Calculator version 0.0.1 \nCreated by Đinh Văn Lực \n" +
                "\nHướng dẫn sử dụng: \n" +
                "- Cho phép nhập các phép tính từ thao tác chuột,\n" +
                "- Tính giá trị của biểu thức theo thứ tự ưu tiên các toán tử\n" +
                " -> Example: Nhân chia trước cộng trừ sau,\n" +
                "- Tính được các phép tính nâng cao: Exp, Sqr (bình phương), Sqrt (căn bậc hai).\n" +
                "\n\n Thêm các tính năng trong bản update mới như sau: \n" +
                "- Tối ưu chạy phép toán bằng phép dịch bit", " About",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
