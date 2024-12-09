namespace Wsa2023Project11App
{
    partial class FrmBookRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbdescription = new System.Windows.Forms.RichTextBox();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpcheckin = new System.Windows.Forms.DateTimePicker();
            this.dtpcheckout = new System.Windows.Forms.DateTimePicker();
            this.tbguest = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbnights = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbook = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lbroomnumber = new System.Windows.Forms.Label();
            this.lbcapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbdescription
            // 
            this.tbdescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbdescription.Location = new System.Drawing.Point(393, 136);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.ReadOnly = true;
            this.tbdescription.Size = new System.Drawing.Size(477, 107);
            this.tbdescription.TabIndex = 6;
            this.tbdescription.Text = "";
            this.tbdescription.TextChanged += new System.EventHandler(this.tbdescription_TextChanged);
            // 
            // pbimage
            // 
            this.pbimage.Location = new System.Drawing.Point(54, 70);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(300, 200);
            this.pbimage.TabIndex = 5;
            this.pbimage.TabStop = false;
            this.pbimage.Click += new System.EventHandler(this.pbimage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Details";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.Location = new System.Drawing.Point(389, 246);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(53, 24);
            this.lbtype.TabIndex = 9;
            this.lbtype.Text = "Type";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprice.Location = new System.Drawing.Point(732, 246);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(138, 24);
            this.lbprice.TabIndex = 10;
            this.lbprice.Text = "Price: $0000.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Booking Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date From:";
            // 
            // dtpcheckin
            // 
            this.dtpcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcheckin.Location = new System.Drawing.Point(173, 403);
            this.dtpcheckin.Name = "dtpcheckin";
            this.dtpcheckin.Size = new System.Drawing.Size(179, 31);
            this.dtpcheckin.TabIndex = 12;
            // 
            // dtpcheckout
            // 
            this.dtpcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpcheckout.Location = new System.Drawing.Point(469, 403);
            this.dtpcheckout.Name = "dtpcheckout";
            this.dtpcheckout.Size = new System.Drawing.Size(179, 31);
            this.dtpcheckout.TabIndex = 13;
            this.dtpcheckout.ValueChanged += new System.EventHandler(this.dtpcheckout_ValueChanged);
            // 
            // tbguest
            // 
            this.tbguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbguest.Location = new System.Drawing.Point(173, 357);
            this.tbguest.Name = "tbguest";
            this.tbguest.Size = new System.Drawing.Size(290, 31);
            this.tbguest.TabIndex = 16;
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(580, 357);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(290, 31);
            this.tbphone.TabIndex = 17;
            // 
            // tbnights
            // 
            this.tbnights.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnights.Location = new System.Drawing.Point(749, 402);
            this.tbnights.Name = "tbnights";
            this.tbnights.Size = new System.Drawing.Size(121, 31);
            this.tbnights.TabIndex = 18;
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(173, 450);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(121, 31);
            this.tbtotal.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Guest:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(664, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nights:";
            // 
            // btnbook
            // 
            this.btnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(575, 521);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(139, 34);
            this.btnbook.TabIndex = 24;
            this.btnbook.Text = "Book Now";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(746, 521);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(124, 34);
            this.btncancel.TabIndex = 25;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lbroomnumber
            // 
            this.lbroomnumber.AutoSize = true;
            this.lbroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbroomnumber.Location = new System.Drawing.Point(389, 70);
            this.lbroomnumber.Name = "lbroomnumber";
            this.lbroomnumber.Size = new System.Drawing.Size(39, 24);
            this.lbroomnumber.TabIndex = 26;
            this.lbroomnumber.Text = "R - ";
            // 
            // lbcapacity
            // 
            this.lbcapacity.AutoSize = true;
            this.lbcapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcapacity.Location = new System.Drawing.Point(576, 70);
            this.lbcapacity.Name = "lbcapacity";
            this.lbcapacity.Size = new System.Drawing.Size(81, 24);
            this.lbcapacity.TabIndex = 27;
            this.lbcapacity.Text = "Capacity";
            // 
            // FrmBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 595);
            this.Controls.Add(this.lbcapacity);
            this.Controls.Add(this.lbroomnumber);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tbnights);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbguest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpcheckin);
            this.Controls.Add(this.dtpcheckout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdescription);
            this.Controls.Add(this.pbimage);
            this.Name = "FrmBookRoom";
            this.Text = "FrmBookRoom";
            this.Load += new System.EventHandler(this.FrmBookRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbdescription;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpcheckin;
        private System.Windows.Forms.DateTimePicker dtpcheckout;
        private System.Windows.Forms.TextBox tbguest;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbnights;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lbroomnumber;
        private System.Windows.Forms.Label lbcapacity;
    }
}