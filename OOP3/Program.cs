using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu şekilde de yazabiliriz.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //Interface ler new'lenemez !
            // Bu şekilde de yazabiliriz. Yani interface onu implamente eden classın referansını tutabilir. 

            IKrediManager konutKrediManager = new KonutKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


            //Burada kredi çekmek isteyen bir kişinin istediği kredi türü ne olursa olsun, tek tuş ile hesabını yaptık.
            //Başvurumanager da imzayı her kredi için ayrı ayrı yapmak yerine ya da döngüleri kullanarak bütün kredileri aratarak hesaplatmak yerine
            //imzayı interface türünden istediğimiz için bütün kredileri tek tuşla hesaplayabildik. Başlangıçta IKrediManager'ı hepsinin base i olarak ayarladık.
            //BaşvuruYap operasyonunun imzasını IKrediManager türünden verdiğimiz için hepsini kapsadı.
            //Bu olaya polymorphism (Çok Biçimlilik) denir. Bir metodu, operasyonu class lara göre farklılık göstertebilme özelliğidir.
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

            //Yeni bir kredi türü ve yeni bir loglama türü çıkartıldığını varsayalım.
            //Sadece Yeni kredi türü ve loglama için sınıf açılır. Kodların içinde boğulmazsın.
            //SOLİD in O harfi 'Open closed principle' . Der ki sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
            //Liste olarakta aşağıdaki örnekteki gibi yapılabilir. BaşvuruManager'dan imzayı List<> olarak ayarlamak gerekiyor.
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {databaseLoggerService,fileLoggerService,new SmsLoggerService() }); 



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
