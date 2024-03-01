using TestError.TestError.ContractDefinition;

namespace TestError {
	internal class CustomErrorMessages : Nethereum.CustomError.CustomErrorMapperBase {
		protected override string CustomErrorNotFound() {
			return "Error Unknown";
		}

		protected override string GenerateMessage(WithIntParameterErrorBase error) {
			return $"Error with parameter {error.Param}";
		}

		protected override string GenerateMessage(WithoutParameterErrorBase error) {
			return "Error without parameter";
		}
	}
}
