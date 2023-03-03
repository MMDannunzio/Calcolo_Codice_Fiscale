namespace Calcolo_Codice_Fiscale
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
            BTX_Calcolo = new Button();
            BR_Maschio = new RadioButton();
            BR_Femmina = new RadioButton();
            Comune = new ComboBox();
            DT_Nascita = new DateTimePicker();
            TX_Nome = new TextBox();
            TX_Cognome = new TextBox();
            SuspendLayout();
            // 
            // BTX_Calcolo
            // 
            BTX_Calcolo.Location = new Point(286, 338);
            BTX_Calcolo.Name = "BTX_Calcolo";
            BTX_Calcolo.Size = new Size(200, 70);
            BTX_Calcolo.TabIndex = 0;
            BTX_Calcolo.Text = "Calcolo";
            BTX_Calcolo.UseVisualStyleBackColor = true;
            BTX_Calcolo.Click += Button1_Click;
            // 
            // BR_Maschio
            // 
            BR_Maschio.AutoSize = true;
            BR_Maschio.Location = new Point(459, 196);
            BR_Maschio.Name = "BR_Maschio";
            BR_Maschio.Size = new Size(85, 24);
            BR_Maschio.TabIndex = 2;
            BR_Maschio.TabStop = true;
            BR_Maschio.Text = "maschio";
            BR_Maschio.UseVisualStyleBackColor = true;
            BR_Maschio.CheckedChanged += BR_Maschio_CheckedChanged;
            // 
            // BR_Femmina
            // 
            BR_Femmina.AutoSize = true;
            BR_Femmina.Location = new Point(592, 196);
            BR_Femmina.Name = "BR_Femmina";
            BR_Femmina.Size = new Size(91, 24);
            BR_Femmina.TabIndex = 3;
            BR_Femmina.TabStop = true;
            BR_Femmina.Text = "Femmina";
            BR_Femmina.UseVisualStyleBackColor = true;
            BR_Femmina.CheckedChanged += BR_Femmina_CheckedChanged;
            // 
            // Comune
            // 
            Comune.FormattingEnabled = true;
            Comune.Location = new Point(308, 266);
            Comune.Name = "Comune";
            Comune.Size = new Size(151, 28);
            Comune.TabIndex = 4;
            Comune.SelectedIndexChanged += Comune_SelectedIndexChanged;
            // 
            // DT_Nascita
            // 
            DT_Nascita.Location = new Point(66, 193);
            DT_Nascita.Name = "DT_Nascita";
            DT_Nascita.Size = new Size(250, 27);
            DT_Nascita.TabIndex = 5;
            DT_Nascita.ValueChanged += DT_Nascita_ValueChanged;
            // 
            // TX_Nome
            // 
            TX_Nome.Location = new Point(66, 62);
            TX_Nome.Name = "TX_Nome";
            TX_Nome.Size = new Size(545, 27);
            TX_Nome.TabIndex = 6;
            TX_Nome.TextChanged += TX_Nome_TextChanged;
            // 
            // TX_Cognome
            // 
            TX_Cognome.Location = new Point(66, 113);
            TX_Cognome.Name = "TX_Cognome";
            TX_Cognome.Size = new Size(545, 27);
            TX_Cognome.TabIndex = 7;
            TX_Cognome.TextChanged += TX_Cognome_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BR_Femmina);
            Controls.Add(BR_Maschio);
            Controls.Add(TX_Cognome);
            Controls.Add(TX_Nome);
            Controls.Add(DT_Nascita);
            Controls.Add(Comune);
            Controls.Add(BTX_Calcolo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTX_Calcolo;
        private RadioButton BR_Maschio;
        private RadioButton BR_Femmina;
        private ComboBox Comune;
        private DateTimePicker DT_Nascita;
        private TextBox TX_Nome;
        private TextBox TX_Cognome;
    }
}