using Microsoft.Win32;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Xml.Serialization;
using M03UF5AC3.Persistence.Utils;
using M03UF5AC3.Persistence.Mapping;
using M03UF5AC3.Persistence.DAO;

namespace M03UF5AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            string path = "..\\..\\..\\Fitxers\\Consum.csv";
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<Registre> registres = csv.GetRecords<Registre>().ToList();

            for (int i = registres.Min(x => x.Any); i <= 2050; i++)
            {
                cmbAny.Items.Add(i);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Registre>));
            using (TextWriter writer = new StreamWriter("..\\..\\..\\Fitxers\\Consum.xml"))
            {
                serializer.Serialize(writer, registres);
            }
            cmbComarca.DataSource = serializer.Deserialize(new StreamReader("..\\..\\..\\Fitxers\\Consum.xml"));
            cmbComarca.DisplayMember = "Comarca";
            cmbComarca.ValueMember = "Codi_comarca";
            cmbComarca.SelectedIndex = -1;

            dgvComarques.DataSource = registres;
            dgvComarques.Columns[1].Visible = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //crea algo nuevo en la tabla usando los datos escritos
                Registre registre = new Registre();
                registre.Any = Convert.ToInt32(cmbAny.Text);
                registre.Codi_comarca = Convert.ToInt32(cmbComarca.SelectedValue);
                registre.Comarca = cmbComarca.Text;
                registre.Població = Convert.ToInt32(txtPoblacio.Text);
                registre.Domèstic_xarxa = Convert.ToInt32(txtDomesticXarxa.Text);
                registre.Activitats_econòmiques_i_fonts_pròpies = Convert.ToInt32(txtEconomiques.Text);
                registre.Total = Convert.ToInt32(txtTotal.Text);
                registre.Consum_domèstic_per_càpita = Convert.ToDouble(txtCapita.Text);

                //añade el nuevo registro al csv
                using (var writer = new StreamWriter("..\\..\\..\\Fitxers\\Consum.csv", true))
                {
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecord(registre);
                        writer.WriteLine();
                    }
                };

                //actualiza la tabla
                string path = "..\\..\\..\\Fitxers\\Consum.csv";
                using var reader = new StreamReader(path);
                using var csv2 = new CsvReader(reader, CultureInfo.InvariantCulture);
                List<Registre> registres = csv2.GetRecords<Registre>().ToList();
                dgvComarques.DataSource = registres;
                dgvComarques.Columns[1].Visible = false;

                //añade el nuevo registro a la base de datos
                IRegistreDAO registreDAO = new RegistreDAO(NpgsqlUtils.OpenConnection());
                Registre newRegistre = new Registre
                {
                    Any = registre.Any,
                    Codi_comarca = registre.Codi_comarca,
                    Comarca = registre.Comarca,
                    Població = registre.Població,
                    Domèstic_xarxa = registre.Domèstic_xarxa,
                    Activitats_econòmiques_i_fonts_pròpies = registre.Activitats_econòmiques_i_fonts_pròpies,
                    Total = registre.Total,
                    Consum_domèstic_per_càpita = registre.Consum_domèstic_per_càpita
                };

                try
                {
                    registreDAO.AddComarca(newRegistre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al afegir la comarca: " + ex.Message);
                }

            }

        }

        private void btnNetejar_Click(object sender, EventArgs e)
        {
            cmbAny.SelectedIndex = -1;
            cmbComarca.SelectedIndex = -1;
            txtPoblacio.Text = "";
            txtDomesticXarxa.Text = "";
            txtEconomiques.Text = "";
            txtCapita.Text = "";
            txtTotal.Text = "";
        }
        private void cmbAny_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            List<int> anys = cmbAny.Items.Cast<int>().ToList();
            if (string.IsNullOrEmpty(cmbAny.Text))
            {
                e.Cancel = true;
                cmbAny.Focus();
                errAny.SetError(cmbAny, "El camp any no pot estar buit");
            }
            else if (!anys.Contains(Convert.ToInt32(cmbAny.Text)))
            {
                e.Cancel = true;
                cmbAny.Focus();
                errAny.SetError(cmbAny, "El camp any no és vàlid");
            }
            else
            {
                e.Cancel = false;
                errAny.SetError(cmbAny, "");
            }
        }

        private void cmbComarca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //crea una lista con los nombres de todas las comarcas
            List<string> comarques = new List<string>();
            foreach (DataGridViewRow row in dgvComarques.Rows)
            {
                if (comarques.Contains(row.Cells[2].Value.ToString()) == false)
                    comarques.Add(row.Cells[2].Value.ToString());
            }
            if (string.IsNullOrEmpty(cmbComarca.Text))
            {
                e.Cancel = true;
                cmbComarca.Focus();
                errComarca.SetError(cmbComarca, "El camp comarca no pot estar buit");
            }
            else if (!comarques.Contains(cmbComarca.Text))
            {
                e.Cancel = true;
                cmbComarca.Focus();
                errComarca.SetError(cmbComarca, "El camp comarca no és vàlid");
            }
            else
            {
                e.Cancel = false;
                errComarca.SetError(cmbComarca, "");
            }
        }

        private void txtPoblacio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoblacio.Text))
            {
                e.Cancel = true;
                txtPoblacio.Focus();
                errPoblacio.SetError(txtPoblacio, "El camp població no pot estar buit");
            }
            else if (!int.TryParse(txtPoblacio.Text, out int result))
            {
                e.Cancel = true;
                txtPoblacio.Focus();
                errPoblacio.SetError(txtPoblacio, "El camp població ha de ser un número");
            }
            else
            {
                e.Cancel = false;
                errPoblacio.SetError(txtPoblacio, "");
            }
        }

        private void txtDomesticXarxa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDomesticXarxa.Text))
            {
                e.Cancel = true;
                txtDomesticXarxa.Focus();
                errDomesticXarxa.SetError(txtDomesticXarxa, "El camp domèstic xarxa no pot estar buit");
            }
            else if (!int.TryParse(txtDomesticXarxa.Text, out int result))
            {
                e.Cancel = true;
                txtDomesticXarxa.Focus();
                errDomesticXarxa.SetError(txtDomesticXarxa, "El camp domèstic xarxa ha de ser un número");
            }
            else
            {
                e.Cancel = false;
                errDomesticXarxa.SetError(txtDomesticXarxa, "");
            }
        }

        private void txtEconomiques_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEconomiques.Text))
            {
                e.Cancel = true;
                txtEconomiques.Focus();
                errEconomiques.SetError(txtEconomiques, "El camp activitats econòmiques i fonts pròpies no pot estar buit");
            }
            else if (!int.TryParse(txtEconomiques.Text, out int result))
            {
                e.Cancel = true;
                txtEconomiques.Focus();
                errEconomiques.SetError(txtEconomiques, "El camp activitats econòmiques i fonts pròpies ha de ser un número");
            }
            else
            {
                e.Cancel = false;
                errEconomiques.SetError(txtEconomiques, "");
            }
        }

        private void txtCapita_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapita.Text))
            {
                e.Cancel = true;
                txtCapita.Focus();
                errCapita.SetError(txtCapita, "El camp consum domèstic per càpita no pot estar buit");
            }
            else if (!double.TryParse(txtCapita.Text, out double result))
            {
                e.Cancel = true;
                txtCapita.Focus();
                errCapita.SetError(txtCapita, "El camp consum domèstic per càpita ha de ser un número");
            }
            else
            {
                e.Cancel = false;
                errCapita.SetError(txtCapita, "");
            }
        }

        private void txtTotal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                e.Cancel = true;
                txtTotal.Focus();
                errTotal.SetError(txtTotal, "El camp total no pot estar buit");
            }
            else if (!int.TryParse(txtTotal.Text, out int result))
            {
                e.Cancel = true;
                txtTotal.Focus();
                errTotal.SetError(txtTotal, "El camp total ha de ser un número");
            }
            else
            {
                e.Cancel = false;
                errTotal.SetError(txtTotal, "");
            }
        }

        private void dgvComarques_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;//número de fila seleccionada
            if (n != -1)
            {
                DataGridViewRow row = dgvComarques.Rows[n];
                string nomComarca = row.Cells[2].Value.ToString();
                int poblacio = Convert.ToInt32(row.Cells[3].Value);
                double consumCapita = Convert.ToDouble(row.Cells[7].Value);

                if (poblacio > 2000)
                {
                    lblBoolPob.Text = "Sí";
                }
                else
                {
                    lblBoolPob.Text = "No";
                }
                //haz la media de todas con el mismo nombre de comarca
                double media = 0;
                int count = 0;
                foreach (DataGridViewRow r in dgvComarques.Rows)
                {
                    if (r.Cells[2].Value.ToString() == nomComarca)
                    {
                        media += Convert.ToDouble(r.Cells[7].Value);
                        count++;
                    }
                }
                media = media / count;
                media = Math.Round(media, 2);
                lblMitja.Text = media.ToString();

                //comprueba si el consum per capita es el mas grande de todas con el mismo nombre
                bool esMax = true;
                bool esMin = true;
                foreach (DataGridViewRow r in dgvComarques.Rows)
                {
                    if (r.Cells[2].Value.ToString() == nomComarca)
                    {
                        if (Convert.ToDouble(r.Cells[7].Value) > consumCapita)
                        {
                            esMax = false;
                        }
                        if (Convert.ToDouble(r.Cells[7].Value) < consumCapita)
                        {
                            esMin = false;
                        }
                    }
                }
                lblAlt.Text = esMax ? "Sí" : "No";
                lblBaix.Text = esMin ? "Sí" : "No";
            }
        }
    }
}
