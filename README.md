# Ammonite Archive

A Windows Forms application for cataloging and managing information about ammonite fossils.

## Overview

Ammonites are extinct marine mollusks that lived millions of years ago. This application provides a simple interface for archiving and preserving information about these ancient fossils.

## Features

- User-friendly Windows interface
- Sample ammonite catalog
- Interactive list display
- Detail view functionality

## Building

The project requires .NET 8.0 SDK:

```bash
dotnet restore
dotnet build -c Release
```

## Publishing

To create a standalone executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:PublishReadyToRun=true -o ./publish
```

The executable will be created at `./publish/AmmoniteArchive.exe`.

## Requirements

- .NET 8.0 Runtime (included in self-contained builds)
- Windows OS
