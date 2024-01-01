public interface Subject{
   public void registerObserver(Observer o);
   public void removeObeserver(Observer o);
   public void notifyObserver();
}
   public interface Observer{
      public void update(float temp, float humity, float pressure);
   }
      public interface DisplayElement{
         public void display()
      }