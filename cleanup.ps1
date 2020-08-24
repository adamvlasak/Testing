# make sure bin and obj are really clean
Remove-Item -Path **\bin -Force -Recurse
Remove-Item -Path **\obj -Force -Recurse

# because of test explorer in vscode
Remove-Item -Path **\TestResults -Force -Recurse

# remove screenshots
Remove-Item -Path c:\tmp\screenshots\*.png -Force