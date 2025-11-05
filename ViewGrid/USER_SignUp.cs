using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ViewGrid
{
    public partial class USER_SignUp : Form
    {
        private readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private string captchaCode;

        public USER_SignUp()
        {
            InitializeComponent();
            Captcha();
        }

        private void Captcha()
        {
            // Generate random 5-character CAPTCHA
            var sb = new StringBuilder(5);
            for (int i = 0; i < 5; i++)
                sb.Append(chars[random.Next(chars.Length)]);
            captchaCode = sb.ToString();

            // Display CAPTCHA text in label
            lblCaptcha.Text = captchaCode;

            // 🎨 Random style for CAPTCHA
            lblCaptcha.ForeColor = System.Drawing.Color.FromArgb(
                random.Next(50, 200),
                random.Next(50, 200),
                random.Next(50, 200));
            lblCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 22, System.Drawing.FontStyle.Italic);

            // Clear text box and result
            txtAnswer.Clear();
            lblResult.Text = "";
        }

        private void USER_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Trim().Equals(captchaCode, StringComparison.OrdinalIgnoreCase))
            {
                lblResult.Text = "Correct!";
                lblResult.ForeColor = System.Drawing.Color.Green;

                USER_SignUpComplete user_signupcomplete = new USER_SignUpComplete();
                USER_SignUp complete = new USER_SignUp();
                
                this.Hide();
                user_signupcomplete.Show();

            }
            else
            {
                lblResult.Text = "Incorrect!";
                lblResult.ForeColor = System.Drawing.Color.Red;

            }
        }

        private void lblRetry_Click(object sender, EventArgs e)
        {
            Captcha();
        }
    }
}
