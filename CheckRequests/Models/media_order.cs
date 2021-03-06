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
    
    public partial class media_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public media_order()
        {
            this.check_request_detail = new HashSet<check_request_detail>();
            this.media_order_detail = new HashSet<media_order_detail>();
            this.media_order1 = new HashSet<media_order>();
        }
    
        public Nullable<int> media_order_code { get; set; }
        public Nullable<int> order_ref { get; set; }
        public string order_type { get; set; }
        public Nullable<System.DateTime> local_air_date { get; set; }
        public Nullable<System.DateTime> broadcast_date { get; set; }
        public string order_instruction { get; set; }
        public System.DateTime start_air_time { get; set; }
        public Nullable<System.DateTime> end_air_time { get; set; }
        public string month_year { get; set; }
        public Nullable<System.DateTime> week_date { get; set; }
        public string start_air_day { get; set; }
        public string end_air_day { get; set; }
        public string program_name { get; set; }
        public int order_qty { get; set; }
        public decimal order_rate { get; set; }
        public string show_title_phone { get; set; }
        public Nullable<int> air_count { get; set; }
        public Nullable<decimal> media_ratio { get; set; }
        public Nullable<decimal> cpc_amt { get; set; }
        public Nullable<decimal> cpo_amt { get; set; }
        public Nullable<decimal> profit_loss_amt { get; set; }
        public string approve_status { get; set; }
        public Nullable<decimal> station_rate { get; set; }
        public Nullable<decimal> client_rate { get; set; }
        public Nullable<decimal> commission_amt { get; set; }
        public int document { get; set; }
        public int show_title { get; set; }
        public string broker { get; set; }
        public Nullable<System.DateTime> tape_traffic_sent_date { get; set; }
        public Nullable<System.DateTime> dubhouse_ack_tape_date { get; set; }
        public Nullable<System.DateTime> station_trafic_sent_date { get; set; }
        public Nullable<System.DateTime> station_tape_ack_date { get; set; }
        public Nullable<System.DateTime> po_sent_date { get; set; }
        public Nullable<System.DateTime> po_ack_date { get; set; }
        public string station_tracking_num { get; set; }
        public string client_tracking_num { get; set; }
        public string note { get; set; }
        public Nullable<System.DateTime> cancel_date { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> last_update_date { get; set; }
        public Nullable<int> last_update_by { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> create_by { get; set; }
        public int id { get; set; }
        public Nullable<int> buyer { get; set; }
        public Nullable<bool> visual_status { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<decimal> booked_gross_total { get; set; }
        public Nullable<decimal> booked_gross_client { get; set; }
        public Nullable<decimal> booked_gross_station { get; set; }
        public Nullable<decimal> cleared_gross_total { get; set; }
        public Nullable<decimal> cleared_gross_client { get; set; }
        public Nullable<int> approver { get; set; }
        public Nullable<decimal> gross_revenue { get; set; }
        public Nullable<decimal> conversion_ratio { get; set; }
        public Nullable<decimal> cleared_gross_station { get; set; }
        public string Days { get; set; }
        public Nullable<decimal> pgc_against { get; set; }
        public string cancel_reason { get; set; }
        public Nullable<int> new_show_title { get; set; }
        public string times { get; set; }
        public Nullable<System.DateTime> approved_date { get; set; }
        public Nullable<int> approved_by { get; set; }
        public Nullable<int> packaged { get; set; }
        public Nullable<bool> confirm_indicator { get; set; }
        public Nullable<int> rename_id { get; set; }
        public string order_status { get; set; }
        public Nullable<System.DateTime> broadcast_est_date { get; set; }
        public string failed_rule_descr { get; set; }
        public string broker_info { get; set; }
        public Nullable<System.DateTime> migrate_fox_date { get; set; }
        public Nullable<int> buy_type { get; set; }
        public string campaign_name { get; set; }
        public string client_code { get; set; }
        public string station_name { get; set; }
        public string payee_code { get; set; }
        public string internal_name { get; set; }
        public string market_name { get; set; }
        public string employee_code { get; set; }
        public string update_for_st { get; set; }
        public string dms_status { get; set; }
        public string media_order_barcode { get; set; }
        public string docm_po_link { get; set; }
        public Nullable<System.DateTime> PO_reconcile_date { get; set; }
        public Nullable<int> PO_reconcile_by { get; set; }
        public string FoxProDocumentId { get; set; }
        public Nullable<int> rebooked_from { get; set; }
        public Nullable<int> rebooked_to { get; set; }
        public string IsAdded { get; set; }
        public Nullable<int> Qty_Difference { get; set; }
        public string prev_approve_status { get; set; }
        public Nullable<int> old_show_title { get; set; }
        public Nullable<int> pw_contact_role { get; set; }
        public Nullable<int> av_contact_role { get; set; }
        public string approval_feedback { get; set; }
        public Nullable<System.DateTime> m_invdate { get; set; }
        public string lmarket { get; set; }
        public Nullable<decimal> byrchk { get; set; }
        public string statinv { get; set; }
        public Nullable<decimal> byrcom { get; set; }
        public Nullable<decimal> ordequiv { get; set; }
        public Nullable<decimal> orefnum { get; set; }
        public Nullable<System.DateTime> edidate { get; set; }
        public Nullable<System.DateTime> cairdate { get; set; }
        public string siteidorig { get; set; }
        public Nullable<bool> verified { get; set; }
        public string acctstatus { get; set; }
        public string strptkey { get; set; }
        public string acctnote { get; set; }
        public Nullable<bool> acctbcom { get; set; }
        public string b_chkno { get; set; }
        public Nullable<System.DateTime> b_chkdate { get; set; }
        public string mdocrefnum { get; set; }
        public string otypeinst { get; set; }
        public Nullable<System.DateTime> invtstamp { get; set; }
        public Nullable<decimal> costcode { get; set; }
        public string brtrack { get; set; }
        public Nullable<decimal> revlcomm { get; set; }
        public Nullable<decimal> permatrix { get; set; }
        public Nullable<System.DateTime> perprodate { get; set; }
        public Nullable<decimal> perproamt { get; set; }
        public string percat { get; set; }
        public string authid { get; set; }
        public string perbccat { get; set; }
        public Nullable<System.DateTime> aeperfckdt { get; set; }
        public Nullable<decimal> aeperfid { get; set; }
        public string m_invcr { get; set; }
        public Nullable<System.DateTime> m_invcrdt { get; set; }
        public string acctype { get; set; }
        public Nullable<decimal> pleadin { get; set; }
        public string slot_num { get; set; }
        public string rectype { get; set; }
        public Nullable<decimal> lnidorg { get; set; }
        public string airtimes { get; set; }
        public string airprog { get; set; }
        public string campver { get; set; }
        public Nullable<decimal> gross { get; set; }
        public Nullable<decimal> extamt { get; set; }
        public Nullable<decimal> discamt { get; set; }
        public string etype { get; set; }
        public Nullable<decimal> revnum { get; set; }
        public Nullable<decimal> revnumst { get; set; }
        public Nullable<System.DateTime> dates { get; set; }
        public Nullable<System.DateTime> datee { get; set; }
        public Nullable<decimal> cl_crate { get; set; }
        public Nullable<decimal> st_crate { get; set; }
        public Nullable<decimal> br_crate { get; set; }
        public Nullable<decimal> byr_net { get; set; }
        public Nullable<decimal> origqty { get; set; }
        public Nullable<decimal> rtime { get; set; }
        public string rtimedesc { get; set; }
        public string campid { get; set; }
        public Nullable<decimal> basordr { get; set; }
        public Nullable<decimal> upsells { get; set; }
        public Nullable<System.DateTime> fairdate { get; set; }
        public Nullable<decimal> dstat_net { get; set; }
        public Nullable<decimal> dclnt_net { get; set; }
        public Nullable<decimal> dbyr_net { get; set; }
        public Nullable<decimal> dlcomm { get; set; }
        public string userid { get; set; }
        public Nullable<decimal> clearedqty { get; set; }
        public string brokerid { get; set; }
        public Nullable<bool> complete_ind { get; set; }
        public Nullable<byte> day_bit_mask { get; set; }
        public string order_coverage { get; set; }
        public Nullable<System.DateTime> migrate_fox_date_reverse { get; set; }
        public Nullable<int> buy_category { get; set; }
        public Nullable<int> rate_category { get; set; }
        public Nullable<decimal> MarketValueRate { get; set; }
        public Nullable<System.DateTime> po_cxl_Ack_date { get; set; }
        public Nullable<int> cluster_id { get; set; }
        public Nullable<int> prev_cluster_id { get; set; }
        public Nullable<int> attachment { get; set; }
        public Nullable<System.DateTime> flight_end_date { get; set; }
        public Nullable<System.DateTime> station_traffic_conf_date { get; set; }
        public decimal tax_amount { get; set; }
        public Nullable<decimal> client_rate_gross { get; set; }
        public Nullable<decimal> station_rate_gross { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<check_request_detail> check_request_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<media_order_detail> media_order_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<media_order> media_order1 { get; set; }
        public virtual media_order media_order2 { get; set; }
    }
}
