using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Archivos_Json
{
    public partial class _Default : Page
    {
        List<Persona> humano = new List<Persona>();
        List<Profesor> profesores = new List<Profesor>();
        static List<Alumno> alumnos = new List<Alumno>();

        static List<int> NotasTemp = new List<int>();

        private void SaveJson()
        {
            string json = JsonConvert.SerializeObject(alumnos);

            string archivo = Server.MapPath("Alumnos.json");

            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJson()
        {
            List<Alumno> lista = new List<Alumno>();

            string archivo = Server.MapPath(@"Alumnos.json");

            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Alumno>>(json);
        }    
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.NoCarne = TextBoxCarne.Text;
            alumno.FirstName = TextBoxName.Text;
            alumno.LastName = TextBoxLastName.Text;
            alumno.Notas = NotasTemp;

            alumnos.Add(alumno);

            SaveJson();

            NotasTemp.Clear();
        }
        protected void ButtonAddNotas_Click(object sender, EventArgs e)
        {

            int notaTemp = Convert.ToInt16(TextBoxNota.Text);

            NotasTemp.Add(notaTemp);

            GridView1.DataSource = NotasTemp;
            GridView1.DataBind();
        }
    }
}