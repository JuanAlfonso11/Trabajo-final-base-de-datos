using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios usuarios = new MantenimientoUsuarios();
            usuarios.ShowDialog();

        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoEmpleados empleados = new MantenimientoEmpleados();
            empleados.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantimentoClientes clientes = new MantimentoClientes();
            clientes.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Desea Salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientosSuplidores suplidores = new MantenimientosSuplidores();
            suplidores.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void equipoYSeriviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipo_y_servicios equipo_Y_Servicios = new Equipo_y_servicios();
            equipo_Y_Servicios.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaUsuario Usuarios = new ConsultaUsuario();
            Usuarios.ShowDialog();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEmpleado empleado = new ConsultaEmpleado();
            empleado.ShowDialog();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaCliente cliente = new ConsultaCliente();
            cliente.ShowDialog();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaSuplidores suplidores = new ConsultaSuplidores();
            suplidores.ShowDialog();
        }

        private void equiposYServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEquipo equipo = new ConsultaEquipo();
            equipo.ShowDialog();
        }

        private void ConduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaConduces conduces = new ConsultaConduces();
            conduces.ShowDialog();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Facturación_de_Servicios facturación_De_Servicios = new Facturación_de_Servicios();
            facturación_De_Servicios.ShowDialog();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HistorialDeAccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaHistorial historial = new ConsultaHistorial();
            historial.ShowDialog();

        }

        private void PagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPagos pagos = new ConsultaPagos();
            pagos.ShowDialog();
        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCompras compras = new ConsultaCompras();
            compras.ShowDialog();
        }

        private void FacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFacturas facturas = new ConsultaFacturas();
            facturas.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir Calculadora de Windows
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "calc";
            proc.Start();

        }

        private void googleChromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir Google Chrome
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "chrome";
                proc.Start();
            }
            catch
            {
                //Si no tiene Chrome Instalado, pregunta si desea abrir I. Explorer
                DialogResult d = MessageBox.Show("Este software No esta instalado en el equipo, ¿Desea abrir Internet Explorer?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "iexplore";
                    proc.Start();
                }
            }

        }

        private void conducesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proceso_de_conduces conduces = new Proceso_de_conduces();
            conduces.ShowDialog();
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp backUp = new BackUp();
            backUp.ShowDialog();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el manual de usuario
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //En esta linea va la ruta donde esta el archivo del Manual de Usuario
            proc.StartInfo.FileName = "C:\\MANUAL DE USUARIOS.pdf";
            proc.Start();

        }

        private void ComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proceso_compras compras = new Proceso_compras();
            compras.ShowDialog();
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            proceso_pagos pagos = new proceso_pagos();
            pagos.ShowDialog();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
