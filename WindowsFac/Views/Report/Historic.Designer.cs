namespace WindowsFac.Views.Report
{
    partial class Historic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historic));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBusqueda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.filterFac = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filterDocumento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.filterCliente = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.filterFecha = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoScroll = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.filterFecha);
            this.bunifuCards1.Controls.Add(this.filterCliente);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.filterDocumento);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.btnBusqueda);
            this.bunifuCards1.Controls.Add(this.filterFac);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel16);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(21, 31);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(759, 152);
            this.bunifuCards1.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(281, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(222, 25);
            this.bunifuCustomLabel2.TabIndex = 406;
            this.bunifuCustomLabel2.Text = "Busqueda de facturas";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.Depth = 0;
            this.btnBusqueda.Location = new System.Drawing.Point(613, 105);
            this.btnBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Primary = true;
            this.btnBusqueda.Size = new System.Drawing.Size(109, 37);
            this.btnBusqueda.TabIndex = 403;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // filterFac
            // 
            this.filterFac.BorderColorFocused = System.Drawing.Color.Violet;
            this.filterFac.BorderColorIdle = System.Drawing.Color.Purple;
            this.filterFac.BorderColorMouseHover = System.Drawing.Color.Violet;
            this.filterFac.BorderThickness = 2;
            this.filterFac.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.filterFac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterFac.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filterFac.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.filterFac.isPassword = false;
            this.filterFac.Location = new System.Drawing.Point(17, 64);
            this.filterFac.Margin = new System.Windows.Forms.Padding(4);
            this.filterFac.MaxLength = 4;
            this.filterFac.Name = "filterFac";
            this.filterFac.Size = new System.Drawing.Size(108, 33);
            this.filterFac.TabIndex = 402;
            this.filterFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(46, 51);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(58, 13);
            this.bunifuCustomLabel16.TabIndex = 401;
            this.bunifuCustomLabel16.Text = "N° Factura";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(182, 51);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel1.TabIndex = 404;
            this.bunifuCustomLabel1.Text = "N° Documento";
            // 
            // filterDocumento
            // 
            this.filterDocumento.BorderColorFocused = System.Drawing.Color.Violet;
            this.filterDocumento.BorderColorIdle = System.Drawing.Color.Purple;
            this.filterDocumento.BorderColorMouseHover = System.Drawing.Color.Violet;
            this.filterDocumento.BorderThickness = 2;
            this.filterDocumento.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.filterDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filterDocumento.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.filterDocumento.isPassword = false;
            this.filterDocumento.Location = new System.Drawing.Point(141, 64);
            this.filterDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.filterDocumento.MaxLength = 4;
            this.filterDocumento.Name = "filterDocumento";
            this.filterDocumento.Size = new System.Drawing.Size(150, 33);
            this.filterDocumento.TabIndex = 405;
            this.filterDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // filterCliente
            // 
            this.filterCliente.BorderColorFocused = System.Drawing.Color.Violet;
            this.filterCliente.BorderColorIdle = System.Drawing.Color.Purple;
            this.filterCliente.BorderColorMouseHover = System.Drawing.Color.Violet;
            this.filterCliente.BorderThickness = 2;
            this.filterCliente.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.filterCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filterCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filterCliente.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.filterCliente.isPassword = false;
            this.filterCliente.Location = new System.Drawing.Point(308, 64);
            this.filterCliente.Margin = new System.Windows.Forms.Padding(4);
            this.filterCliente.MaxLength = 4;
            this.filterCliente.Name = "filterCliente";
            this.filterCliente.Size = new System.Drawing.Size(193, 33);
            this.filterCliente.TabIndex = 408;
            this.filterCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(381, 51);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(39, 13);
            this.bunifuCustomLabel3.TabIndex = 407;
            this.bunifuCustomLabel3.Text = "Cliente";
            // 
            // filterFecha
            // 
            this.filterFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filterFecha.BorderRadius = 1;
            this.filterFecha.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.filterFecha.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.filterFecha.DisabledColor = System.Drawing.Color.Gray;
            this.filterFecha.DisplayWeekNumbers = false;
            this.filterFecha.DPHeight = 0;
            this.filterFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.filterFecha.FillDatePicker = false;
            this.filterFecha.ForeColor = System.Drawing.Color.Purple;
            this.filterFecha.Icon = ((System.Drawing.Image)(resources.GetObject("filterFecha.Icon")));
            this.filterFecha.IconColor = System.Drawing.Color.Purple;
            this.filterFecha.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.filterFecha.Location = new System.Drawing.Point(519, 64);
            this.filterFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.filterFecha.MinimumSize = new System.Drawing.Size(217, 32);
            this.filterFecha.Name = "filterFecha";
            this.filterFecha.Size = new System.Drawing.Size(217, 32);
            this.filterFecha.TabIndex = 409;
            this.filterFecha.Value = new System.DateTime(1900, 1, 1, 10, 24, 0, 0);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.AutoScroll = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards2.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(21, 222);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(759, 252);
            this.bunifuCards2.TabIndex = 2;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(281, 15);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(184, 25);
            this.bunifuCustomLabel5.TabIndex = 406;
            this.bunifuCustomLabel5.Text = "Listado de faturas";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(19, 48);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(703, 184);
            this.bunifuCustomDataGrid1.TabIndex = 407;
            // 
            // Historic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historic";
            this.Text = "Historic";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBusqueda;
        private Bunifu.Framework.UI.BunifuMetroTextbox filterFac;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuMetroTextbox filterCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox filterDocumento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker filterFecha;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}