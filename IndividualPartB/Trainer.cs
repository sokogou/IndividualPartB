//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndividualPartB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainer : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainer()
        {
            this.Courses = new HashSet<Course>();
        }

        public Trainer(string firstName, string lastsName, string subject)
        {
            FirstName = firstName;
            LastsName = lastsName;
            Subject = subject;
        }

       

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastsName { get; set; }
        public string Subject { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
