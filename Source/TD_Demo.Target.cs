

using UnrealBuildTool;
using System.Collections.Generic;

public class TD_DemoTarget : TargetRules
{
	public TD_DemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TD_Demo" } );
	}
}
