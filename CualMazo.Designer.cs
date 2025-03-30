namespace Proyecto_Yu_Gi_Oh
{
    partial class CualMazo
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
            botonMazoFamilia = new Button();
            botonMazoObliga = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // botonMazoFamilia
            // 
            botonMazoFamilia.BackColor = Color.PeachPuff;
            botonMazoFamilia.Location = new Point(33, 63);
            botonMazoFamilia.Name = "botonMazoFamilia";
            botonMazoFamilia.Size = new Size(140, 59);
            botonMazoFamilia.TabIndex = 0;
            botonMazoFamilia.Text = "Mazo Familia";
            botonMazoFamilia.UseVisualStyleBackColor = false;
            // 
            // botonMazoObliga
            // 
            botonMazoObliga.BackColor = Color.PeachPuff;
            botonMazoObliga.Location = new Point(247, 63);
            botonMazoObliga.Name = "botonMazoObliga";
            botonMazoObliga.Size = new Size(140, 59);
            botonMazoObliga.TabIndex = 1;
            botonMazoObliga.Text = "Mazo Obligatorio";
            botonMazoObliga.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Location = new Point(108, 12);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el Mazo a ver";
            // 
            // CualMazo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(434, 147);
            Controls.Add(label1);
            Controls.Add(botonMazoObliga);
            Controls.Add(botonMazoFamilia);
            Name = "CualMazo";
            Text = "CualMazo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonMazoFamilia;
        private Button botonMazoObliga;
        private Label label1;
    }
}