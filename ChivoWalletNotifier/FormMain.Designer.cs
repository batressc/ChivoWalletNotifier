
namespace ChivoWalletNotifier {
    partial class FormMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonRevisar = new System.Windows.Forms.Button();
            this.numericUpDownSegundos = new System.Windows.Forms.NumericUpDown();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.checkBoxMain = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Validando estatus de la Chivo Wallet";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // buttonRevisar
            // 
            this.buttonRevisar.Location = new System.Drawing.Point(123, 93);
            this.buttonRevisar.Name = "buttonRevisar";
            this.buttonRevisar.Size = new System.Drawing.Size(141, 23);
            this.buttonRevisar.TabIndex = 0;
            this.buttonRevisar.Text = "Activar notificador";
            this.buttonRevisar.UseVisualStyleBackColor = true;
            this.buttonRevisar.Click += new System.EventHandler(this.buttonRevisar_Click);
            // 
            // numericUpDownSegundos
            // 
            this.numericUpDownSegundos.Location = new System.Drawing.Point(181, 44);
            this.numericUpDownSegundos.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownSegundos.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSegundos.Name = "numericUpDownSegundos";
            this.numericUpDownSegundos.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownSegundos.TabIndex = 1;
            this.numericUpDownSegundos.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Location = new System.Drawing.Point(120, 46);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(55, 13);
            this.labelSegundos.TabIndex = 2;
            this.labelSegundos.Text = "Segundos";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 60000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // checkBoxMain
            // 
            this.checkBoxMain.AutoSize = true;
            this.checkBoxMain.Checked = true;
            this.checkBoxMain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMain.Location = new System.Drawing.Point(107, 70);
            this.checkBoxMain.Name = "checkBoxMain";
            this.checkBoxMain.Size = new System.Drawing.Size(170, 17);
            this.checkBoxMain.TabIndex = 3;
            this.checkBoxMain.Text = "Notificar solo si está disponible";
            this.checkBoxMain.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.checkBoxMain);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.numericUpDownSegundos);
            this.Controls.Add(this.buttonRevisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISPONIBILIDAD DE CHIVO WALLET";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Button buttonRevisar;
        private System.Windows.Forms.NumericUpDown numericUpDownSegundos;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.CheckBox checkBoxMain;
    }
}

