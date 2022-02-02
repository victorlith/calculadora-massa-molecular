
namespace WindowsFormsApp12
{
    partial class BuscarElemento
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbMassaElemento = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbCamadaElemento = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbNomeElemento = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbSimboloElemento = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNomeElemento = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscarElemento = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbMassaElemento);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.lbCamadaElemento);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lbNomeElemento);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lbSimboloElemento);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 114);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(315, 145);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informações:";
			// 
			// lbMassaElemento
			// 
			this.lbMassaElemento.AutoSize = true;
			this.lbMassaElemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMassaElemento.Location = new System.Drawing.Point(132, 122);
			this.lbMassaElemento.Name = "lbMassaElemento";
			this.lbMassaElemento.Size = new System.Drawing.Size(20, 17);
			this.lbMassaElemento.TabIndex = 7;
			this.lbMassaElemento.Text = "---";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(131, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 21);
			this.label8.TabIndex = 6;
			this.label8.Text = "Massa Atômica:";
			// 
			// lbCamadaElemento
			// 
			this.lbCamadaElemento.AutoSize = true;
			this.lbCamadaElemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCamadaElemento.Location = new System.Drawing.Point(131, 51);
			this.lbCamadaElemento.Name = "lbCamadaElemento";
			this.lbCamadaElemento.Size = new System.Drawing.Size(20, 17);
			this.lbCamadaElemento.TabIndex = 5;
			this.lbCamadaElemento.Text = "---";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(131, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 21);
			this.label6.TabIndex = 4;
			this.label6.Text = "Camada de Eletrons:";
			// 
			// lbNomeElemento
			// 
			this.lbNomeElemento.AutoSize = true;
			this.lbNomeElemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNomeElemento.Location = new System.Drawing.Point(22, 122);
			this.lbNomeElemento.Name = "lbNomeElemento";
			this.lbNomeElemento.Size = new System.Drawing.Size(20, 17);
			this.lbNomeElemento.TabIndex = 3;
			this.lbNomeElemento.Text = "---";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Nome:";
			// 
			// lbSimboloElemento
			// 
			this.lbSimboloElemento.AutoSize = true;
			this.lbSimboloElemento.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSimboloElemento.Location = new System.Drawing.Point(22, 44);
			this.lbSimboloElemento.Name = "lbSimboloElemento";
			this.lbSimboloElemento.Size = new System.Drawing.Size(68, 44);
			this.lbSimboloElemento.TabIndex = 1;
			this.lbSimboloElemento.Text = "---";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Símbolo:";
			// 
			// tbNomeElemento
			// 
			this.tbNomeElemento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNomeElemento.Location = new System.Drawing.Point(60, 38);
			this.tbNomeElemento.Name = "tbNomeElemento";
			this.tbNomeElemento.Size = new System.Drawing.Size(219, 21);
			this.tbNomeElemento.TabIndex = 0;
			this.tbNomeElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeElemento_KeyDown);
			this.tbNomeElemento.Leave += new System.EventHandler(this.tbNomeElemento_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Digite o Nome ou Simbolo do Elemento:";
			// 
			// btnBuscarElemento
			// 
			this.btnBuscarElemento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscarElemento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarElemento.Image = global::AssistenteQuimico.Properties.Resources.icon6;
			this.btnBuscarElemento.Location = new System.Drawing.Point(112, 65);
			this.btnBuscarElemento.Name = "btnBuscarElemento";
			this.btnBuscarElemento.Size = new System.Drawing.Size(115, 43);
			this.btnBuscarElemento.TabIndex = 1;
			this.btnBuscarElemento.Text = "Buscar";
			this.btnBuscarElemento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscarElemento.UseVisualStyleBackColor = true;
			this.btnBuscarElemento.Click += new System.EventHandler(this.btnBuscarElemento_Click);
			// 
			// BuscarElemento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 271);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBuscarElemento);
			this.Controls.Add(this.tbNomeElemento);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "BuscarElemento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Elemento";
			this.Load += new System.EventHandler(this.AdicionarElementos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbNomeElemento;
		private System.Windows.Forms.Button btnBuscarElemento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbMassaElemento;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbCamadaElemento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbNomeElemento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbSimboloElemento;
		private System.Windows.Forms.Label label2;
	}
}