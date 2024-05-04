namespace CalculadoraPrestamos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonto = new TextBox();
            txtAños = new TextBox();
            txtInteres = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            label5 = new Label();
            txtAcumulados = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Monto Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 100);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Tasa de Interes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 162);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de años a Pagar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 277);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Capital Final";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(330, 60);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 4;
            // 
            // txtAños
            // 
            txtAños.Location = new Point(325, 190);
            txtAños.Name = "txtAños";
            txtAños.Size = new Size(125, 27);
            txtAños.TabIndex = 5;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(330, 132);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(125, 27);
            txtInteres.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(325, 309);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(344, 232);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 350);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 9;
            label5.Text = "Intereses Acumulados";
            // 
            // txtAcumulados
            // 
            txtAcumulados.Location = new Point(325, 385);
            txtAcumulados.Name = "txtAcumulados";
            txtAcumulados.Size = new Size(125, 27);
            txtAcumulados.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAcumulados);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtInteres);
            Controls.Add(txtAños);
            Controls.Add(txtMonto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonto;
        private TextBox txtAños;
        private TextBox txtInteres;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label5;
        private TextBox txtAcumulados;
    }
}
