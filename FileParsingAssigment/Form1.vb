Imports System.IO

Public Class Form1
    Dim ResultSheet As New List(Of GradeSheet)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ProcessStudentGrade()
        Try
            ' Create an instance of StreamReader to read from a file.
            Dim answerPath As String = String.Empty
            Dim studentsAnswerPath As String = String.Empty
            Dim generalPath As String = Directory.GetCurrentDirectory() + "\\Doucmentation"

            If rbtTest1.Checked = True Then
                answerPath = generalPath + "\\answerkey.txt"
                studentsAnswerPath = generalPath + "\\stanswers.txt"
            ElseIf rbtnTest2.Checked = True Then
                answerPath = generalPath + "\\answerkey2.txt"
                studentsAnswerPath = generalPath + "\\stanswers2.txt"
            End If

            Dim answerKey As New List(Of String)

            If answerPath <> String.Empty Then
                Dim sr As StreamReader = New StreamReader(answerPath)
                Dim line As String = String.Empty

                Do
                    line = sr.ReadLine()
                    If line IsNot Nothing Then
                        For i = 0 To line.Length - 1
                            Dim c As String = line.Substring(i, 1)
                            If c.ToUpper >= "A" And c.ToUpper <= "Z" Then
                                answerKey.Add(c)
                            End If
                        Next
                    End If
                Loop Until line Is Nothing
                sr.Close()


                If studentsAnswerPath <> String.Empty Then
                    sr = New StreamReader(studentsAnswerPath)
                    Do
                        line = sr.ReadLine()
                        If line <> String.Empty Then
                            Dim lineSplit As String() = line.Split(",")
                            If lineSplit.Length >= 1 Then
                                Dim name As String = lineSplit(0)
                                Dim answerScript As String = lineSplit(1)
                                Dim mark As Integer = Me.getStudentMark(answerScript, answerKey)
                                Dim grade As String = Me.getStudentGrade(mark)
                                Dim result As GradeSheet
                                result.StudeName = name
                                result.mark = mark
                                result.Grade = grade
                                ResultSheet.Add(result)
                                Dim listView As ListViewItem = lstvStudent.Items.Add(name)
                                listView.SubItems.Add(mark)
                                listView.SubItems.Add(grade)
                            End If
                        End If
                    Loop Until line Is Nothing
                    sr.Close()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function getStudentMark(ByVal anserScript As String, ByVal answerKey As List(Of String)) As Integer
        Dim mark As Integer = 0
        Try
            If anserScript IsNot Nothing Then
                For i = 0 To anserScript.Length - 1
                    Dim c As String = anserScript.Substring(i, 1)
                    If c.ToUpper >= "A" And c.ToUpper <= "Z" Then
                        If c = answerKey.Item(i).ToString() Then
                            mark = mark + 1
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return mark
    End Function
    Private Function getStudentGrade(ByVal mark As Integer) As String
        Dim grade As String = String.Empty
        Try
            If mark >= 9 Then
                grade = "A"
            ElseIf mark = 8 Then
                grade = "B"
            ElseIf mark = 7 Then
                grade = "C"
            ElseIf mark = 6 Then
                grade = "D"
            ElseIf mark >= 0 And mark <= 5 Then
                grade = "F"
            Else
                grade = String.Empty
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return grade
    End Function

    Private Sub btnStudentGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudentGrades.Click
        lstvStudent.Items.Clear()
        ResultSheet = New List(Of GradeSheet)
        Me.ProcessStudentGrade()
    End Sub
    Private Sub SetSummaryInfo()
        Try
            If ResultSheet IsNot Nothing Then
                Dim mark As New List(Of Integer)
                For I As Integer = 0 To ResultSheet.Count - 1
                    Dim gradeSheet As GradeSheet = ResultSheet.Item(I)
                    mark.Add(gradeSheet.mark)
                Next
                txtAverage.Text = Me.GetAverageMark(mark).ToString()
                txthighestMark.Text = Me.GethighestMark(mark).ToString()
                txtLowestMark.Text = Me.GetLowesttMark(mark).ToString()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function GethighestMark(ByVal mark As List(Of Integer)) As Integer
        Dim highestMark As Integer = 0
        Try
            For i As Integer = 0 To mark.Count - 1
                If highestMark < Integer.Parse(mark.Item(i)) Then
                    highestMark = Integer.Parse(mark.Item(i))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return highestMark
    End Function
    Private Function GetLowesttMark(ByVal mark As List(Of Integer)) As Integer
        Dim lowestMark As Integer = Integer.Parse(mark.Item(0))
        Try
            For i As Integer = 0 To mark.Count - 1
                If lowestMark > Integer.Parse(mark.Item(i)) Then
                    lowestMark = Integer.Parse(mark.Item(i))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return lowestMark
    End Function
    Private Function GetAverageMark(ByVal mark As List(Of Integer)) As Decimal
        Dim AverageMark As Decimal = 0
        Try
            For i As Integer = 0 To mark.Count - 1
                AverageMark = AverageMark + Integer.Parse(mark.Item(i))
            Next
            AverageMark = AverageMark / mark.Count

        Catch ex As Exception
            Throw ex
        End Try
        Return AverageMark
    End Function
    Private Sub SetPlaccements()
        Try
            Dim newList As List(Of GradeSheet) = ResultSheet
            newList.Sort(Function(p1 As GradeSheet, p2 As GradeSheet) p2.mark.CompareTo(p1.mark))
            For i As Integer = 0 To ResultSheet.Count - 1
                Dim studentGrade As GradeSheet = newList.Item(i)
                lstAverage.Items.Add(studentGrade.StudeName)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub SetTopStudent()
        Try
            If String.IsNullOrEmpty(txtAverage.Text.Trim()) = False Then
                Dim avgMark As Decimal = Decimal.Parse(txtAverage.Text.Trim())
                For i As Integer = 0 To ResultSheet.Count - 1
                    Dim student As GradeSheet = ResultSheet.Item(i)
                    Dim mark As Decimal = Decimal.Parse(student.mark)
                    If mark > avgMark Then
                        lstTopClass.Items.Add(student.StudeName)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub SetNeedToImproveStudent()
        Try
            If String.IsNullOrEmpty(txtAverage.Text.Trim()) = False Then
                Dim avgMark As Decimal = Decimal.Parse(txtAverage.Text.Trim())
                For i As Integer = 0 To ResultSheet.Count - 1
                    Dim student As GradeSheet = ResultSheet.Item(i)
                    Dim mark As Decimal = Decimal.Parse(student.mark)
                    If mark < avgMark Then
                        lstNeedsImprove.Items.Add(student.StudeName)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnPlacement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlacement.Click
        Try
            If ResultSheet.Count >= 1 Then
                lstNeedsImprove.Items.Clear()
                lstTopClass.Items.Clear()
                lstAverage.Items.Clear()
                Me.SetPlaccements()
                Me.SetSummaryInfo()
                Me.SetTopStudent()
                Me.SetNeedToImproveStudent()
            Else
                MessageBox.Show("First need to process student grade by clicking the Get Student Grade Button.", "Student Grade Process Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            lstvStudent.Items.Clear()
            ResultSheet = New List(Of GradeSheet)
            lstNeedsImprove.Items.Clear()
            lstTopClass.Items.Clear()
            lstAverage.Items.Clear()
            txtAverage.Text = String.Empty
            txthighestMark.Text = String.Empty
            txtLowestMark.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
