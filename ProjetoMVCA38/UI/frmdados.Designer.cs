namespace ProjetoMVCA38.UI
{
    partial class frmdados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdados));
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txtCpfA38 = new System.Windows.Forms.TextBox();
            this.txt_nomecompletoA38 = new System.Windows.Forms.TextBox();
            this.lbl_nomecompleto = new System.Windows.Forms.Label();
            this.txt_nomemaeA38 = new System.Windows.Forms.TextBox();
            this.lbl_Nomemae = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(87, 105);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(42, 17);
            this.lbl_cpf.TabIndex = 0;
            this.lbl_cpf.Text = "CPF:";
            // 
            // txtCpfA38
            // 
            this.txtCpfA38.Location = new System.Drawing.Point(87, 148);
            this.txtCpfA38.Name = "txtCpfA38";
            this.txtCpfA38.Size = new System.Drawing.Size(427, 22);
            this.txtCpfA38.TabIndex = 1;
            this.txtCpfA38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfA38_KeyPress);
            // 
            // txt_nomecompletoA38
            // 
            this.txt_nomecompletoA38.Location = new System.Drawing.Point(87, 235);
            this.txt_nomecompletoA38.Name = "txt_nomecompletoA38";
            this.txt_nomecompletoA38.Size = new System.Drawing.Size(427, 22);
            this.txt_nomecompletoA38.TabIndex = 4;
            // 
            // lbl_nomecompleto
            // 
            this.lbl_nomecompleto.AutoSize = true;
            this.lbl_nomecompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomecompleto.Location = new System.Drawing.Point(87, 195);
            this.lbl_nomecompleto.Name = "lbl_nomecompleto";
            this.lbl_nomecompleto.Size = new System.Drawing.Size(126, 17);
            this.lbl_nomecompleto.TabIndex = 3;
            this.lbl_nomecompleto.Text = "Nome Completo:";
            // 
            // txt_nomemaeA38
            // 
            this.txt_nomemaeA38.Location = new System.Drawing.Point(87, 330);
            this.txt_nomemaeA38.Name = "txt_nomemaeA38";
            this.txt_nomemaeA38.Size = new System.Drawing.Size(427, 22);
            this.txt_nomemaeA38.TabIndex = 6;
            // 
            // lbl_Nomemae
            // 
            this.lbl_Nomemae.AutoSize = true;
            this.lbl_Nomemae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomemae.Location = new System.Drawing.Point(87, 290);
            this.lbl_Nomemae.Name = "lbl_Nomemae";
            this.lbl_Nomemae.Size = new System.Drawing.Size(112, 17);
            this.lbl_Nomemae.TabIndex = 5;
            this.lbl_Nomemae.Text = "Nome da mãe:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(209, 393);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 30);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(146, 80);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(317, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Por favor, complete o formulário completo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultar benefício";
            // 
            // frmdados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(583, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_nomemaeA38);
            this.Controls.Add(this.lbl_Nomemae);
            this.Controls.Add(this.txt_nomecompletoA38);
            this.Controls.Add(this.lbl_nomecompleto);
            this.Controls.Add(this.txtCpfA38);
            this.Controls.Add(this.lbl_cpf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdados";
            this.Text = "Consultar benefício";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txtCpfA38;
        private System.Windows.Forms.TextBox txt_nomecompletoA38;
        private System.Windows.Forms.Label lbl_nomecompleto;
        private System.Windows.Forms.TextBox txt_nomemaeA38;
        private System.Windows.Forms.Label lbl_Nomemae;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}