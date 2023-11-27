using System.Collections.Generic;

public interface ICaptionDataParser
{
    Queue<Caption> Parse(string pathToFile); // cambiar a matriz
}
