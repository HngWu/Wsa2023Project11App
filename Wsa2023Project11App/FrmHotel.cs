using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsa2023Project11App
{
    public partial class FrmHotel : Form
    {
        Wsa2023Project11Context context = new Wsa2023Project11Context();
        BindingSource hotelbs = new BindingSource();
        public FrmHotel()
        {
            InitializeComponent();
            // Clear the rows and columns in the table layout panel
            // Clear the rows and columns in the table layout panel

            this.WindowState = FormWindowState.Maximized;
            cbtype.Items.Add("All");

            var types = context.roomtypes
                .Select(x => x.Type)
                .ToArray();
            cbtype.Items.AddRange(types);
            cbtype.SelectedIndex = 0;
            cbprice.SelectedIndex = 0;
            getRooms();
            getBookings();

            DataGridViewButtonColumn checkoutButton = new DataGridViewButtonColumn();
            checkoutButton.HeaderText = "Check Out";
            checkoutButton.Text = "Check Out";
            checkoutButton.Name = "Check Out";
            checkoutButton.UseColumnTextForButtonValue = true;
            dgvbookings.Columns.Add(checkoutButton);
            // Add the following code after the foreach loop in the FrmHotel constructor

           

            // Add the following code after the foreach loop in the FrmHotel constructor

            // Set the button text for each row in the checkout column
        }
        public void getRooms()
        {
            tlphotels.Controls.Clear();
            tlphotels.ColumnStyles.Clear();
            tlphotels.RowStyles.Clear();

            // Set the number of columns to display rooms in a row
            tlphotels.ColumnCount = 6;

            int minPrice = 0;
            int maxPrice = 0;


           

          

            


            string selectedPriceRange = cbprice.SelectedItem.ToString();
            switch (selectedPriceRange)
            {
                case "All":
                    minPrice = 0;
                    maxPrice = 10000000;
                    break;
                case "0-2000":
                    minPrice = 0;
                    maxPrice = 2000;
                    break;
                case "2001-4000":
                    minPrice = 2001;
                    maxPrice = 4000;
                    break;
                case "4001-6000":
                    minPrice = 4001;
                    maxPrice = 6000;
                    break;
                case "6001-8000":
                    minPrice = 6001;
                    maxPrice = 8000;
                    break;
                case "8001-10000":
                    minPrice = 8001;
                    maxPrice = 10000;
                    break;
                default:
                    // Invalid price range selected
                    MessageBox.Show("Invalid price range selected.");
                    return;
            }

            var priceFrom = tbpricefrom.Text.ToString();
            var priceTo = tbpriceto.Text.ToString();
            if (string.IsNullOrEmpty(priceFrom))
            {

            }
            else
            {
                if (!int.TryParse(priceFrom, out minPrice))
                {
                    MessageBox.Show("Invalid input for minimum price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(priceTo))
            {

            }
            else
            {
                if (!int.TryParse(priceTo, out maxPrice))
                {
                    MessageBox.Show("Invalid input for maximum price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Validate the input for minPrice and maxPrice




            // Continue with the rest of the code

            // Retrieve the selected room type
            string selectedRoomType = cbtype.SelectedItem.ToString();

            // Retrieve the selected check-in and check-out dates
            DateTime checkInDate = dtpcheckin.Value.Date;
            DateTime checkOutDate = dtpcheckout.Value.Date;


            var selectedRoomId = context.roomtypes.Where(x=>x.Type == selectedRoomType)
                .Select(x => x.id)
                .FirstOrDefault();

            // Perform the search based on the selected criteria
            var hotels = context.rooms
                .Where(r => r.Price >= minPrice && r.Price <= maxPrice)
                .Where(r => selectedRoomType == "All" || r.RoomType == selectedRoomId)
                .OrderBy(r => r.bookings.Any(b => (checkInDate <= b.Date_To && checkOutDate >= b.Date_From)))
                .ToList();




            //var hotels = context.rooms
            //    .OrderBy(x => x.bookings.Count).ToList();
            foreach (var hotel in hotels)
            {
                // Create a new panel to display hotel information
                Panel hotelPanel = new Panel();
                hotelPanel.BorderStyle = BorderStyle.FixedSingle;
                hotelPanel.Size = new Size(300, 400);

                // Create and configure the picture box
                var filePath = Path.Combine("C:\\WS C#\\Wsa2023Project11App\\Wsa2023Project11App\\rooms", hotel.Photo);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(300, 200);
                pictureBox.Location = new Point(0, 0);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                if (System.IO.File.Exists(filePath))
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    using (var ms = new MemoryStream())
                    {
                        fileStream.CopyTo(ms);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox.Image = null;
                }

                Label roomTypeLabel = new Label();
                roomTypeLabel.Text = "Room Type: " + hotel.roomtype1.Type;
                roomTypeLabel.Location = new Point(10, pictureBox.Bottom + 10);
                roomTypeLabel.AutoSize = true;

                // Create labels to display hotel details with updated positions
                Label nameLabel = new Label();
                nameLabel.Text = "Price: $" + hotel.Price;
                nameLabel.Location = new Point(10, roomTypeLabel.Bottom + 10);
                nameLabel.AutoSize = true;

                Label addressLabel = new Label();
                addressLabel.Text = "R - " + hotel.RoomNumber.ToString();
                addressLabel.Location = new Point(10, nameLabel.Bottom + 10);
                addressLabel.AutoSize = true;

                Label ratingLabel = new Label();
                ratingLabel.Text = "Capacity: " + hotel.Capacity;
                ratingLabel.Location = new Point(10, addressLabel.Bottom + 10);
                ratingLabel.AutoSize = true;


                Button bookButton = new Button();
                bookButton.Text = "Book";
                bookButton.Location = new Point(10, ratingLabel.Bottom + 10);
                bookButton.AutoSize = true;
                bookButton.Click += (sender, e) =>
                {
                    // Retrieve the ID of the clicked hotel card
                    int hotelID = hotel.ID;
                    FrmBookRoom frmBookRoom = new FrmBookRoom(hotelID, this);
                    frmBookRoom.ShowDialog();
                };

                Button detailButton = new Button();
                detailButton.Text = "Details";
                detailButton.Location = new Point(bookButton.Right + 10, ratingLabel.Bottom + 10);
                detailButton.AutoSize = true;
                detailButton.Click += (sender, e) =>
                {
                    // Retrieve the ID of the clicked hotel card
                    int hotelID = hotel.ID;
                    FrmRoomDetails frmRoomDetails = new FrmRoomDetails(hotelID);
                    frmRoomDetails.ShowDialog();

                };

                bookButton.ForeColor = Color.White;

                if (hotel.bookings.Any(b => (checkInDate <= b.Date_To && (string.IsNullOrEmpty(b.checkoutdate) ||  checkOutDate >= DateTime.Parse(b.checkoutdate)))))
                {
                    // Date ranges clash
                    hotelPanel.BackColor = Color.Red;
                    bookButton.ForeColor = Color.Black;
                    bookButton.Visible = false;
                }

                bookButton.Enabled = !hotel.bookings.Any(b => (checkInDate <= b.Date_To && (string.IsNullOrEmpty(b.checkoutdate) || checkOutDate >= DateTime.Parse(b.checkoutdate))));
                bookButton.BackColor = Color.Green;
                detailButton.BackColor = Color.LightGray;

                // Add controls to the hotel panel in the correct order
                hotelPanel.Controls.AddRange(new Control[]
                {
                    roomTypeLabel,
                    pictureBox,
                    nameLabel,
                    addressLabel,
                    ratingLabel,
                    bookButton,
                    detailButton
                });

                // Add the hotel panel to the tlbhotels control
                tlphotels.Controls.Add(hotelPanel);
            }

            // Optional: Set equal column widths
            for (int i = 0; i < tlphotels.ColumnCount; i++)
            {
                tlphotels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / tlphotels.ColumnCount));
            }
        }

        public void getBookings()
        {

            DateTime checkInDate = dtpcheckin.Value.Date;
            DateTime checkOutDate = dtpcheckout.Value.Date;

            var bookings = context.bookings.Where(b => b.Date_From <= checkOutDate && ( string.IsNullOrEmpty(b.checkoutdate) ||  b.Date_To >= checkInDate))
                            .Select(x => new
                            {
                                x.id,
                                x.Guest,
                                x.room.roomtype1.Type,
                                x.RoomID,
                                price = x.room.Price,
                                duration = DbFunctions.DiffDays(x.Date_From, x.Date_To), // Calculate the duration in hours
                                x.Date_From,
                                x.Date_To,
                                checkoutdate = x.checkoutdate,
                                Status = x.checkoutdate == null ? "Not Checked Out" : "Checked Out",
                                total = x.Total,
                            }).ToList();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Guest", typeof(string));
            dataTable.Columns.Add("Room Type", typeof(string));
            dataTable.Columns.Add("Room ID", typeof(int));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Duration", typeof(int));
            dataTable.Columns.Add("Date From", typeof(DateTime));
            dataTable.Columns.Add("Date To", typeof(DateTime));
            dataTable.Columns.Add("Checkout Date", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            dataTable.Columns.Add("Total", typeof(decimal));
            foreach (var booking in bookings)
            {
                dataTable.Rows.Add(
                    booking.id,
                    booking.Guest,
                    booking.Type,
                    booking.RoomID,
                    booking.price,
                    booking.duration,
                    booking.Date_From,
                    booking.Date_To,
                    booking.checkoutdate,
                    booking.Status,
                    booking.total
                );
            }

            dgvbookings.DataSource = dataTable;


        }

        private void FrmHotel_Load(object sender, EventArgs e)
        {

        }

        private void tlphotels_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvbookings.Columns["Check Out"].Index)
                {
                    int bookingId = (int)dgvbookings.Rows[e.RowIndex].Cells["id"].Value;
                    var booking = context.bookings.Find(bookingId);

                    if (booking.checkoutdate != null)
                    {
                        MessageBox.Show("This booking has already been checked out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    booking.checkoutdate = DateTime.Today.ToString("yyyy-MM-dd");
                    context.bookings.AddOrUpdate(booking);
                    context.SaveChanges();
                    getBookings();
                    dgvbookings.Rows[e.RowIndex].Cells["Checkout"].Value = "Checked Out";
                    MessageBox.Show("Checkout successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Misclick");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            // Retrieve the selected price range



            if(DateTime.Compare(dtpcheckin.Value, dtpcheckout.Value) > 0)
            {
                MessageBox.Show("The check-in date cannot be after the check-out date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            getRooms();
            getBookings();
        }
    }
}
