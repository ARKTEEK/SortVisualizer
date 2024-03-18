using System.Windows.Forms;

namespace SortVisualizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.graphCard1 = new SortVisualizer.GraphCard();
            this.graphCard2 = new SortVisualizer.GraphCard();
            this.graphCard3 = new SortVisualizer.GraphCard();
            this.graphCard4 = new SortVisualizer.GraphCard();
            this.graphCard5 = new SortVisualizer.GraphCard();
            this.graphCard7 = new SortVisualizer.GraphCard();
            this.graphCard8 = new SortVisualizer.GraphCard();
            this.graphCard9 = new SortVisualizer.GraphCard();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.numericUpDown1.Location = new System.Drawing.Point(12, 55);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(179, 35);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter size of array";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(195)))), ((int)(((byte)(216)))));
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 511);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(334, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Disable visualization (better sorting speeds)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(213)))), ((int)(((byte)(228)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.richTextBox1.Location = new System.Drawing.Point(460, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(512, 124);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(99)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(233, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate numbers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.graphCard1);
            this.flowLayoutPanel1.Controls.Add(this.graphCard2);
            this.flowLayoutPanel1.Controls.Add(this.graphCard3);
            this.flowLayoutPanel1.Controls.Add(this.graphCard4);
            this.flowLayoutPanel1.Controls.Add(this.graphCard5);
            this.flowLayoutPanel1.Controls.Add(this.graphCard7);
            this.flowLayoutPanel1.Controls.Add(this.graphCard8);
            this.flowLayoutPanel1.Controls.Add(this.graphCard9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 351);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // graphCard1
            // 
            this.graphCard1.Location = new System.Drawing.Point(3, 3);
            this.graphCard1.Name = "graphCard1";
            this.graphCard1.Size = new System.Drawing.Size(305, 311);
            this.graphCard1.TabIndex = 0;
            // 
            // graphCard2
            // 
            this.graphCard2.Location = new System.Drawing.Point(314, 3);
            this.graphCard2.Name = "graphCard2";
            this.graphCard2.Size = new System.Drawing.Size(305, 311);
            this.graphCard2.TabIndex = 1;
            // 
            // graphCard3
            // 
            this.graphCard3.Location = new System.Drawing.Point(625, 3);
            this.graphCard3.Name = "graphCard3";
            this.graphCard3.Size = new System.Drawing.Size(305, 311);
            this.graphCard3.TabIndex = 2;
            // 
            // graphCard4
            // 
            this.graphCard4.Location = new System.Drawing.Point(3, 320);
            this.graphCard4.Name = "graphCard4";
            this.graphCard4.Size = new System.Drawing.Size(305, 311);
            this.graphCard4.TabIndex = 3;
            // 
            // graphCard5
            // 
            this.graphCard5.Location = new System.Drawing.Point(314, 320);
            this.graphCard5.Name = "graphCard5";
            this.graphCard5.Size = new System.Drawing.Size(305, 311);
            this.graphCard5.TabIndex = 4;
            // 
            // graphCard7
            // 
            this.graphCard7.Location = new System.Drawing.Point(625, 320);
            this.graphCard7.Name = "graphCard7";
            this.graphCard7.Size = new System.Drawing.Size(305, 311);
            this.graphCard7.TabIndex = 9;
            // 
            // graphCard8
            // 
            this.graphCard8.Location = new System.Drawing.Point(3, 637);
            this.graphCard8.Name = "graphCard8";
            this.graphCard8.Size = new System.Drawing.Size(305, 311);
            this.graphCard8.TabIndex = 10;
            // 
            // graphCard9
            // 
            this.graphCard9.Location = new System.Drawing.Point(314, 637);
            this.graphCard9.Name = "graphCard9";
            this.graphCard9.Size = new System.Drawing.Size(305, 311);
            this.graphCard9.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Sorting Algorithms Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private Button button1;
        private GraphCard graphCard5;
        private GraphCard graphCard4;
        private GraphCard graphCard3;
        private GraphCard graphCard2;
        private GraphCard graphCard1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBox1;
        private GraphCard graphCard7;
        private GraphCard graphCard8;
        private GraphCard graphCard9;
    }
}

