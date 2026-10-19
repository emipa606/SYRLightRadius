# GitHub Copilot Instructions for [SYR] Light Radius (Continued) Mod

## Mod Overview and Purpose
The [SYR] Light Radius (Continued) mod offers an intuitive way to visualize light sources in RimWorld by adding dynamic light radii indicators. Created as an update to the original mod by Syrchalis, this mod helps players accurately assess how their light sources will illuminate designated areas.

## Key Features and Systems
- **Dynamic Light Radius Indicators**: When selecting or placing light sources, the mod displays an indicator to show the expected range of illumination.
- **Inner and Outer Light Radiuses**: Two customizable radii are available:
  - **Inner Light Radius**: Represents areas with over 30% light.
  - **Outer Light Radius**: Covers areas affected by light, showing more than 0% illumination.
- **Dynamic Compatibility**: Seamless integration with most other mods. Special consideration for the "Wall Light" mod for light radii visualization.
- **Non-intrusive and Safe**: The mod is safe to add or remove from save games without impacting data integrity.

## Coding Patterns and Conventions
- **C# Structure**: The mod's C# implementation focuses on modular, type-safe programming, with clear class definitions and method usages.
- **File and Class Naming**: C# files and classes are consistently named to reflect functionality—e.g., `LightRadiusCore`, `Designator_Place_SelectedUpdate`.
- **Method Conventions**: Methods use clear, descriptive names like `DoSettingsWindowContents` and `ExposeData` for clarity and maintainability.

## XML Integration
- **About.xml and ModSync.xml**: These XML files are used to integrate the mod with RimWorld, ensuring correct versioning and dependency management. The `About.xml` includes dependencies such as `brrainz.harmony`.

## Harmony Patching
- **Harmony Library**: Uses Harmony to create safe patches for the game's methods, enabling runtime modifications without altering the original game code.
- **Patch Types**: Includes postfix patches, which execute after the original method, to overlay the selection indicators for light sources.

## Suggestions for Copilot
- **Coding Assistance**: Copilot can assist in generating repetitive boilerplate code, such as XML configuration entries or method stubs in C#.
- **Pattern Recognition**: Utilize Copilot to identify coding patterns within the mod and suggest modifications that conform to these patterns.
- **Integrating Features**: Copilot can be used to propose enhancements or additional features that align with the existing mod structure, offering prompts for light radius calculations or GUI improvements.
- **Error Handling**: Leverage Copilot to suggest robust error handling mechanisms for user settings and Harmony patches.

By following these guidelines and utilizing the structured features of Copilot, mod developers contribute to maintaining the elegance and efficiency of the [SYR] Light Radius (Continued) mod within the RimWorld modding community.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

