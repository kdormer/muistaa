Imports System.IO
Imports System.Text

Public MustInherit Class Card 'Base abstract class for all card-types

    Protected _ID As String 'Unique card ID
    Protected _user As String 'User ID
    Protected _box As Integer ''Box' of flashcards to comply with the Leitner flashcard system
    Protected _nextRevision As String 'Date when card is eligible to be revised next
    Protected _totalRevisions As Integer 'Total revisions a card has had
    Protected _creationDate As String 'Creation date, to the second, that card was created
    Protected _deck As String 'ID of deck card belongs to
    Protected _front As String 'Front of flashcard
    Protected _back As String 'Back of flashcard

    '|Properties are used to prevent exposure of variables to global scope|

    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property

    Public Property user() As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property

    Public Property box() As Integer
        Get
            Return _box

        End Get
        Set(value As Integer)
            _box = value
        End Set
    End Property

    Public Property nextRevision() As String
        Get
            Return _nextRevision
        End Get
        Set(value As String)
            _nextRevision = value
        End Set
    End Property

    Public Property totalRevisions() As Integer
        Get
            Return _totalRevisions
        End Get
        Set(value As Integer)
            _totalRevisions = value
        End Set
    End Property

    Public Property creationDate() As String
        Get
            Return _creationDate
        End Get
        Set(value As String)
            _creationDate = value
        End Set
    End Property

    Public Property deck() As String
        Get
            Return _deck
        End Get
        Set(value As String)
            _deck = value
        End Set
    End Property

    Public Property front() As String
        Get
            Return _front
        End Get
        Set(value As String)
            _front = value
        End Set
    End Property

    Public Property back() As String
        Get
            Return _back
        End Get
        Set(value As String)
            _back = value
        End Set
    End Property


    Public Sub New(ByVal front As String, ByVal back As String, ByVal box As Integer, ByVal deck As Deck) 'Constructor initializes fields with given parameters

        Me._ID = ID
        Me._user = Session.userID
        Me._box = Session.Boxes.BOX_ONE
        Me._nextRevision = Session.ReturnCalculatedDateTime(0) 'First revision can be performed immediately
        Me._totalRevisions = 0
        Me._creationDate = Session.ReturnCalculatedDateTime(0)
        Me._deck = deck.deckID
        Me._front = front
        Me._back = back
    End Sub

    Protected MustOverride Sub storeCardInDatabase() 'Polymorphic subroutine to store card in database (different procedure for different card types)

End Class