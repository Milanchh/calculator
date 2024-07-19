let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredNames: string list = List.filter (fun name -> name.IndexOf("i", System.StringComparison.OrdinalIgnoreCase) >= 0) names
let concatenatedNames: string = List.fold (fun acc name -> acc + name) "" filteredNames

printfn "Concatenated names containing 'i': %s" concatenatedNames

// Create a sequence of the first 700 positive integers
let sequence = seq { 1 .. 700 }

// Convert the sequence to a list
let numberList = Seq.toList sequence

// Filter the list to keep only elements that are multiples of both 7 and 5
let filteredList = List.filter (fun x -> x % 7 = 0 && x % 5 = 0) numberList

let sumOfFilteredNumbers = List.fold (+) 0 filteredList


printfn "Filtered List: %A" filteredList
printfn "The sum of all numbers that are multiples of both 7 and 5 is %d" sumOfFilteredNumbers


let trimTheGivenSpace (givenList: string list) =
    givenList |> List.map (fun x -> x.Trim())


let list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]


let trimmedNames = trimTheGivenSpace list


trimmedNames |> List.iter (printfn "%s")

let productOfOdd (n: int) =
    // Define the tail-recursive helper function
    let rec helper (current: int) (acc: int) =
        if current < 1 then
            acc
        else
            helper (current - 2) (acc * current)
    
    // Call the helper function starting with the given number and initial accumulator value of 1
    helper n 1

// Test the function with the number 11
let result = productOfOdd 11
printfn "The product of all odd numbers from 11 to 1 is %d" result
let rec printList lst =
    match lst with
    | [] -> ()
    | head :: tail ->
        printfn "%A" head
        printList tail

let listOfFootballPlayers = ["Lionel Messi"; "Cristiano Ronaldo"; "Neymar"; "Kylian Mbappe"; "Kevin De Bruyne"]
printList listOfFootballPlayers

