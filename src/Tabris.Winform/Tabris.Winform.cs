using DSkin.Common;
using DSkin.DirectUI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tabris.Winform.Control;
namespace Tabris.Winform
{
    public partial class TabrisWinform : DSkin.Forms.DSkinForm
    {
        DuiButton addButton = new DuiButton { NormalImage = Properties.Resources.ChromeAdd, HoverImage = Properties.Resources.ChromeAddHover, Margin = new Padding(0, 3, 0, 0), Name = "add", MouseEventBubble = false ,Cursor= System.Windows.Forms.Cursors.Hand };
        private string tabrisUrl = string.Empty;
        private int DebuggerPort;
        private Process debuggerProcess ;
        public TabrisWinform()
        {
            InitializeComponent();

            var domanPath = AppDomain.CurrentDomain.BaseDirectory;
            var tabrisFolder = Path.Combine(domanPath, "tabris");
            if (!Directory.Exists(tabrisFolder))
            {
                throw new FileNotFoundException(tabrisFolder);
            }
            var indexFile = Path.Combine(tabrisFolder, "tabris.html");
            if (!File.Exists(indexFile))
            {
                throw new FileNotFoundException(indexFile);
            }

            tabrisUrl = "file:///" + indexFile;

            this.MinimumSize = new Size(770, 570);

            this.IsLayeredWindowForm = false;

        }


        private void TabrisWinform_Load(object sender, EventArgs e)
        {
            StartRDing();
            dSkinTabBar1.Items.ItemAdded += Items_ItemAdded;
            dSkinTabBar1.Items.ItemRemoved += Items_ItemRemoved;
            dSkinTabControl1.ItemSize = new Size(1, 1);
            dSkinTabBar1.Items.Add(addButton);
            addButton.MouseClick += add_MouseClick;
            dSkinTabBar1.InnerDuiControl.MouseDown += InnerDuiControl_MouseDown;

            add_MouseClick(null, null);

            
        }
        void InnerDuiControl_MouseDown(object sender, DuiMouseEventArgs e)
        {
            DSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }
        void Items_ItemRemoved(object sender, CollectionEventArgs<DuiBaseControl> e)
        {
            if (dSkinTabBar1.Items.Count == 1)
            {
                addButton.Margin = new Padding(0, 3, 0, 0);
            }
            else
            {
                addButton.Margin = new Padding(-2, 3, 0, 0);
            }
            SetItemSize();
        }

        void Items_ItemAdded(object sender, CollectionEventArgs<DuiBaseControl> e)
        {
            SetItemSize();
        }

        public void ShowDebugView(TabrisTabItem item)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                dSkinTabBar1.SetSelect(item);
            }));
        }

        public void addDebugPanel(DuiMiniBlink chrome, Action OnClosing)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                LogPannel logPannel = new LogPannel();
                var selected = GetSelectedTabrisControlContainer();
                if (selected != null)
                {
                    if (selected.LogPannel != null)
                    {
                        selected.LogPannel.OnLoging += delegate (object sender, EventArgs args)
                        {
                            var model = sender as LogEventModel;
                            if (model != null)
                            {
                                logPannel.Log(model.LogLevel, model.Message);
                            }
                        };
                    }
                }
                var index = dSkinTabBar1.Items.IndexOf(addButton);
                TabrisTabItem item = new TabrisTabItem()
                {
                    Text = "debug " + (index + 1),
                    Image = Properties.Resources.JSS
                };
                dSkinTabBar1.Items.Insert(index, item);
                TabPage page = new TabPage();
                item.TabPage = page;
                dSkinTabControl1.TabPages.Add(page);
                dSkinTabBar1.LayoutContent();
                dSkinTabBar1.SetSelect(item);
                chrome.Tag = item;
                DSkin.Controls.DSkinBaseControl db = new DSkin.Controls.DSkinBaseControl { Dock = DockStyle.Fill };
                db.DUIControls.Add(chrome);
                page.Controls.Add(db);
                var buttonPanel = new ChromeButtonPannel(chrome);
                this.dSkinPanel3.Controls.Add(buttonPanel);
                this.dSkinPanel1.Controls.Add(logPannel);
                item.Tag = new ViewControlContainer
                {
                    OnClosing = delegate ()
                    {
                        OnClosing();
                        if (selected != null)
                        {
                            selected.LogPannel.OnLoging -= delegate (object sender, EventArgs args)
                            {
                                var model = sender as LogEventModel;
                                if (model != null)
                                {
                                    logPannel.Log(model.LogLevel, model.Message);
                                }
                            };
                        }
                    },
                    ButtonPannel = buttonPanel,
                    LogPannel = logPannel
                };

            }));

        }
        public void addPanel(DuiMiniBlink chrome,Action OnClosing)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                LogPannel logPannel = new LogPannel();
                var selected = GetSelectedTabrisControlContainer();
                if (selected != null)
                {
                    if (selected.LogPannel != null)
                    {
                        selected.LogPannel.OnLoging += delegate(object sender, EventArgs args)
                        {
                            var model = sender as LogEventModel;
                            if (model != null)
                            {
                                logPannel.Log(model.LogLevel, model.Message);
                            }
                        };
                    }
                }
                var index = dSkinTabBar1.Items.IndexOf(addButton);
                TabrisTabItem item = new TabrisTabItem()
                {
                    Text = "view " + (index + 1),
                    Image = Properties.Resources.JSS
                };
                dSkinTabBar1.Items.Insert(index, item);
                TabPage page = new TabPage();
                item.TabPage = page;
                dSkinTabControl1.TabPages.Add(page);
                dSkinTabBar1.LayoutContent();
                dSkinTabBar1.SetSelect(item);
                DSkin.Controls.DSkinBaseControl db = new DSkin.Controls.DSkinBaseControl { Dock = DockStyle.Fill };
               
                db.DUIControls.Add(chrome);
                page.Controls.Add(db);
                var buttonPanel = new ChromeButtonPannel(chrome);
                this.dSkinPanel3.Controls.Add(buttonPanel);
                this.dSkinPanel1.Controls.Add(logPannel);
                item.Tag = new ViewControlContainer
                {
                    OnClosing = delegate()
                    {
                        OnClosing();
                        if (selected != null)
                        {
                            selected.LogPannel.OnLoging -= delegate(object sender, EventArgs args)
                            {
                                var model = sender as LogEventModel;
                                if (model != null)
                                {
                                    logPannel.Log(model.LogLevel, model.Message);
                                }
                            };
                        }
                    },
                    ButtonPannel = buttonPanel,
                    LogPannel = logPannel
                };

            }));
           
        }
        void add_MouseClick(object sender, DuiMouseEventArgs e)
        {
            var index = dSkinTabBar1.Items.IndexOf(addButton);
            TabrisTabItem item = new TabrisTabItem()
            {
                Text = "new " + (index + 1),
                Image = Properties.Resources.JSS
            };
            dSkinTabBar1.Items.Insert(index, item);
            //item.SendToBack();
            DSkin.Controls.DSkinBaseControl db = new DSkin.Controls.DSkinBaseControl { Dock = DockStyle.Fill };
            var  brower = new DuiMiniBlink()
            {
                Url = this.tabrisUrl,
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.White,
                ContextMenuStrip = this.codemirrowMenu,
                Visible = true
            };
            brower.Tag = item;
            db.DUIControls.Add(brower);
            //db.Controls.Add(brower);


            LogPannel logPannel = new LogPannel();
            ButtonPannel buttonPannel = new ButtonPannel(brower,this.DebuggerPort, logPannel.Log, logPannel.LogClear, addPanel, addDebugPanel, ShowDebugView)
            {
                Index = index,
                OnTitleChange = s =>
                {
                    item.Text = s;
                    var tag = item.Tag as TabrisControlContainer;
                    if (tag != null)
                    {
                        tag.TagName = s;
                    }
                },
                OnModify = () =>
                {
                    var tag = item.Tag as TabrisControlContainer;
                    if (tag != null)
                    {
                        item.Text = " * " + tag.TagName;
                    }
                    
                }
            };

            TabPage page = new TabPage();


            item.TabPage = page;
            dSkinTabControl1.TabPages.Add(page);
            dSkinTabBar1.LayoutContent();
            dSkinTabBar1.SetSelect(item);

            page.Controls.Add(db);

            this.dSkinPanel3.Controls.Add(buttonPannel);
            this.dSkinPanel1.Controls.Add(logPannel);
            item.Tag = new TabrisControlContainer
            {
                ButtonPannel = buttonPannel,
                LogPannel = logPannel,
                TagName = item.Text
            };
        }
       
        private void dSkinTabBar1_SizeChanged(object sender, EventArgs e)
        {
            SetItemSize();
        }
        private void SetItemSize()
        {
            if (dSkinTabBar1.Items.Count > 1)
            {
                int w = 150;
                if ((dSkinTabBar1.Items.Count - 1) * 150 + 15 > dSkinTabBar1.Width)
                {
                    w = (dSkinTabBar1.Width - 45) / (dSkinTabBar1.Items.Count - 1) + 13;
                }
                foreach (DuiBaseControl item in dSkinTabBar1.Items)
                {
                    if (item is TabrisTabItem)
                    {
                        item.Width = w;
                    }
                }
            }
        }

    

      

        private TabrisControlContainer GetSelectedTabrisControlContainer()
        {
            try
            {
                if (this.dSkinTabBar1.Items.Count == 1) return null;
                var selectItem = this.dSkinTabBar1.Items[this.dSkinTabBar1.SelectedIndex];
                return selectItem.Tag as TabrisControlContainer;
            }
            catch (Exception)
            {
                return null;
            }
        }

     

        private void TabrisWinform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
            CutProcess();
        }

        /// <summary>
        /// 开启应用程序
        /// </summary>
        private  void StartRDing()
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("inspector");
                foreach (Process process in processes)
                {
                    process.Kill();
                }

                var inteceporPath = Application.StartupPath + "\\" + "inspector.exe";
                if (!File.Exists(inteceporPath))
                {
                    return;
                }

                DebuggerPort = PortUtilities.FindFreePort();
                debuggerProcess = new Process();
                // 设置启动进程路径
                debuggerProcess.StartInfo.FileName = inteceporPath;
                debuggerProcess.StartInfo.Arguments = "--web-port="+ DebuggerPort;
                debuggerProcess.EnableRaisingEvents = true;
                // 是否在新窗口中启动该进程的值
                debuggerProcess.StartInfo.CreateNoWindow = true;
                debuggerProcess.StartInfo.UseShellExecute = true;
                debuggerProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                debuggerProcess.Exited += new EventHandler(pro_Exited);
                debuggerProcess.Start();
            }
            catch (Exception ex)
            {
                //ignore
                MessageBox.Show("debugger start Error", "Error");
            }
        }

        private static void pro_Exited(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// 检测是否存在进程， 存在就杀进程
        /// </summary>
        private  void CutProcess()
        {
            try
            {
                if (debuggerProcess != null)
                {
                    debuggerProcess.Kill();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("kill debugger error,please try close inspector process in Task Manager!", "Error");
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.PasteToclipboard();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.CopyFromclipboard();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.DeleteSeletectd();
        }

        private void 格式化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.FormatSeletectd();
        }

        private void 注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.Annotation(true);
        }

        private void 反注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.Annotation(false);
        }

        private void 提示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.Tip();
        }

        private void 打开DevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.ShowDevTools();
        }
        private void debuggerF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.DebugEx();
        }

        private void 清除LOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSelectedTabrisControlContainer()?.ButtonPannel.ClearLog();
        }

        private void codemirrowMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var seleted = GetSelectedTabrisControlContainer();
            if (seleted == null)
            {
                return;
            }

            if (seleted.ButtonPannel.HaveSelected())
            {
                复制ToolStripMenuItem.Text = "复制";
                删除ToolStripMenuItem.Visible = true;
                格式化ToolStripMenuItem.Visible = true;
            }
            else
            {
                复制ToolStripMenuItem.Text = "复制全部";
                删除ToolStripMenuItem.Visible = false;
                格式化ToolStripMenuItem.Visible = false;
            }

            if (string.IsNullOrEmpty(Clipboard.GetText()))
            {
                粘贴ToolStripMenuItem.Enabled = false;
            }
        }

    }

}
