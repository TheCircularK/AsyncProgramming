using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AsyncProgramming.Shared;

namespace AsyncProgramming.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class DataProcessingController : ControllerBase
{
    [HttpPost]
    public async Task<string> SubmitData([FromBody] WeatherForecast[] forecasts)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        // Replace this delay with processing data. We'll do this twice.
        await Task.Delay(500);
        
        stopwatch.Stop();
        string time = stopwatch.ElapsedMilliseconds.ToString();
        
        return time;
    }

    private async Task ProcessData(WeatherForecast forecast)
    {
        // This method simulates doing work. Don't change this method.
        Random random = new Random();
        int delayLength = random.Next(500, 3500);
        await Task.Delay(delayLength);
    }
}