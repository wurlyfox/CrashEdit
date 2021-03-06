﻿namespace Crash.GOOLIns
{
    [GOOLInstruction(144,GameVersion.Crash1)]
    [GOOLInstruction(144,GameVersion.Crash1Beta1995)]
    [GOOLInstruction(144,GameVersion.Crash1BetaMAR08)]
    [GOOLInstruction(144,GameVersion.Crash1BetaMAY11)]
    [GOOLInstruction(69,GameVersion.Crash2)]
    [GOOLInstruction(69,GameVersion.Crash3)]
    public sealed class Evnb : GOOLInstruction
    {
        public Evnb(int value,GOOLEntry gool) : base(value,gool) { }

        public override string Name => "EVNB";
        public override string Format => "[EEEEEEEEEEEE] (RRRRRR) AAA (LLL)";
        public override string Comment => $"cascade event {GetArg('E')} to {GetArg('L')} for every object" + (Args['A'].Value > 0 ? $" with {GetArg('A')} arguments (starting at {GetArg('R')})" : "");
    }
}
