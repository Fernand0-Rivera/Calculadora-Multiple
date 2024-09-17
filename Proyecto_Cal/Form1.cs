using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cal
{
    public partial class Form1 : Form{
        double X, R, Y;
        GroupBox gB1, gB2, gB3;
        TextBox tB1, tB2;
        Button BExp, BLog, BSin, BCos, BTan, BPlus, BLess, BMult, BDiv, BPi, BSqrt;
        ListBox lBsalida;
        MenuStrip MS;
        ToolStripMenuItem MenuItems, FirmaItems, SalirItems;
        Label x, y;
        public Form1() {
            InitializeComponent();
            Genera();
            GeneraM();
            Form Forms = new Form();
        }

        public void Label(){
            x = new Label();
            y = new Label();
            x.Text = "X";
            y.Text = "Y";
            x.Location = new Point(20, 50);
            y.Location = new Point(20, 100);

            gB1.Controls.Add(x);
            gB1.Controls.Add(y);
        }
        

        public void GeneraM (){
            MS = new MenuStrip();
            MS.BackColor = Color.LightGray;

            MenuItems = new ToolStripMenuItem("Menú");
            FirmaItems = new ToolStripMenuItem("Firma");
            SalirItems = new ToolStripMenuItem("Salir");

            MenuItems.DropDownItems.Add(FirmaItems);
            MenuItems.DropDownItems.Add(SalirItems);

            MS.Items.Add(MenuItems);

            this.Controls.Add(MS);

            FirmaItems.Click += new System.EventHandler(FirmaItems_Click);
            SalirItems.Click += new System.EventHandler(SalirItems_Click);

        }
        private void FirmaItems_Click(object sender, EventArgs e){
            System.Diagnostics.Process.Start("Practica_2.exe");
        }

        private void SalirItems_Click(object sender, EventArgs e){
            Close();
        }

        public void Genera() { 
            //Entrada
            gB1 = new GroupBox();
            gB1.Text = "Entrada";
            gB1.Width = 200;
            gB1.Height = 350;
            gB1.Location = new Point(40, 50);
            this.Controls.Add(gB1);

            tB1 = new TextBox();
            tB1.Width = 100;
            tB1.Height = 50;
            tB1.Location = new Point(30, 50);
            gB1.Controls.Add(tB1);

            tB2 = new TextBox();
            tB2.Width = 100;
            tB2.Height = 50;
            tB2.Location = new Point(30, 100);
            gB1.Controls.Add(tB2);
            Label();

            //Proceso
            gB2 = new GroupBox();
            gB2.Text = "Proceso";
            gB2.Width = 200;
            gB2.Height = 350;
            gB2.Location = new Point(270, 50);
            this.Controls.Add(gB2);

            //1-Exponencial
            BExp = new Button();
            BExp.Text = "Exp";
            BExp.Width = 50;
            BExp.Height = 30;
            BExp.Location = new Point(25, 50);
            BExp.Click += new System.EventHandler(BExp_Click);
            gB2.Controls.Add(BExp);
            //2-Logaritmo
            BLog = new Button();
            BLog.Text = "Log";
            BLog.Width = 50;
            BLog.Height = 30;
            BLog.Location = new Point(75, 50);
            BLog.Click += new System.EventHandler(BLog_Click);
            gB2.Controls.Add(BLog);
            //3-Seno
            BSin = new Button();
            BSin.Text = "Sin";
            BSin.Width = 50;
            BSin.Height = 30;
            BSin.Location = new Point(125, 50);
            BSin.Click += new System.EventHandler(BSin_Click);
            gB2.Controls.Add(BSin);
            //4-Coseno
            BCos = new Button();
            BCos.Text = "Cos";
            BCos.Width = 50;
            BCos.Height = 30;
            BCos.Location = new Point(25, 100);
            BCos.Click += new System.EventHandler(BCos_Click);
            gB2.Controls.Add(BCos);
            //5-Tangente
            BTan = new Button();
            BTan.Text = "Tan";
            BTan.Width = 50;
            BTan.Height = 30;
            BTan.Location = new Point(75, 100);
            BTan.Click += new System.EventHandler(BTan_Click);
            gB2.Controls.Add(BTan);
            //6-Suma
            BPlus = new Button();
            BPlus.Text = "+";
            BPlus.Width = 50;
            BPlus.Height = 30;
            BPlus.Location = new Point(125, 100);
            BPlus.Click += new System.EventHandler(BPlus_Click);
            gB2.Controls.Add(BPlus);
            //7-Resta
            BLess = new Button();
            BLess.Text = "-";
            BLess.Width = 50;
            BLess.Height = 30;
            BLess.Location = new Point(25, 150);
            BLess.Click += new System.EventHandler(BLess_Click);
            gB2.Controls.Add(BLess);
            //8-Multiplicacion
            BMult = new Button();
            BMult.Text = "*";
            BMult.Width = 50;
            BMult.Height = 30;
            BMult.Location = new Point(75, 150);
            BMult.Click += new System.EventHandler(BMult_Click);
            gB2.Controls.Add(BMult);
            //9-Division
            BDiv = new Button();
            BDiv.Text = "/";
            BDiv.Width = 50;
            BDiv.Height = 30;
            BDiv.Location = new Point(125, 150);
            BDiv.Click += new System.EventHandler(BDiv_Click);
            gB2.Controls.Add(BDiv);
            //10-Raix Cuadrada
            BSqrt = new Button();
            BSqrt.Text = "√";
            BSqrt.Width = 50;
            BSqrt.Height = 30;
            BSqrt.Location = new Point(25, 200);
            BSqrt.Click += new System.EventHandler(BSqrt_Click);
            gB2.Controls.Add(BSqrt);

            //Salida
            gB3 = new GroupBox();
            gB3.Text = "Salida";
            gB3.Width = 200;
            gB3.Height = 350;
            gB3.Location = new Point(500, 50);
            this.Controls.Add(gB3);

            lBsalida = new ListBox();
            lBsalida.Width = 100;
            lBsalida.Height = 50;
            lBsalida.Location = new Point(30, 50);
            gB3.Controls.Add(lBsalida);
        }

        private void BPlus_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            Y = double.Parse(tB2.Text);
            R = X + Y;
            lBsalida.Items.Add(R);
        }

        //CODIGO PARA CALCULAR EL lOGARITMO
        private void BLog_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            R = Math.Log(X);
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA CALCULAR EXPONENCIAL
        private void BExp_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            R = Math.Exp(X);
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA CALCULAR EL SENO
        private void BSin_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            R = Math.Sin(X);
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA CALCULAR EL COSENO
        private void BCos_Click(object sender, EventArgs e) {
            X = double.Parse(tB1.Text);
            R = Math.Cos(X);
            lBsalida.Items.Add(R);
        }

        //CODIGO PARA CALCULAR lA TANGENTE
        private void BTan_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            R = Math.Tan(X);
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA RESTA
        private void BLess_Click(object sender, EventArgs e) {
            X = double.Parse(tB1.Text);
            Y = double.Parse(tB2.Text);
            R = X - Y;
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA DIVIDIR
        private void BDiv_Click(object sender, EventArgs e){
            X = double.Parse(tB1.Text);
            Y = double.Parse(tB2.Text);
            R = X / Y;
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA MULTIPLICAR
        private void BMult_Click(object sender, EventArgs e) {
            X = double.Parse(tB1.Text);
            Y = double.Parse(tB2.Text);
            R = X * Y;
            lBsalida.Items.Add(R);
        }
        //CODIGO PARA RAIZ CUADRADA
        private void BSqrt_Click(object sender, EventArgs e)
        {
            X = double.Parse(tB1.Text);
            R = Math.Sqrt(X);
            lBsalida.Items.Add(R);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
