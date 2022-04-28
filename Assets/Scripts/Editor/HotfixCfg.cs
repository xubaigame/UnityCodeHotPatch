//如果涉及到Assembly-CSharp.dll之外的其它dll，如下代码需要放到Editor目录

using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using XLuaTest;

public static class HotfixCfg
{
    [Hotfix]
    public static List<Type> by_hotfix = new List<Type>()
    {
        typeof(GameObject),
        typeof(Treasour),
        typeof(Gun),
        typeof(Ice),
        typeof(Fire),
        typeof(ButterFly),
        typeof(Boss),
        typeof(DeffendBoss),
        typeof(InvisibleBoss),
        typeof(CreateFish),
        typeof(Fish),
        typeof(GunImage)
    };
    
    [LuaCallCSharp]
    public static List<Type> by_luacallsharp = new List<Type>()
    {
        typeof(Gun),
        typeof(Boss),
        typeof(DeffendBoss),
        typeof(InvisibleBoss)
    };
    
}