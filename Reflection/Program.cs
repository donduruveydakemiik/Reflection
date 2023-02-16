using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DortIslem dortIslem= new DortIslem(2,3);
            //Console.WriteLine( dortIslem.Topla2());


            #region Çalışma anında Reflection

            var type = typeof(DortIslem); // Benim çalışacağım tip dörtişlem

            /// Activator.CreateInstance(type); // new DortIslem();

            //DortIslem dortIslem= (DortIslem)Activator.CreateInstance(type,6,7); //parametreli kullanım
            //Console.WriteLine( dortIslem.Carp2());
            // Console.WriteLine(dortIslem.Topla(2,2)); 

            //2.örnek 

            //var instance = Activator.CreateInstance(type, 6, 7);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null)); //parametresiz medhod çalıştırma

            #region reflaction kullanrak class içindeki methodların tümüne ulaşma
            var metods = type.GetMethods();
            foreach (var metod in metods)
            {
                Console.WriteLine(metod.Name);
            }
            #endregion

            #endregion
            Console.ReadLine();
        }

        class DortIslem
        {
            int _sayi1;
            int _sayi2;
            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }
            public DortIslem()
            {

            }


            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }


        }
    }
}
