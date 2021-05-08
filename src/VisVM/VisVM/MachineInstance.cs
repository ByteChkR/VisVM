using System;
using System.Diagnostics;

namespace VisVM
{

    public class MachineInstance
    {

        public event Action OnMachineExit;
        private Process m_Process;
        public MachineProfile Profile=> Machine.Profile;
        public Machine Machine { get; }

        public int PID => m_Process.Id;
        public bool IsRunning => !m_Process.HasExited;

        public string GetConsoleOutput() =>
            m_Process.StartInfo.RedirectStandardOutput ? m_Process.StandardOutput.ReadToEnd() : "No Output";

        #region Public

        public MachineInstance(Machine machine, Process proc )
        {
            Machine = machine;
            m_Process = proc;
            m_Process.Exited += M_Process_Exited;
        }

        private void M_Process_Exited(object sender, EventArgs e)
        {
            OnMachineExit?.Invoke();
        }

        public void ForceShutdown()
        {
            m_Process.Kill();
            m_Process.WaitForExit();
        }

        public MachineInstance SoftRestart()
        {
            if(IsRunning)
            ForceShutdown();
            return Machine.CreateInstance();
        }

        public MachineInstance HardRestart()
        {
            if (IsRunning)
                ForceShutdown();
            return Machine.Create( Profile ).CreateInstance();
        }

        #endregion

    }

}