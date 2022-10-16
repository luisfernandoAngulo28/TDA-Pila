using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
    public class clsPila
    {
        //Atributos
        public const int MAX = 10;
        private int _top;
        private int[] _pila;

        //Constructor
        
        public clsPila()
        {
            _top = -1;
            _pila = new int[MAX];
        }
        // constructor de copia
        public clsPila(clsPila p)
        {
            _top = p._top;
            _pila = new int[MAX];
            for (int i = 0; i < p._top; i++)
            {
                _pila[i] = p._pila[i];
            }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
            
        }

        public int[] Pila
        {
            get { return _pila; }
            set { _pila = value; }
           
        }

        //Destruir la Pila
        public void Drop()
        {
            _top = -1;
        }

        // Vacia Validar si la pila esta Vacia
        public Boolean Vacia()
        {
            if (_top == -1)
            {
                return true;
            }
            return false;
        }

        public Boolean Vacia2()
        {
            
            return _top==-1;
        }
        //Obtiene el elemento de la cima de la pila
        public int Tope()
        {
            if (!Vacia() )
            {
                return _pila[_top];
            }
            return 0;
        }

        //Adicionar un elemento a la Cima de la Pila
        public void Add(int elemento)
        {
            if (!Llena())
            {
                _top++;
                _pila[_top] = elemento;
            }
        }

        //Eliminar el Elemento de la Cima de la Pila
        public void Delete()
        {
            if (!Vacia())
            {
                _top--;
            }
        }

        public Boolean Llena()
        {
            if (_top + 1 == MAX)
            {
                return true;
            }
            return false;
        }

        public Boolean Llena2()
        {
           return _top + 1 == MAX;
        }


        //Obtene la Cantidad de Elementos en  la Pia
        public int Long()
        {
            return _top + 1;
        }

        //Imprimir los Elementos de la Pila
        public String Imprimir()
        {
            String S = "";
            for(int i = 0; i <= _top; i++)
            {
                S = S + "[" + _pila[i].ToString() + "]";
            }
            return S;
        }





        //a. Rear(S) --> elemento // retorna el elemento del fondo de la pila

        public int Reac()
        {
            if (!Vacia())
            {
                return _pila[0];
            }
            return 0;
        }






        //b. Avg(S) --> NumReal // retorna el promedio de los elementos de la pila

        public float Avg()
        {
            float S = 0;
            for(int i = 0; i <= _top; i++)
            {
                S = S + _pila[i];
            }
            S = S / (_top + 1);
            return S;
        }





        //c. Suma(S) --> NumEntero //retorna la suma de los elementos de la Pila

        public int Suma()
        {
            int S = 0;
            for (int i = 0; i <= _top; i++)
            {
                S = S + _pila[i];
            }
            return S;
        }




        // d.Ivertir(S) --> S //invierte los elementos de la pila
        public clsPila Invertir(clsPila P)
        {
            clsPila d = new clsPila();
            for (int i = P._top; i >= 0; i--)
            {
                d.Add(P._pila[i]);
            }
            return d;
        }
















    }
}
