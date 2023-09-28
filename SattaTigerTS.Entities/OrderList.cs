using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace SattaTigerTS.Entities
{
    public class OrderList
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Approver
        {
            [JsonProperty("approver_name")]
            public string ApproverName { get; set; }

            [JsonProperty("approver_email")]
            public string ApproverEmail { get; set; }

            [JsonProperty("approval_date")]
            public DateTime ApprovalDate { get; set; }
        }

        public class Order
        {
            public bool SelectedItem { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("proposal_id")]
            public int ProposalId { get; set; }

            [JsonProperty("company_id")]
            public int CompanyId { get; set; }

            [JsonProperty("supplier")]
            public string Supplier { get; set; }

            [JsonProperty("supplier_erp_id")]
            public string SupplierErpId { get; set; }

            [JsonProperty("supplier_tax_id")]
            public string SupplierTaxId { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("delivery_date")]
            public DateTime? DeliveryDate { get; set; }

            [JsonProperty("payment_due_date")]
            public int PaymentDueDate { get; set; }

            [JsonProperty("payment_type")]
            public object PaymentType { get; set; }

            [JsonProperty("order_date")]
            public DateTime OrderDate { get; set; }

            [JsonProperty("demand_name")]
            public string DemandName { get; set; }

            [JsonProperty("demand_no")]
            public int DemandNo { get; set; }

            [JsonProperty("demand_creator_name")]
            public string DemandCreatorName { get; set; }

            [JsonProperty("demand_creator_email")]
            public string DemandCreatorEmail { get; set; }

            [JsonProperty("procurement_name")]
            public string ProcurementName { get; set; }

            [JsonProperty("procurement_email")]
            public string ProcurementEmail { get; set; }


            [JsonProperty("approvers")]
            public List<Approver> Approvers { get; set; }


            [JsonProperty("products")]
            public List<Product> Products { get; set; }
        }

        public class Product
        {
            public bool SelectedItemProduct { get; set; }

            [JsonProperty("product_proposal_id")]
            public int ProductProposalId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("category_id")]
            public int CategoryId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("amount")]
            public double Amount { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }

            [JsonProperty("price")]
            public double? Price { get; set; }

            [JsonProperty("currency_code")]
            public string CurrencyCode { get; set; }

            [JsonProperty("erp_id")]
            public object ErpId { get; set; }

            [JsonProperty("product_erp_id")]
            public object ProductErpId { get; set; }

            [JsonProperty("proposal_note")]
            public string ProposalNote { get; set; }

            [JsonProperty("category_erp_id")]
            public string CategoryErpId { get; set; }

        }

        public class Root
        {
            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("response_message")]
            public string ResponseMessage { get; set; }

            [JsonProperty("request_id")]
            public string RequestId { get; set; }

            [JsonProperty("order")]
            public List<Order> Orders { get; set; }
        }

        


    }
}
