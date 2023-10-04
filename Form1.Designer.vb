<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnOK = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnOK
        ' 
        btnOK.BackColor = SystemColors.Info
        btnOK.Location = New Point(289, 240)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(112, 34)
        btnOK.TabIndex = 0
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Viner Hand ITC", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(12, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(748, 104)
        Button1.TabIndex = 1
        Button1.Text = "Our first time doing strings"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnOK)
        Name = "Form1"
        Text = "Intro to strings"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents Button1 As Button
End Class
