string svar1;
string svar2;
string svar3;
string svar4;
string svar5;
string svar6;
string name1;
string name2;
int P1 = 0;
int P2 = 0;

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("Hello! And welcome to the annual quizgame of ET! What is your name Player 1?");

Console.BackgroundColor = ConsoleColor.Red;
name1 = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("And what is your name player 2?");

Console.BackgroundColor = ConsoleColor.Red;
name2 = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Welcome {name1} and {name2}!");

Console.WriteLine("Okay! First question of the day, What is the capital of Sweden? is it A) Stockholm, is it B) Helsinki, or is it C) Oslo");
Console.WriteLine($"{name1} first please");

Console.BackgroundColor = ConsoleColor.Red;
svar1 = Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"And {name2}?");

Console.BackgroundColor = ConsoleColor.Red;
svar2 = Console.ReadLine();

if((svar1 == "Stockholm" || svar1 == "stockholm" || svar1 == "a" || svar1 == "A") && (svar2 == "Stockholm" || svar2 == "stockholm" || svar2 == "a" || svar2 == "A")){
 Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Congratulations {name1} and {name2}, you were both correct!");
P1 = P1+1;
P2 = P2+1;
}

if((svar1 == "Stockholm" || svar1 == "stockholm" || svar1 == "a" || svar1 == "A") && (svar2 == "Stockholm" || svar2 == "stockholm" || svar2 == "a" || svar2 == "A") == false){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name1}, You were correct, unfortunatly for you {name2}, you were not");
P1 = P1+1;
}

if((svar1 == "Stockholm" || svar1 == "stockholm" || svar1 == "a" || svar1 == "A") == false && (svar2 == "Stockholm" || svar2 == "stockholm" || svar2 == "a" || svar2 == "A")){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name2}, You were correct, unfortunatly for you {name1}, you were not.");
P2 = P2+1;
}

Console.WriteLine($"{name1}, you have {P1} points and {name2} you have {P2} points!");
Console.ReadLine();
Console.WriteLine($"Okay! Now to question 2, Contrary to popular believes of the size of the famous painting Mona Lisa, how wide is the painting? is it A) 1,23m, is it B) 3,5m, or is it C) 53cm? {name1}?");

 Console.BackgroundColor = ConsoleColor.Red;
svar3 = Console.ReadLine();

 Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"and {name2}?");

 Console.BackgroundColor = ConsoleColor.Red;
 svar4 = Console.ReadLine();

if((svar3 == "53 cm" || svar3 == "53cm" || svar3 == "c" || svar3 == "C") && (svar4 == "53 cm" || svar4 == "53cm" || svar4 == "c" || svar4 == "C")){
 Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Congratulations {name1} and {name2}, you were both correct!");
P1 = P1+1;
P2 = P2+1;
}

if((svar3 == "53 cm" || svar3 == "53cm" || svar3 == "c" || svar3 == "C") && (svar4 == "53 cm" || svar4 == "53cm" || svar4 == "c" || svar4 == "C") == false){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name1}, You were correct, unfortunatly for you {name2}, you were not");
P1 = P1+1;
}

if((svar3 == "53 cm" || svar3 == "53cm" || svar3 == "c" || svar3 == "C") == false && (svar4 == "53 cm" || svar4 == "53cm" || svar4 == "c" || svar4 == "C")){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name2}, You were correct, unfortunatly for you {name1}, you were not.");
P2 = P2+1;
}

Console.WriteLine($"{name1}, you have {P1} points and {name2} you have {P2} points!");
Console.WriteLine($"Onto the 3rd question. What year was the first google search? is it a) 1987, is it B) 1998, or is it C) 2001? {name1}?");

 Console.BackgroundColor = ConsoleColor.Red;
svar5 = Console.ReadLine();

 Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"and {name2}?");

 Console.BackgroundColor = ConsoleColor.Red;
 svar6 = Console.ReadLine();

if((svar5 == "1998" || svar5 == "98" || svar5 == "b" || svar5 == "B") && (svar6 == "98" || svar6 == "1998" || svar6 == "b" || svar6 == "B")){
 Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Congratulations {name1} and {name2}, you were both correct!");
P1 = P1+1;
P2 = P2+1;
}

if((svar5 == "1998" || svar5 == "98" || svar5 == "b" || svar5 == "B") && (svar6 == "98" || svar6 == "1998" || svar6 == "b" || svar6 == "B") == false){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name1}, You were correct, unfortunatly for you {name2}, you were not");
P1 = P1+1;
}

if((svar5 == "1998" || svar5 == "98" || svar5 == "b" || svar5 == "B") == false && (svar6 == "98" || svar6 == "1998" || svar6 == "b" || svar6 == "B")){
 Console.BackgroundColor = ConsoleColor.Blue;
 Console.WriteLine($"Congratulations {name2}, You were correct, unfortunatly for you {name1}, you were not.");
P2 = P2+1;
}

Console.WriteLine($"{name1}, you have {P1} points and {name2} you have {P2} points!");

Console.WriteLine("Well, that was all the questions for today, thank you guys for playing, now, lets see the winner!");

Console.ReadLine();
if (P1 > P2){
Console.WriteLine($"{name2} you have {P2} points and {name1} you have {P1} points, Congratulations {name1}! You won!");
}

if (P2 > P1){
Console.WriteLine($"{name2} you have {P2} points and {name1} you have {P1} points, Congratulations {name2}! You won!");
}

if (P1 == P2){
Console.WriteLine($"{name2} you have {P2} points and {name1} you have {P1} points, It Seems like the game ends in a tie!");
}

Console.ReadLine();