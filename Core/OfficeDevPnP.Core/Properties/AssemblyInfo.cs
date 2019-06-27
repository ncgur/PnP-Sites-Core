using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OfficeDevPnP.Core")]
#if SP2013
[assembly: AssemblyDescription("Office Dev PnP Core library for SharePoint 2013")]
#elif SP2016
[assembly: AssemblyDescription("Office Dev PnP Core library for SharePoint 2016")]
#elif SP2019
[assembly: AssemblyDescription("Office Dev PnP Core library for SharePoint 2019")]
#else
[assembly: AssemblyDescription("Office Dev PnP Core library for SharePoint Online")]
#endif
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OfficeDevPnP.Core")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("065331b6-0540-44e1-84d5-d38f09f17f9e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// Convention:
// Major version = current version 3 (released as of Aug 2018)
// Minor version = Sequence...version 0 was with Aug 2018 release, 1 = Sept, 2 = Oct,...
// Third part = version indenpendant showing the release month in YYMM
// Fourth part = 0 normally or a sequence number when we do an emergency release
[assembly: AssemblyVersion("3.10.1906.0")]
[assembly: AssemblyFileVersion("3.10.1906.0")]

#if PATCHED
#if SP2019
[assembly: AssemblyInformationalVersion("3.10.1906.0-SP2019")]
[assembly: AssemblyConfiguration("SP2019 Patched for client side")]
#elif SP2016
[assembly: AssemblyInformationalVersion("3.10.1906.0-SP2016")]
[assembly: AssemblyConfiguration("SP2016 Patched for client side")]
#endif
[assembly: InternalsVisibleTo("OfficeDevPnP.Core.Tests,PublicKey=00240000048000009400000006020000002400005253413100040000010001003b7dfd92f5d18c35ca84ad3a57acb260518f0e1367053cbdeb404f3d9ec4741eb5725569369484035d0287300a0444a7b0f90b36943347c9e46a8b0d1ab9c0543746bc115ea7733e904b289cbcb5087f77dae9bb85c094999c71e589e616d6bbce0a0da80a487491d575752269c6f446ee522c86a507757403ffc5bb4b0252d9")]
#else
[assembly: InternalsVisibleTo("OfficeDevPnP.Core.Tests")]
#endif
