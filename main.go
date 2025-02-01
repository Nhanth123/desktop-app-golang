package main

import (
	"fmt"
	"myapp/doctor"
)

func main() {
	var whatToSay string
	whatToSay = doctor.Intro()
	fmt.Println("What to say:", whatToSay)
}

func sayHello(s string) {
	fmt.Println(s)
}
