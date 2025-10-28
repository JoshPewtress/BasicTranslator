using BasicTranslator;

do
{
	SelectDictionary();
}
while (ConfirmContinue());

void SelectDictionary()
{
	FrenchDictionary fd = new();
	SpanishDictionary sd = new();

	Console.Write(
		$"""
		Select a language to translate too.
		1 - French
		2 - Spanish
		Make selection: 
		""");
	var selection = Console.ReadLine() ?? "";

	switch (selection)
	{
		case "1":
			fd.Translate(UserInput());
			break;
        case "2":
            sd.Translate(UserInput());
            break;
        default:
            Console.WriteLine($"\"{selection}\" was not a valid selection.");
			break;
	}
}

string UserInput()
{
	Console.Write("Enter a sentence to translate: ");
	return Console.ReadLine() ?? "";
}

bool ConfirmContinue()
{
	Console.WriteLine();
    Console.Write("Translate again (Y\\N): ");
	var response = Console.ReadLine();

    if (response.Trim().ToUpper() == "Y")
    {
		return true;
    }

	return false;
}