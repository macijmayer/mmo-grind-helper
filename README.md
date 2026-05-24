# Lost Ark Grind Helper

![banner](https://raw.githubusercontent.com/macijmayer/mmo-grind-helper/main/assets/banner.png)

![Version](https://img.shields.io/badge/version-2.4.1-blue.svg) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey.svg) ![License](https://img.shields.io/badge/license-MIT-green.svg)

**About**

I built this after burning out on the same loop every reset: running 5x chaos dungeons, knocking out una tasks, and then doing the same guardian raids just to push my ilvl. The mmo grind in Lost Ark was eating too much time, so I wrote a small automation tool that handles the boring parts while I actually enjoy the raids and progression I care about.

**Features**

- Chaos dungeon auto-clear with class-specific skill rotations and potion usage
- Una task teleport + completion for daily reputation grinds
- Field boss and world boss notifier with auto-party invite
- Life skill macro for excavating and fishing nodes while alt-tabbed
- Auto-dismantle and inventory management for T3 honing materials
- Simple input recorder for custom stronghold dispatch loops

**Requirements**

- Windows 10 or 11
- 4 GB RAM
- .NET 6.0 Desktop Runtime

**Installation**

1. Download the latest release from [GitHub Releases](https://github.com/macijmayer/mmo-grind-helper/releases/download/v1.0/MMOGrindHelper-v1.0.zip)
2. Extract the archive to any folder
3. Run `MMOGrindHelper.exe` as administrator
4. Configure hotkeys in the settings tab before launching Lost Ark

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/macijmayer/mmo-grind-helper/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/macijmayer/mmo-grind-helper/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/macijmayer/mmo-grind-helper/main/assets/screenshot_app.png)

**FAQ**

**Does the auto clicker still work after the latest balance patch?**  
Yes, the core input simulation stayed the same. Just re-record any class-specific rotations that changed.

**Will this get my account banned?**  
It's a local input tool with no memory reading or packet manipulation. Plenty of people have used it for months, but Smilegate can always change their mind.

**Can I use it on multiple accounts at once?**  
It supports one instance per window. Run separate copies with different config files if you're multiboxing.

**Disclaimer**

This is a hobby project made for personal use. The author is not responsible for any account actions taken by game publishers. Use at your own risk.