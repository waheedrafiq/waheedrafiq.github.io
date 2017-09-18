
Partial Class account
    Inherits System.Web.UI.Page
    
    Private Sub gotoinsertpage() Handles customerdetails.DataBound
        If (Request.IsAuthenticated = True) Then
            ' user is logged in so continue
            ' check session data is set properly
            If Session("usersloginid") Is Nothing Then
                ' force a login or registration
                FormsAuthentication.RedirectToLoginPage()
            Else
                ' where the d/b customer record is NOT found, check session data is set
                If customerdetails.DataItemCount = 0 Then
                    ' complete the customer record set up
                    Response.Redirect("insertcustomer.aspx")
                Else
                    Session("customerid") = customerdetails.DataItem.customerid
                End If
            End If
        Else
            ' force a login or registration
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub
End Class
