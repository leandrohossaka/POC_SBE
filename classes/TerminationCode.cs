/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Org.SbeTool.Sbe.Dll;

namespace Sbe
{
    public enum TerminationCode : byte
    {
        UNSPECIFIED = 0,
        FINISHED = 1,
        REREQUEST_OUT_OF_BOUNDS = 2,
        REREQUEST_IN_PROGRESS = 3,
        NULL_VALUE = 255
    }
}
