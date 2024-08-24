
ChestState currentState = ChestState.Locked;

do
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    string userState = Console.ReadLine().ToLower();

    if ( currentState == ChestState.Locked && userState == "unlock") {currentState = ChestState.Unlocked; }
    if ( currentState == ChestState.Unlocked && userState == "open") {currentState = ChestState.Open; }
    if ( currentState == ChestState.Closed && userState == "open") { currentState = ChestState.Open; }
    if ( currentState == ChestState.Open &&  userState == "close") { currentState = ChestState.Unlocked; }
    if( currentState == ChestState.Unlocked && userState == "lock") { currentState = ChestState.Locked; }


} while (true);

enum ChestState { Open, Locked, Closed, Unlocked }