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
        Titlelabel = New Label()
        Sloganlabel = New Label()
        SuspendLayout()
        ' 
        ' Titlelabel
        ' 
        Titlelabel.AutoSize = True
        Titlelabel.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Titlelabel.Location = New Point(348, 9)
        Titlelabel.Name = "Titlelabel"
        Titlelabel.Size = New Size(566, 37)
        Titlelabel.TabIndex = 0
        Titlelabel.Text = "Puppies Babbies N Supplies One Stop Shop"
        ' 
        ' Sloganlabel
        ' 
        Sloganlabel.AutoSize = True
        Sloganlabel.Font = New Font("Segoe UI", 12F)
        Sloganlabel.Location = New Point(396, 55)
        Sloganlabel.Name = "Sloganlabel"
        Sloganlabel.Size = New Size(440, 21)
        Sloganlabel.TabIndex = 1
        Sloganlabel.Text = "Purchase Your Furby Baby and Supplies At The Same Time!😊"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cute_dog_sleeping_ai_generatedBackgroundImage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1163, 690)
        Controls.Add(Sloganlabel)
        Controls.Add(Titlelabel)
        Name = "Form1"
        Text = "Purchase Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Titlelabel As Label
    Friend WithEvents Sloganlabel As Label

End Class
