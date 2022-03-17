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

namespace ProyectoPersonas.Windows
{
    public partial class frmInicio : Form
    {

        //ATRIBUTOS

        private RepositorioPersona repositorio;

        public frmInicio()
        {
            InitializeComponent();
            repositorio = RepositorioPersona.obtenerInstancia();
            llenarGrilla(repositorio.obtenerPersonasPorIngreso());
            inicializarComponentes();
        }

        //METODOS

        //METODOS PUBLICOS

        public void agregarPersona(Persona persona)
        {
            repositorio.agregarPersona(persona);
            agregarPersonaEnGrilla(persona);
            llenarGrilla(repositorio.obtenerPersonasPorIngreso());
            lblCantidadPersonas.Text = repositorio.obtenerCantidadPersonas().ToString();
        }

        public void editarPersona(Persona personaViejo, Persona personaEditado)
        {
            repositorio.editarPersona(personaViejo, personaEditado);
            editarPersonaEnGrilla(personaEditado);
        }
        public void inhabilitarBotones()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnFiltrar.Enabled = false;
            btnOrdenar.Enabled = false;
            btnActualizar.Enabled = false;
            btnSalir.Enabled = false;
        }

        public void habilitarBotones()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnFiltrar.Enabled = true;
            btnOrdenar.Enabled = true;
            btnActualizar.Enabled = true;
            btnSalir.Enabled = true;
        }

        //METODOS PRIVADOS

        private void agregarPersonaEnGrilla(Persona persona)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(datosPersonas);
            llenarFila(fila, persona);
            datosPersonas.Rows.Add(fila);
        }

        private void editarPersonaEnGrilla(Persona personaEditado)
        {
            llenarFila(datosPersonas.SelectedRows[0], personaEditado);
        }
        private void llenarFila(DataGridViewRow fila, Persona persona)
        {
            fila.Cells[colApellido.Index].Value = persona.obtenerApellido();
            fila.Cells[colPrimerNombre.Index].Value = persona.obtenerPrimerNombre();
            fila.Cells[colSegundoNombre.Index].Value = persona.obtenerSegundoNombre().ToString();
            fila.Cells[colDNI.Index].Value = persona.obtenerDNI();
            fila.Cells[colEdad.Index].Value = persona.obtenerEdad().ToString();
            fila.Cells[colSexo.Index].Value = persona.obtenerSexo();
            fila.Cells[colLocalidad.Index].Value = persona.obtenerLocalidad().ToString().Replace('_', ' ');

            fila.Tag = persona;
        }

        private void inicializarComponentes()
        {
            List<Sexo> sexos = Enum.GetValues(typeof(Sexo)).Cast<Sexo>().ToList();

            foreach (Sexo sexo in sexos)
            {
                cmboxFiltrarPorSexo.Items.Add(sexo);
            }

            List<Localidad> localidades = Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList();

            foreach (Localidad localidad in localidades)
            {
                cmboxFiltrarPorLocalidad.Items.Add(localidad.ToString().Replace('_', ' '));
            }

        }
        private void llenarGrilla(List<Persona> personas)
        {
            datosPersonas.Rows.Clear();

            foreach (Persona persona in personas)
            {
                agregarPersonaEnGrilla(persona);
            }

            lblCantidadPersonas.Text = personas.Count.ToString();
        }

        private string mostrarPersonaEliminado(Persona persona)
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.Append("Se elimino la siguiente persona:\n");
            mensaje.Append($"APELLIDO: {persona.obtenerApellido()}\n");
            mensaje.Append($"PRIMER NOMBRE: {persona.obtenerPrimerNombre()}\n");
            mensaje.Append($"SEGUNDO NOMBRE: { persona.obtenerSegundoNombre()}\n");
            mensaje.Append($"DNI: { persona.obtenerDNI()}\n");
            mensaje.Append($"EDAD: {persona.obtenerEdad()}\n");
            mensaje.Append($"SEXO: {persona.obtenerSexo()}\n");
            mensaje.Append($"LOCALIDAD: {persona.obtenerLocalidad().ToString().Replace('_', ' ')}");
            return mensaje.ToString();
        }

        //EVENTOS

        //Eventos Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEdicion formulario = new frmEdicion(this);

            formulario.modoAgregar();

            formulario.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (datosPersonas.SelectedRows.Count > 0)
            {
                Persona persona = (Persona)datosPersonas.SelectedRows[0].Tag;

                frmEdicion formulario = new frmEdicion(this);

                formulario.modoEditar(persona);

                formulario.Show();
            }
            else
            {
                MessageBox.Show("No hay ningun persona o no se selecciono nada para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (datosPersonas.SelectedRows.Count > 0)
            {
                DialogResult operacion = MessageBox.Show("¿Desea eliminar este persona?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (operacion == DialogResult.OK)
                {
                    Persona persona = (Persona)datosPersonas.SelectedRows[0].Tag;

                    repositorio.eliminarPersona(persona);

                    datosPersonas.Rows.Remove(datosPersonas.SelectedRows[0]);

                    lblCantidadPersonas.Text = repositorio.obtenerCantidadPersonas().ToString();

                    MessageBox.Show(mostrarPersonaEliminado(persona), "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("No hay persona o no se selecciono nada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarGrilla(repositorio.obtenerPersonasPorIngreso());
            datosPersonas.ClearSelection();
        }

        private void btnOrdenarAscendenteEdad_Click(object sender, EventArgs e)
        {
            llenarGrilla(repositorio.ordenarAscendentePorEdad());
            datosPersonas.ClearSelection();
        }

        private void btnOrdenarDescendenteEdad_Click(object sender, EventArgs e)
        {
            llenarGrilla(repositorio.ordenarDescendentePorEdad());
            datosPersonas.ClearSelection();
        }

        private void cmboxFiltrarPorSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sexo sexo = (Sexo)cmboxFiltrarPorSexo.SelectedIndex;
            llenarGrilla(repositorio.filtrarPorSexo(sexo));
            datosPersonas.ClearSelection();
        }

        private void cmboxFiltrarPorLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Localidad localidad = (Localidad)cmboxFiltrarPorLocalidad.SelectedIndex;
            llenarGrilla(repositorio.filtrarPorLocalidad(localidad));
            datosPersonas.ClearSelection();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            datosPersonas.ClearSelection();
        }

        private void btnOrdenarAscendenteApellido_Click(object sender, EventArgs e)
        {
            llenarGrilla(repositorio.ordenarAscendentePorApellido());
            datosPersonas.ClearSelection();
        }

        private void btnOrdenarDescendenteApellido_Click(object sender, EventArgs e)
        {
            llenarGrilla(repositorio.ordenarDescendentePorApellido());
            datosPersonas.ClearSelection();
        }
    }
}
