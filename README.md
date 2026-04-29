# 4.3.-Niveles-de-juego-
# Helix Jump Unity - Sistema de Niveles Progresivos

## Descripción del Proyecto

Este proyecto consiste en el desarrollo de un videojuego tipo **Helix Jump** realizado en **Unity 3D** para Android o PC, donde el jugador controla una pelota que debe descender a través de plataformas giratorias evitando zonas peligrosas.

El juego incorpora una mecánica automática de generación de niveles con dificultad progresiva, aumentando el reto conforme el jugador avanza.

---

## Objetivo del Juego

Guiar la pelota hacia la parte inferior de la torre pasando entre espacios vacíos y evitando tocar las plataformas peligrosas de color rojo.

---

## Características Principales

- Movimiento de pelota con físicas.
- Plataformas giratorias.
- Sistema de niveles automático.
- Incremento progresivo de dificultad.
- Reinicio al perder.
- Sistema de puntuación.
- Cámara dinámica.
- Compatible con Android y PC.

---

## Estructura del Proyecto

```plaintext
Assets/
├── Scripts/
│   ├── LevelManager.cs
│   ├── PlatformController.cs
│   ├── BallController.cs
│   ├── DeathManager.cs
│   ├── GoalManager.cs
│   ├── ScoreManager.cs
│   └── CameraFollow.cs
├── Prefabs/
├── Materials/
├── Scenes/
│   └── MainScene.unity



Unity Technologies. (2024). Unity User Manual. Unity. https://docs.unity3d.com/Manual/index.html

Unity Technologies. (2024). Unity scripting API. Unity. https://docs.unity3d.com/ScriptReference/

Brackeys. (2019). How to make a game in Unity [Video]. YouTube. https://www.youtube.com/@Brackeys

Code Monkey. (2023). Unity beginner tutorials [Video]. YouTube. https://www.youtube.com/@CodeMonkeyUnity
