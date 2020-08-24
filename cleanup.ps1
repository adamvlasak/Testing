$required_computer_name = "<COMPUTERNAME>"

if (-Not ($env:computername -Like $required_computer_name))
{
    Write-Output "Cannot use ${env:computername} - must be ${required_computer_name} computer!"
    exit(1)
}

# make sure bin and obj are really clean
Write-Output "Removing bin and obj directories in projects"
Remove-Item -Path .\**\bin -Force -Recurse
Remove-Item -Path .\**\obj -Force -Recurse

# because of test explorer in vscode
Write-Output "Removing vs code test explorer results"
Remove-Item -Path .\**\TestResults -Force -Recurse

# remove screenshots
Write-Output "Removing screenshots"
Remove-Item -Path c:\tmp\screenshots\*.png -Force

Write-Output "Done with cleanup"
exit(0)
