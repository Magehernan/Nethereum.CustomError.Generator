// SPDX-License-Identifier: MIT
pragma solidity 0.8.20;

interface TestError {
	error WithoutParameter();
	error WithIntParameter(int256 param);
}