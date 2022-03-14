using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vezbe2Primer.util;

namespace Vezbe2Primer.primeri
{
    public class Primer9 : AbstractPrimer
    {
        /* jednostavan primer lambda izraza koji se koriste kao filter za prikaz liste*/
        delegate bool filter<T>(T a);//ovo pokazuje na metodu/funkciju koja vraca bool a prima parametrizovan tip
        public Primer9(frmPrimer2 f) : base(f)
        {

        }
        //potpuno genericka metoda za filtriranje sadrzaja liste
        //umesto ovog delegata koji smo napravili
        //java bi imala genericki interfejs ovde koji bi imao jednu metodu 'test' ili tako nesto
        private List<T> filterList<T>(List<T> list, filter<T> f)
        {
            List<T> ret = new List<T>();//ovo ne moze u Javi zbog brisanja tipova.
            foreach (T t in list)
            {
                if (f(t))
                {
                    ret.Add(t);
                }
            }
            return ret;
        }

        public override void izvrsi()
        {
            List<int> listaBrojeva = new List<int>();
            listaBrojeva.Add(3);
            listaBrojeva.Add(1);
            listaBrojeva.Add(4);
            listaBrojeva.Add(1);
            listaBrojeva.Add(5);
            listaBrojeva.Add(9);
            listaBrojeva.Add(2);
            listaBrojeva.Add(6);
            listaBrojeva.Add(5);
            listaBrojeva.Add(3);
            List<int> rezultat = filterList<int>(listaBrojeva, x => (x % 2 == 0));
            //Ovo bi u Javi uradili sa unutarnjom anonimnom klasom koja bi implementirala interfejs i koju bi
            //prosledili u metodu. Ovde to radimo sa lambda izrazom. Lambda izraz je, u osnovi, literal. Baš kao
            //što je "C#" literal za string, tako je i ovo literal za funkciju. Naravno, lambda izraz je tipa
            //delegata, pošto delegati služe da u jeziku predstave signaturu funkcije. Po tome su moćniji od
            //običnih pokazivača. Lambda izraz se sastoji od liste parametara, strelice, i tela funkcije. U ovom
            //slučaju to je prost lambda izraz koji se svodi na expression u jeziku, i to expression koji
            //proverava da li je element paran ili ne
            ispisi("Primer 9 - Lambda izrazi:\r\n");
            ispisi("############\r\n");
            foreach(int x in rezultat)
            {
                ispisi(x.ToString() + "\r\n");
            }
            ispisi("############\r\n");
        }
    }
}
