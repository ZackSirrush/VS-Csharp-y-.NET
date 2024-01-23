//Universidad Abierta y a Distancia de M�xico
//Desarrollo de software
//Programaci�n Net III
//Unidad 2. Dise�o de interfaces mediante .NET
//Actividad 1. Dise�o de interfaces
//Angel Isaac Nabor Torres
//ES1921013978
//Docente. Juan Daniel Oliva V�zquez


using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace DPRN3_U2_A1_ANNT
{
    public partial class Rvehiculo : Form
    {
        Vehiculo nv;//Objeto de veh�culo para usas sus m�todos
        byte[] imagenByte; //Declara un arreglo para guardar la imagen
        public Rvehiculo()
        {
            nv = new Vehiculo();
            InitializeComponent(); //Inicializa los componentes del formulario
            dataGridView1.DataSource = nv.Mostrar().Tables[0]; //Muestra la tabla al inicio del programa
            dataGridView1.Columns[0].HeaderText = "No Serie"; //T�tulos de columnas
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Fecha adquisici�n";
            dataGridView1.Columns[3].HeaderText = "Marca";
            dataGridView1.Columns[4].HeaderText = "Modelo";
            dataGridView1.Columns[5].HeaderText = "Fecha fabrica";
            dataGridView1.Columns[6].HeaderText = "Foto";
            dataGridView1.Columns[7].HeaderText = "Color";
            dataGridView1.Columns[8].HeaderText = "Verificaci�n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addFoto_Click(object sender, EventArgs e) //Bot�n agregar foto
        {

            OpenFileDialog abrir = new OpenFileDialog(); //Seleciona un archivo
            abrir.Title = "Seleccionar imagen";
            abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP|PNG(*.PNG)|*.PNG"; //Filtra los archivos por su extensi�n
            if(abrir.ShowDialog() == DialogResult.OK) //Muestra los resultados
            {
                pbFoto.Image = Image.FromStream(abrir.OpenFile()); //Coloca el resultado seleccionado en el espacio de la imagen
                MemoryStream memoria = new MemoryStream();
                pbFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png); //Convierte la imagen en formato png
                imagenByte= memoria.ToArray(); //Almacena la imagen en memoria
            }

        }

        private void showBttn_Click(object sender, EventArgs e) //Bot�n mostrar que actualiza los datos de la tabla cuando se ingresa un nuevo registro
        {
            dataGridView1.DataSource = nv.Mostrar().Tables[0]; //Muestra la tabla invocando el m�todo Mostrar
            dataGridView1.Columns[0].HeaderText = "No Serie";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Fecha adquisici�n";
            dataGridView1.Columns[3].HeaderText = "Marca";
            dataGridView1.Columns[4].HeaderText = "Modelo";
            dataGridView1.Columns[5].HeaderText = "Fecha fabrica";
            dataGridView1.Columns[6].HeaderText = "Foto";
            dataGridView1.Columns[7].HeaderText = "Color";
            dataGridView1.Columns[8].HeaderText = "Verificaci�n"; //T�tulos de columna

        }

        private void addBD_Click(object sender, EventArgs e) //Bot�n para a�adir a la base de datos
        {
            nv.Agregar(RecuperarInformaci�n());
            LimpiarCampos(); //Limpia los datos del TextBox y dem�s elementos
        }

        private Vehiculo RecuperarInformaci�n() //Recupera la informaci�n ingresada en los campos de la interfaz
        {
            Vehiculo nvehiculo = new Vehiculo(); //Objeto que llama a la clase veh�culo

            nvehiculo.Serie=tbSerie.Text; //Almacena la informaci�n ingresada en los getters y setters
            nvehiculo.Tipo = cbTipo.Text;
            nvehiculo.FAdq = dtpFadqui.Value.Date;
            nvehiculo.Marca = tbMarca.Text;
            nvehiculo.Modelo = tbModelo.Text;
            nvehiculo.FFabric = dtpFfabric.Value.Date;
            nvehiculo.Foto = imagenByte;
            nvehiculo.Color = tbColor.Text;
            nvehiculo.Verif = cbVerif.Text;

            return nvehiculo; //Devuelve los datos guardados

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex; //Selecciona la casilla marcada por el usuario

            dataGridView1.ClearSelection(); //Limpia la selecci�n

            if (indice >= 0) //Si la casilla seleccionada es mayor a 1
            {
                
                tbSerie.Text = dataGridView1.Rows[indice].Cells[0].Value.ToString(); //Recupera el valor de la fila seleccionada en la celda indicada
                cbTipo.Text = dataGridView1.Rows[indice].Cells[1].Value.ToString(); //y lo coloca en el apartado indicado
                dtpFadqui.Text = dataGridView1.Rows[indice].Cells[2].Value.ToString();
                tbMarca.Text = dataGridView1.Rows[indice].Cells[3].Value.ToString();
                tbModelo.Text = dataGridView1.Rows[indice].Cells[4].Value.ToString();
                dtpFfabric.Text = dataGridView1.Rows[indice].Cells[5].Value.ToString();
                pbFoto.Image = ActualizarImagen(); //Invoca el m�todo actualizar imagen
               
                tbColor.Text = dataGridView1.Rows[indice].Cells[7].Value.ToString();
                cbVerif.Text = dataGridView1.Rows[indice].Cells[8].Value.ToString();
            }
            
        }

        public Image ActualizarImagen() //M�todo actualizar imagen
        {
            byte[] imgBytes = new byte[0]; //Invoca un arreglo de bytes
            if (dataGridView1.CurrentRow.Cells["Foto"].Value != null) //Si la selecci�n del recuadro no es null
            {
                imgBytes = (byte[])dataGridView1.CurrentRow.Cells["Foto"].Value; //Selecciona la imagen de la fila que marque el usuario
                MemoryStream mst = new MemoryStream(imgBytes); //Almacena el valor en memoria
                return Image.FromStream(mst); //Devuelve el valor buscado
            }
            else
            {
                return null; //si falla devuelve null
            }
        }

        public void LimpiarCampos() //M�todo para limpiar los elementos del formulario
        {
            tbSerie.Text = "";
            cbTipo.Text = "";
            dtpFadqui.Text = "01/01/2000";
            tbMarca.Text = "";
            tbModelo.Text = "";
            dtpFfabric.Text = "01/01/2000";
            pbFoto.Image = null;
            tbColor.Text = "";
            cbVerif.Text = "";
        }

    }
}