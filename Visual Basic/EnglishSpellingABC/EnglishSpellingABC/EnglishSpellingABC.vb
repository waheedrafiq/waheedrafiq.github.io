

Public NotInheritable Class EnglishSpellingABC

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub EnglishSpellingABC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim StartMenuFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)

        Dim StartupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)



        Dim wsh As Object = CreateObject("WScript.Shell")

        wsh = CreateObject("WScript.Shell")

        Dim MyShortcut, DesktopPath

        ' Read desktop path using WshSpecialFolders object

        DesktopPath = wsh.SpecialFolders("Desktop")

        ' Create a shortcut object on the desktop

        MyShortcut = wsh.CreateShortcut(DesktopPath & "\name of shortcut.lnk")

        ' Set shortcut object properties and save it

        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings("path to exe including the exe")

        MyShortcut.WorkingDirectory = wsh.ExpandEnvironmentStrings("path to exe without the exe")

        MyShortcut.WindowStyle = 4

        'Use this next line to assign a icon other then the default icon for the exe

        'MyShortcut.IconLocation = WSHShell.ExpandEnvironmentStrings("path to a file with an embeded icon", icon index number)

        'Save the shortcut

        MyShortcut.Save()












        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ' ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
