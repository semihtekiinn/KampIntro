using System;

namespace OOP3
{

    // Loglama nedir? Kim, ne zaman hangi operasyonu çağırdığıdır.
    // Yani bir nevi o sistemde olan hareketleri döktüğümüz bir dökümdür.
    // Loglarımızı bir dosyada, veritabanında  tutabiliriz, mail, sms olarak atabiliriz vs vs .
    // Hepsinin imzası aynı ama dosyaya yazarken dosyaya yazma kodları, sms yollarken sms yollama kodları yazılır.
    // Örneğin birisi bir krediye başvuru yaptığı zaman ona sms gitmesi bir loglamadır. 

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
