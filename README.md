Utility class generated for any custom error in your contracts.

It creates a class that you can call with a Nethereum.Contracts.SmartContractCustomErrorRevertException and give you a message

When you inherit from Nethereum.CustomError.CustomErrorMapperBase you will need to implement all the abstract methods for any custom error it found.


How to use in your project add a reference with  OutputItemType="Analyzer" ReferenceOutputAssembly="false"  then it generates the base class and you can implement it.
```
<ProjectReference Include="..\Nethereum.CustomError.Generator\Nethereum.CustomError.Generator.csproj"  OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
```
