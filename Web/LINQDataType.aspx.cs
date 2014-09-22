using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Negocio;


namespace Web
{
    public partial class LINQDataType : System.Web.UI.Page
    {


        protected void btnEjecutar_Click(object sender, EventArgs e)

        {

            tbResultado.Text = Linq14();
        }

        private string numeroMayores() 
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            string str = "";

            var lowNums =
                from n in numbers
                where n < 5
                select n;

            str = "Numbers < 5 \n";

            foreach (var x in lowNums)
            {
                str += x + "\n";
            }

            return str;
        }

        public string Linq12()
        {
            string str = "";

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });

            str = "Number: In-place?";
            foreach (var n in numsInPlace)
            {
                str += n.Num.ToString() + n.InPlace.ToString() + "\n";
            }
            return str;
        }


        public string Linq14()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            string str = "";

            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a, b };

            str = "Pairs where a < b:" + "\n";
            foreach (var pair in pairs)
            {
                str += "{0} is less than {1}" + pair.a.ToString() + pair.b.ToString() + "\n";
            }

            return str;
        }


    }
}