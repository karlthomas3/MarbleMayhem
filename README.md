# CS50G Final Project
## Marble Mayhem
### **Resources**
* Unity
* C#
### **Builds**
This file contains builds for both Windows and MacOS located in the GameBuilds folder. 

### **History**
I was maybe five or six the first time i saw a Nintend Entertainment System and was completely awstruck. This project being the first game in the course for us to build from the ground up, I thought it fitting to call back to the beginning of my gaming life and make my own version of one of the first games I liked.

 We'd already worked on Mario and Zelda clones in the course and Duck Hunt would've been too simple and kinda boring with a mouse so I settled on Marble Madness.

 ### **Concept**
 The player controls a marble to reach the end of a level impeded by obstacles, enemeies, and other marbles. 

 # **Development**
 ### **Perspective**
 The original Marble Madness featured an isometric perspective to create the illusion of three dimensions. I'd originally wanted to play with the built in *First Person* or *Third Person* controllers. I scrapped that and returned to a more isometric view because being so close to the marble just didnt feel right and both of those controllers simply *moved* the player through the level completely destroying the sense that you were actually rolling a marble.

 ### **Movement**
 I wanted the player to feel like they were actually rolling a marble around almost like those wooden labryths where you tilt the board to get the marble through the maze. I considered tilting the game world but decided that would feel finicky and discovered simply applying force to the marble itself felt quite natural. With the inbuilt physics the ball would actually roll and maintain momentum allowing for that sweet spot of being *only just* in control.

 ### **Levels**
 The original Marble Madness had more levels than I ever managed to play through but the demo video to be recored for submission is limited to five minutes so I settled on only three. They feature several of the hazards I remember from playing the original as a small child. Terrain, water hazards, jumps, and other marbles.

 ##### **Level Design**
 Using Unity's 2D tilemap with the game object brush I was able to sketch out levels pretty quickly but decided to keep them fairly small to focus on the gameply and shorten the time of the demo video.

 ##### **Jumps**
 There are tiles laid out across the levels that add upward force as an impulse to the players marble causing it to jump. I'd orignally given the player the ability to jump anytime but it broke that *rolling the marble around* feeling I was trying to create so in confined jumping to a thing the map did to the marble. 

 ##### **Other marbles**
 Throughout the levels I placed several other marbles to attack the player. I set their logic to only activate when the player gets within a certain range of these enemies at which point they're launched at the player with varying amounts of force at slightly randomized intervals to give the impression they're also being controlled. 

 ##### **End Button**
 At the begging of each stage the player sees a text instructing the player to hit the big red button to proceed to the next level. This button simply tells the game manager to show the level complete UI and move to the next level after a short wait.

 ### **Camera, UI, and GameManager**
##### **Camera**
The camera is controlled by a short script that simply locks the camera to an offset of the player's transform.

##### **UI**
All of the ingame text is managed via the game manager script which toggles which UIs are displayed at any given time. 

##### **GameManager**
The game manager also handles all inputs except the character controls such as pausing the game or quiting the application. It also manages the flow of the game from level to level and all the miscellaneous little functions. 

##### **Audio**
While figuring out how to manage all the audio I came across a tutorial on youtube (Brackeys channel) outlining a basic audio manager. Handles all the audio in the game and I'll be modifying the concept to streamline my game managers in future games. 

# **Conclusion**
*Marble Mayhem* is a short reboot of the classic *Marble Madness* of the late 80's/early 90's. It updates the original by moving to a full three dimensions with much more accurate physics and enemies feature rudimentary AI. I really enjoyed building this and putting everything together from scratch was as educational as all the projects I worked on to reach this point. It really has been a fantastic experience and I cant wait to get started on my next game. 