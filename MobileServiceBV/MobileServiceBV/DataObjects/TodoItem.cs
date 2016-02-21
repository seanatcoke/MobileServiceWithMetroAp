using Microsoft.WindowsAzure.Mobile.Service;

namespace MobileServiceBV.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }

        public string Id { get; set; }
    }
}