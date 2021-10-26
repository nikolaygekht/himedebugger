using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Hime.SDK.Reflection;

namespace himedbg
{
    class AssemblyReflectionEx : AssemblyReflection
    {
        public AssemblyReflectionEx(Assembly assembly) : base(assembly)
        {

        }

        public AssemblyReflectionEx(string fileName) : base(Assembly.Load(File.ReadAllBytes(fileName)))
        {

        }
    }
}
