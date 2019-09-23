namespace Clase_06.WindowsForms
{
    partial class FrmPaleta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstPaleta = new System.Windows.Forms.ListBox();
            this.groupBoxPaleta = new System.Windows.Forms.GroupBox();
            this.btnAgregarTempera = new System.Windows.Forms.Button();
            this.btnQuitarTempera = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // paletaToolStripMenuItem
            // 
            this.paletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.paletaToolStripMenuItem.Name = "paletaToolStripMenuItem";
            this.paletaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.paletaToolStripMenuItem.Text = "Paleta";
            this.paletaToolStripMenuItem.Click += new System.EventHandler(this.paletaToolStripMenuItem_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // lstPaleta
            // 
            this.lstPaleta.FormattingEnabled = true;
            this.lstPaleta.Location = new System.Drawing.Point(27, 16);
            this.lstPaleta.Name = "lstPaleta";
            this.lstPaleta.Size = new System.Drawing.Size(743, 212);
            this.lstPaleta.TabIndex = 1;
            // 
            // groupBoxPaleta
            // 
            this.groupBoxPaleta.Controls.Add(this.btnModificar);
            this.groupBoxPaleta.Controls.Add(this.btnAgregarTempera);
            this.groupBoxPaleta.Controls.Add(this.btnQuitarTempera);
            this.groupBoxPaleta.Controls.Add(this.lstPaleta);
            this.groupBoxPaleta.Location = new System.Drawing.Point(12, 64);
            this.groupBoxPaleta.Name = "groupBoxPaleta";
            this.groupBoxPaleta.Size = new System.Drawing.Size(776, 347);
            this.groupBoxPaleta.TabIndex = 2;
            this.groupBoxPaleta.TabStop = false;
            this.groupBoxPaleta.Text = "Paleta";
            // 
            // btnAgregarTempera
            // 
            this.btnAgregarTempera.Location = new System.Drawing.Point(233, 237);
            this.btnAgregarTempera.Name = "btnAgregarTempera";
            this.btnAgregarTempera.Size = new System.Drawing.Size(125, 40);
            this.btnAgregarTempera.TabIndex = 2;
            this.btnAgregarTempera.Text = "+";
            this.btnAgregarTempera.UseVisualStyleBackColor = true;
            this.btnAgregarTempera.Click += new System.EventHandler(this.btnAgregarTempera_Click);
            // 
            // btnQuitarTempera
            // 
            this.btnQuitarTempera.Location = new System.Drawing.Point(436, 237);
            this.btnQuitarTempera.Name = "btnQuitarTempera";
            this.btnQuitarTempera.Size = new System.Drawing.Size(125, 40);
            this.btnQuitarTempera.TabIndex = 3;
            this.btnQuitarTempera.Text = "-";
            this.btnQuitarTempera.UseVisualStyleBackColor = true;
            this.btnQuitarTempera.Click += new System.EventHandler(this.btnQuitarTempera_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(339, 302);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 39);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.groupBoxPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPaleta;
        private System.Windows.Forms.GroupBox groupBoxPaleta;
        private System.Windows.Forms.Button btnAgregarTempera;
        private System.Windows.Forms.Button btnQuitarTempera;
        private System.Windows.Forms.Button btnModificar;
    }
}

