var possibleWords = File.ReadAllLines(@"D:\Desktop\usFiveLetterWords.txt");
var finalWordList = new List<string>();
var counter = 0;
char[] inputLetters = new char[21];

for (int i = 0; i < inputLetters.Length; i++)
{
    inputLetters[i] = Console.ReadLine()[0];
}

foreach (var word in possibleWords)
{
    for (int i = 0; i < inputLetters.Length; i++)
    {
        var inputChar = inputLetters.ElementAt(i);

        for (int j = 0; j < word.Length; j++)
        {
            var wordChar = word.ElementAt(j);

            if (wordChar.Equals(inputChar))
            {
                counter++;
            }
        }
    }

    if (counter == 5)
    {
        finalWordList.Add(word);
    }

    else
    {
        counter = 0;
    }
}

foreach (var word in finalWordList)
{
    Console.WriteLine(word);
}