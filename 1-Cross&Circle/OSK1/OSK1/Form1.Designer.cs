using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OSK1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        public bool circleTurn;
        public ToolStripMenuItem chosenCross, chosenCircle;
        public enum cellState
        {
            empty,
            cross,
            circle
        }
        public cellState[,] grid;
        public int[] focus;
        public int turns;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybórSymboluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kółkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwykłeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.czaszkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolczastaKulkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.img00 = new System.Windows.Forms.PictureBox();
            this.img10 = new System.Windows.Forms.PictureBox();
            this.img20 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.img11 = new System.Windows.Forms.PictureBox();
            this.img21 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img12 = new System.Windows.Forms.PictureBox();
            this.img22 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img22)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(781, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.wybórSymboluToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // resetujToolStripMenuItem
            // 
            this.resetujToolStripMenuItem.Name = "resetujToolStripMenuItem";
            this.resetujToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.resetujToolStripMenuItem.Text = "Resetuj";
            this.resetujToolStripMenuItem.Click += new System.EventHandler(this.resetujToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // wybórSymboluToolStripMenuItem
            // 
            this.wybórSymboluToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kółkaToolStripMenuItem,
            this.toolStripMenuItem1});
            this.wybórSymboluToolStripMenuItem.Name = "wybórSymboluToolStripMenuItem";
            this.wybórSymboluToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.wybórSymboluToolStripMenuItem.Text = "Wybór symbolu";
            // 
            // kółkaToolStripMenuItem
            // 
            this.kółkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zwykłeToolStripMenuItem1,
            this.czaszkaToolStripMenuItem,
            this.cyklToolStripMenuItem,
            this.okoToolStripMenuItem,
            this.planetaToolStripMenuItem,
            this.kolczastaKulkaToolStripMenuItem});
            this.kółkaToolStripMenuItem.Name = "kółkaToolStripMenuItem";
            this.kółkaToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.kółkaToolStripMenuItem.Text = "Krzyżyki";
            // 
            // zwykłeToolStripMenuItem1
            // 
            this.zwykłeToolStripMenuItem1.Checked = true;
            this.zwykłeToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zwykłeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("zwykłeToolStripMenuItem1.Image")));
            this.zwykłeToolStripMenuItem1.Name = "zwykłeToolStripMenuItem1";
            this.zwykłeToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.zwykłeToolStripMenuItem1.Text = "Zwykłe";
            this.zwykłeToolStripMenuItem1.Click += new System.EventHandler(this.cross_Click);
            // 
            // czaszkaToolStripMenuItem
            // 
            this.czaszkaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("czaszkaToolStripMenuItem.Image")));
            this.czaszkaToolStripMenuItem.Name = "czaszkaToolStripMenuItem";
            this.czaszkaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.czaszkaToolStripMenuItem.Text = "Kości";
            this.czaszkaToolStripMenuItem.Click += new System.EventHandler(this.cross_Click);
            // 
            // cyklToolStripMenuItem
            // 
            this.cyklToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cyklToolStripMenuItem.Image")));
            this.cyklToolStripMenuItem.Name = "cyklToolStripMenuItem";
            this.cyklToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.cyklToolStripMenuItem.Text = "Szable";
            this.cyklToolStripMenuItem.Click += new System.EventHandler(this.cross_Click);
            // 
            // okoToolStripMenuItem
            // 
            this.okoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("okoToolStripMenuItem.Image")));
            this.okoToolStripMenuItem.Name = "okoToolStripMenuItem";
            this.okoToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.okoToolStripMenuItem.Text = "Sztućce";
            this.okoToolStripMenuItem.Click += new System.EventHandler(this.cross_Click);
            // 
            // planetaToolStripMenuItem
            // 
            this.planetaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("planetaToolStripMenuItem.Image")));
            this.planetaToolStripMenuItem.Name = "planetaToolStripMenuItem";
            this.planetaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.planetaToolStripMenuItem.Text = "Narzędzia";
            this.planetaToolStripMenuItem.Click += new System.EventHandler(this.cross_Click);
            // 
            // kolczastaKulkaToolStripMenuItem
            // 
            this.kolczastaKulkaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kolczastaKulkaToolStripMenuItem.Image")));
            this.kolczastaKulkaToolStripMenuItem.Name = "kolczastaKulkaToolStripMenuItem";
            this.kolczastaKulkaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.kolczastaKulkaToolStripMenuItem.Text = "Zadrapania";
            this.kolczastaKulkaToolStripMenuItem.Click += new System.EventHandler(this.cross_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.toolStripMenuItem1.Text = "Kółka";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem2.Text = "Zwykłe";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.circle_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem3.Text = "Czaszka";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.circle_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem4.Text = "Cykl";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.circle_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem5.Text = "Oko";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.circle_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem6.Text = "Planeta";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.circle_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(193, 26);
            this.toolStripMenuItem7.Text = "Kolczasta kulka";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.circle_Click);
            // 
            // img00
            // 
            this.img00.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img00.Location = new System.Drawing.Point(3, 3);
            this.img00.Name = "img00";
            this.img00.Size = new System.Drawing.Size(93, 93);
            this.img00.TabIndex = 0;
            this.img00.TabStop = false;
            this.img00.Click += new System.EventHandler(this.tile_Click);
            // 
            // img10
            // 
            this.img10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img10.Location = new System.Drawing.Point(102, 3);
            this.img10.Name = "img10";
            this.img10.Size = new System.Drawing.Size(93, 93);
            this.img10.TabIndex = 1;
            this.img10.TabStop = false;
            this.img10.Click += new System.EventHandler(this.tile_Click);
            // 
            // img20
            // 
            this.img20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img20.Location = new System.Drawing.Point(202, 3);
            this.img20.Name = "img20";
            this.img20.Size = new System.Drawing.Size(93, 93);
            this.img20.TabIndex = 2;
            this.img20.TabStop = false;
            this.img20.Click += new System.EventHandler(this.tile_Click);
            // 
            // img01
            // 
            this.img01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img01.Location = new System.Drawing.Point(3, 103);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(93, 93);
            this.img01.TabIndex = 3;
            this.img01.TabStop = false;
            this.img01.Click += new System.EventHandler(this.tile_Click);
            // 
            // img11
            // 
            this.img11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img11.Location = new System.Drawing.Point(102, 103);
            this.img11.Name = "img11";
            this.img11.Size = new System.Drawing.Size(93, 93);
            this.img11.TabIndex = 4;
            this.img11.TabStop = false;
            this.img11.Click += new System.EventHandler(this.tile_Click);
            // 
            // img21
            // 
            this.img21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img21.Location = new System.Drawing.Point(202, 103);
            this.img21.Name = "img21";
            this.img21.Size = new System.Drawing.Size(93, 93);
            this.img21.TabIndex = 5;
            this.img21.TabStop = false;
            this.img21.Click += new System.EventHandler(this.tile_Click);
            // 
            // img02
            // 
            this.img02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img02.Location = new System.Drawing.Point(3, 203);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(93, 93);
            this.img02.TabIndex = 6;
            this.img02.TabStop = false;
            this.img02.Click += new System.EventHandler(this.tile_Click);
            // 
            // img12
            // 
            this.img12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img12.Location = new System.Drawing.Point(102, 203);
            this.img12.Name = "img12";
            this.img12.Size = new System.Drawing.Size(93, 93);
            this.img12.TabIndex = 7;
            this.img12.TabStop = false;
            this.img12.Click += new System.EventHandler(this.tile_Click);
            // 
            // img22
            // 
            this.img22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.img22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img22.Location = new System.Drawing.Point(202, 203);
            this.img22.Name = "img22";
            this.img22.Size = new System.Drawing.Size(93, 93);
            this.img22.TabIndex = 8;
            this.img22.TabStop = false;
            this.img22.Click += new System.EventHandler(this.tile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.img22, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.img12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.img02, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.img21, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.img11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.img01, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.img20, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.img10, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.img00, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // infoPicture
            // 
            this.infoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPicture.Location = new System.Drawing.Point(358, 32);
            this.infoPicture.Name = "infoPicture";
            this.infoPicture.Size = new System.Drawing.Size(30, 30);
            this.infoPicture.TabIndex = 4;
            this.infoPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 387);
            this.Controls.Add(this.infoPicture);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img22)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem wybórSymboluToolStripMenuItem;
        private ToolStripMenuItem kółkaToolStripMenuItem;
        private ToolStripMenuItem zwykłeToolStripMenuItem1;
        private ToolStripMenuItem czaszkaToolStripMenuItem;
        private ToolStripMenuItem cyklToolStripMenuItem;
        private ToolStripMenuItem okoToolStripMenuItem;
        private ToolStripMenuItem planetaToolStripMenuItem;
        private ToolStripMenuItem kolczastaKulkaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private PictureBox img00;
        private PictureBox img10;
        private PictureBox img20;
        private PictureBox img01;
        private PictureBox img11;
        private PictureBox img21;
        private PictureBox img02;
        private PictureBox img12;
        private PictureBox img22;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem graToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private ToolStripMenuItem resetujToolStripMenuItem;
        private PictureBox infoPicture;
    }
}

