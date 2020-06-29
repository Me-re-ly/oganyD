namespace /*rnd*/DynagoStub/*rnd*/
{

    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    class /*rnd*/cl_Memory/*rnd*/
    {
        /*order-start*/
        /*junk_method*/
        /*order-*/
        public static Process /*rnd*/met_InitializeCSGO/*rnd*/()
        {
            /*junk_line*/
            Process /*rnd*/Process/*rnd*/;
            if (Process.GetProcessesByName("csgo").Length > 0) /*rnd*/Process/*rnd*/ = Process.GetProcessesByName("csgo")[0]; else return null;
            /*junk_line*/
            foreach (ProcessModule /*rnd*/Module/*rnd*/ in /*rnd*/Process/*rnd*/.Modules)
            {
                /*junk_line*/
                string /*rnd*/ModuleName/*rnd*/ = /*rnd*/Module/*rnd*/.ModuleName;

                switch (/*rnd*/ModuleName/*rnd*/)
                {
                    /*order-start*/
                    /*order-*/case "client.dll": /*rnd*/ClientAddress/*rnd*/ = (int)/*rnd*/Module/*rnd*/.BaseAddress; break;/*order-*/
                    /*order-*/case "engine.dll": /*rnd*/EngineAddress/*rnd*/ = (int)/*rnd*/Module/*rnd*/.BaseAddress; break;/*order-*/
                    /*order-*/default:
                        /*junk_line*/
                        break;/*order-*/
                        /*order-end*/
                }
                /*junk_line*/
            }
            /*junk_line*/
            /*rnd*/ProcessHandle/*rnd*/ = (int)OpenProcess(0x8 | 0x10 | 0x20, false, /*rnd*/Process/*rnd*/.Id);
            /*junk_line*/
            if (/*rnd*/ProcessHandle/*rnd*/ > 0 && /*rnd*/ClientAddress/*rnd*/ > 0 && /*rnd*/EngineAddress/*rnd*/ > 0)
                return /*rnd*/Process/*rnd*/;
            else return null;
        }
        /*order-*/

        /*junk_method*/

        /*order-*/public static int /*rnd*/ProcessHandle/*rnd*/ = 0;/*order-*/
        /*order-*/public static int /*rnd*/ClientAddress/*rnd*/ = 0;/*order-*/
        /*order-*/public static int /*rnd*/EngineAddress/*rnd*/ = 0;/*order-*/

        /*order-*/private static int /*rnd*/BytesWritten/*rnd*/ = 0;/*order-*/
        /*order-*/private static int /*rnd*/BytesRead/*rnd*/ = 0;/*order-*/

        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int /*rnd*/Process/*rnd*/, int /*rnd*/Address/*rnd*/, byte[] /*rnd*/Buffer/*rnd*/, int /*rnd*/BufferSize/*rnd*/, ref int /*rnd*/ByteCount/*rnd*/);
        /*order-*/
        /*junk_method*/
        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(int /*rnd*/Process/*rnd*/, int /*rnd*/Address/*rnd*/, byte[] /*rnd*/Buffer/*rnd*/, int /*rnd*/BufferSize/*rnd*/, out int /*rnd*/ByteCount/*rnd*/);
        /*order-*/

        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int /*rnd*/DesiredAccess/*rnd*/, bool /*rnd*/InheritHandle/*rnd*/, int /*rnd*/ProcessID/*rnd*/);
        /*order-*/

        /*order-*/
        public static T /*rnd*/met_ReadMemory/*rnd*/<T>(int /*rnd*/Address/*rnd*/) where T : struct
        {
            int /*rnd*/ByteSize/*rnd*/ = Marshal.SizeOf(typeof(T));
            byte[] /*rnd*/Buffer/*rnd*/ = new byte[/*rnd*/ByteSize/*rnd*/];
            ReadProcessMemory(/*rnd*/ProcessHandle/*rnd*/, /*rnd*/Address/*rnd*/, /*rnd*/Buffer/*rnd*/, /*rnd*/Buffer/*rnd*/.Length, ref /*rnd*/BytesRead/*rnd*/);
            return /*rnd*/met_ByteArrayToStructure/*rnd*/<T>(/*rnd*/Buffer/*rnd*/);
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static void /*rnd*/met_WriteMemory/*rnd*/<T>(int /*rnd*/Address/*rnd*/, object /*rnd*/Value/*rnd*/) where T : struct
        {
            byte[] /*rnd*/Buffer/*rnd*/ = /*rnd*/met_StructureToByteArray/*rnd*/(/*rnd*/Value/*rnd*/);
            WriteProcessMemory(/*rnd*/ProcessHandle/*rnd*/, /*rnd*/Address/*rnd*/, /*rnd*/Buffer/*rnd*/, /*rnd*/Buffer/*rnd*/.Length, out /*rnd*/BytesWritten/*rnd*/);
        }
        /*order-*/

        /*order-*/
        private static T /*rnd*/met_ByteArrayToStructure/*rnd*/<T>(byte[] /*rnd*/Bytes/*rnd*/) where T : struct
        {
            GCHandle /*rnd*/Handle/*rnd*/ = GCHandle.Alloc(/*rnd*/Bytes/*rnd*/, GCHandleType.Pinned);
            try { return (T)Marshal.PtrToStructure(/*rnd*/Handle/*rnd*/.AddrOfPinnedObject(), typeof(T)); }
            finally { /*rnd*/Handle/*rnd*/.Free(); }
        }
        /*order-*/

        /*order-*/
        private static byte[] /*rnd*/met_StructureToByteArray/*rnd*/(object /*rnd*/Object/*rnd*/)
        {
            int /*rnd*/Length/*rnd*/ = Marshal.SizeOf(/*rnd*/Object/*rnd*/);
            byte[] /*rnd*/Array/*rnd*/ = new byte[/*rnd*/Length/*rnd*/];
            IntPtr /*rnd*/Pointer/*rnd*/ =
                Marshal.AllocHGlobal(/*rnd*/Length/*rnd*/);
            Marshal.StructureToPtr(/*rnd*/Object/*rnd*/, /*rnd*/Pointer/*rnd*/, true);
            Marshal.Copy(/*rnd*/Pointer/*rnd*/, /*rnd*/Array/*rnd*/, 0, /*rnd*/Length/*rnd*/);
            Marshal.FreeHGlobal(/*rnd*/Pointer/*rnd*/);
            return /*rnd*/Array/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-end*/
    }
}