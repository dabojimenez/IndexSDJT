using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ORUSCURSO.Logica
{
    // https://lenguajesdeprogramacion.com/c-xamarin/encriptar-texto-en-c/
    //link donde se encuentra el codigo de desemcriptacion
    public class Desencryptacion
    {
        static private Encryptacion aes = new Encryptacion();
        static public string CnString;
        static string dbcnString;
        //entre mas caracteres es mejor, para q tome el sistema los carcatere sy los mezcle
        static public string appPwdUnique = "Index365.index365";

        // es el proceso que llera el archivo XML, y lo desencriptara
        // para esto es necesario, crear el acrhivo indicado
        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            //creamos este archivo donde tenemos la solucion, nos dirigiremos a ProyectoName/bin/Debug, y aqui es donde crearemos el archivo .xml
            //el nombre debe ser tal cual se le indica en la siguiente linea
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }

        //public static object UsuariosEncryp()
        //{
        //    XmlDocument doc = new XmlDocument();
        //    Label root = new Label();

        //    dbcnString = root.ToString();
        //    CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
        //    return CnString;

        //}
    }
}
