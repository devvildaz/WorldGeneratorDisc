namespace WorldGenerator
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ConfigurationBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WorldPreview = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfigurationBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WorldPreview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seed";
            this.label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(44, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(677, 22);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.UseWaitCursor = true;
            this.GenerateButton.Click += new System.EventHandler(this.Generate_Click);
            // 
            // ConfigurationBox
            // 
            this.ConfigurationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfigurationBox.Controls.Add(this.label1);
            this.ConfigurationBox.Controls.Add(this.GenerateButton);
            this.ConfigurationBox.Controls.Add(this.textBox1);
            this.ConfigurationBox.Location = new System.Drawing.Point(12, 0);
            this.ConfigurationBox.Name = "ConfigurationBox";
            this.ConfigurationBox.Size = new System.Drawing.Size(760, 57);
            this.ConfigurationBox.TabIndex = 3;
            this.ConfigurationBox.TabStop = false;
            this.ConfigurationBox.Text = "Configuration";
            this.ConfigurationBox.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.WorldPreview);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 486);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Generated";
            // 
            // WorldPreview
            // 
            this.WorldPreview.BackColor = System.Drawing.Color.White;
            this.WorldPreview.Controls.Add(this.panel2);
            this.WorldPreview.Controls.Add(this.panel1);
            this.WorldPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorldPreview.Location = new System.Drawing.Point(3, 19);
            this.WorldPreview.Name = "WorldPreview";
            this.WorldPreview.Size = new System.Drawing.Size(754, 464);
            this.WorldPreview.TabIndex = 0;
            this.WorldPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorldPreview_MouseDown);
            this.WorldPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorldPreview_MouseMove);
            this.WorldPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorldPreview_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.yLabel);
            this.panel1.Controls.Add(this.xLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 28);
            this.panel1.TabIndex = 0;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(49, 5);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(40, 15);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "32,767";
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(3, 5);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(40, 15);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "32,767";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(647, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 31);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConfigurationBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.ConfigurationBox.ResumeLayout(false);
            this.ConfigurationBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.WorldPreview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button GenerateButton;
        private GroupBox ConfigurationBox;
        private GroupBox groupBox1;
        private Panel WorldPreview;
        private Panel panel1;
        private Label xLabel;
        private Label yLabel;
        private Panel panel2;
        private Button button1;
    }
}