using ORUSCURSO.Presentacion;
using ORUSCURSO.Presentacion.AsistenteInstalacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUSCURSO
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Arrancaremos de la siguuiente manera, para poder iniciar los formularios, y sin porblemas de usar el Dispose
            //Application.Run(new LoginForm());
            /*
            UsuarioPrincipal frm = new UsuarioPrincipal();
            frm.ShowDialog();
            */
            LoginForm frmLogin = new LoginForm();
            //cuando cierro el formulario
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.ShowDialog();
            Application.Run(); //<----- No afecta en que este, pero no lo colocaremos
            
        }
        // cada vez que cierre este formulario, la aplicacion terminara todos los recursos pero que no se detenga
        private static void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //livermaos recuros, pero que siga la palicaicon
            Application.ExitThread();
            // si finalizo el ultimo fomulario, que se temine la palicaicon
            Application.Exit();
        }
    }
}
