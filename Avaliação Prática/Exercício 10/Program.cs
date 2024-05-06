class Program {
    static void Main(string[] args) {
        IReserva reservaRegular = new ReservaRegular();
        IReserva reservaUpgrade = new ReservaComUpgrade();
        IReserva reservaGrupo = new ReservaGrupoGrande();

        reservaRegular.ReservarVoo();
        reservaRegular.CancelarReserva();
        reservaRegular.VerificarStatusReserva();

        reservaUpgrade.ReservarVoo();
        reservaUpgrade.CancelarReserva();
        reservaUpgrade.VerificarStatusReserva();

        reservaGrupo.ReservarVoo();
        reservaGrupo.VerificarStatusReserva();
    }
}