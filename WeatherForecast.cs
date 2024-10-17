namespace practica_unir_eiec
{
    // this class defines parameters about the weather 
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public double TemperatureK => TemperatureC + 273.15;

        public string? Summary { get; set; }
    }

    //Check if it's freezing
        public bool IsFreezing()
        {
            return TemperatureC <= 0;
        }

}