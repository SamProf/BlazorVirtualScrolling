# BlazorVirtualScrolling

## Material Design components for Blazor and Razor Components
[![NuGet](https://img.shields.io/nuget/v/BlazorVirtualScrolling.svg)](https://www.nuget.org/packages/BlazorVirtualScrolling/)
[![Gitter](https://badges.gitter.im/MatBlazor/community.svg)](https://gitter.im/MatBlazor/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
[![GitHub Stars](https://img.shields.io/github/stars/SamProf/BlazorVirtualScrolling.svg)](https://github.com/SamProf/BlazorVirtualScrolling/stargazers)
[![GitHub Issues](https://img.shields.io/github/issues/SamProf/BlazorVirtualScrolling.svg)](https://github.com/SamProf/BlazorVirtualScrolling/issues)
[![Live Demo](https://img.shields.io/badge/demo-online-green.svg)](https://samprof.github.io/BlazorVirtualScrolling/)
[![MIT](https://img.shields.io/github/license/SamProf/BlazorVirtualScrolling.svg)](LICENSE)
[![Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=9XT68N2VKWTPE&source=url)

The `VirtualScroll` displays large lists of elements performantly by only rendering the items that fit on-screen. Loading hundreds of elements can be slow in any browser; virtual scrolling enables a performant way to simulate all items being rendered by making the height of the container element the same as the height of total number of elements to be rendered, and then only rendering the items in view.


## Demo and Documentation
- [Documentation and demo](https://samprof.github.io/BlazorVirtualScrolling/)


## Prerequisites

Don't know what Blazor is? Read [here](https://github.com/aspnet/Blazor)

Complete all Blazor dependencies.

- .NET Core 3.0 Preview 4 SDK (3.0.0-preview4-19216-03)
- Visual Studio 2019 Preview 4 with the ASP.NET and web development workload selected.
- The latest Blazor extension from the Visual Studio Marketplace.
- The Blazor templates on the command-line: dotnet new -i Microsoft.AspNetCore.Blazor.Templates::3.0.0-preview4-19216-03

## Installation 

Latest version in here:  [![NuGet](https://img.shields.io/nuget/v/BlazorVirtualScrolling.svg)](https://www.nuget.org/packages/BlazorVirtualScrolling/)


To Install 

```
Install-Package BlazorVirtualScrolling
```
or 
```
dotnet add package BlazorVirtualScrolling
```

## Usage

```html
@using BlazorVirtualScrolling

<VirtualScroll style="height: 500px;" ItemType="string" Items="@items" ItemHeight="50">
    <div>@context</div>
</VirtualScroll>

@functions
{
    public IEnumerable<string> items = Enumerable.Range(0, 1000000).Select(i => i.ToString()).ToArray();
}
```

## BlazorVirtualScrolling components for server-side Blazor (Razor Components)
- Startup.cs
```
app.UseEmbeddedBlazorContent(typeof(BlazorVirtualScrolling.VirtualScroll).Assembly);
```
- _Host.cshtml (head section)  
```html
@using EmbeddedBlazorContent
<head>
    ...
    @Html.EmbeddedBlazorContent()
</head>
```





## Questions

For *how-to* questions and other non-issues, for now you can use issues or you can use [![Gitter](https://badges.gitter.im/MatBlazor/community.svg)](https://gitter.im/MatBlazor/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge).

## Contributing

We'd greatly appreciate any contribution you make. :)

## License

This project is licensed under the terms of the [MIT license](LICENSE).

## News

### Version 1.0.0
 - First version of VirtualScroll component, proof of concept
