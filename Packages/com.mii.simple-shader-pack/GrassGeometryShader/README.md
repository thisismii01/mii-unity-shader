# 🌾 Unity Grass Geometry Shader

> Originally created by [Erik Roystan](https://github.com/IronWarrior). This project demonstrates procedural grass generation in Unity using tessellation and geometry shaders.
> View the original repository here: [UnityGrassGeometryShader](https://github.com/IronWarrior/UnityGrassGeometryShader)

## ✨ Features

- **Procedural Grass Blades**  
  Grass blades are fully generated on the GPU using a geometry shader—no need for prefabs or instancing.

- **Customizable Blade Shape**  
  Control blade width, height, forward lean, curvature, and random variations for a natural look.

- **Tessellation Support**  
  Use hardware tessellation to control grass density and surface blending dynamically.

- **Wind Simulation**  
  Includes distortion texture and time-based parameters to simulate wind sway and turbulence.

- **Translucency Lighting**  
  Subtle backlight simulation adds realism when light passes through blades.

- **Shadows & Lighting**  
  Supports Unity’s forward rendering path, shadows, and ambient lighting (spherical harmonics).

## 🧰 Requirements

- Unity 2018.1 or newer
- Shader Model 4.6 (DX11-compatible GPU)
- Platform support for geometry shaders

