# ParticleExplosionButton-CSharp

A fun little C# WinForms demo where clicking a button makes it **explode into colorful particles** 🎆  
This project is beginner-friendly and shows how to use **timers, graphics, and custom objects** in WinForms.

---

## 📺 YouTube Tutorial
👉 Watch the full step-by-step tutorial on YouTube:  
[![Watch the video](https://img.shields.io/badge/YouTube-Watch%20Now-red?logo=youtube&style=for-the-badge)](YOUR_YOUTUBE_VIDEO_LINK_HERE)

*(Replace `YOUR_YOUTUBE_VIDEO_LINK_HERE` with your actual video link)*

---

## 🚀 Features
- Click the **Boomm!** button to trigger an **explosion effect**  
- Colorful **particle system** with gravity  
- Smooth animation using **double buffering**  
- Simple and lightweight (only uses built-in .NET libraries)  

---

## 📂 Project Structure
Explosion_Button/
├── Form1.cs # Main form with button and particle logic
├── Particle.cs # Particle class with position, velocity, color, lifetime
├── Program.cs # Application entry point
├── Explosion_Button.csproj
└── README.md # This file

yaml
Copy code

---

## 🛠️ How It Works
1. The form creates a button labeled **Boomm!**
2. When clicked, it generates **50 random particles**
3. Each particle has:
   - A random direction and speed  
   - A random color  
   - A lifetime of ~1.6 seconds  
4. The `Timer` updates particle positions every 16 ms  
5. Gravity is applied, and expired particles are removed  
6. `OnPaint` redraws the particles as small colored circles  

---

## ▶️ Getting Started

### Requirements
- Windows  
- .NET Framework (4.8 or newer)  
- Visual Studio (Community Edition is fine)

### Run the project
1. Clone the repo:
   ```bash
   git clone https://github.com/YourUsername/Explosion_Button.git
Open Explosion_Button.sln in Visual Studio

Press F5 to run

📚 What You Can Learn
Basics of WinForms UI

Using a Timer for smooth animations

Custom drawing with OnPaint

Simple particle system design

🤝 Contributing
Feel free to fork this project, improve the particle system, or add new effects (e.g., fading particles, explosions from images, multiple explosion types, etc.).

📜 License
This project is licensed under the MIT License – free to use, modify, and share.

✨ Have fun coding explosions in C#!
