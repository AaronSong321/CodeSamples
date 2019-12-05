# Sample 2 Readme

Author: Song Jian

Code Creation Time: October 2019 - November 2019

This code sample is written in C++ based on Unreal Editor (Version 4.22).

This is a basic tower-defense game with several elements including enemies, turrets, bullets, and enemy debuffs. Due to brevity constriction, only two classes are shown here, including **ATower** and **AEnemy**.
The whole project includes main classes, structs, or enums:

- **ABase** describes the basement of a tower-defense game.
- **ABullet** describes bullets shot by turrets. Several trivial classes inherit from **ABullet** but they do not yet provide extra functions.
- **ATower** describes the turret of the game. Several trivial classes inherit from **ATower** but they do not yet provide extra functions.
- **AExplode** describes an actor used only when an explosion occurs and the references of nearby enemies are detected and collected to deal explosion damage.
- **AWaypoint** describes points following which enemies plod towards the basement.
- **UDebuffComponent** describes a component based on which enemies suffer from slow or poison debuff.
- **ATDGameMode** describes the game mode of this game, inherited from **AGameMode**.
- **ATDController** describes behaviours when the player clicks a basin to build a turret.
- **UHPWidget** and et cetera describe user widgets based on UMG.

You may also clone the whole project from [github](https://github.com/AaronSong321/TowerDefenseGame).
