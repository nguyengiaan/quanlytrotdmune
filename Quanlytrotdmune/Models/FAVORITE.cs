//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlytrotdmune.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAVORITE
    {
        public int favorite_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> room_id { get; set; }
        public string name { get; set; }
        public Nullable<double> price { get; set; }
    
        public virtual ROOM ROOM { get; set; }
        public virtual USERTRO USERTRO { get; set; }
    }
}
