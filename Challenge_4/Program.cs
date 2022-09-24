using Challenge_4.DTOs;
using Challenge_4.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/quotes", (QuoteCreateCommand quoteCreateCommand) =>
{
    Quote quote = new()
    {
        Id = Guid.NewGuid(),
        Text = quoteCreateCommand.Text,
    };

    QuoteDatabase.Quotes.Add(quote);
});

app.MapGet("/quotes", () =>
{
    var result = QuoteDatabase.Quotes;

    return Results.Ok(result);
});

app.MapGet("/quotes/daily", () =>
{
    if (QuoteDatabase.Quotes.Any(x => x.PresentAt != null))
    {
        var data = QuoteDatabase.Quotes.Where(q => q.PresentAt != null).ToList();
        var result = data.Find(q => q.PresentAt!.Value.DayOfYear == DateTime.UtcNow.DayOfYear);
        return Results.Ok(result);
    }

    var random = new Random();
    var selectedQuoteIndex = random.Next(QuoteDatabase.Quotes.Count());
    var quote = QuoteDatabase.Quotes[selectedQuoteIndex];
    quote.PresentAt = DateTime.UtcNow;

    return Results.Ok(quote);
});

app.Run();