Public Class PointlessButton
  Private NumCount As UShort = 0
  Private Sub BtnClick() Handles Btn.Click
    NumCount += 1
    Btn.Text = NumCount
  End Sub
End Class
