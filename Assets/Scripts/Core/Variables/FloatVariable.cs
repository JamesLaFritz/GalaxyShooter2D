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


[CreateAssetMenu(fileName = "Float", menuName = "Variable/Float", order = 0)]
public class FloatVariable : VariableBase<float>
{
    #region Overrides of VariableBase<float>

    /// <inheritdoc />
    public override void Add(float amount) => variableValue += amount;

    /// <inheritdoc />
    public override void Add(VariableBase<float> amount) => variableValue += amount.Value;

    #endregion
}