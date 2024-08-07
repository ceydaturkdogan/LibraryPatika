using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPatika
{
    public class Library
    {
        private string _bookName { get; set; }
        private string _authorName { get; set; }
        private string _authorSurname { get; set; }
        private string _publisher { get; set; }
        private int _numberOfPages { get; set; }
        private DateTime _registerDate { get; }

        public Library() {

            _registerDate = DateTime.Now;
            Console.WriteLine(_registerDate);

        }
        public Library(string bookName, string authorName,  string publisher, int numberOfPages ) {

            _bookName = bookName;
            _authorName = authorName;
            _publisher = publisher;
            _numberOfPages = numberOfPages;
            _registerDate = DateTime.Now;
            Console.WriteLine($"Kayıt Tarihi:{_registerDate}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Kitap Adı:{_bookName}\nYazar Adı:{_authorName}\nSayfa Sayısı:{_numberOfPages}\nYayınevi:{_publisher}");
        }
    }

    //Burada oluşturduğumuz library classı bir nesne üzerinde birden fazla özelliği aynı anda barındırmak için kullanılır
    //Buradaki propertyler ise nesnemizde bulunan özellikleri tuttuğumuz değişkenler denebilir.
    //New kavramı ise nesneleri oluşturmak için gereklidir.
    //constructor ise bir classta başlangıçta çalışmasını istediğimiz yapıcı metotlardır.
}
