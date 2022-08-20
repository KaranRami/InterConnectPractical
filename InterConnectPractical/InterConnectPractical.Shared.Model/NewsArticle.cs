using InterConnectPractical.Shared.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterConnectPractical.Shared.Model
{
    public class NewsArticle : INewsArticle
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? ImageURL { get; set; }
        public bool IsRtlFlowDirection { get; set; }
    }
}
