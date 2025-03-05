:start
dotnet build SpengernewsProject.Webapi --no-incremental --force
dotnet watch run -c Debug --project DreiProject.Webapi
goto start