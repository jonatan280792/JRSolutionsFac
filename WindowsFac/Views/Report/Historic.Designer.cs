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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBusqueda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.filterFac = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.gridHistorico = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AutoScroll = true;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.btnBusqueda);
            this.bunifuCards1.Controls.Add(this.filterFac);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(21, 24);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(759, 119);
            this.bunifuCards1.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(49, 51);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(424, 13);
            this.bunifuCustomLabel3.TabIndex = 407;
            this.bunifuCustomLabel3.Text = "Busqueda por Factura, Nombre del cliente, Numero documento, Fecha asi (2019/07/28" +
    ")";
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
            this.btnBusqueda.Location = new System.Drawing.Point(505, 68);
            this.btnBusqueda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Primary = true;
            this.btnBusqueda.Size = new System.Drawing.Size(109, 37);
            this.btnBusqueda.TabIndex = 403;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
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
            this.filterFac.Location = new System.Drawing.Point(52, 68);
            this.filterFac.Margin = new System.Windows.Forms.Padding(4);
            this.filterFac.MaxLength = 4;
            this.filterFac.Name = "filterFac";
            this.filterFac.Size = new System.Drawing.Size(421, 33);
            this.filterFac.TabIndex = 402;
            this.filterFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.AutoScroll = true;
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards2.Controls.Add(this.gridHistorico);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(17, 181);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(767, 339);
            this.bunifuCards2.TabIndex = 2;
            // 
            // gridHistorico
            // 
            this.gridHistorico.AllowUserToAddRows = false;
            this.gridHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHistorico.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistorico.DoubleBuffered = true;
            this.gridHistorico.EnableHeadersVisualStyles = false;
            this.gridHistorico.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridHistorico.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.gridHistorico.Location = new System.Drawing.Point(11, 45);
            this.gridHistorico.MultiSelect = false;
            this.gridHistorico.Name = "gridHistorico";
            this.gridHistorico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistorico.Size = new System.Drawing.Size(745, 271);
            this.gridHistorico.StandardTab = true;
            this.gridHistorico.TabIndex = 407;
            this.gridHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imprimir);
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
            this.Load += new System.EventHandler(this.load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBusqueda;
        private Bunifu.Framework.UI.BunifuMetroTextbox filterFac;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridHistorico;
    }
}