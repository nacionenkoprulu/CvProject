namespace CvProject
{
    partial class KisiListesiForm
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
            components = new System.ComponentModel.Container();
            dgvKisiler = new DataGridView();
            btnReflesh = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            kişiİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKisiler
            // 
            dgvKisiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisiler.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvKisiler.Location = new Point(12, 81);
            dgvKisiler.MultiSelect = false;
            dgvKisiler.Name = "dgvKisiler";
            dgvKisiler.RowHeadersWidth = 51;
            dgvKisiler.RowTemplate.Height = 29;
            dgvKisiler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKisiler.Size = new Size(776, 188);
            dgvKisiler.TabIndex = 0;
            dgvKisiler.RowHeaderMouseDoubleClick += dgvKisiler_RowHeaderMouseDoubleClick;
            // 
            // btnReflesh
            // 
            btnReflesh.Location = new Point(694, 33);
            btnReflesh.Name = "btnReflesh";
            btnReflesh.Size = new Size(94, 29);
            btnReflesh.TabIndex = 1;
            btnReflesh.Text = "Reflesh";
            btnReflesh.UseVisualStyleBackColor = true;
            btnReflesh.Click += btnReflesh_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kişiİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // kişiİşlemleriToolStripMenuItem
            // 
            kişiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, ekleToolStripMenuItem });
            kişiİşlemleriToolStripMenuItem.Name = "kişiİşlemleriToolStripMenuItem";
            kişiİşlemleriToolStripMenuItem.Size = new Size(106, 24);
            kişiİşlemleriToolStripMenuItem.Text = "Kişi İşlemleri";
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(149, 26);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(149, 26);
            ekleToolStripMenuItem.Text = "Ekle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(288, 20);
            label1.TabIndex = 3;
            label1.Text = "Kişi ayrıntılarını görmek için çift tıklayınız...";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = SystemColors.Info;
            btnSil.Location = new Point(12, 286);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(184, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Seçilen Kişiyi Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // KisiListesiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 341);
            Controls.Add(btnSil);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(btnReflesh);
            Controls.Add(dgvKisiler);
            MainMenuStrip = menuStrip1;
            Name = "KisiListesiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += KisiListesiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKisiler;
        private Button btnReflesh;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kişiİşlemleriToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private Label label1;
        private Button btnSil;
    }
}