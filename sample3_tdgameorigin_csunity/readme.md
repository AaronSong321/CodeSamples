# Sample 3 readme

Author: Song Jian

Code Creation Time: October 2017 - December 2017

This sample is written in C# based on Unity3D.

## Introduction

Laboratory Defense is a 3D tower-defense game powered by Unity3D and built for Windows. What most discriminates this game from everyday TD games is the subsystem of perks and abilities. There are five perks and each perk has ten unique abilites. The player shall choose one perk for one instance of the game, build turrets augmented by the perk he or she has choosed to exploit the turrets, choose abilities whose numbers are limited by the level of the perk, and gain experiences by defeating enemies and surviving rounds. In one instance of the game, your goal is to build correct turrets to prevent enemies from damage your basement and survive each round before all your basement's health points are lost to win this instance.

## Features

The first scene you see when you enter the game allows players to register and log in. Note that the registration is completely offline, so you may not be able to synchronize your accounts through multiple terminals. After login, the second scene allows players to choose perks and abilities, and also difficulty and map of the game. Although the game is currently offline, the data of your perks and abilites shall be permenantly stored on your computer and can be loaded each time you boot the game. Several in-game features are elaborated below.

### Perks and Abilities

Perks and abilities are the most raping feature of this game. The five perks are Gunner, Bombardier, Arsonist, Electromagnetics Expert, and Coach, as shown in the "Perk" table. (You may have seen the icons of these five perks somewhere, I am sure, for I do not synthesize pictures nor can our art designer, so quit thinking about it.) Choose one perk, and you will select it as your current perk and see the details of its properties and abilities. Properties are anonymous privileges that are constantly active (which means you do not have to choose which ones to deactive) and usually accrue accompanying the increase of your perk level. While abilities, however, are not statically active. You unlock one ability every 10 level and the terminal level is 50. Before each instance of the game, you need to choose one level out of the two and you may only change your abilities in your next game (we are working on this issue and hopefully you are allowed to change your abilities and even your perks every round of game).
You can read the descriptions of each property and ability in either simplified Chinese or English, so they will not be demonstrated here. Some abilities lack flairs, such as "Increase the damage of your perk turrets by 30 percent"; while others may have an abstrusing effect like "All your turrets deal damage of damage type Nuclear".

### Game Difficulty

There are two maps and two difficulties to be choosen from, as "hypothetical" means an easier game and "rival" indicates a slightly harder game. Actually, four difficulties in total are designed and they are adapted to the level of your perk. We suggest that DO NOT try the highest difficulty when your level is not high enough, ohterwise your game experience might not be satisfying. Here is the design of difficulties. The first two difficulties have already been implemented and match our design exactly. (Have a try!)
|Difficulty|Suggested Perk Level|Odd of Victory|
|----|----|----|
|Hypothetical|0-20|90%|
|Rival|15-35|80%|
|Hard|30-45|80%|
|Extreme|40-50|70%|
The game has a partially satisfying level of equilibrium and you may not be able to survive every round without a single loss of health point in five hours of gameplay.

### Turrets

There are thirteen kinds of turrets and a compendium is shown below. (You may get detailed data in the game.)
|Turret|Sugguested Perk|Target Type|Introduction|Special Ability|
|----|----|----|----|----|
|Machine Gun|Gunner|Ground Units|Cheap and Rapid Fire|None|
|Crossbow|Gunner|Ground and Air Units|Slow but Powerful|Chance to Stun|
|Sniper|Gunner|Ground Units|Slow but Powerful|A Large Range|
|PillBox|Gunner|Ground Units|Rapid Fire|None|
|Sharpnel Thrower|Bombardier|Ground Units|Explosive Rounds|None|
|Patriot Missile|Bombardier|Air Units|Explosive Rounds|None|
|Rocket|Bombardier|Ground and Air Units|Explosive Rounds|None|
|Prisim|Electromagnetics Expert|Ground Units|None|None|
|Transformer|Electromagnetics Expert|Ground Units|Shoot all Units within Range|Slow Effect|
|Thunder|Electromagnetics Expert|Ground and Air Units|Slow but Powerful|Chance to Stun|
|Flame Thrower|Arsonist|Ground Units|Shoot all Units within Range|Burning Damage|
|Molotov Cocktail|Arsonist|Ground Units|None|Burning Damage|
|Micro|Arsonist|Ground Units|Shoot all Units within Range|Burning Damage|

Not that there is one perk, Coach, that has no unique turrets. That is true, Coach is a different perk that can benefit from all these turrets, but my suggestion is that consider using Coach only when you are familiar with every turret in this game. From the table, you may also realize that certain perks are excellent in some situations while others are not. For example, Arsonist and Bombardier are both good at attacking a big crowd of enemies, which may insinuate that they are probably not good at coping with a small amount of large and powerful units.

### Enemies

You can only drum the enemies when you are aware of the enemies you are encountering. There are ten kinds of enemies and among them two kinds are flying units, meaning they can only be shot by anti-air turrets and are not blocked by your turrets. Some enemies are defined as huge ones, because they have tremendous health points and a frightening damage, but they are rare and provide a heavy pouch of cash. Defeat enemies to survive one round, and defeat all rounds to win the game!

## Future Extension

There are still works yet to be done, such as:

- More game modes. In fact, three game modes are designed, but due to the time issue only the plain survival game is implemented. The other two are cooperation game and versus game. In a cooperation game several players form a team and choose different perks to do what a perk is really designed to do, while in a versus game one player assign half of his resources to build turrets to defend and spend the other half building barracks that generate creeps every round so as to attack his opponent.
- Online game resolution. The game is now completely standalone, but an online game is the basement of the extended game modes and cloud data storage.
- Achievement system. A good game shall contain achievements to keep players challenging themselves and developing more strategies (A tower-defense game is a strategy game in essence.)

You may contact the author through email 2511146542@qq.com or 15504638627@163.com to commit a bug issure, or help improve the game.

You may also download the [source code](https://github.com/AaronSong321/LaboratoryDefense) or [executable game](https://github.com/AaronSong321/MyGamesBuild) from github.
