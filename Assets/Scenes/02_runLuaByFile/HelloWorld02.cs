using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        /*第一种加载*/
        /*TextAsset ta = Resources.Load<TextAsset>("helloworld.lua");//加载helloworld.lua.txt
       // print(ta);

        LuaEnv luaEnv = new LuaEnv();
        luaEnv.DoString(ta.ToString());
        */

        /*第二种加载*/
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.DoString("require 'helloworld'");//找到Resources中的helloworld.lua.txt
        luaEnv.Dispose();
	}
	

}
