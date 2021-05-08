using System;
using System.IO;
using System.Threading;

using Newtonsoft.Json;

namespace VisVM
{

    public struct MachineProfile
    {

        public static string ProfileDirectory => Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "profiles" );

        public string Name;
        public string ProfileRoot;
        public string StartArguments;
        public string BiosPath;

        public static bool Exists( string name ) => File.Exists( Path.Combine( ProfileDirectory, name + ".json" ) );
        public static MachineProfile GetByName( string name )
        {
            string path = Path.Combine( ProfileDirectory, name + ".json" );
            if ( File.Exists(path ) )
            {
                return JsonConvert.DeserializeObject < MachineProfile >( File.ReadAllText( path ) );
            }

            throw new Exception( "Can not find Profile: " + name );
        }

        public static string Save( MachineProfile profile )
        {
          string log=  Machine.WriteProfileData( profile );
            string path = Path.Combine(ProfileDirectory, profile.Name + ".json");
            Directory.CreateDirectory( ProfileDirectory );
            File.WriteAllText(path, JsonConvert.SerializeObject(profile));

            return log;
        }
    }

}
