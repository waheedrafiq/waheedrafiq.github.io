
Partial Class _Default
    Inherits Page
    Dim currentUser As MembershipUser
    Protected Sub Page_Load()
        ' To check if user is logged in
        If (Request.IsAuthenticated = True) Then
            ' user is logged in so save username & email in sessions for later use
            currentUser = Membership.GetUser()
            Session("usersloginid") = currentUser.UserName
            Session("usersemail") = currentUser.Email
            usersname.Text = currentUser.UserName
        Else
            ' force a login or registration
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub
    Private Sub gotoinsertpage() Handles customerdetails.DataBound
        If customerdetails.DataItemCount = 0 Then
            ' where the d/b customer record is NOT found, check session data is set
            If Session("usersloginid") Is Nothing Then
                ' force a login or registration
                FormsAuthentication.RedirectToLoginPage()
            Else
                ' complete the customer record set up
                Response.Redirect("insertcustomer.aspx")
            End If
        Else
            Session("customerid") = customerdetails.DataItem.customerid
        End If
    End Sub
End Class