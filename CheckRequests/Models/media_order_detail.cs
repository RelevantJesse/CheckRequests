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
    
    public partial class media_order_detail
    {
        public int id { get; set; }
        public int media_order { get; set; }
        public System.DateTime actual_air_date { get; set; }
        public Nullable<System.DateTime> actual_air_time { get; set; }
        public Nullable<bool> inv_ind { get; set; }
        public string e_type { get; set; }
        public string air_status { get; set; }
        public Nullable<decimal> num_of_calls { get; set; }
        public Nullable<int> num_of_inq { get; set; }
        public Nullable<decimal> collected_amt { get; set; }
        public Nullable<System.DateTime> monitor_date { get; set; }
        public Nullable<System.DateTime> monitor_time { get; set; }
        public string slot_num { get; set; }
        public Nullable<decimal> profit_loss_amt { get; set; }
        public Nullable<decimal> gross_amt { get; set; }
        public string note { get; set; }
        public Nullable<System.DateTime> last_update_date { get; set; }
        public Nullable<int> last_update_by { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> create_by { get; set; }
        public Nullable<bool> visual_status { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<decimal> cpo_amt { get; set; }
        public Nullable<decimal> cpc_amt { get; set; }
        public Nullable<decimal> media_ratio { get; set; }
        public Nullable<decimal> conversion_ratio { get; set; }
        public Nullable<decimal> station_rate { get; set; }
        public Nullable<decimal> client_rate { get; set; }
        public Nullable<decimal> gross_revenue { get; set; }
        public Nullable<decimal> base_order_count { get; set; }
        public Nullable<int> upsell1_count { get; set; }
        public Nullable<int> upsell2_count { get; set; }
        public Nullable<int> upsell3_count { get; set; }
        public Nullable<int> upsell4_count { get; set; }
        public Nullable<int> upsell5_count { get; set; }
        public Nullable<int> upsell6_count { get; set; }
        public Nullable<int> upsell7_count { get; set; }
        public Nullable<int> upsell8_count { get; set; }
        public Nullable<int> upsell9_count { get; set; }
        public Nullable<int> upsell10_count { get; set; }
        public Nullable<int> upsell11_count { get; set; }
        public Nullable<int> upsell12_count { get; set; }
        public Nullable<int> upsell13_count { get; set; }
        public Nullable<int> upsell14_count { get; set; }
        public Nullable<int> upsell15_count { get; set; }
        public Nullable<int> upsell16_count { get; set; }
        public Nullable<int> upsell17_count { get; set; }
        public Nullable<int> upsell18_count { get; set; }
        public Nullable<int> upsell19_count { get; set; }
        public Nullable<int> upsell20_count { get; set; }
        public Nullable<int> upsell21_count { get; set; }
        public Nullable<int> upsell22_count { get; set; }
        public Nullable<int> upsell23_count { get; set; }
        public Nullable<int> upsell24_count { get; set; }
        public Nullable<int> upsell25_count { get; set; }
        public Nullable<int> show_title_upsell_detail { get; set; }
        public Nullable<int> total_upsell_count { get; set; }
        public string program_name { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> migrate_fox_date { get; set; }
        public string docm_postlog_link { get; set; }
        public string dms_invoice_status { get; set; }
        public string docm_invoice_link { get; set; }
        public string invoice_num { get; set; }
        public string Invoice_Type { get; set; }
        public Nullable<System.DateTime> post_log_date { get; set; }
        public Nullable<int> post_log_by { get; set; }
        public Nullable<System.DateTime> invoice_date { get; set; }
        public Nullable<int> invoice_by { get; set; }
        public Nullable<int> dtid { get; set; }
        public string show_title_phone { get; set; }
        public string station_inv_num { get; set; }
        public Nullable<System.DateTime> inv_rcvd_date { get; set; }
        public string station_chq_num { get; set; }
        public Nullable<System.DateTime> station_chq_date { get; set; }
        public string client_inv_num { get; set; }
        public string client_chq_num { get; set; }
        public Nullable<System.DateTime> client_chq_date { get; set; }
        public Nullable<System.DateTime> date_rec_station_invoice_num { get; set; }
        public Nullable<System.DateTime> date_sent_client_invoice_num { get; set; }
        public Nullable<System.DateTime> broadcast_utc_date { get; set; }
        public Nullable<System.DateTime> PO_reconcile_date { get; set; }
        public Nullable<int> PO_reconcile_by { get; set; }
        public Nullable<System.DateTime> lbooked_date { get; set; }
        public Nullable<System.DateTime> mbooked_date { get; set; }
        public string PhoneNumber { get; set; }
        public string buyer_chq_num { get; set; }
        public Nullable<System.DateTime> buyer_chq_date { get; set; }
        public string accounting_entry_status { get; set; }
        public Nullable<System.DateTime> cancel_date { get; set; }
        public Nullable<decimal> boidbase { get; set; }
        public Nullable<decimal> ordequiv { get; set; }
        public Nullable<System.DateTime> utctime { get; set; }
        public Nullable<decimal> verifyvia { get; set; }
        public string bnote { get; set; }
        public string mtype { get; set; }
        public Nullable<System.DateTime> mairdate { get; set; }
        public string mairtime { get; set; }
        public string invoice_status_change_reason { get; set; }
        public Nullable<decimal> commission_amt { get; set; }
        public Nullable<decimal> revlcomm { get; set; }
        public Nullable<bool> Commission_Processed { get; set; }
        public Nullable<bool> Performance_Processed { get; set; }
        public Nullable<decimal> web_click { get; set; }
        public Nullable<decimal> web_visit { get; set; }
        public Nullable<decimal> web_order { get; set; }
        public Nullable<decimal> upsell26_count { get; set; }
        public Nullable<decimal> upsell27_count { get; set; }
        public Nullable<decimal> upsell28_count { get; set; }
        public Nullable<decimal> upsell29_count { get; set; }
        public Nullable<decimal> upsell30_count { get; set; }
        public Nullable<decimal> web_revenue { get; set; }
        public string prev_recon_e_type { get; set; }
        public Nullable<System.DateTime> Performance_Processed_Date { get; set; }
        public Nullable<System.DateTime> Commission_Processed_Date { get; set; }
        public string program_name_category { get; set; }
        public string lead_in_program_type { get; set; }
        public string NetworkOrSyndicated { get; set; }
        public string HighDef { get; set; }
        public Nullable<System.DateTime> OriginalAirDate { get; set; }
        public string TVRating { get; set; }
        public Nullable<bool> no_recalc { get; set; }
        public Nullable<decimal> average_audience_15_segment { get; set; }
        public Nullable<decimal> households_15_min_segment { get; set; }
        public Nullable<decimal> households_15_min_segment2 { get; set; }
        public Nullable<decimal> phone_calls { get; set; }
        public Nullable<decimal> num_of_orders { get; set; }
        public Nullable<decimal> call_revenue { get; set; }
        public Nullable<int> attachment { get; set; }
        public Nullable<int> prev_media_order_detail { get; set; }
        public Nullable<int> media_order_rebooked_from { get; set; }
        public Nullable<decimal> MarketValueRate { get; set; }
        public string client_credit_inv_num { get; set; }
        public Nullable<System.DateTime> client_credit_inv_date { get; set; }
        public Nullable<int> invoice_ms { get; set; }
        public Nullable<int> invoice_sec { get; set; }
        public Nullable<decimal> primary_rating { get; set; }
        public Nullable<decimal> nielsen_performance_rating { get; set; }
        public bool RATINGUPD { get; set; }
        public Nullable<int> ListingTitleHistory_tms { get; set; }
        public Nullable<int> ListingTitleHistory_rovi { get; set; }
        public decimal tax_amount { get; set; }
        public Nullable<decimal> client_rate_gross { get; set; }
        public Nullable<decimal> station_rate_gross { get; set; }
    
        public virtual media_order media_order1 { get; set; }
    }
}
