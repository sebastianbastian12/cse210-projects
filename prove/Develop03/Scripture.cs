using System;

public class Scripture {
    Reference _reference;
    public List<Word> _words = new List<Word>();
    int _listCount;

    public Scripture(Reference Reference, string text)

    {
        _reference = Reference;

         string[] words = text.Split(' ');
         foreach (var word in words)
         {
            _words.Add(new Word(word));
         }

        _listCount = _words.Count;
    }

    public void HideRandomWords(int numberToHide)
    {
            Random randomWord = new Random();
            int range = Math.Min(numberToHide, _listCount);

            for (int i = 0; i < range; i++)
            {
                int _randomIndex = randomWord.Next(0, _words.Count);
                _words[_randomIndex].Hide();
            }
    }


    public string GetDisplayString()
    {
        string scripture = $"{_reference.GetDisplayText()}\n";
        foreach (var word in _words)
        {
            scripture+= word.GetDisplayText() + " ";
        }
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
      foreach (var word in _words)
        {
            if(!word.IsHidden()){
                   return false;
            }  
        }

        return true;    
    }

}