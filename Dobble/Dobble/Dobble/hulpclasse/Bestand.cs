using System;
using System.IO;
using System.Text;
// klasse gemaakt om mijn variabele weg te schrijven in txt files 
// een beetje rechttoe recht aan maar werkt wel 
namespace Dobble.hulpclasse
{
    public class Bestand
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        #region bestand maken of overschrijven met tekst
        public void Save(string tekst, string bestandsnaam)
        {

            string filename = Path.Combine(path, bestandsnaam);
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            fs.SetLength(0);
            byte[] bdata = Encoding.Default.GetBytes(tekst);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

        }
        #endregion
        #region leegmaken van bestand
        public void Delete (string bestandsnaam)
        {
            string tekst = "";
            string filename = Path.Combine(path, bestandsnaam);
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            fs.SetLength(0);
            byte[] bdata = Encoding.Default.GetBytes(tekst);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
        }
        #endregion
        #region toevoegen aan bestand 
        public void Append(string tekst, string bestandsnaam)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, bestandsnaam);
            FileStream fs = new FileStream(filename, FileMode.Append);
            // fs.SetLength(0);
            byte[] bdata = Encoding.Default.GetBytes(tekst);
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

        }
        #endregion
        #region lezen van tekstfile
        public string ReadFile(string bestandsnaam)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, bestandsnaam);
            string content = "";
            try
            {
                using (var streamReader = new StreamReader(filename))
                {
                    content = streamReader.ReadToEnd();

                }

            }
            catch
            {

            }

            return content;
        }
        #endregion
    }
}

