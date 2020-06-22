using System;
using System.IO;
using ETModel;
using UnityEditor;

namespace ETEditor
{
    [InitializeOnLoad]
    public class Startup
    {
        private const string ScriptAssembliesDir = "Library/ScriptAssemblies";
        private const string CodeDir = "Assets/Res/Code/";

        private const string HotfixDll = "Unity.Hotfix.dll";
        private const string HotfixPdb = "Unity.Hotfix.pdb";

        private const string Hot2Dll = "Unity.Hot2.dll";
        private const string Hot2Pdb = "Unity.Hot2.pdb";

        static Startup()
        {
            File.Copy(Path.Combine(ScriptAssembliesDir, HotfixDll), Path.Combine(CodeDir, "Hotfix.dll.bytes"), true);
            File.Copy(Path.Combine(ScriptAssembliesDir, HotfixPdb), Path.Combine(CodeDir, "Hotfix.pdb.bytes"), true);

            File.Copy(Path.Combine(ScriptAssembliesDir, Hot2Dll), Path.Combine(CodeDir, "Hot2.dll.bytes"), true);
            File.Copy(Path.Combine(ScriptAssembliesDir, Hot2Pdb), Path.Combine(CodeDir, "Hot2.pdb.bytes"), true);

            Log.Info($"复制Hotfix.dll, Hotfix.pdb到Res/Code完成");
            Log.Info($"复制Hot2.dll, Hot2.pdb到Res/Code完成");
            AssetDatabase.Refresh ();
        }
    }
}