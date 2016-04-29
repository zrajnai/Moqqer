﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("MoqInjectionContainer")]
[assembly:
    AssemblyDescription(
        "An Auto Mocker for Moq that acts like a IoC Container and creates default mocks recursively which all you have to do is verify."
        )]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Michal Ciechan @ Codeperf.net")]
[assembly: AssemblyProduct("MoqInjectionContainer")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("Codeperf")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("a8d854de-482c-4f15-9bc7-fe8a8041580d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion("1.8.0.0")]
[assembly: AssemblyFileVersion("1.8.0.0")]
[assembly: InternalsVisibleTo("Moqqer.Tests")]