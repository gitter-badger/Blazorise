# Blazorise components for Blazor

Blazorise is a component library built on top of [Blazor](https://blazor.net/) and CSS frameworks like Bootstrap, Bulma and Material.

Please look at [Bootstrap Demo](https://blazorisedemo.azurewebsites.net/) or [Material Demo](https://blazorisematerialdemo.azurewebsites.net) to see Blazorise in action.

```
Note: This project is still experimental so it's possible that some components will be removed or refactored.
```

[Releases](https://blazorise.com/docs/releases/) and [Roadmap](https://blazorise.com/docs/roadmap/)

## Feeds

* NuGet [![NuGet](https://img.shields.io/nuget/vpre/Blazorise.svg)](https://www.nuget.org/profiles/stsrki) ![Nuget](https://img.shields.io/nuget/dt/Blazorise.svg)

## Installation

Each of the supported css framework is defined by a diferent nuget package. To install them you must run one of the following commands:

```
Install-Package Blazorise.Bootstrap
or
Install-Package Blazorise.Material
or
Install-Package Blazorise.Bulma
```
Note that Bulma implementation is still in progress.

## Usage

The setup process is the same for all supported frameworks, just replace Bootstrap with the one you need.

Now, for a bootstrap framework you must do:

1. in index.html add:

```
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">

<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
```

2. In your main _ViewImports.cshtml add:

```
@addTagHelper *, Blazorise

@using Blazorise
@using Blazorise.Bootstrap
```

3. In Startup.cs add:

```
services
    .AddBootstrapProviders()
    .AddIconProvider( IconProvider.FontAwesome );
```

To setup Blazorise for other frameworks please refer the [Usage](https://blazorise.com/docs/usage/) page in the documentation.

