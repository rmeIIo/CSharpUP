public interface IReserva
{
    void ReservarVoo();
    void CancelarReserva();
    void VerificarStatusReserva();
}

public class ReservaRegular : IReserva
{
    private bool vooCancelado = false;

    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe realizada.");
        vooCancelado = false;
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe cancelada.");
        vooCancelado = true;
    }

    public void VerificarStatusReserva()
    {
        string status = vooCancelado ? "Cancelada" : "Confirmada";
        Console.WriteLine($"Status da reserva de voo com upgrade de classe: {status}.");
    }
}

public class ReservaComUpgrade : IReserva
{
    private bool vooCancelado = false;

    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe realizada.");
        vooCancelado = false;
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe cancelada.");
        vooCancelado = true;
    }

    public void VerificarStatusReserva()
    {
        string status = vooCancelado ? "Cancelada" : "Confirmada";
        Console.WriteLine($"Status da reserva de voo com upgrade de classe: {status}.");
    }
}

public class ReservaGrupoGrande : IReserva
{
    private bool vooCancelado = false;

    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe realizada.");
        vooCancelado = false;
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe cancelada.");
        vooCancelado = true;
    }

    public void VerificarStatusReserva()
    {
        string status = vooCancelado ? "Cancelada" : "Confirmada";
        Console.WriteLine($"Status da reserva de voo com upgrade de classe: {status}.");
    }
}