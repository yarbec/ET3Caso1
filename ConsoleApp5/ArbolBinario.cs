using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArbolBinario
    {
        public Nodo raiz;
        private string nombre;

        public ArbolBinario(string nombre, string apellido, string carrera)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
        }

        private int id;

        public ArbolBinario(int id, string carrera)
        {
            this.id = id;
            this.carrera = carrera;
        }

        public ArbolBinario(Nodo raiz, string nombre, int id, string apellido, string carrera)
        {
            this.raiz = raiz;
            this.nombre = nombre;
            this.id = id;
            this.apellido = apellido;
            this.carrera = carrera;
        }

        private readonly string apellido;

        public ArbolBinario(string apellido)
        {
            this.apellido = apellido;
        }

        public ArbolBinario()
        {
        }

        private readonly string carrera;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierdo);
                Console.WriteLine("{0}, valor {1}", raiz.id, raiz.nombre, raiz.apellido, raiz.carrera) ;
                Inorden(raiz.derecho);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0}, valor {1}", raiz.id, raiz.nombre, raiz.apellido, raiz.carrera);
                Preorden(raiz.izquierdo);
                Preorden(raiz.derecho);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierdo);
                Postorden(raiz.derecho);
                Console.WriteLine("{0}, valor {1}", raiz.id, raiz.nombre, raiz.apellido, raiz.carrera);
            }
        }

        public void InsertarNodo(int valor, string valor2)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                id = id,
                nombre = nombre,
                apellido = apellido,
                carrera = carrera

            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (valor < puntero.id)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }

        public void BuscarPorValor(Nodo puntero, string nombre, string apellido, string carrera, int contador)
        {
            if (puntero != null)
            {
                contador += 1;
                if (puntero.nombre == nombre)
                {
                    Console.WriteLine("{0} encontrado en posición {1}", puntero.nombre, puntero.id);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                BuscarPorValor(puntero.izquierdo, nombre, contador);
                BuscarPorValor(puntero.derecho, nombre, contador);
            }
            else
            {
                Console.WriteLine("Total de iteraciones:" + contador);
            }
        }

        private void BuscarPorValor(Nodo izquierdo, string nombre, int contador)
        {
            throw new NotImplementedException();
        }

        public void BuscarPorLlave(int llave)
        {
            int contador = 0;
            Nodo puntero = raiz;
            while (puntero != null)
            {
                contador += 1;
                if (puntero.id == llave)
                {
                    Console.WriteLine("Llave {0} encontrada", puntero.id);
                    Console.WriteLine("Valor de la llave: {0} ", puntero.nombre);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                else
                {
                    if (llave > puntero.id)
                    {
                        puntero = puntero.derecho;
                    }
                    else
                    {
                        puntero = puntero.izquierdo;
                    }
                }
            }
            Console.WriteLine("No se encontró la llave");
            Console.WriteLine("Total de iteraciones:" + contador);
        }

        public Nodo Eliminar(Nodo puntero, int llave)
        {
            if (puntero == null)
            {
                return puntero;
            }
            if (llave < puntero.id)
            {
                puntero.izquierdo = Eliminar(puntero.izquierdo, llave);
            }
            if (llave > puntero.id)
            {
                puntero.derecho = Eliminar(puntero.derecho, llave);
            }
            if (llave == puntero.id)
            {
                if (puntero.izquierdo == null && puntero.derecho == null)
                {
                    puntero = null;
                    return puntero;
                }
                else if (puntero.izquierdo == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.derecho;
                    temp = null;
                }
                else if (puntero.derecho == null)
                {
                    Nodo temp = puntero;
                    puntero = puntero.izquierdo;
                    temp = null;
                }
            }
            return puntero;
        }
    }
}
