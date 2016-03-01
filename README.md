# Asp.Net-Security-Secrets-Revealed
Playground for [Pluralsight course] (https://www.pluralsight.com/courses/aspdotnet-security-secrets-revealed)

## Newbie findings

# IIS

Running the application from Visual Studio on IIS Express is not 100% the same as on full IIS. 

- ASP.NET must be properly installed and registred in the IIS. To register run `windir%\Microsoft.NET\Framework64\v4.0.30319\aspnet_regiis.exe -i`.

- No more manual copying files to `inetpub\wwwroot`! The most convenient way to deploy the application into IIS is via Visual Studion Publish... feature.

# Tracing

- If tracing enabled in `Web.config` details logged in `/trace.axd`
- See [commit] (https://github.com/milanoid/Asp.Net-Security-Secrets-Revealed/commit/8e2763fef2000adbd41c05df31001224c52eeb14)
