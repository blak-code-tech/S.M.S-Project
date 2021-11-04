
namespace S.M.S_Project
{
    partial class SalesPrintForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPrintForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.Titlebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.CloseTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCart1 = new S.M.S_Project.rptCart();
            this.txtClose = new Bunifu.UI.WinForms.BunifuLabel();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.Titlebar;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // Titlebar
            // 
            this.Titlebar.BackgroundColor = System.Drawing.Color.Transparent;
            this.Titlebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar.BackgroundImage")));
            this.Titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Titlebar.BorderColor = System.Drawing.Color.Transparent;
            this.Titlebar.BorderRadius = 5;
            this.Titlebar.BorderThickness = 1;
            this.Titlebar.Controls.Add(this.txtClose);
            this.Titlebar.Controls.Add(this.CloseTxt);
            this.Titlebar.Controls.Add(this.bunifuSeparator2);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.ShowBorders = true;
            this.Titlebar.Size = new System.Drawing.Size(800, 40);
            this.Titlebar.TabIndex = 7;
            // 
            // CloseTxt
            // 
            this.CloseTxt.AllowParentOverrides = false;
            this.CloseTxt.AutoEllipsis = false;
            this.CloseTxt.AutoSize = false;
            this.CloseTxt.CursorType = null;
            this.CloseTxt.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.CloseTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.CloseTxt.Location = new System.Drawing.Point(844, 0);
            this.CloseTxt.Name = "CloseTxt";
            this.CloseTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseTxt.Size = new System.Drawing.Size(40, 37);
            this.CloseTxt.TabIndex = 17;
            this.CloseTxt.Text = "×";
            this.CloseTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 35);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(800, 5);
            this.bunifuSeparator2.TabIndex = 16;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 40);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 410);
            this.crystalReportViewer1.TabIndex = 8;
            // 
            // txtClose
            // 
            this.txtClose.AllowParentOverrides = false;
            this.txtClose.AutoEllipsis = false;
            this.txtClose.AutoSize = false;
            this.txtClose.CursorType = null;
            this.txtClose.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.txtClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtClose.Location = new System.Drawing.Point(760, 0);
            this.txtClose.Name = "txtClose";
            this.txtClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClose.Size = new System.Drawing.Size(40, 37);
            this.txtClose.TabIndex = 18;
            this.txtClose.Text = "×";
            this.txtClose.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtClose.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // SalesPrintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesPrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesPrintForm";
            this.Load += new System.EventHandler(this.SalesPrintForm_Load);
            this.Titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPanel Titlebar;
        private Bunifu.UI.WinForms.BunifuLabel CloseTxt;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptCart rptCart1;
        private Bunifu.UI.WinForms.BunifuLabel txtClose;
    }
}