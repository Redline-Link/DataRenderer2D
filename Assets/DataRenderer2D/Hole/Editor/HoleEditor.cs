﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UI;

namespace geniikw.DataRenderer2D.Hole
{
    [CustomEditor(typeof(UIHole), true)]
    public class HoleEditor : ImageEditor
    {
        SerializedProperty m_holeInfo;
        
        protected override void OnEnable()
        {
            base.OnEnable();
            m_holeInfo = serializedObject.FindProperty("hole");
        }


        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(m_holeInfo,true);
            serializedObject.ApplyModifiedProperties();
            base.OnInspectorGUI();
        }
    }
}
#endif