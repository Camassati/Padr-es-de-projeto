public class WeatherData implements Subject{

    private ArrayList observer;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData(){
        observers = new ArrayList();
    }
    public void registersObserver(Observer o){
        observer.add(o);
    }
    public void removeObserver(Observer o){
        int i = observers.indexOF(o);
        if (i >= 0){
            observers.remove(i)
        }
    }
    public void notifyObservers(){
        for(int i = 0;i <observer.size(); i++){
            Observer observer = (Observer)observer.get(i);
            observer.update(temperature, humidity, pressure); 
        }
    }
    public void measurementsChanged(){
        notifyObservers();
    }
    public void setMensurements(float temperature, float humidity float pressure){
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementesChanged();
    }

    //declaração de variavel de instância 

    public void measurementsChanged(){

        float temp = getTemperature();
        float humidity = getHumidity();
        float pressure = getPressure();

        correntConditionsDisplay.update(temp, humidity, pressure);
        statisticsDisplay.update(temp, humidity, pressure);
        forecastDisplay.update(temp,humidity,pressure);
 
    }

}