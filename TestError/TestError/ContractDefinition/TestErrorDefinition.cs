using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace TestError.TestError.ContractDefinition
{


    public partial class TestErrorDeployment : TestErrorDeploymentBase
    {
        public TestErrorDeployment() : base(BYTECODE) { }
        public TestErrorDeployment(string byteCode) : base(byteCode) { }
    }

    public class TestErrorDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public TestErrorDeploymentBase() : base(BYTECODE) { }
        public TestErrorDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class WithIntParameterError : WithIntParameterErrorBase { }

    [Error("WithIntParameter")]
    public class WithIntParameterErrorBase : IErrorDTO
    {
        [Parameter("int256", "param", 1)]
        public virtual BigInteger Param { get; set; }
    }

    public partial class WithoutParameterError : WithoutParameterErrorBase { }
    [Error("WithoutParameter")]
    public class WithoutParameterErrorBase : IErrorDTO
    {
    }
}
