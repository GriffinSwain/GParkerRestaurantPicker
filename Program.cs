//Griffin Parker
//October 20. 2022
//Project # 3 - Restaurant Picker

int choice = 0;
int num = 0;
string picked = "";
string pick = "";
string loop = "";
string eyes =    ("          \\_)_|  /`  ._.   ._.  `\\ ");
string eyesEnd = ("          \\_)_|  /`  .O.   .O.  `\\ ");
bool ending = false;
bool repeat = true;
bool like = false;
Random rndNum = new Random();
string [] badRestaurants = {"Applebees", "Olive Garden", "McDonalds", "Burger King", "Del Taco", "Domino's", "Subway", "Your Nearest Greasy Chinese Restaurant", "Denny's", "Mimi's Cafe"};
string [] decentRestaurants = {"In-n-Out", "Wendy's", "Five Guys", "Rubio's", "Your Local Taco Truck", "Taco Bell", "Old Spaghetti Factory", "PizzaHut", "Togo's", "Papa John's"};
string [] goodRestaurants = {"Shadowbrook", "Smack Pie", "Market Tavern", "Papapavlo's", "The Creamery", "Fenton's", "The Dancing Fox", "Michael David Winery", "Prime Table Steakhouse", "Misaki Sushi"};

while (repeat == true)
{
Console.Clear();
ending = false;
like = false;
Console.WriteLine("Hello! I can pick a restaurant for you today!");

while (like == false)
{
Console.WriteLine("What kind of restaurant would you like to go to? A \"bad\", \"decent\", or \"good\" one?");
pick = Console.ReadLine().ToLower();
Console.Clear();

switch (pick)
{
case "bad":
    like = true;
    choice = 1;
    break;
case "decent":
    like = true;
    choice = 2;
    break;
case "good":
    like = true;
    choice = 3;
    break;
default:
    Console.WriteLine("Please put \"bad\", \"decent\", or \"good\"!");
    break;
}
}

num = rndNum.Next(0, 9);

Console.WriteLine("I'm going to determine an establishment for you to eat at \n             ~drum roll please~");
Thread.Sleep(3000);
switch (choice)
{
case 1:
    picked = badRestaurants[num];
    break;
case 2:
    picked = decentRestaurants[num];
    break;
case 3:
    picked = goodRestaurants[num];
    break;
default:
    break;
}

for(int i = 0; i <= 9; i++)
{
    Console.Clear();
    LeftDrum();
    Thread.Sleep(150);
    Console.Clear();
    RightDrum(eyes);
    Thread.Sleep(150);
}
Console.Clear();
RightDrum(eyesEnd);
RestaurantChoice(picked);
Thread.Sleep(4000);
while (ending == false)
{
Console.WriteLine("\nWould you like to play again? \"yes\"? Or \"no\"?");
loop = Console.ReadLine().ToLower();
switch (loop)
{
case "yes":
    ending = true;
    break;
case "no":
    ending = true;
    repeat = false;
    break;
default:
    Console.WriteLine("Please put \"yes\" or \"no\".");
    break;
}
}
}

static void RestaurantChoice(string restaurant)
{
Console.WriteLine($"\n-=~=-=-=~=-=-=~=-=-=~=-={restaurant}-=~=-=-=~=-=-=~=-=-=~=-=");
}

static void LeftDrum()
{
Console.WriteLine("                    _.-===-._");
Console.WriteLine("                   .; `_-.'- .'.     _");
Console.WriteLine("                  /.'\\ ._  '. , \\   (_\\");
Console.WriteLine("                  |.`.-._'- .  '|     \\");
Console.WriteLine("                  |/`    `'--'`\\|     _\\__");
Console.WriteLine("                 /`  .-.   .-.  `\\   / )(_\\");
Console.WriteLine("                 \\_      _      _/   \\' (_|");
Console.WriteLine("                   \\           /     _) (_/");
Console.WriteLine("              __ _ _'._'---'_.'_ _,.'    | \\");
Console.WriteLine("             / __) \\ \\  `\"\"\"`  / / /     /   \\");
Console.WriteLine("             |  __)  \\ \\       / /  |   .'");
Console.WriteLine("              \\___)   \\ \\     / /  _;-'`");
Console.WriteLine("                `|\\    \\ \\   / /  |");
Console.WriteLine("                .;-\\_\"\"```````\"\"--;.");
Console.WriteLine("               /(  \\_)            )\\");
Console.WriteLine("               \\_`'-------------'`_/");
Console.WriteLine("               | `';-----;-----;'` |");
Console.WriteLine("               | / : \\ / : \\ / : \\ |");
Console.WriteLine("               |V.','.V.','.V.','.V|");
Console.WriteLine("               \\`./_\\.;./_\\.;./_\\.`/");
Console.WriteLine("                ';..___________..;'");
 Console.WriteLine("\nUsing the powers of Randomness granted to me by RNGesus, I besto upon you this choice!\n                    You should eat at"); 
}

static void RightDrum(string eyes)
{
Console.WriteLine("                /_)  _.-===-._");
Console.WriteLine("                /  .; `_-.'- .'.     ");
Console.WriteLine("           __ _/  /.'\\ ._  '. , \\ ");
Console.WriteLine("          /\\_( \\  |.`.-._'- .  '|   ");
Console.WriteLine("          |_)  /  |/`    `'--'`\\|  ");
Console.WriteLine($"{eyes}");
Console.WriteLine("          )/  (  \\_      _      _/  ");
Console.WriteLine("          /   /    \\           /   ");
Console.WriteLine("          |   `',_ _'._'---'_.'_ _____");
Console.WriteLine("          \\    /  \\ \\  `\"\"\"`  / / (_  \\");
Console.WriteLine("            \\_.'    \\ \\       / / (__  |");
Console.WriteLine("             `--.,   \\ \\     / /  (___/ ");
Console.WriteLine("                 `|   \\ \\   / /   /|");
Console.WriteLine("                .;--\"\"```` ```\"\"_/-.");
Console.WriteLine("               /(              (_/)\\");
Console.WriteLine("               \\_`'-------------'`_/");
Console.WriteLine("               | `';-----;-----;'` |");
Console.WriteLine("               | / : \\ / : \\ / : \\ |");
Console.WriteLine("               |V.','.V.','.V.','.V|");
Console.WriteLine("               \\`./_\\.;./_\\.;./_\\.`/");
Console.WriteLine("                ';..___________..;'");
Console.WriteLine("\nUsing the powers of Randomness granted to me by RNGesus, I besto upon you this choice!\n                    You should eat at");
}