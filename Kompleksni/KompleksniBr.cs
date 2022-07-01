using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kompleksni
{
    class KompleksniBr
    {

        double re, im;


        public double Re
        {
            get { return re; }
        }
        public double Im
        {
            get { return im; }
        }
        public double Modul
        {
            get { return Math.Sqrt(re * re + im * im); }
        }
        public double Arg
        {
            get { return Math.Atan2(im, re); }
        }


        public KompleksniBr()
        {
            re = im = 0;
        }
        public KompleksniBr(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public KompleksniBr(KompleksniBr a)
        {
            re = a.re;
            im = a.im;
        }

        
        public override string ToString() {
            if (im == 0)
                return re.ToString();
            else
            {
                if (im >= 0)
                    return re.ToString() + " + " + im.ToString() + " i";
                else
                    return re.ToString() + " - " + Math.Abs(im).ToString() + " i";
            }



        }
        public void Citaj(TextBox tb1, TextBox tb2) {
            re = Convert.ToDouble(tb1.Text);
            im = Convert.ToDouble(tb2.Text);
        }


        public static KompleksniBr operator +(KompleksniBr a, KompleksniBr b)
        {
            return new KompleksniBr(a.re + b.re, a.im + b.im);
        }
        public static KompleksniBr operator -(KompleksniBr a, KompleksniBr b)
        {
            return new KompleksniBr(a.re - b.re, a.im - b.im);
        }
        public static KompleksniBr operator *(KompleksniBr a, KompleksniBr b)
        {
            return new KompleksniBr(a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);
           }

    }
    
}
