namespace Proyecto_Yu_Gi_Oh
{
    public partial class Form1 : Form
    {
        ListaImagenes ManoJ1 = new ListaImagenes();
        ListaImagenes ManoJ2 = new ListaImagenes();
        ListaImagenes CampoMonsJ1 = new ListaImagenes();
        ListaImagenes CampoMonsJ2 = new ListaImagenes();
        ListaImagenes CampoTraJ1 = new ListaImagenes();
        ListaImagenes CampoTraJ2 = new ListaImagenes();


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

        private unsafe void Form1_Load(object sender, EventArgs e)
        {
            InicializarTodo();
            Jugador1.RobarCarta();
            Jugador1.RobarCarta();
            Jugador1.RobarCarta();
            Jugador2.RobarCarta();
            Jugador2.RobarCarta();
            Jugador2.RobarCarta();
            AsignarImagenes();
            cargarImagenes();
        }
        public unsafe void AsignarImagenes()
        {
            // MANO JUGADOR 1
            Nodo* aux = Jugador1.ManoMonstruos.cabeza;
            while (aux != null)
            {
                ManoJ1.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }
            NodoHechizos* aux1 = Jugador1.ManoHechizos.cabeza;
            while (aux1 != null)
            {
                ManoJ1.Insertar(aux1->getHechizo().getDireccion());
                aux1 = aux1->getSiguiente();
            }
            NodoTrampaAtaque* aux2 = Jugador1.ManoTrampasAtaque.cabeza;
            while (aux2 != null)
            {
                ManoJ1.Insertar(aux2->getTrampa().getDireccion());
                aux2 = aux2->getSiguiente();
            }
            NodoTrampasInvocacion* aux3 = Jugador1.ManoTrampasInvocacion.cabeza;
            while (aux3 != null)
            {
                ManoJ1.Insertar(aux3->getTrampa().getDireccion());
                aux3 = aux3->getSiguiente();
            }

            //MANO JUGADOR 2
            aux = Jugador2.ManoMonstruos.cabeza;
            while (aux != null)
            {
                ManoJ2.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }
            aux1 = Jugador2.ManoHechizos.cabeza;
            while (aux1 != null)
            {
                ManoJ2.Insertar(aux1->getHechizo().getDireccion());
                aux1 = aux1->getSiguiente();
            }
            aux2 = Jugador2.ManoTrampasAtaque.cabeza;
            while (aux2 != null)
            {
                ManoJ2.Insertar(aux2->getTrampa().getDireccion());
                aux2 = aux2->getSiguiente();
            }
            aux3 = Jugador2.ManoTrampasInvocacion.cabeza;
            while (aux3 != null)
            {
                ManoJ2.Insertar(aux3->getTrampa().getDireccion());
                aux3 = aux3->getSiguiente();
            }

            //CAMPO MONSTRUOS JUGADOR 1
            aux = Jugador1.CampoMonstruos.cabeza;
            while (aux != null)
            {
                CampoMonsJ1.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }

            //CAMPO MONSTRUOS JUGADOR 2
            aux = Jugador2.CampoMonstruos.cabeza;
            while (aux != null)
            {
                CampoMonsJ2.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }

            //CAMPO TRAMPAS ATAQUE JUGADOR 1
            aux2 = Jugador1.CampoTrampasAtaque.cabeza;
            while (aux2 != null)
            {
                CampoTraJ1.Insertar(aux2->getTrampa().getDireccion());
                aux2 = aux2->getSiguiente();
            }

            //CAMPO TRAMPAS ATAQUE JUGADOR 2
            aux2 = Jugador2.CampoTrampasAtaque.cabeza;
            while (aux2 != null)
            {
                CampoTraJ2.Insertar(aux2->getTrampa().getDireccion());
                aux2 = aux2->getSiguiente();
            }

            //CAMPO TRAMPAS INVOCACION JUGADOR 1
            aux3 = Jugador1.CampoTrampasInvocacion.cabeza;
            while (aux3 != null)
            {
                CampoTraJ1.Insertar(aux3->getTrampa().getDireccion());
                aux3 = aux3->getSiguiente();
            }

            //CAMPO TRAMPAS INVOCACION JUGADOR 2
            aux3 = Jugador2.CampoTrampasInvocacion.cabeza;
            while (aux3 != null)
            {
                CampoTraJ2.Insertar(aux3->getTrampa().getDireccion());
                aux3 = aux3->getSiguiente();
            }
        }
        public unsafe void cargarImagenes()
        {
            // MANO JUGADOR 1
            NodoImagenes* aux = ManoJ1.cabeza;
            J1Mano1.Image = aux->getImagen();
            if (aux->getSiguiente() != null && aux != null)
            {
                aux = aux->getSiguiente();
                J1Mano2.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J1Mano3.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J1Mano4.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J1Mano5.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J1Mano6.Image = aux->getImagen();
            }

            //MANO JUGADOR 2
            aux = ManoJ2.cabeza;
            J2Mano1.Image = aux->getImagen();
            if (aux->getSiguiente() != null && aux != null)
            {
                aux = aux->getSiguiente();
                J2Mano2.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J2Mano3.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J2Mano4.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J2Mano5.Image = aux->getImagen();
            }
            if (aux->getSiguiente() != null)
            {
                aux = aux->getSiguiente();
                J2Mano6.Image = aux->getImagen();
            }

            //CAMPO MONSTRUOS JUGADOR 1
            aux = CampoMonsJ1.cabeza;
            if (aux != null)
            {
                J1CampMons1.Image = aux->getImagen();
                if (aux->getSiguiente() != null && aux != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons2.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons3.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons4.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons5.Image = aux->getImagen();
                }
            }

            // CAMPO MONSTRUOS JUGADOR 2
            aux = CampoMonsJ2.cabeza;
            if (aux != null)
            {
                J2CampMons1.Image = aux->getImagen();
                if (aux->getSiguiente() != null && aux != null)
                {
                    aux = aux->getSiguiente();
                    J2CampMons2.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampMons3.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampMons4.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampMons5.Image = aux->getImagen();
                }
            }

            // CAMPO TRAMPAS JUGADOR 1
            aux = CampoTraJ1.cabeza;
            if (aux != null)
            {
                J1CampTra1.Image = aux->getImagen();
                if (aux->getSiguiente() != null && aux != null)
                {
                    aux = aux->getSiguiente();
                    J1CampTra2.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampTra3.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampTra4.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampTra5.Image = aux->getImagen();
                }
            }

            // CAMPO TRAMPAS JUGADOR 2
            aux = CampoTraJ2.cabeza;
            if (aux != null)
            {
                J2CampTra1.Image = aux->getImagen();
                if (aux->getSiguiente() != null && aux != null)
                {
                    aux = aux->getSiguiente();
                    J2CampTra2.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampTra3.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampTra4.Image = aux->getImagen();
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2CampTra5.Image = aux->getImagen();
                }
            }
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

            Jugador1.DeckTrampasInvocacion.InsertarTra(new AgujeroSinFondo());
            Jugador1.DeckTrampasInvocacion.InsertarTra(new LlamarAlCondenado());
            Jugador1.DeckTrampasAtaque.InsertarTr(new BalatroBalatrez());
            Jugador1.DeckTrampasAtaque.InsertarTr(new EngatuzamientoLabioso());
            Jugador1.DeckTrampasAtaque.InsertarTr(new JarraDeLaCodicia());
            Jugador1.DeckTrampasAtaque.InsertarTr(new EspantapajarosDeHierro());
            Jugador1.DeckTrampasAtaque.InsertarTr(new CilindroMagico());
            Jugador1.DeckTrampasAtaque.InsertarTr(new Expropiese());

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

            Jugador2.DeckTrampasAtaque.InsertarTr(new EspejoDeFuerza());
            Jugador2.DeckTrampasAtaque.InsertarTr(new MuroDeDefensa());
            Jugador2.DeckTrampasInvocacion.InsertarTra(new AgujeroOscuro());
            Jugador2.DeckTrampasAtaque.InsertarTr(new CambioPreventivo());
            Jugador2.DeckTrampasInvocacion.InsertarTra(new RobarDestino());
            Jugador2.DeckTrampasAtaque.InsertarTr(new CadenasDeSombra());
            Jugador2.DeckTrampasAtaque.InsertarTr(new ArmaduraSakuretsu());
            Jugador2.DeckTrampasInvocacion.InsertarTra(new AgujeroTrampa());

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

        private void botonDescartar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
