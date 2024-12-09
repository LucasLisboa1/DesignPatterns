

var teste = Singleton.SingletonClass.getInstance(0);

teste = Singleton.SingletonClass.getInstance(teste.Data);

teste = Singleton.SingletonClass.getInstance(teste.Data);

Console.WriteLine(teste.Data);  