using caiosb.Util.Data;
using Etherchain.Common;
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
    }
}
