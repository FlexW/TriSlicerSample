// Copyright (c) 2024 Felix Weilbach. All Rights Reserved.

using UnrealBuildTool;

public class TriSlicerSampleEditorTarget : TargetRules
{
    public TriSlicerSampleEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;

        ExtraModuleNames.AddRange(new string[] { "TriSlicerSample" });
    }
}
