using System;

namespace InterConnectPractical.Shared.Model.Interfaces
{
    public interface INewsArticle
    {
        int ID { get; set; }
        string? Title { get; set; }
        string? Description { get; set; }
        DateTime Date { get; set; }
        string? ImageURL { get; set; }
        bool IsRtlFlowDirection { get; set; }
    }
}
