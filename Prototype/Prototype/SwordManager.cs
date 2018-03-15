using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class SwordManager
    {
        static SwordManager _instance = null;
        private Dictionary<string, SwordPrototype> _swords = new Dictionary<string, SwordPrototype>();

        private SwordManager(string FileName)
        {
            string FilePath;
            string DeployPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FilePath = Path.Combine(DeployPath, FileName);

            FileStream File = new FileStream(FilePath, FileMode.Open);
            StreamReader sr = new StreamReader(File);
            string f;
            while ((f = sr.ReadLine()) != null){
                string[] Parameters = f.Split(';');
                if (Parameters.Length < 5) continue;
                string Name;
                int Hitpoints;
                double Lenght;
                double Weight;
                string Material;
                double Durability;
                if(string.IsNullOrEmpty(Name = Parameters[0])) continue;
                if(!int.TryParse(Parameters[1], out Hitpoints)) continue;
                if (!double.TryParse(Parameters[2], out Lenght)) continue;
                if (!double.TryParse(Parameters[3], out Weight)) continue;
                Material = Parameters[4];
                if (!double.TryParse(Parameters[3], out Durability)) continue;
                try
                {
                    _swords.Add(Name, new SwordPrototype(Name, Hitpoints, Lenght, Weight, Material, Durability, new Handle()));
                }
                catch (ArgumentException)
                {
                    //log error here
                };
                
            }
            sr.Close();
        }

        public static SwordManager GetManager(string FileName)
        {
            if (_instance == null) _instance = new SwordManager(FileName);
            return _instance;
        }

        public static SwordManager GetManager()
        {
            if (_instance == null) throw new Exception();
            return _instance;
        }

        public SwordPrototype this[string key]
        {
            get
            {
                return _swords[key].Clone<SwordPrototype>();
            }
        }

        public List<string> SwordList()
        {
            return _swords.Keys.ToList<string>();
        }
    }
}
