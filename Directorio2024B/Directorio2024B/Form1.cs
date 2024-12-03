using MongoDB.Driver;
using System.ComponentModel;
using System.Windows.Forms;
using MongoDB.Bson;

namespace Directorio2024B
{
    public partial class Form1 : Form
    {
        //private BindingList<Persona> personas = new BindingList<Persona>();

        // inicializar el objeto
        private Persona persona = new Persona();

        private int edit_index = -1; // -1 indica que no se esta haciendo una modificacion porque un arreglo no tiene el campo -1
                                     // cualquier otro numero, indica una posicion en la lista 

        private MongoHelper mongo;

        public Form1(MongoHelper mongo)
        {
            InitializeComponent();
            this.mongo = mongo;
            actualizarTabla();
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTel.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var idSeleccionado = dgvDatos.SelectedCells[0].Value.ToString();
                var filter = Builders<Persona>.Filter.Eq("_id", ObjectId.Parse(idSeleccionado));
                var result = await mongo.colPersona.Find(filter).FirstOrDefaultAsync();

                if (result != null)
                {
                    //Persona people = result[0];

                    persona = result;

                    txtNombre.Text = persona.nombre;
                    txtApellido.Text = persona.apellido;
                    txtTel.Text = persona.telefono;
                    txtCorreo.Text = persona.correo;
                    

                    edit_index = 1; // modo edicion de acuerdo a la posicion 
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Revisa tu conexion");
            }

            
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_index != -1)
                {
                    // remover el usuario en la posicion indicada
                    var filter = Builders<Persona>.Filter.Eq("_id",persona.Id);
                    await mongo.colPersona.DeleteOneAsync(filter);

                    edit_index = -1; // salir del modo edicion 
                    actualizarTabla();
                    LimpiarCampos();
                }
                else
                {
                    // mensaje al usuario 
                    MessageBox.Show("Para eliminar primero selecciona una fila con doble click sobre la misma.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Revisa tu conexion");
            }

            

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona pers = new Persona();
            pers.nombre = txtNombre.Text;
            pers.apellido = txtApellido.Text;
            pers.telefono = txtTel.Text;
            pers.correo = txtCorreo.Text;

            try
            {
                if (edit_index != -1)
                {
                    // agregar a la persona en una posicion en especifico 
                    pers.Id = persona.Id;

                    // crear un filtro de tipo persona
                    var filtro = Builders<Persona>.Filter.Eq("_id",pers.Id);

                    // actualizar los campos
                    var update = Builders<Persona>.Update.Set("nombre", pers.nombre)
                        .Set("apellido", pers.apellido)
                        .Set("telefono", pers.telefono)
                        .Set("correo", pers.correo);

                    // actualizar un solo usuario en la BD | si se quiere actualizar varios se usa UpdateMany
                    await mongo.colPersona.UpdateOneAsync(filtro, update);
                     
                    // resetear el objeto para que no se quede con los mismos datos 
                    persona = new Persona();

                    edit_index = -1; // se vuelve a inicializar a -1 para que pueda añadir mas personas
                }
                else
                {
                    // nueva persona 
                    // insertar de forma asincrona 
                    await mongo.colPersona.InsertOneAsync(pers);
                    // await es para que se espere a que se termine de ejecutar para continuar con el codigo - poner async
                }

                actualizarTabla();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Revisa tu conexion");
            }

            
        }

        private async void actualizarTabla()
        {
            // async es asincrona, es decir, que viene de un servidor en otra locacion

            try
            {
                // que se muestren los elementos en la pantalla 
                dgvDatos.DataSource = null; // primero la limpiamos para que muestre correctaente el contenido 
                dgvDatos.DataSource = await mongo.colPersona.Find(new BsonDocument()).ToListAsync();
                dgvDatos.ClearSelection(); // que limpie cuando nosotros seleccionamos un usuario 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Revisa tu conexion");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edit_index = -1;
            LimpiarCampos();
            actualizarTabla();
        }
    }

}
