using caiosb.Util.Data;
using Etherchain.Common;
using Etherchain.Desktop.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiCSB.Component;

namespace caiosb.Util
{
    public static class UtilCreatePanel
    {
        public static void CreateUserPanel(Employee employee, FlowLayoutPanel flowLayoutPanel, EventHandler clickEvent)
        {
            uiPanel uiPanel = new uiPanel();
            uiPanel.Name = "pnlEmployee" + employee.EmployeeId;
            uiPanel.Size = new Size(221, 86);
            uiPanel.PanelRadius = 5;
            uiPanel.Tag = employee.EmployeeId;
            uiPanel.BackColor = Color.FromArgb(215, 223, 255);
            uiPanel.Click += new EventHandler(clickEvent);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picEmployee" + employee.EmployeeId;
            pictureBox.Size = new Size(77, 77);
            pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = employee.ArchiveId }.ObterPorCod().Blob);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = employee.EmployeeId;
            pictureBox.BackColor = Color.Transparent;
            uiPanel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(4, 4);
            pictureBox.Click += new EventHandler(clickEvent);

            Label label = new Label();
            label.Name = "lblEmployee" + employee.EmployeeId;
            label.Font = new Font("Gadugi", 14, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(80, 63, 153);
            label.Tag = employee.EmployeeId;
            label.BackColor = Color.FromArgb(242, 245, 255);
            label.Text = employee.FirstName + " " + employee.LastName;
            label.AutoEllipsis = true;
            label.AutoSize = false;
            label.Size = new Size(133, 21);
            uiPanel.Controls.Add(label);
            label.Location = new Point(85, 6);
            label.Click += new EventHandler(clickEvent);

            Label labelCPF = new Label();
            labelCPF.Name = "lblEmployeeCPF" + employee.EmployeeId;
            labelCPF.Font = new Font("Gadugi", 8);
            labelCPF.ForeColor = Color.FromArgb(180, 182, 194);
            labelCPF.BackColor = Color.FromArgb(242, 245, 255);
            labelCPF.Text = UtilConvert.ToString(employee.CPF);
            labelCPF.AutoEllipsis = true;
            labelCPF.Tag = employee.EmployeeId;
            labelCPF.AutoSize = false;
            labelCPF.Size = new Size(131, 14);
            uiPanel.Controls.Add(labelCPF);
            labelCPF.Location = new Point(87, 27);
            labelCPF.Click += new EventHandler(clickEvent);

            flowLayoutPanel.Controls.Add(uiPanel);
            //flowLayoutPanel.Controls.Add(uiPanelEmployee);
        }

        public static void CreateUserPanel(List<Employee> employeeList, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            foreach (var employee in employeeList)
            {
                uiPanel uiPanel = new uiPanel();
                uiPanel.Name = "pnlEmployee" + employee.EmployeeId;
                uiPanel.Size = new Size(221, 86);
                uiPanel.PanelRadius = 5;
                uiPanel.Tag = employee.EmployeeId;
                uiPanel.BackColor = Color.FromArgb(215, 223, 255);
                uiPanel.Click += new EventHandler(eventHandler);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "picEmployee" + employee.EmployeeId;
                pictureBox.Size = new Size(77, 77);
                pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = employee.ArchiveId }.ObterPorCod().Blob);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = employee.EmployeeId;
                pictureBox.BackColor = Color.Transparent;
                uiPanel.Controls.Add(pictureBox);
                pictureBox.Location = new Point(4, 4);
                pictureBox.Click += new EventHandler(eventHandler);

                Label label = new Label();
                label.Name = "lblEmployee" + employee.EmployeeId;
                label.Font = new Font("Gadugi", 14, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(80, 63, 153);
                label.Tag = employee.EmployeeId;
                label.BackColor = Color.FromArgb(242, 245, 255);
                label.Text = employee.FirstName + " " + employee.LastName;
                label.AutoEllipsis = true;
                label.AutoSize = false;
                label.Size = new Size(133, 21);
                uiPanel.Controls.Add(label);
                label.Location = new Point(85, 6);
                label.Click += new EventHandler(eventHandler);

                Label labelCPF = new Label();
                labelCPF.Name = "lblEmployeeCPF" + employee.EmployeeId;
                labelCPF.Font = new Font("Gadugi", 8);
                labelCPF.ForeColor = Color.FromArgb(180, 182, 194);
                labelCPF.BackColor = Color.FromArgb(242, 245, 255);
                labelCPF.Text = UtilConvert.ToString(employee.CPF);
                labelCPF.AutoEllipsis = true;
                labelCPF.Tag = employee.EmployeeId;
                labelCPF.AutoSize = false;
                labelCPF.Size = new Size(131, 14);
                uiPanel.Controls.Add(labelCPF);
                labelCPF.Location = new Point(87, 27);
                labelCPF.Click += new EventHandler(eventHandler);

                flowLayoutPanel.Controls.Add(uiPanel);
                //flowLayoutPanel.Controls.Add(uiPanelEmployee);
            }
        }

        public static void CreateCryptocurrencyPanel(Cryptocurency cryptocurrency, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            uiPanel uiPanel = new uiPanel();
            uiPanel.Name = "pnlCryptocurrency" + cryptocurrency.CryptocurrencyId;
            uiPanel.Size = new Size(221, 86);
            uiPanel.PanelRadius = 5;
            uiPanel.Tag = cryptocurrency.CryptocurrencyId;
            uiPanel.BackColor = Color.FromArgb(215, 223, 255);
            uiPanel.Click += new EventHandler(eventHandler);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picCryptocurrency" + cryptocurrency.CryptocurrencyId;
            pictureBox.Size = new Size(77, 77);
            pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = cryptocurrency.ArchiveId }.ObterPorCod().Blob);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = cryptocurrency.CryptocurrencyId;
            pictureBox.BackColor = Color.Transparent;
            uiPanel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(4, 4);
            pictureBox.Click += new EventHandler(eventHandler);

            Label label = new Label();
            label.Name = "lblCryptocurrency" + cryptocurrency.CryptocurrencyId;
            label.Font = new Font("Gadugi", 14, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(80, 63, 153);
            label.Tag = cryptocurrency.CryptocurrencyId;
            label.BackColor = Color.FromArgb(242, 245, 255);
            label.Text = String.Format("{0} [{1}]", cryptocurrency.Name, cryptocurrency.Base);
            label.AutoEllipsis = true;
            label.AutoSize = false;
            label.Size = new Size(133, 21);
            uiPanel.Controls.Add(label);
            label.Location = new Point(85, 6);
            label.Click += new EventHandler(eventHandler);

            Label labelBalance = new Label();
            labelBalance.Name = "lblCryptocurrencyBalance" + cryptocurrency.CryptocurrencyId;
            labelBalance.Font = new Font("Gadugi", 8);
            labelBalance.ForeColor = Color.FromArgb(180, 182, 194);
            labelBalance.BackColor = Color.FromArgb(242, 245, 255);
            labelBalance.Text = String.Format("{0} ({1})", UtilConvert.ToString(cryptocurrency.CryptocurrencyBalance), UtilConvert.ToString(cryptocurrency.CryptocurrencyUnit));
            labelBalance.AutoEllipsis = true;
            labelBalance.Tag = cryptocurrency.CryptocurrencyId;
            labelBalance.AutoSize = false;
            labelBalance.Size = new Size(131, 14);
            uiPanel.Controls.Add(labelBalance);
            labelBalance.Location = new Point(87, 27);
            labelBalance.Click += new EventHandler(eventHandler);

            flowLayoutPanel.Controls.Add(uiPanel);
        }

        public static void CreateCryptocurrencyPanel(List<Cryptocurency> cryptocurrencyList, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            foreach (var cryptocurrency in cryptocurrencyList)
            {
                uiPanel uiPanel = new uiPanel();
                uiPanel.Name = "pnlCryptocurrency" + cryptocurrency.CryptocurrencyId;
                uiPanel.Size = new Size(221, 86);
                uiPanel.PanelRadius = 5;
                uiPanel.Tag = cryptocurrency.CryptocurrencyId;
                uiPanel.BackColor = Color.FromArgb(215, 223, 255);
                uiPanel.Click += new EventHandler(eventHandler);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "picCryptocurrency" + cryptocurrency.CryptocurrencyId;
                pictureBox.Size = new Size(77, 77);
                pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = cryptocurrency.ArchiveId }.ObterPorCod().Blob);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = cryptocurrency.CryptocurrencyId;
                pictureBox.BackColor = Color.Transparent;
                uiPanel.Controls.Add(pictureBox);
                pictureBox.Location = new Point(4, 4);
                pictureBox.Click += new EventHandler(eventHandler);

                Label label = new Label();
                label.Name = "lblCryptocurrency" + cryptocurrency.CryptocurrencyId;
                label.Font = new Font("Gadugi", 14, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(80, 63, 153);
                label.Tag = cryptocurrency.CryptocurrencyId;
                label.BackColor = Color.FromArgb(242, 245, 255);
                label.Text = String.Format("{0} [{1}]", cryptocurrency.Name, cryptocurrency.Base);
                label.AutoEllipsis = true;
                label.AutoSize = false;
                label.Size = new Size(133, 21);
                uiPanel.Controls.Add(label);
                label.Location = new Point(85, 6);
                label.Click += new EventHandler(eventHandler);

                Label labelBalance = new Label();
                labelBalance.Name = "lblCryptocurrencyBalance" + cryptocurrency.CryptocurrencyId;
                labelBalance.Font = new Font("Gadugi", 8);
                labelBalance.ForeColor = Color.FromArgb(180, 182, 194);
                labelBalance.BackColor = Color.FromArgb(242, 245, 255);
                labelBalance.Text = String.Format("{0} ({1})", UtilConvert.ToString(cryptocurrency.CryptocurrencyBalance), UtilConvert.ToString(cryptocurrency.CryptocurrencyUnit));
                labelBalance.AutoEllipsis = true;
                labelBalance.Tag = cryptocurrency.CryptocurrencyId;
                labelBalance.AutoSize = false;
                labelBalance.Size = new Size(131, 14);
                uiPanel.Controls.Add(labelBalance);
                labelBalance.Location = new Point(87, 27);
                labelBalance.Click += new EventHandler(eventHandler);

                flowLayoutPanel.Controls.Add(uiPanel);
                //flowLayoutPanel.Controls.Add(uiPanelEmployee);
            }
        }

        public static void CreateSupportPanel(Support support, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            uiPanel uiPanel = new uiPanel();
            uiPanel.Name = "pnlSupport" + support.SupportId;
            uiPanel.Size = new Size(221, 86);
            uiPanel.PanelRadius = 5;
            uiPanel.Tag = support.SupportId;
            uiPanel.BackColor = Color.FromArgb(215, 223, 255);
            uiPanel.Click += new EventHandler(eventHandler);

            Label lblTitulo = new Label();
            lblTitulo.Name = "lblTitulo" + support.SupportId;
            lblTitulo.Font = new Font("Gadugi", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(80, 63, 153);
            lblTitulo.Tag = support.SupportId;
            lblTitulo.BackColor = Color.FromArgb(242, 245, 255);
            lblTitulo.Text = support.Title;
            lblTitulo.AutoEllipsis = true;
            lblTitulo.AutoSize = false;
            lblTitulo.Size = new Size(214, 21);
            uiPanel.Controls.Add(lblTitulo);
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Click += new EventHandler(eventHandler);

            Label lblCausa = new Label();
            lblCausa.Name = "lblCausa" + support.SupportId;
            lblCausa.Font = new Font("Gadugi", 8);
            lblCausa.ForeColor = Color.FromArgb(180, 182, 194);
            lblCausa.BackColor = Color.FromArgb(242, 245, 255);
            lblCausa.Text = support.Title;
            lblCausa.AutoEllipsis = true;
            lblCausa.Tag = support.SupportId;
            lblCausa.AutoSize = false;
            lblCausa.Size = new Size(213, 53);
            uiPanel.Controls.Add(lblCausa);
            lblCausa.Location = new Point(4, 27);
            lblCausa.Click += new EventHandler(eventHandler);

            flowLayoutPanel.Controls.Add(uiPanel);
        }

        public static void CreateSupportPanel(List<Support> supports, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            foreach (var support in supports)
            {
                uiPanel uiPanel = new uiPanel();
                uiPanel.Name = "pnlSupport" + support.SupportId;
                uiPanel.Size = new Size(221, 86);
                uiPanel.PanelRadius = 5;
                uiPanel.Tag = support.SupportId;
                uiPanel.BackColor = Color.FromArgb(215, 223, 255);
                uiPanel.Click += new EventHandler(eventHandler);

                Label lblTitulo = new Label();
                lblTitulo.Name = "lblTitulo" + support.SupportId;
                lblTitulo.Font = new Font("Gadugi", 9, FontStyle.Bold);
                lblTitulo.ForeColor = Color.FromArgb(80, 63, 153);
                lblTitulo.Tag = support.SupportId;
                lblTitulo.BackColor = Color.FromArgb(242, 245, 255);
                lblTitulo.Text = support.Title;
                lblTitulo.AutoEllipsis = true;
                lblTitulo.AutoSize = false;
                lblTitulo.Size = new Size(235, 21);
                uiPanel.Controls.Add(lblTitulo);
                lblTitulo.Location = new Point(3, 3);
                lblTitulo.Click += new EventHandler(eventHandler);

                Label lblCausa = new Label();
                lblCausa.Name = "lblCausa" + support.SupportId;
                lblCausa.Font = new Font("Gadugi", 8);
                lblCausa.ForeColor = Color.FromArgb(180, 182, 194);
                lblCausa.BackColor = Color.FromArgb(242, 245, 255);
                lblCausa.Text = support.Description;
                lblCausa.AutoEllipsis = true;
                lblCausa.Tag = support.SupportId;
                lblCausa.AutoSize = false;
                lblCausa.Size = new Size(231, 53);
                uiPanel.Controls.Add(lblCausa);
                lblCausa.Location = new Point(4, 27);
                lblCausa.Click += new EventHandler(eventHandler);

                flowLayoutPanel.Controls.Add(uiPanel);
                //flowLayoutPanel.Controls.Add(uiPanelEmployee);
            }
        }

        public static void CreateCustomerFPanel(CustomerFisico customer, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            uiPanel uiPanel = new uiPanel();
            uiPanel.Name = "pnlCustomer" + customer.CustomerId;
            uiPanel.Size = new Size(241, 86);
            uiPanel.PanelRadius = 5;
            uiPanel.Tag = customer.CustomerId;
            uiPanel.BackColor = Color.Transparent;
            uiPanel.Click += new EventHandler(eventHandler);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picCustomer" + customer.CustomerId;
            pictureBox.Size = new Size(77, 77);
            pictureBox.Image = Resources.unknown;
            //pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = customer.ArchiveId }.ObterPorCod().Blob);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = customer.CustomerId;
            pictureBox.BackColor = Color.Transparent;
            uiPanel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(4, 4);
            pictureBox.Click += new EventHandler(eventHandler);

            Label label = new Label();
            label.Name = "lblCustomerName" + customer.CustomerId;
            label.Font = new Font("Gadugi", 14, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(80, 63, 153);
            label.Tag = customer.CustomerId;
            label.BackColor = Color.FromArgb(242, 245, 255);
            label.Text = String.Format("{0} {1}", customer.FirstName, customer.LastName);
            label.AutoEllipsis = true;
            label.AutoSize = false;
            label.Size = new Size(133, 21);
            uiPanel.Controls.Add(label);
            label.Location = new Point(85, 6);
            label.Click += new EventHandler(eventHandler);

            Label labelBalance = new Label();
            labelBalance.Name = "lblCustomerEmail" + customer.CustomerId;
            labelBalance.Font = new Font("Gadugi", 8);
            labelBalance.ForeColor = Color.FromArgb(180, 182, 194);
            labelBalance.BackColor = Color.FromArgb(242, 245, 255);
            labelBalance.Text = UtilConvert.ToString(customer.Email);
            labelBalance.AutoEllipsis = true;
            labelBalance.Tag = customer.CustomerId;
            labelBalance.AutoSize = false;
            labelBalance.Size = new Size(131, 14);
            uiPanel.Controls.Add(labelBalance);
            labelBalance.Location = new Point(87, 27);
            labelBalance.Click += new EventHandler(eventHandler);

            flowLayoutPanel.Controls.Add(uiPanel);
            //flowLayoutPanel.Controls.Add(uiPanelEmployee);
        }

        public static void CreateCustomerPanel(List<CustomerFisico> customersList, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            foreach (var customer in customersList)
            {
                uiPanel uiPanel = new uiPanel();
                uiPanel.Name = "pnlCustomer" + customer.CustomerId;
                uiPanel.Size = new Size(241, 86);
                uiPanel.PanelRadius = 5;
                uiPanel.Tag = customer.CustomerId;
                uiPanel.BackColor = Color.Transparent;
                uiPanel.Click += new EventHandler(eventHandler);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "picCustomer" + customer.CustomerId;
                pictureBox.Size = new Size(77, 77);
                pictureBox.Image = Resources.unknown;
                //pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = customer.ArchiveId }.ObterPorCod().Blob);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = customer.CustomerId;
                pictureBox.BackColor = Color.Transparent;
                uiPanel.Controls.Add(pictureBox);
                pictureBox.Location = new Point(4, 4);
                pictureBox.Click += new EventHandler(eventHandler);

                Label label = new Label();
                label.Name = "lblCustomerName" + customer.CustomerId;
                label.Font = new Font("Gadugi", 14, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(80, 63, 153);
                label.Tag = customer.CustomerId;
                label.BackColor = Color.FromArgb(242, 245, 255);
                label.Text = String.Format("{0} {1}", customer.FirstName, customer.LastName);
                label.AutoEllipsis = true;
                label.AutoSize = false;
                label.Size = new Size(133, 21);
                uiPanel.Controls.Add(label);
                label.Location = new Point(85, 6);
                label.Click += new EventHandler(eventHandler);

                Label labelBalance = new Label();
                labelBalance.Name = "lblCustomerEmail" + customer.CustomerId;
                labelBalance.Font = new Font("Gadugi", 8);
                labelBalance.ForeColor = Color.FromArgb(180, 182, 194);
                labelBalance.BackColor = Color.FromArgb(242, 245, 255);
                labelBalance.Text = UtilConvert.ToString(customer.Email);
                labelBalance.AutoEllipsis = true;
                labelBalance.Tag = customer.CustomerId;
                labelBalance.AutoSize = false;
                labelBalance.Size = new Size(131, 14);
                uiPanel.Controls.Add(labelBalance);
                labelBalance.Location = new Point(87, 27);
                labelBalance.Click += new EventHandler(eventHandler);

                flowLayoutPanel.Controls.Add(uiPanel);
                //flowLayoutPanel.Controls.Add(uiPanelEmployee);
            }
        }

        public static void CreateCustomerJPanel(CustomerJuridico customer, FlowLayoutPanel flowLayoutPanel, EventHandler eventHandler)
        {
            uiPanel uiPanel = new uiPanel();
            uiPanel.Name = "pnlCustomer" + customer.CustomerId;
            uiPanel.Size = new Size(241, 86);
            uiPanel.PanelRadius = 5;
            uiPanel.Tag = customer.CustomerId;
            uiPanel.BackColor = Color.Transparent;
            uiPanel.Click += new EventHandler(eventHandler);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picCustomer" + customer.CustomerId;
            pictureBox.Size = new Size(77, 77);
            pictureBox.Image = Resources.unknown;
            //pictureBox.Image = UtilImage.ByteToImage(new Archive { ArchiveId = customer.ArchiveId }.ObterPorCod().Blob);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = customer.CustomerId;
            pictureBox.BackColor = Color.Transparent;
            uiPanel.Controls.Add(pictureBox);
            pictureBox.Location = new Point(4, 4);
            pictureBox.Click += new EventHandler(eventHandler);

            Label label = new Label();
            label.Name = "lblCustomerName" + customer.CustomerId;
            label.Font = new Font("Gadugi", 14, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(80, 63, 153);
            label.Tag = customer.CustomerId;
            label.BackColor = Color.FromArgb(242, 245, 255);
            label.Text = customer.CNPJ;
            label.AutoEllipsis = true;
            label.AutoSize = false;
            label.Size = new Size(133, 21);
            uiPanel.Controls.Add(label);
            label.Location = new Point(85, 6);
            label.Click += new EventHandler(eventHandler);

            Label labelBalance = new Label();
            labelBalance.Name = "lblCustomerEmail" + customer.CustomerId;
            labelBalance.Font = new Font("Gadugi", 8);
            labelBalance.ForeColor = Color.FromArgb(180, 182, 194);
            labelBalance.BackColor = Color.FromArgb(242, 245, 255);
            labelBalance.Text = UtilConvert.ToString(customer.Email);
            labelBalance.AutoEllipsis = true;
            labelBalance.Tag = customer.CustomerId;
            labelBalance.AutoSize = false;
            labelBalance.Size = new Size(131, 14);
            uiPanel.Controls.Add(labelBalance);
            labelBalance.Location = new Point(87, 27);
            labelBalance.Click += new EventHandler(eventHandler);

            flowLayoutPanel.Controls.Add(uiPanel);
            //flowLayoutPanel.Controls.Add(uiPanelEmployee);
        }
    }
}
