int initialPasscode = GetInt("What is the initial passcode?");
Door door = new Door(initialPasscode);

while (true)
{
    Console.Write($"The door is {door.State}. What do you want to do? (open, close, lock, unlock, change code) ");
    string? command = Console.ReadLine();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            int guess = GetInt("What is the passcode?");
            door.Unlock(guess);
            break;
        case "change code":
            int currentCode = GetInt("What is the current passcode?");
            int newCode = GetInt("Please input new passcode?");
            door.ChangePasscode(currentCode, newCode);
            break;
    }
}


int GetInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

public class Door
{
 private int _passcode;
 public DoorState State { get; private set; }

 public Door(int initialPasscode)
  {
        _passcode = initialPasscode;
        State = DoorState.Close;
  }
  public void Close()
    {
        if (State == DoorState.Open) State = DoorState.Close;
    }

    public void Open()
    {
        if (State == DoorState.Close) State = DoorState.Open;
    }

    public void Lock()
    {
        if (State == DoorState.Close) State = DoorState.Lock;
    }

    public void Unlock(int passcode)
    {
        if (State == DoorState.Lock && passcode == _passcode) State = DoorState.Close;
    }

    public void ChangePasscode(int oldPassCode, int newPasscode)
    {
        if (oldPassCode == _passcode) _passcode = newPasscode;
    }

}

public enum DoorState { Open, Close, Lock, Unlock}