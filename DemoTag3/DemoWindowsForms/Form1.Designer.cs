namespace DemoWindowsForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnBerechnen = new Button();
			lblZahl1 = new Label();
			txtZahl1 = new TextBox();
			txtZahl2 = new TextBox();
			lblZahl2 = new Label();
			lblPlus = new Label();
			lblErgebnis = new Label();
			gbRechenoperation = new GroupBox();
			rbDividieren = new RadioButton();
			rbMulitplizieren = new RadioButton();
			rbSubtrahieren = new RadioButton();
			rbAddiern = new RadioButton();
			gbRechenoperation.SuspendLayout();
			SuspendLayout();
			// 
			// btnBerechnen
			// 
			btnBerechnen.Font = new Font("Segoe UI", 18F);
			btnBerechnen.Location = new Point(167, 238);
			btnBerechnen.Name = "btnBerechnen";
			btnBerechnen.Size = new Size(307, 124);
			btnBerechnen.TabIndex = 0;
			btnBerechnen.Text = "Berechnen";
			btnBerechnen.UseVisualStyleBackColor = true;
			btnBerechnen.Click += button1_Click;
			// 
			// lblZahl1
			// 
			lblZahl1.AutoSize = true;
			lblZahl1.Location = new Point(153, 114);
			lblZahl1.Name = "lblZahl1";
			lblZahl1.Size = new Size(167, 32);
			lblZahl1.TabIndex = 1;
			lblZahl1.Text = "Zahl Eingeben";
			// 
			// txtZahl1
			// 
			txtZahl1.Location = new Point(153, 149);
			txtZahl1.Name = "txtZahl1";
			txtZahl1.Size = new Size(200, 39);
			txtZahl1.TabIndex = 2;
			// 
			// txtZahl2
			// 
			txtZahl2.Location = new Point(417, 149);
			txtZahl2.Name = "txtZahl2";
			txtZahl2.Size = new Size(200, 39);
			txtZahl2.TabIndex = 4;
			// 
			// lblZahl2
			// 
			lblZahl2.AutoSize = true;
			lblZahl2.Location = new Point(417, 114);
			lblZahl2.Name = "lblZahl2";
			lblZahl2.Size = new Size(167, 32);
			lblZahl2.TabIndex = 3;
			lblZahl2.Text = "Zahl Eingeben";
			// 
			// lblPlus
			// 
			lblPlus.AutoSize = true;
			lblPlus.Location = new Point(368, 149);
			lblPlus.Name = "lblPlus";
			lblPlus.Size = new Size(30, 32);
			lblPlus.TabIndex = 5;
			lblPlus.Text = "+";
			// 
			// lblErgebnis
			// 
			lblErgebnis.AutoSize = true;
			lblErgebnis.Location = new Point(685, 156);
			lblErgebnis.Name = "lblErgebnis";
			lblErgebnis.Size = new Size(105, 32);
			lblErgebnis.TabIndex = 6;
			lblErgebnis.Text = "Ergebnis";
			// 
			// gbRechenoperation
			// 
			gbRechenoperation.Controls.Add(rbDividieren);
			gbRechenoperation.Controls.Add(rbMulitplizieren);
			gbRechenoperation.Controls.Add(rbSubtrahieren);
			gbRechenoperation.Controls.Add(rbAddiern);
			gbRechenoperation.Location = new Point(167, 525);
			gbRechenoperation.Name = "gbRechenoperation";
			gbRechenoperation.Size = new Size(403, 376);
			gbRechenoperation.TabIndex = 7;
			gbRechenoperation.TabStop = false;
			gbRechenoperation.Text = "Rechenoparation";
			// 
			// rbDividieren
			// 
			rbDividieren.AutoSize = true;
			rbDividieren.Location = new Point(16, 222);
			rbDividieren.Name = "rbDividieren";
			rbDividieren.Size = new Size(154, 36);
			rbDividieren.TabIndex = 3;
			rbDividieren.Text = "Dividieren";
			rbDividieren.UseVisualStyleBackColor = true;
			rbDividieren.CheckedChanged += rbDividieren_CheckedChanged;
			// 
			// rbMulitplizieren
			// 
			rbMulitplizieren.AutoSize = true;
			rbMulitplizieren.Location = new Point(16, 165);
			rbMulitplizieren.Name = "rbMulitplizieren";
			rbMulitplizieren.Size = new Size(192, 36);
			rbMulitplizieren.TabIndex = 2;
			rbMulitplizieren.Text = "Multiplizieren";
			rbMulitplizieren.UseVisualStyleBackColor = true;
			rbMulitplizieren.CheckedChanged += rbMulitplizieren_CheckedChanged;
			// 
			// rbSubtrahieren
			// 
			rbSubtrahieren.AutoSize = true;
			rbSubtrahieren.Location = new Point(16, 104);
			rbSubtrahieren.Name = "rbSubtrahieren";
			rbSubtrahieren.Size = new Size(182, 36);
			rbSubtrahieren.TabIndex = 1;
			rbSubtrahieren.Text = "Subtrahieren";
			rbSubtrahieren.UseVisualStyleBackColor = true;
			rbSubtrahieren.CheckedChanged += rbSubtrahieren_CheckedChanged;
			// 
			// rbAddiern
			// 
			rbAddiern.AutoSize = true;
			rbAddiern.Checked = true;
			rbAddiern.Location = new Point(16, 42);
			rbAddiern.Name = "rbAddiern";
			rbAddiern.Size = new Size(129, 36);
			rbAddiern.TabIndex = 0;
			rbAddiern.TabStop = true;
			rbAddiern.Text = "Addiern";
			rbAddiern.UseVisualStyleBackColor = true;
			rbAddiern.CheckedChanged += rbAddiern_CheckedChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1725, 972);
			Controls.Add(gbRechenoperation);
			Controls.Add(lblErgebnis);
			Controls.Add(lblPlus);
			Controls.Add(txtZahl2);
			Controls.Add(lblZahl2);
			Controls.Add(txtZahl1);
			Controls.Add(lblZahl1);
			Controls.Add(btnBerechnen);
			Name = "Form1";
			Text = "Form1";
			gbRechenoperation.ResumeLayout(false);
			gbRechenoperation.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBerechnen;
		private Label lblZahl1;
		private TextBox txtZahl1;
		private TextBox txtZahl2;
		private Label lblZahl2;
		private Label lblPlus;
		private Label lblErgebnis;
		private GroupBox gbRechenoperation;
		private RadioButton rbDividieren;
		private RadioButton rbMulitplizieren;
		private RadioButton rbSubtrahieren;
		private RadioButton rbAddiern;
	}
}
