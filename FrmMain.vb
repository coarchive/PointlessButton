Public Class PointlessButton
  Private ReadOnly Key As Microsoft.Win32.RegistryKey
  Public Sub New()
    InitializeComponent()
    Dim RegSoftware = My.Computer.Registry.CurrentUser.OpenSubKey("Software", True)
    Key = RegSoftware.CreateSubKey("coalpha").CreateSubKey("PointlessButton")
    Btn.Text = GetCount()
  End Sub

  Private Function GetCount() As UInteger
    Dim NumCount = Key.GetValue("count")
    If NumCount Is Nothing Then
      Key.SetValue("count", 0, Microsoft.Win32.RegistryValueKind.DWord)
      Return 0
    Else
      Return NumCount
    End If
  End Function

  Private Sub BtnClick() Handles Btn.Click
    Dim NumCount = Key.GetValue("count")
    If NumCount Is Nothing Then
      NumCount = 1
    Else
      NumCount += 1
    End If
    Btn.Text = NumCount
    Key.SetValue("count", NumCount, Microsoft.Win32.RegistryValueKind.DWord)
  End Sub
End Class
