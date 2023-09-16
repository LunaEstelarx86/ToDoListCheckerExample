using System.Windows.Forms;

namespace AndyToDoListChecker
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Label();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuevo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.rectangulo = new System.Windows.Forms.GroupBox();
            this.Pestañas.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(13, 346);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(72, 13);
            this.salida.TabIndex = 9;
            this.salida.Text = "holis:NO546P";
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.tab1);
            this.Pestañas.Controls.Add(this.Nuevo);
            this.Pestañas.Location = new System.Drawing.Point(0, 3);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(627, 385);
            this.Pestañas.TabIndex = 11;
            // 
            // tab1
            // 
            this.tab1.AutoScroll = true;
            this.tab1.Controls.Add(this.rectangulo);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(619, 359);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Nuevo1.atd";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(4, 22);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Padding = new System.Windows.Forms.Padding(3);
            this.Nuevo.Size = new System.Drawing.Size(619, 359);
            this.Nuevo.TabIndex = 1;
            this.Nuevo.Text = "(+)";
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.salida);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(670, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 420);
            this.panel2.TabIndex = 10;
            // 
            // paneles
            // 
            this.paneles.Controls.Add(this.tabPage1);
            this.paneles.Controls.Add(this.tabPage2);
            this.paneles.Location = new System.Drawing.Point(12, 10);
            this.paneles.Name = "paneles";
            this.paneles.SelectedIndex = 0;
            this.paneles.Size = new System.Drawing.Size(652, 420);
            this.paneles.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Pestañas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(20, 79);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 48);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar!!";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rectangulo
            // 
            this.rectangulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rectangulo.Location = new System.Drawing.Point(186, 82);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(251, 73);
            this.rectangulo.TabIndex = 4;
            this.rectangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.paneles);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Andy ToDo List Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pestañas.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.paneles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.Panel panel2;
        private TabControl Pestañas;
        private TabPage tab1;
        private TabPage Nuevo;
        private Label label1;
        private TabControl paneles;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button saveButton;
        private GroupBox rectangulo;
    }



}


