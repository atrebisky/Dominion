# Dominion
Practice C# by building the Dominion Board Game

This is my initial plan but things could drastically change as I start digging in. I hope to stop and refactor regularly but sometimes early hopes are things that never actually happen.

Inital ideas/step to make dominion game
1. Create starting deck of cards for a player
2. shuffle deck and draw 5
3. clean up: move cards to discard and draw 5 new cards
	should be able to know when to take discard pile and shuffle a new deck of cards

Stop and refactor as needed
1. Create cards from files
 	set up so that I can have json or xml files that my program pulls cards from
	allow all of the cards data to be part of the card(name, type, actions like +card or +action)
	http://wiki.dominionstrategy.com/index.php/List_of_cards
2. Create UI interface that shows things


Show available cards for the game
1. Display All the cards that will be available for a game
2. Allow user to add cards
3. create Action phase and Buy phase
3. logic in place that only lets player gain cards if they have enough money during buy phase

Stop and refactor as needed

Actions
1. allow player to play an action card and resolve the logic properly
2. player should be able to, after cards are drawn, to play card and resolve action, start buy phase at any time, end turn 

ideas for later
1. basic AI for multiplayer games
