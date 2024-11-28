using ClosedXML.Excel;
using System.Windows.Forms;

namespace AlgoritmoMonteCarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerar_Click(object sender, EventArgs e)
        {
            string algoritmo = comboBoxAlgoritmo.SelectedItem.ToString();
            int cantidad = int.Parse(textBoxCantidad.Text);
            List<int> numeros = new();

            if (algoritmo == "Congruencial Lineal")
            {
                int semilla = int.Parse(textBoxSemilla.Text);
                int a = int.Parse(textBoxA.Text);
                int c = int.Parse(textBoxC.Text);
                int m = int.Parse(textBoxM.Text);

                Congruencial generador = new(semilla, a, c, m);
                var numerosGenerados = generador.GenerarNumeros(cantidad);
                numeros = numerosGenerados;
            }
            else if (algoritmo == "No Congruencial")
            {
                int semilla = int.Parse(textBoxSemilla.Text);
                int n = int.Parse(textBoxNDigitos.Text);
                NoCongruencial generador = new(semilla);
                var numerosGenerados = generador.GenerarNumeros(cantidad, n);
                numeros = numerosGenerados;
            }

            GuardarEnExcel(numeros);
        }

        private void GuardarEnExcel(List<int> numeros)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos Excel|*.xlsx";
                saveFileDialog.Title = "Guardar archivo como";
                saveFileDialog.FileName = "NumerosAleatorios.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;

                    using var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Numeros Aleatorios");
                    worksheet.Cell(1, 1).Value = "Números";

                    for (int i = 0; i < numeros.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = numeros[i];
                    }

                    workbook.SaveAs(rutaArchivo);

                    MessageBox.Show("Archivo generado exitosamente en: " + rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se seleccionó una ubicación para guardar el archivo.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
