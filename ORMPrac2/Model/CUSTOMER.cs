//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMPrac2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.ORDER = new HashSet<ORDER>();
        }
    
        public int CUST_CODE { get; set; }
        public string CUST_NAME { get; set; }
        public string CUST_CITY { get; set; }
        public string WORKING_AREA { get; set; }
        public string CUST_COUNTRY { get; set; }
        public int GRADE { get; set; }
        public decimal OPENING_AMT { get; set; }
        public decimal RECEIVE_AMT { get; set; }
        public decimal PAYMENT_AMT { get; set; }
        public decimal OUTSTANDING_AMT { get; set; }
        public string PHONE_NO { get; set; }
        public int AGENTS_CODE { get; set; }
    
        public virtual AGENTS AGENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDER { get; set; }
    }
}
