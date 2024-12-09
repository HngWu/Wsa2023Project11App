using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsa2023Project11App
{
    public partial class FrmBookRoom : Form
    {
        Wsa2023Project11Context context = new Wsa2023Project11Context();
        int roomId;

        FrmHotel frmHotel;

        public FrmBookRoom(int roomid, FrmHotel frmHotel)
        {
            InitializeComponent();
            this.roomId = roomid;
            this.frmHotel = frmHotel;


            var roomDetails = context.rooms.Where(x => x.ID == roomId).FirstOrDefault();
            lbtype.Text = "Type: " + roomDetails.roomtype1.Type;
            lbprice.Text = "Price: $" + roomDetails.Price.ToString();
            lbcapacity.Text = "Capacity: " + roomDetails.Capacity.ToString();
            lbroomnumber.Text = "R - " + roomDetails.RoomNumber.ToString();


            tbdescription.Text = roomDetails.Description;
            var filePath = Path.Combine("C:\\WS C#\\Wsa2023Project11App\\Wsa2023Project11App\\rooms", roomDetails.Photo);
            pbimage.Size = new Size(300, 200);
            pbimage.SizeMode = PictureBoxSizeMode.StretchImage;

            if (System.IO.File.Exists(filePath))
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (var ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    pbimage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbimage.Image = null;
            }



        }

        private void tbdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbimage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmBookRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            string roomDescription = tbdescription.Text.ToString();
            string guestName = tbguest.Text.ToString();
            string phone = tbphone.Text.ToString();
            DateTime dateFrom = dtpcheckin.Value;
            DateTime dateTo = dtpcheckout.Value;

            var hotel = context.rooms.Where(x=>x.ID == roomId).FirstOrDefault();
            try
            {
                if (hotel.bookings.Any(b => b.RoomID == roomId && ((dateFrom <= b.Date_To && dateTo >= b.Date_From))))
                {
                    MessageBox.Show("Room already booked between these dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrEmpty(roomDescription) || string.IsNullOrEmpty(guestName) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (DateTime.Compare(dateTo, dateFrom) < 0)
                {
                    MessageBox.Show("The to date  cannot be before the from date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(phone, out int intphone))
                {
                    MessageBox.Show("The Phone Number must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int numberOfNights = (int)(dateTo.Date - dateFrom.Date).TotalDays;
                decimal totalCost = decimal.Parse(tbtotal.Text);


                if (numberOfNights <= 0)
                {
                       MessageBox.Show("The number of nights must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newBooking = new booking
                {
                    Date = DateTime.Now,
                    Guest = guestName,
                    Phone = phone.ToString(),
                    RoomID = roomId,
                    Date_From = dateFrom,
                    Date_To = dateTo,
                    checkoutdate = null,
                    Total = totalCost,
                    UserID = common.userId,

                };


                context.bookings.Add(newBooking);
                context.SaveChanges();
                MessageBox.Show("Booking successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmHotel.getBookings();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error has occured");
            }

            
            // Calculate the number of nights


            // Display the booking details
        }

        private void dtpcheckout_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpcheckin.Value;
            DateTime dateTo = dtpcheckout.Value;

            try
            {
                int numberOfNights = (int)(dateTo.Date - dateFrom.Date).TotalDays;
                var roomPrice = context.rooms.Where(x => x.ID == roomId).Select(x => x.Price).FirstOrDefault();
                // Calculate the total cost
                decimal price = (decimal)roomPrice; // Replace this with your actual method to retrieve the room price
                decimal totalCost = price * numberOfNights;
                tbtotal.Text =  totalCost.ToString();
                tbnights.Text =  numberOfNights.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error please input the correct details");
            }
          
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
