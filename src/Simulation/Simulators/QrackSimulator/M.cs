﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.InteropServices;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

namespace Microsoft.Quantum.Simulation.Simulators.Qrack
{
    public partial class QrackSimulator
    {
        [DllImport(QRACKSIM_DLL_NAME, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "M")]
        private static extern uint M(uint id, uint q);
        Result IIntrinsicM.Body(Qubit target)
        {
            this.CheckQubit(target);
            //setting qubit as measured to allow for release
            target.IsMeasured = true;
            return M(this.Id, (uint)target.Id).ToResult();
        }
    }
}
