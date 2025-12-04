using UnrealBuildTool;

public class FpsMyGameClientTarget : TargetRules
{
	public FpsMyGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FpsMyGame");
	}
}
