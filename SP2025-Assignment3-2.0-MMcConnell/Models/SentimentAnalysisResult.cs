namespace SP2025_Assignment3_2._0_MMcConnell.Models
{
    public class SentimentAnalysisResult
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double SentimentScore { get; set; }
        public string SentimentLabel { get; set; } // "Positive", "Negative", "Neutral"
    }

}
