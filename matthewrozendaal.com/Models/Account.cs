//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace matthewrozendaal.com.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.People = new HashSet<Person>();
            this.People1 = new HashSet<Person>();
            this.Point_Changes = new HashSet<Point_Changes>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> lastLoginDate { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Person> People1 { get; set; }
        public virtual ICollection<Point_Changes> Point_Changes { get; set; }
    }
}