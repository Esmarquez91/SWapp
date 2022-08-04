using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SWapp.Clases;


namespace SWapp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            
            InitializeComponent();
            DiseñoForm.RedondearForm(this);
            Files.ObtenerDirecciones();
            BaseDeDatos.connSTr = Files.AccesoBD;
        }
        

        //Movimiento de la ventana con el panel1
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e){ _dragging = true;_start_point = new Point(e.X, e.Y);}
        private void panel1_MouseUp(object sender, MouseEventArgs e){_dragging = false;}
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((_dragging)&&!(this.WindowState == FormWindowState.Maximized))
            {Point p = PointToScreen(e.Location);Location = new Point(p.X - _start_point.X, p.Y - _start_point.Y);}
            else if((_dragging) && (this.WindowState == FormWindowState.Maximized))
            {this.WindowState = FormWindowState.Normal; DiseñoForm.RedondearForm(this); _start_point.X = (_start_point.X / 2); }
        }
        
        //---------------------------------------------//

        //Botones de control de la aplicación:
        private void Minimizar_Click(object sender, EventArgs e){this.WindowState = FormWindowState.Minimized;}
        private void Maximizar_Click(object sender, EventArgs e){if(this.WindowState == FormWindowState.Maximized){this.WindowState = FormWindowState.Normal;}else{this.WindowState = FormWindowState.Maximized; } DiseñoForm.RedondearForm(this); }
        private void Cerrar_Click(object sender, EventArgs e){this.Close();}
        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e){{ if (this.WindowState == FormWindowState.Maximized) { this.WindowState = FormWindowState.Normal; } else { this.WindowState = FormWindowState.Maximized;} } DiseñoForm.RedondearForm(this); }
        //---------------------------------------------//
        private void BtnCircuitosBL_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtBoxSWid.Text.Length > 1)
                {
                    PlaceHolders();
                    
                    TxtBoxTicketId.Text =  TxtBoxSWid.Text;
                    //TLpanelPrincipal.SetColumnSpan(DataGridCircuitos, 13);

                    Files.ObtenerDirecciones();
                    Files.ConvertirXLSXtoCSV();
                    Files.ImportarArchivoCSV();
                    Files.EnviarArchivoFinal(TxtBoxSWid.Text);
                    DataGridCircuitos.RowHeadersVisible = false;
                    DataGridCircuitos.DataSource = Files.ss;
                    DataGridCircuitos.AllowUserToAddRows = false;
                    Files.DeleteArchives();
                    Files.dt.Rows.Clear();
                    Files.dt.Clear();
                    Funciones.CopiarDataGrid(DataGridCircuitos);
                    TxtBoxSWid.Text = "";
                    LabelCountCircuits.Text = "Resultados: " + DataGridCircuitos.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Llenar PlannedWork Id");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());

            }
        }
        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Funciones.CopiarDataGrid(DataGridCircuitos);
        }
        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridCircuitos.DataSource = null;
                DataGridCircuitos.Rows.Clear();
                Files.dt.Rows.Clear();
                Files.dt.Clear();
                Files.ObtenerDirecciones();
                Files.ConvertirXLSXtoCSV();
                Files.ImportarArchivoCSV2();
                DataGridCircuitos.RowHeadersVisible = false;
                DataGridCircuitos.DataSource = Files.dt;
                DataGridCircuitos.AllowUserToAddRows = false;
                Files.dtcliente.Clear();
                Files.dtcliente = Files.dt;
                LabelCountCircuits.Text = "Resultados: " + DataGridCircuitos.Rows.Count.ToString();
            }
            catch (Exception ErrorImport)
            {
                MessageBox.Show("ErrorImport:\n\r-Falta Generar el Archivo del Conversor CRT -> CRM \n" + ErrorImport.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            PlaceHolders();
        }

        private void PlaceHolders()
        {
            foreach (Control c in TLpanelPrincipal.Controls)
            {
                if (c is TextBox) { c.Text = ""; }
            }

            TextBoxLocation.BackColor = Color.White;
            DataGridCircuitos.DataSource = null;
            DataGridCorreos.DataSource = null;
            DataGridCircuitos.Rows.Clear();
            DataGridCorreos.Rows.Clear();
            Files.dt.Clear();
            Files.dtcliente.Clear();

            progressBar1.Visible = false;
            LabelEstado.Visible = false;

            TxtBoxTicketId.Text = "Ticket";
            TxtBoxTicketId.ForeColor = Color.Gray;
            TxtBoxTicketId.GotFocus += TxtBoxTicketId_GotFocus;
            TxtBoxTicketId.LostFocus += TxtBoxTicketId_LostFocus;

            TextBoxDescripcion.Text = "Description";
            TextBoxDescripcion.ForeColor = Color.Gray;
            TextBoxDescripcion.GotFocus += TextBoxDescripcion_GotFocus;
            TextBoxDescripcion.LostFocus += TextBoxDescripcion_LostFocus;

            TextBoxImpacTime.Text = "Impact Time";
            TextBoxImpacTime.ForeColor = Color.Gray;
            TextBoxImpacTime.GotFocus += TextBoxImpacTime_GotFocus;
            TextBoxImpacTime.LostFocus += TextBoxImpacTime_LostFocus;

            TextBoxLocation.Text = "Location";
            TextBoxLocation.ForeColor = Color.Gray;
            TextBoxLocation.GotFocus += TextBoxLocation_GotFocus;
            TextBoxLocation.LostFocus += TextBoxLocation_LostFocus;

            TextBoxSchedule.Text = "Schedule";
            TextBoxSchedule.ForeColor = Color.Gray;
            TextBoxSchedule.GotFocus += TextBoxSchedule_GotFocus;
            TextBoxSchedule.LostFocus += TextBoxSchedule_LostFocus;

            TextBoxScheduleUpdate.Text = "Update Schedule";
            TextBoxScheduleUpdate.ForeColor = Color.Gray;
        }

        private void BtnCorreos_Click(object sender, EventArgs e)
        {
            try
            {
                DataView vista2 = new DataView(Files.dtcliente);
                Files.dtcliente = vista2.ToTable(true, "CRM Number", "CRM Name", "CRT", "IP Service Identifier", "Protection Type C", "Circuit Category");
                
                DataGridCircuitos.DataSource = Files.dtcliente;
                
            }
            catch
            {
                MessageBox.Show("Error: Falta obtener tabla de circuitos");
            }

            DataGridCorreos.RowHeadersVisible = false;
            DataGridCorreos.DataSource = Funciones.RecibirCorreo();
            DataGridCorreos.Columns["Subject"].Width = 320;
            DataGridCorreos.Columns["Sender"].Width = 100;
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            string ayudaTXT = SWapp.Properties.Resources.Ayuda;
            MessageBox.Show(ayudaTXT);
        }

        private void DataGridCorreos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DataGridCorreos.Rows.Count))
            {
                WebCorreo.DocumentText = Funciones.Be.Rows[e.RowIndex]["Body"].ToString();

            }
        }

        private void WebCorreo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.TxtBoxCorreo.Lines = Files.StripHTML(this.WebCorreo.DocumentText.ToString()).Split("\r".ToCharArray());
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            string webline2 = "";
            foreach(Control t in this.TLpanelPrincipal.Controls)
            {
                if(t is TextBox) { (t as TextBox).ForeColor = Color.Black; }
            }
            foreach (string webline in TxtBoxCorreo.Lines)
            {
                if (webline.Split('/')[0].TrimEnd(null) == "NOTIFICATION NUMBER")
                {
                    webline2 = webline.Split(':')[1].TrimStart(null).TrimEnd(null); 
                    TxtBoxTicketId.Text = webline2;
                }
                else if (webline.Split('/')[0].TrimEnd(null) == "NOTIFICATION TYPE")
                {
                    webline2 = webline.Split(':')[1].TrimStart(null).TrimEnd(null);
                    if (webline2 == "Normal") { ComboBoxTipo.Text = "Normal"; }
                    else { ComboBoxTipo.Text = "Emergency // Emergencia"; }
                }
                else if (webline.Split(' ')[0] == "DESCRIPTION")
                {
                    TextBoxDescripcion.Text = webline.Split(':')[1];
                }
                else if (webline.Split(' ')[0] == "SERVICE")
                {
                    webline2 = webline.Split(':')[1].TrimStart(null);

                    if ((webline2.Split(' ')[2] == "SWITCH") || (webline2.Split(' ')[1] == "SWITCH"))
                    {
                        ComboBoxImpacto.SelectedIndex = 1;
                        TextBoxImpacTime.Text = webline2.Substring(0, 2);
                    }
                    else if ((webline2.Split(' ')[0] == "OUTAGE") && (webline2.Split(' ')[4] == "MIN"))
                    {
                        ComboBoxImpacto.SelectedIndex = 0;
                        TextBoxImpacTime.Text = webline2.Split(' ')[3];
                    }
                    else if ((webline2.Split(' ')[0] == "PROTECTION") && (webline2.Split(' ')[5] == "MIN"))
                    {
                        ComboBoxImpacto.SelectedIndex = 2;
                        TextBoxImpacTime.Text = webline2.Split(' ')[4];
                    }
                    else
                    {
                        ComboBoxImpacto.SelectedIndex = 3;
                        TextBoxImpacTime.Text = webline.Split(':')[1];
                    }
                }
                else if (webline.Split(' ')[0] == "LOCATION")
                {
                    TextBoxLocation.Text = webline.Split(':')[1];
                }
                else if (webline.Split('-').Count() == 6)
                {
                    if (webline.Length < 35) { TextBoxSchedule.Text = webline.Substring(0, 11) + " " + webline.Substring(11, 5) + " " + webline.Substring(16, 1) + " " + webline.Substring(17, 11) + " " + webline.Substring(28,5); }
                    else { TextBoxSchedule.Text = webline.Substring(0, 12) + " " + webline.Substring(12, 5) + " " + webline.Substring(17, 1) + " " + webline.Substring(18, 12) + " " + webline.Substring(30, 5);}

                    //TextBoxSchedule.Text = webline.Substring(0, 11) + " " + webline.Substring(11, 5) + " " + webline.Substring(16, 1) + " " + webline.Substring(17, 11) + " " + webline.Substring(28, 5);

                    break;
                }
            }

        }

        int IngresarCliente;
        string Impacto;
        string tiponotif;
        int Mapfre = 0;
        int DirectTV = 0;
        private void BtnNotificar_Click(object sender, EventArgs e)
        {
            DataTable CircuitosMultiLine = new DataTable();
            DataColumn ColumnCliente = new DataColumn("Cliente");
            DataColumn ColumnCRT = new DataColumn("CRT");
            CircuitosMultiLine.Columns.Add(ColumnCliente);
            CircuitosMultiLine.Columns.Add(ColumnCRT);
            string[] linea;
            string cCID = "";
            IngresarCliente = 0;
            string ccliente = "";
            string clientefinal = "";
            string Asunto;
            string Descript;
            string TablaCircuitos;
            string Localidad;
            Impacto = "";
            string TicketID;
            string Horario;
            //string tiponotif;

            //Validar si hay datos:
            if (TextBoxDescripcion.Text.Length <= 2 || TxtBoxTicketId.Text.Length <= 2 || TextBoxImpacTime.Text.Length < 1 || TextBoxLocation.Text.Length <= 1 || ComboBoxTipo.Text.Length <= 2 || TxtBoxCorreo.Text.Length <= 2 ||ComboBoxImpacto.Text.Length<1)
            {
                MessageBox.Show("Datos imcompletos");
            }
            else if(TextBoxSchedule.Text.Length >= 2 || TextBoxScheduleUpdate.Text.Length >= 2)
            {
                //Se inicia el análisis de freezing:
                string U = "";
                if (CheckBoxUpdate.Checked == true) { U = "Update"; }
                else { U = "Normal"; }
                BaseDeDatos.TablaFreeze(U, TextBoxSchedule, TextBoxScheduleUpdate);
                //---------------------------------------------//

                //Se revisa si es Multple Customer o se debe buscar internamente el nombre de Cliente.
                int DetectClienteUnico = 0;
                string FullNameCliente = "Cliente";
                foreach (string line in TxtBoxCorreo.Lines)
                {
                    try
                    {
                        if(line.Split(' ')[0] == "Dear")
                        {
                            DetectClienteUnico = DetectClienteUnico + 1;
                        }
                        else if (DetectClienteUnico == 1)
                        {
                            DetectClienteUnico = DetectClienteUnico + 1;
                        }
                        else if (DetectClienteUnico == 2)
                        {
                            FullNameCliente = Files.GetClientFullName(line.TrimEnd(null));
                            DetectClienteUnico = 0;
                        }


                            if (line.Length > 10)
                        {
                            linea = line.Split(':');

                            if (linea.Length > 1)
                            {
                                if ((linea[0] == "Circuitname") && (linea[1].TrimStart(null).Split('-')[0] == "CRT"))
                                {
                                    cCID = linea[1].TrimStart(null).Split(null)[0];
                                    if (IngresarCliente == 0) //SOLO REALIZAR UNA VEZ.
                                    {
                                        ccliente = FullNameCliente;
                                        if (ccliente == "CHINA UNICOM AMERICAS" || ccliente == "CHINA UNICOM GLOBAL") { ccliente = "CHINA UNICOM"; }
                                        else if (ccliente == "CHINA TELECOM AMERICAS") { ccliente = "CHINA TELECOM"; }
                                        else if(ccliente=="TIWS USA") { ccliente = "TELEFÓNICA USA INC"; }
                                        else if (ccliente == "EQUINIX GLOBAL") { ccliente = "EQUINIX"; }
                                        IngresarCliente = 1;
                                    }
                                    DataRow ClienteCRT = CircuitosMultiLine.NewRow();
                                    ClienteCRT["Cliente"] = ccliente;
                                    ClienteCRT["CRT"] = cCID;
                                    CircuitosMultiLine.Rows.Add(ClienteCRT);
                                }
                                else if (linea[1].TrimStart(null).Split('-')[0] == "CRT")
                                {
                                    ccliente = linea[0].TrimEnd(null);
                                    if (ccliente == "CHINA UNICOM AMERICAS" || ccliente =="CHINA UNICOM GLOBAL") { ccliente = "CHINA UNICOM"; }
                                    else if (ccliente == "CHINA TELECOM AMERICAS") { ccliente = "CHINA TELECOM"; }
                                    else if (ccliente == "TIWS USA") { ccliente = "TELEFÓNICA USA INC"; }
                                    else if (ccliente == "EQUINIX GLOBAL") { ccliente = "EQUINIX"; }
                                    cCID = linea[1].TrimStart(null).Split(null)[0];
                                    DataRow ClienteCRT = CircuitosMultiLine.NewRow();
                                    ClienteCRT["Cliente"] = ccliente;
                                    ClienteCRT["CRT"] = cCID;
                                    CircuitosMultiLine.Rows.Add(ClienteCRT);
                                }
                            }
                        }
                    }
                    catch (Exception Evento01)
                    {
                        MessageBox.Show("Evento01:\n\r- En una de las lineas no hay CRT's\n" + Evento01.Message);
                    }
                }
                //---------------------------------------------------------------------------------//
                //Detectar el Circuit Category de cada Circuito:
                string cliente = "";
                string CID = "";
                string CircuitCategory = "";
                try
                {
                    foreach (DataRow cid2 in CircuitosMultiLine.Rows)
                    {
                        cliente = cid2["Cliente"].ToString();
                        CID = cid2["CRT"].ToString();
                        try
                        {
                            CircuitCategory = Files.dtcliente.Select("CRT = '" + CID + "'", "CRT")[0][5].ToString();
                            if (CircuitCategory == "IP")
                            {
                                cid2["Cliente"] = "TIWS SL";
                            }
                            else if (((CircuitCategory == "CIRCUITO CAPACIDAD") || (CircuitCategory == "CXC") || (CircuitCategory == "DCN") || (CircuitCategory == "NNI")) && (cliente == "TELXIUS CABLE"))
                            {
                                cid2["Cliente"] = "CM ONNET";
                            }
                            else if ((CircuitCategory == "TRONCAL") && (cliente == "TELXIUS CABLE"))
                            {
                                cid2["Cliente"] = "TIWS SL";
                            }
                            else if (cliente == "PLANIFICACIÓN DE RED - USO INTERNO")
                            {
                                cid2["Cliente"] = "CM ONNET";
                            }
                            else if (CircuitCategory == "OSS")
                            {
                                cid2["Cliente"] = "OSS";
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch (Exception Evento02)
                {
                    MessageBox.Show("Evento02:\n\r-Error en análisis de Circuit Category\n\r" + Evento02.Message);
                }
                //----------------------------------------------------------------------------------//
                //Se ordena la tabla de Clientes/CRT:
                CircuitosMultiLine.DefaultView.Sort = "Cliente asc";
                CircuitosMultiLine = CircuitosMultiLine.DefaultView.ToTable();
                //----------------------------------------------------------------------------------//
                //Se genera tabla temporal para almacenar lista de circuitos por cliente.
                DataTable TABLACID2 = new DataTable();
                TABLACID2.Columns.Add("CRM Number", typeof(String));
                TABLACID2.Columns.Add("CRM Name", typeof(String));
                TABLACID2.Columns.Add("CRT", typeof(String));
                TABLACID2.Columns.Add("IP Service Identifier", typeof(String));
                //----------------------------------------------------------------------------------//
                
                
                
                
                //Generar Alertas por circuitos especiales:
                int numcliente2 = 0;
                string cliente2 = "";
                try
                {
                    foreach (DataRow cid2 in CircuitosMultiLine.Rows)
                    {
                        DataRow CRT2 = TABLACID2.NewRow();
                        cliente = cid2["Cliente"].ToString(); if (numcliente2 == 0) { cliente2 = cliente; numcliente2 = 1; }
                        CID = cid2["CRT"].ToString();

                        if (numcliente2 == 0) { cliente2 = cliente; numcliente2 = 1; }

                        if (((CID == "CRT-002670") || (CID == "CRT-002028") || (CID == "CRT-002025")) && (ComboBoxImpacto.Text != "PL"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Red, TxtBoxTicketId.Text + " - " + CID + " Neutrona Crítico: " + ComboBoxImpacto.Text + " - Revisar afectación y antelación");
                        }
                        else if ((CID == "CRT-005535") || (CID == "CRT-005536") || (CID == "CRT-005537") || (CID == "CRT-005538") || (CID == "CRT-005539") || (CID == "CRT-005540") || (CID == "CRT-005541") || (CID == "CRT-005542") || (CID == "CRT-006152") || (CID == "CRT-006153") || (CID == "CRT-006154") || (CID == "CRT-006155") || (CID == "CRT-006156") || (CID == "CRT-006157") || (CID == "CRT-006158") || (CID == "CRT-006159") || (CID == "CRT-006160") || (CID == "CRT-006161") || (CID == "CRT-006162") || (CID == "CRT-006163") || (CID == "CRT-006164") || (CID == "CRT-006165") || (CID == "CRT-006166") || (CID == "CRT-006167"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Blue, TxtBoxTicketId.Text + " - " + CID + " - Avisar a Leader, trabajo en el tramo submarino de FB Brusa.");
                        }
                        else if ((CID == "CRT-000967") || (CID == "CRT-003834") || (CID== "CRT-003832"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Red, TxtBoxTicketId.Text + " - " + CID + " - O3B: No notificar, circuito desactivado");
                        }
                        else if ((CID == "CRT-005112") || (CID == "CRT-002073") || (CID == "CRT-002071"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Green, TxtBoxTicketId.Text + " - El circuito: " + CID + " debe ser notificado a TUSA");
                        }
                        else if ((CID == "CRT-001216") || (CID == "CRT-001048"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Red, TxtBoxTicketId.Text + " - " + CID + " circuito crítico de TUSA, detallar impacto y copiar a Leader en notificación");
                        }
                        else if ((CID == "CRT-005985") || (CID == "CRT-005984") || (CID == "CRT-005983") || (CID == "CRT-005982") || (CID == "CRT-005981") || (CID == "CRT-006346") || (CID == "CRT-006345") || (CID == "CRT-006344") || (CID == "CRT-006343") || (CID == "CRT-005979") || (CID == "CRT-002628") || (CID == "CRT-000680") || (CID == "CRT-005975") || (CID == "CRT-005974") || (CID == "CRT-005973") || (CID == "CRT-005972") || (CID == "CRT-005657") || (CID == "CRT-006486") || (CID == "CRT-005971") || (CID == "CRT-005970") || (CID == "CRT-005969"))
                        {
                            Funciones.AlertaBoton(timer1);
                            TextBoxLocation.BackColor = Color.OrangeRed;
                            Funciones.GenerarAlerta(RichTextAlertas, Color.DarkGreen, TxtBoxTicketId.Text + " - " + CID + " - Se debe detallar la ubicación del trabajo. Consultar segmento con Cmonnet.");
                        }
                        else if (CID == "CRT-000685")
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Green, TxtBoxTicketId.Text + " - " + CID + " - circuito debe ser notificado a  cliente TELMEX USA");
                        }
                        else if ((CID == "CRT-006728")||(CID == "CRT-002451"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Green, TxtBoxTicketId.Text + " - " + CID + " - circuito debe ser notificado a  cliente Claro Chile");
                        }
                        else if ((CID == "CRT-007338") || (CID=="CRT-007339"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Green, TxtBoxTicketId.Text + " - " + CID + " - Circuitos críticos de INDITEX, avisar a Leader");
                        }
                        else if((CID== "CRT-005430") || (CID == "CRT-006109") || (CID == "CRT-003114") || (CID == "CRT-006103"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.DarkBlue, TxtBoxTicketId.Text + " - " + CID + " - Circuitos de Mapfre, se agregan correos en copia en notificación de TUSA");
                            Mapfre = 1;
                        }
                        else if ((CID == "CRT-005745") || (CID == "CRT-005746"))
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.DarkBlue, TxtBoxTicketId.Text + " - " + CID + " - Circuitos de DirectTV, se agregan correos en copia en notificación de ATT");
                            DirectTV = 1;
                        }
                        else if (CID=="CRT-001035")
                        {

                        }

                        //------------------------------------------------------------------------------------------//
                        //ANALISIS DE FREEZE Por Cicuito
                        DataRow[] rows = BaseDeDatos.dtFreeze.Select("CRT_Cliente = '" + CID + "'");
                        if (rows.Length > 0)
                        {
                            Funciones.GenerarAlerta(RichTextAlertas, Color.Blue, TxtBoxTicketId.Text + " - " + ComboBoxImpacto.Text + " - " + CID + " - circuito se encuentra en periodo de Freezing");
                        }


                        //Generar Correo de notificacion a cliente:


                        if (cliente == cliente2)
                        {
                            if (Files.dtcliente.Select("CRT = '" + CID + "'", "CRT").Length > 0)
                            {
                                CRT2 = Files.dtcliente.Select("CRT = '" + CID + "'", "CRT")[0];
                                TABLACID2.ImportRow(CRT2);
                                clientefinal = cliente2;
                            }
                            else
                            {
                                //numcliente2 = 0;
                            }
                        }
                        else if ((cliente != cliente2) && (Files.dtcliente.Select("CRT = '" + CID + "'", "CRT").Length > 0))
                        {

                            Asunto = "SCHEDULED MAINTENANCE NOTIFICATION " + TxtBoxTicketId.Text + " - " + cliente2;
                            Descript = TextBoxDescripcion.Text;
                            Localidad = TextBoxLocation.Text;
                            if (ComboBoxImpacto.Text == "O") { Impacto = "OUTAGE UP TO " + TextBoxImpacTime.Text + " MIN"; }
                            else if (ComboBoxImpacto.Text == "SH") { Impacto = TextBoxImpacTime.Text + " MS SWITCH HITS"; }
                            else if (ComboBoxImpacto.Text == "PL") { Impacto = "PROTECTION PATH NOT AVAILABLE UP TO " + TextBoxImpacTime.Text + " MIN"; }
                            else { Impacto = TextBoxImpacTime.Text; }
                            Horario = TextBoxSchedule.Text;
                            tiponotif = ComboBoxTipo.Text;
                            TicketID = TxtBoxTicketId.Text;

                            if (cliente2 != "TIWS SL") { TABLACID2.Columns.Remove("IP Service Identifier"); }
                            TablaCircuitos = Funciones.ExportDatatableToHtml(TABLACID2);
                            if (TABLACID2.Rows.Count > 0) { Funciones.EnviarEmail(cliente2, tiponotif, Asunto, CheckBoxUpdate, TablaCircuitos, TextBoxSchedule, TextBoxScheduleUpdate, TicketID, Descript, Impacto, Localidad, ComboBoxImpacto.Text, RichTextAlertas,Mapfre,DirectTV); Mapfre = 0; DirectTV = 0; }
                            if (cliente2 != "TIWS SL") { TABLACID2.Columns.Add("IP Service Identifier"); }

                            //CAMBIA DE CLIENTE
                            TABLACID2.Clear();
                            numcliente2 = 2;

                            cliente2 = cliente;
                            if (Files.dtcliente.Select("CRT = '" + cid2["CRT"].ToString() + "'", "CRT")[0] != null)
                            {
                                clientefinal = cliente2;
                            }
                            CRT2 = Files.dtcliente.Select("CRT = '" + cid2["CRT"].ToString() + "'", "CRT")[0];
                            TABLACID2.ImportRow(CRT2);
                        }

                    }


                }
                catch (Exception errorx123)
                {
                    MessageBox.Show("Errorx123:\n\r- Error en la busqueda de CRT's en la tabla\n\r-Error en las fechas ingresadas\n\r" + errorx123.Message);
                }

                try
                {
                    if (TABLACID2.Rows.Count > 0) //Notifica al ultimo cliente.
                    {
                        cliente2 = clientefinal;
                        Asunto = "SCHEDULED MAINTENANCE NOTIFICATION " + TxtBoxTicketId.Text + " - " + clientefinal; //iba cliente.
                        Descript = TextBoxDescripcion.Text;
                        Localidad = TextBoxLocation.Text;
                        if (ComboBoxImpacto.Text == "O") { Impacto = "OUTAGE UP TO " + TextBoxImpacTime.Text + " MIN"; }
                        else if (ComboBoxImpacto.Text == "SH") { Impacto = TextBoxImpacTime.Text + " MS SWITCH HITS"; }
                        else if (ComboBoxImpacto.Text == "PL") { Impacto = "PROTECTION PATH NOT AVAILABLE UP TO " + TextBoxImpacTime.Text + " MIN"; }
                        else { Impacto = TextBoxImpacTime.Text; }
                        //Impacto = IMPACT.Text;
                        Horario = TextBoxSchedule.Text;
                        tiponotif = ComboBoxTipo.Text;
                        TicketID = TxtBoxTicketId.Text;

                        if (cliente2 != "TIWS SL") { TABLACID2.Columns.Remove("IP Service Identifier"); }
                        TablaCircuitos = Funciones.ExportDatatableToHtml(TABLACID2);
                        //LabelEstado.Text = "Guardando Trabajo en BD...";
                        Funciones.EnviarEmail(cliente2, tiponotif, Asunto, CheckBoxUpdate, TablaCircuitos, TextBoxSchedule, TextBoxScheduleUpdate, TicketID, Descript, Impacto, Localidad, ComboBoxImpacto.Text, RichTextAlertas, Mapfre, DirectTV); Mapfre = 0; DirectTV = 0;
                        if (cliente2 != "TIWS SL") { TABLACID2.Columns.Add("IP Service Identifier"); }
                        MessageBox.Show("Correos Generados");
                    }
                }
                catch
                {
                    //Error en ultimo cliente.
                }

                //GUARDAR TP EN Base de Datos:

                DataTable DTintersect = new DataTable();
                DTintersect.Columns.Add("Cliente");
                DTintersect.Columns.Add("CRT");
                DTintersect.Columns.Add("CRM Name");
                DTintersect.Columns.Add("IP Service Identifier");

                foreach (DataRow intersect in CircuitosMultiLine.Rows)
                {
                    cliente = intersect["Cliente"].ToString();
                    CID = intersect["CRT"].ToString();
                    try
                    {
                        if (Files.dtcliente.Select("CRT = '" + CID + "'", "CRT")[0][2].ToString().Length >0) 
                        {
                            DataRow r1 = DTintersect.NewRow();
                            r1["Cliente"] = cliente;
                            r1["CRT"] = CID;
                            r1["CRM Name"] = Files.dtcliente.Select("CRT='" + CID + "'", "CRT")[0][1].ToString();
                            r1["IP Service Identifier"] = Files.dtcliente.Select("CRT='"+CID+"'","CRT")[0][3].ToString();
                            DTintersect.Rows.Add(r1);
                        }
                    }
                    catch { }
                }
                //DataGridCircuitos.DataSource = DTintersect;

                if (DTintersect.Rows.Count > 0)
                {
                    try
                    {
                        TextBoxSchedule.Enabled = false;
                        BtnNotificar.Enabled = false;
                        TxtBoxCorreo.Enabled = false;
                        CheckBoxUpdate.Enabled = false;
                        TxtBoxTicketId.Enabled = false;
                        TextBoxScheduleUpdate.Enabled = false;

                        DataView vista3 = new DataView(CircuitosMultiLine);
                        DataTable CircuitosMultilineSinDuplicado = vista3.ToTable(true, "Cliente");
                        
                        progressBar1.Visible = true;
                        LabelEstado.Visible = true;
                        if (!SegundoPlano.IsBusy)
                        {
                            //circuitosmultiline2 = CircuitosMultiLine.Copy();
                            circuitosmultiline2 = DTintersect.Copy();
                            SegundoPlano.RunWorkerAsync();
                            //LabelEstado.Text = "Completado";
                        }
                    }
                    catch (Exception Evento03)
                    {
                        MessageBox.Show("Evento03\n\r-No se pudo Guardar Trabajo en Base de Datos\n\r " + Evento03.Message);
                    }
                }
                
                
            }
            
        }

        //Timer para parpadeo de boton Alerta.
        int seg = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Funciones.flag){BtnAlerta.BackColor = Color.IndianRed;Funciones.flag = false;}
            else{BtnAlerta.BackColor = Color.Transparent ; Funciones.flag = true;seg++;}
            if (seg == 10){timer1.Stop();BtnAlerta.BackColor = Color.Transparent; Funciones.flag = true; seg = 1; }
        }

        private Form InfoMessage;
        private void BtnAlerta_Click(object sender, EventArgs e)
        {
            if ((InfoMessage == null) || (InfoMessage.IsDisposed))
            {
                InfoMessage = new InfoMessageForm();
            }
            InfoMessage.Show();
            InfoMessage.Focus();
            InfoMessage.WindowState = FormWindowState.Normal;
        }

        private void CheckBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxUpdate.Checked == true)
            {
                TextBoxScheduleUpdate.Text = TextBoxSchedule.Text;
                if (TextBoxScheduleUpdate.Text == "Schedule") { TextBoxScheduleUpdate.Text = ""; }
                TextBoxSchedule.Text = "";
                TextBoxSchedule.ForeColor = Color.Black;
                TextBoxScheduleUpdate.ForeColor = Color.Black;
                TextBoxScheduleUpdate.Enabled = true;
            }
            else
            {
                TextBoxSchedule.ForeColor = Color.Black;
                TextBoxScheduleUpdate.Enabled = false;
                TextBoxScheduleUpdate.Text = "Update Schedule";
                TextBoxScheduleUpdate.ForeColor = Color.Gray;
            }
        }
        DataTable circuitosmultiline2;
        private void SegundoPlano_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int Progress = 0;
            try
            {
                if ((CheckBoxUpdate.Checked == true) && (TextBoxScheduleUpdate.Text.Length > 5))
                {
                    foreach (string c in TextBoxScheduleUpdate.Lines)
                    {
                        Progress = 0;
                        if (c.Length >= 25)
                        {
                            BaseDeDatos.GuardarTPenBD(c.Split(' ')[0], c.Split(' ')[1], c.Split(' ')[3], c.Split(' ')[4], TxtBoxTicketId.Text, TextBoxDescripcion.Text, Impacto, TextBoxLocation.Text, tiponotif);
                            SegundoPlano.ReportProgress(0);
                            foreach (DataRow C in circuitosmultiline2.Rows)
                            {
                                BaseDeDatos.GuardarClientesEnBD((C)[0].ToString(), (C)[1].ToString(), (C)[2].ToString(), (C)[3].ToString(), TxtBoxTicketId.Text);
                                SegundoPlano.ReportProgress(Progress);
                                Progress = ((100 / (circuitosmultiline2.Rows.Count)) + Progress);
                            }
                            SegundoPlano.ReportProgress(100);
                        }
                    }
                }
                else
                {

                    foreach (string c in TextBoxSchedule.Lines)
                    {
                        Progress = 0;
                        if (c.Length >= 25)
                        {
                            BaseDeDatos.GuardarTPenBD(c.Split(' ')[0], c.Split(' ')[1], c.Split(' ')[3], c.Split(' ')[4], TxtBoxTicketId.Text, TextBoxDescripcion.Text, Impacto, TextBoxLocation.Text, tiponotif);
                            SegundoPlano.ReportProgress(0);
                            foreach (DataRow C in circuitosmultiline2.Rows)
                            {
                                BaseDeDatos.GuardarClientesEnBD((C)[0].ToString(), (C)[1].ToString(), (C)[2].ToString(), (C)[3].ToString(), TxtBoxTicketId.Text);
                                SegundoPlano.ReportProgress(Progress);
                                Progress = (100 / (circuitosmultiline2.Rows.Count) + Progress);
                            }
                            SegundoPlano.ReportProgress(100);
                        }
                    }
                }
            }
            catch(Exception exBD)
            {
                MessageBox.Show("Error exBD:\n\rNo se pudo ingresar TP en la Base de Datos\n\r-Error en las fechas\n\r" + exBD.Message +"\n\r"+ exBD);
            }
            
        }

        private void SegundoPlano_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            LabelEstado.Text = "Guardando Tp en BD";
        }

        private void SegundoPlano_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LabelEstado.Text = "Completado";
            TextBoxSchedule.Enabled = true;
            //TextBoxSchedule.ForeColor = Color.Black;
            BtnNotificar.Enabled = true;
            TxtBoxCorreo.Enabled = true;
            CheckBoxUpdate.Enabled = true;
            CheckBoxUpdate.Checked = false;
            TxtBoxTicketId.Enabled = true;
        }

        private Form FreezeWindow;
        private void BtnFreeze_Click(object sender, EventArgs e)
        {
            if ((FreezeWindow == null) || (FreezeWindow.IsDisposed))
            {
                FreezeWindow = new FreezeForm();
            }
            FreezeWindow.Show();
            FreezeWindow.Focus();
            FreezeWindow.WindowState = FormWindowState.Normal;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PlaceHolders();
            BtnCorreos.Location = new Point(0,126);
            BtnCalendario.Location= new Point(0,181); 
            BtnFreeze.Location= new Point(0, 236);
            BtnNotificar.Location= new Point(0, 291);
        }

        private void TextBoxSchedule_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSchedule.Text) && (CheckBoxUpdate.Checked==false))
            {
                TextBoxSchedule.Text = "Schedule";
                TextBoxSchedule.ForeColor = Color.Gray;
            }
        }

        private void TextBoxSchedule_GotFocus(object sender, EventArgs e)
        {
            if ((TextBoxSchedule.Text == "Schedule") && (CheckBoxUpdate.Checked == false))
            {
                TextBoxSchedule.ForeColor = Color.Black;
                TextBoxSchedule.Text = "";
            }
        }

        private void TextBoxLocation_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLocation.Text))
            {
                TextBoxLocation.Text = "Location";
                TextBoxLocation.ForeColor = Color.Gray;
            }
        }

        private void TextBoxLocation_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxLocation.Text == "Location")
            {
                TextBoxLocation.ForeColor = Color.Black;
                TextBoxLocation.Text = "";
            }
        }

        private void TextBoxImpacTime_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxImpacTime.Text))
            {
                TextBoxImpacTime.Text = "Impact Time";
                TextBoxImpacTime.ForeColor = Color.Gray;
            }
        }

        private void TextBoxImpacTime_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxImpacTime.Text == "Impact Time")
            {
                TextBoxImpacTime.ForeColor = Color.Black;
                TextBoxImpacTime.Text = "";
            }
        }

        private void TextBoxDescripcion_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxDescripcion.Text))
            {
                TextBoxDescripcion.Text = "Description";
                TextBoxDescripcion.ForeColor = Color.Gray;
            }
        }

        private void TextBoxDescripcion_GotFocus(object sender, EventArgs e)
        {
            if (TextBoxDescripcion.Text == "Description")
            {
                TextBoxDescripcion.ForeColor = Color.Black;
                TextBoxDescripcion.Text = "";
            }
        }

        private void TxtBoxTicketId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxTicketId.Text))
            {
                TxtBoxTicketId.Text = "Ticket";
                TxtBoxTicketId.ForeColor = Color.Gray;
            }
        }

        private void TxtBoxTicketId_GotFocus(object sender, EventArgs e)
        {
            if (TxtBoxTicketId.Text == "Ticket")
            {
                TxtBoxTicketId.ForeColor = Color.Black;
                TxtBoxTicketId.Text = "";
            }
        }

        private void ComboBoxImpacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxImpacto.Text == "SH") { TextBoxImpacTime.Text = "50"; }
            else { TextBoxImpacTime.Text = ""; }
        }

        private void TextBoxImpacTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxImpacto.Text == "*")
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsNumber(e.KeyChar) || (Char.IsControl(e.KeyChar)))
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }

        private void Principal_Deactivate(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private Form Calendario;
        
        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            if ((Calendario == null) || (Calendario.IsDisposed))
            {
                Calendario = new CalendarioSWapp.CalendarioForm();
            }
            Calendario.Show();
            Calendario.Focus();
            Calendario.WindowState = FormWindowState.Maximized;
        }

        int Desplegar = 0;
        private void BtnDesplegable_Click(object sender, EventArgs e)
        {
            
            if(Desplegar==0)
            {
                BtnDesplegable.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                BtnVerificar.Visible = true;
                BtnLimpiar.Visible = true;
                BtnCopiar.Visible = true;
                BtnCorreos.Location = new Point(0, 276);
                BtnCalendario.Location = new Point(0, 331);
                BtnFreeze.Location = new Point(0, 386);
                BtnNotificar.Location = new Point(0, 441);
                Desplegar = 1;
            }
            else
            {
                BtnDesplegable.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                BtnVerificar.Visible = false;
                BtnLimpiar.Visible = false;
                BtnCopiar.Visible = false;
                BtnCorreos.Location = new Point(0, 126);
                BtnCalendario.Location = new Point(0, 181);
                BtnFreeze.Location = new Point(0, 236);
                BtnNotificar.Location = new Point(0, 291);
                Desplegar = 0;
            }
            
        }

        private void RichTextAlertas_TextChanged(object sender, EventArgs e)
        {
            
        }

        private Form CambioTurno;

        private void Pendientes_Click(object sender, EventArgs e)
        {
            if ((CambioTurno == null) || (CambioTurno.IsDisposed))
            {
                CambioTurno = new CambioTurnoForm();
            }
            CambioTurno.Show();
            CambioTurno.Focus();
            CambioTurno.WindowState = FormWindowState.Normal;
        }
    }
}
