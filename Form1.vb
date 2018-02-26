Imports System.Data.SqlClient
Public Class Form1
    Public mode As Boolean = False
    Dim dv As DataView
    Dim cnStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
                "AttachDbFilename=|DataDirectory|MD.mdf;" &
                "Integrated Security=True;"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(1).ContextMenuStrip = CMS1
        DataGridView1.Columns(2).ContextMenuStrip = CMS1
        Using cn As New SqlConnection()
            cn.ConnectionString = cnStr
            Dim da As New SqlDataAdapter("SELECT 編號, 怪物名稱, 掉落物名稱, 怪物編號, 掉落物編號 FROM dbo.怪物掉落表", cn)
            Dim ds As New DataSet()
            da.Fill(ds, "怪物掉落表")
            dv = ds.Tables("怪物掉落表").DefaultView
        End Using
        ComboBox1.Text = "預設"
        DataGridView1.Columns(0).Visible = False '編號
        DataGridView1.Columns(5).Visible = False '機率(數量)
        DataGridView1.Columns(6).Visible = False '機率(實際)
        DataGridView1.DataSource = dv
        ProgressBar1.Value = 100
    End Sub

    Private Sub LF_Click(sender As Object, e As EventArgs) Handles LF.Click
        RBar()

        Using cn As New SqlConnection
            cn.ConnectionString = cnStr
            Dim daStr As String = "SELECT 編號"
            If C1.Checked Then
                daStr &= ", 怪物名稱"
                DataGridView1.Columns(1).Visible = True
            ElseIf C1.Checked = False Then
                DataGridView1.Columns(1).Visible = False
            End If
            If C2.Checked Then
                daStr &= ", 掉落物名稱"
                DataGridView1.Columns(2).Visible = True
            ElseIf C2.Checked = False Then
                DataGridView1.Columns(2).Visible = False
            End If
            If C3.Checked Then
                daStr &= ", 怪物編號"
                DataGridView1.Columns(3).Visible = True
            ElseIf C3.Checked = False Then
                DataGridView1.Columns(3).Visible = False
            End If
            If C4.Checked Then
                daStr &= ", 掉落物編號"
                DataGridView1.Columns(4).Visible = True
            ElseIf C4.Checked = False Then
                DataGridView1.Columns(4).Visible = False
            End If
            'mode = true
            If mode = True Then
                daStr &= ", [機率(數量)], [機率(實際)]"
                DataGridView1.Columns(5).Visible = True
                DataGridView1.Columns(6).Visible = True
            End If
            '從該資料表
            daStr &= " FROM dbo.怪物掉落表"
            '選取條件
            daStr &= " WHERE 怪物名稱 LIKE N'%" & TextBox1.Text & "%'"
            daStr &= " AND 掉落物名稱 LIKE N'%" & TextBox2.Text & "%'"
            '排序方式
            If ComboBox1.Text = "預設" Then
                daStr &= " ORDER BY " & "編號"
            Else
                daStr &= " ORDER BY " & ComboBox1.Text
            End If
            If R1.Checked Then
                daStr &= " ASC"
            Else
                daStr &= " DESC"
            End If
            Dim da As New SqlDataAdapter(daStr, cn)
            Dim ds As New DataSet()
            da.Fill(ds, "怪物掉落表")
            dv = ds.Tables("怪物掉落表").DefaultView
        End Using
        DataGridView1.DataSource = dv
        If TextBox1.Text = "天大地大台科大" Then
            mode = True
            MessageBox.Show("啟用隱藏模式")
        End If
        ProgressBar1.Value = 100
    End Sub

    Sub RBar()
        ProgressBar1.Value = 0
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.Button = MouseButtons.Left Then '左鍵
            Dim countcell As Integer = DataGridView1.GetCellCount(DataGridViewElementStates.Selected)
            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                If countcell = 1 Then
                    Dim sb As New System.Text.StringBuilder()
                    'For i = 0 To countcell - 1 '迴圈取得所有儲存格
                    'sb.Append(DataGridView1.SelectedCells(0).Value.ToString())
                    'Next
                    Dim cv As String = DataGridView1.SelectedCells(0).Value.ToString()
                    Dim ci As Short = DataGridView1.SelectedCells(0).ColumnIndex
                    If ci = 1 Or ci = 2 Then
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        If ci = 1 Then
                            TextBox1.Text = cv
                        ElseIf ci = 2 Then
                            TextBox2.Text = cv
                        End If
                        Call LF_Click(vbNull, e)
                    End If
                    'MessageBox.Show(sb.ToString(), "新功能測試中 請不要驚慌")
                End If
            End If
        End If
    End Sub

    Private Sub 詳細資訊ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 詳細資訊ToolStripMenuItem.Click
        If DataGridView1.SelectedCells(0).ColumnIndex = 1 Then
            Select Case DataGridView1.Rows(DataGridView1.CurrentCellAddress.Y).Cells(DataGridView1.CurrentCellAddress.X + 2).Value.ToString.Length
                Case 1
                    MessageBox.Show("全部怪物無個別詳細資料", "MonsterDrop", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 6
                    Form2.target = "0" & DataGridView1.Rows(DataGridView1.CurrentCellAddress.Y).Cells(DataGridView1.CurrentCellAddress.X + 2).Value.ToString
                    Form2.tname = DataGridView1.CurrentCell.Value
                    If Form2.Created Then
                        Call Form2.Privous()
                    End If
                    Form2.Show()
                Case 7
                    Form2.target = DataGridView1.Rows(DataGridView1.CurrentCellAddress.Y).Cells(DataGridView1.CurrentCellAddress.X + 2).Value.ToString
                    Form2.tname = DataGridView1.CurrentCell.Value
                    If Form2.Created Then
                        Call Form2.Privous()
                    End If
                    Form2.Show()
            End Select
        End If
    End Sub

    Private Sub DataGridView1_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles DataGridView1.CellContextMenuStripNeeded
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
        If DataGridView1.SelectedCells.Count = 1 And (e.ColumnIndex = 1 Or e.ColumnIndex = 2) Then
            DataGridView1.Columns(1).ContextMenuStrip = CMS1
            DataGridView1.Columns(2).ContextMenuStrip = CMS1
        Else
            DataGridView1.Columns(1).ContextMenuStrip = Nothing
            DataGridView1.Columns(2).ContextMenuStrip = Nothing
        End If
    End Sub

End Class
