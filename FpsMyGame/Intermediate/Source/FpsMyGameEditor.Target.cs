using UnrealBuildTool;

public class FpsMyGameEditorTarget : TargetRules
{
	public FpsMyGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FpsMyGame");
	}
}
