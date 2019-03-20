using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class HelloWorld01 : MonoBehaviour {

    // Use this for initialization
    private LuaEnv luaEnv;
	void Start () {
        luaEnv = new LuaEnv();
        luaEnv.DoString("print('Hello world!')");

        luaEnv.DoString("CS.UnityEngine.Debug.Log('111')");
	}
	
	// Update is called once per frame
	void OnDestroy () {
        luaEnv.Dispose();
	}
}
