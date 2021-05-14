using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MyText : IReciever
    {
        public int CurrentIndex { get; set; } = 0;
        public List<string> CollectedText { get; set; } = new();
        public void OptionalTaskPriorToRedo()
        {
        }

        public void Print()
        {
            for (int i = 0; i < CurrentIndex; i++)
            {
                Console.Write(CollectedText[i]);
            }

        }

        public void OptionalTaskPriorToUndo()
        {
        }

        public void PerformRedo() => CurrentIndex = CurrentIndex == CollectedText.Count() ? CurrentIndex : ++CurrentIndex;

        public void PerformUndo() => CurrentIndex  = CurrentIndex == 0 ? CurrentIndex : --CurrentIndex;
        

        public void WriteNewLine(string textLine)
        {
            if (CurrentIndex != CollectedText.Count())
            {
                for (int i = CurrentIndex; i < CollectedText.Count(); i++)
                {
                    CollectedText.Remove(CollectedText[i]);
                }
            }
            CollectedText.Add(textLine);
            CurrentIndex++;
        }
    }
}
