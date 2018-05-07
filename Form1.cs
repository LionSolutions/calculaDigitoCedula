using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaCedula
{
    public partial class Form1 : Form
    {
        private string strTemp;
        private string digito;
        private double conta;
        private double indice;

        private double ksiduo;

        private string strinserttemp;

        private int i;

        private int j;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            lbresult.Text = calculaDigitoCedula(txtcedula.Text);
        }

        public string calculaDigitoCedula(string numero)
        {
            string result;
            try
            {
                this.digito = "00";
                if ( numero.ToString().Length != 10 )
                {
                    result = null;
                }
                else
                {
                    this.conta = 0.0;
                    this.indice = 11.0;
                    this.strTemp = numero;
                    this.i = 1;
                    while (this.i <= 10)
                    {
                        this.conta += (double)int.Parse(this.VBLeft(this.strTemp, 1)) * this.indice;
                        this.indice -= 1.0;
                        this.strTemp = this.VBRight(numero, numero.Length - this.i);
                        this.i++;
                    }
                    this.ksiduo = this.conta - Math.Truncate(this.conta / 37.0) * 37.0;
                    this.indice = 37.0 - this.ksiduo;
                    if (this.indice < 10.0)
                    {
                        this.digito = "0" + this.indice.ToString();
                    }
                    else
                    {
                        this.digito = this.indice.ToString();
                    }
                    result = this.digito;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

       

        public string VBLeft(string param, int length)
        {
            return param.Substring(0, length);
        }

        public string VBRight(string param, int length)
        {
            return param.Substring(param.Length - length, length);
        }

        public string VBMid(string param, int startIndex, int length)
        {
            return param.Substring(startIndex, length);
        }

        public string VBMid(string param, int startIndex)
        {
            return param.Substring(startIndex);
        }

    }
}
