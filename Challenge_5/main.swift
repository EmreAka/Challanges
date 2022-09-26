let question = "Guess the number: "
let randomInt = Int.random(in: 1..<30)
for _ in 0..<5{
  print(question)
  let myIntegerVariable = Int(readLine()!) ?? 0 
  if(myIntegerVariable < randomInt){
    print("You're guess is lower than the answer!")
  }
  else if(myIntegerVariable > randomInt){
    print("You're guess is higher than the answer!")
  }
  else {
    print("Congratulations!")
    break
  }
}

print("You're lost!")