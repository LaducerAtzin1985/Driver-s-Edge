Public Class DrivingSchool
    'A Driving School that provides comprehensive driver's education and training to help new drivers become confident and safe on the road.
    Private m_Name As String = "Driving School"
    Private m_Address As String = ""
    Private m_PhoneNumber As String = ""
    Private m_Hours As String = ""
    Private m_CoursesOffered As String = ""

    'constructor
    Public Sub New()
    End Sub

    'Properties
    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set
            m_Name = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return m_Address
        End Get
        Set
            m_Address = value
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return m_PhoneNumber
        End Get
        Set
            m_PhoneNumber = value
        End Set
    End Property

    Public Property Hours As String
        Get
            Return m_Hours
        End Get
        Set
            m_Hours = value
        End Set
    End Property

    Public Property CoursesOffered As String
        Get
            Return m_CoursesOffered
        End Get
        Set
            m_CoursesOffered = value
        End Set
    End Property

    'Method
    Public Function PrintDetails() As String
        Dim Details As String = ""
        Details &= "School Name: " & Me.Name & vbCrLf
        Details &= "Address: " & Me.Address & vbCrLf
        Details &= "Phone No: " & Me.PhoneNumber & vbCrLf
        Details &= "Operating Hours: " & Me.Hours & vbCrLf
        Details &= "Courses Offered: " & Me.CoursesOffered & vbCrLf
        Return Details
    End Function

    'Enum
    Public Enum Courses
        BasicDriving
        DefensiveDriving
        AdvancedDriving
        MotorcycleSafety
        TruckDriving
    End Enum

End Class