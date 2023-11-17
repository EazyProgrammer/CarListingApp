
using CarListingApp.MAUI.UI.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CarListingApp.MAUI.UI.Services;

public class CarApiService
{
    private HttpClient _httpClient;
    public static string BaseAddress;
    public string statusMessage;

    public CarApiService()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:7151" : "https://localhost:7151";
        _httpClient = new(clientHandler) { BaseAddress = new Uri(BaseAddress) };
    }

    public async Task<List<Car>> GetCarsAsync()
    {
        try
        {
            await SetAuthToken();
            var hst = Uri.CheckHostName(BaseAddress);
            var reponse = await _httpClient.GetAsync("/cars");
            reponse.EnsureSuccessStatusCode();

            var data = await reponse.Content.ReadAsStringAsync();
            var cars = JsonConvert.DeserializeObject<List<Car>>(data);
            return cars;
        }
        catch (Exception)
        {
            statusMessage = "Failed to retrieve data.";
            return null;
        }
    }

    public async Task<Car> GetCarAsync(int id)
    {
        try
        {
            await SetAuthToken();
            var reponse = await _httpClient.GetStringAsync("/cars/" + id);
            var cars = JsonConvert.DeserializeObject<Car>(reponse);
            return cars;
        }
        catch (Exception)
        {
            statusMessage = "Failed to retrieve data.";
            return null;
        }
    }

    public async Task AddCarAsync(Car car)
    {
        try
        {
            await SetAuthToken();
            var reponse = await _httpClient.PostAsJsonAsync("/cars/", car);
            reponse.EnsureSuccessStatusCode();

            statusMessage = "Successfully added " + car.Model + " " + car.Make;
        }
        catch (Exception)
        {
            statusMessage = "Failed to add car.";
        }
    }

    public async Task UpdateCarAsync(Car car)
    {
        try
        {
            await SetAuthToken();
            var reponse = await _httpClient.PutAsJsonAsync("/cars/" + car.Id, car);
            reponse.EnsureSuccessStatusCode();

            statusMessage = "Successfully updated car";
        }
        catch (Exception)
        {
            statusMessage = "Failed to update car.";
        }
    }

    public async Task DeleteCarAsync(int id)
    {
        try
        {
            await SetAuthToken();
            var reponse = await _httpClient.DeleteAsync("/cars/" + id);
            reponse.EnsureSuccessStatusCode();

            statusMessage = "Successfully deleted car";
        }
        catch (Exception)
        {
            statusMessage = "Failed to deleted car.";
        }
    }

    public async Task<AuthResponseDto> Login(LoginDto login)
    {
        try
        {
            var reponse = await _httpClient.PostAsJsonAsync("/login", login);
            reponse.EnsureSuccessStatusCode();
            statusMessage = "Login Successful";

            return JsonConvert.DeserializeObject<AuthResponseDto>(await reponse.Content.ReadAsStringAsync());
        }
        catch (Exception)
        {
            statusMessage = "Failed to login!";
            return default;
        }
    }

    private async Task SetAuthToken() => _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", await SecureStorage.GetAsync("token"));
}
