namespace Ejercicio_2
{
    /// <summary>
    /// Hacer una calculadora que permita las siguientes operaciones:
    /// Sumar, restar, multiplicar y dividir
    /// </summary>
    public partial class Form1 : Form
    {
        // Contendrá el acumulado de las operaciones que se
        // mostrará en la caja de texto 
        public decimal Acumulado { get; set; }

        // Al pulsar un operador, se meterá lo que haya en txtResultado
        // en esta propiedad
        public decimal Numero1 { get; set; }

        // Cuando se pulse un operador, se guardará en esta propiedad
        public Operador? Operacion { get; set; }

        public Form1()
        {
            InitializeComponent();

            // Inicializar las cajas de texto de la calculadora
            txtResultado.Text = String.Empty;
            txtAcumulado.Text = "0";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón CE
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            txtAcumulado.Text = "0";
            Numero1 = 0;
            Acumulado = 0;
        }

        #region Eventos de botones numericos

        /// <summary>
        /// Evento que se lanza al pulsar el botón 1
        /// </summary>
        private void btn1_Click(object sender, EventArgs e)
        {
            // Si la caja de texto del resultado está vacía
            // se asigna directamente el valor 1, si no, se
            // añade el 1 a lo que tenga la caja de texto
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "1";
            else
                txtResultado.Text += "1";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 2
        /// </summary>
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "2";
            else
                txtResultado.Text += "2";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 3
        /// </summary>
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "3";
            else
                txtResultado.Text += "3";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 4
        /// </summary>
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "4";
            else
                txtResultado.Text += "4";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 5
        /// </summary>
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "5";
            else
                txtResultado.Text += "5";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 6
        /// </summary>
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "6";
            else
                txtResultado.Text += "6";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 7
        /// </summary>
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "7";
            else
                txtResultado.Text += "7";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 8
        /// </summary>
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "8";
            else
                txtResultado.Text += "8";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 9
        /// </summary>
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "9";
            else
                txtResultado.Text += "9";
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón 0
        /// </summary>
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "0";
            else
                txtResultado.Text += "0";
        }

        #endregion

        /// <summary>
        /// Evento que se lanza al pulsar el botón del decimal
        /// </summary>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Si la caja de texto está vacía, la rellena con "0,",
            // si no, añadirá la coma del decimal a lo que tenga
            // la caja de texto.
            // A partir de ese momento, todo lo que se añada serán
            // decimales
            if (txtResultado.Text == String.Empty)
                txtResultado.Text = "0,";
            else
            {
                if (!txtResultado.Text.Contains(","))
                    txtResultado.Text += ",";
            }
        }

        #region Eventos de los botones de los operadores

        /// <summary>
        /// Evento que se lanza al pulsar el botón del operador +
        /// </summary>
        private void btnMas_Click(object sender, EventArgs e)
        {
            // Si la caja de texto tiene contenido, entra al IF
            if (txtResultado.Text != String.Empty)
            {
                // Asigna el operador +
                Operacion = Operador.Mas;

                // Convierte en número lo que haya en la caja de texto
                // y lo mete en Numero1
                Numero1 = Convert.ToDecimal(txtResultado.Text);

                // Incrementa Acumulado con el valor de Numero1
                Acumulado += Numero1;

                // Escribe el acumulado en txtAcumulado y limpia
                // txtResultado
                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;
            }
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón del operador -
        /// </summary>
        private void btnMenos_Click(object sender, EventArgs e)
        {
            // Si la caja de texto tiene contenido, entra al IF
            if (txtResultado.Text != String.Empty)
            {
                // Asigna el operador -
                Operacion = Operador.Menos;

                // Convierte en número lo que haya en la caja de texto
                // y lo mete en Numero1
                Numero1 = Convert.ToDecimal(txtResultado.Text);

                // Si hay un 0 en acumulado, asigna directamente el 
                // valor de Numero1, si no, resta Numero1 a lo que haya
                // en acumulado
                if (txtAcumulado.Text == "0")
                    Acumulado = Numero1;
                else
                    Acumulado -= Numero1;

                // Escribe el acumulado en txtAcumulado y limpia
                // txtResultado
                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;
            }
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón del operador *
        /// </summary>
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Si la caja de texto tiene contenido, entra al IF
            if (txtResultado.Text != String.Empty)
            {
                // Asigna el operador *
                Operacion = Operador.Por;

                // Convierte en número lo que haya en la caja de texto
                // y lo mete en Numero1
                Numero1 = Convert.ToDecimal(txtResultado.Text);

                // Si hay un 0 en acumulado, asigna directamente el 
                // valor de Numero1, si no, multiplica Numero1 con lo 
                // que haya en acumulado
                if (Acumulado != 0)
                    Acumulado *= Numero1;
                else
                    Acumulado = Numero1;

                // Escribe el acumulado en txtAcumulado y limpia
                // txtResultado
                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;
            }
        }

        /// <summary>
        /// Evento que se lanza al pulsar el botón del operador /
        /// </summary>
        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Si la caja de texto tiene contenido, entra al IF
            if (txtResultado.Text != String.Empty)
            {
                // Asigna el operador /
                Operacion = Operador.Dividir;

                // Convierte en número lo que haya en la caja de texto
                // y lo mete en Numero1
                Numero1 = Convert.ToDecimal(txtResultado.Text);

                // Si hay un 0 en acumulado, asigna directamente el 
                // valor de Numero1, si no, divide lo que haya
                // en acumulado por Numero1
                if (Acumulado != 0)
                    Acumulado /= Numero1;
                else
                    Acumulado = Numero1;

                // Escribe el acumulado en txtAcumulado y limpia
                // txtResultado
                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;
            }
        }

        #endregion

        /// <summary>
        /// Evento que se lanza al pulsar el botón del =
        /// </summary>
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Si la caja de texto tiene contenido, entra al IF
            if (txtResultado.Text != String.Empty)
            {
                // Convierte en número lo que haya en la caja de texto
                // y lo mete en Numero1
                Numero1 = Convert.ToDecimal(txtResultado.Text);

                // En función de la última operación,
                // seleccionada, se calcula el acumulado
                switch (Operacion)
                {
                    case Operador.Mas:
                        Acumulado += Numero1;
                        break;
                    case Operador.Menos:
                        Acumulado -= Numero1;
                        break;
                    case Operador.Por:
                        Acumulado *= Numero1;
                        break;
                    case Operador.Dividir:
                        Acumulado /= Numero1;
                        break;
                    default:
                        break;
                }

                // Ponemos a 0 la caja de texto del acumulado
                txtAcumulado.Text = "0";
                // Ponemos el valor de la propiedad Acumulado en la
                // caja de texto del resultado
                txtResultado.Text = Acumulado.ToString();
                // Ponemos a 0 la propiedad Acumulado, Numero1 y 
                //`ponemos la propiedad Operador a NULL
                Acumulado = 0;
                Operacion = null;
                Numero1 = 0;
            }

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            // Creamos un nuevo objeto de la clase Form1
            Form1 pipo = new Form1();
            // Mostramos el objeto para que sea visible por el usuario
            pipo.Show();
        }
    }
}