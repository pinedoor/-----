using UnrealBuildTool;

public class FpsMyGameServerTarget : TargetRules
{
	public FpsMyGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FpsMyGame");
	}
}
