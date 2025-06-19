# ✒️ Unity Outline Post-Processing Shader  
> Originally created by [Erik Roystan](https://github.com/IronWarrior). This project implements a screen-space outline effect using Unity's Post-Processing Stack v2. The effect detects edges based on depth and normal data, adding stylized outlines around 3D geometry.
> View the original repository here: [UnityOutlineShader](https://github.com/IronWarrior/UnityOutlineShader)

## ✨ Features

- **Screen-Space Edge Detection**  
  Outlines are applied in screen space using depth and normal differences—no need to modify materials or meshes.

- **Post-Processing Integration**  
  Uses Unity’s Post-Processing v2 stack for full pipeline compatibility.

- **Adjustable Line Thickness**  
  Control sample scale to make outlines thicker or thinner.

- **Custom Outline Color**  
  Set any RGB color and alpha to suit your scene style.

- **Depth + Normal Sensitivity**  
  Tweak thresholds to control how easily edges are detected.

- **View-Aware Thresholds**  
  Prevents false outlines on shallow slopes by considering view direction vs surface normal.

---

## 🧰 Requirements

- Unity 2018.1 or newer  
- **Built-in Render Pipeline** (URP/HDRP not supported out-of-the-box)  
- Post-Processing Stack v2 (via Package Manager)  
- GPU with Shader Model 4.0+

## 🧪 How It Works

This effect uses a fullscreen shader pass to compare neighboring pixels’ depth and normals. If differences exceed the thresholds, an outline is drawn. A matrix transform from clip to view space ensures accuracy when calculating normal direction relative to the camera.