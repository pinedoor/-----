using UnrealBuildTool;

public class FpsMyGameTarget : TargetRules
{
	public FpsMyGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FpsMyGame");
	}
}
