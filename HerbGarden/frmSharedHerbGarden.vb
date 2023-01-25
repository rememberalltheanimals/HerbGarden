'Author: Eunhae Hwang

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmSharedHerbGarden

    Dim objSelectedHerb As clsHerb
    Dim lstHerbs As New BindingList(Of clsHerb)

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intCheck As Integer
        Dim decCheck As Decimal
       
        Dim objHerb As New clsHerb()

        'Validation of inputs
        If (Not String.IsNullOrEmpty(txtLatin.Text) And
            Not String.IsNullOrEmpty(txtMember.Text) And
            Not String.IsNullOrEmpty(cboYear.Text) And
            Integer.TryParse(txtNumber.Text, intCheck) And
            Not String.IsNullOrEmpty(txtFamily.Text) And
            Not String.IsNullOrEmpty(txtHabitat.Text) And
            Not String.IsNullOrEmpty(cboStatus.Text) And
            Not String.IsNullOrEmpty(txtParts.Text) And
            Not String.IsNullOrEmpty(cboUses.Text) And
            Decimal.TryParse(txtSpacing.Text, decCheck) And
            Not String.IsNullOrEmpty(txtStartDate.Text)) Then

        End If

        'Assign Herb information from the form
        objHerb.Latin = txtLatin.Text
        objHerb.Member = txtMember.Text
        objHerb.Year = cboYear.SelectedItem.ToString
        objHerb.Number = Integer.Parse(txtNumber.Text)
        objHerb.Family = txtFamily.Text
        objHerb.Habitat = txtHabitat.Text
        objHerb.Status = cboStatus.SelectedItem.ToString
        objHerb.Parts = txtParts.Text
        objHerb.Uses = cboUses.SelectedItem.ToString
        objHerb.Spacing = Decimal.Parse(txtSpacing.Text)
        objHerb.StartDate = txtStartDate.Text

        'Collect Herb input for the land space calculation inputs

        'Land Space Calculation
        Dim NumOfPlants As Integer
        Dim SpaceNeed As Decimal
        NumOfPlants = Integer.Parse(txtNumber.Text)
        SpaceNeed = Decimal.Parse(txtSpacing.Text)
        Dim LandSpace = NumOfPlants * SpaceNeed


        'Set objHerb to objSelectedHerb for bindingList
        objSelectedHerb = objHerb
        lstHerbs.Add(objHerb)
        lbxPlants.SelectedItem = objHerb



        InsertCommand(objSelectedHerb)

    End Sub




    Private Function OpenDBConnection() As SqlConnection

        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "Herbs.mdf"
        Dim dbConnection As New SqlConnection(strconnection)
        dbConnection.Open()

        Return dbConnection
    End Function

    Private Sub LoadDBHerbs()
        'Clear existing users to refresh list
        If lstHerbs.Count > 0 Then
            lstHerbs.Clear()
        End If

        Dim dbConnection = OpenDBConnection()
        Dim selectCommand As New SqlCommand("SELECT * FROM Herbs", dbConnection)
        Try
            Dim userReader As SqlDataReader = selectCommand.ExecuteReader
            If userReader.HasRows Then
                While userReader.Read
                    'Read and store each user from db
                    Dim objStoredHerb As New clsHerb()
                    objStoredHerb.Id = CInt(userReader.Item("Id"))
                    objStoredHerb.Latin = userReader.Item("Latin").ToString
                    objStoredHerb.Member = userReader.Item("Member").ToString
                    objStoredHerb.Year = userReader.Item("Year").ToString
                    objStoredHerb.Number = CInt(userReader.Item("Number").ToString)
                    objStoredHerb.Family = userReader.Item("Family").ToString
                    objStoredHerb.Habitat = userReader.Item("Habitat").ToString
                    objStoredHerb.Status = userReader.Item("Status").ToString
                    objStoredHerb.Parts = userReader.Item("Parts").ToString
                    objStoredHerb.Uses = userReader.Item("Uses").ToString
                    objStoredHerb.Spacing = Decimal.Parse(userReader.Item("Spacing").ToString)
                    objStoredHerb.StartDate = userReader.Item("StartDate").ToString

                    lstHerbs.Add(objStoredHerb)
                    lbxPlants.SelectedItem = objSelectedHerb
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub InsertCommand(herb As clsHerb)

        Dim dbConnection As SqlConnection = OpenDBConnection()

        Dim intEditHerbId = objSelectedHerb.Id

        Dim strSql As String
        Dim saveCommand As New SqlCommand()
        saveCommand.Connection = dbConnection

        'Select whether to insert new or update existing herb
        If intEditHerbId = Nothing Then
            strSql = "INSERT INTO Herbs (Latin, Member, Year, Number, Family, Habitat, Status, Parts, Uses, Spacing, StartDate) 
            VALUES (@Latin, @Member, @Year, @Number, @Family, @Habitat, @Status, @Parts, @Uses, @Spacing, @StartDate);"
        Else
            strSql = "UPDATE Herbs SET Latin = @Latin, Member = @Member, Number = @Number, Family = @Family, Habitat = @Habitat, Status = @Status, 
            Parts = @Parts, Uses = @Uses, Spacing = @Spacing, StartDate = @StartDate, WHERE Id = @Id"
            saveCommand.Parameters.AddWithValue("@Id", herb.Id)
        End If
        saveCommand.CommandText = strSql
        'Adding properties to sql parameters
        saveCommand.Parameters.AddWithValue("@Latin", herb.Latin)
        saveCommand.Parameters.AddWithValue("@Member", herb.Member)
        saveCommand.Parameters.AddWithValue("@Year", herb.Year)
        saveCommand.Parameters.AddWithValue("@Number", herb.Number)
        saveCommand.Parameters.AddWithValue("@Family", herb.Family)
        saveCommand.Parameters.AddWithValue("@Habitat", herb.HAbitat)
        saveCommand.Parameters.AddWithValue("@Status", herb.Status)
        saveCommand.Parameters.AddWithValue("@Parts", herb.Parts)
        saveCommand.Parameters.AddWithValue("@Uses", herb.Uses)
        saveCommand.Parameters.AddWithValue("@Spacing", herb.Spacing)
        saveCommand.Parameters.AddWithValue("@StartDate", herb.StartDate)
        

        Try
            Dim rowsAffected As Integer = saveCommand.ExecuteNonQuery()
            If rowsAffected = 1 Then
                MessageBox.Show(herb.Latin + " was saved.")
            Else
                MessageBox.Show(herb.Latin + " was NOT saved.")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Insert failed: " + ex.Message)
        End Try

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub



    Private Sub SharedHerbGarden_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadDBHerbs()

        'Add contents to combo boxes when the form loads
        cboYear.Items.Add("Annual")
        cboYear.Items.Add("Perrenial")
        cboYear.SelectedIndex = 1

        cboStatus.Items.Add("Native")
        cboStatus.Items.Add("Invasive")
        cboStatus.SelectedIndex = 1

        cboUses.Items.Add("Cullinary")
        cboUses.Items.Add("Medicinal")
        cboUses.SelectedIndex = 1

        lbxPlants.DataSource = lstHerbs
        lbxPlants.DisplayMember = "Latin"

    End Sub

    Private Sub lbxPlants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPlants.SelectedIndexChanged

        Dim objCurrentHerb As clsHerb = CType(lbxPlants.SelectedItem, clsHerb)

        If objCurrentHerb IsNot Nothing Then
            'Display selected herb information
            txtLatin.Text = objCurrentHerb.Latin
            txtMember.Text = objCurrentHerb.Member
            cboYear.Text = objCurrentHerb.Year
            txtNumber.Text = CStr(objCurrentHerb.Number)
            txtFamily.Text = objCurrentHerb.Family
            txtHabitat.Text = objCurrentHerb.Habitat
            cboStatus.Text = objCurrentHerb.Status
            txtParts.Text = objCurrentHerb.Parts
            cboUses.Text = objCurrentHerb.Uses
            txtSpacing.Text = CStr(objCurrentHerb.Spacing)
            txtStartDate.Text = objCurrentHerb.StartDate
        End If

    End Sub
End Class
