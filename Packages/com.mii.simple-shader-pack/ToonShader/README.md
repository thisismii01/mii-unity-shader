# 🖍️ Unity Toon Shader

> Originally created by [Erik Roystan](https://github.com/IronWarrior).  
> This project demonstrates stylized lighting using toon shading with specular, rim, and ambient components in Unity’s built-in render pipeline.  
> View the original repository here: [UnityToonShader](https://github.com/IronWarrior/UnityToonShader)

## ✨ Features

- **Stylized Toon Shading**  
  Non-photorealistic rendering using a modified Blinn-Phong lighting model with hard shading transitions.

- **Ambient + Diffuse Lighting**  
  Ambient light adds base brightness, while directional lighting provides strong stylized contrast.

- **Sharp Specular Highlights**  
  Artist-controlled glossiness produces cartoon-like highlights via smoothstep falloff.

- **Rim Lighting Effects**  
  Adds a glowing edge around the object silhouette based on viewing angle and lighting, with customizable blend and color.

- **Shadow Support**  
  Compatible with Unity’s real-time shadow system via shadow attenuation macros and `SHADOWCASTER` pass.

## 🧰 Requirements

- Unity 2018.1 or newer  
- Shader Model 3.0+  
- **Built-in Render Pipeline (Forward Rendering)**  
- No SRP support (URP/HDRP not included)

## 🎛️ Shader Parameters

| Property            | Description |
|---------------------|-------------|
| `Color`              | Tint applied to the final output |
| `Main Texture`       | Base albedo texture |
| `Ambient Color`      | Global light contribution even in shadows |
| `Specular Color`     | Color of specular highlight |
| `Glossiness`         | Controls sharpness and size of highlight |
| `Rim Color`          | Color of rim glow near object edges |
| `Rim Amount`         | Controls rim light thickness |
| `Rim Threshold`      | How quickly the rim fades into the lit surface |

## 💡 How It Works

This shader uses a **Blinn-Phong lighting model** with toon-style thresholding:

- **Light and shadow**: Directional light intensity is quantized for flat cartoon tones.
- **Specular**: Highlights are exaggerated using a double-squared glossiness term and smooth blending.
- **Rim light**: View-based highlighting along the object silhouette simulates cartoon edge glow.
- **Ambient**: Constant ambient color provides minimum brightness.
- **Shadow attenuation**: Shadows use Unity’s built-in macros for compatibility with lighting and shadow passes.

The final color combines light, shadow, specular, rim, and texture into a fully stylized output.
