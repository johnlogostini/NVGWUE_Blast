// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NVGWUE_BlastEditorTarget : TargetRules
{
	public NVGWUE_BlastEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "NVGWUE_Blast" } );
	}
}
