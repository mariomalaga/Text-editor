/*
* PRÁCTICA.............: Práctica 8
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: App.de Formulario II. Generación de Componentes.
* FECHA DE ENTREGA.....: 08 de Enero de 2019
*/
namespace Proyecto9
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.progressBarCargar = new System.Windows.Forms.ProgressBar();
            this.tmrCargar = new System.Windows.Forms.Timer(this.components);
            this.lblCargando = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(74, 45);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(177, 173);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // progressBarCargar
            // 
            this.progressBarCargar.Location = new System.Drawing.Point(62, 265);
            this.progressBarCargar.Name = "progressBarCargar";
            this.progressBarCargar.Size = new System.Drawing.Size(874, 115);
            this.progressBarCargar.TabIndex = 1;
            this.progressBarCargar.Click += new System.EventHandler(this.progressBarCargar_Click);
            // 
            // tmrCargar
            // 
            this.tmrCargar.Tick += new System.EventHandler(this.Timer_tick);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblCargando.Location = new System.Drawing.Point(303, 142);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(209, 76);
            this.lblCargando.TabIndex = 2;
            this.lblCargando.Text = "label1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTitulo.Location = new System.Drawing.Point(303, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(485, 76);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Editor de Texto";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(986, 437);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.progressBarCargar);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Text = "Form_Splash";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ProgressBar progressBarCargar;
        private System.Windows.Forms.Timer tmrCargar;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblTitulo;
    }
}