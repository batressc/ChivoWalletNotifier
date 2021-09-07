using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ChivoWalletNotifier {
    public partial class FormMain : Form {
        private bool isTimerActive;
        public FormMain() {
            InitializeComponent();
            isTimerActive = false;
        }

        private void buttonRevisar_Click(object sender, EventArgs e) {
            timerMain.Interval = Convert.ToInt32(numericUpDownSegundos.Value) * 1000;
            if (isTimerActive) {
                buttonRevisar.Text = "Activar notificador";
                timerMain.Stop();
                isTimerActive = false;
            } else {
                buttonRevisar.Text = "Detener notificador";
                timerMain.Start();
                isTimerActive = true;
            }
        }

        private async void timerMain_Tick(object sender, EventArgs e) {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://play.google.com/store/apps/details?id=com.chivo.wallet");
            if (response.IsSuccessStatusCode) {
                notifyIconMain.ShowBalloonTip(60 * 1000, "Atento", "Ya puedes descargar la chivo wallet", ToolTipIcon.Info);
            } else if (!checkBoxMain.Checked) {
                notifyIconMain.ShowBalloonTip(60 * 1000, "Espera un poco más...", "Aún no está disponible la chivo wallet", ToolTipIcon.Info);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
            }
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
