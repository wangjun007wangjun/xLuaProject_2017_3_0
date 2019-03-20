using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.IO;
public class CreatLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
       /*第三种执行Lua程序方法，将lua文件放在StreamingAssets中，自定义Loader*/
        LuaEnv luaEnv = new LuaEnv();

        luaEnv.AddLoader(MyLoader);

        luaEnv.DoString("require 'test007'");
        luaEnv.Dispose();
	}
	
    private byte[] MyLoader(ref string filePath)
    {
        string absPath = Application.streamingAssetsPath + "/" + filePath + ".lua.txt";
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
    }
}
