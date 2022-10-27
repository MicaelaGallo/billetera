using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercbilletera
{
    internal class Billetera
    { 
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            decimal acumulador = 0;

            acumulador += BilletesDe10 * 10;
            acumulador += BilletesDe20 * 20;
            acumulador += BilletesDe50 * 50;
            acumulador += BilletesDe100 * 100;
            acumulador += BilletesDe200 * 200;
            acumulador += BilletesDe500 * 500;
            acumulador += BilletesDe1000 * 1000;
            return acumulador;
        }

       public Billetera Combinar (Billetera SegundaBilletera)
        {
            var billeteraNueva= new Billetera();
            int SumaBill10 = BilletesDe10 + SegundaBilletera.BilletesDe10;
            int SumaBill20 = BilletesDe20 + SegundaBilletera.BilletesDe20;
            int SumaBill50 = BilletesDe50 + SegundaBilletera.BilletesDe50;
            int SumaBill100 = BilletesDe100 + SegundaBilletera.BilletesDe100;
            int SumaBill200 = BilletesDe200 + SegundaBilletera.BilletesDe200;
            int SumaBill500 = BilletesDe500 + SegundaBilletera.BilletesDe500;
            int SumaBill1000 = BilletesDe1000 + SegundaBilletera.BilletesDe1000;

            billeteraNueva.BilletesDe10 = SumaBill10;
            billeteraNueva.BilletesDe20 = SumaBill20;
            billeteraNueva.BilletesDe50 = SumaBill50;
            billeteraNueva.BilletesDe100 = SumaBill100;
            billeteraNueva.BilletesDe200 = SumaBill200;
            billeteraNueva.BilletesDe500=SumaBill500;
            billeteraNueva.BilletesDe1000=SumaBill1000;

            if(billeteraNueva!= null)
            {
                BilletesDe10 = 0;
                BilletesDe20 = 0;
                BilletesDe50 = 0;
                BilletesDe100 = 0;
                BilletesDe200 = 0;
                BilletesDe500 = 0;
                BilletesDe1000 = 0;
                SegundaBilletera.BilletesDe10 = 0;
                SegundaBilletera.BilletesDe20 = 0;
                SegundaBilletera.BilletesDe50 = 0;
                SegundaBilletera.BilletesDe100 = 0;
                SegundaBilletera.BilletesDe200 = 0;
                SegundaBilletera.BilletesDe500 = 0;
                SegundaBilletera.BilletesDe1000 = 0;
            }
               
            return billeteraNueva; 


        }
    }





}

