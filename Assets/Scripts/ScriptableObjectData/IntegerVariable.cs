using System;
using UnityEngine;
/// <summary>
/// Represents any integer variable.
/// <para>Fires Increased, Decreased and Changed events, when value is changed.</para>
/// <para>Can be used as System.Int32</para>
/// </summary>
[CreateAssetMenu(fileName = "IntegerVariable", menuName = "ScriptabelObjects/IntegerVariable", order = 0)]
public class IntegerVariable : ScriptableObject
{
    /// <summary>
    /// Fired when the value increses.
    /// </summary>
    public event Action Increased;
    /// <summary>
    /// Fired when the value decreses.
    /// </summary>
    public event Action Decreased;
    /// <summary>
    /// Fired when the value changes.
    /// </summary>
    public event Action Changed;
    [SerializeField] private int DefaultValue = 0;
    /// <summary>
    /// Value of this variable. Access through property.
    /// </summary>
    private int variableValue;
    private int Value
    {
        get => variableValue;
        set
        {
            if (value > variableValue)
            {
                Increased?.Invoke();
            }
            else if (value < variableValue)
            {
                Decreased?.Invoke();
            }
            variableValue = value >= 0 ? value : 0;
            Changed?.Invoke();
        }
    }
    /// <summary>
    /// Resets value to DefaultValue.
    /// </summary>
    public void ResetValue() => variableValue = DefaultValue;
    public static implicit operator int (IntegerVariable integerVariable) => integerVariable.Value;
    //немного запутанно, по крайней мере мне так кажется.
    //для корректной работы операторы должены вернуть ссылку на одного из своих операндов, то есть на конкретный экземпляр scriptableObject.
    //в результате  работает так, как ожидаешь от простой переменной. 
    #region + Operator overloads
    public static IntegerVariable operator +(IntegerVariable integerVariable, int number) 
    {
        integerVariable.Value += number;
        return integerVariable;
    }
    public static IntegerVariable operator +(int number, IntegerVariable scriptableObject) => scriptableObject + number;
    #endregion
    #region - Operator overloads
    public static IntegerVariable operator -(IntegerVariable integerVariable, int number)
    {
        integerVariable.Value -= number;
        return integerVariable;
    }
    public static IntegerVariable operator -(int number, IntegerVariable integerVariable)
    {
        integerVariable.Value = number - integerVariable.Value;
        return integerVariable;
    }
    #endregion
    #region Decrement and Increment operator overloads
    public static IntegerVariable operator --(IntegerVariable integerVariable)
    {
        integerVariable.Value--;
        return integerVariable;
    }
    public static IntegerVariable operator ++(IntegerVariable integerVariable)
    {
        integerVariable.Value++;
        return integerVariable;
    }
    #endregion
    public override string ToString() => variableValue.ToString();
}

