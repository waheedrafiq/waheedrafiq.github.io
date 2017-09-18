
Partial Class insertcustomer
    Inherits System.Web.UI.Page
    Public Sub doinsertcode() Handles insertcustomerform.Init
        insertcustomerform.ChangeMode(FormViewMode.Insert)
    End Sub
    Protected Sub FormView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles insertcustomerform.DataBound
        If insertcustomerform.CurrentMode = FormViewMode.Insert Then
            DirectCast(insertcustomerform.FindControl("custusernameTextBox"), TextBox).Text = Session("usersloginid")
            DirectCast(insertcustomerform.FindControl("custemailTextBox"), TextBox).Text = Session("usersemail")
        End If
    End Sub
    Private Sub gobacktoaccountpage() Handles insertcustomerform.ItemInserted
        ' when the d/b customer record has been inserted, go to the customer details page
        Response.Redirect("customerdetails.aspx")
    End Sub
    Private Sub gobacktohomepage() Handles customerdetails.DataBound
        If customerdetails.DataItemCount > 0 Then
            ' where the d/b customer record already exists, go back to the home page
            Response.Redirect("default.aspx")
        End If
    End Sub
End Class
