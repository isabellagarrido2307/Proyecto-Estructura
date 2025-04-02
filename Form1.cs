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
        public int TipoFase = 1;
        // 1 = Fase de planeacion (Poner cartas y tal)
        // 2 = Fase de ataque
        // 3 = Fase de planeacion 2
        public int TurnoJugador = 1;
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(cerrarform);
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
            Jugador1.ManoHechizos.Insertar(new OllaCodicia());
            ActualizarFase(Jugador1, Jugador2);
            AsignarImagenes();
            cargarImagenes();
            actualizacionVida.Start();
        }
        //cositas del front
        public void ImagenVacia()
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.Default;
            }
        }
        private void cerrarform(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //codigo
        public unsafe void ActualizarFase(Jugador JugadorAJugar, Jugador JugadorEnemigo)
        {
            if (TipoFase == 1)
            {
                comboBoxCampoAliado.Items.Clear();
                comboBoxMano.Items.Clear();
                comboBoxManoHechizo.Items.Clear();
                comboBoxManoTra.Items.Clear();
                comboBoxMano.Items.Clear();
                Nodo* aux = JugadorAJugar.ManoMonstruos.cabeza;
                while (aux != null)
                {
                    comboBoxMano.Items.Add(aux->getMonstruo().getNombre());
                    aux = aux->getSiguiente();
                }
                aux = JugadorAJugar.CampoMonstruos.cabeza;
                while (aux != null)
                {
                    comboBoxCampoAliado.Items.Add(aux->getMonstruo().getNombre());
                    aux = aux->getSiguiente();
                }
                NodoHechizos* aux1 = JugadorAJugar.ManoHechizos.cabeza;
                while (aux1 != null)
                {
                    comboBoxManoHechizo.Items.Add(aux1->getHechizo().getNombre());
                    aux1 = aux1->getSiguiente();
                }
                NodoTrampaAtaque* aux2 = JugadorAJugar.ManoTrampasAtaque.cabeza;
                while (aux2 != null)
                {
                    comboBoxManoTra.Items.Add(aux2->getTrampa().getNombre());
                    aux2 = aux2->getSiguiente();
                }
                NodoTrampasInvocacion* aux3 = JugadorAJugar.ManoTrampasInvocacion.cabeza;
                while (aux3 != null)
                {
                    comboBoxManoTra.Items.Add(aux3->getTrampa().getNombre());
                    aux3 = aux3->getSiguiente();
                }
                Fase1.Image = Properties.Resources.Fase1;
                comboBoxAtacante.Enabled = false;
                comboBoxDefensor.Enabled = false;
                botonAtacar.Enabled = false;
                botonEliminarHechizo.Enabled = true;
                botonEliminarMounstro.Enabled = true;
                botonEliminarTra.Enabled = true;
                comboBoxCampoAliado.Enabled = true;
                comboBoxMano.Enabled = true;
                comboBoxManoHechizo.Enabled = true;
                comboBoxManoTra.Enabled = true;
            }
            else
            if (TipoFase == 2)
            {
                comboBoxAtacante.Items.Clear();
                comboBoxDefensor.Items.Clear();
                Nodo* aux = JugadorAJugar.CampoMonstruos.cabeza;
                while (aux != null)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        comboBoxAtacante.Items.Add(aux->getMonstruo().getNombre());
                    }
                    aux = aux->getSiguiente();
                }
                aux = JugadorEnemigo.CampoMonstruos.cabeza;
                while (aux != null)
                {
                    comboBoxDefensor.Items.Add(aux->getMonstruo().getNombre());
                    aux = aux->getSiguiente();
                }
                Fase1.Image = Properties.Resources.Fase2;
                comboBoxAtacante.Enabled = true;
                comboBoxDefensor.Enabled = true;
                botonAtacar.Enabled = true;
                botonEliminarHechizo.Enabled = false;
                botonEliminarMounstro.Enabled = false;
                botonEliminarTra.Enabled = false;
                comboBoxCampoAliado.Enabled = false;
                comboBoxMano.Enabled = false;
                comboBoxManoHechizo.Enabled = false;
                comboBoxManoTra.Enabled = false;
            }
            else
            if (TipoFase == 3)
            {
                comboBoxCampoAliado.Items.Clear();
                comboBoxMano.Items.Clear();
                comboBoxManoHechizo.Items.Clear();
                comboBoxManoTra.Items.Clear();
                comboBoxMano.Items.Clear();
                Nodo* aux = JugadorAJugar.ManoMonstruos.cabeza;
                while (aux != null)
                {
                    comboBoxMano.Items.Add(aux->getMonstruo().getNombre());
                    aux = aux->getSiguiente();
                }
                aux = JugadorAJugar.CampoMonstruos.cabeza;
                while (aux != null)
                {
                    comboBoxCampoAliado.Items.Add(aux->getMonstruo().getNombre());
                    aux = aux->getSiguiente();
                }
                NodoHechizos* aux1 = JugadorAJugar.ManoHechizos.cabeza;
                while (aux1 != null)
                {
                    comboBoxManoHechizo.Items.Add(aux1->getHechizo().getNombre());
                    aux1 = aux1->getSiguiente();
                }
                NodoTrampaAtaque* aux2 = JugadorAJugar.ManoTrampasAtaque.cabeza;
                while (aux2 != null)
                {
                    comboBoxManoTra.Items.Add(aux2->getTrampa().getNombre());
                    aux2 = aux2->getSiguiente();
                }
                NodoTrampasInvocacion* aux3 = JugadorAJugar.ManoTrampasInvocacion.cabeza;
                while (aux3 != null)
                {
                    comboBoxManoTra.Items.Add(aux3->getTrampa().getNombre());
                    aux3 = aux3->getSiguiente();
                }
                Fase1.Image = Properties.Resources.Fase3;
                comboBoxAtacante.Enabled = false;
                comboBoxDefensor.Enabled = false;
                botonAtacar.Enabled = false;
                botonEliminarHechizo.Enabled = true;
                botonEliminarMounstro.Enabled = true;
                botonEliminarTra.Enabled = true;
                comboBoxCampoAliado.Enabled = true;
                comboBoxMano.Enabled = true;
                comboBoxManoHechizo.Enabled = true;
                comboBoxManoTra.Enabled = true;
            }
        }
        public unsafe void AsignarImagenes()
        {
            // MANO JUGADOR 1
            ManoJ1 = new ListaImagenes();
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
            ManoJ2 = new ListaImagenes();
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
            CampoMonsJ1 = new ListaImagenes();
            aux = Jugador1.CampoMonstruos.cabeza;
            while (aux != null)
            {
                CampoMonsJ1.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }

            //CAMPO MONSTRUOS JUGADOR 2
            CampoMonsJ2 = new ListaImagenes();
            aux = Jugador2.CampoMonstruos.cabeza;
            while (aux != null)
            {
                CampoMonsJ2.Insertar(aux->getMonstruo().getDireccion());
                aux = aux->getSiguiente();
            }

            //CAMPO TRAMPAS ATAQUE JUGADOR 1
            CampoTraJ1 = new ListaImagenes();
            aux2 = Jugador1.CampoTrampasAtaque.cabeza;
            while (aux2 != null)
            {
                CampoTraJ1.Insertar(aux2->getTrampa().getDireccion());
                aux2 = aux2->getSiguiente();
            }

            //CAMPO TRAMPAS ATAQUE JUGADOR 2
            CampoTraJ2 = new ListaImagenes();
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
            if (aux != null)
            {
                J1Mano1.Image = aux->getImagen();
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1Mano2.Image = aux->getImagen();
                }
                else
                {
                    J1Mano2.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1Mano3.Image = aux->getImagen();
                }
                else
                {
                    J1Mano3.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1Mano4.Image = aux->getImagen();
                }
                else
                {
                    J1Mano4.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1Mano5.Image = aux->getImagen();
                }
                else
                {
                    J1Mano5.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1Mano6.Image = aux->getImagen();
                }
                else
                {
                    J1Mano6.Image = null;
                }
            }
            else
            {
                J1Mano1.Image = null;
            }

            //MANO JUGADOR 2
            aux = ManoJ2.cabeza;
            if (aux != null)
            {
                J2Mano1.Image = aux->getImagen();
                if (aux->getSiguiente() != null && aux != null)
                {
                    aux = aux->getSiguiente();
                    J2Mano2.Image = aux->getImagen();
                }
                else
                {
                    J2Mano2.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2Mano3.Image = aux->getImagen();
                }
                else
                {
                    J2Mano3.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2Mano4.Image = aux->getImagen();
                }
                else
                {
                    J2Mano4.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2Mano5.Image = aux->getImagen();
                }
                else
                {
                    J2Mano5.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J2Mano6.Image = aux->getImagen();
                }
                else
                {
                    J2Mano6.Image = null;
                }
            }
            else
            {
                J2Mano1.Image = null;
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
                else
                {
                    J1CampMons2.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons3.Image = aux->getImagen();
                }
                else
                {
                    J1CampMons3.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons4.Image = aux->getImagen();
                }
                else
                {
                    J1CampMons4.Image = null;
                }
                if (aux->getSiguiente() != null)
                {
                    aux = aux->getSiguiente();
                    J1CampMons5.Image = aux->getImagen();
                }
                else { J1CampMons5.Image = null; }

            }
            else
            {
                J1CampMons1.Image = null;
                J1CampMons2.Image = null;
                J1CampMons3.Image = null;
                J1CampMons4.Image = null;
                J1CampMons5.Image = null;
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
        public unsafe void InvocarMonstruo(Jugador JugadorInvocando, Jugador JugadorEnemigo, string NombreMons)
        {
            Nodo* aux = JugadorInvocando.ManoMonstruos.cabeza;
            while (aux->getMonstruo().getNombre() != NombreMons)
            {
                aux = aux->getSiguiente();
            }
            aux->getMonstruo().EfectoDespliegue(JugadorInvocando.CampoMonstruos, JugadorEnemigo.CampoMonstruos);
            JugadorInvocando.CampoMonstruos.Insertar(aux->getMonstruo());
            JugadorInvocando.ManoMonstruos.Eliminar(aux->getMonstruo());
        }
        public unsafe void UsarHechizo(Jugador JugadorUso, Jugador JugadorEnemigo, string NombreHechizo)
        {
            NodoHechizos* aux = JugadorUso.ManoHechizos.cabeza;
            while (aux->getHechizo().getNombre() != NombreHechizo)
            {
                aux = aux->getSiguiente();
            }

            MessageBox.Show("Activamos efecto" + aux->getHechizo().getNombre());

            aux->getHechizo().activarEfecto(JugadorUso, JugadorEnemigo);
            MessageBox.Show("post actIVAMOS efecto");

            JugadorUso.Cementerio.CementerioHechizos.Insertar(aux->getHechizo());
            JugadorUso.ManoHechizos.Eliminar(aux->getHechizo());
        }
        public unsafe void EliminarTrampa(Jugador JugadorAliado, string NombreTrampa)
        {
            NodoTrampasInvocacion* aux = JugadorAliado.ManoTrampasInvocacion.cabeza;
            while (aux != null)
            {
                var trampa = aux->getTrampa();
                if (trampa != null && trampa.getNombre() == NombreTrampa)
                {
                    break;
                }
                aux = aux->getSiguiente();
            }
            if (aux != null)
            {
                JugadorAliado.Cementerio.CementerioTrampasInvocacion.InsertarTra(aux->getTrampa());
                JugadorAliado.ManoTrampasInvocacion.Eliminar(aux->getTrampa());
            }
            else
            {
                NodoTrampaAtaque* aux2 = JugadorAliado.ManoTrampasAtaque.cabeza;
                while (aux2 != null)
                {
                    var trampa = aux2->getTrampa();
                    if (trampa != null && trampa.getNombre() == NombreTrampa)
                    {
                        break;
                    }
                    aux2 = aux2->getSiguiente();
                }
                if (aux2 != null)
                {
                    JugadorAliado.Cementerio.CementerioTrampasAtaque.InsertarTr(aux2->getTrampa());
                    JugadorAliado.ManoTrampasAtaque.Eliminar(aux2->getTrampa());
                }
            }
        }
        public unsafe void DesplegarTrampa(Jugador JugadorAliado, Jugador JugadorEnemigo, string NombreTrampa)
        {
            NodoTrampasInvocacion* aux = JugadorAliado.ManoTrampasInvocacion.cabeza;
            while (aux != null)
            {
                if (aux->getTrampa().getNombre() == NombreTrampa)
                {
                    break;
                }
                aux = aux->getSiguiente();
            }
            if (aux != null)
            {
                JugadorAliado.CampoTrampasInvocacion.InsertarTra(aux->getTrampa());
                JugadorAliado.ManoTrampasInvocacion.Eliminar(aux->getTrampa());
            }
            else
            {
                NodoTrampaAtaque* aux2 = JugadorAliado.ManoTrampasAtaque.cabeza;
                while (aux2 != null)
                {
                    if (aux2->getTrampa().getNombre() == NombreTrampa)
                    {
                        break;
                    }
                    aux2 = aux2->getSiguiente();
                }
                JugadorAliado.CampoTrampasAtaque.InsertarTr(aux2->getTrampa());
                JugadorAliado.ManoTrampasAtaque.Eliminar(aux2->getTrampa());

            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private unsafe void botonInvocar_Click(object sender, EventArgs e)
        {
            if (comboBoxMano.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carta de la mano");
                return;
            }
            if (TurnoJugador == 1)
            {
                if (Jugador1.CampoMonstruos.getTamano() >= 5)
                {
                    MessageBox.Show("Campo de Monstruos lleno");
                    return;
                }
                InvocarMonstruo(Jugador1, Jugador2, comboBoxMano.SelectedItem.ToString());
                ActualizarFase(Jugador1, Jugador2);
            }
            else
            {
                if (Jugador2.CampoMonstruos.getTamano() >= 5)
                {
                    MessageBox.Show("Campo de Monstruos lleno");
                    return;
                }
                InvocarMonstruo(Jugador2, Jugador1, comboBoxMano.SelectedItem.ToString());
                ActualizarFase(Jugador2, Jugador1);
            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxMano.SelectedIndex = -1;
        }

        private unsafe void botonEliminarMounstro_Click(object sender, EventArgs e)
        {
            if (comboBoxMano.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un monstruo del campo");
                return;
            }

            Nodo* aux = null;
            if (TurnoJugador == 1)
            {
                aux = Jugador1.ManoMonstruos.cabeza;
            }
            else
            {
                aux = Jugador2.ManoMonstruos.cabeza;
            }

            if (aux == null)
            {
                MessageBox.Show("No hay monstruos en el campo");
                return;
            }

            while (aux != null && aux->getMonstruo().getNombre() != comboBoxMano.SelectedItem.ToString())
            {
                aux = aux->getSiguiente();
            }

            if (aux == null)
            {
                MessageBox.Show("Monstruo no encontrado");
                return;
            }

            if (TurnoJugador == 1)
            {
                Jugador1.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                Jugador1.ManoMonstruos.Eliminar(aux->getMonstruo());
                ActualizarFase(Jugador1, Jugador2);
            }
            else
            {
                Jugador2.Cementerio.CementerioMonstruos.Insertar(aux->getMonstruo());
                Jugador2.ManoMonstruos.Eliminar(aux->getMonstruo());
                ActualizarFase(Jugador2, Jugador1);

            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxMano.SelectedIndex = -1;
        }

        private unsafe void botonActivarHechizo_Click(object sender, EventArgs e)
        {
            if (comboBoxManoHechizo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un hechizo de la mano");
                return;
            }
            if (TurnoJugador == 1)
            {
                NodoHechizos* aux = Jugador1.ManoHechizos.cabeza;
                while (aux->getHechizo().getNombre() != comboBoxManoHechizo.SelectedItem.ToString())
                {
                    aux = aux->getSiguiente();
                }
                UsarHechizo(Jugador1, Jugador2, comboBoxManoHechizo.SelectedItem.ToString());
                AsignarImagenes();
                cargarImagenes();
                ActualizarFase(Jugador1, Jugador2);
                comboBoxManoHechizo.SelectedIndex = -1;
            }
            else
            {
                NodoHechizos* aux = Jugador2.ManoHechizos.cabeza;
                while (aux != null)
                {
                    if (aux->getHechizo().getNombre() == comboBoxManoHechizo.SelectedItem.ToString())
                    {
                        break;
                    }
                    aux = aux->getSiguiente();
                }
                UsarHechizo(Jugador2, Jugador1, comboBoxManoHechizo.SelectedItem.ToString());
                AsignarImagenes();
                cargarImagenes();
                ActualizarFase(Jugador2, Jugador1);
                comboBoxManoHechizo.SelectedIndex = -1;
            }
        }

        private void J1Mano1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano1.Image;
        }

        private void J1Mano2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano2.Image;
        }

        private unsafe void botonEliminarHechizo_Click(object sender, EventArgs e)
        {
            if (comboBoxManoHechizo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un monstruo del campo");
                return;
            }
            if (TurnoJugador == 1)
            {
                NodoHechizos* aux = Jugador1.ManoHechizos.cabeza;
                while (aux != null)
                {
                    if (aux->getHechizo().getNombre().Equals(comboBoxManoHechizo.SelectedItem.ToString()))
                    {
                        break;
                    }
                    aux = aux->getSiguiente();
                }
                Jugador1.Cementerio.CementerioHechizos.Insertar(aux->getHechizo());
                Jugador1.ManoHechizos.Eliminar(aux->getHechizo());
                ActualizarFase(Jugador1, Jugador2);
            }
            else
            {
                NodoHechizos* aux = Jugador2.ManoHechizos.cabeza;
                while (aux != null)
                {
                    if (aux->getHechizo().getNombre().Equals(comboBoxManoHechizo.SelectedItem.ToString()))
                    {
                        break;
                    }
                    aux = aux->getSiguiente();
                }
            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxManoHechizo.SelectedIndex = -1;
        }

        private void botonColocarTra_Click(object sender, EventArgs e)
        {
            if (comboBoxManoTra.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una trampa de la mano");
                return;
            }
            if (TurnoJugador == 1)
            {
                if (Jugador1.CampoTrampasAtaque.getTamano() + Jugador1.CampoTrampasInvocacion.getTamano() < 5)
                {
                    DesplegarTrampa(Jugador1, Jugador2, comboBoxManoTra.SelectedItem.ToString());
                    ActualizarFase(Jugador1, Jugador2);
                }
                else
                {
                    MessageBox.Show("Campo de trampas lleno");
                }
            }
            else
            {
                if (Jugador2.CampoTrampasAtaque.getTamano() + Jugador2.CampoTrampasInvocacion.getTamano() < 5)
                {
                    DesplegarTrampa(Jugador2, Jugador1, comboBoxManoTra.SelectedItem.ToString());
                    ActualizarFase(Jugador2, Jugador1);
                }
                else
                {
                    MessageBox.Show("Campo de trampas lleno");
                }
            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxManoTra.SelectedIndex = -1;
        }

        private void BotonCambiarFase_Click(object sender, EventArgs e)
        {
            if (TipoFase == 1)
            {
                TipoFase = 2;
                if (TurnoJugador == 1)
                {
                    ActualizarFase(Jugador1, Jugador2);
                }
                else
                {
                    ActualizarFase(Jugador2, Jugador1);
                }
            }
            else if (TipoFase == 2)
            {
                TipoFase = 3;
                if (TurnoJugador == 1)
                {
                    ActualizarFase(Jugador1, Jugador2);
                }
                else
                {
                    ActualizarFase(Jugador2, Jugador1);
                }
            }
            else
            {
                TipoFase = 1;
                if (TurnoJugador == 1)
                {
                    TurnoJugador = 2;
                    labelJugadorTurno.Text = "Jugador 2";
                    Jugador2.RobarCarta();
                    ActualizarFase(Jugador2, Jugador1);
                    AsignarImagenes();
                    cargarImagenes();
                }
                else
                {
                    labelJugadorTurno.Text = "Jugador 1";
                    TurnoJugador = 1;
                    Jugador1.RobarCarta();
                    ActualizarFase(Jugador1, Jugador2);
                    AsignarImagenes();
                    cargarImagenes();
                }
            }

        }




        //cositas del front
        private void button1_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarform);
        }

        private void J1Mano3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano3.Image;
            ImagenVacia();
        }

        private void J1Mano4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano4.Image;
            ImagenVacia();
        }

        private void J1Mano5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano5.Image;
            ImagenVacia();
        }

        private void J1Mano6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1Mano6.Image;
            ImagenVacia();
        }

        private void J1CampTra1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampTra1.Image;
            ImagenVacia();
        }

        private void J1CampTra2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampTra2.Image;
            ImagenVacia();
        }

        private void J1CampTra3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampTra3.Image;
            ImagenVacia();
        }

        private void J1CampTra4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampTra4.Image;
            ImagenVacia();
        }

        private void J1CampTra5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampTra5.Image;
            ImagenVacia();
        }

        private void J1CampMons1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampMons1.Image;
            ImagenVacia();
        }

        private void J1CampMons2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampMons2.Image;
            ImagenVacia();
        }

        private void J1CampMons3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampMons3.Image;
            ImagenVacia();
        }

        private void J1CampMons4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampMons4.Image;
            ImagenVacia();
        }

        private void J1CampMons5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J1CampMons5.Image;
            ImagenVacia();
        }

        private void J2CampMons1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampMons1.Image;
            ImagenVacia();
        }

        private void J2CampMons2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampMons2.Image;
            ImagenVacia();
        }

        private void J2CampMons3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampMons3.Image;
            ImagenVacia();
        }

        private void J2CampMons4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampMons4.Image;
            ImagenVacia();
        }

        private void J2CampMons5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampMons1.Image;
            ImagenVacia();
        }

        private void J2CampTra1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampTra1.Image;
            ImagenVacia();
        }

        private void J2CampTra2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampTra2.Image;
            ImagenVacia();
        }

        private void J2CampTra3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampTra3.Image;
            ImagenVacia();
        }

        private void J2CampTra4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampTra4.Image;
            ImagenVacia();
        }

        private void J2CampTra5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2CampTra5.Image;
            ImagenVacia();
        }

        private void J2Mano1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano1.Image;
            ImagenVacia();
        }

        private void J2Mano2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano2.Image;
            ImagenVacia();
        }

        private void J2Mano3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano3.Image;
            ImagenVacia();
        }

        private void J2Mano4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano4.Image;
            ImagenVacia();
        }

        private void J2Mano5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano5.Image;
            ImagenVacia();
        }

        private void J2Mano6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = J2Mano6.Image;
            ImagenVacia();
        }

        private unsafe void botonCambiarModo_Click(object sender, EventArgs e)
        {
            if (comboBoxCampoAliado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un monstruo del campo");
                return;
            }
            if (TurnoJugador == 1)
            {
                int contador = 0;
                Nodo* aux = Jugador1.CampoMonstruos.cabeza;
                while (aux->getMonstruo().getNombre() != comboBoxCampoAliado.SelectedItem.ToString())
                {
                    aux = aux->getSiguiente();
                    contador++;
                }
                aux->getMonstruo().cambiarModo();
                if (contador == 0)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J1CampMons1Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J1CampMons1Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 1)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J1CampMons2Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J1CampMons2Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 2)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J1CampMons3Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J1CampMons3Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 3)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J1CampMons4Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J1CampMons4Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 4)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J1CampMons5Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J1CampMons5Mod.BackColor = Color.Gray;
                    }
                }
            }
            else
            {
                int contador = 0;
                Nodo* aux = Jugador2.CampoMonstruos.cabeza;
                while (aux->getMonstruo().getNombre() != comboBoxCampoAliado.SelectedItem.ToString())
                {
                    aux = aux->getSiguiente();
                    contador++;
                }
                aux->getMonstruo().cambiarModo();
                if (contador == 0)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J2CampMons1Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J2CampMons1Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 1)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J2CampMons2Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J2CampMons2Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 2)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J2CampMons3Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J2CampMons3Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 3)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J2CampMons4Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J2CampMons4Mod.BackColor = Color.Gray;
                    }
                }
                else if (contador == 4)
                {
                    if (aux->getMonstruo().getModo() == true)
                    {
                        J2CampMons5Mod.BackColor = Color.Red;
                    }
                    else
                    {
                        J2CampMons5Mod.BackColor = Color.Gray;
                    }
                }
            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxMano.SelectedIndex = -1;
        }

        private unsafe void J1CampMons1_MouseHover(object sender, EventArgs e)
        {
            //if (J1CampMons1.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J1CampMons1, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J1CampMons1.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J1CampMons1, $"Nombre: {aux.getNombre()} \nATK: {aux.getAtaque()} \nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J1CampMons2_MouseHover(object sender, EventArgs e)
        {
            //if (J1CampMons2.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J1CampMons2, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J1CampMons2.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J1CampMons2, $"Nombre: {aux.getNombre()} \nATK: {aux.getAtaque()} \nDEF: {aux.getDefensa()}");
            //}
        }
        public unsafe Monstruos BuscarMonsPorImg(Image Imagen, ListaMonstruos ListaBuscar)
        {
            Nodo* aux = ListaBuscar.cabeza;
            while (aux != null)
            {
                if ((aux->getMonstruo().getDireccion() == Imagen))
                {
                    break;
                }
                aux = aux->getSiguiente();
            }
            return aux->getMonstruo();
        }
        private unsafe void J1CampMons3_MouseHover(object sender, EventArgs e)
        {
            //if (J1CampMons3.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J1CampMons3, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J1CampMons3.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J1CampMons3, $"Nombre: {aux.getNombre()} \nATK: {aux.getAtaque()} \nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J1CampMons4_MouseHover(object sender, EventArgs e)
        {
            //if (J1CampMons4.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J1CampMons4, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J1CampMons4.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J1CampMons4, $"Nombre: {aux.getNombre()} \nATK: {aux.getAtaque()} \nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J1CampMons5_MouseHover(object sender, EventArgs e)
        {
            //if (J1CampMons5.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J1CampMons5, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J1CampMons5.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J1CampMons5,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J2CampMons1_MouseHover(object sender, EventArgs e)
        {
            //if (J2CampMons1.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J2CampMons1, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J2CampMons1.Image, Jugador2.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J2CampMons1,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J2CampMons2_MouseHover(object sender, EventArgs e)
        {
            //if (J2CampMons2.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J2CampMons2, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J2CampMons2.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J2CampMons2,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J2CampMons3_MouseHover(object sender, EventArgs e)
        {
            //if (J2CampMons3.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J2CampMons3, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J2CampMons3.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J2CampMons3,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J2CampMons4_MouseHover(object sender, EventArgs e)
        {
            //if (J2CampMons4.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J2CampMons4, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J2CampMons4.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J2CampMons4,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private unsafe void J2CampMons5_MouseHover(object sender, EventArgs e)
        {
            //if (J2CampMons5.Image == null)
            //{
            //    this.toolTipDato.SetToolTip(this.J2CampMons5, "No Mostro");
            //}
            //else
            //{
            //    Monstruos aux = BuscarMonsPorImg(J2CampMons5.Image, Jugador1.CampoMonstruos);

            //    this.toolTipDato.SetToolTip(this.J2CampMons5,
            //        $"Nombre: {aux.getNombre()} " +
            //        $"\nATK: {aux.getAtaque()} " +
            //        $"\nDEF: {aux.getDefensa()}");
            //}
        }

        private void botonEliminarTra_Click(object sender, EventArgs e)
        {
            if (comboBoxManoTra.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una trampa de la mano");
                return;
            }
            if (TurnoJugador == 1)
            {
                EliminarTrampa(Jugador1, comboBoxManoTra.SelectedItem.ToString());

                ActualizarFase(Jugador1, Jugador2);
            }
            else
            {
                EliminarTrampa(Jugador2, comboBoxManoTra.SelectedItem.ToString());
                ActualizarFase(Jugador2, Jugador1);
            }
            AsignarImagenes();
            cargarImagenes();
            comboBoxManoTra.SelectedIndex = -1;
        }

        private void botonAtacar_Click(object sender, EventArgs e)
        {

            if (comboBoxDefensor.Items.Count == 0 && comboBoxAtacante.SelectedIndex != -1)
            {
                if (TurnoJugador == 1)
                {
                    if (Jugador2.Vida - Jugador1.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString()).getAtaque() <= 0)
                    {
                        Jugador2.Vida = 0;
                    }
                    else
                    {
                        Jugador2.Vida = Jugador2.Vida - Jugador1.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString()).getAtaque();
                    }
                    comboBoxAtacante.Items.RemoveAt(comboBoxAtacante.SelectedIndex);
                    return;
                }
                else
                {
                    if (Jugador1.Vida - Jugador2.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString()).getAtaque() <= 0)
                    {
                        Jugador1.Vida = 0;
                    }
                    else
                    {
                        Jugador1.Vida = Jugador1.Vida - Jugador2.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString()).getAtaque();
                    }
                    comboBoxAtacante.Items.RemoveAt(comboBoxAtacante.SelectedIndex);
                    return;
                }
            }
            else if (comboBoxAtacante.SelectedIndex == -1 || comboBoxDefensor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Monstruo Atacante Y Defensor");
                return;
            }


            if (TurnoJugador == 1)
            {
                Monstruos MonstruoAtacante = Jugador1.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString());
                Monstruos MonstruoDefensor = Jugador2.CampoMonstruos.BuscarMonstruo(comboBoxDefensor.SelectedItem.ToString());
                if (MonstruoAtacante.getSalud() > MonstruoDefensor.getSalud())
                {
                    Jugador2.CampoMonstruos.Eliminar(MonstruoDefensor);
                    Jugador2.Cementerio.CementerioMonstruos.Insertar(MonstruoDefensor);
                    if (MonstruoDefensor.getNombre() == "Ladron Fantasma")
                    {
                        Jugador2.RobarCarta();
                    }
                    if (MonstruoDefensor.getModo() == true)
                    {
                        Jugador2.Vida = Jugador2.Vida - (MonstruoAtacante.getSalud() - MonstruoDefensor.getSalud());
                    }
                    comboBoxAtacante.Items.RemoveAt(comboBoxAtacante.SelectedIndex);
                    MonstruoAtacante.EfectoAtaque(Jugador1.CampoMonstruos, Jugador2.CampoMonstruos, Jugador1.Cementerio.CementerioMonstruos, Jugador2.Cementerio.CementerioMonstruos, MonstruoDefensor);
                    AsignarImagenes();
                    cargarImagenes();
                }
                else if (MonstruoAtacante.getSalud() < MonstruoDefensor.getSalud())
                {
                    Jugador1.CampoMonstruos.Eliminar(MonstruoAtacante);
                    Jugador1.Cementerio.CementerioMonstruos.Equals(MonstruoAtacante);
                    AsignarImagenes();
                    cargarImagenes();
                    if (MonstruoAtacante.getNombre() == "Ladron Fantasma")
                    {
                        Jugador1.RobarCarta();
                    }
                }
                else
                {
                    Jugador1.CampoMonstruos.Eliminar(MonstruoAtacante);
                    Jugador1.Cementerio.CementerioMonstruos.Equals(MonstruoAtacante);
                    Jugador2.CampoMonstruos.Eliminar(MonstruoDefensor);
                    Jugador2.Cementerio.CementerioMonstruos.Insertar(MonstruoDefensor);
                    AsignarImagenes();
                    cargarImagenes();
                    if (MonstruoAtacante.getNombre() == "Ladron Fantasma")
                    {
                        Jugador1.RobarCarta();
                    }
                    if (MonstruoDefensor.getNombre() == "Ladron Fantasma")
                    {
                        Jugador2.RobarCarta();
                    }
                }
                ActualizarFase(Jugador1, Jugador2);
            }
            else
            {
                Monstruos MonstruoAtacante = Jugador2.CampoMonstruos.BuscarMonstruo(comboBoxAtacante.SelectedItem.ToString());
                Monstruos MonstruoDefensor = Jugador1.CampoMonstruos.BuscarMonstruo(comboBoxDefensor.SelectedItem.ToString());
                if (MonstruoAtacante.getSalud() > MonstruoDefensor.getSalud())
                {
                    Jugador1.CampoMonstruos.Eliminar(MonstruoDefensor);
                    Jugador1.Cementerio.CementerioMonstruos.Insertar(MonstruoDefensor);
                    if (MonstruoDefensor.getModo() == true)
                    {
                        Jugador1.Vida = Jugador1.Vida - (MonstruoAtacante.getSalud() - MonstruoDefensor.getSalud());
                    }
                    if (MonstruoDefensor.getNombre() == "Ladron Fantasma")
                    {
                        Jugador1.RobarCarta();
                    }
                    comboBoxAtacante.Items.RemoveAt(comboBoxAtacante.SelectedIndex);
                    MonstruoAtacante.EfectoAtaque(Jugador2.CampoMonstruos, Jugador1.CampoMonstruos, Jugador2.Cementerio.CementerioMonstruos, Jugador1.Cementerio.CementerioMonstruos, MonstruoDefensor);
                    AsignarImagenes();
                    cargarImagenes();
                }
                else if (MonstruoAtacante.getSalud() < MonstruoDefensor.getSalud())
                {
                    Jugador2.CampoMonstruos.Eliminar(MonstruoAtacante);
                    Jugador2.Cementerio.CementerioMonstruos.Equals(MonstruoAtacante);
                    if (MonstruoAtacante.getNombre() == "Ladron Fantasma")
                    {
                        Jugador2.RobarCarta();
                    }
                    AsignarImagenes();
                    cargarImagenes();
                }
                else
                {
                    Jugador2.CampoMonstruos.Eliminar(MonstruoAtacante);
                    Jugador2.Cementerio.CementerioMonstruos.Equals(MonstruoAtacante);
                    Jugador1.CampoMonstruos.Eliminar(MonstruoDefensor);
                    Jugador1.Cementerio.CementerioMonstruos.Insertar(MonstruoDefensor);
                    AsignarImagenes();
                    cargarImagenes();
                    if (MonstruoAtacante.getNombre() == "Ladron Fantasma")
                    {
                        Jugador2.RobarCarta();
                    }
                    if (MonstruoDefensor.getNombre() == "Ladron Fantasma")
                    {
                        Jugador1.RobarCarta();
                    }
                }
                ActualizarFase(Jugador2, Jugador1);
            }

        }

        private void actualizacionVida_Tick(object sender, EventArgs e)
        {
            BarraVidaJ1.Value = Jugador1.Vida;
            BarraVidaJ2.Value = Jugador2.Vida;
            if (Jugador1.Vida <= 0)
            {
                actualizacionVida.Stop();
                MessageBox.Show("Jugador 2 Gana");
                this.Close();
            }
            if (Jugador2.Vida <= 0)
            {
                actualizacionVida.Stop();
                MessageBox.Show("Jugador 1 Gana");
                this.Close();
            }
        }
    }
}
