Imports System.IO
Imports System.Xml
Public Class Form2
    Public target As String
    Public tname As String
    Public xmlpath As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Privous()
    End Sub
    Public Sub Privous()
        xmlpath = "Mob\" & target & ".img.xml"
        If My.Computer.FileSystem.FileExists(xmlpath) Then
            Call LoadXML(xmlpath)
        Else
            MessageBox.Show("怪物資料不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Private Sub LoadXML(path As String)
        Try
            Dim xDoc As XmlDocument = New XmlDocument
            xDoc.Load(path)
            Dim xRoot As XmlNode
            Dim xNode As XmlNode
            Dim xIntNodeList As XmlNodeList
            Dim xIntNode As XmlNode
            Dim xElem As XmlElement

            xRoot = CType(xDoc.DocumentElement, XmlNode)
            '選擇imgdir
            xNode = xRoot.SelectSingleNode("imgdir[@name='info']")
            '取得[int]name有值的節點
            xIntNodeList = xNode.SelectNodes("int[@name!='']")
            Label1.Text = ""
            Label1.Text &= "怪物名稱：" & tname & vbNewLine
            Label1.Text &= "怪物代碼：" & target & vbNewLine
            For i = 0 To xIntNodeList.Count - 1
                xIntNode = xIntNodeList.Item(i)
                xElem = CType(xIntNode, XmlElement)
                If Form1.mode = True Then
                    Label1.Text &= 轉中(xElem.GetAttribute("name")) & "(" & xElem.GetAttribute("name") & ")：" & xElem.GetAttribute("value") & vbNewLine
                Else
                    If Not 轉中(xElem.GetAttribute("name")) = "" Then
                        Label1.Text &= 轉中(xElem.GetAttribute("name")) & "：" & xElem.GetAttribute("value") & vbNewLine
                    End If
                End If
            Next
            ' MsgBox(Label1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message & System.Environment.NewLine & ex.StackTrace)
        End Try
    End Sub
    Private Function 轉中(name As String)
        Select Case name
            Case "bodyAttack"
                name = "身體碰撞(True:1/False:0)"
            Case "level"
                name = "等級"
            Case "maxHP"
                name = "血量"
            Case "maxMP"
                name = "魔力"
            Case "speed"
                name = "移動速度"
            Case "PDDamage"
                name = "物理防禦"
            Case "MADamage"
                name = "魔法傷害"
            Case "MDDamage"
                name = "魔法防禦"
            Case "acc"
                name = "命中值"
            Case "eva"
                name = "迴避值"
            Case "exp"
                name = "經驗值"
            Case "undead"
                name = "受到群體治癒攻擊(True:1/False:0)"
            Case "pushed"
                name = "阻嚇"
            Case "summonType"
                name = "召喚類型"
            Case "PADamage"
                name = "物理傷害"
            Case "hpRecovery"
                name = "生命恢復"
            Case "mpRecovery"
                name = "魔力恢復"
            Case "hpTagColor"
                name = "血條顏色"
            Case "boss"
                name = "頭目"
            Case "firstAttack"
                name = "出場攻擊"
            Case "hpRecovery"
                name = "生命恢復"
            Case "noFlip"
                name = "不轉向"
            Case "noRegen"
                name = "不再生"
            Case "publicReward"
                name = "公共獎勵"
            Case "explosiveReward"
                name = "噴發獎勵"
            Case "mobType"
                name = "怪物類型"
            Case "fixedDamage"
                name = "固定傷害"
            Case "hpTagBgcolor"
                name = "血條背景顏色"
            Case "ignoreFieldOut"
                name = "忽視掉出領域"
            Case Else '把Else 去掉會直接Return原值
                name = "" '過濾用
        End Select
        Return name
    End Function
End Class