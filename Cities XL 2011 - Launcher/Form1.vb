Public Class Form1
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        filedialog1.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RadMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub StartupSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartupSetupToolStripMenuItem.Click
        startup.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub HepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HepToolStripMenuItem.Click
        helpDialog.ShowDialog()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Process.Start("http://www2.citiesxl.com/en/fansites")
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Process.Start("http://www2.citiesxl.com/")
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Process.Start("http://forum.citiesxl.com/")
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        helpDialog.ShowDialog()
    End Sub

    Private Sub HideMainbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideMainbarToolStripMenuItem.Click
        'Toggle the visibility of the toolstrip and also the checked state of the associated menu item
        HideMainbarToolStripMenuItem.Checked = Not HideMainbarToolStripMenuItem.Checked
        MenuStrip1.Visible = HideMainbarToolStripMenuItem.Checked
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub HideStatebarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideStatebarToolStripMenuItem.Click
        'Toggle the visibility of the toolstrip and also the checked state of the associated menu item
        HideStatebarToolStripMenuItem.Checked = Not HideStatebarToolStripMenuItem.Checked
        StatusStrip1.Visible = HideStatebarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
