﻿
namespace appE2Colsis.Vista
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnNotas = new Guna.UI.WinForms.GunaButton();
            this.btnReporte = new Guna.UI.WinForms.GunaButton();
            this.lblnombreApellido = new Guna.UI.WinForms.GunaLabel();
            this.btnRol = new Guna.UI.WinForms.GunaButton();
            this.btnPersona = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pnNombre = new System.Windows.Forms.Panel();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnNotas);
            this.gunaPanel1.Controls.Add(this.btnReporte);
            this.gunaPanel1.Controls.Add(this.lblnombreApellido);
            this.gunaPanel1.Controls.Add(this.btnRol);
            this.gunaPanel1.Controls.Add(this.btnPersona);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Location = new System.Drawing.Point(2, 2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(299, 739);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnNotas
            // 
            this.btnNotas.AnimationHoverSpeed = 0.07F;
            this.btnNotas.AnimationSpeed = 0.03F;
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNotas.BorderColor = System.Drawing.Color.Black;
            this.btnNotas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotas.FocusedColor = System.Drawing.Color.Empty;
            this.btnNotas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNotas.Location = new System.Drawing.Point(26, 512);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNotas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNotas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNotas.OnHoverImage = null;
            this.btnNotas.OnPressedColor = System.Drawing.Color.Black;
            this.btnNotas.Radius = 20;
            this.btnNotas.Size = new System.Drawing.Size(258, 42);
            this.btnNotas.TabIndex = 7;
            this.btnNotas.Text = "Notas";
            this.btnNotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AnimationHoverSpeed = 0.07F;
            this.btnReporte.AnimationSpeed = 0.03F;
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReporte.BorderColor = System.Drawing.Color.Black;
            this.btnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReporte.Location = new System.Drawing.Point(38, 344);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReporte.OnHoverImage = null;
            this.btnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.btnReporte.Radius = 20;
            this.btnReporte.Size = new System.Drawing.Size(258, 42);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblnombreApellido
            // 
            this.lblnombreApellido.AutoSize = true;
            this.lblnombreApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreApellido.Location = new System.Drawing.Point(53, 142);
            this.lblnombreApellido.Name = "lblnombreApellido";
            this.lblnombreApellido.Size = new System.Drawing.Size(121, 22);
            this.lblnombreApellido.TabIndex = 5;
            this.lblnombreApellido.Text = "gunaLabel1";
            // 
            // btnRol
            // 
            this.btnRol.AnimationHoverSpeed = 0.07F;
            this.btnRol.AnimationSpeed = 0.03F;
            this.btnRol.BackColor = System.Drawing.Color.Transparent;
            this.btnRol.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRol.BorderColor = System.Drawing.Color.Black;
            this.btnRol.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRol.FocusedColor = System.Drawing.Color.Empty;
            this.btnRol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.Color.White;
            this.btnRol.Image = ((System.Drawing.Image)(resources.GetObject("btnRol.Image")));
            this.btnRol.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRol.Location = new System.Drawing.Point(38, 287);
            this.btnRol.Name = "btnRol";
            this.btnRol.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRol.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRol.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRol.OnHoverImage = null;
            this.btnRol.OnPressedColor = System.Drawing.Color.Black;
            this.btnRol.Radius = 20;
            this.btnRol.Size = new System.Drawing.Size(258, 42);
            this.btnRol.TabIndex = 2;
            this.btnRol.Text = "Rol";
            this.btnRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.AnimationHoverSpeed = 0.07F;
            this.btnPersona.AnimationSpeed = 0.03F;
            this.btnPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnPersona.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPersona.BorderColor = System.Drawing.Color.Black;
            this.btnPersona.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPersona.FocusedColor = System.Drawing.Color.Empty;
            this.btnPersona.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersona.ForeColor = System.Drawing.Color.White;
            this.btnPersona.Image = ((System.Drawing.Image)(resources.GetObject("btnPersona.Image")));
            this.btnPersona.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPersona.Location = new System.Drawing.Point(41, 224);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPersona.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPersona.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPersona.OnHoverImage = null;
            this.btnPersona.OnPressedColor = System.Drawing.Color.Black;
            this.btnPersona.Radius = 20;
            this.btnPersona.Size = new System.Drawing.Size(255, 46);
            this.btnPersona.TabIndex = 1;
            this.btnPersona.Text = "Persona";
            this.btnPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(82, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 50;
            this.gunaPictureBox1.Size = new System.Drawing.Size(104, 99);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pnNombre
            // 
            this.pnNombre.AutoSize = true;
            this.pnNombre.BackColor = System.Drawing.Color.White;
            this.pnNombre.Location = new System.Drawing.Point(280, 2);
            this.pnNombre.Name = "pnNombre";
            this.pnNombre.Size = new System.Drawing.Size(920, 739);
            this.pnNombre.TabIndex = 1;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 744);
            this.Controls.Add(this.pnNombre);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lblnombreApellido;
        private Guna.UI.WinForms.GunaButton btnRol;
        private Guna.UI.WinForms.GunaButton btnPersona;
        private System.Windows.Forms.Panel pnNombre;
        private Guna.UI.WinForms.GunaButton btnReporte;
        private Guna.UI.WinForms.GunaButton btnNotas;
    }
}