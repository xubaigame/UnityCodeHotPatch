using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class HotFixManager : MonoBehaviour
{
    private LuaEnv _luaEnv;
    private void Awake()
    {
        _luaEnv = new LuaEnv();
        _luaEnv.AddLoader(CustomLoader);
    }

    private void OnEnable()
    {
        _luaEnv.DoString("require 'fish'");
    }

    private void OnDisable()
    {
        _luaEnv.DoString("require 'fishDispose'");
    }

    private void OnDestroy()
    {
        _luaEnv.Dispose();
    }

    private byte[] CustomLoader(ref string filePath)
    {
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(Application.streamingAssetsPath + "/" + filePath + ".lua"));
    }
}
