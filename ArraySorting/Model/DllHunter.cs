using ISorterNamespace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ArraySorting
{
    static public class DllHunter
    {
        static public List<ISorter> FindSorters()
        {
            List<ISorter> sorters = new List<ISorter>();

            string[] dllFiles = Directory.GetFiles(".\\DLLs\\", "*.dll");

            foreach (string dllFile in dllFiles)
            {
                Assembly assembly = Assembly.LoadFile(Path.GetFullPath(dllFile));
                foreach (Type item in assembly.GetTypes())
                {
                    if (!item.IsClass) continue;
                    if (item.GetInterfaces().Contains(typeof(ISorter)))
                    {
                        sorters.Add((ISorter)Activator.CreateInstance(item));
                        if (sorters.Count == 9)
                        {
                            return sorters;
                        }
                    }
                }
            }
            
            return sorters;
        }
        
    }
}
