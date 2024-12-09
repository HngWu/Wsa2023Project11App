namespace Wsa2023Project11App
{
    partial class FrmRoomDetails
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
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.tbdescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvroomdetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroomdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pbimage
            // 
            this.pbimage.Location = new System.Drawing.Point(28, 91);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(300, 200);
            this.pbimage.TabIndex = 0;
            this.pbimage.TabStop = false;
            // 
            // tbdescription
            // 
            this.tbdescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbdescription.Location = new System.Drawing.Point(351, 184);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(413, 107);
            this.tbdescription.TabIndex = 1;
            this.tbdescription.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Details";
            // 
            // dgvroomdetails
            // 
            this.dgvroomdetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvroomdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvroomdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroomdetails.Location = new System.Drawing.Point(351, 91);
            this.dgvroomdetails.Name = "dgvroomdetails";
            this.dgvroomdetails.Size = new System.Drawing.Size(413, 54);
            this.dgvroomdetails.TabIndex = 3;
            this.dgvroomdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroomdetails_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // FrmRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvroomdetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdescription);
            this.Controls.Add(this.pbimage);
            this.Name = "FrmRoomDetails";
            this.Text = "FrmRoomDetails";
            this.Load += new System.EventHandler(this.FrmRoomDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroomdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.RichTextBox tbdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvroomdetails;
        private System.Windows.Forms.Label label2;
    }
}