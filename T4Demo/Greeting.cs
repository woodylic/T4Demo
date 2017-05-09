 

// Generated from template
// DO NOT change manually

using System;
using System.Collections.Generic;

namespace T4Ddemo.Entity
{
	class Greeting
	{
		public static Dictionary<String, String> GetGlobalGreetings()
        {
            var result = new Dictionary<String, String>();			
            result.Add("en-US", "Good morning!");
            result.Add("zh-CN", "早上好！");
            return result;
        }
	}
}

