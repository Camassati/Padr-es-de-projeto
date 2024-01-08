using CommandPattern;

var receiver = new Receiver();
var commandState = (State)receiver.Handle(new Command(1,"Comando 1"));

Console.WriteLine($"{commandState.StatusCode} - {commandState.Message}");