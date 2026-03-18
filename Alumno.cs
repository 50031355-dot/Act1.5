namespace Act1._5;

class Alumno
{
    private int dni;
    private string nombre;
    private double cantFaltas;


    public Alumno(int dni,  string nombre, double cantFaltas)
    {
        this.dni= dni;
        this.nombre=nombre;
        this.cantFaltas=cantFaltas;
    }

    public int GetDNI(){
        return this.dni;
    }
        public string GetNombre(){
        return this.nombre;
    }
        public double GetFaltas(){
        return this.cantFaltas;
    }
    public string MostrarInfo(){
        return ($"NOMBRE: {this.nombre}. DNI:{this.dni}. CANTIDAD DE FALTAS:{this.cantFaltas}");
    }
    public void AgregarFaltaAlumno(double faltas){
        cantFaltas+=faltas;
    }

}