# 🌊 Unity Toon Water Shader

> Originally created by [Erik Roystan](https://github.com/IronWarrior).  
> This project showcases a stylized water shader with foam, surface distortion, and depth-based coloration in Unity’s built-in render pipeline.  
> View the original repository here: [ToonWaterShader](https://github.com/IronWarrior/ToonWaterShader)

## ✨ Features

- **Depth-Based Color Blending**  
  Water color transitions between shallow and deep hues based on depth buffer sampling for visual richness.

- **Foam Rendering**  
  Dynamic foam appears where water intersects other objects, modulated by depth and surface normal differences.

- **Surface Distortion**  
  A distortion texture adds motion and displacement to the water surface for stylized wave simulation.

- **Scrolling Surface Noise**  
  Foam and wave patterns animate over time using noise textures and UV scrolling.

- **Screen-Space Effects**  
  Uses Unity's `_CameraDepthTexture` and `_CameraNormalsTexture` for pixel-accurate underwater interaction.

- **Alpha Blending**  
  Proper transparent blending using custom `alphaBlend()` for seamless compositing over background.

## 🧰 Requirements

- Unity 2018.1 or newer  
- Shader Model 3.0+  
- **Built-in Render Pipeline**  
- Geometry must be opaque or semi-transparent and use a camera rendering the `_CameraDepthTexture`.

## 🎛️ Shader Parameters

| Property                    | Description |
|-----------------------------|-------------|
| `Depth Gradient Shallow`    | Color for shallow water areas |
| `Depth Gradient Deep`       | Color for deeper water regions |
| `Depth Maximum Distance`    | Max depth range for color blending |
| `Foam Color`                | Tint of foam rendered at intersections |
| `Surface Noise`             | Noise texture controlling foam patterns |
| `Surface Noise Scroll`     | Speed and direction of noise animation |
| `Surface Noise Cutoff`      | Threshold for how much noise appears |
| `Surface Distortion`        | Texture used to distort foam/noise UVs |
| `Surface Distortion Amount` | Intensity of distortion effect |
| `Foam Minimum Distance`     | Minimum depth for foam to appear |
| `Foam Maximum Distance`     | Maximum depth range to show foam |

## 💡 How It Works

- **Depth Calculation**:  
  Compares screen-space depth of the current pixel against the camera's depth buffer to find objects behind water.

- **Color Gradient**:  
  Blends between `Depth Gradient Shallow` and `Depth Gradient Deep` based on depth difference to simulate water depth.

- **Foam Effect**:  
  Foam is shown where normals differ and objects intersect water; driven by a noise texture and customizable cutoff threshold.

- **Distortion**:  
  The distortion texture shifts UVs to simulate refraction-like movement in the water and noise.

- **Anti-Aliased Foam**:  
  Uses `smoothstep()` for smooth, anti-aliased transitions between foam and water.