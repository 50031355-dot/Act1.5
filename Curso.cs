namespace Act1._5;

class Curso
{
    private Dictionary<int, Alumno> alumnos;

    public Curso()
    {
        Dictionary <int, Alumno> alumnos = new Dictionary <int, Alumno> ();
    }

    public bool AgregarAlumno(int dni, string nombre, double cantFaltas)
    {
        bool esta = BuscarAlumno(dni);
        if (esta){
            return false;
        }
        Alumno a = new Alumno(dni, nombre, cantFaltas);
        alumnos.Add(dni, Alumno);
        return true;
    }
    public bool BuscarAlumno(int dni){
        bool esta= alumnos.ContainsKey(dni);
        if (esta){
            return true;
        }
        return false;
    }
    public Dictionary<int, Alumno> MostrarAlumnos(){
        return listaAlumnos;
    }
    public Dictionary<int, Alumno> MostrarAlumnosLibres(){
        Dictionary<int, Alumno> listaLibres = new Dictionary <int, Alumno>();
        foreach(int clave in alumnos){
            double faltas= alumnos[clave].GetFaltas();
            if (faltas>15){
                listaLibres.Add(a);
            }
        }
        return listaLibres;
    }
    public bool AgregarFaltaCurso(int dni, double falta){
        bool encontrado=BuscarAlumno(dni);
        if (encontrado){
            Alumno a =EncontrarAlumno(dni);
            a.AgregarFaltaAlumno(falta);
        }
        return encontrado;
    }
    private Alumno EncontrarAlumno(int dni){ //Esta funcion busca el alumno y además devuelve el alumno
    {

       foreach(int clave in alumnos){
        if ()
       }
       return alumno;
    }
}