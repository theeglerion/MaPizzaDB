using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pizza
{
    public class Datenbank
    {

        MySqlConnection con;


        public Datenbank() // opens connection to database, try/catch TODO for connection fails, typos etc.
        {
            List<string> liFile = ReadCfgFile();

            try
            {
                con = new MySqlConnection(liFile[1] + ";" + 
                                          liFile[2] + ";" + 
                                          liFile[3] + ";" + 
                                          liFile[4]);
                //con = new MySqlConnection("Server=127.0.0.1; UID=root; Password= ; Database = pizza");
                
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Öffnen" + ex.Message);
            }
        }
        

        public List<string> ReadCfgFile() // reads sql.cfg.-file to get data for conncetion with the sql-server.
        {
            List<string> content = new List<string>();
            
            try
            {
                using (StreamReader reader = new StreamReader("sql.cfg"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        content.Add(line);
                    }
                    reader.Close();
                }
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return content;
        } 


        public void CloseDB() // closes connetion to SQL database
        {
            if (con != null)
                con.Close();
        }


        public List<Kunde> GetKunden() 
        {
            List<Kunde> liKunde = new List<Kunde>();

            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "Select * From kunden";

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    liKunde.Add(new Kunde(reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                                            reader.IsDBNull(2) ? "" : reader.GetString(2),
                                            reader.IsDBNull(3) ? "" : reader.GetString(3),
                                            reader.IsDBNull(4) ? "" : reader.GetString(4),
                                            reader.IsDBNull(5) ? "" : reader.GetString(5),
                                            reader.IsDBNull(6) ? "" : reader.GetString(6)
                                            ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetKunden: " + ex.Message);
            }

            return liKunde;
        }


        public void UpdateKunden(Kunde k)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "UPDATE kunden " +
                                    "SET KdnName = '" + k.KdnName1 + "'," +
                                        "KdnEmail = '" + k.KdnEmail1 + "'," +
                                        "KdnTelefon = '" + k.KdnTelefon1 + "'," +
                                        "KdnStrasseNr = '" + k.KdnStrassenNr1 + "'," +
                                        "KdnPlz = '" + k.KdnPLZ1 + "'," +
                                        "KdnOrt = '" + k.KdnOrt1 + "' " +                                        
                                    "WHERE KdnNr = " + k.KdnNr1.ToString() + ";";

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Kunde: " + ex.Message);
            }
        }


        public void InsertKunde(Kunde k)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO kunden VALUES (NULL,'" +
                                        k.KdnName1 + "', '" +
                                        k.KdnEmail1 + "', '" +
                                        k.KdnTelefon1 + "', '" +
                                        k.KdnStrassenNr1 + "', '" +
                                        k.KdnPLZ1 + "', '" +
                                        k.KdnOrt1 + "');";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neuer Kunde: " + ex.Message);
            }
        }


        public void DeleteKunde(Kunde k)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "DELETE FROM kunden WHERE KdnNr = " + k.KdnNr1.ToString() + ";";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteKunde: " + ex);
            }
        }


        public List<Bestellung> GetBestellung()
        {
            List<Bestellung> liBestellung = new List<Bestellung>();

            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "SELECT * FROM bestellung";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liBestellung.Add(new Bestellung(    reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                                    reader.IsDBNull(1) ? "" : reader.GetString(1),
                                                    reader.IsDBNull(2) ? -1 : reader.GetInt32(3)
                                                    ));
            }
            reader.Close();
            return liBestellung;
        }


        public int InsertBestellung (Bestellung b)
        {
            int bestellnr = -1;
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO bestellung VALUES (NULL,'" +
                                    b.BestDatum1 + "'," +
                                    b.BestKunde1 + ");";

                comm.ExecuteNonQuery();

                comm.CommandText = "SELECT MAX(BestNr) FROM bestellung;";
                MySqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    bestellnr = reader.GetInt32(0);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neue Bestellung: " + ex.Message);
            }
            return bestellnr;
        }


        public List<Speisen> GetSpeisen()
        {
            List<Speisen> liSpeisen = new List<Speisen>();

            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "SELECT * FROM speisekarte";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liSpeisen.Add(new Speisen(  reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                                            reader.IsDBNull(2) ? -1 : reader.GetInt32(2),
                                            reader.IsDBNull(3) ? -1 : reader.GetDouble(3)                    
                                            ));
            }

            reader.Close();
            return liSpeisen;
        }


        public void UpdateSpeise(Speisen s)
        {

            CultureInfo ci = new CultureInfo("en-us");
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "UPDATE speisekarte " +
                                    "SET SpBezeichnung = '" + s.SBezeichnung + "'," +
                                        "SpKategorie = " + s.SKategorie + "," +
                                        "SpPreis = '" + s.SPreis.ToString(ci) + "' " +
                                    "WHERE SpNr = " + s.SNr + ";";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateSpeise: " + ex.Message);
            }
        }


        public void InsertSpeise(Speisen s)
        {
            CultureInfo ci = new CultureInfo("en-us");
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO speisekarte " +
                                   "VALUES (" + 
                                        s.SNr + ",'" +
                                        s.SBezeichnung + "'," +
                                        s.SKategorie + "," +
                                        s.SPreis.ToString(ci) + ");";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neue Speise: " + ex.Message);
            }         
        }


        public void DeleteSpiese(Speisen s)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "DELETE FROM speisekarte WHERE SpNr = " + s.SNr.ToString() + ";";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteSpiese: " + ex);
            }
        }


        public List<Position> GetPosition()
        {
            List<Position> liPosition = new List<Position>();

            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "SELECT * FROM position";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liPosition.Add(new Position(   reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                               reader.IsDBNull(1) ? -1 : reader.GetInt32(1),
                                               reader.IsDBNull(2) ? -1 : reader.GetInt32(2)
                                               ));
            }
            reader.Close();
            return liPosition;
        }


        public void InsertPosition(Position p)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO position " +
                                   "VALUES (" + p.PosSpeise1 + "," +
                                                p.PosMenge1 + "," +
                                                p.PosBestellung1 + ");";

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neue Position: " + ex.Message);
            }
        }


        public List<Fahrer> GetFahrer()
        {
            List<Fahrer> liFahrer = new List<Fahrer>();

            MySqlCommand comm = con.CreateCommand();

            comm.CommandText = "SELECT * FROM fahrer";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liFahrer.Add(new Fahrer(reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                        reader.IsDBNull(1) ? "" : reader.GetString(1),
                                        reader.IsDBNull(2) ? "" : reader.GetString(2),
                                        reader.IsDBNull(3) ? "" : reader.GetString(3)
                                        ));
            }

            reader.Close();
            return liFahrer;
        }


        public List<View> ViewBestellung()
        {
            List<View> liView = new List<View>();

            MySqlCommand comm = con.CreateCommand();

            comm.CommandText = "SELECT " +
                                "   bestellung.BestNr," +
                                "   bestellung.BestDatum," +
                                "   speisekarte.SpBezeichnung," +
                                "   speisekarte.SpPreis," +
                                "	position.PosMenge," +
                                "	kunden.KdnName," +
                                "   kunden.KdnTelefon," +
                                "	kunden.KdnStrasseNr," +
                                "	kunden.KdnPLZ," +
                                "	kunden.KdnOrt" +
                                " FROM bestellung" +
                                " LEFT JOIN position ON position.PosBestellung = bestellung.BestNr" +
                                " LEFT JOIN speisekarte ON speisekarte.SpNr = position.PosSpeise" +
                                " LEFT JOIN kunden ON kunden.KdnNr = bestellung.BestKunde" +
                                " ORDER BY BestNr desc"
                                ;

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liView.Add(new View(reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                    reader.IsDBNull(1) ? "" : reader.GetString(1),
                                    reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    reader.IsDBNull(3) ? -1 : reader.GetDouble(3),
                                    reader.IsDBNull(4) ? -1 : reader.GetInt32(4),
                                    reader.IsDBNull(5) ? "" : reader.GetString(5),
                                    reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    reader.IsDBNull(8) ? "" : reader.GetString(8),
                                    reader.IsDBNull(9) ? "" : reader.GetString(9)
                                    ));
            }

            reader.Close();
            return liView;
        }


        public List<Kategorie> GetKategorie()
        {
            List<Kategorie> liKategorie = new List<Kategorie>();

            MySqlCommand comm = con.CreateCommand();

            comm.CommandText = "SELECT * FROM kategorie";

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                liKategorie.Add(new Kategorie(reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                                              reader.IsDBNull(1) ? "" : reader.GetString(1)
                                              ));
            }

            reader.Close();
            return liKategorie;
        }


        public void InsertKategorie(string s)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO kategorie " +
                                   "VALUES (NULL, '" + s + "');";

                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("InsertKategorie: " + ex.Message);
            }
        }


        public void DeleteKategorie(Kategorie k)
        {
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "DELETE FROM kategorie WHERE KatNr = " + k.KatNr1.ToString() + ";";
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteSpiese: " + ex);
            }
        }
    }
}