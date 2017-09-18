
Partial Class addorder
    Inherits System.Web.UI.Page
    Dim currentUser As MembershipUser
    Private Sub gotoinsertpage() Handles FormView1.DataBound


        If (Request.IsAuthenticated = True) Then
            Response.Write("<h1>Ordering System </h1>")

        Else
            
            Response.Redirect("Default.aspx")

        End If



    End Sub

    
    Protected Sub Page_Load()

        ScriptManager1.RegisterAsyncPostBackControl(FormView1)

       


    End Sub
    Private Sub defaulttextbox() Handles lblHelloUser.Init
        currentUser = Membership.GetUser()
        lblHelloUser.Text = Session("usersloginid")
        lblCustID.Text = Session("customerid")

    End Sub

    Public Sub doinsertcode() Handles FormView1.Init
        FormView1.ChangeMode(FormViewMode.Insert)
    End Sub
    
    Protected Sub FormView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.DataBound
        If FormView1.CurrentMode = FormViewMode.Insert Then
            DirectCast(FormView1.FindControl("customeridTextBox"), TextBox).Text = Session("customerid")
        End If
    End Sub

   
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
