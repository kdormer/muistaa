Imports System.Net.Mail
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Session
    'Static variables are used so the value is the same across the program rather than having different instances of the session class
    Public Shared username As String
    Public Shared passwordHash As String
    Public Shared email As String
    Public Shared userID As String
    Public Shared firstName As String
    Public Shared lastName As String
    Public Shared isLoggedIn As Boolean
    Public Shared DeckCount As Integer

    Public Enum Boxes
        'Enum of constants for card boxes
        BOX_ONE = 1
        BOX_TWO = 2
        BOX_THREE = 3
        BOX_FOUR = 4
        BOX_FIVE = 5
        BOX_SIX = 6
        BOX_SEVEN = 7
    End Enum

    Public Enum TimeMeasurements
        'Enum of time measurements - means enum need only be changed to change the whole behaviour of the program
        MINUTE = 1
        HOUR = 60 * MINUTE
        DAY = 24 * HOUR
        WEEK = 7 * DAY
        MONTH = 30 * WEEK
    End Enum

    '|STATIC FUNCTIONS TO ALLOW USAGE ACROSS PROGRAM WITHOUT HAVING TO INSTANTIATE THE SESSION CLASS|

    Public Shared Function ReturnCurrentDate()
        'Returns current date as a ready formatted string
        Dim currentDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Return currentDate
    End Function

    Public Shared Function ReturnCalculatedDateTime(ByVal minutes As Double)
        'Returns current date with a given amount of minutes added to it
        Dim dTime As String = DateTime.Now.AddMinutes(minutes).ToString("dd/MM/yyyy HH:mm:ss")
        Return dTime
    End Function

    Public Shared Function dateReached(ByVal d As String)
        'Compares two dates and checks whether the date has been reached yet
        Dim date1 As Date = DateTime.ParseExact(d, "dd/MM/yyyy HH:mm:ss", Nothing)

        If date1 <= DateTime.Now Then
            Return True 'Date reached
        Else
            Return False 'Date not reached
        End If
    End Function

    Public Shared Function isEmail(ByVal email As String)
        'Checks inputted email format against common email regular expression
        Static eRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return eRegex.IsMatch(email)
    End Function

    Private Function RandomInt(ByVal incMin As Integer, ByVal excMax As Integer)
        'Generates and returns random integer
        Static generator As System.Random = New System.Random()
        Return generator.Next(incMin, excMax)
    End Function

    Public Shared Function HashInput(ByVal key As String)
        'Custom procedure to hash a string input and return a string output
        Dim hash As UInt32 = &H55555555
        Dim length As Integer = key.Length() 'Length of inputted string
        Dim keyBytes() As Byte = Encoding.UTF8.GetBytes(key) 'Gets individual bytes of key string and stores them in array

        Dim rol = Function(ByVal h As UInt32, ByVal bitsToShift As UInt32) 'Lambda function to rotate bits left - implemntation of C 'rol'
                      h = (h << bitsToShift) Or (h >> (32 - bitsToShift))
                      Return h
                  End Function

        While length
            hash = hash Xor keyBytes(length - 1) ' Xor current hash code with current byte
            length -= 1
            hash = rol(hash, 5) 'Rotate bytes left by 5 bits
        End While

        Return hash
    End Function

    Public Shared Sub EmailString(ByVal recipient As String, ByVal subject As String, ByVal message As String)
        'Emails string to inputted email
        Dim smtpServer As New SmtpClient
        Dim email As New MailMessage()
        smtpServer.UseDefaultCredentials = False
        smtpServer.Credentials = New Net.NetworkCredential("EMAIL", "PASSWORD")
        smtpServer.Port = 587
        smtpServer.EnableSsl = True
        smtpServer.Host = "smtp.gmail.com"

        email = New MailMessage()
        email.From = New MailAddress("EMAIL")
        email.To.Add(recipient)
        email.Subject = subject
        email.IsBodyHtml = False
        email.Body = message

        smtpServer.Send(email)
    End Sub

    Public Shared Function calculateNextCardRevision(ByVal card As Deck.CardData, ByVal recalledCorrectly As Boolean) As String
        'Calculates and returns date of next revision for a flashcard based on its box
        If recalledCorrectly = True Then
            Select Case card.box
                Case Boxes.BOX_ONE
                    Return Session.ReturnCalculatedDateTime(0)
                Case Boxes.BOX_TWO
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.MINUTE * 10)
                Case Boxes.BOX_THREE
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.HOUR)
                Case Boxes.BOX_FOUR
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.DAY * 1)
                Case Boxes.BOX_FIVE
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.DAY * 2)
                Case Boxes.BOX_SIX
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.DAY * 4)
                Case Boxes.BOX_SEVEN
                    Return Session.ReturnCalculatedDateTime(TimeMeasurements.DAY * 8) 'Final box and longest interval
            End Select
        End If

        Return Session.ReturnCalculatedDateTime(TimeMeasurements.MINUTE * 10)
    End Function

    Public Shared Function calculateNewBox(ByVal card As Deck.CardData, ByVal recalledCorrectly As Boolean)
        'Calculates and returns new box for a flashcard based on how the user recalled it 
        If recalledCorrectly = True And card.box < 7 Then
            Return card.box + 1 'If answer is correctly recalled, put card in next box
        Else
            Return 1 'If answer is not recalled, put card back in first box
        End If
    End Function
End Class