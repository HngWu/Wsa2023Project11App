//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wsa2023Project11App
{
    using System;
    using System.Collections.Generic;
    
    public partial class booking
    {
        public int id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Guest { get; set; }
        public string Phone { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<System.DateTime> Date_From { get; set; }
        public Nullable<System.DateTime> Date_To { get; set; }
        public string checkoutdate { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual room room { get; set; }
        public virtual user user { get; set; }
    }
}