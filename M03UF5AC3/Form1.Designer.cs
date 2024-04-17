namespace M03UF5AC3
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
            components = new System.ComponentModel.Container();
            grpPrincipal = new GroupBox();
            txtPoblacio = new TextBox();
            txtTotal = new TextBox();
            txtCapita = new TextBox();
            txtEconomiques = new TextBox();
            txtDomesticXarxa = new TextBox();
            lblTotal = new Label();
            lblCapita = new Label();
            lblEconomiques = new Label();
            lblDomesticXarxa = new Label();
            cmbComarca = new ComboBox();
            cmbAny = new ComboBox();
            lblPoblacio = new Label();
            lblComarca = new Label();
            lblAny = new Label();
            btnNetejar = new Button();
            btnGuardar = new Button();
            dgvComarques = new DataGridView();
            errAny = new ErrorProvider(components);
            errComarca = new ErrorProvider(components);
            errPoblacio = new ErrorProvider(components);
            errDomesticXarxa = new ErrorProvider(components);
            errEconomiques = new ErrorProvider(components);
            errCapita = new ErrorProvider(components);
            errTotal = new ErrorProvider(components);
            grpEstadistiques = new GroupBox();
            lblBaix = new Label();
            lblAlt = new Label();
            lblMitja = new Label();
            lblBoolPob = new Label();
            lblLow = new Label();
            lblHigh = new Label();
            lblConsumMitja = new Label();
            lblPob = new Label();
            grpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComarques).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errAny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errComarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errPoblacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDomesticXarxa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errEconomiques).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errCapita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTotal).BeginInit();
            grpEstadistiques.SuspendLayout();
            SuspendLayout();
            // 
            // grpPrincipal
            // 
            grpPrincipal.Controls.Add(txtPoblacio);
            grpPrincipal.Controls.Add(txtTotal);
            grpPrincipal.Controls.Add(txtCapita);
            grpPrincipal.Controls.Add(txtEconomiques);
            grpPrincipal.Controls.Add(txtDomesticXarxa);
            grpPrincipal.Controls.Add(lblTotal);
            grpPrincipal.Controls.Add(lblCapita);
            grpPrincipal.Controls.Add(lblEconomiques);
            grpPrincipal.Controls.Add(lblDomesticXarxa);
            grpPrincipal.Controls.Add(cmbComarca);
            grpPrincipal.Controls.Add(cmbAny);
            grpPrincipal.Controls.Add(lblPoblacio);
            grpPrincipal.Controls.Add(lblComarca);
            grpPrincipal.Controls.Add(lblAny);
            grpPrincipal.Location = new Point(40, 91);
            grpPrincipal.Name = "grpPrincipal";
            grpPrincipal.Size = new Size(659, 212);
            grpPrincipal.TabIndex = 0;
            grpPrincipal.TabStop = false;
            grpPrincipal.Text = "Gestió de dades demgràfiques de regions";
            // 
            // txtPoblacio
            // 
            txtPoblacio.Location = new Point(300, 50);
            txtPoblacio.Name = "txtPoblacio";
            txtPoblacio.Size = new Size(130, 23);
            txtPoblacio.TabIndex = 15;
            txtPoblacio.Validating += txtPoblacio_Validating;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(499, 146);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(134, 23);
            txtTotal.TabIndex = 14;
            txtTotal.Validating += txtTotal_Validating;
            // 
            // txtCapita
            // 
            txtCapita.Location = new Point(499, 105);
            txtCapita.Name = "txtCapita";
            txtCapita.Size = new Size(134, 23);
            txtCapita.TabIndex = 13;
            txtCapita.Validating += txtCapita_Validating;
            // 
            // txtEconomiques
            // 
            txtEconomiques.Location = new Point(197, 146);
            txtEconomiques.Name = "txtEconomiques";
            txtEconomiques.Size = new Size(138, 23);
            txtEconomiques.TabIndex = 12;
            txtEconomiques.Validating += txtEconomiques_Validating;
            // 
            // txtDomesticXarxa
            // 
            txtDomesticXarxa.Location = new Point(28, 146);
            txtDomesticXarxa.Name = "txtDomesticXarxa";
            txtDomesticXarxa.Size = new Size(131, 23);
            txtDomesticXarxa.TabIndex = 11;
            txtDomesticXarxa.Validating += txtDomesticXarxa_Validating;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(385, 149);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total";
            // 
            // lblCapita
            // 
            lblCapita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapita.Location = new Point(385, 98);
            lblCapita.Name = "lblCapita";
            lblCapita.Size = new Size(108, 37);
            lblCapita.TabIndex = 9;
            lblCapita.Text = "Consum domèstic per càpita";
            // 
            // lblEconomiques
            // 
            lblEconomiques.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEconomiques.Location = new Point(197, 108);
            lblEconomiques.Name = "lblEconomiques";
            lblEconomiques.Size = new Size(138, 37);
            lblEconomiques.TabIndex = 8;
            lblEconomiques.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // lblDomesticXarxa
            // 
            lblDomesticXarxa.AutoSize = true;
            lblDomesticXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomesticXarxa.Location = new Point(28, 120);
            lblDomesticXarxa.Name = "lblDomesticXarxa";
            lblDomesticXarxa.Size = new Size(94, 15);
            lblDomesticXarxa.TabIndex = 7;
            lblDomesticXarxa.Text = "Domèstic xarxa";
            // 
            // cmbComarca
            // 
            cmbComarca.FormattingEnabled = true;
            cmbComarca.Location = new Point(116, 50);
            cmbComarca.Name = "cmbComarca";
            cmbComarca.Size = new Size(151, 23);
            cmbComarca.TabIndex = 5;
            cmbComarca.Validating += cmbComarca_Validating;
            // 
            // cmbAny
            // 
            cmbAny.FormattingEnabled = true;
            cmbAny.Location = new Point(28, 50);
            cmbAny.Name = "cmbAny";
            cmbAny.Size = new Size(54, 23);
            cmbAny.TabIndex = 4;
            cmbAny.Validating += cmbAny_Validating;
            // 
            // lblPoblacio
            // 
            lblPoblacio.AutoSize = true;
            lblPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoblacio.Location = new Point(300, 32);
            lblPoblacio.Name = "lblPoblacio";
            lblPoblacio.Size = new Size(53, 15);
            lblPoblacio.TabIndex = 3;
            lblPoblacio.Text = "Població";
            // 
            // lblComarca
            // 
            lblComarca.AutoSize = true;
            lblComarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComarca.Location = new Point(116, 32);
            lblComarca.Name = "lblComarca";
            lblComarca.Size = new Size(55, 15);
            lblComarca.TabIndex = 2;
            lblComarca.Text = "Comarca";
            // 
            // lblAny
            // 
            lblAny.AutoSize = true;
            lblAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAny.Location = new Point(28, 32);
            lblAny.Name = "lblAny";
            lblAny.Size = new Size(28, 15);
            lblAny.TabIndex = 1;
            lblAny.Text = "Any";
            // 
            // btnNetejar
            // 
            btnNetejar.Location = new Point(510, 334);
            btnNetejar.Name = "btnNetejar";
            btnNetejar.Size = new Size(101, 30);
            btnNetejar.TabIndex = 1;
            btnNetejar.Text = "Netejar";
            btnNetejar.UseVisualStyleBackColor = true;
            btnNetejar.Click += btnNetejar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(627, 334);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvComarques
            // 
            dgvComarques.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvComarques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComarques.Location = new Point(68, 380);
            dgvComarques.Name = "dgvComarques";
            dgvComarques.RowTemplate.Height = 25;
            dgvComarques.Size = new Size(912, 150);
            dgvComarques.TabIndex = 3;
            dgvComarques.CellClick += dgvComarques_CellClick;
            // 
            // errAny
            // 
            errAny.ContainerControl = this;
            // 
            // errComarca
            // 
            errComarca.ContainerControl = this;
            // 
            // errPoblacio
            // 
            errPoblacio.ContainerControl = this;
            // 
            // errDomesticXarxa
            // 
            errDomesticXarxa.ContainerControl = this;
            // 
            // errEconomiques
            // 
            errEconomiques.ContainerControl = this;
            // 
            // errCapita
            // 
            errCapita.ContainerControl = this;
            // 
            // errTotal
            // 
            errTotal.ContainerControl = this;
            // 
            // grpEstadistiques
            // 
            grpEstadistiques.Controls.Add(lblBaix);
            grpEstadistiques.Controls.Add(lblAlt);
            grpEstadistiques.Controls.Add(lblMitja);
            grpEstadistiques.Controls.Add(lblBoolPob);
            grpEstadistiques.Controls.Add(lblLow);
            grpEstadistiques.Controls.Add(lblHigh);
            grpEstadistiques.Controls.Add(lblConsumMitja);
            grpEstadistiques.Controls.Add(lblPob);
            grpEstadistiques.Location = new Point(737, 91);
            grpEstadistiques.Name = "grpEstadistiques";
            grpEstadistiques.Size = new Size(308, 212);
            grpEstadistiques.TabIndex = 4;
            grpEstadistiques.TabStop = false;
            grpEstadistiques.Text = "Estadístiques";
            // 
            // lblBaix
            // 
            lblBaix.AutoSize = true;
            lblBaix.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaix.ForeColor = SystemColors.MenuHighlight;
            lblBaix.Location = new Point(249, 139);
            lblBaix.Name = "lblBaix";
            lblBaix.Size = new Size(12, 15);
            lblBaix.TabIndex = 23;
            lblBaix.Text = "-";
            // 
            // lblAlt
            // 
            lblAlt.AutoSize = true;
            lblAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlt.ForeColor = SystemColors.MenuHighlight;
            lblAlt.Location = new Point(249, 101);
            lblAlt.Name = "lblAlt";
            lblAlt.Size = new Size(12, 15);
            lblAlt.TabIndex = 22;
            lblAlt.Text = "-";
            // 
            // lblMitja
            // 
            lblMitja.AutoSize = true;
            lblMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMitja.ForeColor = SystemColors.MenuHighlight;
            lblMitja.Location = new Point(177, 66);
            lblMitja.Name = "lblMitja";
            lblMitja.Size = new Size(12, 15);
            lblMitja.TabIndex = 21;
            lblMitja.Text = "-";
            // 
            // lblBoolPob
            // 
            lblBoolPob.AutoSize = true;
            lblBoolPob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBoolPob.ForeColor = SystemColors.MenuHighlight;
            lblBoolPob.Location = new Point(177, 29);
            lblBoolPob.Name = "lblBoolPob";
            lblBoolPob.Size = new Size(12, 15);
            lblBoolPob.TabIndex = 20;
            lblBoolPob.Text = "-";
            // 
            // lblLow
            // 
            lblLow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLow.Location = new Point(19, 145);
            lblLow.Name = "lblLow";
            lblLow.Size = new Size(224, 23);
            lblLow.TabIndex = 19;
            lblLow.Text = "Consum domèstic per càpita més baix:";
            // 
            // lblHigh
            // 
            lblHigh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHigh.Location = new Point(19, 107);
            lblHigh.Name = "lblHigh";
            lblHigh.Size = new Size(224, 23);
            lblHigh.TabIndex = 18;
            lblHigh.Text = "Consum domèstic per càpita més alt:";
            // 
            // lblConsumMitja
            // 
            lblConsumMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConsumMitja.Location = new Point(19, 72);
            lblConsumMitja.Name = "lblConsumMitja";
            lblConsumMitja.Size = new Size(152, 23);
            lblConsumMitja.TabIndex = 17;
            lblConsumMitja.Text = "Consum domèstic mitjà:";
            // 
            // lblPob
            // 
            lblPob.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPob.Location = new Point(19, 35);
            lblPob.Name = "lblPob";
            lblPob.Size = new Size(138, 23);
            lblPob.TabIndex = 16;
            lblPob.Text = "Població>2000 hab.:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1057, 584);
            Controls.Add(grpEstadistiques);
            Controls.Add(dgvComarques);
            Controls.Add(btnGuardar);
            Controls.Add(btnNetejar);
            Controls.Add(grpPrincipal);
            Name = "Form1";
            Text = "Form1";
            grpPrincipal.ResumeLayout(false);
            grpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComarques).EndInit();
            ((System.ComponentModel.ISupportInitialize)errAny).EndInit();
            ((System.ComponentModel.ISupportInitialize)errComarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)errPoblacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDomesticXarxa).EndInit();
            ((System.ComponentModel.ISupportInitialize)errEconomiques).EndInit();
            ((System.ComponentModel.ISupportInitialize)errCapita).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTotal).EndInit();
            grpEstadistiques.ResumeLayout(false);
            grpEstadistiques.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPrincipal;
        private Label lblAny;
        private Label lblPoblacio;
        private Label lblComarca;
        private ComboBox cmbComarca;
        private ComboBox cmbAny;
        private Label lblTotal;
        private Label lblCapita;
        private Label lblEconomiques;
        private Label lblDomesticXarxa;
        private TextBox txtTotal;
        private TextBox txtCapita;
        private TextBox txtEconomiques;
        private TextBox txtDomesticXarxa;
        private Button btnNetejar;
        private Button btnGuardar;
        private DataGridView dgvComarques;
        private TextBox txtPoblacio;
        private ErrorProvider errAny;
        private ErrorProvider errComarca;
        private ErrorProvider errPoblacio;
        private ErrorProvider errDomesticXarxa;
        private ErrorProvider errEconomiques;
        private ErrorProvider errCapita;
        private ErrorProvider errTotal;
        private GroupBox grpEstadistiques;
        private Label lblPob;
        private Label lblLow;
        private Label lblHigh;
        private Label lblConsumMitja;
        private Label lblBaix;
        private Label lblAlt;
        private Label lblMitja;
        private Label lblBoolPob;
    }
}
