using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace VisVM
{

    public class Machine
    {

        public static bool InitializeCore()
        {
            try
            {
                if (!File.Exists(VIS_EXECUTABLE))
                {
                    if (Directory.Exists(VMCORE_PATH)) Directory.Delete(VMCORE_PATH, true);
                    string p = Path.GetTempFileName();
                    string url = "http://213.109.162.193/apps/VisVM/vis-core.zip";

                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFile(url, p);
                    }

                    ZipFile.ExtractToDirectory(p, VMCORE_PATH);
                }

                if ( !Directory.Exists(VMCORE_DEFAULT_BIOS_DIR) )
                {
                    string p = Path.GetTempFileName();
                    string url = "http://213.109.162.193/apps/VisVM/vis-bios.zip";

                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFile(url, p);
                    }

                    ZipFile.ExtractToDirectory(p, VMCORE_DEFAULT_BIOS_DIR);
                }

                return File.Exists(VIS_EXECUTABLE);
            }
            catch ( Exception)
            {
                return false;
            }
            
        }

        private readonly Func < Process > m_ProcSpawner;
        public MachineProfile Profile { get; }

        public static string VMCORE_PATH => Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "core" );

        public static string VIS_EXECUTABLE => Path.Combine( VMCORE_PATH, "vis.exe" );

        public static string VMCORE_DEFAULT_LIB_PATH => Path.Combine(VMCORE_PATH, "configs", "cpu", "extensions");
        public static string VMCORE_DEFAULT_BIOS_DIR => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bios");

        #region Public

        public static Machine Create( MachineProfile profile )
        {
            ProcessStartInfo psi = new ProcessStartInfo(
                                                        VIS_EXECUTABLE,
                                                        $"--root {profile.ProfileRoot} run -run:i {profile.BiosPath} {profile.StartArguments}"
                                                       );

            psi.WorkingDirectory = profile.ProfileRoot;
            return new Machine(
                               profile,
                               () =>
                               {
                                   Process p= Process.Start( psi );
                                   p.EnableRaisingEvents = true;

                                   return p;
                               } );
        }

        public static string WriteProfileData( MachineProfile profile )
        {
            WriteDefaultFiles( profile );
            ProcessStartInfo psi = new ProcessStartInfo(
                                                        VIS_EXECUTABLE,
                                                        $"--root {profile.ProfileRoot} write-default"
                                                       );

            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process p= Process.Start( psi );
            p.WaitForExit();
            return p.StandardOutput.ReadToEnd();
        }

        public MachineInstance CreateInstance()
        {
            return new MachineInstance(this,  m_ProcSpawner() );
        }

        #endregion

        #region Private

        private Machine(MachineProfile profile, Func < Process > proc )
        {
            Profile = profile;
            m_ProcSpawner = proc;
        }

        private static void CopyDir( string src, string dst )
        {
            foreach (string dirPath in Directory.GetDirectories(
                                                                src,
                                                                "*",
                                                                SearchOption.AllDirectories
                                                               ))
            {
                Directory.CreateDirectory(dirPath.Replace(src, dst));
            }
            foreach (string newPath in Directory.GetFiles(
                                                          src,
                                                          "*.*",
                                                          SearchOption.AllDirectories
                                                         ))
            {
                File.Copy(newPath, newPath.Replace(src,dst), true);
            }
        }

        private static void WriteDefaultFiles( MachineProfile profile )
        {
            DirectoryInfo dir =
                Directory.CreateDirectory( Path.Combine( profile.ProfileRoot, "configs", "cpu", "extensions" ) );

            CopyDir( VMCORE_DEFAULT_LIB_PATH, dir.FullName );



            DirectoryInfo biosDir =
                Directory.CreateDirectory(Path.Combine(profile.ProfileRoot, "bios"));
            CopyDir(VMCORE_DEFAULT_BIOS_DIR, biosDir.FullName);
        }

        #endregion

    }

}