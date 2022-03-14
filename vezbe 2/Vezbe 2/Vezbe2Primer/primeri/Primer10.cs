using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vezbe2Primer.util;

namespace Vezbe2Primer.primeri
{
    /*
     *  Kompleksniji primer lambda izraza.
    */
    public class Primer10 : AbstractPrimer
    {
        public Primer10(frmPrimer2 f) : base(f)
        {

        }

        //Ovde umesto da pravimo delegat samo za ovu jednu stvar, umesto toga specificiramo
        //samo da je to funkcija koja prima dva T tipa a vraca integer. To je kao Comparator u javi.
        //Sam SmartSort uvek sortira u uzlaznom redosledu, ali posto imamo kontrolu nad cmp algoritmom
        //onda mozemo da to promenimo tako sto samo obrnemo logiku
        private void SmartSort<T>(List<T> list, Func<T, T, int> cmp)
        {
            SmartSort(list, cmp, 0, (list.Count - 1 > 0) ? list.Count - 1 : 0);//poziv rekurzivne implementacije
            //QuickSort algoritma. Naravno mogli bi da isti ubrzamo koristeci stek strukturu i iterativno
            //izvrsavanje
        }

        private void SmartSort<T>(List<T> list, Func<T, T, int> cmp, int lo, int hi)
        {
            if (lo >= hi) return;
            int pivot = lo + (hi - lo) / 2; //Biramo pivot QuickSort algoritma koristeci Sedzvikovu sugestiju
            //neobican oblik racunanja sredine je tu zbog opasnosti integer overflow-a za vrlo velike nizove
            T temp;
            int storeLoc = lo;
            temp = list[hi];
            list[hi] = list[pivot];
            list[pivot] = temp;
            //stavili smo pivot na kraj segmenta gde ne moze da smeta, sada vrsimo particiju
            for (int i = lo; i < hi; i++)
            {
                if (cmp(list[i], list[hi]) == -1) //ako je trenutni element manji od pivot-a
                {
                    temp = list[storeLoc];
                    list[storeLoc] = list[i];
                    list[i] = temp;
                    storeLoc++;//pratimo gde smo stavili manje stvari tako da na kraju ove procedure ovo
                    //pokazuje taman gde ide sam pivot. Sve ostalo je netaknuto i nalazi se sa desne strane
                    //storeLoc
                }
            }
            temp = list[storeLoc];
            list[storeLoc] = list[hi];
            list[hi] = temp; //stavimo pivot tamo gde pripada
            //sada imamo dva dela, levi gde je sve manje od pivota, i desni gde je sve vece
            SmartSort(list, cmp, lo, storeLoc - 1);
            SmartSort(list, cmp, storeLoc + 1, hi);
            return;
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

            SmartSort<int>(listaBrojeva, (a, b) =>
            {
                if (a < b)
                {
                    return -1;
                }
                else if (a == b)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            });
            //ovde je isto lambda izraz u pitanju, ali ovde je kompleksniji--baziran je na statement-ima, a ne
            //na izrazima. Ovaj izraz inace, sortira uzlazno.
            ispisi("Primer 10 - Lambda izrazi II:\r\n");
            ispisi("############\r\n");
            foreach (int x in listaBrojeva)
            {
                ispisi(x.ToString() + "\r\n");
            }
            ispisi("############\r\n");

            SmartSort<int>(listaBrojeva, (a, b) =>
            {
                if (a < b)
                {
                    return 1;
                }
                else if (a == b)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            });
            //ovde sortiramo silazeci
            ispisi("############\r\n");
            foreach (int x in listaBrojeva)
            {
                ispisi(x.ToString() + "\r\n");
            }
            ispisi("############\r\n");
            Random r = new Random();
            SmartSort<int>(listaBrojeva, (a, b) =>
            {
                double x = r.NextDouble();
                if (x < 0.5)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            //vraca nasumicno uredjen niz, primetite klauzuru koja radi isto
            //kao u Javi
            ispisi("############\r\n");
            foreach (int x in listaBrojeva)
            {
                ispisi(x.ToString() + "\r\n");
            }
            ispisi("############\r\n");
        }

    }
}
