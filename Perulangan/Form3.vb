Public Class Form3

    

    Private Sub hitungbt_Click(sender As Object, e As EventArgs) Handles hitungbt.Click
        hasiltxbx.Text = ""
        Dim matrix1 As New List(Of String)
        Dim mat As New List(Of String)
        Dim temp As String()
        Dim tem As String() = matrix1tx.Text.Split(vbCrLf)
        For Each a In tem
            mat.Add(a)
        Next
        For s As Integer = 0 To mat.Count - 1
            temp = mat.Item(s).Split(" ")
            For Each t In temp
                matrix1.Add(t)
            Next
        Next
        Dim int1 As New List(Of Integer)
        For i As Integer = 0 To matrix1.Count - 1
            int1.Add(matrix1.Item(i))
        Next
        Dim matrix2 As New List(Of String)
        Dim mat2 As New List(Of String)
        Dim temp2 As String()
        Dim tem2 As String() = matrix2tx.Text.Split(vbCrLf)
        For Each f In tem2
            mat2.Add(f)
        Next
        For g As Integer = 0 To mat2.Count - 1
            temp2 = mat2.Item(g).Split(" ")
            For Each t2 In temp2
                matrix2.Add(t2)
            Next
        Next
        Dim int2 As New List(Of Integer)
        For ii As Integer = 0 To matrix1.Count - 1
            int2.Add(matrix2.Item(ii))
        Next
        Dim hasil As Integer
        Dim hasilakhir As New List(Of Integer)
        Select Case operasicmbx.Text
            Case "Tambah"
                For x As Integer = 0 To int1.Count - 1
                    hasil = int1.Item(x) + int2.Item(x)
                    hasilakhir.Add(hasil)
                Next
            Case "Kurang"
                For y As Integer = 0 To int1.Count - 1
                    hasil = int1.Item(y) - int2.Item(y)
                    hasilakhir.Add(hasil)
                Next
            Case Else
                Dim message As String
                message = MsgBox("Anda Belum Memilih Operasi", MsgBoxStyle.Information)
        End Select
        For h As Integer = 0 To hasilakhir.Count - 1
            hasiltxbx.Text &= hasilakhir.Item(h) & " "
            If (h = hasilakhir.Count / 2 - 1) Then
                hasiltxbx.Text &= vbCrLf
            End If
        Next
    End Sub
End Class