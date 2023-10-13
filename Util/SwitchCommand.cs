using SysBot.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SYS_AutoUpdater
{
    public static class SwitchCommand
    {
        private static readonly Encoding Encoder = Encoding.ASCII;

        private static byte[] Encode(string command, bool crlf = true)
        {
            if (crlf)
                command += "\r\n";
            return Encoder.GetBytes(command);
        }

        public static byte[] DetachController(bool crlf = true) => Encode("detachController", crlf);
        public static byte[] Click(SwitchButton button, bool crlf = true) => Encode($"click {button}", crlf);
        public static byte[] Hold(SwitchButton button, bool crlf = true) => Encode($"press {button}", crlf);
        public static byte[] Release(SwitchButton button, bool crlf = true) => Encode($"release {button}", crlf);
        public static byte[] SetStick(SwitchStick stick, short x, short y, bool crlf = true) => Encode($"setStick {stick} {x} {y}", crlf);
        public static byte[] ResetStick(SwitchStick stick, bool crlf = true) => SetStick(stick, 0, 0, crlf);
        public static byte[] TypeKey(HidKeyboardKey key, bool crlf = true) => Encode($"key {(int)key}", crlf);
#pragma warning disable CA1416 // Validate platform compatibility
        public static byte[] TypeMultipleKeys(IEnumerable<HidKeyboardKey> keys, bool crlf = true) => Encode($"key{string.Concat(keys.Select(z => $" {(int)z}"))}", crlf);
#pragma warning restore CA1416 // Validate platform compatibility
        public static byte[] Peek(uint offset, int count, bool crlf = true) => Encode($"peek 0x{offset:X8} {count}", crlf);
        public static byte[] PeekMulti(IReadOnlyDictionary<ulong, int> offsetSizeDictionary, bool crlf = true) => Encode($"peekMulti{string.Concat(offsetSizeDictionary.Select(z => $" 0x{z.Key:X16} {z.Value}"))}", crlf);
        public static byte[] Poke(uint offset, byte[] data, bool crlf = true) => Encode($"poke 0x{offset:X8} 0x{string.Concat(data.Select(z => $"{z:X2}"))}", crlf);
        public static byte[] PeekAbsolute(ulong offset, int count, bool crlf = true) => Encode($"peekAbsolute 0x{offset:X16} {count}", crlf);
        public static byte[] PeekAbsoluteMulti(IReadOnlyDictionary<ulong, int> offsetSizeDictionary, bool crlf = true) => Encode($"peekAbsoluteMulti{string.Concat(offsetSizeDictionary.Select(z => $" 0x{z.Key:X16} {z.Value}"))}", crlf);
        public static byte[] PokeAbsolute(ulong offset, byte[] data, bool crlf = true) => Encode($"pokeAbsolute 0x{offset:X16} 0x{string.Concat(data.Select(z => $"{z:X2}"))}", crlf);
        public static byte[] PeekMain(ulong offset, int count, bool crlf = true) => Encode($"peekMain 0x{offset:X16} {count}", crlf);
        public static byte[] PeekMainMulti(IReadOnlyDictionary<ulong, int> offsetSizeDictionary, bool crlf = true) => Encode($"peekMainMulti{string.Concat(offsetSizeDictionary.Select(z => $" 0x{z.Key:X16} {z.Value}"))}", crlf);
        public static byte[] PokeMain(ulong offset, byte[] data, bool crlf = true) => Encode($"pokeMain 0x{offset:X16} 0x{string.Concat(data.Select(z => $"{z:X2}"))}", crlf);
        public static byte[] PointerPeek(IEnumerable<long> jumps, int count, bool crlf = true) => Encode($"pointerPeek {count}{string.Concat(jumps.Select(z => $" {z}"))}", crlf);
        public static byte[] PointerPoke(IEnumerable<long> jumps, byte[] data, bool crlf = true) => Encode($"pointerPoke 0x{string.Concat(data.Select(z => $"{z:X2}"))}{string.Concat(jumps.Select(z => $" {z}"))}", crlf);
        public static byte[] PointerAll(IEnumerable<long> jumps, bool crlf = true) => Encode($"pointerAll{string.Concat(jumps.Select(z => $" {z}"))}", crlf);
        public static byte[] PointerRelative(IEnumerable<long> jumps, bool crlf = true) => Encode($"pointerRelative{string.Concat(jumps.Select(z => $" {z}"))}", crlf);
        public static byte[] GetMainNsoBase(bool crlf = true) => Encode("getMainNsoBase", crlf);
        public static byte[] GetHeapBase(bool crlf = true) => Encode("getHeapBase", crlf);
        public static byte[] GetTitleID(bool crlf = true) => Encode("getTitleID", crlf);
        public static byte[] GetBuildID(bool crlf = true) => Encode("getBuildID", crlf);
        public static byte[] GetBotbaseVersion(bool crlf = true) => Encode("getVersion", crlf);
        public static byte[] GetHekateVersion(bool crlf = true) => Encode("getVersion", crlf);
        public static byte[] GetGameInfo(string info, bool crlf = true) => Encode($"game {info}", crlf);
    }
}
