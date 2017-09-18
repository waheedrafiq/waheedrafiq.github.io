
Partial Class addorderitems
    Inherits System.Web.UI.Page
    Dim currentUser As MembershipUser
    Protected Sub Page_Load()
        ' To check if user is logged in
        ' If (Request.IsAuthenticated = True) Then

        'currentUser = Membership.GetUser()

        '  Else
        '   ' force a login or registration
        '  FormsAuthentication.RedirectToLoginPage()
        '   End If
    End Sub

    Private Sub defaulttextbox() Handles DropDownList1.Init
        'DropDownList1.Text = Session("restname")
    End Sub
    Private Sub gotoinsertpage() Handles FrmVOrders.DataBound

       
    End Sub



End Class
