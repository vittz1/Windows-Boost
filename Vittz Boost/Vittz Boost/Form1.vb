Imports System.IO
Imports System.Security.Principal
Imports System.Threading


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/// executar somente com privilegio de administrador
        Dim mPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent)
        If mPrincipal.IsInRole(WindowsBuiltInRole.Administrator) = False Then
            MessageBox.Show("Você precisa executar a aplicação como Administrador", "VITTZ BOOST", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        Else
            MessageBox.Show("Sigam no instagram: @Vithor97", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start("https://www.instagram.com/vithor97/")
        End If

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "CacheCleaner.bat"
        IO.File.WriteAllText(filename, My.Resources.CacheCleaner)
        Process.Start(filename)


    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Process.Start("cmd", "/K powercfg -h off & @echo Hibernation is disabled successfully. ")

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "RegistryOptimizations.reg"
        IO.File.WriteAllText(filename, My.Resources.RegistryOptimizations)
        Process.Start(filename)
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click

        Process.Start("cmd", "/K ipconfig /flushdns")

    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Process.Start("cmd", "/K Dism /Online /Cleanup-Image /ScanHealth && Dism /Online /Cleanup-Image /RestoreHealth")
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click

        Process.Start("cmd", "/K powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61")

    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "Disable_DVR_1.reg"
        IO.File.WriteAllText(filename, My.Resources.Disable_DVR_1)
        Process.Start(filename)
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "Disable_DVR_2.reg"
        IO.File.WriteAllText(filename, My.Resources.Disable_DVR_2)
        Process.Start(filename)
    End Sub

    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "fullscreenfix.reg"
        IO.File.WriteAllText(filename, My.Resources.fullscreenfix)
        Process.Start(filename)
    End Sub

    Private Sub MetroButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton10_Click_1(sender As Object, e As EventArgs) Handles MetroButton10.Click

        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "DefenderControl.exe"
        IO.File.WriteAllBytes(filename, My.Resources.DefenderControl)
        Process.Start(filename)

    End Sub

    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles MetroButton11.Click

        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "_10AppsManager.exe"
        IO.File.WriteAllBytes(filename, My.Resources._10AppsManager)
        Process.Start(filename)

    End Sub

End Class
