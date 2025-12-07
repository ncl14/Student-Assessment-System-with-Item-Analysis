Imports MySqlConnector
Imports System.Windows.Forms

Namespace Student_Assessment_System_with_Item_Analysis
    Public Module modProcedureVariable

        Public Function fncConnectToDatabase() As Boolean
            Try
                servername = "localhost"
                dbname = "studentassessment"
                username = "root"
                password = ""
                port = "3306"

                strConnection = $"SERVER={servername};DATABASE={dbname};UID={username};PWD={password};PORT={port};"

                conDbInformation = New MySqlConnection(strConnection)
                conDbInformation.Open()

                command = New MySqlCommand()
                command.Connection = conDbInformation
                command.CommandTimeout = 20 * 60

                Return True
            Catch ex As Exception
                MessageBox.Show("Database Connection Error: " & ex.Message)
                Return False
            End Try
        End Function

        Public Sub checkDatabaseConnection()
            If conDbInformation Is Nothing OrElse conDbInformation.State = ConnectionState.Closed Then
                fncConnectToDatabase()
            End If
        End Sub

    End Module
End Namespace
