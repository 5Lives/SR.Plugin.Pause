Example Mod for Satellite Reign.

Press pause(pause/break) key on keyboard to pause / unpause the game.


How to Build:

You will need MonoDevelop (or Visual Studio) & Unity 5.0+ installed to compile this mod.

Open the solution file "Pause.sln" in MonoDevelop
Make sure the Solution pane is showing. (View -> Pads -> Solution)

Expand the "Pause" solution and "Pause" project in the "Solution" pane.

Right click "References" -> "Edit References"

Click ".Net Assembly" tab

Click "Browse" and add references to the following assemblies.

[SR install folder]\SatelliteReignWindows_Data\Managed\UnityEngine.dll
[SR install folder]\SatelliteReignWindows_Data\Managed\Assembly-CSharp.dll
[SR install folder]\SatelliteReignWindows_Data\Managed\Assembly-CSharp-firstpass.dll
Click "OK"

Select menu "Build" -> "Rebuild All". 
Depending on selected configuration, "Pause.dll" will be written out to either 

[ProjectRoot]Pause\bin\Debug\Pause.dll or 
[ProjectRoot]Pause\bin\Release\Pause.dll 

Copy Pause.dll to 
[SR install folder]\Mods

Start Satellite Reign

Once you start a game you should now be able to pause the game with the pause key.

