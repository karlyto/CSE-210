# Hangman
## Description
Hangman is a game in which the player seeks to solve a puzzle
by guessing the letters of a secret word one at a time.
In this program you have to guess the name of a prophet in the book of Mormon to save a man's life from being hanged.

## The Rules
---

It is played according to the following rules.

The puzzle is a secret word randomly chosen from a list.
The player guesses a letter in the puzzle.
If the guess is correct, the letter is revealed.
If the guess is incorrect, a part of the man's body will be added to be filled, starting with the Head.  
+---+
O   |
    |
    |
   ===   
If the puzzle is solved the game is over.
If the the whole body is added, the man is dead hanged, the game is over.
+---+
 O  |
/|\ |
/ \ |
   ===


## Project Structure
---
The project files and folders are organized as follows:
```
root                    (project root folder)
+-- Game                (source code folder)
+-- Program.cs          (program entry point)    
+-- README.md           (general info)
+-- Unit03.csproj       (dotnet project file)
```
## Required Software
---
* dotnet 6.0

## Authors
---
* Carly Jensen Michel (mic21016@byui.edu)