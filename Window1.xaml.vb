Public Class Window1
    Public RO As Boolean
    Public KeyLocation As String
    Public passwd As String
    Private Sub Window1_loaded()

    End Sub


    Private Sub checkBox_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox.Checked

    End Sub



    Private Sub button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click

    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textBox.TextChanged

    End Sub

    Private Sub checkBox2_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox2.Checked

    End Sub



    Private Sub radioButton2_Copy1_Checked(sender As Object, e As RoutedEventArgs) Handles radioButton2_Copy1.Checked
        PhysDmg.IsChecked = False
        MagiDmg.IsChecked = True
    End Sub

    Private Sub radioButton1_Checked(sender As Object, e As RoutedEventArgs) Handles radioButton1.Checked

    End Sub

    Private Sub radioButton4_Checked(sender As Object, e As RoutedEventArgs) Handles radioButton4.Checked

    End Sub


    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        MsgBox("保存出错:Configuration 'FileIO.SaveMethod' Not Defined", vbOKOnly, Title:="保存出错")
    End Sub

    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        MsgBox("导出出错:Configuration '7zip.PackageInfo.Tools' Not Defined", vbOKOnly, Title:="导出出错")
    End Sub

    Private Sub radioButton3_Checked(sender As Object, e As RoutedEventArgs) Handles radioButton3.Checked
        OtherWork.IsEnabled = True

    End Sub

    Private Sub radioButton3_Unchecked(sender As Object, e As RoutedEventArgs) Handles radioButton3.Unchecked
        OtherWork.IsEnabled = False
    End Sub

    Private Sub checkBox4_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox4.Checked
        KeepTime.IsEnabled = True
    End Sub

    Private Sub checkBox4_Unchecked(sender As Object, e As RoutedEventArgs) Handles checkBox4.Unchecked
        KeepTime.IsEnabled = False
    End Sub

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim OpenFile As New Forms.OpenFileDialog
        OpenFile.Filter = "JPG图像|*.jpg|PNG图像|*.png|BMP图像|*.bmp|ICO图像|*.ico"
        If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            imgdef.Source = New BitmapImage(New Uri(OpenFile.FileName))
        End If

    End Sub

    Private Sub button_Copy_Click(sender As Object, e As RoutedEventArgs) Handles button_Copy.Click
        Dim OpenFile As New Forms.OpenFileDialog
        OpenFile.Filter = "JPG图像|*.jpg|PNG图像|*.png|BMP图像|*.bmp|ICO图像|*.ico"
        If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            imgl1.Source = New BitmapImage(New Uri(OpenFile.FileName))
        End If

    End Sub

    Private Sub button_Copy1_Click(sender As Object, e As RoutedEventArgs) Handles button_Copy1.Click
        Dim OpenFile As New Forms.OpenFileDialog
        OpenFile.Filter = "JPG图像|*.jpg|PNG图像|*.png|BMP图像|*.bmp|ICO图像|*.ico"
        If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            imgl2.Source = New BitmapImage(New Uri(OpenFile.FileName))
        End If

    End Sub

    Private Sub button5_Click(sender As Object, e As RoutedEventArgs) Handles button5.Click
        Dim OpenFile As New Forms.OpenFileDialog
        OpenFile.Filter = "JPG图像|*.jpg|PNG图像|*.png|BMP图像|*.bmp|ICO图像|*.ico"
        If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            image1.Source = New BitmapImage(New Uri(OpenFile.FileName))
        End If

    End Sub

    Private Sub checkBox5_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox5.Checked
        SpecAttk.IsEnabled = True
    End Sub

    Private Sub checkBox5_Unchecked(sender As Object, e As RoutedEventArgs) Handles checkBox5.Unchecked
        SpecAttk.IsEnabled = False
    End Sub

    Private Sub button4_Click(sender As Object, e As RoutedEventArgs) Handles button4.Click
        Dim OpenFile As New Forms.OpenFileDialog
        OpenFile.Filter = "证书文件|*.cef|包含密钥的文本文件|*.txt"
        If OpenFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            KeyLocation = OpenFile.FileName
        End If
    End Sub

    Private Sub Window1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub checkBox_Copy_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox_Copy.Checked
        If KeyLocation = "" Then
            MsgBox("请先选择密钥/证书文件！", Title:="提示")
            checkBox_Copy.IsChecked = False
        End If
    End Sub

    Private Sub checkBox_Copy1_Checked(sender As Object, e As RoutedEventArgs) Handles checkBox_Copy1.Checked
        If passwd = "" Then
            MsgBox("请先设置密码", Title:="提示")
            passwd = InputBox("键入新密码")
            checkBox_Copy1.IsChecked = False
        End If
    End Sub

    Private Sub button4_Copy_Click(sender As Object, e As RoutedEventArgs) Handles button4_Copy.Click
        passwd = InputBox("键入新密码")
    End Sub

    Private Sub button4_Copy1_Click(sender As Object, e As RoutedEventArgs) Handles button4_Copy1.Click
        If passwd <> "" Then
            MsgBox("当前密码是：" & passwd, Title:="查看密码")
        Else
            MsgBox("您还未设置密码", Title:="提示")
        End If
    End Sub

    Private Sub ComboBoxItem_Selected(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
