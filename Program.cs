string[] CreateLessThanThreeCharStringArray(string[] charArray)
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

    return result;
}
