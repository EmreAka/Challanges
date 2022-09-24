namespace Challenge_4.Models;

public sealed class Quote
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime? PresentAt { get; set; }
}

public static class QuoteDatabase
{
    public static List<Quote> Quotes { get; set; } = new List<Quote>();
}
