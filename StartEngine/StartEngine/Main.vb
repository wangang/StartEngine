Imports System.IO.Ports
Public Class Main
    Dim configData As List(Of Byte) = New List(Of Byte)
    Dim TimeScale As Integer = 1000
    Dim Message(0) As Byte
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                SerialInit()
                ComPort.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MessageProcess(ByVal message As String)

        If message = "configdata" Then
            'For i As Integer = 0 To 3
            '    configData.Add(&HAA)
            'Next
            For Each row As DataGridViewRow In ConfigDataGrid.Rows
          
                If row.Cells(1).Value = "" Then

                Else
                    configData.Add(CInt(row.Cells(1).Value))  'channel no.
                    configData.Add(CDbl(row.Cells(2).Value * TimeScale) And &HFF) 'start time
                    configData.Add((CDbl(row.Cells(2).Value * TimeScale) And &HFF00) >> 8)
                    configData.Add(&H80 + ((CDbl(row.Cells(2).Value * TimeScale) And &HFF0000) >> 16))
                    configData.Add(CInt(row.Cells(1).Value))  'channel no.
                    configData.Add(CDbl(row.Cells(2).Value * TimeScale + row.Cells(3).Value * TimeScale) And &HFF) 'start time
                    configData.Add((CDbl(row.Cells(2).Value * TimeScale + row.Cells(3).Value * TimeScale) And &HFF00) >> 8)
                    configData.Add((CDbl(row.Cells(2).Value * TimeScale + row.Cells(3).Value * TimeScale) And &H7F0000) >> 16)

                End If

            Next
        ElseIf message = "start" Then
            For i As Integer = 0 To 3
                configData.Add(&HFF)
            Next
        ElseIf message = "pause" Then
            For i As Integer = 0 To 3
                configData.Add(&HEE)
            Next
        ElseIf message = "renew" Then
            For i As Integer = 0 To 3
                configData.Add(&HFF)
            Next
        ElseIf message = "stop" Then

            For i As Integer = 0 To 3
                configData.Add(&HDD)
            Next


        End If


    End Sub
    Private Sub SerialInit()
        ComPort.BaudRate = "38400"
        ComPort.PortName = "COM3"
        ComPort.DataBits = 8
        ComPort.StopBits = IO.Ports.StopBits.One
        ComPort.Parity = IO.Ports.Parity.None
    End Sub

    Private Sub sendMessage()
        If ComPort.IsOpen = True Then
            ProgressBar.Minimum = 0
            ProgressBar.Maximum = configData.Count - 1
            For i As Integer = 0 To configData.Count - 1
                Message(0) = configData(i)
                ComPort.Write(Message, 0, Message.Length)
                System.Threading.Thread.Sleep(10)
                ProgressBar.Value = i
            Next
        Else
            MessageBox.Show("请打开设备！")
        End If
    End Sub
    Private Sub downLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downLoad.Click
        MessageProcess("configdata")
        sendMessage()
        configData.Clear()
        engineStart.Text = "启动"
    End Sub

    Private Sub engineStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles engineStart.Click
        If engineStart.Text = "启动" Then
            MessageProcess("start")
            sendMessage()
            engineStart.Text = "暂停"
        ElseIf engineStart.Text = "暂停" Then
            MessageProcess("pause")
            sendMessage()
            engineStart.Text = "恢复"
        ElseIf engineStart.Text = "恢复" Then
            MessageProcess("renew")
            sendMessage()
            engineStart.Text = "暂停"
        End If
        configData.Clear()
    End Sub

    Private Sub engineStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles engineStop.Click
        MessageProcess("stop")
        sendMessage()
        configData.Clear()
        engineStart.Text = "启动"
    End Sub

End Class
