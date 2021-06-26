# BattleshipSinglePlayer
## System Requirements
1. Install [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Install [Visual Studio Code](https://code.visualstudio.com/)
3. Open this project in VS Code and accept the prompt to install recommended extensions
4. Open your terminal window in VS code and enter the following commands in order
  - ```cd BattleshipSinglePlayer```
  - ```dotnet run```
5. The program uses a CLI which will ask for your user input. It will display your game board and ask you what ship you would like to deploy. Your options are Destroyer, Carrier, Cruiser, Battleship and Submarine.
```
Welcome to Battleship single player!

Player 1's current board: 
   1 2 3 4 5 6 7 8 9 10 
   ___________________
A |□ □ □ □ □ □ □ □ □ □ 
B |□ □ □ □ □ □ □ □ □ □ 
C |□ □ □ □ □ □ □ □ □ □ 
D |□ □ □ □ □ □ □ □ □ □ 
E |□ □ □ □ □ □ □ □ □ □ 
F |□ □ □ □ □ □ □ □ □ □ 
G |□ □ □ □ □ □ □ □ □ □ 
H |□ □ □ □ □ □ □ □ □ □ 
I |□ □ □ □ □ □ □ □ □ □ 
J |□ □ □ □ □ □ □ □ □ □ 

What ship would you like to deploy?    Please below enter any of the following (Carrier; Cruiser; Battleship; Destroyer; Submarine)
```
6. The CLI will then ask you what orientation you would like to place your ship. 
```
Please enter 'V' (vertical) or 'H' (horizontal) to choose the orientation of your ship placement
```
7. You will then get asked to enter coordinates of where you want to place your ship. e.g. E3
```
Please enter coordinates of where you would like to place your ship
```
8. After entering your coordinates the board will render with your ship.
```
Player 1's current board: 
   1 2 3 4 5 6 7 8 9 10 
   ___________________
A |□ □ □ □ □ □ □ □ □ □ 
B |□ □ □ □ □ □ □ □ □ □ 
C |□ □ □ □ □ □ □ □ □ □ 
D |□ □ □ □ □ □ □ □ □ □ 
E |□ □ S S S □ □ □ □ □ 
F |□ □ □ □ □ □ □ □ □ □ 
G |□ □ □ □ □ □ □ □ □ □ 
H |□ □ □ □ □ □ □ □ □ □ 
I |□ □ □ □ □ □ □ □ □ □ 
J |□ □ □ □ □ □ □ □ □ □ 
```
9. You will then be asked to enter a coordinate of where you would like to attack. If you hit the ship the square will mark as ```X``` if you miss the square will be marked as ```M```. Your board will rerender as well as the outcome of your attack above it.
```
Please enter coordinates of where you would like attack
```
If you miss
```
Player 1's current board: You missed!
   1 2 3 4 5 6 7 8 9 10 
   ___________________
A |□ □ □ □ □ □ □ □ □ □ 
B |□ □ □ □ □ □ □ □ □ □ 
C |□ □ □ □ □ □ □ □ □ □ 
D |□ □ □ □ □ □ □ □ □ □ 
E |□ □ S S S □ □ M □ □ 
F |□ □ □ □ □ □ □ □ □ □ 
G |□ □ □ □ □ □ □ □ □ □ 
H |□ □ □ □ □ □ □ □ □ □ 
I |□ □ □ □ □ □ □ □ □ □ 
J |□ □ □ □ □ □ □ □ □ □ 
```
If you hit the ship
```
Player 1's current board: Direct hit!
   1 2 3 4 5 6 7 8 9 10 
   ___________________
A |□ □ □ □ □ □ □ □ □ □ 
B |□ □ □ □ □ □ □ □ □ □ 
C |□ □ □ □ □ □ □ □ □ □ 
D |□ □ □ □ □ □ □ □ □ □ 
E |□ □ S S X □ □ □ □ □ 
F |□ □ □ □ □ □ □ □ □ □ 
G |□ □ □ □ □ □ □ □ □ □ 
H |□ □ □ □ □ □ □ □ □ □ 
I |□ □ □ □ □ □ □ □ □ □ 
J |□ □ □ □ □ □ □ □ □ □ 
```
10. The game will continue until your ship is destroyed. When your ship is destroyed there will be a message stating that you have lost.
```
Player 1's current board: Direct hit!
   1 2 3 4 5 6 7 8 9 10 
   ___________________
A |□ □ □ □ □ □ □ □ □ □ 
B |□ □ □ □ □ □ □ □ □ □ 
C |□ □ □ □ □ □ □ □ □ □ 
D |□ □ □ □ □ □ □ □ □ □ 
E |□ □ X X X □ □ □ □ □ 
F |□ □ □ □ □ □ □ □ □ □ 
G |□ □ □ □ □ □ □ □ □ □ 
H |□ □ □ □ □ □ □ □ □ □ 
I |□ □ □ □ □ □ □ □ □ □ 
J |□ □ □ □ □ □ □ □ □ □ 

Your ship has been sunk, you have lost
 ```
