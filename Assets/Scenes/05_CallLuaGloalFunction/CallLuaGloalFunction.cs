using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CallLuaGloalFunction : MonoBehaviour {

    // Use this for initialization
    LuaEnv lua = new LuaEnv();
	void Start () {
        lua.DoString("require 'CallLuaGloalFunction'");
        /*访问Lua中全局函数,Lua中Add函数无形参无返回值*/

        /*Action act1 = lua.Global.Get<Action>("add");
        act1();

        act1 = null;*/


        /*第一种，映射到Delegate*/
        /*访问Lua中全局函数,Lua中Add函数有形参有返回值，定义委托*/
        /*Add add = lua.Global.Get<Add>("add");
        int resa, resb;
        int res=add(22, 11,out resa,out resb);
        print("res:"+res);
        print("resa:"+resa);
        print("resb:"+resb);
        add = null;*/

        /*第二种，映射到LuaFunction，调用慢，耗性能*/
        LuaFunction func = lua.Global.Get<LuaFunction>("add");
        object[] os = func.Call(1, 2);//接收函数的返回值
        foreach(object o in os)
        {
            print(o);
        }

        lua.Dispose();

	}
    /*Lua中add函数有多返回值，可用out或者ref*/
    [CSharpCallLua]
    delegate int Add(int a, int b,out int resa,out int rsb);
}
