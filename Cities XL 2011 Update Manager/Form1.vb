Public Class Form1
    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadMenuItem3_Click(sender As Object, e As EventArgs) Handles RadMenuItem3.Click
        Process.Start("www.focus-files.com/patchs/CXL2011/Patch_1.5.0.723_1.5.0.725.exe")
    End Sub

    Private Sub RadMenuItem4_Click(sender As Object, e As EventArgs) Handles RadMenuItem4.Click
        Process.Start("www.focus-files.com/patchs/CXL2011/Patch_1.5.0.723_1.5.0.725.exe")
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Process.Start("http://forum.citiesxl.com/viewtopic.php?t=7748")
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
