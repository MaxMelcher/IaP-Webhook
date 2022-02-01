namespace Apple_IaP_WebApi2
{
    /// <summary>
    /// This class is sent by the Apple Server side events
    /// see for values: https://gist.github.com/MaxMelcher/99562cfb4d906446a7364be63755b6c1
    /// </summary>
    public class IaPEvent
    {
        /// <summary>
        /// Can be 
        /// 'CONSUMPTION_REQUEST', 
        /// 'DID_CHANGE_RENEWAL_PREF', 
        /// 'DID_CHANGE_RENEWAL_STATUS',
        /// 'DID_FAIL_TO_RENEW',
        /// 'DID_RENEW',
        /// 'EXPIRED', 
        /// 'GRACE_PERIOD_EXPIRED', 
        /// 'OFFER_REDEEMED', 
        /// 'PRICE_INCREASE', 
        /// 'REFUND', 
        /// 'REFUND_DECLINED', 
        /// 'RENEWAL_EXTENDED', 
        /// 'REVOKE', 
        /// 'SUBSCRIBED'
        /// see https://developer.apple.com/documentation/appstoreservernotifications/notificationtype
        /// </summary>
        public string notificationType { get; set; }

        /// <summary>
        /// Subtype, see: https://developer.apple.com/documentation/appstoreservernotifications/subtype
        /// </summary>
        public string subtype { get; set; }
        public string notificationUUID { get; set; }
        public IaPData data { get; set; }
        public string version { get; set; }

        public IaPEvent()
        {

        }
    }
}