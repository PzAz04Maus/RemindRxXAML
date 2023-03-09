using System;

namespace RemindRx.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string ToD { get; set; }
        public string Date { get; set; }
        public string DoseageAmount { get; set; }
    }
}