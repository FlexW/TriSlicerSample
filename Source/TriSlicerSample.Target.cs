// Copyright (c) 2024 Felix Weilbach. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TriSlicerSampleTarget : TargetRules
{
	public TriSlicerSampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "TriSlicerSample" } );
	}
}
