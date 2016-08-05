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
    public partial class MainMenu : Form
    {
        public static string ConS = @"Server=tcp:danphung.database.windows.net,1433;Data Source=danphung.database.windows.net;Initial Catalog=eSchedule;Persist Security Info=False;User ID=DanTheMan;Password=Danspassword!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static string editID;

        int xxxb = 0;

        public MainMenu()
        {
            InitializeComponent();
            Do_Checked();
            lb_timeSelected.Text = "";
            lb_Calenderselected.Text = "Please Select a Calender Date";

          
        }

        
        SqlConnection con;
        SqlDataReader Reader;
        string Query;
        string timestart;
        string timeend;

        
        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            lb_Calenderselected.Text = Calender.SelectionRange.Start.ToLongDateString();
        }
        private void Do_Checked()
        {
            if (rBut12_115.Checked == true)
            {
                lb_timeSelected.Text = "12PM-1:15PM";
                timestart = "12:00PM";
                timeend = "01:15PM";
            }
            else if (rBut115_230.Checked == true)
            {
                lb_timeSelected.Text = "1:15PM-2:30PM";
                timestart = "01:15PM";
                timeend = "02:30PM";
            }
            else if (rBut230_345.Checked == true)
            {
                lb_timeSelected.Text = "2:30PM-3:45PM";
                timestart = "02:30PM";
                timeend = "03:45PM";
            }
            else if (rBut345_4.Checked == true)
            {
                lb_timeSelected.Text = "3:45PM-4:00PM";
                timestart = "03:45PM";
                timeend = "04:00PM";
            }
            else if (rBut4_515.Checked == true)
            {
                lb_timeSelected.Text = "4:00PM-5:15PM";
                timestart = "04:00PM";
                timeend = "05:15PM";
            }
            else if (rBut515_630.Checked == true)
            {
                lb_timeSelected.Text = "5:15PM-6:30PM";
                timestart = "05:15PM";
                timeend = "06:30PM";
            }
            else if (rBut630_745.Checked == true)
            {
                lb_timeSelected.Text = "6:30PM-7:45PM";
                timestart = "06:30PM";
                timeend = "07:45PM";
            }
            else if (rBut745_900.Checked == true)
            {
                lb_timeSelected.Text = "7:45PM-9:00PM";
                timestart = "07:45PM";
                timeend = "09:00PM";
            }
            else if (rBut900_1015.Checked == true)
            {
                lb_timeSelected.Text = "9:00PM-10:15PM";
                timestart = "09:00PM";
                timeend = "10:15PM";
            }
            else if (rBut1015_1130.Checked == true)
            {
                lb_timeSelected.Text = "10:15PM-11:30PM";
                timestart = "10:15PM";
                timeend = "11:30PM";
            }
        }
        private void rBut12_115_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut115_230_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut230_345_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut345_4_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut4_515_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut515_630_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut630_745_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut745_900_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut900_1015_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void rBut1015_1130_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void But_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult xresult;
                if(textFirstName.TextLength < 20 && textLastName.TextLength < 20 && textGuest.TextLength < 2 && textPhone.TextLength <= 11)
                { 
                if (lb_timeSelected.Text == "" || lb_Calenderselected.Text == "Please Select a Calender Date" || textFirstName.Text == "" || textLastName.Text == "" || textGuest.Text == "" || textPhone.Text =="")
                {
                    MessageBox.Show("One or more information is messing! Please make sure all information is fill completely!");
                }
                else
                {
                    string[] inFormation = new string[6] { lb_Calenderselected.Text, lb_timeSelected.Text, textFirstName.Text, textLastName.Text, textPhone.Text, textGuest.Text };
                    string disPlay = string.Join(Environment.NewLine, inFormation);
                 xresult = MessageBox.Show("Please make sure everything is correct. \n" + disPlay,  "Guest Application", MessageBoxButtons.OKCancel);

                       con = new SqlConnection(ConS);
                        con.Open();
                        
                       string Query2 = "SELECT* FROM[SCHEDULE] WHERE Calender_Date = @Calender_Date AND Time_Start=@Time_Start";
                        SqlCommand cmd2 = new SqlCommand(Query2, con);
                        cmd2.Parameters.AddWithValue("@Calender_Date", Calender.SelectionRange.Start.ToShortDateString());
                        cmd2.Parameters.AddWithValue("@Time_Start", timestart);
                        Reader = cmd2.ExecuteReader();

                        if (Reader.Read())
                        {
                            MessageBox.Show("There is already a appointment at that time.");
                        }
                        
                       else if  (xresult == System.Windows.Forms.DialogResult.OK)
                        {
                            Do_Checked();
                            con = new SqlConnection(ConS);
                            con.Open();
                            Query = "INSERT INTO [SCHEDULE]  (First_Name, Last_Name, Phone_Number, Number_Of_Guest, Calender_Date, Time_Start, Time_End) VALUES (@First_Name, @Last_Name, @Phone_Number, @Number_Of_Guest, @Calender_Date, @Time_Start, @Time_End)";
                            SqlCommand cmd = new SqlCommand(Query, con);
                            cmd.Parameters.AddWithValue("@First_Name", textFirstName.Text);
                            cmd.Parameters.AddWithValue("@Last_Name", textLastName.Text);
                            cmd.Parameters.AddWithValue("@Phone_Number", textPhone.Text);
                            cmd.Parameters.AddWithValue("@Number_Of_Guest", textGuest.Text);
                            cmd.Parameters.AddWithValue("@Calender_Date", Calender.SelectionRange.Start.ToShortDateString());
                            cmd.Parameters.AddWithValue("@Time_Start", timestart);
                            cmd.Parameters.AddWithValue("@Time_End", timeend);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            con = new SqlConnection(ConS);
                            con.Open();

                            string Query3 = "SELECT* FROM[SCHEDULE] WHERE Calender_Date = @Calender_Date AND Time_Start=@Time_Start";
                            SqlCommand cmd3 = new SqlCommand(Query3, con);
                            cmd3.Parameters.AddWithValue("@Calender_Date", Calender.SelectionRange.Start.ToShortDateString());
                            cmd3.Parameters.AddWithValue("@Time_Start", timestart);
                            Reader = cmd3.ExecuteReader();

                            if (Reader.Read())
                            {
                                MessageBox.Show("You're conformation number is "+ Reader["ScheduleID"].ToString());
                            }

                        }


                    }

                }
                else
                {
                    MessageBox.Show("Please make sure your name and last name is within a 20 characters, \nGuest should only be 1 to 15, \nand phone number should be less than 11 numbers.");
                }

            }
            finally
            {
        
            }
        }

        private void butLookupEnter_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConS);
                con.Open();
                Query = "SELECT * FROM [SCHEDULE] WHERE ScheduleID= @ScheduleID";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ScheduleID", textLookUp.Text);
                Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    lb_cFirstName.Text = Reader["First_Name"].ToString();
                    lb_cLastName.Text = Reader["Last_Name"].ToString();
                    lb_cPhoneNumber.Text = Reader["Phone_Number"].ToString();
                    lb_cNumberGuest.Text = Reader["Number_Of_Guest"].ToString();

                    lb_cDate.Text = Reader["Calender_Date"].ToString();
                    comboTime.Text = Reader["Time_Start"].ToString();

          
                }
                else
                {
                    MessageBox.Show("There is no appointment with that last name.");
                }
          
            
            }
            finally
            {
                Reader.Close();
                con.Close();
                xxxb = 1;
  
            }
        }

        private void currentCSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                con = new SqlConnection(ConS);
                con.Open();
                Query = "SELECT * FROM [SCHEDULE] WHERE Calender_Date=@Calender_Date";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Calender_Date", currentCSchedule.SelectionRange.Start.ToShortDateString());
                Reader = cmd.ExecuteReader();
                comboTime.Items.Clear();
                comboTime.SelectedIndex = -1;
                comboTime.Text = "";

                while (Reader.Read())
                {
                    comboTime.Items.Add(Reader["Time_Start"].ToString());

                }


            }
            finally
            {
               
                Reader.Close();
                con.Close();
            }
        }

        private void comboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConS);
                con.Open();
                Query = "SELECT * FROM [SCHEDULE] WHERE Time_Start=@Time_Start AND Calender_Date=@Calender_Date";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Time_Start", this.comboTime.GetItemText(this.comboTime.SelectedItem));
                cmd.Parameters.AddWithValue("@Calender_Date", currentCSchedule.SelectionRange.Start.ToShortDateString());
                Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {
                    lb_cFirstName.Text = Reader["First_Name"].ToString();
                    lb_cLastName.Text = Reader["Last_Name"].ToString();
                    lb_cPhoneNumber.Text = Reader["Phone_Number"].ToString();
                    lb_cNumberGuest.Text = Reader["Number_Of_Guest"].ToString();
                    lb_cDate.Text = Reader["Calender_Date"].ToString();
                    textLookUp.Text = Reader["ScheduleID"].ToString();



                }
            }
            finally
            {

                Reader.Close();
                con.Close();
                xxxb = 1;
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult xresult;

                xresult = MessageBox.Show("Pressing OK will delete the currecnt schedule. \n Are you sure?", "warning!", MessageBoxButtons.OKCancel);


                if (xresult == System.Windows.Forms.DialogResult.OK)
                {
                    con = new SqlConnection(ConS);
                    con.Open();
                    Query = "DELETE FROM [SCHEDULE] WHERE First_Name=@First_Name AND Last_Name=@Last_Name AND Time_Start=@Time_Start";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@First_Name", lb_cFirstName.Text);
                    cmd.Parameters.AddWithValue("@Last_Name", lb_cLastName.Text);
                    cmd.Parameters.AddWithValue("@Time_Start", comboTime.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                   
                }

            }
            finally
            {
               comboTime.Text = "";
                con = new SqlConnection(ConS);
                con.Open();
                Query = "SELECT * FROM [SCHEDULE] WHERE Calender_Date=@Calender_Date";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Calender_Date", currentCSchedule.SelectionRange.Start.ToShortDateString());
                Reader = cmd.ExecuteReader();
                comboTime.Items.Clear();
                comboTime.SelectedIndex = -1;
                comboTime.Text = "";

                while (Reader.Read())
                {
                    comboTime.Items.Add(Reader["Time_Start"].ToString());

                }
                Reader.Close();
                con.Close();

                lb_cFirstName.Text = "First Name";
                lb_cLastName.Text = "Last Name";
                lb_cPhoneNumber.Text = "Phone Number";
                lb_cNumberGuest.Text = "Number Of Guest";
                lb_cDate.Text = "Date";
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (xxxb == 1)
            {
                try
                {
                    con = new SqlConnection(ConS);
                    con.Open();
                    Query = "SELECT * FROM [SCHEDULE] WHERE Time_Start=@Time_Start AND Last_Name=@Last_Name";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@Last_Name", lb_cLastName.Text);
                    cmd.Parameters.AddWithValue("@Time_Start", this.comboTime.GetItemText(this.comboTime.SelectedItem));
                    Reader = cmd.ExecuteReader();

                    if (Reader.Read())
                    {
                        editID = Reader["ScheduleID"].ToString();
                    }
                }
                finally
                {

                    EditMenu xEditMenu = new EditMenu();
                    xEditMenu.Show();
                    Reader.Close();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please use the calender or the lookup to find the schedule");
            }
        }

        private void vDatePicker_ValueChanged(object sender, EventArgs e)
        {
            vlistVIEW.Items.Clear();
            string theDate = vDatePicker.Value.ToString("MM/dd/yyyy");
            try
            {
                vlistVIEW.View = View.Details;
                
                con = new SqlConnection(ConS);
                con.Open();
               Query = "SELECT * FROM [SCHEDULE] WHERE Calender_Date=@Calender_Date";
          


                SqlDataAdapter ada = new SqlDataAdapter(Query, con);
                ada.SelectCommand.Parameters.Add("@Calender_Date", SqlDbType.Date).Value = theDate;

                DataTable dt = new DataTable();
                ada.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem vItems = new ListViewItem(dr["First_Name"].ToString());
                    vItems.SubItems.Add(dr["Last_Name"].ToString());
                    vItems.SubItems.Add(dr["Phone_Number"].ToString());
                    vItems.SubItems.Add(dr["Number_Of_Guest"].ToString());
                    vItems.SubItems.Add(dr["Time_Start"].ToString());
                    vItems.SubItems.Add(dr["Time_End"].ToString());

                    vlistVIEW.Items.Add(vItems);
                }

            }
            finally
            {
    
                con.Close();
            }
        }
    }
}
