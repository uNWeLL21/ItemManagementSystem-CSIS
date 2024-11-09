using Item_Management_System___CSIS.DB_Connection;
using System;
using System.Windows.Forms;

namespace Item_Management_System___CSIS.Forms
{
    public partial class FormLogin : Form
    {
        #region"Variables"
        Database DB = new Database();
        private int trial = 0;
        private int second = 0;
        private bool cooldown = false;
        #endregion
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if(!cooldown)
            {
                if(TBUsername.Text == "" || TBPassword.Text == "")
                {
                    MessageBox.Show("Enter a complete credeantials!");
                    return;
                }
                if (DB.Validate(TBUsername.Text, TBPassword.Text))
                {
                    TBPassword.Clear();
                    TBUsername.Clear();
                    this.Hide();

                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                else
                {
                    trial++;
                    if (trial > 2)
                    {
                        second = 10;
                        cooldown = true;
                        labelMeg.Visible = true;
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cooldown)
            {
                second--;
                labelMeg.Text = $"Try again after {second} second/s";
                if(second == 0)
                {
                    labelMeg.Visible = false;
                    trial = 0;
                    cooldown = false;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
