Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As String
        keluar = MsgBox("Apakah Anda yakin ingin Keluar", MsgBoxStyle.YesNo)
        If keluar = vbYes Then
            Close()
        End If
    End Sub
End Class
