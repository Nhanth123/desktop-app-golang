package main

import (
	"bufio"
	"fmt"
	"myapp/doctor"
	"os"
	"strings"
)

func main() {
	reader := bufio.NewReader(os.Stdin)
	whatToSay := doctor.Intro()
	fmt.Println("What to say:", whatToSay)

	for {
		userInput, _ := reader.ReadString('\n')
		userInput = strings.Replace(userInput, "\r\n", "", -1)
		userInput = strings.Replace(userInput, "\n", "", -1)
		response := doctor.Response(userInput)

		if userInput == "exit" || response == "quit" {
			break
		} else {
			fmt.Println(doctor.Response(userInput))
		}

		fmt.Println(response)
	}
}
