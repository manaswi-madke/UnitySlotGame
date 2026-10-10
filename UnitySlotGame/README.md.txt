# Unity Slot Machine Game

## Overview
A simple slot machine game developed using Unity. Players can spin three reels, get random symbols, and win coins by matching all three symbols.

## Features
- Three spinning reels with random symbol selection
- Reel animations that gradually slow down
- Jackpot detection for matching symbols
- Coin balance system with a spin cost and win reward
- Restart button to reset the balance
- WebGL build for browser testing

## How to Play
1. Open the game.
2. Click **Spin** to spin the reels. Each spin costs 10 coins.
3. Match all three symbols to win 50 coins.
4. Click **Restart Game** to reset your balance to 100 coins.

## Technologies Used
- Unity
- C#
- TextMeshPro
- WebGL

## How to Run
- **In Unity:** Open the project through Unity Hub and load the main game scene.
- **In a browser:** Open the `Build/WebGL-Test` folder through a local web server and visit the server address in your browser.

## Project Structure
- `Assets/` — Game assets, scripts, and scenes
- `Packages/` — Unity package configuration
- `ProjectSettings/` — Unity project settings
- `Build/WebGL-Test/` — Browser build

## Development Notes
The game uses random symbol selection for each reel and checks the final symbols to determine whether the player wins. The reel animation gradually increases the delay between symbol changes before each reel stops.
