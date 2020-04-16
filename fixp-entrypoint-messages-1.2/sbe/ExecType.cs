/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments

namespace SbeFIX
{
    public enum ExecType : byte
    {
        NEW = 48,
        CANCELED = 52,
        REPLACE = 53,
        REJECTED = 56,
        EXPIRED = 67,
        RESTATED = 68,
        TRADE = 70,
        TRADE_CANCEL = 72,
        NULL_VALUE = 0
    }
}
