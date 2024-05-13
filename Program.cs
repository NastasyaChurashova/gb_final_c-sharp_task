﻿string[] CreateLessThanThreeCharStringArray(string[] charArray)
{
    int count = 0;
    for (int i = 0; i < charArray.Length; i++)
    {
        if (charArray[i].Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int index = 0;

    if (count == 0)
    {
        return new string[0];
    }

    foreach (string s in charArray)
    {
        if (s.Length <= 3)
        {
            result[index++] = s;
        }
    }
    return result;
}
