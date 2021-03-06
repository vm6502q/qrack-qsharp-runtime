﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;
using Xunit;
using Microsoft.Quantum.Simulation.XUnit;
using Microsoft.Quantum.Simulation.Simulators.Tests.Circuits;
using Microsoft.Quantum.Simulation.Simulators.Qrack;

namespace Microsoft.Quantum.Simulation.Simulators.Tests
{
    public partial class QrackSimulatorTests
    {
        [OperationDriver(TestCasePrefix ="QrackSim", TestNamespace = "Microsoft.Quantum.Simulation.Simulators.Tests.Circuits")]
        public void QrackSimTestTarget( TestOperation op )
        {
            using (var sim = new QrackSimulator(throwOnReleasingQubitsNotInZeroState: true))
            {
                op.TestOperationRunner(sim);
            }
        }
    }
}
