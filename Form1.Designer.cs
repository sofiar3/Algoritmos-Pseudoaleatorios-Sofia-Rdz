namespace AlgoritmoMonteCarlo
{
    partial class Form1
    {
        private ComboBox comboBoxAlgoritmo;
        private TextBox textBoxSemilla, textBoxA, textBoxC, textBoxM, textBoxCantidad, textBoxNDigitos;
        private Button buttonGenerar;
        private Label labelSemilla, labelCantidad, labelParametrosCongruencial, labelA, labelC, labelM, labelParametrosNoCongruencial, labelNDigitos;

        private void InitializeComponent()
        {
            comboBoxAlgoritmo = new ComboBox();
            textBoxSemilla = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxA = new TextBox();
            textBoxC = new TextBox();
            textBoxM = new TextBox();
            textBoxNDigitos = new TextBox();
            buttonGenerar = new Button();
            labelSemilla = new Label();
            labelCantidad = new Label();
            labelParametrosCongruencial = new Label();
            labelA = new Label();
            labelC = new Label();
            labelM = new Label();
            labelParametrosNoCongruencial = new Label();
            labelNDigitos = new Label();

            SuspendLayout();

            comboBoxAlgoritmo.Items.AddRange(new object[] {
                "Congruencial Lineal",
                "No Congruencial"
            });
            comboBoxAlgoritmo.Location = new Point(30, 20);
            comboBoxAlgoritmo.Name = "comboBoxAlgoritmo";
            comboBoxAlgoritmo.Size = new Size(250, 23);

            labelSemilla.Text = "Semilla (X0):";
            labelSemilla.Location = new Point(30, 60);
            labelSemilla.Size = new Size(100, 20);
            textBoxSemilla.Location = new Point(150, 60);
            textBoxSemilla.Size = new Size(130, 20);

            labelCantidad.Text = "Cantidad:";
            labelCantidad.Location = new Point(30, 90);
            labelCantidad.Size = new Size(100, 20);
            textBoxCantidad.Location = new Point(150, 90);
            textBoxCantidad.Size = new Size(130, 20);

            labelParametrosCongruencial.Text = "Parámetros del método Congruencial:";
            labelParametrosCongruencial.Location = new Point(30, 130);
            labelParametrosCongruencial.Size = new Size(250, 20);

            labelA.Text = "A:";
            labelA.Location = new Point(30, 160);
            labelA.Size = new Size(100, 20);
            textBoxA.Location = new Point(150, 160);
            textBoxA.Size = new Size(130, 20);

            labelC.Text = "C:";
            labelC.Location = new Point(30, 190);
            labelC.Size = new Size(100, 20);
            textBoxC.Location = new Point(150, 190);
            textBoxC.Size = new Size(130, 20);

            labelM.Text = "M:";
            labelM.Location = new Point(30, 220);
            labelM.Size = new Size(100, 20);
            textBoxM.Location = new Point(150, 220);
            textBoxM.Size = new Size(130, 20);

            labelParametrosNoCongruencial.Text = "Parámetros del método No Congruencial:";
            labelParametrosNoCongruencial.Location = new Point(30, 260);
            labelParametrosNoCongruencial.Size = new Size(300, 20);

            labelNDigitos.Text = "N° de Dígitos:";
            labelNDigitos.Location = new Point(30, 290);
            labelNDigitos.Size = new Size(100, 20);
            textBoxNDigitos.Location = new Point(150, 290);
            textBoxNDigitos.Size = new Size(130, 20);

            buttonGenerar.Text = "Generar";
            buttonGenerar.Location = new Point(30, 330);
            buttonGenerar.Size = new Size(250, 30);
            buttonGenerar.Click += ButtonGenerar_Click;

            Controls.Add(comboBoxAlgoritmo);
            Controls.Add(labelSemilla);
            Controls.Add(textBoxSemilla);
            Controls.Add(labelCantidad);
            Controls.Add(textBoxCantidad);
            Controls.Add(labelParametrosCongruencial);
            Controls.Add(labelA);
            Controls.Add(textBoxA);
            Controls.Add(labelC);
            Controls.Add(textBoxC);
            Controls.Add(labelM);
            Controls.Add(textBoxM);
            Controls.Add(labelParametrosNoCongruencial);
            Controls.Add(labelNDigitos);
            Controls.Add(textBoxNDigitos);
            Controls.Add(buttonGenerar);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Text = "Generadores Pseudoaleatorios";
            ResumeLayout(false);
        }
    }
}
