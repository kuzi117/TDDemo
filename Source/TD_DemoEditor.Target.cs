

using UnrealBuildTool;
using System.Collections.Generic;

public class TD_DemoEditorTarget : TargetRules
{
	public TD_DemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TD_Demo" } );
	}
}
