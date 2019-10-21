namespace PaypalExample
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
            this.GetToken = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.DetailsOrder = new System.Windows.Forms.Button();
            this.AppoveOorder = new System.Windows.Forms.Button();
            this.CaptureOrder = new System.Windows.Forms.Button();
            this.DetalleCaptura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetToken
            // 
            this.GetToken.Location = new System.Drawing.Point(12, 240);
            this.GetToken.Name = "GetToken";
            this.GetToken.Size = new System.Drawing.Size(146, 23);
            this.GetToken.TabIndex = 0;
            this.GetToken.Text = "Obtener Token de Acceso";
            this.GetToken.UseVisualStyleBackColor = true;
            this.GetToken.Click += new System.EventHandler(this.GetToken_Click);
            // 
            // richText
            // 
            this.richText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richText.Location = new System.Drawing.Point(1, -3);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(956, 226);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(164, 240);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(146, 23);
            this.CreateOrder.TabIndex = 2;
            this.CreateOrder.Text = "Crear Orden";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // DetailsOrder
            // 
            this.DetailsOrder.Location = new System.Drawing.Point(316, 240);
            this.DetailsOrder.Name = "DetailsOrder";
            this.DetailsOrder.Size = new System.Drawing.Size(146, 23);
            this.DetailsOrder.TabIndex = 3;
            this.DetailsOrder.Text = "Detalles de Orden";
            this.DetailsOrder.UseVisualStyleBackColor = true;
            this.DetailsOrder.Click += new System.EventHandler(this.DetailsOrder_Click);
            // 
            // AppoveOorder
            // 
            this.AppoveOorder.Location = new System.Drawing.Point(468, 240);
            this.AppoveOorder.Name = "AppoveOorder";
            this.AppoveOorder.Size = new System.Drawing.Size(146, 23);
            this.AppoveOorder.TabIndex = 4;
            this.AppoveOorder.Text = "Aprobar Orden";
            this.AppoveOorder.UseVisualStyleBackColor = true;
            this.AppoveOorder.Click += new System.EventHandler(this.AppoveOorder_Click);
            // 
            // CaptureOrder
            // 
            this.CaptureOrder.Location = new System.Drawing.Point(620, 240);
            this.CaptureOrder.Name = "CaptureOrder";
            this.CaptureOrder.Size = new System.Drawing.Size(146, 23);
            this.CaptureOrder.TabIndex = 5;
            this.CaptureOrder.Text = "Capturar Orden";
            this.CaptureOrder.UseVisualStyleBackColor = true;
            this.CaptureOrder.Click += new System.EventHandler(this.CaptureOrder_Click);
            // 
            // DetalleCaptura
            // 
            this.DetalleCaptura.Location = new System.Drawing.Point(772, 240);
            this.DetalleCaptura.Name = "DetalleCaptura";
            this.DetalleCaptura.Size = new System.Drawing.Size(146, 23);
            this.DetalleCaptura.TabIndex = 6;
            this.DetalleCaptura.Text = "Detalles de Capturar Orden\r\n";
            this.DetalleCaptura.UseVisualStyleBackColor = true;
            this.DetalleCaptura.Click += new System.EventHandler(this.DetalleCaptura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.DetalleCaptura);
            this.Controls.Add(this.CaptureOrder);
            this.Controls.Add(this.AppoveOorder);
            this.Controls.Add(this.DetailsOrder);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.GetToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetToken;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button DetailsOrder;
        private System.Windows.Forms.Button AppoveOorder;
        private System.Windows.Forms.Button CaptureOrder;
        private System.Windows.Forms.Button DetalleCaptura;
    }
}

