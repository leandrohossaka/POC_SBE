/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments

namespace SbeFIX
{
    public enum MassActionType : byte
    {
        SUSPEND_ORDERS = 1,
        RELEASE_ORDERS_FROM_SUSPENSION = 2,
        CANCEL_ORDERS = 3,
        NULL_VALUE = 255
    }
}
