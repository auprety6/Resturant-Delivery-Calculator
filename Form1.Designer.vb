<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAUUserInterface
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AUResturantBox = New System.Windows.Forms.ComboBox()
        Me.AUComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AUZIPCODE = New System.Windows.Forms.TextBox()
        Me.AUCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AUCHARGE = New System.Windows.Forms.TextBox()
        Me.AUACCEPT = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AUUPDATEDIS = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chose the cuisine that you prefer "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chose the Resturant that you prefer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter your zip code"
        '
        'AUResturantBox
        '
        Me.AUResturantBox.BackColor = System.Drawing.SystemColors.Info
        Me.AUResturantBox.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUResturantBox.FormattingEnabled = True
        Me.AUResturantBox.Location = New System.Drawing.Point(352, 95)
        Me.AUResturantBox.Name = "AUResturantBox"
        Me.AUResturantBox.Size = New System.Drawing.Size(121, 28)
        Me.AUResturantBox.TabIndex = 3
        '
        'AUComboBox1
        '
        Me.AUComboBox1.BackColor = System.Drawing.SystemColors.Info
        Me.AUComboBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUComboBox1.FormattingEnabled = True
        Me.AUComboBox1.Location = New System.Drawing.Point(352, 3)
        Me.AUComboBox1.Name = "AUComboBox1"
        Me.AUComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.AUComboBox1.TabIndex = 4
        '
        'AUZIPCODE
        '
        Me.AUZIPCODE.Font = New System.Drawing.Font("mobileflat-font", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUZIPCODE.Location = New System.Drawing.Point(352, 175)
        Me.AUZIPCODE.Name = "AUZIPCODE"
        Me.AUZIPCODE.Size = New System.Drawing.Size(100, 25)
        Me.AUZIPCODE.TabIndex = 5
        '
        'AUCalculate
        '
        Me.AUCalculate.BackColor = System.Drawing.SystemColors.Info
        Me.AUCalculate.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUCalculate.Location = New System.Drawing.Point(352, 248)
        Me.AUCalculate.Name = "AUCalculate"
        Me.AUCalculate.Size = New System.Drawing.Size(167, 37)
        Me.AUCalculate.TabIndex = 6
        Me.AUCalculate.Text = "Calculate Delivery"
        Me.AUCalculate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Info
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Your delivery charge is"
        '
        'AUCHARGE
        '
        Me.AUCHARGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUCHARGE.Location = New System.Drawing.Point(352, 299)
        Me.AUCHARGE.Name = "AUCHARGE"
        Me.AUCHARGE.Size = New System.Drawing.Size(148, 24)
        Me.AUCHARGE.TabIndex = 8
        '
        'AUACCEPT
        '
        Me.AUACCEPT.BackColor = System.Drawing.SystemColors.Info
        Me.AUACCEPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUACCEPT.Location = New System.Drawing.Point(352, 365)
        Me.AUACCEPT.Name = "AUACCEPT"
        Me.AUACCEPT.Size = New System.Drawing.Size(75, 24)
        Me.AUACCEPT.TabIndex = 9
        Me.AUACCEPT.Text = "Accept"
        Me.AUACCEPT.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "For the dinner - Update Distance"
        '
        'AUUPDATEDIS
        '
        Me.AUUPDATEDIS.BackColor = System.Drawing.SystemColors.Info
        Me.AUUPDATEDIS.Location = New System.Drawing.Point(352, 395)
        Me.AUUPDATEDIS.Name = "AUUPDATEDIS"
        Me.AUUPDATEDIS.Size = New System.Drawing.Size(121, 26)
        Me.AUUPDATEDIS.TabIndex = 11
        Me.AUUPDATEDIS.Text = "Update distance"
        Me.AUUPDATEDIS.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AUACCEPT, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AUCalculate, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AUZIPCODE, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AUComboBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AUResturantBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AUUPDATEDIS, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.AUCHARGE, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.74449!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.25551!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 426)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'frmAUUserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmAUUserInterface"
        Me.Text = "FoodFinder"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AUResturantBox As ComboBox
    Friend WithEvents AUComboBox1 As ComboBox
    Friend WithEvents AUZIPCODE As TextBox
    Friend WithEvents AUCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents AUCHARGE As TextBox
    Friend WithEvents AUACCEPT As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AUUPDATEDIS As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
