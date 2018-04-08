﻿namespace Tabris.Winform
{
    partial class TabrisWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabrisWinform));
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.logList = new DSkin.Controls.DSkinListBox();
            this.dSkinPanel2 = new DSkin.Controls.DSkinPanel();
            this.dSkinPanel4 = new DSkin.Controls.DSkinPanel();
            this.dSkinTabControl1 = new DSkin.Controls.DSkinTabControl();
            this.dSkinPanel3 = new DSkin.Controls.DSkinPanel();
            this.SaveButton = new DSkin.Controls.DSkinButton();
            this.bottomPannel = new DSkin.Controls.DSkinPanel();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.runtimeTimeout = new DSkin.Controls.DSkinTextBox();
            this.catchBox = new DSkin.Controls.DSkinCheckBox();
            this.reloadRuntime = new DSkin.Controls.DSkinButton();
            this.btExcutorSelected = new DSkin.Controls.DSkinButton();
            this.btnExcutor = new DSkin.Controls.DSkinButton();
            this.dSkinTabBar1 = new DSkin.Controls.DSkinTabBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.codemirrowMenu = new DSkin.Controls.DSkinContextMenuStrip();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开DevToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggerF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除LOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logList)).BeginInit();
            this.dSkinPanel2.SuspendLayout();
            this.dSkinPanel4.SuspendLayout();
            this.dSkinPanel3.SuspendLayout();
            this.bottomPannel.SuspendLayout();
            this.codemirrowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.logList);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 445);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(797, 179);
            this.dSkinPanel1.TabIndex = 0;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // logList
            // 
            this.logList.BackColor = System.Drawing.Color.Transparent;
            this.logList.Borders.TopColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logList.Location = new System.Drawing.Point(0, 0);
            this.logList.Name = "logList";
            this.logList.ScrollBarWidth = 12;
            this.logList.Size = new System.Drawing.Size(797, 179);
            this.logList.TabIndex = 0;
            this.logList.Text = "dSkinListBox1";
            this.logList.Value = 0D;
            this.logList.Visible = false;
            // 
            // dSkinPanel2
            // 
            this.dSkinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel2.Controls.Add(this.dSkinPanel4);
            this.dSkinPanel2.Controls.Add(this.dSkinPanel3);
            this.dSkinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel2.Location = new System.Drawing.Point(4, 29);
            this.dSkinPanel2.Name = "dSkinPanel2";
            this.dSkinPanel2.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel2.RightBottom")));
            this.dSkinPanel2.Size = new System.Drawing.Size(797, 416);
            this.dSkinPanel2.TabIndex = 1;
            this.dSkinPanel2.Text = "dSkinPanel2";
            // 
            // dSkinPanel4
            // 
            this.dSkinPanel4.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel4.Controls.Add(this.dSkinTabControl1);
            this.dSkinPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel4.Location = new System.Drawing.Point(0, 0);
            this.dSkinPanel4.Name = "dSkinPanel4";
            this.dSkinPanel4.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel4.RightBottom")));
            this.dSkinPanel4.Size = new System.Drawing.Size(684, 416);
            this.dSkinPanel4.TabIndex = 2;
            this.dSkinPanel4.Text = "dSkinPanel4";
            // 
            // dSkinTabControl1
            // 
            this.dSkinTabControl1.AllowDrop = true;
            this.dSkinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTabControl1.BitmapCache = false;
            this.dSkinTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.ItemBackgroundImage = null;
            this.dSkinTabControl1.ItemBackgroundImageHover = null;
            this.dSkinTabControl1.ItemBackgroundImageSelected = null;
            this.dSkinTabControl1.Location = new System.Drawing.Point(3, 3);
            this.dSkinTabControl1.Name = "dSkinTabControl1";
            this.dSkinTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.PageImagePosition = DSkin.Controls.ePageImagePosition.Left;
            this.dSkinTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.dSkinTabControl1.Size = new System.Drawing.Size(678, 410);
            this.dSkinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dSkinTabControl1.TabIndex = 1;
            this.dSkinTabControl1.UpdownBtnArrowNormalColor = System.Drawing.Color.Black;
            this.dSkinTabControl1.UpdownBtnArrowPressColor = System.Drawing.Color.Gray;
            this.dSkinTabControl1.UpdownBtnBackColor = System.Drawing.Color.White;
            this.dSkinTabControl1.UpdownBtnBorderColor = System.Drawing.Color.Black;
            // 
            // dSkinPanel3
            // 
            this.dSkinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel3.Controls.Add(this.SaveButton);
            this.dSkinPanel3.Controls.Add(this.bottomPannel);
            this.dSkinPanel3.Controls.Add(this.reloadRuntime);
            this.dSkinPanel3.Controls.Add(this.btExcutorSelected);
            this.dSkinPanel3.Controls.Add(this.btnExcutor);
            this.dSkinPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.dSkinPanel3.Location = new System.Drawing.Point(684, 0);
            this.dSkinPanel3.Name = "dSkinPanel3";
            this.dSkinPanel3.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel3.RightBottom")));
            this.dSkinPanel3.Size = new System.Drawing.Size(113, 416);
            this.dSkinPanel3.TabIndex = 1;
            this.dSkinPanel3.Text = "dSkinPanel3";
            // 
            // SaveButton
            // 
            this.SaveButton.AdaptImage = true;
            this.SaveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.SaveButton.ButtonBorderColor = System.Drawing.Color.Gray;
            this.SaveButton.ButtonBorderWidth = 1;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.HoverColor = System.Drawing.Color.Empty;
            this.SaveButton.HoverImage = null;
            this.SaveButton.IsPureColor = false;
            this.SaveButton.Location = new System.Drawing.Point(8, 213);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NormalImage = null;
            this.SaveButton.PressColor = System.Drawing.Color.Empty;
            this.SaveButton.PressedImage = null;
            this.SaveButton.Radius = 10;
            this.SaveButton.ShowButtonBorder = true;
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save To File (Ctrl+S)";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.TextPadding = 0;
            this.SaveButton.Visible = false;
            // 
            // bottomPannel
            // 
            this.bottomPannel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPannel.Controls.Add(this.dSkinLabel1);
            this.bottomPannel.Controls.Add(this.runtimeTimeout);
            this.bottomPannel.Controls.Add(this.catchBox);
            this.bottomPannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPannel.Location = new System.Drawing.Point(0, 279);
            this.bottomPannel.Name = "bottomPannel";
            this.bottomPannel.RightBottom = ((System.Drawing.Image)(resources.GetObject("bottomPannel.RightBottom")));
            this.bottomPannel.Size = new System.Drawing.Size(113, 137);
            this.bottomPannel.TabIndex = 6;
            this.bottomPannel.Text = "dSkinPanel5";
            this.bottomPannel.Visible = false;
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinLabel1.AutoSize = false;
            this.dSkinLabel1.Location = new System.Drawing.Point(8, 34);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(102, 46);
            this.dSkinLabel1.TabIndex = 5;
            this.dSkinLabel1.Text = "Timeout For Runtime(Need reload runtime)";
            this.dSkinLabel1.Visible = false;
            // 
            // runtimeTimeout
            // 
            this.runtimeTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runtimeTimeout.BitmapCache = false;
            this.runtimeTimeout.Location = new System.Drawing.Point(8, 86);
            this.runtimeTimeout.Name = "runtimeTimeout";
            this.runtimeTimeout.Size = new System.Drawing.Size(100, 21);
            this.runtimeTimeout.TabIndex = 4;
            this.runtimeTimeout.TransparencyKey = System.Drawing.Color.Empty;
            this.runtimeTimeout.Visible = false;
            this.runtimeTimeout.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runtimeTimeout.WaterText = "unlimited";
            this.runtimeTimeout.WaterTextOffset = new System.Drawing.Point(5, 5);
            // 
            // catchBox
            // 
            this.catchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catchBox.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catchBox.Checked = true;
            this.catchBox.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.catchBox.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.catchBox.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.catchBox.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.catchBox.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.catchBox.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.catchBox.CheckRectColor = System.Drawing.Color.DodgerBlue;
            this.catchBox.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.catchBox.CheckRectWidth = 14;
            this.catchBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.catchBox.InnerPaddingWidth = 2;
            this.catchBox.InnerRectInflate = 3;
            this.catchBox.Location = new System.Drawing.Point(8, 113);
            this.catchBox.Name = "catchBox";
            this.catchBox.Size = new System.Drawing.Size(100, 18);
            this.catchBox.SpaceBetweenCheckMarkAndText = 3;
            this.catchBox.TabIndex = 2;
            this.catchBox.Text = "Global Catch";
            this.catchBox.TextColorDisabled = System.Drawing.Color.Gray;
            this.catchBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.catchBox.Visible = false;
            // 
            // reloadRuntime
            // 
            this.reloadRuntime.AdaptImage = true;
            this.reloadRuntime.BaseColor = System.Drawing.Color.Crimson;
            this.reloadRuntime.ButtonBorderColor = System.Drawing.Color.Gray;
            this.reloadRuntime.ButtonBorderWidth = 1;
            this.reloadRuntime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadRuntime.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reloadRuntime.HoverColor = System.Drawing.Color.Empty;
            this.reloadRuntime.HoverImage = null;
            this.reloadRuntime.IsPureColor = false;
            this.reloadRuntime.Location = new System.Drawing.Point(8, 148);
            this.reloadRuntime.Name = "reloadRuntime";
            this.reloadRuntime.NormalImage = null;
            this.reloadRuntime.PressColor = System.Drawing.Color.Empty;
            this.reloadRuntime.PressedImage = null;
            this.reloadRuntime.Radius = 10;
            this.reloadRuntime.ShowButtonBorder = true;
            this.reloadRuntime.Size = new System.Drawing.Size(100, 40);
            this.reloadRuntime.TabIndex = 3;
            this.reloadRuntime.Text = "Reload(JsRuntime)";
            this.reloadRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reloadRuntime.TextPadding = 0;
            this.reloadRuntime.Visible = false;
            // 
            // btExcutorSelected
            // 
            this.btExcutorSelected.AdaptImage = true;
            this.btExcutorSelected.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.btExcutorSelected.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btExcutorSelected.ButtonBorderWidth = 1;
            this.btExcutorSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcutorSelected.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btExcutorSelected.HoverColor = System.Drawing.Color.Empty;
            this.btExcutorSelected.HoverImage = null;
            this.btExcutorSelected.IsPureColor = false;
            this.btExcutorSelected.Location = new System.Drawing.Point(8, 82);
            this.btExcutorSelected.Name = "btExcutorSelected";
            this.btExcutorSelected.NormalImage = null;
            this.btExcutorSelected.PressColor = System.Drawing.Color.Empty;
            this.btExcutorSelected.PressedImage = null;
            this.btExcutorSelected.Radius = 10;
            this.btExcutorSelected.ShowButtonBorder = true;
            this.btExcutorSelected.Size = new System.Drawing.Size(100, 40);
            this.btExcutorSelected.TabIndex = 1;
            this.btExcutorSelected.Text = "Process(Selected)";
            this.btExcutorSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btExcutorSelected.TextPadding = 0;
            this.btExcutorSelected.Visible = false;
            // 
            // btnExcutor
            // 
            this.btnExcutor.AdaptImage = true;
            this.btnExcutor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(186)))), ((int)(((byte)(233)))));
            this.btnExcutor.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btnExcutor.ButtonBorderWidth = 1;
            this.btnExcutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcutor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcutor.HoverColor = System.Drawing.Color.Empty;
            this.btnExcutor.HoverImage = null;
            this.btnExcutor.IsPureColor = false;
            this.btnExcutor.Location = new System.Drawing.Point(8, 20);
            this.btnExcutor.Name = "btnExcutor";
            this.btnExcutor.NormalImage = null;
            this.btnExcutor.PressColor = System.Drawing.Color.Empty;
            this.btnExcutor.PressedImage = null;
            this.btnExcutor.Radius = 10;
            this.btnExcutor.ShowButtonBorder = true;
            this.btnExcutor.Size = new System.Drawing.Size(100, 40);
            this.btnExcutor.TabIndex = 0;
            this.btnExcutor.Text = "Process         (F5)";
            this.btnExcutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcutor.TextPadding = 0;
            this.btnExcutor.Visible = false;
            // 
            // dSkinTabBar1
            // 
            this.dSkinTabBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dSkinTabBar1.BackgroundImage = global::Tabris.Winform.Properties.Resources.ChromeBackground;
            this.dSkinTabBar1.EnabledLayoutContent = true;
            this.dSkinTabBar1.Location = new System.Drawing.Point(3, 2);
            this.dSkinTabBar1.Name = "dSkinTabBar1";
            this.dSkinTabBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.dSkinTabBar1.Size = new System.Drawing.Size(685, 26);
            this.dSkinTabBar1.TabControl = this.dSkinTabControl1;
            this.dSkinTabBar1.TabIndex = 2;
            this.dSkinTabBar1.Text = "dSkinTabBar1";
            this.dSkinTabBar1.SizeChanged += new System.EventHandler(this.dSkinTabBar1_SizeChanged);
            // 
            // codemirrowMenu
            // 
            this.codemirrowMenu.Arrow = System.Drawing.Color.Black;
            this.codemirrowMenu.Back = System.Drawing.Color.White;
            this.codemirrowMenu.BackRadius = 4;
            this.codemirrowMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.codemirrowMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.codemirrowMenu.Fore = System.Drawing.Color.Black;
            this.codemirrowMenu.HoverFore = System.Drawing.Color.White;
            this.codemirrowMenu.ItemAnamorphosis = true;
            this.codemirrowMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.codemirrowMenu.ItemBorderShow = true;
            this.codemirrowMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.codemirrowMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.codemirrowMenu.ItemRadius = 4;
            this.codemirrowMenu.ItemRadiusStyle = DSkin.Common.RoundStyle.All;
            this.codemirrowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.格式化ToolStripMenuItem,
            this.注释ToolStripMenuItem,
            this.反注释ToolStripMenuItem,
            this.提示ToolStripMenuItem,
            this.打开DevToolsToolStripMenuItem,
            this.debuggerF5ToolStripMenuItem,
            this.清除LOGToolStripMenuItem});
            this.codemirrowMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.codemirrowMenu.Name = "codemirrowMenu";
            this.codemirrowMenu.RadiusStyle = DSkin.Common.RoundStyle.All;
            this.codemirrowMenu.Size = new System.Drawing.Size(198, 246);
            this.codemirrowMenu.SkinAllColor = true;
            this.codemirrowMenu.TitleAnamorphosis = true;
            this.codemirrowMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.codemirrowMenu.TitleRadius = 4;
            this.codemirrowMenu.TitleRadiusStyle = DSkin.Common.RoundStyle.All;
            this.codemirrowMenu.Opening += new System.ComponentModel.CancelEventHandler(this.codemirrowMenu_Opening);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 格式化ToolStripMenuItem
            // 
            this.格式化ToolStripMenuItem.Name = "格式化ToolStripMenuItem";
            this.格式化ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Alt + C";
            this.格式化ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.格式化ToolStripMenuItem.Text = "格式化";
            this.格式化ToolStripMenuItem.Click += new System.EventHandler(this.格式化ToolStripMenuItem_Click);
            // 
            // 注释ToolStripMenuItem
            // 
            this.注释ToolStripMenuItem.Name = "注释ToolStripMenuItem";
            this.注释ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + /";
            this.注释ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.注释ToolStripMenuItem.Text = "注释";
            this.注释ToolStripMenuItem.Click += new System.EventHandler(this.注释ToolStripMenuItem_Click);
            // 
            // 反注释ToolStripMenuItem
            // 
            this.反注释ToolStripMenuItem.Name = "反注释ToolStripMenuItem";
            this.反注释ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl +Alt + /";
            this.反注释ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.反注释ToolStripMenuItem.Text = "反注释";
            this.反注释ToolStripMenuItem.Click += new System.EventHandler(this.反注释ToolStripMenuItem_Click);
            // 
            // 提示ToolStripMenuItem
            // 
            this.提示ToolStripMenuItem.Name = "提示ToolStripMenuItem";
            this.提示ToolStripMenuItem.ShortcutKeyDisplayString = "Alt + /";
            this.提示ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.提示ToolStripMenuItem.Text = "提示";
            this.提示ToolStripMenuItem.Click += new System.EventHandler(this.提示ToolStripMenuItem_Click);
            // 
            // 打开DevToolsToolStripMenuItem
            // 
            this.打开DevToolsToolStripMenuItem.Name = "打开DevToolsToolStripMenuItem";
            this.打开DevToolsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.打开DevToolsToolStripMenuItem.Text = "打开DevTools";
            this.打开DevToolsToolStripMenuItem.Click += new System.EventHandler(this.打开DevToolsToolStripMenuItem_Click);
            // 
            // debuggerF5ToolStripMenuItem
            // 
            this.debuggerF5ToolStripMenuItem.Name = "debuggerF5ToolStripMenuItem";
            this.debuggerF5ToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.debuggerF5ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.debuggerF5ToolStripMenuItem.Text = "调试执行";
            this.debuggerF5ToolStripMenuItem.Click += new System.EventHandler(this.debuggerF5ToolStripMenuItem_Click);
            // 
            // 清除LOGToolStripMenuItem
            // 
            this.清除LOGToolStripMenuItem.Name = "清除LOGToolStripMenuItem";
            this.清除LOGToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.清除LOGToolStripMenuItem.Text = "清除Log";
            this.清除LOGToolStripMenuItem.Click += new System.EventHandler(this.清除LOGToolStripMenuItem_Click);
            // 
            // TabrisWinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionColor = System.Drawing.Color.Transparent;
            this.CaptionFont = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.CaptionHeight = 25;
            this.ClientSize = new System.Drawing.Size(805, 628);
            this.CloseBox.HoverColor = System.Drawing.Color.Red;
            this.Controls.Add(this.dSkinTabBar1);
            this.Controls.Add(this.dSkinPanel2);
            this.Controls.Add(this.dSkinPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconRectangle = new System.Drawing.Rectangle(1, 1, 0, 24);
            this.Name = "TabrisWinform";
            this.Radius = 5;
            this.ShowIcon = false;
            this.Text = "tabris-jsql-v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TabrisWinform_FormClosing);
            this.Load += new System.EventHandler(this.TabrisWinform_Load);
            this.dSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logList)).EndInit();
            this.dSkinPanel2.ResumeLayout(false);
            this.dSkinPanel4.ResumeLayout(false);
            this.dSkinPanel3.ResumeLayout(false);
            this.bottomPannel.ResumeLayout(false);
            this.bottomPannel.PerformLayout();
            this.codemirrowMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinPanel dSkinPanel2;
        private DSkin.Controls.DSkinButton btnExcutor;
        private DSkin.Controls.DSkinPanel dSkinPanel4;
        private DSkin.Controls.DSkinPanel dSkinPanel3;
        private DSkin.Controls.DSkinButton btExcutorSelected;
        private DSkin.Controls.DSkinListBox logList;
        private DSkin.Controls.DSkinCheckBox catchBox;
        private DSkin.Controls.DSkinButton reloadRuntime;
        private DSkin.Controls.DSkinTextBox runtimeTimeout;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private DSkin.Controls.DSkinTabControl dSkinTabControl1;
        private DSkin.Controls.DSkinTabBar dSkinTabBar1;
        private DSkin.Controls.DSkinPanel bottomPannel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DSkin.Controls.DSkinButton SaveButton;
        private DSkin.Controls.DSkinContextMenuStrip codemirrowMenu;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注释ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反注释ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开DevToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debuggerF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除LOGToolStripMenuItem;
    }
}

