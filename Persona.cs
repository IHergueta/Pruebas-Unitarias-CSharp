using PruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Persona : IPersona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int kmRecorridos;
        private bool vivo;
        private Persona pareja;



        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.kmRecorridos = 0;
            this.pareja = null;
            nacer();
        }

        public Persona(string n, string a, int e)
        {
            this.nombre = n;
            this.apellido = a;
            this.edad = e;
            this.pareja = null;
            this.kmRecorridos = 0;
            nacer();
        }

        public void setNombre(string n)
        {
            this.nombre = n;
        }

        public void setApellido(string a)
        {
            this.apellido = a;
        }

        public void setEdad(int e)
        {
            this.edad = e + 2;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public int getEdad()
        {
            return this.edad;
        }
        public int getKmRecorridos()
        {
            return this.kmRecorridos;
        }
        public Persona getPareja()
        {
            return this.pareja;
        }
        public void copiaPersona(Persona p1)
        {
            this.nombre = p1.getApellido();
            this.apellido = p1.getNombre();
            this.edad = p1.getEdad();
            this.kmRecorridos = p1.getKmRecorridos();
            this.pareja = p1.getPareja();
        }

        public string nombreCompleto()
        {
            return "Nombre Completo: " + this.nombre + " " + this.apellido;
        }

        public void nacer()
        {
            if (this.vivo)
                throw new Exception("Ha vuelto a nacer");
            this.vivo = true;

        }
        public int morir()
        {
            if (!this.vivo)
                throw new Exception("Ya estaba muerto");
            else
            {
                this.vivo = true;
                return this.edad;
            }
        }
        public int salirACorrer(int km)
        {
            this.kmRecorridos = this.kmRecorridos + km;

            return this.kmRecorridos;
        }

        public void conseguirPareja(Persona p)
        {
            this.pareja = null;
        }

        public void dejarPareja(Persona p)
        {
            this.pareja = p;
        }
    }
}
