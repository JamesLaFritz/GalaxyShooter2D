#region Description

// 03-05-2021
// James LaFritz
// ----------------------------------------------------------------------------
// Based on
//
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

#endregion

using UnityEngine;


[CreateAssetMenu(fileName = "StringVariable", menuName = "Variable/String")]
public class StringVariable : VariableBase<string>
{
    #region Overrides of VariableBase<string>

    /// <inheritdoc />
    public override void Add(string amount) => variableValue += amount;

    /// <inheritdoc />
    public override void Add(VariableBase<string> amount) => variableValue += amount.Value;

    #endregion

}