/// <summary>
/// EnemyCreator requires specific format of spawn chances array to work correctly.
/// Summ of all of its values should be 100.
/// This class converts any given int[] to required format.
/// </summary>
public static class PercentageCalculator
{
    /// <summary>
    /// Converts values of the provided array so that summ of all their values would be 100.
    /// </summary>
    /// <returns>Returns new int[].</returns>
    public static int[] ToPercents(int[] input)
    {
        //Вычисление множителя.
        int summ = 0;
        foreach (int item in input)
        {
            summ += item;
        }
        int multiplier = summ == 0 ? 0 : 100 / summ;
        //Приведение массива к требуемому формату.
        int[] result = new int[input.Length];
        summ = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = input[i] * multiplier;
            summ += result[i];
        }
        if (summ == 0)
        {
            return result;
        }
        else if (summ < 100)
        {
            int delta = 100 - summ;
            result[0] += delta;
        }
        return result;
    }
}
