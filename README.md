# Unity Slot Machine Game

## Overview
A simple slot machine game developed using Unity and C#. Players spin three reels, receive random symbols, and win coins by matching all three symbols.

## Features
- Three reels with random symbols
- Reel animations that gradually slow down
- Jackpot detection for matching symbols
- Coin balance system
- Spin cost of 10 coins and a win reward of 50 coins
- Restart button to reset the balance
- WebGL build for browser testing

## How to Play
1. Click **Spin** to spin the reels.
2. Each spin costs 10 coins.
3. Match all three symbols to win 50 coins.
4. Click **Restart Game** to reset your balance to 100 coins.

## Technologies Used
- Unity
- C#
- TextMeshPro
- WebGL

## How to Run
Open the project in Unity Hub and load the main game scene.

A browser build is included in `Build/WebGL-Test/`. To play it, serve this folder using a local web server that supports Unity WebGL files.

## Project Structure
- `Assets/` — Game assets, scripts, and scenes
- `Packages/` — Unity package configuration
- `ProjectSettings/` — Unity project settings
- `Build/WebGL-Test/` — WebGL build files

## Development Notes
The game uses random symbol selection and checks the final symbols to determine whether the player wins. Reel animations gradually slow down before the reels stop.

## Developer
Manaswi Madke
