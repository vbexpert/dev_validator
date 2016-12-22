#Region "imports"
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Net.Mime.MediaTypeNames
Imports System.Linq
Imports System.IO
#End Region

Module mod_main
    Sub Main()
        '
        Dim arguments As [String]() = Environment.GetCommandLineArgs()
        Dim s_assembl_fnp As String = arguments(1)
        Dim s_profile_fnp As String = arguments(2)
        _cl(Convert.ToString("Loading assembly: ") & s_assembl_fnp & " & profile: " & s_profile_fnp)


        Dim cls_VP As New cls_Profile
        Dim s_buf As String = File.ReadAllText(s_profile_fnp)
        cls_VP.lst_parametrs = s_buf.Split(vbCrLf).ToList
        'trim all:
        For i As Integer = 0 To cls_VP.lst_parametrs.Count - 1
            cls_VP.lst_parametrs(i) = cls_VP.lst_parametrs(i).Trim
        Next
        _cl("----------------------------------->")
        _get_assembly_FormNames_and_validate(s_assembl_fnp, cls_VP)
        _cl("----------------------------------->")
        '_cl("press any key to quit...")
        'Console.ReadKey()
        '
    End Sub
    Private Sub _get_current_assembly_FormNames()
        Dim AllTypesInProjects As Type() = Assembly.GetExecutingAssembly().GetTypes()
        For i As Integer = 0 To AllTypesInProjects.Length - 1
            If AllTypesInProjects(i).BaseType = GetType(Form) Then
                'Convert Type to Object: 
                Dim f As Form = DirectCast(Activator.CreateInstance(AllTypesInProjects(i)), Form)
                Dim FormText As String = f.Text
                _cl(FormText)
                Console.ReadKey()
            End If
        Next
    End Sub
    Private Sub _get_assembly_FormNames_and_validate(ByVal s_fnp As String, _
                                                     ByVal cls_VP As cls_Profile)
        'http://stackoverflow.com/questions/465488/can-i-load-a-net-assembly-at-runtime-and-instantiate-a-type-knowing-only-the-na
        Dim obj_Assemply As Assembly = Assembly.LoadFrom(s_fnp)
        Dim AllTypesInProjects As Type() = obj_Assemply.GetTypes
        For i As Integer = 0 To AllTypesInProjects.Length - 1
            If AllTypesInProjects(i).BaseType = GetType(Form) Then
                'Convert Type to Object: 
                Dim f As Form = DirectCast(Activator.CreateInstance(AllTypesInProjects(i)), Form)
                _cl("Form size: " & f.Height & ":" & f.Width)
                _cl(f.GetType.ToString & ":" & f.Name)
                '
                '_cl("validation score is: " & cls_VP._get_validation_score(f.Controls))
                '
                Console.WriteLine("<div class='val_score'>" & cls_VP._get_validation_score(f.Controls) & " % вірно!</div>")
            End If
        Next
        'Console.ReadKey()
    End Sub
    Public Sub _cl(ByVal s_msg As String)
        Exit Sub
        Console.WriteLine("<br>" & s_msg)
    End Sub
End Module

Public Class cls_Profile
    Public lst_parametrs As New List(Of String)
    Public Function _get_validation_score(ByVal lst_controls As System.Windows.Forms.Control.ControlCollection) As Integer
        Dim i_score As Integer = 0
        For Each p In lst_parametrs
            Dim b_control_validated As Boolean = False
            Dim sa_values() As String = p.Split(":")
            'syntax:
            '0 = type
            '1 = control name
            '2 = control text
            '-------------------------->
            For Each c As Control In lst_controls
                If c.GetType.ToString = sa_values(0) Then
                    If c.Name = sa_values(1) Then
                        If c.Text = sa_values(2) Then
                            i_score += sa_values(3)
                            b_control_validated = True
                            Exit For
                        End If
                    End If
                End If
            Next
            If b_control_validated = False Then
                _cl("control validation failed: " & p)
            Else
                _cl("control validation Ok: " & p)
            End If
            '--------------------------<
        Next
        Return i_score
    End Function
End Class
