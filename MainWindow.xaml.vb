Class MainWindow



    Private Sub textBox_Copy_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox_Copy.TextChanged

    End Sub

    Private Sub checkBox_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox.Checked
        label3.Visibility = Visibility.Visible
        button_Copy.IsEnabled = False
    End Sub


    Private Sub button_Copy_Click(sender As Object, e As RoutedEventArgs) Handles button_Copy.Click

        Dim checked As Boolean = True
        Dim cspace As Boolean = False
        Dim propj() As Char = textBox.Text.ToArray
        Dim uid() As Char = textBox_Copy.Text.ToArray
        If textBox.Text = "" Or textBox_Copy.Text = "" Then
            MsgBox("请填写作者和项目名称", Title:="错误")
            checked = False
        Else
            If propj(0) = " " Or uid(0) = " " Then
                MsgBox("不规范的名称", Title:="错误")
                checked = False
            Else For i As Integer = 0 To textBox.Text.Length - 1
                    If propj(i) = " " Then
                        checked = False
                        cspace = True
                    End If
                Next i
                For j As Integer = 0 To textBox_Copy.Text.Length - 1
                    If uid(j) = " " Then
                        checked = False
                        cspace = True
                    End If
                Next j
            End If
        End If
        If cspace = True Then
            MsgBox("项目名和作者名不允许出现空格", Title:="错误")
        End If

        If checked = True Then
            If checkBox.IsChecked = True Then
                Dim Edit As New Window1
                Edit.Show()
                Edit.Title = "编辑器(ReadOnly)：" & textBox.Text
                Edit.RO = True
            End If
            If checkBox.IsChecked = False Then
                Dim Edit As New Window1
                Edit.Show()
                Edit.Title = "编辑器：" & textBox.Text
                Edit.RO = False
                Edit.namebox.Text = textBox.Text
                Edit.ownbox.Text = textBox_Copy.Text
            End If
        End If


    End Sub

    Private Sub checkBox_Unchecked(sender As Object, e As RoutedEventArgs) Handles checkBox.Unchecked
        label3.Visibility = Visibility.Hidden
        button_Copy.IsEnabled = True
    End Sub


End Class
