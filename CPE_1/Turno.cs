public struct Turno  //Definición estructura "Turno".
{
    public Paciente paciente;  //Paciente asignado al turno.
    public string hora;  //Hora del turno asignado.
    public bool ocupado;  //Permite inicar si el turno está ocupado (true) o disponible (false).

    public Turno(Paciente paciente, string hora)  //Constructor que inicializa un turno como ocupado.
    {
        this.paciente = paciente;  //Asigna el paciente al campo "paciente".
        this.hora = hora;  //Asigna la hora del turno al campo "hora".
        this.ocupado = true;  //Marca el turno como ocupado.
    }
}
