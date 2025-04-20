using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Unity.UOS.Launcher
{
    public class DefineSymbols
    {
        public static void Add(BuildTargetGroup target, string defineSymbol)
        {
            string currentDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(target);

            HashSet<string> defines = new HashSet<string>(currentDefines.Split(';'));
            if (defines.Contains(defineSymbol)) return;
            defines.Add(defineSymbol);
            
            string newDefines = string.Join(";", defines);
            if (newDefines != currentDefines)
            {
                PlayerSettings.SetScriptingDefineSymbolsForGroup(target, newDefines);
            }
        }
        
        public static void Remove(BuildTargetGroup target, string defineSymbol)
        {
            string currentDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(target);

            HashSet<string> defines = new HashSet<string>(currentDefines.Split(';'));
            if (!defines.Contains(defineSymbol)) return;
            defines.Remove(defineSymbol);
            
            string newDefines = string.Join(";", defines);
            if (newDefines != currentDefines)
            {
                PlayerSettings.SetScriptingDefineSymbolsForGroup(target, newDefines);
            }
        }
    }
}