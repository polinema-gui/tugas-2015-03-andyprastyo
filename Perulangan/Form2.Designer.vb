<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.polalb = New System.Windows.Forms.Label()
        Me.barislb = New System.Windows.Forms.Label()
        Me.baristxbx = New System.Windows.Forms.TextBox()
        Me.Okbt = New System.Windows.Forms.Button()
        Me.Polapbbt = New System.Windows.Forms.ComboBox()
        Me.hasiltxbx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'polalb
        '
        Me.polalb.AutoSize = True
        Me.polalb.Location = New System.Drawing.Point(25, 13)
        Me.polalb.Name = "polalb"
        Me.polalb.Size = New System.Drawing.Size(28, 13)
        Me.polalb.TabIndex = 0
        Me.polalb.Text = "Pola"
        '
        'barislb
        '
        Me.barislb.AutoSize = True
        Me.barislb.Location = New System.Drawing.Point(25, 42)
        Me.barislb.Name = "barislb"
        Me.barislb.Size = New System.Drawing.Size(30, 13)
        Me.barislb.TabIndex = 1
        Me.barislb.Text = "Baris"
        '
        'baristxbx
        '
        Me.baristxbx.Location = New System.Drawing.Point(83, 37)
        Me.baristxbx.Name = "baristxbx"
        Me.baristxbx.Size = New System.Drawing.Size(275, 20)
        Me.baristxbx.TabIndex = 2
        '
        'Okbt
        '
        Me.Okbt.Location = New System.Drawing.Point(365, 34)
        Me.Okbt.Name = "Okbt"
        Me.Okbt.Size = New System.Drawing.Size(75, 23)
        Me.Okbt.TabIndex = 3
        Me.Okbt.Text = "OK"
        Me.Okbt.UseVisualStyleBackColor = True
        '
        'Polapbbt
        '
        Me.Polapbbt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Polapbbt.FormattingEnabled = True
        Me.Polapbbt.Items.AddRange(New Object() {"Piramid", "Hollow Piramid", "Inverted Piramid", "Hollow Inverted Piramid"})
        Me.Polapbbt.Location = New System.Drawing.Point(83, 7)
        Me.Polapbbt.Name = "Polapbbt"
        Me.Polapbbt.Size = New System.Drawing.Size(357, 21)
        Me.Polapbbt.TabIndex = 4
        '
        'hasiltxbx
        '
        Me.hasiltxbx.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasiltxbx.Location = New System.Drawing.Point(28, 75)
        Me.hasiltxbx.Multiline = True
        Me.hasiltxbx.Name = "hasiltxbx"
        Me.hasiltxbx.ReadOnly = True
        Me.hasiltxbx.Size = New System.Drawing.Size(412, 242)
        Me.hasiltxbx.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 422)
        Me.Controls.Add(Me.hasiltxbx)
        Me.Controls.Add(Me.Polapbbt)
        Me.Controls.Add(Me.Okbt)
        Me.Controls.Add(Me.baristxbx)
        Me.Controls.Add(Me.barislb)
        Me.Controls.Add(Me.polalb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents polalb As System.Windows.Forms.Label
    Friend WithEvents barislb As System.Windows.Forms.Label
    Friend WithEvents baristxbx As System.Windows.Forms.TextBox
    Friend WithEvents Okbt As System.Windows.Forms.Button
    Friend WithEvents Polapbbt As System.Windows.Forms.ComboBox
    Friend WithEvents hasiltxbx As System.Windows.Forms.TextBox
End Class
