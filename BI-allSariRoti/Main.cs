using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_allSariRoti
{
    class MainClass
    {
    static void Main(string[] args){

        BIJabodetabek objJabodetabek = new BIJabodetabek();
        BISurabaya objBISurabaya = new BISurabaya();
        BIBandung objBIBandung = new BIBandung();

           /*BI for Jabodetabek */
         objJabodetabek.runBIJabodetabek();

            /*BI for Surabaya */
        //objBISurabaya.runBISurabaya();

        /*BI for Bandung */
        //objBIBandung.runBIBandung();
    }
    
        
       
    }
}
