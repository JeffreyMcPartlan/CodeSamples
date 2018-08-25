Write-Output "`nLoad our DLL.`n"
[System.Reflection.Assembly]::LoadFrom("C:\Users\jeffrey.mcpartlan\Documents\Visual Studio 2017\Projects\BuzzFizz\ClassLibrary1\bin\Release\ClassLibrary1.dll")

Write-Output "`nExecute the static method of our class.`n"
[ClassLibrary1.BuzzFizz]::StaticOutput(350);

Write-Output "`nCreate an object instance of our class.`n"
$MyCompObj = New-Object ClassLibrary1.BuzzFizz(100);

Write-Output "`nExecute the public method of our instantiated class.`n"
$MyCompObj.ObjectInstanceOutput();