<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.matrikslb = New System.Windows.Forms.Label()
        Me.operasilb = New System.Windows.Forms.Label()
        Me.matriks2lb = New System.Windows.Forms.Label()
        Me.hasillb = New System.Windows.Forms.Label()
        Me.matrix1tx = New System.Windows.Forms.TextBox()
        Me.matrix2tx = New System.Windows.Forms.TextBox()
        Me.operasicmbx = New System.Windows.Forms.ComboBox()
        Me.hasiltxbx = New System.Windows.Forms.TextBox()
        Me.hitungbt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'matrikslb
        '
        Me.matrikslb.AutoSize = True
        Me.matrikslb.Location = New System.Drawing.Point(13, 13)
        Me.matrikslb.Name = "matrikslb"
        Me.matrikslb.Size = New System.Drawing.Size(41, 13)
        Me.matrikslb.TabIndex = 0
        Me.matrikslb.Text = "Matriks"
        '
        'operasilb
        '
        Me.operasilb.AutoSize = True
        Me.operasilb.Location = New System.Drawing.Point(13, 108)
        Me.operasilb.Name = "operasilb"
        Me.operasilb.Size = New System.Drawing.Size(43, 13)
        Me.operasilb.TabIndex = 1
        Me.operasilb.Text = "Operasi"
        '
        'matriks2lb
        '
        Me.matriks2lb.AutoSize = True
        Me.matriks2lb.Location = New System.Drawing.Point(13, 136)
        Me.matriks2lb.Name = "matriks2lb"
        Me.matriks2lb.Size = New System.Drawing.Size(50, 13)
        Me.matriks2lb.TabIndex = 2
        Me.matriks2lb.Text = "Matriks 2"
        '
        'hasillb
        '
        Me.hasillb.AutoSize = True
        Me.hasillb.Location = New System.Drawing.Point(13, 239)
        Me.hasillb.Name = "hasillb"
        Me.hasillb.Size = New System.Drawing.Size(30, 13)
        Me.hasillb.TabIndex = 3
        Me.hasillb.Text = "Hasil"
        '
        'matrix1tx
        '
        Me.matrix1tx.Location = New System.Drawing.Point(71, 13)
        Me.matrix1tx.Multiline = True
        Me.matrix1tx.Name = "matrix1tx"
        Me.matrix1tx.Size = New System.Drawing.Size(358, 80)
        Me.matrix1tx.TabIndex = 4
        '
        'matrix2tx
        '
        Me.matrix2tx.Location = New System.Drawing.Point(71, 136)
        Me.matrix2tx.Multiline = True
        Me.matrix2tx.Name = "matrix2tx"
        Me.matrix2tx.Size = New System.Drawing.Size(358, 80)
        Me.matrix2tx.TabIndex = 5
        '
        'operasicmbx
        '
        Me.operasicmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.operasicmbx.FormattingEnabled = True
        Me.operasicmbx.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.operasicmbx.Location = New System.Drawing.Point(71, 108)
        Me.operasicmbx.Name = "operasicmbx"
        Me.operasicmbx.Size = New System.Drawing.Size(358, 21)
        Me.operasicmbx.TabIndex = 6
        '
        'hasiltxbx
        '
        Me.hasiltxbx.Location = New System.Drawing.Point(71, 239)
        Me.hasiltxbx.Multiline = True
        Me.hasiltxbx.Name = "hasiltxbx"
        Me.hasiltxbx.ReadOnly = True
        Me.hasiltxbx.Size = New System.Drawing.Size(358, 80)
        Me.hasiltxbx.TabIndex = 7
        '
        'hitungbt
        '
        Me.hitungbt.Location = New System.Drawing.Point(335, 340)
        Me.hitungbt.Name = "hitungbt"
        Me.hitungbt.Size = New System.Drawing.Size(75, 23)
        Me.hitungbt.TabIndex = 8
        Me.hitungbt.Text = "Hitung"
        Me.hitungbt.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 422)
        Me.Controls.Add(Me.hitungbt)
        Me.Controls.Add(Me.hasiltxbx)
        Me.Controls.Add(Me.operasicmbx)
        Me.Controls.Add(Me.matrix2tx)
        Me.Controls.Add(Me.matrix1tx)
        Me.Controls.Add(Me.hasillb)
        Me.Controls.Add(Me.matriks2lb)
        Me.Controls.Add(Me.operasilb)
        Me.Controls.Add(Me.matrikslb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents matrikslb As System.Windows.Forms.Label
    Friend WithEvents operasilb As System.Windows.Forms.Label
    Friend WithEvents matriks2lb As System.Windows.Forms.Label
    Friend WithEvents hasillb As System.Windows.Forms.Label
    Friend WithEvents matrix1tx As System.Windows.Forms.TextBox
    Friend WithEvents matrix2tx As System.Windows.Forms.TextBox
    Friend WithEvents operasicmbx As System.Windows.Forms.ComboBox
    Friend WithEvents hasiltxbx As System.Windows.Forms.TextBox
    Friend WithEvents hitungbt As System.Windows.Forms.Button
End Class
