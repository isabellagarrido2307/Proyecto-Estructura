namespace Proyecto_Yu_Gi_Oh
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            botonDuelo = new Button();
            botonMazos = new Button();
            SuspendLayout();
            // 
            // botonDuelo
            // 
            botonDuelo.BackgroundImage = Properties.Resources.BotonDuelo;
            botonDuelo.BackgroundImageLayout = ImageLayout.Stretch;
            botonDuelo.FlatAppearance.BorderSize = 0;
            botonDuelo.FlatStyle = FlatStyle.Flat;
            botonDuelo.Location = new Point(506, 371);
            botonDuelo.Name = "botonDuelo";
            botonDuelo.Size = new Size(387, 93);
            botonDuelo.TabIndex = 0;
            botonDuelo.UseVisualStyleBackColor = true;
            botonDuelo.Click += botonDuelo_Click;
            // 
            // botonMazos
            // 
            botonMazos.BackgroundImage = Properties.Resources.BotonMazo;
            botonMazos.BackgroundImageLayout = ImageLayout.Stretch;
            botonMazos.FlatAppearance.BorderSize = 0;
            botonMazos.FlatStyle = FlatStyle.Flat;
            botonMazos.Location = new Point(506, 500);
            botonMazos.Name = "botonMazos";
            botonMazos.Size = new Size(387, 93);
            botonMazos.TabIndex = 1;
            botonMazos.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuFondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1301, 687);
            Controls.Add(botonMazos);
            Controls.Add(botonDuelo);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button botonDuelo;
        private Button botonMazos;
    }
}