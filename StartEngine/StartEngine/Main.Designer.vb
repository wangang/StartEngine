<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortName = New System.Windows.Forms.ToolStripComboBox()
        Me.BaudRates = New System.Windows.Forms.ToolStripComboBox()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.engineStop = New System.Windows.Forms.Button()
        Me.engineStart = New System.Windows.Forms.Button()
        Me.downLoad = New System.Windows.Forms.Button()
        Me.ConfigDataGrid = New System.Windows.Forms.DataGridView()
        Me.ChannelName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SignalAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToContinue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ZedGraphControl2 = New ZedGraph.ZedGraphControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SaveData = New System.Windows.Forms.Button()
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl()
        Me.ComPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ConfigDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 394)
        Me.Panel1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 372)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(536, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar
        '
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.编辑ToolStripMenuItem, Me.设置ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 25)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem1.Text = "文件"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem2.Text = "打开"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem3.Text = "保存"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem4.Text = "另存为"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem6.Text = "退出"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9})
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.编辑ToolStripMenuItem.Text = "编辑"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem7.Text = "上移"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem8.Text = "下移"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem9.Text = "删除"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortName, Me.BaudRates})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        'PortName
        '
        Me.PortName.AutoCompleteCustomSource.AddRange(New String() {"COM1", "COM2", "COM3", "COM4"})
        Me.PortName.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        Me.PortName.Name = "PortName"
        Me.PortName.Size = New System.Drawing.Size(121, 25)
        '
        'BaudRates
        '
        Me.BaudRates.Name = "BaudRates"
        Me.BaudRates.Size = New System.Drawing.Size(121, 25)
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem5.Text = "关于"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 340)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.engineStop)
        Me.TabPage1.Controls.Add(Me.engineStart)
        Me.TabPage1.Controls.Add(Me.downLoad)
        Me.TabPage1.Controls.Add(Me.ConfigDataGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 314)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "时序配置"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'engineStop
        '
        Me.engineStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engineStop.Location = New System.Drawing.Point(424, 268)
        Me.engineStop.Name = "engineStop"
        Me.engineStop.Size = New System.Drawing.Size(92, 37)
        Me.engineStop.TabIndex = 9
        Me.engineStop.Text = "停止"
        Me.engineStop.UseVisualStyleBackColor = True
        '
        'engineStart
        '
        Me.engineStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.engineStart.Location = New System.Drawing.Point(205, 268)
        Me.engineStart.Name = "engineStart"
        Me.engineStart.Size = New System.Drawing.Size(92, 37)
        Me.engineStart.TabIndex = 8
        Me.engineStart.Text = "启动"
        Me.engineStart.UseVisualStyleBackColor = True
        '
        'downLoad
        '
        Me.downLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.downLoad.Location = New System.Drawing.Point(6, 268)
        Me.downLoad.Name = "downLoad"
        Me.downLoad.Size = New System.Drawing.Size(97, 37)
        Me.downLoad.TabIndex = 7
        Me.downLoad.Text = "下载"
        Me.downLoad.UseVisualStyleBackColor = True
        '
        'ConfigDataGrid
        '
        Me.ConfigDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConfigDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChannelName, Me.SignalAddress, Me.TimeToStart, Me.TimeToContinue, Me.Note})
        Me.ConfigDataGrid.Location = New System.Drawing.Point(3, 6)
        Me.ConfigDataGrid.Name = "ConfigDataGrid"
        Me.ConfigDataGrid.RowTemplate.Height = 23
        Me.ConfigDataGrid.Size = New System.Drawing.Size(514, 256)
        Me.ConfigDataGrid.TabIndex = 0
        '
        'ChannelName
        '
        Me.ChannelName.HeaderText = "通道名称"
        Me.ChannelName.Name = "ChannelName"
        '
        'SignalAddress
        '
        Me.SignalAddress.HeaderText = "通道号"
        Me.SignalAddress.Name = "SignalAddress"
        '
        'TimeToStart
        '
        Me.TimeToStart.HeaderText = "启动时间"
        Me.TimeToStart.Name = "TimeToStart"
        '
        'TimeToContinue
        '
        Me.TimeToContinue.HeaderText = "持续时间"
        Me.TimeToContinue.Name = "TimeToContinue"
        '
        'Note
        '
        Me.Note.HeaderText = "备注"
        Me.Note.Name = "Note"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ZedGraphControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(522, 314)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "时序图"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ZedGraphControl2
        '
        Me.ZedGraphControl2.Location = New System.Drawing.Point(3, 3)
        Me.ZedGraphControl2.Name = "ZedGraphControl2"
        Me.ZedGraphControl2.ScrollGrace = 0.0R
        Me.ZedGraphControl2.ScrollMaxX = 0.0R
        Me.ZedGraphControl2.ScrollMaxY = 0.0R
        Me.ZedGraphControl2.ScrollMaxY2 = 0.0R
        Me.ZedGraphControl2.ScrollMinX = 0.0R
        Me.ZedGraphControl2.ScrollMinY = 0.0R
        Me.ZedGraphControl2.ScrollMinY2 = 0.0R
        Me.ZedGraphControl2.Size = New System.Drawing.Size(514, 308)
        Me.ZedGraphControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SaveData)
        Me.TabPage2.Controls.Add(Me.ZedGraphControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 314)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "信号采集"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SaveData
        '
        Me.SaveData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveData.AutoSize = True
        Me.SaveData.Location = New System.Drawing.Point(6, 280)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(105, 28)
        Me.SaveData.TabIndex = 1
        Me.SaveData.Text = "保存"
        Me.SaveData.UseVisualStyleBackColor = True
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedGraphControl1.Location = New System.Drawing.Point(3, 3)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0.0R
        Me.ZedGraphControl1.ScrollMaxX = 0.0R
        Me.ZedGraphControl1.ScrollMaxY = 0.0R
        Me.ZedGraphControl1.ScrollMaxY2 = 0.0R
        Me.ZedGraphControl1.ScrollMinX = 0.0R
        Me.ZedGraphControl1.ScrollMinY = 0.0R
        Me.ZedGraphControl1.ScrollMinY2 = 0.0R
        Me.ZedGraphControl1.Size = New System.Drawing.Size(513, 274)
        Me.ZedGraphControl1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 394)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "StartEngine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ConfigDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ConfigDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents SaveData As System.Windows.Forms.Button
    Friend WithEvents engineStop As System.Windows.Forms.Button
    Friend WithEvents engineStart As System.Windows.Forms.Button
    Friend WithEvents downLoad As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortName As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BaudRates As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ZedGraphControl2 As ZedGraph.ZedGraphControl
    Friend WithEvents ComPort As System.IO.Ports.SerialPort
    Friend WithEvents ChannelName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SignalAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeToStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeToContinue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Note As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
