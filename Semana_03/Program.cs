Console.WriteLine("Tarea Semana #3 - Enrique Gaguancela");
Console.WriteLine("\n");

// Crear un objeto de la clase Estudiante y mostrar su información.
string[] num_tel = { "097 147 2580", "098 369 2580", "099 123 4560" };
Estudiante estudiante = new Estudiante(1, "Enrique", "Gaguancela", "Riobamba, Licán 753", num_tel);

// Llamar al método para mostrar la información del estudiante.
estudiante.MostrarInformacionEstudiante();