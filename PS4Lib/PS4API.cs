namespace PS4Lib
{
    /// <summary>
    /// Represent the PS4API functions 
    /// </summary>
    public class PS4API
    {

        private Extension _extension;
        /// <summary>
        /// Extension methods for more bytes operation
        /// </summary>
        public Extension Extension
        {
            get { return _extension ?? (_extension = new Extension(this)); }
        }
        /// <summary>
        /// Connect to PS4 on your LAN
        /// </summary>
        /// <param name="ip">PS4 ip address</param>
        /// <returns></returns>
        public bool ConnectTarget(string ip)
        {
            return API.Connect(ip);
        }
        /// <summary>
        /// Check whether your PS4 is connected
        /// </summary>
        public bool IsConnected
        {
            get { return API.IsConnected(); }
        }
        /// <summary>
        /// Disconnect from PS4
        /// </summary>
        public void DisconnectTarget()
        {
            API.Disconnect();
        }
        /// <summary>
        /// Attach to current game process
        /// </summary>
        public bool AttachProcess()
        {
            return API.Attach();
        }
        /// <summary>
        /// Detach the current game process
        /// </summary>
        public bool DetachProcess()
        {
            return API.Detach();
        }
        /// <summary>
        /// Continue the current game process
        /// </summary>
        public bool Continue()
        {
            return API.Continue();
        }
        /// <summary>
        /// Suspend the current process
        /// </summary>
        public bool Suspend()
        {
            return API.Suspend();
        }
        /// <summary>
        /// Resume the current process
        /// </summary>
        public bool Resume()
        {
            return API.Resume();
        }
        /// <summary>
        /// Get memory from the attached process
        /// </summary>
        /// <param name="address">64Bits address</param>
        /// <param name="buffer">place to hold output buffer</param>
        public bool GetMemory(ulong address, ref byte[] buffer)
        {
            return API.ReadMemory(address, ref buffer);
        }
        /// <summary>
        /// Get bytes from the attached process
        /// </summary>
        /// <param name="address">64Bits address</param>
        /// <param name="length">length of bytes to read</param>
        public byte[] GetBytes(ulong address, int length)
        {
            return API.GetBytes(address, length);
        }
        /// <summary>
        /// Set memory into attached process
        /// </summary>
        /// <param name="address">64Bits address</param>
        /// <param name="buffer">input data</param>
        /// <param name="length">length to write</param>
        public bool SetMemory(ulong address, byte[] buffer, int length)
        {
            return API.WriteMemory(address, buffer, length);
        }
        /// <summary>
        /// Set memory into attached process
        /// </summary>
        /// <param name="address">64Bits address</param>
        /// <param name="buffer">input data</param>
        public bool SetMemory(ulong address, byte[] buffer)
        {
            return API.WriteMemory(address, buffer, buffer.Length);
        }
        /// <summary>
        /// Show notification with text
        /// </summary>
        public void Notify(int notificationType, string text)
        {
            API.Notify(notificationType, text);
        }
    }
}
