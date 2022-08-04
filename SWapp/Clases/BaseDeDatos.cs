using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using SWapp.Clases;

namespace SWapp.Clases
{
    public class BaseDeDatos
    {
        
        public static string connSTr;
        public static SqlConnection conn;
        public static SqlCommand comando;

        
        

        public static void Agregar(string tipo)
        {
            
            switch (tipo)
            {
                case "SWX":
                    MessageBox.Show("agregar swx a bd");break;
                case "Freeze":
                    MessageBox.Show("Agregar Freezing");break;
            }
        }

        

        public static void ConexionBD()
        {
            conn = new SqlConnection(connSTr);


            try
            {
                conn.Open();
                comando = new SqlCommand("SELECT * FROM trabajosprogramados", conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                //dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }


        public static DataTable dtFreeze;
        public static OleDbCommand cmdfreeze;
        public static void TablaFreeze(string U,TextBox SCHEDULE, TextBox SCHEDULEupdate)
        {

            string Fi, Ff;
            dtFreeze = new DataTable();
            cmdfreeze = new OleDbCommand();
            string queryFreeze;
            DataTable temp = new DataTable();
            int countlines = 0;
            conn = new SqlConnection(connSTr);

            if (U == "Update")
            {
                foreach (string c in SCHEDULEupdate.Lines)
                {

                    try
                    {
                        //Fi = c.Split(' ')[0];
                        //Fi = NombreMesTOnum(Fi.Split('-')[1]) + "/" + Fi.Split('-')[0] + "/" + Fi.Split('-')[2];
                        //Ff = c.Split(' ')[3];
                        //Ff = NombreMesTOnum(Ff.Split('-')[1]) + "/" + Ff.Split('-')[0] + "/" + Ff.Split('-')[2];

                        Fi = c.Split(' ')[0];
                        Fi = Fi.Split('-')[2] + "-" + NombreMesTOnum(Fi.Split('-')[1]) + "-" + Fi.Split('-')[0];
                        Ff = c.Split(' ')[3];
                        Ff = Ff.Split('-')[2] + "-" + NombreMesTOnum(Ff.Split('-')[1]) + "-" + Ff.Split('-')[0];

                        conn.Open();
                        queryFreeze = "SELECT [CRT_Cliente] FROM Freeze WHERE ( (( '" + Fi + "' BETWEEN [Fecha inicio Freeze] AND [Fecha fin Freeze]) OR ( '" + Ff + "' BETWEEN [Fecha inicio Freeze] AND [Fecha fin Freeze])) OR ('" + Fi + "' <= [Fecha inicio Freeze] AND '" + Ff + "' >= [Fecha fin Freeze]) )";
                        comando = new SqlCommand(queryFreeze, conn);
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        dtFreeze = new DataTable();
                        adaptador.Fill(dtFreeze);

                        if (countlines == 1)
                        {
                            dtFreeze.Merge(temp);
                        }
                        temp = dtFreeze.Copy();
                        conn.Close();
                    }
                    catch (System.Exception uno)
                    {
                        MessageBox.Show("No se puede obtener los circuitos en Freezing para estas fechas. Verificar las fechas ingresadas.\n\r" + uno.Message);
                        conn.Close();
                    }
                    countlines = 1;
                }
            }
            else
            {
                foreach (string c in SCHEDULE.Lines)
                {

                    try
                    {
                        Fi = c.Split(' ')[0];
                        Fi = Fi.Split('-')[2] + "-" + NombreMesTOnum(Fi.Split('-')[1]) + "-" + Fi.Split('-')[0];
                        Ff = c.Split(' ')[3];
                        Ff = Ff.Split('-')[2] + "-" + NombreMesTOnum(Ff.Split('-')[1]) + "-" + Ff.Split('-')[0];
                        conn.Open();
                        queryFreeze = "SELECT [CRT_Cliente] FROM Freeze WHERE ( (( '" + Fi + "' BETWEEN [Fecha inicio Freeze] AND [Fecha fin Freeze]) OR ( '" + Ff + "' BETWEEN [Fecha inicio Freeze] AND [Fecha fin Freeze])) OR ('" + Fi + "' <= [Fecha inicio Freeze] AND '" + Ff + "' >= [Fecha fin Freeze]) )";
                        comando = new SqlCommand(queryFreeze, conn);
                        SqlDataAdapter adaptador = new SqlDataAdapter();
                        adaptador.SelectCommand = comando;
                        dtFreeze = new DataTable();
                        adaptador.Fill(dtFreeze);
                        if (countlines == 1)
                        {
                            dtFreeze.Merge(temp);
                        }
                        temp = dtFreeze.Copy();
                        conn.Close();
                    }
                    catch (System.Exception uno)
                    {
                        MessageBox.Show("No se puede obtener los circuitos en Freezing para estas fechas. Verificar las Fechas ingresadas.\n\r" + uno.Message);
                        conn.Close();
                    }

                    countlines = 1;
                }
            }
            countlines = 0;
        }


        public static string NombreMesTOnum(string Mes)
        {
            string result = "0";
            Mes = Mes.TrimEnd('.');
            if (Mes == "set") { Mes = "sep"; }
            switch (Mes)
            {
                case "ene": result = "1"; break;
                case "feb": result = "2"; break;
                case "mar": result = "3"; break;
                case "abr": result = "4"; break;
                case "may": result = "5"; break;
                case "jun": result = "6"; break;
                case "jul": result = "7"; break;
                case "ago": result = "8"; break;
                case "sep": result = "9"; break;
                case "oct": result = "10"; break;
                case "nov": result = "11"; break;
                case "dic": result = "12"; break;
            }


            switch (Mes)
            {
                case "Jan": result = "1"; break;
                case "Feb": result = "2"; break;
                case "Mar": result = "3"; break;
                case "Apr": result = "4"; break;
                case "May": result = "5"; break;
                case "Jun": result = "6"; break;
                case "Jul": result = "7"; break;
                case "Aug": result = "8"; break;
                case "Sep": result = "9"; break;
                case "Oct": result = "10"; break;
                case "Nov": result = "11"; break;
                case "Dec": result = "12"; break;
            }

            return result;
        }


        public static int LASTIDinBDTP = 0;
        public static void GuardarTPenBD(string Fi, string Hi, string Ff, string Hf,string TicketId, string Description, string Impact, string Location, string Emergencia)
        {
            try
            {
                conn = new SqlConnection(connSTr);
                string query, query2;
                Fi = Fi.Split('-')[2] + "-" + NombreMesTOnum(Fi.Split('-')[1]) + "-" + Fi.Split('-')[0];
                Ff = Ff.Split('-')[2] + "-" + NombreMesTOnum(Ff.Split('-')[1]) + "-" + Ff.Split('-')[0];
                if(Emergencia == "Normal") { Emergencia = "0"; }
                else { Emergencia = "1"; }
                conn.Open();
                query = "INSERT INTO trabajosprogramados (Ticket, [Fecha inicio], [Fecha fin], [Hora fin], [Hora Inicio], Descripcion, Impact, Location, Emergencia) VALUES ('" + TicketId + "', '" + Fi + "', '" + Ff + "', '" + Hf + "', '" + Hi + "', '" + Description + "', '" + Impact + "', '" + Location + "', " + Emergencia + ")"; 
                query2 = "Select @@Identity as Id";

                comando = new SqlCommand(query, conn);
                comando.ExecuteNonQuery();

                comando = new SqlCommand(query2, conn);
                LASTIDinBDTP = Convert.ToInt32(comando.ExecuteScalar());
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            
        }

        public static void GuardarClientesEnBD(string ClienteSWX, string CircuitoCRT, string CircuitoCRMName, string IPServiceIdentifier, string TicketId)
        {
            try
            {
                conn = new SqlConnection(connSTr);
                string query;
                conn.Open();
                comando = new SqlCommand();
                comando.Connection = conn;
                query = "insert into Clientes (Id, Ticket, Cliente, CRT, [CRM Name], [IP Service Identifier]) VALUES (" + LASTIDinBDTP + ", '" + TicketId + "', '" + ClienteSWX + "', '" + CircuitoCRT + "', '" + CircuitoCRMName + "','" + IPServiceIdentifier + "')";
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            

        }



        public static void GetTableFreeze(DataGridView DG)
        {
            try
            {
                conn = new SqlConnection(connSTr);
                conn.Open();
                string query = "SELECT * FROM Freeze";
                comando = new SqlCommand(query, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DG.DataSource = tabla;
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            
        }


        public static void AgregarFreeze(string CRT_Cliente, string HiF, string Fif, string Hff,string Fff)
        {
            try
            {
                conn = new SqlConnection(connSTr);
                conn.Open();
                
                int i = 0;
                string query = "INSERT into Freeze ([CRT_Cliente],[Hora inicio Freeze],[Fecha inicio Freeze],[Hora fin Freeze],[Fecha fin Freeze]) VALUES('" + CRT_Cliente + "','" + HiF + "','" + Fif + "','" + Hff + "','" + Fff + "')";
                comando = new SqlCommand(query, conn);
                i = comando.ExecuteNonQuery();
                {
                    comando.Parameters.AddWithValue("@[CRT_Cliente]", CRT_Cliente);
                    comando.Parameters.AddWithValue("@[Hora inicio Freeze]", HiF);
                    comando.Parameters.AddWithValue("@[Fecha inicio Freeze]", Fif);
                    comando.Parameters.AddWithValue("@[Hora fin Freeze]", Hff);
                    comando.Parameters.AddWithValue("@[Fecha fin Freeze]", Fff);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }

        public static void DeleteFreeze(int Id)
        {
            try
            {
                conn = new SqlConnection(connSTr);
                conn.Open();
                string query = "DELETE from Freeze WHERE Id= " + Id + ";";
                comando = new SqlCommand(query, conn);
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }


    }
}
