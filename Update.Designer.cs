namespace entregable
{
    partial class Update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txttipo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtautor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtnobjeto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtctema = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcdarticulo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.upload_file = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.rutaTexto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizar";
            // 
            // txttipo
            // 
            this.txttipo.BorderColorFocused = System.Drawing.Color.Silver;
            this.txttipo.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txttipo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttipo.BorderThickness = 1;
            this.txttipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.ForeColor = System.Drawing.Color.White;
            this.txttipo.isPassword = false;
            this.txttipo.Location = new System.Drawing.Point(29, 472);
            this.txttipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(332, 33);
            this.txttipo.TabIndex = 39;
            this.txttipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttipo.OnValueChanged += new System.EventHandler(this.txtcMB_OnValueChanged);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(29, 337);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(332, 22);
            this.bunifuDatepicker1.TabIndex = 38;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            // 
            // txtautor
            // 
            this.txtautor.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtautor.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtautor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtautor.BorderThickness = 1;
            this.txtautor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.ForeColor = System.Drawing.Color.White;
            this.txtautor.isPassword = false;
            this.txtautor.Location = new System.Drawing.Point(29, 403);
            this.txtautor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(332, 33);
            this.txtautor.TabIndex = 37;
            this.txtautor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtnobjeto
            // 
            this.txtnobjeto.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtnobjeto.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtnobjeto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnobjeto.BorderThickness = 1;
            this.txtnobjeto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnobjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnobjeto.ForeColor = System.Drawing.Color.White;
            this.txtnobjeto.isPassword = false;
            this.txtnobjeto.Location = new System.Drawing.Point(29, 269);
            this.txtnobjeto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnobjeto.Name = "txtnobjeto";
            this.txtnobjeto.Size = new System.Drawing.Size(332, 33);
            this.txtnobjeto.TabIndex = 36;
            this.txtnobjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtctema
            // 
            this.txtctema.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtctema.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtctema.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtctema.BorderThickness = 1;
            this.txtctema.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtctema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtctema.ForeColor = System.Drawing.Color.White;
            this.txtctema.isPassword = false;
            this.txtctema.Location = new System.Drawing.Point(29, 198);
            this.txtctema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtctema.Name = "txtctema";
            this.txtctema.Size = new System.Drawing.Size(332, 33);
            this.txtctema.TabIndex = 35;
            this.txtctema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcdarticulo
            // 
            this.txtcdarticulo.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtcdarticulo.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.txtcdarticulo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcdarticulo.BorderThickness = 1;
            this.txtcdarticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcdarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdarticulo.ForeColor = System.Drawing.Color.White;
            this.txtcdarticulo.isPassword = false;
            this.txtcdarticulo.Location = new System.Drawing.Point(29, 127);
            this.txtcdarticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcdarticulo.Name = "txtcdarticulo";
            this.txtcdarticulo.Size = new System.Drawing.Size(332, 33);
            this.txtcdarticulo.TabIndex = 34;
            this.txtcdarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(77, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(77, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Autor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(77, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(77, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre del objeto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(88, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Codigo del tema";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(88, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo del articulo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtdescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.White;
            this.txtdescripcion.Location = new System.Drawing.Point(411, 304);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(308, 298);
            this.txtdescripcion.TabIndex = 42;
            this.txtdescripcion.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(446, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ActiveBorderThickness = 1;
            this.btnAceptar.ActiveCornerRadius = 1;
            this.btnAceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.btnAceptar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAceptar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.IdleBorderThickness = 1;
            this.btnAceptar.IdleCornerRadius = 1;
            this.btnAceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btnAceptar.IdleForecolor = System.Drawing.Color.White;
            this.btnAceptar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(307, 663);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(181, 41);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(672, 51);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 44;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // upload_file
            // 
            this.upload_file.ActiveBorderThickness = 1;
            this.upload_file.ActiveCornerRadius = 1;
            this.upload_file.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.upload_file.ActiveForecolor = System.Drawing.Color.White;
            this.upload_file.ActiveLineColor = System.Drawing.Color.Transparent;
            this.upload_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.upload_file.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload_file.BackgroundImage")));
            this.upload_file.ButtonText = "Subir Archivo";
            this.upload_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload_file.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_file.ForeColor = System.Drawing.Color.SeaGreen;
            this.upload_file.IdleBorderThickness = 1;
            this.upload_file.IdleCornerRadius = 1;
            this.upload_file.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.upload_file.IdleForecolor = System.Drawing.Color.White;
            this.upload_file.IdleLineColor = System.Drawing.Color.Transparent;
            this.upload_file.Location = new System.Drawing.Point(30, 538);
            this.upload_file.Margin = new System.Windows.Forms.Padding(5);
            this.upload_file.Name = "upload_file";
            this.upload_file.Size = new System.Drawing.Size(155, 41);
            this.upload_file.TabIndex = 45;
            this.upload_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upload_file.Click += new System.EventHandler(this.upload_file_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(33, 578);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ruta Archivo";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // rutaTexto
            // 
            this.rutaTexto.BorderColorFocused = System.Drawing.Color.Silver;
            this.rutaTexto.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.rutaTexto.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rutaTexto.BorderThickness = 1;
            this.rutaTexto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rutaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaTexto.ForeColor = System.Drawing.Color.White;
            this.rutaTexto.isPassword = false;
            this.rutaTexto.Location = new System.Drawing.Point(29, 608);
            this.rutaTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rutaTexto.Name = "rutaTexto";
            this.rutaTexto.Size = new System.Drawing.Size(332, 33);
            this.rutaTexto.TabIndex = 48;
            this.rutaTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rutaTexto.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged_1);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(770, 718);
            this.Controls.Add(this.rutaTexto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.upload_file);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtnobjeto);
            this.Controls.Add(this.txtctema);
            this.Controls.Add(this.txtcdarticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txttipo;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtautor;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtnobjeto;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtctema;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtcdarticulo;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox txtdescripcion;
        public System.Windows.Forms.Label label8;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAceptar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuThinButton2 upload_file;
        public System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuMetroTextbox rutaTexto;
    }
}