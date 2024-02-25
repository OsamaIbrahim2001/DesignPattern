using AdaterPattern.Core;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

string url = "https://localhost:7253/api/PayrollCalaculator";
EmployeeDataReader reader = new();
var employess = reader.GetEmployees();

HttpClient client = new();
foreach (var employee in employess)
{
    var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);
    //var result = client.PostAsJsonAsync(url,employeeAdapter);
    var request = new HttpRequestMessage(HttpMethod.Post, url)
    {
        Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json")
    };
    var response = await client.SendAsync(request);
    var resonseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(resonseJson);
    Console.WriteLine($"Salary for employee {employeeAdapter.FullName} as of today = {salary}");
}
Console.ReadKey();
