﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.Azure.Management.DataFactory.Models;

namespace Microsoft.Azure.Commands.DataFactoryV2.Models
{
    public class PSDataFlowDebugSessionCommandResult
    {
        private DataFlowDebugCommandResponse _commandResult;

        public PSDataFlowDebugSessionCommandResult()
        {
            this._commandResult = new DataFlowDebugCommandResponse();
        }

        public PSDataFlowDebugSessionCommandResult(DataFlowDebugCommandResponse commandResult)
        {
            this._commandResult = commandResult ?? throw new ArgumentNullException("commandResult");
        }

        public string Data
        {
            get
            {
                return this._commandResult.Data;
            }
        }
        public string Status
        {
            get
            {
                return this._commandResult.Status;
            }
        }
    }
}
