using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vezbe2Primer.util;

namespace Vezbe2Primer.primeri
{
    public delegate void MyEventHandler(object sender, EventArgs e); //obrađivač događaja nije klasa-listener, no je metoda. Stoga, 
    //moramo reći kakva metoda, što se odrađuje preko delegata. Sender parametar je ko je okinuo događaj, a EventArgs je generički način
    //da se proslede parametri događaja. 

    class F
    {
        public event MyEventHandler MyEvent;//ovde smo opisali nov događaj koji ima handler koji ima signaturu specificiranu u
        //MyEventHandler delegatu

        protected virtual void OnMyEvent(EventArgs e)//helper metoda koja olakšava okidanje događaja
        {
            if (MyEvent != null) //proverava se da li ima ikoga ko događaj obrađuje
            {
                MyEvent(this, e);//ovako se okida događaj
            }
        }

        public string M1()
        {
            //pretvaramo se da se u ovoj metodi M1 desilo nešto što izaziva da se
            //okine naš događaj što dole i radimo
            OnMyEvent(EventArgs.Empty);
            return "M1 je pokrenut";
        }
    }

    public class Primer6 : AbstractPrimer
    {
        public Primer6(frmPrimer2 f)
            : base(f)
        {

        }

        public override void izvrsi()
        {
            ispisi("Primer 6 - dogadjaji.\r\n");
            ispisi("#############\r\n");
            F f = new F();
            f.MyEvent += obradjivac; //ovde smo dodali obradjivac
            ispisi(f.M1());
            ispisi("\r\n");
            f.MyEvent -= obradjivac; //a ovde smo ga uklonili
            ispisi(f.M1());
            ispisi("\r\n");
        }

        public void obradjivac(object sender, EventArgs e)
        {
            ispisi("Obradjivac dogadjaja je okinut\r\n");
        }

    }
}