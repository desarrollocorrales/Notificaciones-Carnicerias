using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Notificaciones_Carnicerias.GUIs
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            IconoNotificacion.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            Temporizador.Enabled = true;
        }

        private void IconoNotificacion_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Notificar();
        }
        private void Notificar()
        {
            //Frm_Notificacion x = new Frm_Notificacion();
            //x.WindowState = FormWindowState.Minimized;
            //x.Show();
            //x.WindowState = FormWindowState.Normal;

            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Title of popup";
            popupNotifier.ContentText = "Content text";
            popupNotifier.Popup();

        }

    }
}
