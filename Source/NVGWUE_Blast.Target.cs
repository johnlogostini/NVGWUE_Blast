// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NVGWUE_BlastTarget : TargetRules
{
	public NVGWUE_BlastTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "NVGWUE_Blast" } );
	}
}
