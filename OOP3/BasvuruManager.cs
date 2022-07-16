using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //TasitKrediManager tkm = new TasitKrediManager();
            //tkm.Hesapla();

            /************************************
            Yukarıdaki gibi kullanım yapılırsa, BasvuruYap metodu sadece taşıt kredisinin hesapla metodunu çalıştırır.
            Yani bu metodu Taşıt kredi manager sınıfına bağımlı hale getirmiş oluruz. Bu yanlış bir kullanımdır.
            Bunun yerine BasvuruYap metoduna tüm manager sınıflarının referansını tutabilen interface'i parametre 
            olarak verirsek, gönderilen kredi türü parametresine göre ilgili manager sınıfının metodunu çalıştırabiliriz.
            ************************************/

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediList)
        {
            foreach (IKrediManager item in krediList)
            {
                item.Hesapla();
            }
        }
    }
}