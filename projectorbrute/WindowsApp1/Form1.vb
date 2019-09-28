Public Class Form1
    Dim bruteState As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sendserial("C00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SP.PortName = txtcom.Text
        SP.BaudRate = txtbaud.Text
        SP.Open()
    End Sub


    Function sendserial(TheText As String)
        SP.Write(TheText & vbCrLf)
        Return True
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sendserial("C01")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sendserial("C3C")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sendserial("C3D")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sendserial("C3B")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sendserial("C3A")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sendserial("C3F")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sendserial("C1C")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        bruteState = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case bruteState
            Case 0
                sendserial("C3F") 'ENTER
            Case 1
                sendserial("C3B") 'left
            Case 2
                If (txt4.Text = 9) Then
                    If (txt3.Text = 9) Then
                        If (txt2.Text = 9) Then
                            txt1.Text = txt1.Text + 1
                            txt2.Text = 0
                            txt3.Text = 0
                            txt4.Text = 0
                            sendserial("C3B") 'left
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3B") 'left
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3B") 'left
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3A") 'right
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3A") 'right
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3A") 'right
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                        Else
                            txt2.Text = txt2.Text + 1
                            txt3.Text = 0
                            txt4.Text = 0
                            sendserial("C3B") 'left
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3B") 'left
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3A") 'right
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3A") 'right
                            System.Threading.Thread.CurrentThread.Sleep(100)
                            sendserial("C3C") 'up
                        End If
                    Else
                        txt3.Text = txt3.Text + 1
                        txt4.Text = 0
                        sendserial("C3B") 'left
                        System.Threading.Thread.CurrentThread.Sleep(100)
                        sendserial("C3C") 'up
                        System.Threading.Thread.CurrentThread.Sleep(100)
                        sendserial("C3A") 'right
                        System.Threading.Thread.CurrentThread.Sleep(100)
                        sendserial("C3C") 'up
                    End If
                Else
                    sendserial("C3C") 'up
                    txt4.Text = txt4.Text + 1
                End If
            Case 3
                sendserial("C3A") 'right

        End Select
        If bruteState < 3 Then
            bruteState = bruteState + 1
        Else
            bruteState = 0
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) 
        sendserial("C3B") 'left
        System.Threading.Thread.CurrentThread.Sleep(100)
        sendserial("C3B") 'left
        System.Threading.Thread.CurrentThread.Sleep(100)
        sendserial("C3B") 'left
    End Sub
End Class
