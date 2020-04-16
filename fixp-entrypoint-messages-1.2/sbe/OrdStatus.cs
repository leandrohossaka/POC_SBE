/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments

namespace SbeFIX
{
    public enum OrdStatus : byte
    {
        NEW = 48,
        PARTIALLY_FILLED = 49,
        FILLED = 50,
        CANCELED = 52,
        REPLACED = 53,
        REJECTED = 56,
        EXPIRED = 67,
        PREVIOUS_FINAL_STATE = 90,
        NULL_VALUE = 0
    }
}
