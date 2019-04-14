# Self hosting services

## References

<https://garywoodfine.com/ihost-net-core-console-applications/>
<https://www.tutorialdocs.com/article/dotnet-generic-host.html/>
<https://thinkrethink.net/2018/08/02/hostbuilder-ihost-ihostedserice-console-application/>
<https://medium.com/@daniel.sagita/backgroundservice-for-a-long-running-work-3debe8f8d25b/>
<https://stackoverflow.com/questions/54526534/net-core-console-app-fails-to-run-on-windows-server/>
<https://thinkrethink.net/2018/05/31/run-scheduled-background-tasks-in-asp-net-core/>
<https://github.com/pgroene/ASPNETCoreScheduler/>
<https://www.stevejgordon.co.uk/running-net-core-generic-host-applications-as-a-windows-service/>

## deployment reference

<https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service?view=aspnetcore-2.2/>
<https://github.com/aspnet/AspNetCore.Docs/blob/master/aspnetcore/host-and-deploy/windows-service/scripts/2.x/RegisterService.ps1/>
<https://github.com/PowerShell/PowerShell/>

## Reference to build .net core application and use it as windows service

<https://github.com/stevejgordon/IHostedServiceAsAService/>

## command to build and register service

dotnet publish --configuration Release --runtime win10-x64 --output c:\svc
.\RegisterService.ps1 -Name MyService -DisplayName "My Cool Service" -Description "This is the Sample App service."  -Exe "c:\svc\ConsoleApplicationHosting.exe" -User ManjushaShyam\ServiceUser

sc create MyService binPath= "c:\svc\ConsoleApplicationHosting.exe"