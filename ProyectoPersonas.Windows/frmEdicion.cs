using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPersonas.Entidades;
using ProyectoPersonas.Datos;
using ProyectoPersonas.Utilidades;

namespace ProyectoPersonas.Windows
{
    public partial class frmEdicion : Form
    {
        frmInicio referenciaInicio;
        Persona referenciaPersona;
        Verificador verificador;
        public frmEdicion(frmInicio referencia)
        {
            InitializeComponent();

            referenciaInicio = referencia;
            referenciaInicio.inhabilitarBotones();
            verificador = new Verificador();

            inicializarComponentes();
        }

        //METODOS

        //METODOS PUBLICOS

        public void modoAgregar()
        {
            setearBoton(btnEditar, false);
            setearBoton(btnAceptar, true);
            Text = "Agregar Persona";
        }

        public void modoEditar(Persona persona)
        {
            Text = "Editar Persona";

            txtApellido.Focus();

            setearBoton(btnAceptar, false);
            setearBoton(btnEditar, true);

            referenciaPersona = persona;

            txtApellido.Text = persona.obtenerApellido();
            txtPrimerNombre.Text = persona.obtenerPrimerNombre();
            txtSegundoNombre.Text = persona.obtenerSegundoNombre();
            txtDNI.Text = persona.obtenerDNI();
            dtpckFecha.Value = Convert.ToDateTime(persona.obtenerFechaNacimiento());
            cmboxSexo.SelectedItem = persona.obtenerSexo();
            cmboxLocalidad.SelectedItem = persona.obtenerLocalidad().ToString().Replace('_', ' ');

            txtDNI.Enabled = false;
            dtpckFecha.Enabled = false;

        }

        //METODOS PRIVADOS

        private bool campoVacio(TextBox campo)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                mostradorErrores.SetError(campo, "Debe llenar este campo.");
                return false;
            }

            return true;
        }

        private void colocarOpciones() 
        {
            List<Sexo> sexos = Enum.GetValues(typeof (Sexo)).Cast<Sexo>().ToList();

            foreach (Sexo opcion in sexos)
            {
                cmboxSexo.Items.Add(opcion);
            }

            List<Localidad> localidades = Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList();

            foreach (Localidad opcion in localidades)
            {
                cmboxLocalidad.Items.Add(opcion.ToString().Replace('_',' '));
            }
        }

        private Persona construirPersona()
        {

            string DNI = txtDNI.Text;
            string apellido = txtApellido.Text;
            string primerNombre = txtPrimerNombre.Text;
            string segundoNombre = txtSegundoNombre.Text;
            DateTime fechaNacimiento = dtpckFecha.Value;
            Sexo sexo = (Sexo)cmboxSexo.SelectedIndex;
            Localidad localidad = (Localidad)cmboxLocalidad.SelectedIndex;

            Persona persona = new Persona(DNI,apellido,primerNombre,segundoNombre,fechaNacimiento,sexo,localidad);

            return persona;
        }

        private void inicializarComponentes()
        {
            txtApellido.Clear();
            txtDNI.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();

            colocarOpciones();
            cmboxSexo.SelectedItem = Sexo.Masculino;
            cmboxLocalidad.SelectedIndex = Convert.ToInt32(Localidad.Gral_Las_Heras);


            dtpckFecha.Value = DateTime.Today.Date;

        }

        private void setearBoton(ToolStripMenuItem boton, bool estado)
        {
            boton.Enabled = estado;
            boton.Visible = estado;
        }

        private bool validarDatos()
        {
            bool sinCamposVacios = campoVacio(txtApellido) && campoVacio(txtPrimerNombre);

            bool longitudCorrecta = verificarLongitudCampo(txtDNI);
            
            return sinCamposVacios && longitudCorrecta;
        }

        private bool verificarLongitudCampo(TextBox campo)
        {
            if (!verificador.longitudCorrecta(campo.Text, campo.MaxLength))
            {
                mostradorErrores.SetError(campo, $"Debe ingresar {campo.MaxLength} numeros");
                return false;
            }

            return true;
        }

        //EVENTOS
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            referenciaInicio.habilitarBotones();
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mostradorErrores.Clear();

            if (validarDatos())
            {
                try
                {
                    Persona persona = construirPersona();

                    referenciaInicio.agregarPersona(persona);

                    referenciaInicio.habilitarBotones();

                    Dispose();
                }
                catch (ExcepcionDatoEnRepositorio error)
                {
                    MessageBox.Show(error.mostrarError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            mostradorErrores.Clear();

            if (validarDatos())
            {
                try
                {
                    Persona personaEditado = construirPersona();

                    referenciaInicio.editarPersona(referenciaPersona, personaEditado);

                    referenciaInicio.habilitarBotones();

                    Dispose();
                }
                catch (ExcepcionDatoEnRepositorio error)
                {
                    MessageBox.Show(error.mostrarError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !verificador.soloLetras(Convert.ToChar(e.KeyChar));
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !verificador.soloLetras(Convert.ToChar(e.KeyChar));
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !verificador.soloLetras(Convert.ToChar(e.KeyChar));
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !verificador.soloNumeros(Convert.ToChar(e.KeyChar));
        }
    }
}
