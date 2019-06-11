# translation-library-for-human-navi
This project generate translation libraries using Visual Studio.  
The libraries are used by Human Navigation.

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
2. Google.Api.Gax.Rest.dll
3. Google.Apis.Auth.dll
4. Google.Apis.Auth.PlatformServices.dll
5. Google.Apis.Core.dll
6. Google.Apis.dll
7. Google.Apis.PlatformServices.dll
8. Google.Apis.Translate.v2.dll
9. Google.Cloud.Translation.V2.dll
10. System.Diagnostics.DiagnosticSource.dll
11. System.Interactive.Async.dll
12. System.Net.Http.dll
13. System.Security.Cryptography.Algorithms.dll
14. System.Security.Cryptography.Encoding.dll
15. System.Security.Cryptography.Primitives.dll

![ImportLibraries](https://github.com/PartnerRobotChallengeVirtual/translation-library-for-human-navi/blob/master/images/ImportLibraries.png)

## License

This project is licensed under the MIT License - see the LICENSE file for details.

<span style="color:red;">
And you need to agree to the following license to use the generated libraries.
</span>  
https://dotnet.microsoft.com/dotnet_library_license.htm  

  
Library list

<table>
<tr><th> No </th><th> Name </th><th> Version </th><th> License </th></tr>
<tr>
  <td> 1 </td><td> Google.Api.Gax.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Api.Gax/2.7.0">Google.Api.Gax 2.7.0</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Api.Gax/2.7.0/License">License</a> </td>
</tr>
<tr>
  <td> 2 </td><td> Google.Api.Gax.Rest.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Api.Gax.Rest/2.7.0">Google.Api.Gax.Rest 2.7.0</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Api.Gax.Rest/2.7.0/License">License</a> </td>
</tr>
<tr>
  <td> 3 </td><td> Google.Apis.Auth.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Auth/1.40.1">Google.Apis.Auth 1.40.1</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Auth/1.40.1/License">License</a> </td>
</tr>
<tr>
  <td> 4 </td><td> Google.Apis.Auth.PlatformServices.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Auth/1.40.1">Google.Apis.Auth 1.40.1</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Auth/1.40.1/License">License</a> </td>
</tr>
<tr>
  <td> 5 </td><td> Google.Apis.Core.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Core/1.40.1">Google.Apis.Core 1.40.1</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Core/1.40.1/License">License</a> </td>
</tr>
<tr>
  <td> 6 </td><td> Google.Apis.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis/1.40.1">Google.Apis 1.40.1</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis/1.40.1/License">License</a> </td>
</tr>
<tr>
  <td> 7 </td><td> Google.Apis.PlatformServices.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis/1.40.1">Google.Apis 1.40.1</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis/1.40.1/License">License</a> </td>
</tr>
<tr>
  <td> 8 </td><td> Google.Apis.Translate.v2.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Translate.v2/1.40.1.875">Google.Apis.Translate.v2.1.40.1.875</a> </td>
  <td> <a href="https://www.nuget.org/packages/Google.Apis.Translate.v2/1.40.1.875/License">License</a> </td>
</tr>
<tr>
  <td> 9 </td><td> Google.Cloud.Translation.V2.dll </td>
  <td> <a href="https://www.nuget.org/packages/Google.Cloud.Translation.V2/1.1.0">Google.Cloud.Translation.V2 1.1.0</a> </td>
  <td> <a href="https://www.apache.org/licenses/LICENSE-2.0">License</a> </td>
</tr>
<tr>
  <td> 10 </td><td> System.Diagnostics.DiagnosticSource.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Diagnostics.DiagnosticSource/4.5.1">System.Diagnostics.DiagnosticSource.4.5.1</a> </td>
  <td> <a href="https://github.com/dotnet/corefx/blob/master/LICENSE.TXT">License</a> </td>
</tr>
<tr>
  <td> 11 </td><td> System.Interactive.Async.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Interactive.Async/3.2.0">System.Interactive.Async.3.2.0</a> </td>
  <td> <a href="https://github.com/dotnet/reactive/blob/master/LICENSE">License</a> </td>
</tr>
<tr>
  <td> 12 </td><td> System.Net.Http.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Net.Http/4.3.4">System.Net.Http.4.3.4</a> </td>
  <td> <a href="https://dotnet.microsoft.com/dotnet_library_license.htm">License</a> </td>
</tr>
<tr>
  <td> 13 </td><td> System.Security.Cryptography.Algorithms.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Security.Cryptography.Algorithms/4.3.1">System.Security.Cryptography.Algorithms.4.3.1</a> </td>
  <td> <a href="https://dotnet.microsoft.com/dotnet_library_license.htm">License</a> </td>
</tr>
<tr>
  <td> 14 </td><td> System.Security.Cryptography.Encoding.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Security.Cryptography.Encoding/4.3.0">System.Security.Cryptography.Encoding.4.3.0</a> </td>
  <td> <a href="https://dotnet.microsoft.com/dotnet_library_license.htm">License</a> </td>
</tr>
<tr>
  <td> 15 </td><td> System.Security.Cryptography.Primitives.dll </td>
  <td> <a href="https://www.nuget.org/packages/System.Security.Cryptography.Primitives/4.3.0">System.Security.Cryptography.Primitives.4.3.0</a> </td>
  <td> <a href="https://dotnet.microsoft.com/dotnet_library_license.htm">License</a> </td>
</tr>
</table>
