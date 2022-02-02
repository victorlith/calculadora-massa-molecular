
namespace WindowsFormsApp12
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
			this.label1 = new System.Windows.Forms.Label();
			this.tbElemento1 = new System.Windows.Forms.TextBox();
			this.tbElemento2 = new System.Windows.Forms.TextBox();
			this.tbResultado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbQuantidade2 = new System.Windows.Forms.TextBox();
			this.tbQuantidade1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabelaPeriodicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnLimparCampos = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.tbElemento5 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tbQuantidade5 = new System.Windows.Forms.TextBox();
			this.tbElemento4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbQuantidade4 = new System.Windows.Forms.TextBox();
			this.tbElemento3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbQuantidade3 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtbResultados = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(208, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calcular Massa Molecular";
			// 
			// tbElemento1
			// 
			this.tbElemento1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbElemento1.Location = new System.Drawing.Point(22, 44);
			this.tbElemento1.Name = "tbElemento1";
			this.tbElemento1.Size = new System.Drawing.Size(100, 22);
			this.tbElemento1.TabIndex = 1;
			this.tbElemento1.TextChanged += new System.EventHandler(this.tbElemento1_TextChanged);
			this.tbElemento1.Leave += new System.EventHandler(this.tbElemento1_Leave);
			// 
			// tbElemento2
			// 
			this.tbElemento2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbElemento2.Location = new System.Drawing.Point(128, 44);
			this.tbElemento2.Name = "tbElemento2";
			this.tbElemento2.Size = new System.Drawing.Size(100, 22);
			this.tbElemento2.TabIndex = 3;
			this.tbElemento2.TextChanged += new System.EventHandler(this.tbElemento2_TextChanged);
			this.tbElemento2.Leave += new System.EventHandler(this.tbElemento2_Leave);
			// 
			// tbResultado
			// 
			this.tbResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tbResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbResultado.Location = new System.Drawing.Point(434, 257);
			this.tbResultado.Name = "tbResultado";
			this.tbResultado.ReadOnly = true;
			this.tbResultado.Size = new System.Drawing.Size(155, 23);
			this.tbResultado.TabIndex = 6;
			this.tbResultado.TabStop = false;
			this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Elemento 1:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(140, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Elemento 2:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(130, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Qtd. Atomos 2:";
			// 
			// tbQuantidade2
			// 
			this.tbQuantidade2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade2.Location = new System.Drawing.Point(128, 92);
			this.tbQuantidade2.Name = "tbQuantidade2";
			this.tbQuantidade2.Size = new System.Drawing.Size(100, 22);
			this.tbQuantidade2.TabIndex = 4;
			// 
			// tbQuantidade1
			// 
			this.tbQuantidade1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade1.Location = new System.Drawing.Point(22, 92);
			this.tbQuantidade1.Name = "tbQuantidade1";
			this.tbQuantidade1.Size = new System.Drawing.Size(100, 22);
			this.tbQuantidade1.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(28, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Qtd. Atmos 1:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(352, 260);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Resultado:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(614, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaPeriodicaToolStripMenuItem,
            this.buscarElementosToolStripMenuItem});
			this.menuToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuToolStripMenuItem.Image = global::AssistenteQuimico.Properties.Resources.icons8_chemical_plant_3_96;
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// tabelaPeriodicaToolStripMenuItem
			// 
			this.tabelaPeriodicaToolStripMenuItem.Image = global::AssistenteQuimico.Properties.Resources.icons8_periodic_table_of_elements_96;
			this.tabelaPeriodicaToolStripMenuItem.Name = "tabelaPeriodicaToolStripMenuItem";
			this.tabelaPeriodicaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.tabelaPeriodicaToolStripMenuItem.Text = "Tabela Periódica";
			this.tabelaPeriodicaToolStripMenuItem.Click += new System.EventHandler(this.tabelaPeriodicaToolStripMenuItem_Click);
			// 
			// buscarElementosToolStripMenuItem
			// 
			this.buscarElementosToolStripMenuItem.Image = global::AssistenteQuimico.Properties.Resources.icons8_h2o_molecule_96;
			this.buscarElementosToolStripMenuItem.Name = "buscarElementosToolStripMenuItem";
			this.buscarElementosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.buscarElementosToolStripMenuItem.Text = "Buscar Elementos";
			this.buscarElementosToolStripMenuItem.Click += new System.EventHandler(this.buscarElementosToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnLimparCampos);
			this.groupBox1.Controls.Add(this.btnCalcular);
			this.groupBox1.Controls.Add(this.tbElemento5);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.tbQuantidade5);
			this.groupBox1.Controls.Add(this.tbElemento4);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.tbQuantidade4);
			this.groupBox1.Controls.Add(this.tbElemento3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.tbQuantidade3);
			this.groupBox1.Controls.Add(this.tbQuantidade1);
			this.groupBox1.Controls.Add(this.tbElemento1);
			this.groupBox1.Controls.Add(this.tbElemento2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbQuantidade2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 76);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 175);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fórmula Química";
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimparCampos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparCampos.Location = new System.Drawing.Point(22, 142);
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Size = new System.Drawing.Size(133, 27);
			this.btnLimparCampos.TabIndex = 22;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimparCampos.UseVisualStyleBackColor = true;
			this.btnLimparCampos.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Image = global::AssistenteQuimico.Properties.Resources.chemical___ico_2;
			this.btnCalcular.Location = new System.Drawing.Point(430, 120);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(116, 49);
			this.btnCalcular.TabIndex = 11;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// tbElemento5
			// 
			this.tbElemento5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbElemento5.Location = new System.Drawing.Point(446, 44);
			this.tbElemento5.Name = "tbElemento5";
			this.tbElemento5.Size = new System.Drawing.Size(100, 22);
			this.tbElemento5.TabIndex = 9;
			this.tbElemento5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			this.tbElemento5.Leave += new System.EventHandler(this.tbElemento5_Leave);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(448, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 17);
			this.label11.TabIndex = 21;
			this.label11.Text = "Qtd. Atomos 5:";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(458, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 17);
			this.label12.TabIndex = 20;
			this.label12.Text = "Elemento 5:";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// tbQuantidade5
			// 
			this.tbQuantidade5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade5.Location = new System.Drawing.Point(446, 92);
			this.tbQuantidade5.Name = "tbQuantidade5";
			this.tbQuantidade5.Size = new System.Drawing.Size(100, 22);
			this.tbQuantidade5.TabIndex = 10;
			this.tbQuantidade5.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// tbElemento4
			// 
			this.tbElemento4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbElemento4.Location = new System.Drawing.Point(340, 44);
			this.tbElemento4.Name = "tbElemento4";
			this.tbElemento4.Size = new System.Drawing.Size(100, 22);
			this.tbElemento4.TabIndex = 7;
			this.tbElemento4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.tbElemento4.Leave += new System.EventHandler(this.tbElemento4_Leave);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(342, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 17);
			this.label9.TabIndex = 17;
			this.label9.Text = "Qtd. Atomos 4:";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(352, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 17);
			this.label10.TabIndex = 16;
			this.label10.Text = "Elemento 4:";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// tbQuantidade4
			// 
			this.tbQuantidade4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade4.Location = new System.Drawing.Point(340, 92);
			this.tbQuantidade4.Name = "tbQuantidade4";
			this.tbQuantidade4.Size = new System.Drawing.Size(100, 22);
			this.tbQuantidade4.TabIndex = 8;
			this.tbQuantidade4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// tbElemento3
			// 
			this.tbElemento3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbElemento3.Location = new System.Drawing.Point(234, 44);
			this.tbElemento3.Name = "tbElemento3";
			this.tbElemento3.Size = new System.Drawing.Size(100, 22);
			this.tbElemento3.TabIndex = 5;
			this.tbElemento3.Leave += new System.EventHandler(this.tbElemento3_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(236, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Qtd. Atomos 3:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(246, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Elemento 3:";
			// 
			// tbQuantidade3
			// 
			this.tbQuantidade3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbQuantidade3.Location = new System.Drawing.Point(234, 92);
			this.tbQuantidade3.Name = "tbQuantidade3";
			this.tbQuantidade3.Size = new System.Drawing.Size(100, 22);
			this.tbQuantidade3.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rtbResultados);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(25, 277);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 142);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Resultado Detalhado:";
			// 
			// rtbResultados
			// 
			this.rtbResultados.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rtbResultados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbResultados.Location = new System.Drawing.Point(6, 20);
			this.rtbResultados.Name = "rtbResultados";
			this.rtbResultados.ReadOnly = true;
			this.rtbResultados.Size = new System.Drawing.Size(267, 116);
			this.rtbResultados.TabIndex = 15;
			this.rtbResultados.TabStop = false;
			this.rtbResultados.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AssistenteQuimico.Properties.Resources.img2;
			this.pictureBox1.Location = new System.Drawing.Point(320, 286);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(269, 133);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// MenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 432);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MenuPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Assistente Químico v1.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElemento1;
        private System.Windows.Forms.TextBox tbElemento2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantidade2;
        private System.Windows.Forms.TextBox tbQuantidade1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaPeriodicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarElementosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbElemento4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbQuantidade4;
        private System.Windows.Forms.TextBox tbElemento3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQuantidade3;
        private System.Windows.Forms.TextBox tbElemento5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbQuantidade5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Button btnLimparCampos;
		private System.Windows.Forms.PictureBox pictureBox1;
    }
}

