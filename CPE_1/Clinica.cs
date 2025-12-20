using System;              
using System.IO;           

/*
 * Clinica
 * Se encarga de gestionar los pacientes y la agenda de turnos.
 */
public class Clinica
{
    // Definición del número máximo de pacientes.
    private const int PacientesMax = 5;

    // Vector que almacena los pacientes registrados.
    private Paciente[] pacientes = new Paciente[PacientesMax];

    // Contador para llevar el número de pacientes registrados.
    private int pacienteCount = 0;

    // Matriz que representa la agenda de turnos (5 días x 5 horarios).
    private Turno[,] agenda = new Turno[5, 5];

    // Vector con los días de atención a los pacientes.
    private string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };

    // Vector con los horarios disponibles para consulta.
    public string[] horarios = { "08 a.m.", "09 a.m.", "10 a.m.", "11 a.m.", "12 p.m." };

    /*
     * Método para agregar un nuevo paciente.
     */
    public void AgregarPaciente(Paciente p)
    {
        // Verificación del número máximo de pacientes.
        if (pacienteCount < PacientesMax)
        {
            pacientes[pacienteCount++] = p; // Se guarda el paciente y se incrementa el contador.
            Console.WriteLine("Paciente registrado.");
        }
        else
        {
            Console.WriteLine("No se pueden registrar más pacientes.");
        }
    }

    /*
     * Método que busca un paciente por su DNI.
     * Retorna el paciente si lo encuentra o null si no existe.
     */
    public Paciente BuscarPacientePorDNI(string dni)
    {
        for (int i = 0; i < pacienteCount; i++)
        {
            if (pacientes[i].DNI == dni)
                return pacientes[i];
        }
        return null;
    }

    /*
     * Método para asignar un turno a un paciente.
     */
    public void AsignarTurno(string dni, int dia, int hora)
    {
        // Validación de rangos de día y hora.
        if (dia < 0 || dia >= 5 || hora < 0 || hora >= horarios.Length)
        {
            Console.WriteLine("Día u hora inválidos.");
            return;
        }

        // Buscar un paciente por DNI.
        Paciente paciente = BuscarPacientePorDNI(dni);

        // Verificación que el paciente exista y que el turno esté disponible.
        if (paciente != null && !agenda[dia, hora].ocupado)
        {
            agenda[dia, hora] = new Turno(paciente, horarios[hora]);
            Console.WriteLine($"Turno asignado a {paciente.Nombre} el {dias[dia]} a las {horarios[hora]}");
        }
        else
        {
            Console.WriteLine("Turno no disponible o paciente no encontrado.");
        }
    }

    /*
     * Método para mostrar en pantalla los pacientes registrados.
     */
    public void MostrarPacientes()
    {
        Console.WriteLine("Pacientes Registrados:");
        for (int i = 0; i < pacienteCount; i++)
        {
            Console.WriteLine($"{pacientes[i].Nombre} - DNI: {pacientes[i].DNI} - Edad: {pacientes[i].Edad}");
        }
    }

    /*
     * Método para mostrar la agenda de turnos asignados.
     */
    public void MostrarAgenda()
    {
        Console.WriteLine("Turnos Asignados:");
        bool hayTurnos = false;

        
        for (int d = 0; d < agenda.GetLength(0); d++) // Recorre los días.
        {
            for (int h = 0; h < agenda.GetLength(1); h++) // Recorre los horarios.
            {
                // Verificación si el turno está ocupado.
                if (agenda[d, h].ocupado)
                {
                    var turno = agenda[d, h];
                    Console.WriteLine(
                        $"Día: {dias[d]}, Hora: {horarios[h]}, Paciente: {turno.paciente.Nombre} (DNI: {turno.paciente.DNI})"
                    );
                    hayTurnos = true;
                }
            }
        }

        // Si no se encontró ningún turno ocupado.
        if (!hayTurnos)
        {
            Console.WriteLine("No hay turnos asignados.");
        }
    }

    /*
     * Método para guardar los pacientes.
     */
    public void GuardarPacientesEnArchivo(string ruta)
    {
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            for (int i = 0; i < pacienteCount; i++)
            {
                sw.WriteLine($"{pacientes[i].Nombre}|{pacientes[i].Edad}|{pacientes[i].DNI}");
            }
        }
    }

    /*
     * Método para cargar los pacientes.
     */
    public void CargarPacientesDesdeArchivo(string ruta)
    {
        if (!File.Exists(ruta)) return;

        foreach (string linea in File.ReadAllLines(ruta))
        {
            var datos = linea.Split('|');
            if (datos.Length == 3)
            {
                AgregarPaciente(new Paciente(datos[0], int.Parse(datos[1]), datos[2]));
            }
        }
    }

    /*
     * Método para guardar la agenda de turnos.
     */
    public void GuardarAgendaEnArchivo(string ruta)
    {
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            for (int d = 0; d < 5; d++)
            {
                for (int h = 0; h < horarios.Length; h++)
                {
                    if (agenda[d, h].ocupado)
                    {
                        var p = agenda[d, h].paciente;
                        sw.WriteLine($"{d}|{h}|{p.Nombre}|{p.Edad}|{p.DNI}");
                    }
                }
            }
        }
    }

    /*
     * Método para cargar la agenda de turnos.
     */
    public void CargarAgendaDesdeArchivo(string ruta)
    {
        if (!File.Exists(ruta)) return;

        foreach (string linea in File.ReadAllLines(ruta))
        {
            var datos = linea.Split('|');
            if (datos.Length == 5)
            {
                int d = int.Parse(datos[0]);
                int h = int.Parse(datos[1]);
                Paciente p = new Paciente(datos[2], int.Parse(datos[3]), datos[4]);
                agenda[d, h] = new Turno(p, horarios[h]);
            }
        }
    }
}
