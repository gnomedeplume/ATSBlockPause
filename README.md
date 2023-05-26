# ATSBlockPause
A simple mod for Against the Storm that disables pausing. 
This mod mimics the effects of the Shattered Obelisk modifier, but without any bonus Citadel Resources.
It also disables auto-pausing for most window overlays including:

- Newcomers
- Orders
- Trade Routes
- Consumption
- Recipes
- Choose New Building

The only exception is the game will still pause when the Trading Post or the Menu is open.

## Installation (pre-built)
1. Download BepInEx 5.4 x86 from https://github.com/BepInEx/BepInEx/releases. Again, make sure it's the x86 version. 
2. Extract and put the contents of the folder in the same folder as your game files. (For example: `C:\Program Files (x86)\Steam\steamapps\common\Against the Storm`)
3. Run the game once. The BepInEx folder in your game folder should be populated with some new folders.
4. Download ATSBlockPause.dll from the Releases page. Copy ATSBlockPause.dll into `Against the Storm/BepInEx/plugins`.

That's it. Pausing should now be disabled.

## Installation (build it yourself)
1. Download the ATSBlockPause source code locally by cloning or forking this repository. 
2. Open the .sln file with Visual Studio. (I am using Visual Studo 2019 and .Net 4.7.2)
3. Build the Solution

The ATSBlockPause.dll file should now be in `ATSBlockPause\bin\Debug`. 
Follow the instructions for installing the pre-built mod using your .dll file instead.


