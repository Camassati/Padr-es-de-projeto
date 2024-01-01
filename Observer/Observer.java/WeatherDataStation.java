public class WeatherDataStation {
    public static void main(String[] args) {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        ForecastDisplay forecastDisplay = new ForecastDisplay(WeatherData);

        weatherData.setMensurements(80,65.4f);
        weatherData.setMensurements(82,70.2f);
        weatherData.setMensurements(78,29.2f);
    }
}