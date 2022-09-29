using System.Net.Http.Json;
namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;
    string imageSource = "https://images.dog.ceo/breeds/schipperke/n02104365_3826.jpg";
    private readonly HttpClient _httpClient = new HttpClient();
    public MainPage()
    {
        InitializeComponent();
        image.Source = imageSource;
    }

    private async Task GetDogImage()
    {
        var result = await _httpClient.GetFromJsonAsync<Response>("https://dog.ceo/api/breeds/image/random");
        if (result.Status == "success")
        {
            imageSource = result.Message;
            image.Source = imageSource;
        }
        else
            throw new Exception("A problem occured");
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await GetDogImage();
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

internal class Response
{
    public string Message { get; set; }
    public string Status { get; set; }
}