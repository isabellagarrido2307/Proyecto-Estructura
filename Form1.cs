namespace Proyecto_Yu_Gi_Oh
{
    public partial class Form1 : Form
    {
        Jugador Jugador1;
        Jugador Jugador2;
        public int TipoFase;
        // 1 = Fase de planeacion (Poner cartas y tal)
        // 2 = Fase de ataque
        // 3 = Fase de planeacion 2
        public int TurnoJugador = 1;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //quitarlo
        }
        public void InicializarTodo()
        {

            Jugador1 = new Jugador()
            {
                Vida = 8000,
                DeckMonstruo = new ListaMonstruos(),
                DeckHechizos = new ListaHechizos(),
                DeckTrampasInvocacion = new ListaTrampasInvocacion(),
                DeckTrampasAtaque = new ListaTrampasAtaque(),
                ManoMonstruos = new ListaMonstruos(),
                ManoHechizos = new ListaHechizos(),
                ManoTrampasInvocacion = new ListaTrampasInvocacion(),
                ManoTrampasAtaque = new ListaTrampasAtaque(),
                Cementerio = new Cementerio(new ListaMonstruos(), new ListaHechizos(), new ListaTrampasInvocacion(), new ListaTrampasAtaque()),
                CampoMonstruos = new ListaMonstruos(),
                CampoHechizos = new ListaHechizos(),
                CampoTrampasInvocacion = new ListaTrampasInvocacion(),
                CampoTrampasAtaque = new ListaTrampasAtaque()

            };

            Jugador1.DeckMonstruo.Insertar(new KuribohAlado());
            Jugador1.DeckMonstruo.Insertar(new GabrielConductor());
            Jugador1.DeckMonstruo.Insertar(new SergioEmbaucador());
            Jugador1.DeckMonstruo.Insertar(new MiguelMondaquera());
            Jugador1.DeckMonstruo.Insertar(new FamiliaUnida());
            Jugador1.DeckMonstruo.Insertar(new Alfonsina());
            Jugador1.DeckMonstruo.Insertar(new AndresAbsoluto());
            Jugador1.DeckMonstruo.Insertar(new AlejandroLapiz());
            Jugador1.DeckMonstruo.Insertar(new ChacinDomino());
            Jugador1.DeckMonstruo.Insertar(new AymaraPeluche());
            Jugador1.DeckMonstruo.Insertar(new SebastianGacha());
            Jugador1.DeckMonstruo.Insertar(new GinoPeloCotufa());
            Jugador1.DeckMonstruo.Insertar(new Isabella());
            Jugador1.DeckMonstruo.Insertar(new AngelIntegral());

            Jugador1.DeckHechizos.Insertar(new OllaCodicia());
            Jugador1.DeckHechizos.Insertar(new FuriaDragoniana());
            Jugador1.DeckHechizos.Insertar(new CambioFidelidad());
            Jugador1.DeckHechizos.Insertar(new ProvisionesEmergencia());
            Jugador1.DeckHechizos.Insertar(new ArremetidaImprudente());
            Jugador1.DeckHechizos.Insertar(new PactoDemoniaco());
            Jugador1.DeckHechizos.Insertar(new Raigeki());
            Jugador1.DeckHechizos.Insertar(new EspadaEscudo());

            Jugador1.DeckTrampasInvocacion.Insertar(new AgujeroSinFondo());
            Jugador1.DeckTrampasInvocacion.Insertar(new LlamarAlCondenado());
            Jugador1.DeckTrampasAtaque.Insertar(new BalatroBalatrez());
            Jugador1.DeckTrampasAtaque.Insertar(new EngatuzamientoLabioso());
            Jugador1.DeckTrampasAtaque.Insertar(new JarraDeLaCodicia());
            Jugador1.DeckTrampasAtaque.Insertar(new EspantapajarosDeHierro());
            Jugador1.DeckTrampasAtaque.Insertar(new CilindroMagico());
            Jugador1.DeckTrampasAtaque.Insertar(new Expropiese());

            Jugador2 = new Jugador()
            {
                Vida = 8000,
                DeckMonstruo = new ListaMonstruos(),
                DeckHechizos = new ListaHechizos(),
                DeckTrampasInvocacion = new ListaTrampasInvocacion(),
                DeckTrampasAtaque = new ListaTrampasAtaque()
            };

            Jugador2.DeckMonstruo.Insertar(new DragonFuego());
            Jugador2.DeckMonstruo.Insertar(new CaballeroOscuro());
            Jugador2.DeckMonstruo.Insertar(new GuerreroRelampago());
            Jugador2.DeckMonstruo.Insertar(new SliferCielo());
            Jugador2.DeckMonstruo.Insertar(new AlaEscudo());
            Jugador2.DeckMonstruo.Insertar(new PollueloSonico());
            Jugador2.DeckMonstruo.Insertar(new RoedorMalicioso());
            Jugador2.DeckMonstruo.Insertar(new LadronFantasma());
            Jugador2.DeckMonstruo.Insertar(new GolemPiedra());
            Jugador2.DeckMonstruo.Insertar(new MagoSombrio());
            Jugador2.DeckMonstruo.Insertar(new RataBlindada());
            Jugador2.DeckMonstruo.Insertar(new RompeEscudos());
            Jugador2.DeckMonstruo.Insertar(new Imitador());
            Jugador2.DeckMonstruo.Insertar(new Kuriboh());

            Jugador2.DeckHechizos.Insertar(new TormentaRelampagos());
            Jugador2.DeckHechizos.Insertar(new RecargaMagica());
            Jugador2.DeckHechizos.Insertar(new EspadaDestino());
            Jugador2.DeckHechizos.Insertar(new MonstruoRenacido());
            Jugador2.DeckHechizos.Insertar(new CuracionSuperma());
            Jugador2.DeckHechizos.Insertar(new ControlMental());
            Jugador2.DeckHechizos.Insertar(new TormentaFlamas());
            Jugador2.DeckHechizos.Insertar(new NegarDefensa());

            Jugador2.DeckTrampasAtaque.Insertar(new EspejoDeFuerza());
            Jugador2.DeckTrampasAtaque.Insertar(new MuroDeDefensa());
            Jugador2.DeckTrampasInvocacion.Insertar(new AgujeroOscuro());
            Jugador2.DeckTrampasAtaque.Insertar(new CambioPreventivo());
            Jugador2.DeckTrampasInvocacion.Insertar(new RobarDestino());
            Jugador2.DeckTrampasAtaque.Insertar(new CadenasDeSombra());
            Jugador2.DeckTrampasAtaque.Insertar(new ArmaduraSakuretsu());
            Jugador2.DeckTrampasInvocacion.Insertar(new AgujeroTrampa());

        }

        private void toolTipDato_Popup(object sender, PopupEventArgs e)
        {

        }

        private void MazoJ1_MouseHover(object sender, EventArgs e)
        {
            this.toolTipDato.SetToolTip(this.MazoJ1, "N° Cartas: " /* variable/procedimiento para calcular el tamaño */);
        }

        private void MazoJ2_MouseHover(object sender, EventArgs e)
        {
            this.toolTipDato.SetToolTip(this.MazoJ2, "N° Cartas: " /* variable/procedimiento para calcular el tamaño */);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
