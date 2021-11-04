
namespace S.M.S_Project
{
    partial class AddCategoryPage
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Titlebar = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.closeBtn = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.CloseTxt = new Bunifu.UI.WinForms.BunifuLabel();
            this.nameTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.addBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Titlebar
            // 
            this.Titlebar.BackgroundColor = System.Drawing.Color.Transparent;
            this.Titlebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Titlebar.BackgroundImage")));
            this.Titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Titlebar.BorderColor = System.Drawing.Color.Transparent;
            this.Titlebar.BorderRadius = 5;
            this.Titlebar.BorderThickness = 1;
            this.Titlebar.Controls.Add(this.bunifuLabel2);
            this.Titlebar.Controls.Add(this.closeBtn);
            this.Titlebar.Controls.Add(this.bunifuSeparator2);
            this.Titlebar.Controls.Add(this.CloseTxt);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.ShowBorders = true;
            this.Titlebar.Size = new System.Drawing.Size(500, 40);
            this.Titlebar.TabIndex = 8;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(197, 8);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(99, 21);
            this.bunifuLabel2.TabIndex = 18;
            this.bunifuLabel2.Text = "New Category";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // closeBtn
            // 
            this.closeBtn.AllowParentOverrides = false;
            this.closeBtn.AutoEllipsis = false;
            this.closeBtn.AutoSize = false;
            this.closeBtn.CursorType = null;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.closeBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.Location = new System.Drawing.Point(460, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(40, 37);
            this.closeBtn.TabIndex = 17;
            this.closeBtn.Text = "×";
            this.closeBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
            this.bunifuSeparator2.Size = new System.Drawing.Size(500, 5);
            this.bunifuSeparator2.TabIndex = 16;
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
            this.CloseTxt.TabIndex = 5;
            this.CloseTxt.Text = "×";
            this.CloseTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseTxt.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // nameTxt
            // 
            this.nameTxt.AcceptsReturn = false;
            this.nameTxt.AcceptsTab = false;
            this.nameTxt.AnimationSpeed = 200;
            this.nameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTxt.AutoSizeHeight = true;
            this.nameTxt.BackColor = System.Drawing.Color.Transparent;
            this.nameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTxt.BackgroundImage")));
            this.nameTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.nameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nameTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.nameTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.nameTxt.BorderRadius = 1;
            this.nameTxt.BorderThickness = 1;
            this.nameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 10F);
            this.nameTxt.DefaultText = "";
            this.nameTxt.FillColor = System.Drawing.Color.White;
            this.nameTxt.HideSelection = true;
            this.nameTxt.IconLeft = null;
            this.nameTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.IconPadding = 10;
            this.nameTxt.IconRight = null;
            this.nameTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(70, 93);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.nameTxt.Modified = false;
            this.nameTxt.Multiline = false;
            this.nameTxt.Name = "nameTxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.nameTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.nameTxt.OnIdleState = stateProperties4;
            this.nameTxt.Padding = new System.Windows.Forms.Padding(3);
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.ReadOnly = false;
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(350, 40);
            this.nameTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.nameTxt.TabIndex = 9;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTxt.TextMarginBottom = 0;
            this.nameTxt.TextMarginLeft = 3;
            this.nameTxt.TextMarginTop = 1;
            this.nameTxt.TextPlaceholder = "";
            this.nameTxt.UseSystemPasswordChar = false;
            this.nameTxt.WordWrap = true;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(70, 72);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(48, 15);
            this.bunifuLabel4.TabIndex = 20;
            this.bunifuLabel4.Text = "Category";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // addBtn
            // 
            this.addBtn.AllowAnimations = true;
            this.addBtn.AllowMouseEffects = true;
            this.addBtn.AllowToggling = false;
            this.addBtn.AnimationSpeed = 200;
            this.addBtn.AutoGenerateColors = false;
            this.addBtn.AutoRoundBorders = false;
            this.addBtn.AutoSizeLeftIcon = true;
            this.addBtn.AutoSizeRightIcon = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.ButtonText = "Add";
            this.addBtn.ButtonTextMarginLeft = 0;
            this.addBtn.ColorContrastOnClick = 45;
            this.addBtn.ColorContrastOnHover = 45;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.addBtn.CustomizableEdges = borderEdges1;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.addBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.addBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconLeft = null;
            this.addBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addBtn.IconMarginLeft = 11;
            this.addBtn.IconPadding = 10;
            this.addBtn.IconRight = null;
            this.addBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addBtn.IconSize = 25;
            this.addBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.addBtn.IdleBorderRadius = 0;
            this.addBtn.IdleBorderThickness = 0;
            this.addBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.addBtn.IdleIconLeftImage = null;
            this.addBtn.IdleIconRightImage = null;
            this.addBtn.IndicateFocus = false;
            this.addBtn.Location = new System.Drawing.Point(148, 164);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.OnDisabledState.BorderRadius = 1;
            this.addBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnDisabledState.BorderThickness = 1;
            this.addBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addBtn.OnDisabledState.IconLeftImage = null;
            this.addBtn.OnDisabledState.IconRightImage = null;
            this.addBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.BorderRadius = 1;
            this.addBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.onHoverState.BorderThickness = 1;
            this.addBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addBtn.onHoverState.IconLeftImage = null;
            this.addBtn.onHoverState.IconRightImage = null;
            this.addBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.OnIdleState.BorderRadius = 1;
            this.addBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnIdleState.BorderThickness = 1;
            this.addBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnIdleState.IconLeftImage = null;
            this.addBtn.OnIdleState.IconRightImage = null;
            this.addBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.BorderRadius = 1;
            this.addBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnPressedState.BorderThickness = 1;
            this.addBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnPressedState.IconLeftImage = null;
            this.addBtn.OnPressedState.IconRightImage = null;
            this.addBtn.Size = new System.Drawing.Size(179, 39);
            this.addBtn.TabIndex = 21;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addBtn.TextMarginLeft = 0;
            this.addBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.addBtn.UseDefaultRadiusAndThickness = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = false;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
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
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // AddCategoryPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.Titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategoryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminDashboard";
            this.Titlebar.ResumeLayout(false);
            this.Titlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel Titlebar;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuLabel CloseTxt;
        private Bunifu.UI.WinForms.BunifuLabel closeBtn;
        private Bunifu.UI.WinForms.BunifuTextBox nameTxt;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addBtn;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
    }
}
