using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormAppSchedule
{
    public partial class EditMenu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader Reader;
        string Query;
        public EditMenu()
       
        {
            InitializeComponent();
            con = new SqlConnection(MainMenu.ConS);
            con.Open();
            Query = "SELECT * FROM [SCHEDULE] WHERE ScheduleID=@ScheduleID";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ScheduleID", MainMenu.editID);
            Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
               textBoxFirstName.Text = Reader["First_Name"].ToString();
               textBoxLastName.Text = Reader["Last_Name"].ToString();
               textBoxPhoneNumber.Text = Reader["Phone_Number"].ToString();
               textBoxNumberOfGuest.Text = Reader["Number_Of_Guest"].ToString();
               lb_eDate.Text   = Reader["Calender_Date"].ToString();
               comboBoxTimeStart.Text = Reader["Time_Start"].ToString();
       
            }
            string[] TimeStart = { "12:00PM", "01:15PM", "02:30PM", "03:45PM", "04:00PM", "05:15PM", "06:30PM", "07:45PM", "09:00PM", "10:15PM" };

            for(int i = 0; i <TimeStart.Length; i++)
            {
                comboBoxTimeStart.Items.Add(TimeStart[i]);
            }



        }
     
        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult xresult;
               xresult = MessageBox.Show("By Pressing OK the new written information will override the previous data.","Attention!", MessageBoxButtons.OKCancel);

                if(xresult == System.Windows.Forms.DialogResult.OK)
                {
                    con = new SqlConnection(MainMenu.ConS);
                    con.Open();
                    Query = "UPDATE [SCHEDULE] SET First_Name=@First_Name, Last_Name=@Last_Name, Phone_Number=@Phone_Number, Number_Of_Guest=@Number_Of_Guest,Calender_Date=@Calender_Date,Time_Start=@Time_Start WHERE ScheduleID =@ScheduleID";
                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@ScheduleID", MainMenu.editID);
                    cmd.Parameters.AddWithValue("@First_Name", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@Last_Name", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@Phone_Number", textBoxPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Number_Of_Guest", textBoxNumberOfGuest.Text);
              
                    cmd.Parameters.AddWithValue("@Calender_Date", lb_eDate.Text);

                    cmd.Parameters.AddWithValue("@Time_Start", comboBoxTimeStart.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private void editCalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            lb_echangeDate.Text = "New Date";
            lb_eDate.Text = editCalender.SelectionRange.Start.ToShortDateString();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
