Public Class about
    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadButton2_Click_1(sender As Object, e As EventArgs) Handles RadButton2.Click
        helpDialog.ShowDialog()
    End Sub

    Private Sub RadButton1_Click_1(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub
End Class