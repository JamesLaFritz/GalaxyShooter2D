﻿#region Description

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

using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(BoolReference))]
public class BoolReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferencePropertyDrawer.OnGUI(position, property, label);
    }
}