using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface'ler de, onu implemente eden class'ların referans numarasını tutabiliyor.

            //IhtiyacKrediManager ikm = new IhtiyacKrediManager();
            //ikm.Hesapla();

            //TasitKrediManager tkm = new TasitKrediManager();
            //tkm.Hesapla();

            //KonutKrediManager kkm = new KonutKrediManager();
            //kkm.Hesapla();

            //Interface'i implemente eden class'ların referans no'sunu tutan şeklinde yazılmış hali
            IKrediManager ikm2 = new IhtiyacKrediManager();
            IKrediManager tkm2 = new TasitKrediManager();
            IKrediManager kkm2 = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tkm2, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ikm2, tkm2 };
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
