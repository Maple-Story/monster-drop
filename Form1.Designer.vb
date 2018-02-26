<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LF = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.怪物名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.掉落物名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.怪物編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.掉落物編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.機率數量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.機率實際DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MDDataSet = New MonsterDrop.MDDataSet()
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.詳細資訊ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.排序方式 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.怪物掉落表TableAdapter = New MonsterDrop.MDDataSetTableAdapters.怪物掉落表TableAdapter()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.C3 = New System.Windows.Forms.CheckBox()
        Me.C2 = New System.Windows.Forms.CheckBox()
        Me.C4 = New System.Windows.Forms.CheckBox()
        Me.顯示欄位 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS1.SuspendLayout()
        Me.排序方式.SuspendLayout()
        Me.顯示欄位.SuspendLayout()
        Me.SuspendLayout()
        '
        'LF
        '
        Me.LF.Location = New System.Drawing.Point(591, 12)
        Me.LF.Name = "LF"
        Me.LF.Size = New System.Drawing.Size(64, 64)
        Me.LF.TabIndex = 0
        Me.LF.Text = "查詢"
        Me.LF.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 12)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 39)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 47)
        Me.TextBox2.MaxLength = 23
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(111, 39)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "怪物名稱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "掉落物名稱"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.編號DataGridViewTextBoxColumn, Me.怪物名稱DataGridViewTextBoxColumn, Me.掉落物名稱DataGridViewTextBoxColumn, Me.怪物編號DataGridViewTextBoxColumn, Me.掉落物編號DataGridViewTextBoxColumn, Me.機率數量DataGridViewTextBoxColumn, Me.機率實際DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(643, 367)
        Me.DataGridView1.TabIndex = 5
        '
        '編號DataGridViewTextBoxColumn
        '
        Me.編號DataGridViewTextBoxColumn.DataPropertyName = "編號"
        Me.編號DataGridViewTextBoxColumn.HeaderText = "編號"
        Me.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn"
        Me.編號DataGridViewTextBoxColumn.Width = 97
        '
        '怪物名稱DataGridViewTextBoxColumn
        '
        Me.怪物名稱DataGridViewTextBoxColumn.DataPropertyName = "怪物名稱"
        Me.怪物名稱DataGridViewTextBoxColumn.HeaderText = "怪物名稱"
        Me.怪物名稱DataGridViewTextBoxColumn.Name = "怪物名稱DataGridViewTextBoxColumn"
        Me.怪物名稱DataGridViewTextBoxColumn.Width = 145
        '
        '掉落物名稱DataGridViewTextBoxColumn
        '
        Me.掉落物名稱DataGridViewTextBoxColumn.DataPropertyName = "掉落物名稱"
        Me.掉落物名稱DataGridViewTextBoxColumn.HeaderText = "掉落物名稱"
        Me.掉落物名稱DataGridViewTextBoxColumn.Name = "掉落物名稱DataGridViewTextBoxColumn"
        Me.掉落物名稱DataGridViewTextBoxColumn.Width = 169
        '
        '怪物編號DataGridViewTextBoxColumn
        '
        Me.怪物編號DataGridViewTextBoxColumn.DataPropertyName = "怪物編號"
        Me.怪物編號DataGridViewTextBoxColumn.HeaderText = "怪物編號"
        Me.怪物編號DataGridViewTextBoxColumn.Name = "怪物編號DataGridViewTextBoxColumn"
        Me.怪物編號DataGridViewTextBoxColumn.Width = 145
        '
        '掉落物編號DataGridViewTextBoxColumn
        '
        Me.掉落物編號DataGridViewTextBoxColumn.DataPropertyName = "掉落物編號"
        Me.掉落物編號DataGridViewTextBoxColumn.HeaderText = "掉落物編號"
        Me.掉落物編號DataGridViewTextBoxColumn.Name = "掉落物編號DataGridViewTextBoxColumn"
        Me.掉落物編號DataGridViewTextBoxColumn.Width = 169
        '
        '機率數量DataGridViewTextBoxColumn
        '
        Me.機率數量DataGridViewTextBoxColumn.DataPropertyName = "機率(數量)"
        Me.機率數量DataGridViewTextBoxColumn.HeaderText = "機率(數量)"
        Me.機率數量DataGridViewTextBoxColumn.Name = "機率數量DataGridViewTextBoxColumn"
        Me.機率數量DataGridViewTextBoxColumn.Width = 161
        '
        '機率實際DataGridViewTextBoxColumn
        '
        Me.機率實際DataGridViewTextBoxColumn.DataPropertyName = "機率(實際)"
        Me.機率實際DataGridViewTextBoxColumn.HeaderText = "機率(實際)"
        Me.機率實際DataGridViewTextBoxColumn.Name = "機率實際DataGridViewTextBoxColumn"
        Me.機率實際DataGridViewTextBoxColumn.Width = 161
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "怪物掉落表"
        Me.BindingSource1.DataSource = Me.MDDataSet
        '
        'MDDataSet
        '
        Me.MDDataSet.DataSetName = "MDDataSet"
        Me.MDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CMS1
        '
        Me.CMS1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CMS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.詳細資訊ToolStripMenuItem})
        Me.CMS1.Name = "CMS1"
        Me.CMS1.Size = New System.Drawing.Size(166, 34)
        '
        '詳細資訊ToolStripMenuItem
        '
        Me.詳細資訊ToolStripMenuItem.Name = "詳細資訊ToolStripMenuItem"
        Me.詳細資訊ToolStripMenuItem.Size = New System.Drawing.Size(165, 30)
        Me.詳細資訊ToolStripMenuItem.Text = "詳細資訊"
        '
        '排序方式
        '
        Me.排序方式.Controls.Add(Me.ComboBox1)
        Me.排序方式.Controls.Add(Me.R2)
        Me.排序方式.Controls.Add(Me.R1)
        Me.排序方式.Location = New System.Drawing.Point(441, 0)
        Me.排序方式.Name = "排序方式"
        Me.排序方式.Size = New System.Drawing.Size(144, 76)
        Me.排序方式.TabIndex = 9
        Me.排序方式.TabStop = False
        Me.排序方式.Text = "排序方式"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"預設", "怪物名稱", "掉落物名稱", "怪物編號", "掉落物編號"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(118, 38)
        Me.ComboBox1.TabIndex = 12
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Location = New System.Drawing.Point(76, 49)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(86, 34)
        Me.R2.TabIndex = 11
        Me.R2.Text = "遞減"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Checked = True
        Me.R1.Location = New System.Drawing.Point(11, 49)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(86, 34)
        Me.R1.TabIndex = 10
        Me.R1.TabStop = True
        Me.R1.Text = "遞增"
        Me.R1.UseVisualStyleBackColor = True
        '
        '怪物掉落表TableAdapter
        '
        Me.怪物掉落表TableAdapter.ClearBeforeFill = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 455)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(643, 18)
        Me.ProgressBar1.TabIndex = 11
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Checked = True
        Me.C1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C1.Enabled = False
        Me.C1.Location = New System.Drawing.Point(5, 21)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(135, 34)
        Me.C1.TabIndex = 8
        Me.C1.Text = "怪物名稱"
        Me.C1.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Checked = True
        Me.C3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C3.Enabled = False
        Me.C3.Location = New System.Drawing.Point(108, 20)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(135, 34)
        Me.C3.TabIndex = 10
        Me.C3.Text = "怪物編號"
        Me.C3.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Checked = True
        Me.C2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C2.Enabled = False
        Me.C2.Location = New System.Drawing.Point(5, 46)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(159, 34)
        Me.C2.TabIndex = 11
        Me.C2.Text = "掉落物名稱"
        Me.C2.UseVisualStyleBackColor = True
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Checked = True
        Me.C4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C4.Enabled = False
        Me.C4.Location = New System.Drawing.Point(108, 46)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(159, 34)
        Me.C4.TabIndex = 13
        Me.C4.Text = "掉落物編號"
        Me.C4.UseVisualStyleBackColor = True
        '
        '顯示欄位
        '
        Me.顯示欄位.Controls.Add(Me.C4)
        Me.顯示欄位.Controls.Add(Me.C2)
        Me.顯示欄位.Controls.Add(Me.C3)
        Me.顯示欄位.Controls.Add(Me.C1)
        Me.顯示欄位.Location = New System.Drawing.Point(218, 0)
        Me.顯示欄位.Name = "顯示欄位"
        Me.顯示欄位.Size = New System.Drawing.Size(217, 76)
        Me.顯示欄位.TabIndex = 10
        Me.顯示欄位.TabStop = False
        Me.顯示欄位.Text = "顯示欄位"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 480)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.顯示欄位)
        Me.Controls.Add(Me.排序方式)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LF)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MonsterDrop By雪楓月舞"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS1.ResumeLayout(False)
        Me.排序方式.ResumeLayout(False)
        Me.排序方式.PerformLayout()
        Me.顯示欄位.ResumeLayout(False)
        Me.顯示欄位.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LF As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 排序方式 As GroupBox
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R1 As RadioButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MDDataSet As MDDataSet
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 怪物名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 掉落物名稱DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 怪物編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 掉落物編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 機率數量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 機率實際DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 怪物掉落表TableAdapter As MDDataSetTableAdapters.怪物掉落表TableAdapter
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CMS1 As ContextMenuStrip
    Friend WithEvents 詳細資訊ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C1 As CheckBox
    Friend WithEvents C3 As CheckBox
    Friend WithEvents C2 As CheckBox
    Friend WithEvents C4 As CheckBox
    Friend WithEvents 顯示欄位 As GroupBox
End Class
