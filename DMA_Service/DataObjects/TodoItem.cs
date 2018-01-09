using Microsoft.Azure.Mobile.Server;

namespace DMA_Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}