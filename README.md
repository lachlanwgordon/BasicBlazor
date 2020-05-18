# BasicBlazor

This repo contains samples of three different ways of hosting Blazor.

 * Blazor server runs as a dotnet core server side app and connects to the browser using SignalR
 * Blazor WASM runs in the Client using Web assembly and only need static file storage
 * Hosted WASM has all the code running in WASM in the browser but also has a dotnet core server hosting it.

So far these projects have only been change by adding a code behind for 
Counter.razor in all three samples.

These projects won't be update for any really feature usage but will have sample added where useful for testing.
