using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndyToDoListChecker
{


    public partial class Form1 : Form
    {
        
        // Lista de datos
       public class Nodo {

            public bool Estado { get; set; } 
            public string Item { get; set; }
            public int Hasharriba { get; set; }
            public int Hashabajo { get; set; }
            public int Posicion { get; set; }

            public GroupBox Objeto { get; set; }

            public Nodo()
            {
                Estado = false;
                Item = "";
            }
            public Nodo(string item)
            {
                Estado = false;
                Item = item;
            }
            public Nodo(bool estado, string item)
            {
                Estado = estado;
                Item = item;
            }
            public Nodo(bool estado, string item, int hasharriba, int hashabajo, int posicion, GroupBox objeto)
            {
                Estado = estado;
                Item = item;
                Hasharriba = hasharriba;
                Hashabajo = hashabajo;
                Posicion = posicion;
                Objeto = objeto;
            }
        };

        
        
        public class Archivo
        {
            public string Direccion { get; set; }
            public string Nombre { get; set; }
            public int Cantidad_Items { get; set; }
            public Archivo(string direccion, string nombre, int cantidad_Items)
            {
                Direccion = direccion;
                Nombre = nombre;
                Cantidad_Items = cantidad_Items;
            }
        }
        
        //Estado
        public struct Estado
        {
            public int Cantidad_De_Archivos { get; set; }
            public List<Archivo> Lista_De_Archivos { get; set; }

        }


        
        public void Abrir_Estado()
        {
            //abrir archivo de estado en ubicación
            //si no se encuentra archivo de estado crear uno nuevo


        }
        public void Guardar_Estado()
        {

        }
        public void Abrir_Archivo(string Direccion)
        {

        }
        public void Cerrar_Archivo(Archivo archivo)
        {

        }
        public void Guardar_Archivo(Archivo archivo)
        {

        }





        public Form1()
        {
           
            InitializeComponent();
              
            Resize += Form1_Resize;
            /*this.rectangulo.MouseMove += Form1_MouseMove;
            this.rectangulo.MouseUp += Form1_MouseUp;
            this.rectangulo.MouseDown += Item_MouseDown;*/
            



        }
        

        private void RegisterEventHandler()
        {

         
    }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;

           


            Pestañas.Width = (control.Size.Width)-130-10;
            Pestañas.Height = control.Size.Height-65-30;
            panel2.Left = control.Size.Width - 125;
            panel2.Height = control.Size.Height - 65;
            paneles.Width = (control.Size.Width) - 130;
            paneles.Height = control.Size.Height - 65;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }




        public void Agregar_A_Lista()
        {

        }



        



        List<Nodo> Lista = new List<Nodo>();

        public void AgregarItem()
        {

        }

        int auxiliar = 0;
        Point punto = new Point(0,0);

        public void agregarBoton()
        {
            
            CheckBox chk = new System.Windows.Forms.CheckBox();
            TextBox txt = new System.Windows.Forms.TextBox();
            Button borrar = new System.Windows.Forms.Button();
            Button arriba = new System.Windows.Forms.Button();
            Button abajo = new System.Windows.Forms.Button();




            GroupBox item = new System.Windows.Forms.GroupBox();
            item.SuspendLayout();

            // item1
            // 
            item.Controls.Add(abajo);
            item.Controls.Add(arriba);
            item.Controls.Add(borrar);
            item.Controls.Add(txt);
            item.Controls.Add(chk);
            item.Location = new System.Drawing.Point(3-this.tab1.HorizontalScroll.Value, 3 + auxiliar * 80- this.tab1.VerticalScroll.Value);
            item.Name = "item" + auxiliar.ToString();
            item.Size = new System.Drawing.Size(643 + 100, 80);
            item.TabIndex = 4;
            item.TabStop = false;

            item.MouseDown += new System.Windows.Forms.MouseEventHandler(Item_MouseDown);
            item.MouseMove += new System.Windows.Forms.MouseEventHandler(Form1_MouseMove);
            item.MouseUp += new System.Windows.Forms.MouseEventHandler(Form1_MouseUp);

            // 
            // chk1
            // 
            chk.AutoSize = true;
            chk.Location = new System.Drawing.Point(7, 20);
            chk.Name = "chk" + auxiliar.ToString();
            chk.Size = new System.Drawing.Size(15, 14);
            chk.TabIndex = 0;
            chk.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            txt.Location = new System.Drawing.Point(23, 20);
            txt.Multiline = true;
            txt.Name = "txt" + auxiliar.ToString();
            txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txt.Size = new System.Drawing.Size(540, 54);
            txt.TabIndex = 1;
            // 
            // borrar1
            // 
            borrar.Location = new System.Drawing.Point(585, 20);
            borrar.Name = "borrar" + auxiliar.ToString();
            borrar.Size = new System.Drawing.Size(52, 23);
            borrar.TabIndex = 3;
            borrar.Text = "Borrar";
            borrar.UseVisualStyleBackColor = true;

            // 
            // arriba1
            // 
            arriba.Location = new System.Drawing.Point(614, 50);
            arriba.Name = "arriba" + auxiliar.ToString();
            arriba.Size = new System.Drawing.Size(100, 23);
            arriba.TabIndex = 4;
            arriba.Text = "^";
            arriba.UseVisualStyleBackColor = true;
            arriba.Click += new System.EventHandler(this.Mover_Click);
            // 
            // abajo1
            // 
            abajo.Location = new System.Drawing.Point(586, 49);
            abajo.Name = "abajo" + auxiliar.ToString();
            abajo.Size = new System.Drawing.Size(22, 23);
            abajo.TabIndex = 5;
            abajo.Text = "v";
            abajo.UseVisualStyleBackColor = true;
            abajo.Click += new System.EventHandler(this.Mover_Click);

            item.ResumeLayout(false);
            item.PerformLayout();
            
            //punto.X = 0;
           // punto.Y = this.tab1.VerticalScroll.Value;

           // this.tab1.AutoScrollPosition = punto ;
            this.tab1.Controls.Add(item);

           





            

            
            Lista.Add(new Nodo(false, "item"+auxiliar.ToString(),arriba.GetHashCode(),abajo.GetHashCode(),auxiliar,item));
            /*
            foreach (Nodo NodoA in Lista)
            {
                this.label1.Text += NodoA.Item;
            }*/



            auxiliar++;

        }


        bool Downmouse=false;

        private void Item_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            

            if (e.Button== MouseButtons.Left)
            {
                Control ctrl = (Control)sender;
                Downmouse = true;
                

                punto.X = ctrl.Left-20+e.X;
                punto.Y = ctrl.Top-20+e.Y;

                this.rectangulo.Location = punto;


                //detectar quien envió




            }


        }


        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Downmouse == true)
            {
                Control ctrl = (Control)sender;


                punto.X = ctrl.Left+ e.X-20;
                punto.Y = ctrl.Top + e.Y-20;

                this.rectangulo.Location = punto;





            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Downmouse = false;
        }


        private void Mover_Click(object sender, EventArgs e)
        {
            int i,n,salir;
            int hashcode;
            Nodo temporal;
            i = 0;
            salir = 0;
            hashcode= sender.GetHashCode();
            //this.label1.Text = hashcode.ToString();

            n = Lista.Count;
            if (n>1)
            {

                do
                {
                    if (Lista[i].Hashabajo == hashcode) salir = 1;
                    if (Lista[i].Hasharriba == hashcode) salir = -1;

                    i++;
                } while (salir == 0 && i < n);


                if(salir==1)
                {
                    if (i < n)
                    {
                        this.tab1.SuspendLayout();
                        this.SuspendLayout();

                        punto =Lista[i - 1].Objeto.Location;
                        punto.Y += 80;
                        Lista[i - 1].Objeto.Location = punto;
                        punto = Lista[i].Objeto.Location;
                        punto.Y -= 80;
                        Lista[i].Objeto.Location = punto;

                        temporal = Lista[i - 1];
                        Lista.RemoveAt(i - 1);
                        Lista.Insert(i, temporal);
                        this.tab1.ResumeLayout(false);
                        this.tab1.PerformLayout();
                        this.ResumeLayout(false);
                        /*
                        this.label1.Text = "";
                        foreach (Nodo nodoA in Lista)
                        {
                            this.label1.Text += nodoA.Posicion.ToString() + "_";

                        }*/


                    }
                }
                else if (salir == -1)
                {
                    if (i >1)
                    {
                        this.tab1.SuspendLayout();
                        this.SuspendLayout();
                        punto = Lista[i - 1].Objeto.Location;
                        punto.Y -= 80;
                        Lista[i - 1].Objeto.Location = punto;
                        punto = Lista[i-2].Objeto.Location;
                        punto.Y += 80;
                        Lista[i-2].Objeto.Location = punto;

                        temporal = Lista[i - 1];
                        Lista.RemoveAt(i - 1);
                        Lista.Insert(i-2, temporal);
                        this.tab1.ResumeLayout(false);
                        this.tab1.PerformLayout();
                        this.ResumeLayout(false);
                        /*
                        this.label1.Text = "";
                        foreach (Nodo nodoA in Lista)
                        {
                            this.label1.Text += nodoA.Posicion.ToString() + "_";

                        }*/

                    }
                }



            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarBoton();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
