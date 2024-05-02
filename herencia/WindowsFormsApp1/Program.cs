using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{/*programa de herencia es la caracteristica de pasar atributos y metodos a otros objetos o clases*/
    //actualizacion2
    //clase mama 
    class Operacion
    {
        /*guardara los espacio de memoria de 3 valores*/
        //modificador-tipo de dato-nombre
        protected         int      valor1;
        protected         int      valor2;
        protected         int      resultado;
        //atributos de la clase de operacion

        //metodo o funciones de operacion
        /*los metodos que se ponen acontinuacion
         * son las funciones de obtener el valor
         * de la caja de texto y guardarlo en la memoria dentro de la variable indicad*/
        //USAMOS UN constructor POR CADA CAJA DE MEMORIA
        public int Valor1 //Caja de memoria 1
        {
            get { return valor1; }//vamos por el valor de la caja de texto
            set { valor1 = value; }//lo guardamos en memoria
        }
        public int Valor2 //Caja de memoria 2
        {
            get { return valor2; }//vamos por el valor de la caja de texto
            set { valor2 = value; }//lo guardamos en memoria
        }
        public int Resultado //Caja de resultado
        {
            get { return resultado; }//vamos por el valor de la caja de texto
            set { resultado = value; }//lo guardamos en memoria
        }
    }

    //crearemos nuestra clase hija que usara los metodos de crear datos
    class Sumar : Operacion //los ":" nos da permiso de usar lo que tiene la operacion
    {
        //las clases hijas tambien pueden sus propios atributos y metodos pueden tener 
        //variables de uso solamente para la clase hijo
        //declarar variables de esta clase atributos de esta clase
        //metodos de clase
        public int operar(int v1,int v2)
        {
            valor1 = v1;//accesmos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : Operacion //los ":" nos da permiso de usar lo que tiene la operacion
    {
        //las clases hijas tambien pueden sus propios atributos y metodos pueden tener 
        //variables de uso solamente para la clase hijo
        //declarar variables de esta clase atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1;//accesmos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : Operacion //los ":" nos da permiso de usar lo que tiene la operacion
    {
        //las clases hijas tambien pueden sus propios atributos y metodos pueden tener 
        //variables de uso solamente para la clase hijo
        //declarar variables de esta clase atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1;//accesmos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class Dividir : Operacion //los ":" nos da permiso de usar lo que tiene la operacion
    {
        //las clases hijas tambien pueden sus propios atributos y metodos pueden tener 
        //variables de uso solamente para la clase hijo
        //declarar variables de esta clase atributos de esta clase
        //metodos de clase
        public int operar(int v1, int v2)
        {
            valor1 = v1;//accesmos al constructor de operacion
            valor2 = v2;
            return resultado = valor1 / valor2;
        }
    }

        static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
