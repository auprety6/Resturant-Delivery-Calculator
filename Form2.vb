Public Class frmAUDistanceData
    'Au I used this array of textboxes to load design and input data 
    Dim locationData(,) As TextBox

    ' AU The main goal here is to load all textboxes and data 
    Public Sub frmAUDistanceData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Au  Counts rows colums, and adds style to specific elements
        Dim rowCount As Integer = frmAUUserInterface.ResturantList.Count
        Dim colCount As Integer = frmAUUserInterface.ZipCode.Count
        Dim T As New TableLayoutPanel
        Controls.Add(T)
        T.RowCount = rowCount + 1
        T.ColumnCount = colCount + 1
        T.Location = New Point(50, 50)
        T.CellBorderStyle = vbSingle
        'AU styles columns
        Dim colOne As New ColumnStyle(SizeType.Absolute, 100)
        T.ColumnStyles.Add(colOne)
        For i = 0 To colCount
            T.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50))
        Next
        ' AU Adds Label style and also adds resturant items to the form
        For a = 0 To rowCount - 1
            Dim resturant = frmAUUserInterface.ResturantList.Item(a)
            Dim resturantLabel As New Label With {
                .Text = resturant(0),
                .ForeColor = Color.Chocolate
            }
            T.Controls.Add(resturantLabel, 0, a + 1)
        Next
        '  AU Loads zip code
        For a = 0 To colCount - 1
            Dim zip As New Label With {
                .Text = frmAUUserInterface.ZipCode(a),
                .ForeColor = Color.DarkGray,
                .Font = New Font(DefaultFont, FontStyle.Italic)
            }
            T.Controls.Add(zip, a + 1, 0)
        Next

        ' AU Adds textboxes to form
        Dim textData(rowCount - 1, colCount - 1) As TextBox
        For a = 0 To rowCount - 1
            For b = 0 To colCount - 1
                Dim Textbox As New TextBox
                Textbox.ForeColor = Color.Black
                textData(a, b) = Textbox
            Next
        Next

        For a = 1 To rowCount
            For b = 1 To colCount
                T.Controls.Add(textData(a - 1, b - 1), b, a)
            Next
        Next
        T.AutoSize = True
        locationData = textData
        T.BackColor = Color.AntiqueWhite


    End Sub
    'AU Catches exceptions and updates distances the user inputs, and changes calculation data 
    Private Sub AUUpdateDistance_Click(sender As Object, e As EventArgs) Handles AUUpdateDistance.Click
        ' AU Try and catch the exeption errors. 
        Try
            ' Updata data and calculations from interface
            For a = 0 To locationData.GetLength(0) - 1
                For b = 0 To locationData.GetLength(1) - 1
                    If locationData(a, b).Modified Then
                        frmAUUserInterface.Distance(a, b) = Convert.ToInt16(locationData(a, b).Text)
                    End If
                Next
            Next
        Catch formatE As FormatException
            Dim message As String = "An entry is not formatted correctly" & vbNewLine
            message = message & formatE.Message
            ExceptionCase(message)
        Catch arithmeticError As ArithmeticException
            Dim message As String = "An entry is not mathematically valid" & vbNewLine
            message = message & arithmeticError.Message
            ExceptionCase(message)
        Catch generalError As Exception
            Dim message As String = "There is an error in the input of the data" & vbNewLine
            message = message & generalError.Message
            ExceptionCase(message)


        End Try





        Close()
    End Sub
    'AU finds exception errors 
    Private Sub ExceptionCase(message As String)
        Dim button As DialogResult
        button = MessageBox.Show(message, "Data Entry Error,", MessageBoxButtons.AbortRetryIgnore,
MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If button = DialogResult.Abort Then
            Close()
        ElseIf DialogResult.Retry Then
            Exit Sub
        Else MessageBox.Show("This application may not work")
        End If
    End Sub
End Class