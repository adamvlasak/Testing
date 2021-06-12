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

Write-Output "Removing generated doc"
Remove-Item -Path .\doc\_site -Force -Recurse

Write-Output "Done with cleanup"
exit(0)
