using Newtonsoft.Json;
decimal Kurs = 0;
Console.WriteLine("Podaj kwote w walucie PLN aby dokonać konwersji do USD");
decimal PLN = Convert.ToDecimal(Console.ReadLine());
try
{
    string url = "http://api.nbp.pl/api/exchangerates/rates/A/USD/";

    using (HttpClient httpClient = new HttpClient())
    {
        HttpResponseMessage response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        ExchangeRateResponse exchangeRateResponse = JsonConvert.DeserializeObject<ExchangeRateResponse>(responseBody);

        Kurs = exchangeRateResponse.Rates[0].Mid;
    }
}
catch (HttpRequestException ex)
{
   
}

decimal Dolary = PLN / Kurs;

Console.WriteLine(PLN + " PLN to " + Math.Round(Dolary, 2) + " USD");



public class ExchangeRateResponse
{
    public string Table { get; set; }
    public string Currency { get; set; }
    public string Code { get; set; }
    public Rate[] Rates { get; set; }
}

public class Rate
{
    public string No { get; set; }
    public DateTime EffectiveDate { get; set; }
    public decimal Mid { get; set; }
}






