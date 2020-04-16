/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments

namespace SbeFIX
{
    public enum EstablishRejectCode : byte
    {
        UNSPECIFIED = 0,
        CREDENTIALS = 1,
        UNNEGOTIATED = 2,
        ALREADY_ESTABLISHED = 3,
        SESSION_BLOCKED = 4,
        KEEPALIVE_INTERVAL = 5,
        NULL_VALUE = 255
    }
}
