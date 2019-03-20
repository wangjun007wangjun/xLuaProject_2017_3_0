using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaCallSharp : MonoBehaviour {

    // Use this for initialization
    private LuaEnv luaEnv;
	void Start () {
        luaEnv = new LuaEnv();

        luaEnv.DoString("require 'LuaCallCSharp'");
	}
    

}
