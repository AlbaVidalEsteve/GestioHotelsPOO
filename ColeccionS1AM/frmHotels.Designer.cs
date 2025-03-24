
namespace GestioHotels
{
    partial class frmHotels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPobHotel = new System.Windows.Forms.TextBox();
            this.txtNomHotel = new System.Windows.Forms.TextBox();
            this.txtCodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumHab = new System.Windows.Forms.TextBox();
            this.lstHotels = new System.Windows.Forms.ListBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtPobClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualitzarHotel = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.grbHotels = new System.Windows.Forms.GroupBox();
            this.btnAfegirHotel = new System.Windows.Forms.Button();
            this.btnEsborrarHotel = new System.Windows.Forms.Button();
            this.btnEditarHotel = new System.Windows.Forms.Button();
            this.grbClients = new System.Windows.Forms.GroupBox();
            this.btnAfegirClient = new System.Windows.Forms.Button();
            this.btnEsborrarClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoci = new System.Windows.Forms.TextBox();
            this.btnReserva = new System.Windows.Forms.Button();
            this.dtgReserves = new System.Windows.Forms.DataGridView();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.txtDies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbHotels.SuspendLayout();
            this.grbClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReserves)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPobHotel
            // 
            this.txtPobHotel.Location = new System.Drawing.Point(162, 109);
            this.txtPobHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPobHotel.Name = "txtPobHotel";
            this.txtPobHotel.Size = new System.Drawing.Size(258, 26);
            this.txtPobHotel.TabIndex = 2;
            this.txtPobHotel.Tag = "Descripcio";
            // 
            // txtNomHotel
            // 
            this.txtNomHotel.Location = new System.Drawing.Point(162, 69);
            this.txtNomHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomHotel.Name = "txtNomHotel";
            this.txtNomHotel.Size = new System.Drawing.Size(258, 26);
            this.txtNomHotel.TabIndex = 1;
            this.txtNomHotel.Tag = "Nom";
            // 
            // txtCodi
            // 
            this.txtCodi.Location = new System.Drawing.Point(162, 29);
            this.txtCodi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodi.Name = "txtCodi";
            this.txtCodi.Size = new System.Drawing.Size(74, 26);
            this.txtCodi.TabIndex = 0;
            this.txtCodi.Tag = "IdPlat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Població";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "num habitacions";
            // 
            // txtNumHab
            // 
            this.txtNumHab.Location = new System.Drawing.Point(162, 149);
            this.txtNumHab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumHab.Name = "txtNumHab";
            this.txtNumHab.Size = new System.Drawing.Size(52, 26);
            this.txtNumHab.TabIndex = 3;
            this.txtNumHab.Tag = "IdPlat";
            // 
            // lstHotels
            // 
            this.lstHotels.DisplayMember = "codi";
            this.lstHotels.FormattingEnabled = true;
            this.lstHotels.ItemHeight = 20;
            this.lstHotels.Location = new System.Drawing.Point(466, 29);
            this.lstHotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstHotels.Name = "lstHotels";
            this.lstHotels.Size = new System.Drawing.Size(266, 224);
            this.lstHotels.TabIndex = 5;
            this.lstHotels.DoubleClick += new System.EventHandler(this.lstHotels_DoubleClick);
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 20;
            this.lstClients.Location = new System.Drawing.Point(408, 34);
            this.lstClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(266, 344);
            this.lstClients.TabIndex = 5;
            this.lstClients.DoubleClick += new System.EventHandler(this.lstClients_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Edat";
            // 
            // txtEdat
            // 
            this.txtEdat.Location = new System.Drawing.Point(105, 154);
            this.txtEdat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdat.Name = "txtEdat";
            this.txtEdat.Size = new System.Drawing.Size(52, 26);
            this.txtEdat.TabIndex = 3;
            this.txtEdat.Tag = "IdPlat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nom ";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(105, 74);
            this.txtNomClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(258, 26);
            this.txtNomClient.TabIndex = 1;
            this.txtNomClient.Tag = "Nom";
            // 
            // txtPobClient
            // 
            this.txtPobClient.Location = new System.Drawing.Point(105, 114);
            this.txtPobClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPobClient.Name = "txtPobClient";
            this.txtPobClient.Size = new System.Drawing.Size(258, 26);
            this.txtPobClient.TabIndex = 2;
            this.txtPobClient.Tag = "Descripcio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Població";
            // 
            // btnActualitzarHotel
            // 
            this.btnActualitzarHotel.Location = new System.Drawing.Point(276, 194);
            this.btnActualitzarHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualitzarHotel.Name = "btnActualitzarHotel";
            this.btnActualitzarHotel.Size = new System.Drawing.Size(106, 35);
            this.btnActualitzarHotel.TabIndex = 4;
            this.btnActualitzarHotel.Text = "Actualitzar";
            this.btnActualitzarHotel.UseVisualStyleBackColor = true;
            this.btnActualitzarHotel.Click += new System.EventHandler(this.btnActualitzarHotel_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(219, 194);
            this.btnActualitzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(106, 35);
            this.btnActualitzar.TabIndex = 4;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // grbHotels
            // 
            this.grbHotels.Controls.Add(this.btnAfegirHotel);
            this.grbHotels.Controls.Add(this.btnEsborrarHotel);
            this.grbHotels.Controls.Add(this.btnEditarHotel);
            this.grbHotels.Controls.Add(this.lstHotels);
            this.grbHotels.Controls.Add(this.txtCodi);
            this.grbHotels.Controls.Add(this.btnActualitzarHotel);
            this.grbHotels.Controls.Add(this.txtNomHotel);
            this.grbHotels.Controls.Add(this.txtPobHotel);
            this.grbHotels.Controls.Add(this.label1);
            this.grbHotels.Controls.Add(this.label2);
            this.grbHotels.Controls.Add(this.label3);
            this.grbHotels.Controls.Add(this.txtNumHab);
            this.grbHotels.Controls.Add(this.label4);
            this.grbHotels.Location = new System.Drawing.Point(18, 32);
            this.grbHotels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHotels.Name = "grbHotels";
            this.grbHotels.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHotels.Size = new System.Drawing.Size(768, 405);
            this.grbHotels.TabIndex = 27;
            this.grbHotels.TabStop = false;
            this.grbHotels.Text = "Hotels";
            // 
            // btnAfegirHotel
            // 
            this.btnAfegirHotel.Location = new System.Drawing.Point(160, 194);
            this.btnAfegirHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAfegirHotel.Name = "btnAfegirHotel";
            this.btnAfegirHotel.Size = new System.Drawing.Size(106, 35);
            this.btnAfegirHotel.TabIndex = 32;
            this.btnAfegirHotel.Text = "Afegir";
            this.btnAfegirHotel.UseVisualStyleBackColor = true;
            this.btnAfegirHotel.Click += new System.EventHandler(this.btnAfegirHotel_Click_1);
            // 
            // btnEsborrarHotel
            // 
            this.btnEsborrarHotel.Location = new System.Drawing.Point(160, 238);
            this.btnEsborrarHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEsborrarHotel.Name = "btnEsborrarHotel";
            this.btnEsborrarHotel.Size = new System.Drawing.Size(106, 35);
            this.btnEsborrarHotel.TabIndex = 31;
            this.btnEsborrarHotel.Text = "Esborrar";
            this.btnEsborrarHotel.UseVisualStyleBackColor = true;
            this.btnEsborrarHotel.Click += new System.EventHandler(this.btnEsborrarHotel_Click);
            // 
            // btnEditarHotel
            // 
            this.btnEditarHotel.Location = new System.Drawing.Point(276, 238);
            this.btnEditarHotel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarHotel.Name = "btnEditarHotel";
            this.btnEditarHotel.Size = new System.Drawing.Size(106, 35);
            this.btnEditarHotel.TabIndex = 6;
            this.btnEditarHotel.Text = "Editar";
            this.btnEditarHotel.UseVisualStyleBackColor = true;
            this.btnEditarHotel.Click += new System.EventHandler(this.btnEditarHotel_Click);
            // 
            // grbClients
            // 
            this.grbClients.Controls.Add(this.btnAfegirClient);
            this.grbClients.Controls.Add(this.btnEsborrarClient);
            this.grbClients.Controls.Add(this.btnEditClient);
            this.grbClients.Controls.Add(this.label8);
            this.grbClients.Controls.Add(this.txtSoci);
            this.grbClients.Controls.Add(this.lstClients);
            this.grbClients.Controls.Add(this.txtNomClient);
            this.grbClients.Controls.Add(this.btnActualitzar);
            this.grbClients.Controls.Add(this.txtPobClient);
            this.grbClients.Controls.Add(this.label7);
            this.grbClients.Controls.Add(this.label5);
            this.grbClients.Controls.Add(this.label6);
            this.grbClients.Controls.Add(this.txtEdat);
            this.grbClients.Location = new System.Drawing.Point(830, 32);
            this.grbClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbClients.Name = "grbClients";
            this.grbClients.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbClients.Size = new System.Drawing.Size(700, 405);
            this.grbClients.TabIndex = 28;
            this.grbClients.TabStop = false;
            this.grbClients.Text = "Clients";
            // 
            // btnAfegirClient
            // 
            this.btnAfegirClient.Location = new System.Drawing.Point(104, 194);
            this.btnAfegirClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAfegirClient.Name = "btnAfegirClient";
            this.btnAfegirClient.Size = new System.Drawing.Size(106, 35);
            this.btnAfegirClient.TabIndex = 30;
            this.btnAfegirClient.Text = "Afegir";
            this.btnAfegirClient.UseVisualStyleBackColor = true;
            this.btnAfegirClient.Click += new System.EventHandler(this.btnAfegirClient_Click);
            // 
            // btnEsborrarClient
            // 
            this.btnEsborrarClient.Location = new System.Drawing.Point(105, 238);
            this.btnEsborrarClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEsborrarClient.Name = "btnEsborrarClient";
            this.btnEsborrarClient.Size = new System.Drawing.Size(106, 35);
            this.btnEsborrarClient.TabIndex = 29;
            this.btnEsborrarClient.Text = "Esborrar";
            this.btnEsborrarClient.UseVisualStyleBackColor = true;
            this.btnEsborrarClient.Click += new System.EventHandler(this.btnEsborrarClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(220, 238);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(105, 35);
            this.btnEditClient.TabIndex = 6;
            this.btnEditClient.Text = "Editar";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Soci";
            // 
            // txtSoci
            // 
            this.txtSoci.Location = new System.Drawing.Point(104, 34);
            this.txtSoci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoci.Name = "txtSoci";
            this.txtSoci.Size = new System.Drawing.Size(97, 26);
            this.txtSoci.TabIndex = 0;
            this.txtSoci.Tag = "IdPlat";
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(18, 465);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(150, 35);
            this.btnReserva.TabIndex = 30;
            this.btnReserva.Text = "Fer reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // dtgReserves
            // 
            this.dtgReserves.AllowUserToAddRows = false;
            this.dtgReserves.AllowUserToDeleteRows = false;
            this.dtgReserves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgReserves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReserves.Location = new System.Drawing.Point(332, 465);
            this.dtgReserves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgReserves.Name = "dtgReserves";
            this.dtgReserves.ReadOnly = true;
            this.dtgReserves.RowHeadersWidth = 62;
            this.dtgReserves.Size = new System.Drawing.Size(914, 275);
            this.dtgReserves.TabIndex = 31;
            // 
            // dtpReserva
            // 
            this.dtpReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReserva.Location = new System.Drawing.Point(18, 509);
            this.dtpReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(150, 26);
            this.dtpReserva.TabIndex = 33;
            // 
            // txtDies
            // 
            this.txtDies.Location = new System.Drawing.Point(75, 549);
            this.txtDies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDies.Name = "txtDies";
            this.txtDies.Size = new System.Drawing.Size(74, 26);
            this.txtDies.TabIndex = 34;
            this.txtDies.Tag = "IdPlat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 554);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Dies:";
            // 
            // frmHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 1050);
            this.Controls.Add(this.txtDies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpReserva);
            this.Controls.Add(this.dtgReserves);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.grbClients);
            this.Controls.Add(this.grbHotels);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHotels";
            this.Text = "Gestió d\'hotels";
            this.Load += new System.EventHandler(this.frmHotels_Load);
            this.grbHotels.ResumeLayout(false);
            this.grbHotels.PerformLayout();
            this.grbClients.ResumeLayout(false);
            this.grbClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPobHotel;
        private System.Windows.Forms.TextBox txtNomHotel;
        private System.Windows.Forms.TextBox txtCodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumHab;
        private System.Windows.Forms.ListBox lstHotels;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtPobClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualitzarHotel;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.GroupBox grbHotels;
        private System.Windows.Forms.GroupBox grbClients;
        private System.Windows.Forms.Button btnEditarHotel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoci;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnAfegirClient;
        private System.Windows.Forms.Button btnEsborrarClient;
        private System.Windows.Forms.Button btnAfegirHotel;
        private System.Windows.Forms.Button btnEsborrarHotel;
        private System.Windows.Forms.DataGridView dtgReserves;
        private System.Windows.Forms.TextBox txtDies;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtpReserva;
    }
}