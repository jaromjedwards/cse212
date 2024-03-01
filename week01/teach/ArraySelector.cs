public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var newList = new List<int>();
        var index = -1;
        int? value = null;

    foreach (int selector in select)
    {
        index++;

    if (selector == 1)
    {
        value = list1[index];
        newList.Insert(index, value.Value);
    }
    else
    {
        value = list2[index];
        newList.Insert(index, value.Value);
    }
    }
    return newList.ToArray();
}

}