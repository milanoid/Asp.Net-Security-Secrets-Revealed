# Asp.Net-Security-Secrets-Revealed
Playground for [Pluralsight course] (https://www.pluralsight.com/courses/aspdotnet-security-secrets-revealed)

## Newbie findings

Running the application from Visual Studio on IIS Express is not 100% the same as on full IIS. 

- ASP.NET must be properly installed and registred in the IIS. To register run `windir%\Microsoft.NET\Framework64\v4.0.30319\aspnet_regiis.exe -i`.

- No more manual copying files to `inetpub\wwwroot`! The most convenient way to deploy the application into IIS is via Visual Studion Publish... feature.
