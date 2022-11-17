# seasoning-with-senpai
A game in which you play as sentient steaks that must be seasoned well to impress your senpai.

![game screenshot](https://raw.githubusercontent.com/mezzofarte/seasoning-with-senpai/master/seasoning-with-senpai/Assets/screenshot.png)

Game Description:

In our game, Seasoning with Senpai, you play as a piece of Steak that needs to be seasoned.
You will have a top down view of the steak on a plate and you’ll try to get seasoned by the chef
as fast as possible to complete as many steaks as you can. However, you have to avoid over
seasoning the steak or else it’ll count as a failed steak. The goal of the game is to get the
highest star rating you can, successful steaks increase your score and failed steaks decrease
your score.

MECHANICS

1. Movement:
1. The player can move the steak by using W,A,S, and D.
2. The player can make the steak sprint by holding down SHIFT. This coincides with
the pillar of chaos, because the steak less responsive but faster.
3. The player can serve the steak by pressing the SPACE bar and a new steak
respawns.
2. Environment:
1. Seasons affect the player differently as described above
2. The edge of the pan stops the player but if the player is moving to fast they fly off
3. A shadow appears directly below the shaker which will indicate where the
seasons fall
3. Level Goal:
1. The player is trying to a get a higher star score each time.
2. Each successful steak is half a star.
3. Each failed steak is negative one star.
4. Avoid flying off the pan, because that also leads to a failed steak

FUTURE IMPLEMENTATIONS

Hazards:
1. Oil: certain parts of the pan will be slippery with oil. If the player goes into oil,
they cannot move the steak anymore and will continue in the direction they were
going in.
2. Obstacles: parts of the pan will have other foods that will block the player from
moving in that space. The player will have to go around them.
3. Vegetables: avoid the vegetables. The player will be unable to move for a
specified amount of time after the steak hits the vegetable
2. Different seasonings:
1. Pepper: this is another seasoning, but the steak has to avoid being seasoned by
the pepper, increasing the difficulty of the game.
Desired Player Experience
We want the player to feel accomplished after he/she sees how many stars they were able to
accumulate. Each successful steak should make the player feel like they’re making progress in
the game, but the failed steaks should make the player feel challenged and aspire to not make
more failed steaks. Having a time limit will make the player feel pushed for time and try to make
the steaks as fast as possible, making the game exciting. The experience should be enjoyable
but challenging. The visuals and sounds of the game should mesh together well and be
appealing for the player. The use of particle effects help portray make realistic visuals. The
game in general should interest and make the player happy.

Roles List:

Adrienne Caparaz - Artist/Audio

Antonin Durchanek - Programmer

Lindsey Duong - Artist/Audio

Sarah Huang - Programmer

Patrick Luong - Programmer

Dillon Vuong - Producer

Task List:

Adrienne Caparaz: Scene transitions, Scene building, Scene transition animation, Narrative/Story

Antonin Durchanek: Enemy movement (Shakers), Shadow, Enemy collisions for Shakers, Shaking animation

Lindsey Duong: Sprite creation, Artwork, Sounds

Sarah Huang: UI, Main Menu, Pause Menu, Menu button animation

Patrick Luong: Pan Boundaries, Speed variable for steak, Player/Steak movement, Obstacle effects (oil)

Dillon Vuong: Particles, Obstacles, Hazards, Animations for normal objects
