namespace Sasw.TestSupport
{
    using System;

    public static class GuidGenerator
    {
        public static Guid Create(int number)
        {
            var bytes = new byte[16];
            BitConverter.GetBytes(number).CopyTo(bytes, 0);
            var guid = new Guid(bytes);
            return guid;
        }
    }
}