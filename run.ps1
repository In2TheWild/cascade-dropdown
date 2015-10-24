

Add-Type -Path .\out\Project.dll
Add-Type -Path .\out\FSharp.Core.dll

$text = [Service]::createText("A1", "A2")
$llist = New-Object Microsoft.FSharp.Collections.FSharp
$level = [Service]::createLevel(0, "Name", "Title", 0, $llist)

 [appdomain]::CurrentDomain.GetAssemblies()|ForEach {

    Try {

        $_.GetExportedTypes()

    } Catch {}

} | where {$_.Name.Contains("FSharp") }  | select -First 100


