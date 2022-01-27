namespace Apple_IaP_WebApi2
{
    public class IaPEvent
    {
        public string notificationType { get; set; }
        public string subtype { get; set; }
        public string notificationUUID { get; set; }
        public IaPData data { get; set; }
        public string version { get; set; }

        public IaPEvent()
        {

        }
    }
}