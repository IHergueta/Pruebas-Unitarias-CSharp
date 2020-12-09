namespace UnitTestProject1
{
    public interface IPersona
    {
        void conseguirPareja(Persona p);
        void copiaPersona(Persona p1);
        void dejarPareja(Persona p);
        string getApellido();
        int getEdad();
        int getKmRecorridos();
        string getNombre();
        Persona getPareja();
        int morir();
        void nacer();
        string nombreCompleto();
        int salirACorrer(int km);
        void setApellido(string a);
        void setEdad(int e);
        void setNombre(string n);
    }
}