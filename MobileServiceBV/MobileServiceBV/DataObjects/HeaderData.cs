using Microsoft.WindowsAzure.Mobile.Service;

namespace MobileServiceBV.DataObjects
{
    public class HeaderData : EntityData
    {
        public string BatchID { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }
    }
}
