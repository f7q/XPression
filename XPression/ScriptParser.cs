﻿#region  License
/*
Copyright 2017 - Jaap Lamfers - jlamfers@xipton.net

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 * */
#endregion

using XPression.Core;
using XPression.Language;
using XPression.Language.Syntax;

namespace XPression
{

   public class ScriptParser<TExtender> : Parser
      where TExtender : new()
   {
      public ScriptParser()
         : base(new Grammar(ScriptSyntax<TExtender>.Instance))
      {

      }
      public ScriptParser(bool strict)
         : base(new Grammar(ScriptSyntax<TExtender>.Instance){Strict = strict})
      {

      }
   }
}