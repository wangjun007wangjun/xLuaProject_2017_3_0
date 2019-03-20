using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CSharpCallLua : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LuaEnv lua = new LuaEnv();

        lua.DoString("require 'CSharpCallLua'");

        /*获取全局变量*/
        /*int a=lua.Global.Get<int>("a");//获取CSharpCallLua文件中的a变量
        print(a);
        string s=lua.Global.Get<string>("str");//获取CSharpCallLua文件中的str变量
        print(s);
        bool b=lua.Global.Get<bool>("isDie");//获取CSharpCallLua文件中的isDie变量
        print(b);*/

        /*一、获取表(C#访问lua中表第一种方式)，定义一个与之对应的类(值传递，耗费性能，并且不能修改lua文件中的值)*/
        /*Person p=lua.Global.Get<Person>("person");
        print(p.name+"-"+p.age);
        p.eat();*/

        /*二、获取表(C#访问lua中表第二种方式)，定义一个与之对应的接口*/
        /*IPerson p = lua.Global.Get<IPerson>("person");
        print(p.name + "-" + p.age);
        p.eat(1, 2);
        p.name = "wangjun22";//能修改
       
        lua.DoString("print(person.name)");
        */

        /*三、获取表(C#访问lua中表第三种方式)，通过Dictionary，List*/
        /*Dictionary<string, object> dict = lua.Global.Get<Dictionary<string, object>>("person");
        foreach(string v in dict.Keys)
        {
            print(v + "-" + dict[v]);
        }*/
        /*
        List<object> list = lua.Global.Get<List<object>>("person");
        foreach (object o in list)
        {
            print(o);
        }*/

        /*四、获取表(C#访问lua中表第四种方式)，通过LuaTable,不用创建类或者接口*/
        LuaTable tab = lua.Global.Get<LuaTable>("person");
        print(tab.Get<string>("name"));
        print(tab.Get<int>("age"));

        lua.Dispose();
	}
	
    class Person
    {
        public string name;
        public int age;
    }

    [CSharpCallLua]
    interface IPerson
    {
        string name { get; set; }
        int age { get; set; }
        void eat(int a,int b);
    }
}
