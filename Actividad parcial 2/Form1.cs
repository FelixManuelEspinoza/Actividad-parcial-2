namespace Actividad_parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Persona unapersona= new Persona();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Ingrese solo numeros ");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (TB_DNI.Text.Length < 7 || TB_DNI .Text.Length > 8)
            {
                MessageBox.Show(" El DNI debe tener 8 numeros");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lbl_edad.Text = unapersona.EdadPersona().ToString();
        }

        private void TB_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Persona_Click(object sender, EventArgs e)
        {
            unapersona.propNombre = TB_Nombre.Text;
            unapersona.propDNI = long.Parse(TB_DNI.Text);
            unapersona.propFechaDeNacimiento = DateTime.Parse(TB_FechNac.Text);

        }
    }
}