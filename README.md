[![](https://img.shields.io/badge/-Void_Crew_Modding_Team-111111?style=just-the-label&logo=github&labelColor=24292f)](https://github.com/Void-Crew-Modding-Team)
![](https://img.shields.io/badge/Game%20Version-0.26.3-111111?style=flat&labelColor=24292f&color=111111)
[![](https://img.shields.io/discord/1180651062550593536.svg?&logo=discord&logoColor=ffffff&style=flat&label=Discord&labelColor=24292f&color=111111)](https://discord.gg/g2u5wpbMGu "Void Crew Modding Discord")

# DelayedShards

Version 0.0.4  
For Game Version 0.26.3  
Developed by 18107  
Requires VoidManager 1.1.7


---------------------

### 💡 Function - Inserting shards into the map adds them to a queue for the pilot to activate at any time

### 🎮 Client Usage

- The Host must have the mod
- The Pilot should have the mod
- View shard count and configure keybinds at F5 > Mod Settings > Delayed Shards
- Activate Escort and Minefield shards with `2` and `3` respectively while sitting in the pilot's seat
- Clients without the mod can use `!ActivateShard` and `!CountShards` instead of keybinds

### 👥 Multiplayer Functionality

- ✅ Client
  - The Pilot should have the mod
- ✅ Host
  - The host must have the mod
- ***If the host leaves the game and the new host doesn't have the mod, all inserted shards will be lost!!!***

---------------------

## 🔧 Install Instructions - **Install following the normal BepInEx procedure.**

Ensure that you have [BepInEx 5](https://thunderstore.io/c/void-crew/p/BepInEx/BepInExPack/) (stable version 5 **MONO**) and [VoidManager](https://thunderstore.io/c/void-crew/p/VoidCrewModdingTeam/VoidManager/) installed.

#### ✔️ Mod installation - **Unzip the contents into the BepInEx plugin directory**

Drag and drop `DelayedShards.dll` into `Void Crew\BepInEx\plugins`
