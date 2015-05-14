# unity-utilities
Useful scripts for Unity 3d on C# language and demo scenes to show how they work.


2dParallax - Parallax effect for backgrounds on 2d games.

2dRepeatObjectOnX - Sprite infinite repetition on horizontal following the camera movement. Useful for background repetition.

2dParallaxWithRepeatObjectOnX - Project that joins the parralax effect with the background repetition. Basically, it uses the 2dParallax and 2dRepeatObjectOnX together. 

GoToScene - Simple script that changes the scene to the one you put the name on the component. Useful to create buttons that changes the scene quickly.

Persistence - Have two persistence scripts: one that uses player prefs (recommended for preferences, like mouse sensibility and sound volume), and a script that creates a binary file with info (useful to store any info that the player should not access and change easily, like a savegame file).

Scripts dependencies:

2dParallax
- None

2dParallaxWithRepeatObjectOnX
- [Demo only] Uses the Camera2dMoveX.cs script from "2dParallax" to move the camera to show the parallax and the background repetition are working together.
- Uses the ParallaxObject.cs script from "2dParallax" on the container objects to make the parallax effect.
- Uses the RepeatSprite.cs script from "2dRepeatObjectOnX" on the children objects to make them repeat.

2dRepeatObjectOnX
- [Demo only] Uses the Camera2dMoveX.cs script from "2dParallax" to move the camera to show the background repetition is working.

GoToScene
- None

Persistence
- [Demo only] Uses the goToScene.cs script from "GoToScene" on the demo button that changes the scenes to show the persistence is working.
