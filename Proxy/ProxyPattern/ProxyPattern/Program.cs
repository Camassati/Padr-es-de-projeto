
using ProxyPattern;

ISuperSecretDatabase database = new SuperSecretDatabaseProxy("testdb", "Password");
database.DisplayDataBaseName();