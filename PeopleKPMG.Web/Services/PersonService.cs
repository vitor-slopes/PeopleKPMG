using System.Net.Http.Json;
using PeopleKPMG.Web.Models;

public class PersonService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly string _apiUrl;

    public PersonService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _apiUrl = _configuration["ApiUrl"];
    }

    public async Task<List<Person>> GetPersonsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<Person>>($"{_apiUrl}/api/people");
        return response;
    }

    public async Task<Person> GetPersonByIdAsync(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<Person>($"{_apiUrl}/api/people/{id}");
        return response;
    }

    public async Task CreatePersonAsync(Person person)
    {
        await _httpClient.PostAsJsonAsync($"{_apiUrl}/api/people", person);
    }

    public async Task UpdatePersonAsync(int id, Person person)
    {
        await _httpClient.PutAsJsonAsync($"{_apiUrl}/api/people/{id}", person);
    }

    public async Task DeletePersonAsync(int id)
    {
        await _httpClient.DeleteAsync($"{_apiUrl}/api/people/{id}");
    }
}
