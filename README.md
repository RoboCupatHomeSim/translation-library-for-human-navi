# translation-library-for-human-navi
This project generate translation libraries using Visual Studio.  
These libraries are used by Human Navigation.

## Prerequisites

- Windows 10
- Visual Studio 2019

## How to Build

1. Launch Visual Studio 2019.
2. Open the TranslationLibraryGenerator.sln with Visual Studio.
3. Click [Build]-[Build Solution].

## How to Execute

The purpose of this project is to generate libraries, but it is also possible to run an executable file and check the translation.

1. Build the execution environment of Google Cloud Translation.  
https://cloud.google.com/translate/
2. Launch a command prompt.
3. Run an executable file.  
```
> cd TranslationLibraryGenerator\bin\Release
> TranslationLibraryGenerator "I have an apple" "ja" "en"  
りんごを持っています。
```

## How to Import

The following libraries are generated in a "TranslationLibraryGenerator\bin\Release" folder.  
Drag and drop these libraries into the Assets/Plugins/x86_64 folder of the Unity project.  
1. Google.Api.Gax.dll
1. Google.Api.Gax.Rest.dll
1. Google.Apis.Auth.dll
1. Google.Apis.Auth.PlatformServices.dll
1. Google.Apis.Core.dll
1. Google.Apis.dll
1. Google.Apis.PlatformServices.dll
1. Google.Apis.Translate.v2.dll
1. Google.Cloud.Translation.V2.dll
1. System.Diagnostics.DiagnosticSource.dll
1. System.Interactive.Async.dll
1. System.Net.Http.dll
1. System.Security.Cryptography.Algorithms.dll
1. System.Security.Cryptography.Encoding.dll
1. System.Security.Cryptography.Primitives.dll

## License

This project is licensed under the MIT License - see the LICENSE file for details.

And you need to agree to the following license to use the generated libraries.  
https://dotnet.microsoft.com/dotnet_library_license.htm
