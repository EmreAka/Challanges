package main

import (
	"fmt"
	"math/rand"
	"time"
)

func main() {
	myGame()
}

func myGame() {
	fmt.Println("Welcome to my number guess game!")
	userInput := 0
	rand.Seed(time.Now().UnixNano())
	var numberToGuess = rand.Intn(100)

	for i := 0; i < 5; i++ {
		fmt.Print("Enter number: ")
		fmt.Scan(&userInput)
		if userInput > numberToGuess {
			fmt.Println("-Your guess is higher than the answer.")
		} else if numberToGuess > userInput {
			fmt.Println("-Your guess is lower than the answer.")
		} else {
			fmt.Println("Congratulations!")
			break
		}
	}
	fmt.Println("Number was: ", numberToGuess)
}
