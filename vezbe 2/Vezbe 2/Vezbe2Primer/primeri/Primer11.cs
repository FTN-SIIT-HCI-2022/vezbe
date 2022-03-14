using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vezbe2Primer.util;

namespace Vezbe2Primer.primeri
{
    class Resurs : IDisposable
    {
        Primer11 p;
        bool disposed = false;
        public Resurs(Primer11 p)
        {
            this.p = p;
            p.ispisi("Resurs napravljen\r\n");
        }

        //Ovo je kao finalize u Javi—ne znamo kada ce da se pozove, i stoga nikada
        //ne smemo da radimo cleanup ovde
        ~Resurs() 
        {
            p.ispisi("Pozvan finalizator-destruktor za resurs.\r\n");
            Dispose(false);
        }

        //ovo je deo interfejsa, i bica pozvano od strane okruzenja automatski kada izadjemo iz
        //using opsega. Naravno, mozemo to i da pozovemo rukom ako hocemo. 
        public void Dispose()
        {
            if (!disposed)
            {
                Dispose(true);
            }
        }

        //ovo je nasa funkcija za oslobadjanje resursa, zatvaranje fajlova i tako dalje
        //disposing je false ako ga pozove destruktor/finalizator
        //zasto je to bitno? Pa _znamo_ kada se poziva dispose, ali ne i redosled u kome se poziva finalize
        //stoga, ako nas je pozvao finalize smemo da radimo samo onaj cleanup koji ne zavisi ni od jedne 
        //spoljne klase, sto je u vecini slucajeva bas nista.
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
                p.ispisi("Resurs dispose-ovan.\r\n");
            }
        }

        public void uradiNesto()
        {
            p.ispisi("Resurs radi nesto.\r\n");
        }

        public void uradiNestoLose()
        {
            throw new IndexOutOfRangeException();
        }
    }

    public class Primer11 : AbstractPrimer
    {
        public Primer11(frmPrimer2 f) : base(f)
        {

        }

        public override void izvrsi()
        {
            ispisi("Primer 11 - RAII:\r\n");
            ispisi("############\r\n");
            using (Resurs r = new Resurs(this))
            {
                r.uradiNesto();
            }
            ispisi("############\r\n");
            try
            {
                using (Resurs r = new Resurs(this))
                {
                    r.uradiNestoLose();//uprkos tome sto ovo baci exception mi se i dalje uredno
                    //dispose-ujemo

                }
            }
            catch (Exception) 
            {
                ispisi("Uhvacen exception!\r\n");
            }
            ispisi("############\r\n");
        }

    }
}
