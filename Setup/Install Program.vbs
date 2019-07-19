Const AppTitle = "CS-Padrón 2015"
Const AppCompanyName = "Cardoner Sistemas"
Const AppProductName = "CS-Padrón"
Const AppEXEName = "CS-Padron.exe"

Dim WSHShell, FileSystemObject
Dim SourcePath, DestinationPath, ProgramsPath, DesktopPath
Dim ProgramsShortcut, DesktopShortcut

If MsgBox("Se instalará la aplicación en el disco local.", vbOKCancel + vbQuestion, AppTitle & " Setup") = vbOK Then
	Set WSHShell = WScript.CreateObject("WScript.Shell")

	'Get folders
	Sourcepath = Left(WScript.ScriptFullName, (Len(WScript.ScriptFullName)) - (Len(WScript.ScriptName)))
	ProgramsPath = WSHShell.SpecialFolders("Programs")
	DesktopPath = WSHShell.SpecialFolders("Desktop")

	'Copy files to Destination
	Set FileSystemObject = CreateObject("Scripting.FileSystemObject")
	If WSHShell.ExpandEnvironmentStrings("%PROGRAMFILES(X86)%") = "%PROGRAMFILES(X86)%" Then
		DestinationPath = WSHShell.ExpandEnvironmentStrings("%PROGRAMFILES%\" & AppCompanyName)
	Else
		DestinationPath = WSHShell.ExpandEnvironmentStrings("%PROGRAMFILES(X86)%\" & AppCompanyName)
	End if
	If Not FileSystemObject.FolderExists(DestinationPath) Then
		FileSystemObject.CreateFolder(DestinationPath)
	End If
	DestinationPath = DestinationPath & "\" & AppProductName
	If Not FileSystemObject.FolderExists(DestinationPath) Then
		FileSystemObject.CreateFolder(DestinationPath)
	End If
	FileSystemObject.CopyFile SourcePath & "\" & AppEXEName, DestinationPath & "\" & AppEXEName, True
	FileSystemObject.CopyFile SourcePath & "\" & AppEXEName & ".config", DestinationPath & "\" & AppEXEName & ".config", True
	FileSystemObject.CopyFile SourcePath & "\" & "Lobos.mdb", DestinationPath & "\" & "Lobos.mdb", True
	FileSystemObject.CopyFile SourcePath & "\" & "Microsoft.VisualBasic.PowerPacks.Vs.dll", DestinationPath & "\" & "Microsoft.VisualBasic.PowerPacks.Vs.dll", True

	'Create a shortcut object on the Start Menu
	Set ProgramsShortcut = WSHShell.CreateShortcut(ProgramsPath & "\" & AppTitle & ".lnk")
	With ProgramsShortcut
		.TargetPath = DestinationPath & "\" & AppEXEName
		.WorkingDirectory = DestinationPath
		.WindowStyle = 4
		.IconLocation = DestinationPath & "\" & AppEXEName & ", 0"
		.Save
	End With

	'Create a shortcut object on the Desktop
	Set DesktopShortcut = WSHShell.CreateShortcut(DesktopPath & "\" & AppTitle & ".lnk")
	With DesktopShortcut
		.TargetPath = DestinationPath & "\" & AppEXEName
		.WorkingDirectory = DestinationPath
		.WindowStyle = 4
		.IconLocation = DestinationPath & "\" & AppEXEName & ", 0"
		.Save
	End With

	MsgBox "La instalación ha finalizado correctamente.", vbInformation, AppTitle & " Setup"
End If