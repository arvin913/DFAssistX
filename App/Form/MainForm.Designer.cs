namespace App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_ResetProcess = new System.Windows.Forms.Button();
            this.comboBox_Process = new System.Windows.Forms.ComboBox();
            this.button_SelectProcess = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_TopSetting = new System.Windows.Forms.Panel();
            this.label_Process = new App.LocalizableLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_Overlay = new System.Windows.Forms.CheckBox();
            this.tabControl = new App.TabControlBlack();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.groupBox_DefaultSet = new System.Windows.Forms.GroupBox();
            this.checkBox_tts = new System.Windows.Forms.CheckBox();
            this.checkBox_Remind = new System.Windows.Forms.CheckBox();
            this.button_ResetOverlayPosition = new System.Windows.Forms.Button();
            this.checkBox_CheatRoullete = new System.Windows.Forms.CheckBox();
            this.checkBox_FlashWindow = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoOverlayHide = new System.Windows.Forms.CheckBox();
            this.checkBox_StartupShow = new System.Windows.Forms.CheckBox();
            this.tabPage_FATE = new System.Windows.Forms.TabPage();
            this.label_FATEAbout = new App.LocalizableLabel();
            this.triStateTreeView_FATEs = new RikTheVeggie.TriStateTreeView();
            this.menuStrip_FATETab = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_UnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.presetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfireIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfireIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfNetherfireIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkyfallIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkyfallIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfNetherfireIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkywindIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOfSkywindIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.bookOfSkyearthIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SelectApply = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.panel_LogCover = new System.Windows.Forms.Panel();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip_LogTab = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_LogCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Info = new System.Windows.Forms.TabPage();
            this.label_About = new App.LocalizableLabel();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.label_AboutTitle = new App.LocalizableLabel();
            this.contextMenuStrip.SuspendLayout();
            this.panel_TopSetting.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.groupBox_DefaultSet.SuspendLayout();
            this.tabPage_FATE.SuspendLayout();
            this.menuStrip_FATETab.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            this.panel_LogCover.SuspendLayout();
            this.menuStrip_LogTab.SuspendLayout();
            this.tabPage_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ResetProcess
            // 
            this.button_ResetProcess.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetProcess.Location = new System.Drawing.Point(288, 0);
            this.button_ResetProcess.Name = "button_ResetProcess";
            this.button_ResetProcess.Size = new System.Drawing.Size(60, 27);
            this.button_ResetProcess.TabIndex = 0;
            this.button_ResetProcess.Text = "重设";
            this.button_ResetProcess.UseVisualStyleBackColor = true;
            this.button_ResetProcess.Click += new System.EventHandler(this.button_ResetProcess_Click);
            // 
            // comboBox_Process
            // 
            this.comboBox_Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Process.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.comboBox_Process.FormattingEnabled = true;
            this.comboBox_Process.Location = new System.Drawing.Point(69, 2);
            this.comboBox_Process.Name = "comboBox_Process";
            this.comboBox_Process.Size = new System.Drawing.Size(153, 23);
            this.comboBox_Process.Sorted = true;
            this.comboBox_Process.TabIndex = 0;
            // 
            // button_SelectProcess
            // 
            this.button_SelectProcess.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectProcess.Location = new System.Drawing.Point(228, 0);
            this.button_SelectProcess.Name = "button_SelectProcess";
            this.button_SelectProcess.Size = new System.Drawing.Size(60, 27);
            this.button_SelectProcess.TabIndex = 0;
            this.button_SelectProcess.Text = "手动";
            this.button_SelectProcess.UseVisualStyleBackColor = true;
            this.button_SelectProcess.Click += new System.EventHandler(this.button_SelectProcess_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "임무/돌발 찾기 도우미";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Close});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Open.Text = "열기";
            this.toolStripMenuItem_Open.Click += new System.EventHandler(this.toolStripMenuItem_Open_Click);
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_Close.Text = "종료";
            this.toolStripMenuItem_Close.Click += new System.EventHandler(this.toolStripMenuItem_Close_Click);
            // 
            // panel_TopSetting
            // 
            this.panel_TopSetting.BackColor = System.Drawing.Color.Silver;
            this.panel_TopSetting.Controls.Add(this.label_Process);
            this.panel_TopSetting.Controls.Add(this.comboBox_Process);
            this.panel_TopSetting.Controls.Add(this.button_SelectProcess);
            this.panel_TopSetting.Controls.Add(this.button_ResetProcess);
            this.panel_TopSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TopSetting.Location = new System.Drawing.Point(0, 0);
            this.panel_TopSetting.Name = "panel_TopSetting";
            this.panel_TopSetting.Padding = new System.Windows.Forms.Padding(5);
            this.panel_TopSetting.Size = new System.Drawing.Size(544, 27);
            this.panel_TopSetting.TabIndex = 1;
            // 
            // label_Process
            // 
            this.label_Process.AutoSize = true;
            this.label_Process.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Process.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Process.ForeColor = System.Drawing.Color.Gray;
            this.label_Process.Location = new System.Drawing.Point(5, 5);
            this.label_Process.Name = "label_Process";
            this.label_Process.Size = new System.Drawing.Size(64, 19);
            this.label_Process.TabIndex = 0;
            this.label_Process.Text = "游戏进程:";
            // 
            // checkBox_Overlay
            // 
            this.checkBox_Overlay.AutoSize = true;
            this.checkBox_Overlay.Checked = true;
            this.checkBox_Overlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Overlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Overlay.Location = new System.Drawing.Point(6, 21);
            this.checkBox_Overlay.Name = "checkBox_Overlay";
            this.checkBox_Overlay.Size = new System.Drawing.Size(87, 21);
            this.checkBox_Overlay.TabIndex = 0;
            this.checkBox_Overlay.Text = "使用悬浮窗";
            this.toolTip.SetToolTip(this.checkBox_Overlay, "오버레이 UI의 좌측 막대를 이용해 드래그 할 수 있습니다.");
            this.checkBox_Overlay.UseVisualStyleBackColor = true;
            this.checkBox_Overlay.CheckedChanged += new System.EventHandler(this.checkBox_Overlay_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabPage_Settings);
            this.tabControl.Controls.Add(this.tabPage_FATE);
            this.tabControl.Controls.Add(this.tabPage_Log);
            this.tabControl.Controls.Add(this.tabPage_Info);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(30, 110);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(544, 270);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Settings.Controls.Add(this.groupBox_DefaultSet);
            this.tabPage_Settings.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Settings.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(426, 262);
            this.tabPage_Settings.TabIndex = 1;
            this.tabPage_Settings.Text = "设置";
            // 
            // groupBox_DefaultSet
            // 
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_tts);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_Remind);
            this.groupBox_DefaultSet.Controls.Add(this.button_ResetOverlayPosition);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_CheatRoullete);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_FlashWindow);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_AutoOverlayHide);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_StartupShow);
            this.groupBox_DefaultSet.Controls.Add(this.checkBox_Overlay);
            this.groupBox_DefaultSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_DefaultSet.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DefaultSet.Name = "groupBox_DefaultSet";
            this.groupBox_DefaultSet.Size = new System.Drawing.Size(426, 266);
            this.groupBox_DefaultSet.TabIndex = 0;
            this.groupBox_DefaultSet.TabStop = false;
            this.groupBox_DefaultSet.Text = "基本设置";
            // 
            // checkBox_tts
            // 
            this.checkBox_tts.AutoSize = true;
            this.checkBox_tts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tts.Location = new System.Drawing.Point(6, 193);
            this.checkBox_tts.Name = "checkBox_tts";
            this.checkBox_tts.Size = new System.Drawing.Size(104, 21);
            this.checkBox_tts.TabIndex = 5;
            this.checkBox_tts.Text = "FATE TTS提示";
            this.checkBox_tts.UseVisualStyleBackColor = true;
            this.checkBox_tts.CheckedChanged += new System.EventHandler(this.checkBox_tts_CheckedChanged);
            // 
            // checkBox_Remind
            // 
            this.checkBox_Remind.AutoSize = true;
            this.checkBox_Remind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Remind.Location = new System.Drawing.Point(6, 166);
            this.checkBox_Remind.Name = "checkBox_Remind";
            this.checkBox_Remind.Size = new System.Drawing.Size(91, 21);
            this.checkBox_Remind.TabIndex = 4;
            this.checkBox_Remind.Text = "FATE提示音";
            this.checkBox_Remind.UseVisualStyleBackColor = true;
            this.checkBox_Remind.CheckedChanged += new System.EventHandler(this.checkBox_Remind_CheckedChanged);
            // 
            // button_ResetOverlayPosition
            // 
            this.button_ResetOverlayPosition.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button_ResetOverlayPosition.Location = new System.Drawing.Point(100, 18);
            this.button_ResetOverlayPosition.Name = "button_ResetOverlayPosition";
            this.button_ResetOverlayPosition.Size = new System.Drawing.Size(67, 25);
            this.button_ResetOverlayPosition.TabIndex = 0;
            this.button_ResetOverlayPosition.Text = "重设";
            this.button_ResetOverlayPosition.UseVisualStyleBackColor = true;
            this.button_ResetOverlayPosition.Click += new System.EventHandler(this.button_ResetOverlayPosition_Click);
            // 
            // checkBox_CheatRoullete
            // 
            this.checkBox_CheatRoullete.AutoSize = true;
            this.checkBox_CheatRoullete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CheatRoullete.Location = new System.Drawing.Point(6, 137);
            this.checkBox_CheatRoullete.Name = "checkBox_CheatRoullete";
            this.checkBox_CheatRoullete.Size = new System.Drawing.Size(183, 21);
            this.checkBox_CheatRoullete.TabIndex = 3;
            this.checkBox_CheatRoullete.Text = "使用随机任务时显示真实副本";
            this.checkBox_CheatRoullete.UseVisualStyleBackColor = true;
            this.checkBox_CheatRoullete.CheckedChanged += new System.EventHandler(this.checkBox_CheatRoullete_CheckedChanged);
            // 
            // checkBox_FlashWindow
            // 
            this.checkBox_FlashWindow.AutoSize = true;
            this.checkBox_FlashWindow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FlashWindow.Location = new System.Drawing.Point(6, 108);
            this.checkBox_FlashWindow.Name = "checkBox_FlashWindow";
            this.checkBox_FlashWindow.Size = new System.Drawing.Size(204, 21);
            this.checkBox_FlashWindow.TabIndex = 2;
            this.checkBox_FlashWindow.Text = "当副本匹配完成/FATE出现时闪烁";
            this.checkBox_FlashWindow.UseVisualStyleBackColor = true;
            this.checkBox_FlashWindow.CheckedChanged += new System.EventHandler(this.checkBox_FlashWindow_CheckedChanged);
            // 
            // checkBox_AutoOverlayHide
            // 
            this.checkBox_AutoOverlayHide.AutoSize = true;
            this.checkBox_AutoOverlayHide.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AutoOverlayHide.Location = new System.Drawing.Point(6, 79);
            this.checkBox_AutoOverlayHide.Name = "checkBox_AutoOverlayHide";
            this.checkBox_AutoOverlayHide.Size = new System.Drawing.Size(239, 21);
            this.checkBox_AutoOverlayHide.TabIndex = 1;
            this.checkBox_AutoOverlayHide.Text = "在副本里面自动隐藏悬浮窗(优雷卡除外)";
            this.checkBox_AutoOverlayHide.UseVisualStyleBackColor = true;
            this.checkBox_AutoOverlayHide.CheckedChanged += new System.EventHandler(this.checkBox_AutoOverlayHide_CheckedChanged);
            // 
            // checkBox_StartupShow
            // 
            this.checkBox_StartupShow.AutoSize = true;
            this.checkBox_StartupShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_StartupShow.Location = new System.Drawing.Point(6, 50);
            this.checkBox_StartupShow.Name = "checkBox_StartupShow";
            this.checkBox_StartupShow.Size = new System.Drawing.Size(147, 21);
            this.checkBox_StartupShow.TabIndex = 0;
            this.checkBox_StartupShow.Text = "启动程序时显示主界面";
            this.checkBox_StartupShow.UseVisualStyleBackColor = true;
            this.checkBox_StartupShow.CheckedChanged += new System.EventHandler(this.checkBox_StartupShow_CheckedChanged);
            // 
            // tabPage_FATE
            // 
            this.tabPage_FATE.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_FATE.Controls.Add(this.label_FATEAbout);
            this.tabPage_FATE.Controls.Add(this.triStateTreeView_FATEs);
            this.tabPage_FATE.Controls.Add(this.menuStrip_FATETab);
            this.tabPage_FATE.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_FATE.Location = new System.Drawing.Point(114, 4);
            this.tabPage_FATE.Name = "tabPage_FATE";
            this.tabPage_FATE.Size = new System.Drawing.Size(426, 262);
            this.tabPage_FATE.TabIndex = 0;
            this.tabPage_FATE.Text = "临危受命";
            // 
            // label_FATEAbout
            // 
            this.label_FATEAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_FATEAbout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_FATEAbout.Location = new System.Drawing.Point(0, 230);
            this.label_FATEAbout.Name = "label_FATEAbout";
            this.label_FATEAbout.Size = new System.Drawing.Size(426, 32);
            this.label_FATEAbout.TabIndex = 2;
            this.label_FATEAbout.Text = "알림을 받고자 하는 돌발을 선택하신 뒤 상단 적용하기 버튼을 눌러주세요.\r\n돌발 알림은 캐릭터가 해당 지역에 있을 때에만 동작합니다.";
            // 
            // triStateTreeView_FATEs
            // 
            this.triStateTreeView_FATEs.BackColor = System.Drawing.SystemColors.Control;
            this.triStateTreeView_FATEs.Dock = System.Windows.Forms.DockStyle.Top;
            this.triStateTreeView_FATEs.FullRowSelect = true;
            this.triStateTreeView_FATEs.HotTracking = true;
            this.triStateTreeView_FATEs.Location = new System.Drawing.Point(0, 25);
            this.triStateTreeView_FATEs.Name = "triStateTreeView_FATEs";
            this.triStateTreeView_FATEs.Size = new System.Drawing.Size(426, 203);
            this.triStateTreeView_FATEs.TabIndex = 0;
            this.triStateTreeView_FATEs.TriStateStyleProperty = RikTheVeggie.TriStateTreeView.TriStateStyles.Installer;
            // 
            // menuStrip_FATETab
            // 
            this.menuStrip_FATETab.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_FATETab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SelectAll,
            this.toolStripMenuItem_UnSelectAll,
            this.presetToolStripMenuItem,
            this.toolStripMenuItem_SelectApply});
            this.menuStrip_FATETab.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_FATETab.Name = "menuStrip_FATETab";
            this.menuStrip_FATETab.Size = new System.Drawing.Size(426, 25);
            this.menuStrip_FATETab.TabIndex = 0;
            this.menuStrip_FATETab.Text = "menuStrip1";
            // 
            // toolStripMenuItem_SelectAll
            // 
            this.toolStripMenuItem_SelectAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem_SelectAll.Name = "toolStripMenuItem_SelectAll";
            this.toolStripMenuItem_SelectAll.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_SelectAll.Text = "全选";
            this.toolStripMenuItem_SelectAll.Click += new System.EventHandler(this.toolStripMenuItem_SelectAll_Click);
            // 
            // toolStripMenuItem_UnSelectAll
            // 
            this.toolStripMenuItem_UnSelectAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem_UnSelectAll.Name = "toolStripMenuItem_UnSelectAll";
            this.toolStripMenuItem_UnSelectAll.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem_UnSelectAll.Text = "取消全选";
            this.toolStripMenuItem_UnSelectAll.Click += new System.EventHandler(this.toolStripMenuItem_UnSelectAll_Click);
            // 
            // presetToolStripMenuItem
            // 
            this.presetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookOfSkyfireIToolStripMenuItem,
            this.bookOfSkyfireIIToolStripMenuItem,
            this.bookOfNetherfireIToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bookOfSkyfallIToolStripMenuItem,
            this.bookOfSkyfallIIToolStripMenuItem,
            this.bookOfNetherfireIToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.bookOfSkywindIToolStripMenuItem,
            this.bookOfSkywindIIToolStripMenuItem,
            this.toolStripMenuItem3,
            this.bookOfSkyearthIToolStripMenuItem});
            this.presetToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            this.presetToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.presetToolStripMenuItem.Text = "预设";
            // 
            // bookOfSkyfireIToolStripMenuItem
            // 
            this.bookOfSkyfireIToolStripMenuItem.Name = "bookOfSkyfireIToolStripMenuItem";
            this.bookOfSkyfireIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfireIToolStripMenuItem.Text = "불의 서 1권";
            this.bookOfSkyfireIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfireIToolStripMenuItem_Click);
            // 
            // bookOfSkyfireIIToolStripMenuItem
            // 
            this.bookOfSkyfireIIToolStripMenuItem.Name = "bookOfSkyfireIIToolStripMenuItem";
            this.bookOfSkyfireIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfireIIToolStripMenuItem.Text = "불의 서 2권";
            this.bookOfSkyfireIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfireIIToolStripMenuItem_Click);
            // 
            // bookOfNetherfireIToolStripMenuItem
            // 
            this.bookOfNetherfireIToolStripMenuItem.Name = "bookOfNetherfireIToolStripMenuItem";
            this.bookOfNetherfireIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfNetherfireIToolStripMenuItem.Text = "불의 서 3권";
            this.bookOfNetherfireIToolStripMenuItem.Click += new System.EventHandler(this.bookOfNetherfireIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkyfallIToolStripMenuItem
            // 
            this.bookOfSkyfallIToolStripMenuItem.Name = "bookOfSkyfallIToolStripMenuItem";
            this.bookOfSkyfallIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfallIToolStripMenuItem.Text = "물의 서 1권";
            this.bookOfSkyfallIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfallIToolStripMenuItem_Click);
            // 
            // bookOfSkyfallIIToolStripMenuItem
            // 
            this.bookOfSkyfallIIToolStripMenuItem.Name = "bookOfSkyfallIIToolStripMenuItem";
            this.bookOfSkyfallIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyfallIIToolStripMenuItem.Text = "물의 서 2권";
            this.bookOfSkyfallIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyfallIIToolStripMenuItem_Click);
            // 
            // bookOfNetherfireIToolStripMenuItem1
            // 
            this.bookOfNetherfireIToolStripMenuItem1.Name = "bookOfNetherfireIToolStripMenuItem1";
            this.bookOfNetherfireIToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.bookOfNetherfireIToolStripMenuItem1.Text = "물의 서 3권";
            this.bookOfNetherfireIToolStripMenuItem1.Click += new System.EventHandler(this.bookOfNetherfireIToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkywindIToolStripMenuItem
            // 
            this.bookOfSkywindIToolStripMenuItem.Name = "bookOfSkywindIToolStripMenuItem";
            this.bookOfSkywindIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkywindIToolStripMenuItem.Text = "바람의 서 1권";
            this.bookOfSkywindIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkywindIToolStripMenuItem_Click);
            // 
            // bookOfSkywindIIToolStripMenuItem
            // 
            this.bookOfSkywindIIToolStripMenuItem.Name = "bookOfSkywindIIToolStripMenuItem";
            this.bookOfSkywindIIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkywindIIToolStripMenuItem.Text = "바람의 서 2권";
            this.bookOfSkywindIIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkywindIIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 6);
            // 
            // bookOfSkyearthIToolStripMenuItem
            // 
            this.bookOfSkyearthIToolStripMenuItem.Name = "bookOfSkyearthIToolStripMenuItem";
            this.bookOfSkyearthIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bookOfSkyearthIToolStripMenuItem.Text = "땅의 서 1권";
            this.bookOfSkyearthIToolStripMenuItem.Click += new System.EventHandler(this.bookOfSkyearthIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_SelectApply
            // 
            this.toolStripMenuItem_SelectApply.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_SelectApply.Name = "toolStripMenuItem_SelectApply";
            this.toolStripMenuItem_SelectApply.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_SelectApply.Text = "应用";
            this.toolStripMenuItem_SelectApply.Click += new System.EventHandler(this.toolStripMenuItem_SelectApply_Click);
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Log.Controls.Add(this.panel_LogCover);
            this.tabPage_Log.Controls.Add(this.menuStrip_LogTab);
            this.tabPage_Log.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Log.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Size = new System.Drawing.Size(426, 262);
            this.tabPage_Log.TabIndex = 2;
            this.tabPage_Log.Text = "记录";
            // 
            // panel_LogCover
            // 
            this.panel_LogCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LogCover.Controls.Add(this.richTextBox_Log);
            this.panel_LogCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LogCover.Location = new System.Drawing.Point(0, 25);
            this.panel_LogCover.Name = "panel_LogCover";
            this.panel_LogCover.Size = new System.Drawing.Size(426, 237);
            this.panel_LogCover.TabIndex = 1;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Log.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Log.Size = new System.Drawing.Size(424, 235);
            this.richTextBox_Log.TabIndex = 0;
            this.richTextBox_Log.Text = "";
            this.richTextBox_Log.TextChanged += new System.EventHandler(this.richTextBox_Log_TextChanged);
            // 
            // menuStrip_LogTab
            // 
            this.menuStrip_LogTab.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_LogTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LogCopy,
            this.toolStripMenuItem_LogClear});
            this.menuStrip_LogTab.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_LogTab.Name = "menuStrip_LogTab";
            this.menuStrip_LogTab.Size = new System.Drawing.Size(426, 25);
            this.menuStrip_LogTab.TabIndex = 0;
            this.menuStrip_LogTab.Text = "menuStrip2";
            // 
            // toolStripMenuItem_LogCopy
            // 
            this.toolStripMenuItem_LogCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem_LogCopy.Name = "toolStripMenuItem_LogCopy";
            this.toolStripMenuItem_LogCopy.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem_LogCopy.Text = "复制日志";
            this.toolStripMenuItem_LogCopy.Click += new System.EventHandler(this.toolStripMenuItem_LogCopy_Click);
            // 
            // toolStripMenuItem_LogClear
            // 
            this.toolStripMenuItem_LogClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem_LogClear.Name = "toolStripMenuItem_LogClear";
            this.toolStripMenuItem_LogClear.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_LogClear.Text = "清除";
            this.toolStripMenuItem_LogClear.Click += new System.EventHandler(this.toolStripMenuItem_LogClear_Click);
            // 
            // tabPage_Info
            // 
            this.tabPage_Info.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Info.Controls.Add(this.label_About);
            this.tabPage_Info.Controls.Add(this.linkLabel_GitHub);
            this.tabPage_Info.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Info.Location = new System.Drawing.Point(114, 4);
            this.tabPage_Info.Name = "tabPage_Info";
            this.tabPage_Info.Size = new System.Drawing.Size(426, 262);
            this.tabPage_Info.TabIndex = 3;
            this.tabPage_Info.Text = "关于";
            // 
            // label_About
            // 
            this.label_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_About.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_About.Location = new System.Drawing.Point(0, 0);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(426, 225);
            this.label_About.TabIndex = 0;
            this.label_About.Text = "[贡献者]\r\n유채색\r\nLaiglinne\r\nHibiyasleep\r\nAlex00728\r\n紫水栈桥《众神之上》部队\r\n\r\n[版权所有]\r\n(C) 2010 -" +
    " 2019 SQUARE ENIX CO., LTD All Rights Reserved.\r\nKorea Published by EYEDENTITY M" +
    "OBILE.\r\n上海数龙科技有限公司";
            this.label_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel_GitHub.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_GitHub.Location = new System.Drawing.Point(0, 225);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(426, 37);
            this.linkLabel_GitHub.TabIndex = 0;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "GitHub";
            this.linkLabel_GitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GitHub_LinkClicked);
            // 
            // label_AboutTitle
            // 
            this.label_AboutTitle.BackColor = System.Drawing.Color.Silver;
            this.label_AboutTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_AboutTitle.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_AboutTitle.ForeColor = System.Drawing.Color.Gray;
            this.label_AboutTitle.Location = new System.Drawing.Point(0, 297);
            this.label_AboutTitle.Name = "label_AboutTitle";
            this.label_AboutTitle.Size = new System.Drawing.Size(544, 24);
            this.label_AboutTitle.TabIndex = 0;
            this.label_AboutTitle.Text = "VERSION STRING";
            this.label_AboutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label_AboutTitle);
            this.Controls.Add(this.panel_TopSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duty/FATE Assist X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel_TopSetting.ResumeLayout(false);
            this.panel_TopSetting.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.groupBox_DefaultSet.ResumeLayout(false);
            this.groupBox_DefaultSet.PerformLayout();
            this.tabPage_FATE.ResumeLayout(false);
            this.tabPage_FATE.PerformLayout();
            this.menuStrip_FATETab.ResumeLayout(false);
            this.menuStrip_FATETab.PerformLayout();
            this.tabPage_Log.ResumeLayout(false);
            this.tabPage_Log.PerformLayout();
            this.panel_LogCover.ResumeLayout(false);
            this.menuStrip_LogTab.ResumeLayout(false);
            this.menuStrip_LogTab.PerformLayout();
            this.tabPage_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
        private System.Windows.Forms.CheckBox checkBox_Overlay;
        private LocalizableLabel label_AboutTitle;
        private System.Windows.Forms.Button button_ResetOverlayPosition;
        private System.Windows.Forms.Button button_SelectProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.CheckBox checkBox_StartupShow;
        private System.Windows.Forms.ComboBox comboBox_Process;
        private System.Windows.Forms.Button button_ResetProcess;
        internal RikTheVeggie.TriStateTreeView triStateTreeView_FATEs;
        private System.Windows.Forms.Panel panel_TopSetting;
        private LocalizableLabel label_Process;
        private TabControlBlack tabControl;
        private System.Windows.Forms.TabPage tabPage_FATE;
        private System.Windows.Forms.TabPage tabPage_Settings;
        private System.Windows.Forms.MenuStrip menuStrip_FATETab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_UnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SelectApply;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.Panel panel_LogCover;
        private System.Windows.Forms.MenuStrip menuStrip_LogTab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LogCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LogClear;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tabPage_Info;
        private LocalizableLabel label_About;
        private System.Windows.Forms.GroupBox groupBox_DefaultSet;
        private System.Windows.Forms.CheckBox checkBox_AutoOverlayHide;
        internal System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox checkBox_FlashWindow;
        private System.Windows.Forms.CheckBox checkBox_CheatRoullete;
        private System.Windows.Forms.ToolStripMenuItem presetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfireIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfireIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfNetherfireIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfallIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyfallIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfNetherfireIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkywindIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkywindIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bookOfSkyearthIToolStripMenuItem;
        private LocalizableLabel label_FATEAbout;
        private System.Windows.Forms.CheckBox checkBox_Remind;
        private System.Windows.Forms.CheckBox checkBox_tts;
    }
}

