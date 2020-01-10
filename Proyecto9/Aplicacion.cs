/*
* PRÁCTICA.............: Práctica 9.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Editor de Textos.
* FECHA DE ENTREGA.....: 02 de Febrero de 2019
*/
using Proyecto9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto9
{
    static class Aplicacion
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplash frmSplash = new frmSplash();
            if (frmSplash.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Application.Run(new frmPrincipal());
                }
                catch (ArgumentException a)
                {
                    MessageBox.Show("Extension no válida");
                }
            }
        }
    }
}
