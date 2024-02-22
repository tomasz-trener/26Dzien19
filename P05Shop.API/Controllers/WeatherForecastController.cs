using Microsoft.AspNetCore.Mvc;
using P05Shop.API.DTO;

namespace P05Shop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase //https://localhost:7061/api/WeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //https://localhost:7061/api/WeatherForecast
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //https://localhost:7061/api/WeatherForecast/onlyTwo
        [HttpGet("onlyTwo")]
        public IEnumerable<WeatherForecast> GetOnyTwoWeatherForecast() // nazwa metody nie ma znaczenia
        {
            return new WeatherForecast[2]
            {
                new WeatherForecast(){ Summary="Summary 1" },
                new WeatherForecast(){ Summary="Summary 2" }
            };
        }

        //https://localhost:7061/api/WeatherForecast/search?number=3
        [HttpGet("search")]
        public IEnumerable<WeatherForecast> GetWeatherforecasts([FromQuery] int number)
        {
            return Enumerable.Range(1, number).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //https://localhost:7061/api/WeatherForecast/test/hello?number=4
        [HttpGet("test/{routeParam}")]
        public string GetValueFromPath([FromQuery] int number, [FromRoute]string routeParam)
        {
            return $"This is result: number:{number}, routeParam: {routeParam}";
        }

        // przeciąznie metod o takiej samej nazwie ale z innymi parametrami


        //https://localhost:7061/api/WeatherForecast/filter?cityName=Krakow&country=Poland
        [HttpGet("filter")]
        public string GetValueFromPath([FromQuery] string cityName, [FromQuery] string country)
        {
            return $"This is result: cityName:{cityName}, country: {country}";
        }

        // tworzenie obiektów typu DTO (Data Transfer Object) - obiektu, który przenosi dane pomiędzy serwerem a klientem

        //https://localhost:7061/api/WeatherForecast/complexFilter?name=Krakow&country=Poland
        [HttpGet("complexFilter")]
        public string GetValueFromPath([FromQuery] CityDTO cityDTO)
        {
            return $"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}";
        }
        

        // w postman wpisujemy w body: {"name":"Krakow","country":"Poland"}
        //https://localhost:7061/api/WeatherForecast
        [HttpPost]
        public string AddNewCity([FromBody] CityDTO cityDTO)
        {
            return $"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}";
        }

        //API - REST bazuje na metodach HTTP
        //GET - pobieranie danych
        //POST - dodawanie danych
        //PUT - aktualizacja danych
        //DELETE - usuwanie danych

        // wiele ścieżek prowadzących do jednej metody

        [HttpPost("newCity")] // https://localhost:7061/api/WeatherForecast/newCity
        [HttpPost("addCity")] // https://localhost:7061/api/WeatherForecast/addCity
        public string MultiplePathsToOneMethod([FromBody] CityDTO cityDTO)
        {
            return $"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}";
        }

        // zwracanie kodów HTTP

        [HttpPost("addNewCity")] // https://localhost:7061/api/WeatherForecast/addNewCity
        public IActionResult AddCityWithStatusCode([FromBody] CityDTO cityDTO)
        {
          //  return $"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}";

            //return StatusCode(200, $"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}");
            //return Ok($"This is result: cityName:{cityDTO.Name}, country: {cityDTO.Country}");

            if(cityDTO.Name ==null)
                return BadRequest("Name is required");

            // próba dodawania do bazy danych 
            try
            {
                // dodawanie do bazy danych
            }
            catch (Exception ex)
            {
                 return StatusCode(500, ex.Message);    
            }
            int id = 1; // pobranie id z bazy danych

            return Created($"https://localhost:7061/api/WeatherForecast/GetCity/{id}", cityDTO); // 201

            // klient bedzie wiedział gdzie jest zapisany nowy zasób
            // w nagłówku odpowiedzi jest zapisany adres nowego zasobu w Location
        }

        //https://localhost:7061/api/WeatherForecast/GetCity/1
        [HttpGet("GetCity/{id}")]
        public IActionResult GetCity([FromRoute] int id)
        {
            // pobranie z bazy danych
            CityDTO cityDTO = new CityDTO() { Name = "Krakow", Country = "Poland" };
            return Ok(cityDTO);
        }

        //Dynamiczne odowlanie się do nazwu metody

        //https://localhost:7061/api/WeatherForecast/MyDynamicMethodName
        [HttpGet("[action]")]
  //      [HttpGet("MyDynamicMethodName")]
        public IActionResult MyDynamicMethodName()
        {
            return Ok("Method invoked");
        }
    }
}
