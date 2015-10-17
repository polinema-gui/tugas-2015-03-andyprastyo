Public Class Form2

    Private Sub Okbt_Click(sender As Object, e As EventArgs) Handles Okbt.Click
        Dim hasil As String = ""
        Dim batas1 As Integer = Convert.ToInt32(baristxbx.Text)
        Dim batas2 As Integer = Convert.ToInt32(baristxbx.Text)
        Select Case Polapbbt.Text
            Case "Piramid"
                For baris As Integer = 1 To Convert.ToInt32(baristxbx.Text)
                    For kolom As Integer = 1 To Convert.ToInt32(baristxbx.Text) * 2 - 1
                        If (kolom >= batas1 And kolom <= batas2) Then
                            hasil &= "*"
                        Else
                            hasil &= "  "
                        End If
                    Next
                    batas1 = batas1 - 1
                    batas2 = batas2 + 1
                    hasil &= vbCrLf
                Next
            Case "Hollow Piramid"
                For baris As Integer = 1 To Convert.ToInt32(baristxbx.Text) - 1
                    For kolom As Integer = 1 To Convert.ToInt32(baristxbx.Text) * 2 - 1
                        If (kolom = batas1 Or kolom = batas2) Then
                            hasil &= "*"
                        Else
                            hasil &= "  "
                        End If
                    Next
                    batas1 = batas1 - 1
                    batas2 = batas2 + 1
                    hasil &= vbCrLf
                Next
                For tutup As Integer = 1 To Convert.ToInt32(baristxbx.Text) * 2 - 1
                    hasil &= "*"
                Next
            Case "Inverted Piramid"
                batas1 = 1
                batas2 = Convert.ToInt32(baristxbx.Text) * 2 - 1
                For baris As Integer = 1 To Convert.ToInt32(baristxbx.Text)
                    For kolom As Integer = Convert.ToInt32(baristxbx.Text) * 2 - 1 To 1 Step -1
                        If (kolom >= batas1 And kolom <= batas2) Then
                            hasil &= "*"
                        Else
                            hasil &= "  "
                        End If
                    Next
                    batas1 = batas1 + 1
                    batas2 = batas2 - 1
                    hasil &= vbCrLf
                Next
            Case "Hollow Inverted Piramid"
                For tutup As Integer = 1 To Convert.ToInt32(baristxbx.Text) * 2 - 1
                    hasil &= "*"
                Next
                hasil &= vbCrLf
                batas1 = 1
                batas2 = (Convert.ToInt32(baristxbx.Text) - 1) * 2 - 1
                For baris As Integer = 1 To (Convert.ToInt32(baristxbx.Text) - 1)
                    hasil &= "  "
                    For kolom As Integer = (Convert.ToInt32(baristxbx.Text) - 1) * 2 - 1 To 1 Step -1
                        If (kolom = batas1 Or kolom = batas2) Then
                            hasil &= "*"
                        Else
                            hasil &= "  "
                        End If
                    Next
                    batas1 = batas1 + 1
                    batas2 = batas2 - 1
                    hasil &= vbCrLf
                Next
            Case Else
                Dim message As String
                message = MsgBox("Anda Belum Memilih Pola", MsgBoxStyle.Information)
        End Select
        hasiltxbx.Text = hasil
    End Sub
End Class