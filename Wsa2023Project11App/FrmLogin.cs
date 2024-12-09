using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsa2023Project11App
{
    public partial class FrmLogin : Form
    {
        Wsa2023Project11Context context = new Wsa2023Project11Context();
        private int loginAttempts = 0;
        private DateTime lastLoginAttemptTime;
        private Timer countdownTimer;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var username = tbusername.Text.ToString();
            var password = tbpassword.Text.ToString();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter username and password");
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        lastLoginAttemptTime = DateTime.Now;
                        MessageBox.Show("Incorrect username/password. Please wait for 10 seconds before attempting to login again.");
                        StartCountdownTimer();
                    }
                    return;
                }
                if (loginAttempts >= 3 && DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds < 10)
                {
                    MessageBox.Show("Please wait for 10 seconds before attempting to login again.");
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        lastLoginAttemptTime = DateTime.Now;
                        MessageBox.Show("Incorrect username/password. Please wait for 10 seconds before attempting to login again.");
                        StartCountdownTimer();
                    }
                    return;
                }

                var isUser = context.users.Where(u => u.username == username && u.password == password ).FirstOrDefault();
             
                if (isUser != null)
                {
                    if (isUser.validity <= DateTime.Now)
                    {
                        MessageBox.Show("Your account is expired. Please contact the administrator.");
                        loginAttempts++;
                        if (loginAttempts >= 3)
                        {
                            lastLoginAttemptTime = DateTime.Now;
                            MessageBox.Show("Incorrect username/password. Please wait for 10 seconds before attempting to login again.");
                            StartCountdownTimer();
                        }
                        return;
                    }
                    MessageBox.Show("Login successful");
                    loginAttempts = 0;
                    common.userId = isUser.id;


                    if(isUser.role == "Administrator")
                    {
                        FrmHotelStuff frmHotelStuff = new FrmHotelStuff();
                        frmHotelStuff.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmHotel frmHotel = new FrmHotel();
                        frmHotel.Show();
                        this.Hide();
                    }

                    
                }
                else
                {
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        lastLoginAttemptTime = DateTime.Now;
                        MessageBox.Show("Incorrect username/password. Please wait for 10 seconds before attempting to login again.");
                        StartCountdownTimer();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to login.");
            }
        }

        private void StartCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
            btnlogin.Enabled = false;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            var remainingSeconds = (int)(10 - DateTime.Now.Subtract(lastLoginAttemptTime).TotalSeconds);
            if (remainingSeconds > 0)
            {
                btnlogin.Text = $"{remainingSeconds}";
            }
            else
            {
                countdownTimer.Stop();
                btnlogin.Text = "Login";
                btnlogin.Enabled = true;
                loginAttempts = 0;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
