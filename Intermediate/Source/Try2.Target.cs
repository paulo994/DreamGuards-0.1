using UnrealBuildTool;

public class Try2Target : TargetRules
{
	public Try2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Try2");
	}
}
