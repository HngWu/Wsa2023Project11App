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
    public partial class FrmRoomDetails : Form
    {
        int roomId;
        Wsa2023Project11Context context = new Wsa2023Project11Context();
        BindingSource bs = new BindingSource();
        public FrmRoomDetails(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;

            var roomDetails = context.rooms.Where(x => x.ID == roomId).ToList();
            var roomDetail = roomDetails.FirstOrDefault();
            bs.DataSource = roomDetails.Select(x=> new
            {
                x.ID,
                x.RoomNumber,
                x.Capacity,
                x.roomtype1.Type,
                x.Price,
            }).FirstOrDefault();

            dgvroomdetails.DataSource = bs;

            tbdescription.Text = roomDetail.Description;
            var filePath = Path.Combine("C:\\WS C#\\Wsa2023Project11App\\Wsa2023Project11App\\rooms", roomDetail.Photo);
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

        private void FrmRoomDetails_Load(object sender, EventArgs e)
        {

        }

        private void dgvroomdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
