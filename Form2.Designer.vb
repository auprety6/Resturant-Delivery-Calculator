<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAUDistanceData
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
        Me.AUUpdateDistance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AUUpdateDistance
        '
        Me.AUUpdateDistance.Location = New System.Drawing.Point(667, 33)
        Me.AUUpdateDistance.Name = "AUUpdateDistance"
        Me.AUUpdateDistance.Size = New System.Drawing.Size(192, 72)
        Me.AUUpdateDistance.TabIndex = 1
        Me.AUUpdateDistance.Text = "Update Distances "
        Me.AUUpdateDistance.UseVisualStyleBackColor = True
        '
        'frmAUDistanceData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 450)
        Me.Controls.Add(Me.AUUpdateDistance)
        Me.Name = "frmAUDistanceData"
        Me.Text = "Distance Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AUUpdateDistance As Button
End Class
