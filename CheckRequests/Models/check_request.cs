//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckRequests.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class check_request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public check_request()
        {
            this.check_request_audit = new HashSet<check_request_audit>();
            this.check_request_detail = new HashSet<check_request_detail>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date_needed { get; set; }
        public System.DateTime requested_date { get; set; }
        public int postage { get; set; }
        public string comments { get; set; }
        public Nullable<int> business_action { get; set; }
        public string business_notes { get; set; }
        public Nullable<int> final_action { get; set; }
        public string AP_notes { get; set; }
        public Nullable<int> processing_state { get; set; }
        public Nullable<int> processed_by { get; set; }
        public Nullable<System.DateTime> processed_date { get; set; }
        public Nullable<int> approved_by { get; set; }
        public Nullable<int> final_approval_by { get; set; }
        public string check_number { get; set; }
        public int create_by { get; set; }
        public System.DateTime create_date { get; set; }
        public int last_update_by { get; set; }
        public System.DateTime last_update_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<check_request_audit> check_request_audit { get; set; }
        public virtual check_request_action check_request_action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<check_request_detail> check_request_detail { get; set; }
        public virtual check_request_action check_request_action1 { get; set; }
        public virtual check_request_postage check_request_postage { get; set; }
        public virtual check_request_processing_state check_request_processing_state { get; set; }
    }
}