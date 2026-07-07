using Elements.Data;
using System.ComponentModel;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]

// Prevent FrooxEngine.Weaver from modifying this assembly, as it doesn't need anything done to it
// This keeps Weaver from overwriting AssemblyVersionAttribute
[module: Description("FROOXENGINE_WEAVED")]

//Mark as DataModelAssembly for the Plugin loading system to load this assembly
[assembly: DataModelAssembly(DataModelAssemblyType.Optional)]
