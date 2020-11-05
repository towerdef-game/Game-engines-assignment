# Game-engines-assignment
My game is a first-person shooter wave defense game. set in a randomly generated city. The player will have to defend themselves from waves of enemies that will attempt to kill the player. Unlike other wave-based games my game will feature time dilation where time will only move when the player is moving like the game superhot. The game will be set in a cyberpunk style.
# Implamentation
## City Generation
The way I intend to create the city generation is by using Perlin noise to decide the height of the buildings making sure each no two buildings are the same height. I will also using create the buildings using segments so each building will look different. The city generation will spawn a grid which will then spawn a smaller grid that will spawn the buildings themselves creating a city block.  
## Time Dilation
For the time dialtion I will have it set based on the player's movement when they move the time will flow normally. But when they are standing still time will slow to a crawl allowing the player to think out their next move.

# Player's goal
The goal of the game is to survive several waves of enemies that will continuously move toward the player when they enter a specfic range they will beginning shooting at the player. Once they kill all the enemies of that wave they will move onto the next wave. Once the player beats all the waves they will win the game. If the Player get hit the will die and lose the game.
