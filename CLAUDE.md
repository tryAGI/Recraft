# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Recraft](https://recraft.ai/) AI image generation platform, auto-generated from the Recraft OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Recraft.slnx

# Build for release (also produces NuGet package)
dotnet build Recraft.slnx -c Release

# Run integration tests (requires RECRAFT_API_KEY env var)
dotnet test src/tests/IntegrationTests/Recraft.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Recraft && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Recraft/Generated/`.

1. `src/libs/Recraft/openapi.yaml` -- the Recraft OpenAPI spec (fetched from `https://external.api.recraft.ai/doc/spec/api.yaml`)
3. `src/libs/Recraft/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Recraft/` | Main SDK library (`RecraftClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Recraft API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
