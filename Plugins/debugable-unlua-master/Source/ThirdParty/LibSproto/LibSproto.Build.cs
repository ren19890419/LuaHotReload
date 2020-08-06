// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class LibSproto : ModuleRules
{
	public LibSproto(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core","LuaLibFeature" });

		PrivateDependencyModuleNames.AddRange(new string[] { "Lua" });

		bEnableShadowVariableWarnings = false;
		bEnableUndefinedIdentifierWarnings = false;

		PublicDefinitions.Add("WITH_LIBSPROTO=1");
	}
}
