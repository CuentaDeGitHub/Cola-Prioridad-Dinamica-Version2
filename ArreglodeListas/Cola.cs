using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglodeListas
{
    class Cola
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }

        Nodo[] ArregloListas;
            public Cola()
            {   
                ArregloListas = new Nodo[3];
                ArregloListas[0] = null;
                ArregloListas[1] = null;
                ArregloListas[2] = null;
            }   
        public void Encolar(Nodo n)
        {
            if(n.Dato == "")
            {
                return;
            }
            if (ArregloListas[n.Prioridad] == null)
            {   
                Head = new Nodo();
                ArregloListas[n.Prioridad] = Head;
                ArregloListas[n.Prioridad].Siguiente = n;      
                return;
            }            
            Nodo h = ArregloListas[n.Prioridad];
            while(h.Siguiente != null)
            {
                h = h.Siguiente;
            }
            h.Siguiente = n; 
        }

        public void Desencolar()
        {
            try
            {
                Nodo head = ArregloListas[0];
                if (head.Siguiente != null)
                {
                    Eliminar(0);
                    return;
                }
                head = ArregloListas[1];
                if (head.Siguiente != null)
                {
                    Eliminar(1);
                    return;
                }
                head = ArregloListas[2];
                if (head.Siguiente != null)
                {
                    Eliminar(2);
                    return;
                }
                return;
            }
            catch(NullReferenceException )
            {
                return;  
            }
           
        }

        public void Eliminar(int prioridad)
        {
            if (ArregloListas[prioridad].Siguiente.Siguiente == null)
            {
                ArregloListas[prioridad].Siguiente = null;  
            }
            else
            {
                ArregloListas[prioridad].Siguiente = ArregloListas[prioridad].Siguiente.Siguiente;
            }
        }
        
        public void IncrementarPrioridad()
        {
            Nodo h = ArregloListas[1];
            if(h.Siguiente != null)
            {
                h = h.Siguiente;
                h.Prioridad = 0;
                Eliminar(1);
                Encolar(h);
                h.Siguiente = null;
            }
            h = ArregloListas[2];
            if(h.Siguiente != null)
            {
                h = h.Siguiente;
                h.Prioridad = 1;
                Eliminar(2);
                Encolar(h);
                h.Siguiente = null;
            }
        }  
            
        
        public string Texto(int prioridad)
        {
            string ColaString = "";
            Head = ArregloListas[prioridad];
            if (Head != null)
            {         
                if(Head.Siguiente == null)
                {
                    return "La cola esta vacia";
                }
                Head = Head.Siguiente;
                ColaString += Head.ToString();
                Head = Head.Siguiente;
                while (Head != null)
                {

                    ColaString += "," + Head.ToString();
                    Head = Head.Siguiente;
                }
                return ColaString;
            }
            else
            {
                return "La cola esta vacia";
            }
        }
    }
}
