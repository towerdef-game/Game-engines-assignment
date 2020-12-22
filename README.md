# Windows Defender
Name: John Heaphey,
Student Number D19124451,
Class group: DT508/TU984


# Controls
| Controls | Description |
|----------|-------------|
| W,A,S,D  | Movement    |
| Left mouse | shoot when gun is equipped|
| R | Drop gun |
| Space Bar | Jump |

The goal of the game is to survive the waves of enemies that are coming 

# How it Works 
## city generator 
The city generator uses perlin noise to determine the height of a building, the building will then use the prefabs you have selected for the base, the first block , the middle all the rest of the blocks, and the roof the final block in the set.
it will set these buildings in a grid similar to what it would be like in a city. 
1. Attach the script "perlin generator" to a plane or terrain.
2. Attach the generated object control script to an empty in your scene.
3.add another empty gameobject to your scene into your scene  and attach the grid spawner script this will spawn the grid edit the buildings on y or x variable to change how you want to build your city if you want to make a street have a high number in one but low number in the other e.g 9,2. 
4. add another empty game object with another grid spawner script and add it to the prefab to spawn varialbe from the previous step this will spawn another grid that will spawn what will spawn our buildings.
5. in the newest grid builder put another prefab with the build with noise script attached.
6. with the build with noise put in the object you want your buildings to be made of and how many objects it can be made of.
7.any difficulty implamenting please look at the scene for how i did it.

## Audio spectrum Manager
The audio spectrum manager uses music from an audio soruce to affect either the scale of an object, the colour or both to use the audio script follow the following steps 
1. create an audio source and put in the audiospectrum script this will convert he music into readalbe data
2. add either a audio syncscale or audiosync color

# References
https://www.youtube.com/embed/PzVbaaxgPco

# What I am most proud of
I am most proud of is how the way the my project looks i was trying to go for a what the inside of a computer hard drive would look like taking insperation from movies like Tron and old atari games. I am also proud of the city generation script  


# Game-engines-assignment proposal
My game is a first-person shooter wave defense game. set in a randomly generated city using perlin noise to determine the height. The player will have to defend themselves from waves of enemies that will attempt to kill the player. Unlike other wave-based games my game will feature time dilation where time will only move when the player is moving like the game superhot. The game will be set in a cyberpunk style.
# Implamentation
## City Generation
The way I intend to create the city generation is by using Perlin noise to decide the height of the buildings making sure each no two buildings are the same height. I will also using create the buildings using segments so each building will look different. The city generation will spawn a grid which will then spawn a smaller grid that will spawn the buildings themselves creating a city block.  
## Time Dilation
For the time dialtion I will have it set based on the player's movement when they move the time will flow normally. But when they are standing still time will slow to a crawl allowing the player to think out their next move.

# Player's goal/ How to Play
The goal of the game is to survive several waves of enemies that will continuously move toward the player when they enter a specfic range they will beginning shooting at the player. Once they kill all the enemies of that wave they will move onto the next wave. Once the player beats all the waves they will win the game. If the Player get hit the will die and lose the game.
