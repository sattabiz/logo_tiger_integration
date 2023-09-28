
using Newtonsoft.Json;
using System.Collections.Generic;


namespace SattaTigerTS.Entities
{
    public class ShipmentList
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Product
        {
            [JsonProperty("order_id")]
            public int OrderId { get; set; }

            [JsonProperty("order_po_no")]
            public object OrderPoNo { get; set; }

            [JsonProperty("products_proposal_id")]
            public int ProductsProposalId { get; set; }

            [JsonProperty("name")]
            public string ProductName { get; set; }

            [JsonProperty("category_id")]
            public int CategoryId { get; set; }

            [JsonProperty("category_erp_id")]
            public string CategoryErpId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("shipped_amount")]
            public double ShippedAmount { get; set; }

            [JsonProperty("unit")]
            public string Unit { get; set; }

            [JsonProperty("price")]
            public double Price { get; set; }

            [JsonProperty("currency_code")]
            public string CurrencyCode { get; set; }

            [JsonProperty("erp_id")]
            public object ErpId { get; set; }

            [JsonProperty("product_erp_id")]
            public object ProductErpId { get; set; }

            [JsonProperty("proposal_note")]
            public string ProposalNote { get; set; }
        }

        public class Root
        {
            [JsonProperty("status")]
            public int Status { get; set; }

            [JsonProperty("response_message")]
            public string ResponseMessage { get; set; }

            [JsonProperty("request_id")]
            public string RequestId { get; set; }

            [JsonProperty("shipments")]
            public List<Shipment> Shipments { get; set; }
        }

        public class Shipment
        {
            public bool SelectedShipment { get; set; }

            [JsonProperty("shipment_id")]
            public int ShipmentId { get; set; }

            [JsonProperty("waybill_no")]
            public string WaybillNo { get; set; }

            [JsonProperty("shipment_date")]
            public string ShipmentDate { get; set; }

            [JsonProperty("carrier")]
            public string Carrier { get; set; }

            [JsonProperty("tracking_no")]
            public string TrackingNo { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("sender_name")]
            public string SenderName { get; set; }

            [JsonProperty("sender_erp_id")]
            public object SenderErpId { get; set; }

            [JsonProperty("products")]
            public List<Product> Products { get; set; }
        }


    }
}
