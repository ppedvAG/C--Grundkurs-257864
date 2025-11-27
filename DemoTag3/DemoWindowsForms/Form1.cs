namespace DemoWindowsForms
{
	public partial class Form1 : Form
	{

		enum Rechenoperation
		{
			Addition = 1, Subtraktion, Multiplikation, Division
		}
		Rechenoperation rechenoperation;

		private static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
		{
			switch (operation)
			{
				case Rechenoperation.Addition:
					return (zahl1 + zahl2);
				case Rechenoperation.Subtraktion:
					return zahl1 - zahl2;
				case Rechenoperation.Multiplikation:
					return zahl1 * zahl2;
				case Rechenoperation.Division:
					if (zahl2 == 0)
					{
						MessageBox.Show("Division dur 0 nicht erlaubt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return double.NaN;
					}
					else
					{
						return zahl1 / zahl2;
					}
			}
			return double.NaN;
		}
		public Form1()
		{
			rechenoperation = Rechenoperation.Addition;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double zahl1;
			double zahl2;

			bool isZahl1Valide = double.TryParse(txtZahl1.Text, out zahl1);
			if (!isZahl1Valide)
			{
				MessageBox.Show("Die erste Zahl ist ungültig. Bitte eine gültige Zahl eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!double.TryParse(txtZahl2.Text, out zahl2))
			{
				MessageBox.Show("Die zweite Zahl ist ungültig. Bitte eine gültige Zahl eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			double ergebnis = Berechne(zahl1, zahl2, rechenoperation);

			lblErgebnis.Text = $"{ergebnis}";

		}

		private void rbAddiern_CheckedChanged(object sender, EventArgs e)
		{
			if (rbAddiern.Checked)
			{
				lblPlus.Text = "+";
				rechenoperation = Rechenoperation.Addition;
			}
			
		}

		private void rbSubtrahieren_CheckedChanged(object sender, EventArgs e)
		{
			if (rbSubtrahieren.Checked)
			{
				lblPlus.Text = "-";
				rechenoperation = Rechenoperation.Subtraktion;
			}
			
		}

		private void rbMulitplizieren_CheckedChanged(object sender, EventArgs e)
		{
			if (rbMulitplizieren.Checked)
			{
				lblPlus.Text = "*";
				rechenoperation = Rechenoperation.Multiplikation;
			}
			
		}

		private void rbDividieren_CheckedChanged(object sender, EventArgs e)
		{
			
			if (rbDividieren.Checked)
			{
				lblPlus.Text = "/";
				rechenoperation = Rechenoperation.Division;
			}
		}
	}
}
