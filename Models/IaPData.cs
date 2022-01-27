namespace Apple_IaP_WebApi2
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class IaPData
    {
        public string bundleId { get; set; }
        public string bundleVersion { get; set; }
        public string environment { get; set; }
        public string signedTransactionInfo { get; set; }
        public string signedRenewalInfo { get; set; }
    }
}