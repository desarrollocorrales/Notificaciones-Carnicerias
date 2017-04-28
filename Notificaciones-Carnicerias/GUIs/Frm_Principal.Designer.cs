namespace Notificaciones_Carnicerias.GUIs
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.IconoNotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.segundoPlano = new System.ComponentModel.BackgroundWorker();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.lblTituo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IconoNotificacion
            // 
            this.IconoNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.IconoNotificacion.BalloonTipText = "El programa de notificaciones esta en ejecucion...";
            this.IconoNotificacion.BalloonTipTitle = "Notificaciones - Los Corrales";
            this.IconoNotificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("IconoNotificacion.Icon")));
            this.IconoNotificacion.Text = "Notificaciones - Los Corrales";
            this.IconoNotificacion.Visible = true;
            this.IconoNotificacion.DoubleClick += new System.EventHandler(this.IconoNotificacion_DoubleClick);
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 10000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // lblTituo
            // 
            this.lblTituo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituo.AutoSize = true;
            this.lblTituo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituo.Location = new System.Drawing.Point(330, 32);
            this.lblTituo.Name = "lblTituo";
            this.lblTituo.Size = new System.Drawing.Size(124, 23);
            this.lblTituo.TabIndex = 0;
            this.lblTituo.Text = "Notificaciones";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Los Corrales";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Principal";
            this.ShowInTaskbar = false;
            this.Text = "Notificaciones - Los Corrales";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon IconoNotificacion;
        private System.ComponentModel.BackgroundWorker segundoPlano;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Label lblTituo;
        private System.Windows.Forms.Label label1;
    }
}