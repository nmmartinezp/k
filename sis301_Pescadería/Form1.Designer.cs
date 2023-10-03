
namespace sis301_Pescadería
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.PanelBarra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lnhelp = new System.Windows.Forms.Label();
            this.lbcont = new System.Windows.Forms.Label();
            this.lbusu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.PanelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.BackColor = System.Drawing.Color.Transparent;
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(659, 352);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(32, 32);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.PanelBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBarra.Controls.Add(this.btnMinimizar);
            this.PanelBarra.Controls.Add(this.btnCerrar);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Location = new System.Drawing.Point(0, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.Size = new System.Drawing.Size(715, 36);
            this.PanelBarra.TabIndex = 1;
            this.PanelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarra_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(634, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(672, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.pictureBox1);
            this.PanelMain.Controls.Add(this.pblogo);
            this.PanelMain.Controls.Add(this.btniniciar);
            this.PanelMain.Controls.Add(this.txtcontra);
            this.PanelMain.Controls.Add(this.txtusuario);
            this.PanelMain.Controls.Add(this.lnhelp);
            this.PanelMain.Controls.Add(this.lbcont);
            this.PanelMain.Controls.Add(this.lbusu);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 36);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(715, 395);
            this.PanelMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(326, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btniniciar
            // 
            this.btniniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btniniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(153)))));
            this.btniniciar.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btniniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btniniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btniniciar.Location = new System.Drawing.Point(297, 270);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(130, 22);
            this.btniniciar.TabIndex = 6;
            this.btniniciar.Text = "Ingresar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcontra.Location = new System.Drawing.Point(244, 227);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(233, 20);
            this.txtcontra.TabIndex = 4;
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusuario.Location = new System.Drawing.Point(244, 183);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(233, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // lnhelp
            // 
            this.lnhelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnhelp.AutoSize = true;
            this.lnhelp.BackColor = System.Drawing.Color.Transparent;
            this.lnhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnhelp.ForeColor = System.Drawing.Color.GhostWhite;
            this.lnhelp.Location = new System.Drawing.Point(294, 304);
            this.lnhelp.Name = "lnhelp";
            this.lnhelp.Size = new System.Drawing.Size(131, 13);
            this.lnhelp.TabIndex = 2;
            this.lnhelp.Text = "¿Olvidaste tu contraseña?";
            // 
            // lbcont
            // 
            this.lbcont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcont.AutoSize = true;
            this.lbcont.BackColor = System.Drawing.Color.Transparent;
            this.lbcont.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcont.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbcont.Location = new System.Drawing.Point(241, 210);
            this.lbcont.Name = "lbcont";
            this.lbcont.Size = new System.Drawing.Size(61, 15);
            this.lbcont.TabIndex = 1;
            this.lbcont.Text = "Contraseña";
            // 
            // lbusu
            // 
            this.lbusu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbusu.AutoSize = true;
            this.lbusu.BackColor = System.Drawing.Color.Transparent;
            this.lbusu.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbusu.Location = new System.Drawing.Point(241, 167);
            this.lbusu.Name = "lbusu";
            this.lbusu.Size = new System.Drawing.Size(43, 15);
            this.lbusu.TabIndex = 0;
            this.lbusu.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 431);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.PanelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBarra;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label lnhelp;
        private System.Windows.Forms.Label lbcont;
        private System.Windows.Forms.Label lbusu;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

