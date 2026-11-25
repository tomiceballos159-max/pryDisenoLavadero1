using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoLavadero1
{
    public partial class frmLavadero : Form
    {
        private decimal _recEncerado;
        private decimal _recCompleto;
        private decimal lblEncerad;
        private decimal _recExpress;
        private decimal _recNormal;
        private object _calculoActual;
        private IEnumerable<object> _lavadosDia;
        private object encontrados;

        public frmLavadero()
        {
            InitializeComponent();
        }
        private void frmLavados_Load(object sender, EventArgs e)
        {
            if (cmbServicio.Items.Count == 0)
            {
                cmbServicio.Items.AddRange(new object[]
                {
                    "Lavado exterior",
                    "Lavado completo",
                    "Lavado con encerado"
                });
            }

            if (cmbServicio.SelectedIndex < 0 && cmbServicio.Items.Count > 0)
            {
                cmbServicio.SelectedIndex = 0;
            }

            LimpiarResultados();
            ActualizarRecaudacion();
        }

        private void LimpiarResultados()
        {
            lblSubtotal.Text = 0m.ToString("N2");
            lblRecargo.Text = 0m.ToString("N2");
            lblDescuento.Text = 0m.ToString("N2");
            lblTotal.Text = 0m.ToString("N2");
        }

        private void ActualizarRecaudacion()
        {
            lblRecExterior.Text = lblExterior.ToString("N2");
            lblRecCompleto.Text = lblCompleto.ToString("N2");
            lblRecEncerado.Text = lblEncerado.ToString("N2");
        }

        private bool ValidarEntradas(out int cantidad)
        {
            cantidad = 0;

            if (string.IsNullOrWhiteSpace(txtCliente.Text)) // <-- verificar nombre del TextBox de cliente
            {
                MessageBox.Show("Ingresá el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            string patente = txtPatente.Text.Trim().ToUpper(); // <-- verificar nombre del TextBox de patente
            if (patente.Length < 6 || patente.Length > 7)
            {
                MessageBox.Show("La patente debe tener entre 6 y 7 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatente.Focus();
                return false;
            }

            if (cmbServicio.SelectedIndex < 0 || cmbServicio.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un servicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbServicio.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(value: txtCantidad.Text) || !int.TryParse(txtCantidad.Text.Trim(), out cantidad)) // <-- verificar nombre
            {
                MessageBox.Show("Ingresá una cantidad numérica válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("La cantidad de vehículos debe ser entre 1 y 5.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private decimal ObtenerPrecioServicio(string servicio)
        {
            switch (servicio)
            {
                case "Lavado exterior":
                    return 8000m;
                case "Lavado completo":
                    return 14000m;
                case "Lavado con encerado":
                    return 20000m;
                default:
                    return 0m;
            }
        }

        private decimal ObtenerPorcentajeDescuento(int cantidad, bool esFrecuente)
        {
            decimal porcentaje = 0m;

            if (cantidad >= 2 && cantidad <= 3)
            {
                porcentaje = 10m;
            }
            else if (cantidad >= 4 && cantidad <= 5)
            {
                porcentaje = 15m;
            }

            if (esFrecuente)
            {
                porcentaje += 5m;
            }

            return porcentaje;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas(out int cantidad))
            {
                btnCalcular = null;
                return;
            }

            string cliente = txtCliente.Text.Trim();
            string patente = txtPatente.Text.Trim().ToUpper();
            string servicio = cmbServicio.SelectedItem.ToString();

            // Si usás RadioButtons optExpress / optNormal o CheckBox chkClienteFrecuente, ajustá acá:
            bool esExpress = false;
            string tipoEntrega = esExpress ? "Express" : "Normal";
            bool esFrecuente = false;

            decimal precioUnitario = ObtenerPrecioServicio(servicio);
            decimal subtotal = precioUnitario * cantidad;

            decimal recargo = 0m;
            if (esExpress)
            {
                recargo = subtotal * 0.25m;
            }

            decimal porcDescuento = ObtenerPorcentajeDescuento(cantidad, esFrecuente);
            decimal descuento = subtotal * (porcDescuento / 100m);
            decimal total = subtotal + recargo - descuento;

            lblSubtotal.Text = subtotal.ToString("N2");
            lblRecargo.Text = recargo.ToString("N2");
            lblDescuento.Text = $"{porcDescuento:0.##}% ({descuento.ToString("N2")})";
            lblTotal.Text = total.ToString("N2");

            btnCalcular = new RegistroLavado
            {
                Cliente = cliente,
                Patente = patente,
                Servicio = servicio,
                TipoEntrega = tipoEntrega,
                Cantidad = cantidad,
                EsFrecuente = esFrecuente,
                Subtotal = subtotal,
                Recargo = recargo,
                Descuento = descuento,
                Total = total
            };
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (btnCalcular == null)
            {
                btnCalcular_Click(sender, e);
                if (btnCalcular == null)
                {
                    return;
                }
            }

            RegistroLavado reg = btnCalcular;
            .Add(reg);

            string item = $"{reg.Patente} | {reg.Cliente} | {reg.Servicio} | {reg.TipoEntrega} | Cant: {reg.Cantidad} | Total: {reg.Total.ToString("N2")}";
            lstLavadosDelDia.Items.Add(item);

            switch (reg.Servicio)
            {
                case "Lavado exterior":
                    lblEncerad += reg.Total;
                    break;
                case "Lavado completo":
                    _recCompleto += reg.Total;
                    break;
                case "Lavado con encerado":
                    _recEncerado += reg.Total;
                    break;
            }

            if (reg.TipoEntrega == "Express")
            {
                _recExpress += reg.Total;
            }
            else
            {
                _recNormal += reg.Total;
            }

            ActualizarRecaudacion();

            _calculoActual = null;
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _calculoActual = null;
            LimpiarCampos();
            LimpiarResultados();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtPatente.Clear();
            txtCantidad.Clear();
            if (cmbServicio.Items.Count > 0)
            {
                cmbServicio.SelectedIndex = 0;
            }
            txtCliente.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string buscada = txtBuscarPatente.Text.Trim().ToUpper(); // <-- verificar nombre del TextBox de búsqueda
            if (string.IsNullOrWhiteSpace(buscada))
            {
                MessageBox.Show("Ingresá una patente para consultar.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarPatente.Focus();
                return;
            }


            if (encontrados.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Patente: {buscada} | Cantidad de veces: {encontrados.Count}");
                foreach (RegistroLavado item in encontrados)
                {
                    sb.AppendLine($"- {item.Servicio} ({item.TipoEntrega}, {item.Cantidad} veh.): {item.Total.ToString("N2")}");
                }

                MessageBox.Show(sb.ToString(), "Resultado de consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No hay lavados registrados para la patente {buscada}.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}



   

