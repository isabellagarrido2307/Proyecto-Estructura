namespace Proyecto_Yu_Gi_Oh
{
    public partial class Form1 : Form
    {
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

        }
        public void InicializarTodo()
        {
            //AlaEscudo alaEscudo = new AlaEscudo();
            //AlejandroLapiz alejandroLapiz = new AlejandroLapiz();
            //Alfonsina alfonsina = new Alfonsina();
            //AndresAbsoluto andresAbsoluto = new AndresAbsoluto();
            //AngelIntegral angelIntegral = new AngelIntegral();
            //AymaraPeluche aymaraPeluche = new AymaraPeluche();
            //CaballeroOscuro caballeroOscuro = new CaballeroOscuro();
            //ChacinDomino chacinDomino = new ChacinDomino();
            //DragonFuego dragonFuego = new DragonFuego();
            //FamiliaUnida familiaUnida = new FamiliaUnida();
            //GabrielConductor gabrielConductor = new GabrielConductor();
            //GinoPeloCotufa ginoPeloCotufa = new GinoPeloCotufa();
            //GolemPiedra golemPiedra = new GolemPiedra();
            //GuerreroRelampago guerreroRelampago = new GuerreroRelampago();
            //Imitador imitador = new Imitador();
            //Isabella isabella = new Isabella();
            //Kuriboh kuriboh = new Kuriboh();
            //KuribohAlado kuribohAlado = new KuribohAlado();
            //LadronFantasma ladronFantasma = new LadronFantasma();
            //MagoSombrio magoSombrio = new MagoSombrio();
            //MiguelMondaquera miguelMondaquera = new MiguelMondaquera();
            //PollueloSonico pollueloSonico = new PollueloSonico();
            //RataBlindada rataBlindada = new RataBlindada();
            //RoedorMalicioso roedorMalicioso = new RoedorMalicioso();
            //RompeEscudos rompeEscudos = new RompeEscudos();
            //SebastianGacha sebastianGacha = new SebastianGacha();
            //SergioEmbaucador sergioEmbaucador = new SergioEmbaucador();
            //SliferCielo sliferCielo = new SliferCielo();

            //ArremetidaImprudente arremetidaImprudente = new ArremetidaImprudente();
            //CambioFidelidad cambioFidelidad = new CambioFidelidad();
            //ControlMental controlMental = new ControlMental();
            //CuracionSuperma curacionSuperma = new CuracionSuperma();
            //EspadaDestino espadaDestino = new EspadaDestino();
            //EspadaEscudo espadaEscudo = new EspadaEscudo();
            //FuriaDragoniana furiaDragoniana = new FuriaDragoniana();
            //MonstruoRenacido monstruoRenacido = new MonstruoRenacido();
            //NegarDefensa negarDefensa = new NegarDefensa();
            //OllaCodicia ollaCodicia = new OllaCodicia();
            //PactoDemoniaco pactoDemoniaco = new PactoDemoniaco();
            //ProvisionesEmergencia provisionesEmergencia = new ProvisionesEmergencia();
            //Raigeki raigeki = new Raigeki();
            //RecargaMagica recargaMagica = new RecargaMagica();
            //TormentaFlamas tormentaFlamas = new TormentaFlamas();
            //TormentaRelampagos tormentaRelampagos = new TormentaRelampagos();

            //AgujeroOscuro agujeroOscuro = new AgujeroOscuro();
            //AgujeroSinFondo agujeroSinFondo = new AgujeroSinFondo();
            //AgujeroTrampa agujeroTrampa = new AgujeroTrampa();
            //ArmaduraSakuretsu armaduraSakuretsu = new ArmaduraSakuretsu();
            //BalatroBalatrez balatroBalatrez = new BalatroBalatrez();
            //CadenasDeSombra cadenasDeSombra = new CadenasDeSombra();
            //CambioPreventivo cambioPreventivo = new CambioPreventivo();
            //CilindroMagico cilindroMagico = new CilindroMagico();
            //EngatuzamientoLabioso engatuzamientoLabioso = new EngatuzamientoLabioso();
            //EspantapajarosDeHierro espantapajarosDeHierro = new EspantapajarosDeHierro();
            //EspejoDeFuerza espejoDeFuerza = new EspejoDeFuerza();
            //Expropiese expropiese = new Expropiese();
            //JarraDeLaCodicia jarraDeLaCodicia = new JarraDeLaCodicia();
            //LlamarAlCondenado llamarAlCondenado = new LlamarAlCondenado();
            //MuroDeDefensa muroDeDefensa = new MuroDeDefensa();
            //RobarDestino robarDestino = new RobarDestino();

            Jugador Jugador1 = new Jugador()
            {
                Vida = 8000,
                DeckMonstruo = new ListaMonstruos(),
                DeckHechizos = new ListaHechizos(),
                DeckTrampas = new ListaTrampas()
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

            //Jugador1.DeckTrampas.Insertar(new AgujeroSinFondo());

            Jugador Jugador2 = new Jugador()
            {
                Vida = 8000,
                DeckMonstruo = new ListaMonstruos(),
                DeckHechizos = new ListaHechizos(),
                DeckTrampas = new ListaTrampas()
            };

            Jugador2.DeckMonstruo.Insertar(new DragonFuego());
            Jugador2.DeckMonstruo.Insertar(new CaballeroOscuro());
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


        }
    }
}
