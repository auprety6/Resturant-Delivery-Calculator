'Au This class lets the user select a resturant and caulcates the original delivery price 
Public Class frmAUUserInterface

    ' AU These lists can be publicly accessed throughout this class, while zipcode and Resturant can be accessed in another .net studio vb platform as well

    Dim CuisineList As New List(Of String) From {{"American"}, {"Italian"}, {"Asian"}, {"Mexican"}}
    Dim ShortList As New List(Of Integer)
    Public ZipCode As New List(Of Short) From {{24060}, {24061}, {24062}, {24063}}
    Public ResturantList As New ArrayList


    ' AU I delcared this array to better help me with my calculations so I could visualize single elements rather than just a list 

    Public Resturants(,) As String = {{"PK's", "American"}, {"Moe's Grill", "American"}, {"Hokie House", "American"}, {"O'Charley's", "American"},
    {"Avellino's", "Italian"}, {"Benny Marzano's", "Italian"}, {"Olive Garden", "Italian"},
    {"China Inn", "Asian"}, {"Hunan King", "Asian"}, {"Chinese Kitchen", "Asian"},
    {"El Rodeo", "Mexican"}, {"El Mariachi", "Mexican"}, {"Chipotle", "Mexican"}}

    ' AU Numeric Data should be seperate from basic software development so public declaration is proper rather then method consistent method iterations
    Public Distance(,) As Single = {{1, 2, 3, 4}, {1, 2, 3, 4}, {1, 2, 3, 4}, {2, 2, 4, 3}, {1, 4, 3, 2}, {2, 4, 3, 1}, {2, 2, 4, 3}, {1, 2, 3, 4}, {1, 1, 3, 3}, {1, 2, 3, 4}, {5, 4, 3, 2}, {2, 3, 3, 4}, {1, 2, 3, 4}}
    Const CostPerMile As Single = 5.4

    'Au this method loads the cusine into the cusine como box by accessing them from the Restuant List 
    Private Sub frmJAUUserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'AU The ResturantList adds all categorical data and cusine string data 
        ResturantList.Add({"PK's", "American"})
        ResturantList.Add({"Moe's Grill", "American"})
        ResturantList.Add({"Hokie House", "American"})
        ResturantList.Add({"O'Charley's", "American"})
        ResturantList.Add({"Avellino's", "Italian"})
        ResturantList.Add({"Benny Marzano's", "Italian"})
        ResturantList.Add({"Olive Garden", "Italian"})
        ResturantList.Add({"China Inn", "Asian"})
        ResturantList.Add({"Hunan King", "Asian"})
        ResturantList.Add({"Chinese Kitchen", "Asian"})
        ResturantList.Add({"El Rodeo", "Mexican"})
        ResturantList.Add({"El Mariachi", "Mexican"})
        ResturantList.Add({"Chipotle", "Mexican"})

        ' AU each cusine in the lsit is added into the cuisine combo box in Form 1 design and visual interfaces

        For Each cusine In CuisineList
            AUComboBox1.Items.Add(cusine)
        Next









    End Sub
    'AU Resturant list indexes are accessed by the ShortList, and data is cleared as well as reorganized in the resturant box
    Private Sub AUComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AUComboBox1.SelectedIndexChanged

        AUResturantBox.ResetText()
        AUResturantBox.Items.Clear()
        ShortList.Clear()
        AUCHARGE.Clear()
        ' AU resturant indexes from the list are added to the my ShortList
        For Each resturant In ResturantList
            If resturant(1).Equals(AUComboBox1.SelectedItem) Then
                AUResturantBox.Items.Add(resturant(0))
                ShortList.Add(ResturantList.IndexOf(resturant))
            End If
        Next




    End Sub
    ' AU This method catches basic errors in user input and also calculates milage according to distance data 
    Private Sub AUCalculate_Click(sender As Object, e As EventArgs) Handles AUCalculate.Click
        ' AU Try and catch all these indivudal exception errors
        Try

        Catch ex As FormatException
            Dim message As String = " Distace is not formatted correctly" & vbNewLine
            message = message & ex.Message
            ExceptionOccured(message)
        Catch aEroor As ArithmeticException
            Dim message As String = " There is an error in calculating the delivery cost" & vbNewLine
            message = message & aEroor.Message
            ExceptionOccured(message)
        Catch gError As Exception
            Dim message As String = " There is an error in input data" & vbNewLine
            message = message & gError.Message
            ExceptionOccured(message)


        End Try
        ' Throw an expetion is this case is found
        If AUResturantBox.SelectedItem Is Nothing Then
            Throw New Exception("Resturant is not selected")

        End If








        ' AU Iterates around resturant array data and uses cost per mile to calculate data, then imports it into design interface
        For x As Integer = 0 To 12
            If AUResturantBox.Text = Resturants(x, 0) Then

                If AUZIPCODE.Text = ZipCode(0) Then
                    AUCHARGE.Text = Distance(x, 0) * CostPerMile
                End If


                If AUZIPCODE.Text = ZipCode(1) Then
                    AUCHARGE.Text = Distance(x, 1) * CostPerMile
                End If


                If AUZIPCODE.Text = ZipCode(2) Then
                    AUCHARGE.Text = Distance(x, 2) * CostPerMile
                End If

                If AUZIPCODE.Text = ZipCode(3) Then
                    AUCHARGE.Text = Distance(x, 3) * CostPerMile
                End If


            End If

        Next

    End Sub
    'Au Once the user accepts all costs and data variations have been satisfied this button ends the design application
    Private Sub AUACCEPT_Click(sender As Object, e As EventArgs) Handles AUACCEPT.Click
        Me.Close()
    End Sub
    ' AU This loads the user form where they can input their milage data 
    Private Sub AUUPDATEDIS_Click(sender As Object, e As EventArgs) Handles AUUPDATEDIS.Click
        Dim newForm As New frmAUDistanceData
        newForm.Show()



    End Sub
    'AU  Finds dialog and message box errors
    Private Sub ExceptionOccured(message As String)
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
