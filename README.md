# BasicBlazor

This repo contains samples of three different ways of hosting Blazor.

 * Blazor server runs as a dotnet core server side app and connects to the browser using SignalR
 * Blazor WASM runs in the Client using Web assembly and only need static file storage
 * Hosted WASM has all the code running in WASM in the browser but also has a dotnet core server hosting it. This app also has a PWA manifest.

All three were created from templates with dotnet new. 

I'll update this whenever a sample is needed to show a feature.

# The only additional changes so far are:

## Patterns
* In the hosted WASM version the Counter page is unmodified from template.
* In the server project the Counter Page is split to use a code behind with a .razor and a .razor.cs
* In the WASM project the CounterPage has been refactored to use a ViewModel, CodeBehind and razor view.

