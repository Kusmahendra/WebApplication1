namespace WebApplication1
{
    public class Class
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 30 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
