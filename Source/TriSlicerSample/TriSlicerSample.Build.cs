// Copyright (c) 2024 Felix Weilbach. All Rights Reserved.

using UnrealBuildTool;

public class TriSlicerSample : ModuleRules
{
	public TriSlicerSample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
