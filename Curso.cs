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
        alumnos.Add(dni, a);
        return true;
    }
    public bool BuscarAlumno(int dni){
        bool esta= alumnos.ContainsKey(dni);
        if (esta){
            return true;
        }
        return false;
    }
    public List<Alumno> MostrarAlumnos(){
        List<Alumno> listaAlumnos=new List<Alumno>();
        foreach (int clave in alumnos.Keys){
            listaAlumnos.Add(alumnos[clave]);
        }
        return listaAlumnos;
    }
    public List<Alumno> MostrarAlumnosLibres(){
        List<Alumno> listaLibres = new List< Alumno>();
        foreach(int clave in alumnos.Keys){
            double faltas= alumnos[clave].GetFaltas();
            if (faltas>15){
                listaLibres.Add(alumnos[clave]);
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
    private Alumno EncontrarAlumno(int dni) //Esta funcion busca el alumno y además devuelve el alumno
    {
       foreach (int clave in alumnos.Keys){
        if (clave == dni){
            return alumnos[clave];
        } 
        }
        return null;
    }
}