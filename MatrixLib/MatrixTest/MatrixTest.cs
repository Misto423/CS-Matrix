using MatrixLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MatrixTestProj
{
    /// <summary>
    ///This is a test class for MatrixTest and is intended
    ///to contain all MatrixTest Unit Tests
    ///</summary>
	[TestClass()]
	public class MatrixTest
	{
		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		public bool CompareMatrix(Matrix<uint> m1, Matrix<uint> m2)
		{
			if (m1.Rows != m2.Rows && m1.Columns != m2.Columns) return false;
			for (int r = 0; r < m1.Rows; r++)
				for (int c = 0; c < m1.Columns; c++)
					if (m1[r, c] != m2[r, c]) return false;
			return true;
		}

		#region Constructor Tests
		public void MatrixConstructorWithInitValueTestMethod<T>(T val)
		{
			int rows = 2; 
			int columns = 2;
			T init = val;
			
			Matrix<T> target = new Matrix<T>(rows, columns, init);
			Assert.AreEqual(target.Rows, 2);
			Assert.AreEqual(target.Columns, 2);
			Assert.AreEqual(target[1, 1], init);
		}

		[TestMethod()]
		public void MatrixConstructorWithInt32InitValueTest()
		{
			MatrixConstructorWithInitValueTestMethod<int>(6);
		}

		[TestMethod()]
		public void MatrixConstructorWithDoubleInitValueTest()
		{
			MatrixConstructorWithInitValueTestMethod<double>(6.7);
		}

		public void MatrixConstructorRowsColumnsTestMethod<T>()
		{
			int rows = 5;
			int columns = 3;
			Matrix<T> target = new Matrix<T>(rows, columns);
			Assert.AreEqual(target.Columns, 3);
			Assert.AreEqual(target.Rows, 5);
			Assert.AreEqual(target[2, 2], (ushort)0);
		}

		[TestMethod()]
		public void MatrixConstructorRowsColumnsTest()
		{
			MatrixConstructorRowsColumnsTestMethod<ushort>();
		}

		public void MatrixDefaultConstructorTestMethod<T>()
		{
			Matrix<T> target = new Matrix<T>();
			Assert.AreEqual(target.Columns, 1);
			Assert.AreEqual(target.Rows, 1);
		}

		[TestMethod()]
		public void MatrixDefaultConstructorTest()
		{
			MatrixDefaultConstructorTestMethod<short>();
		}
		#endregion

		#region Vector Tests
		public void GetColumnVectorTestHelper<T>()
		{
			Matrix<byte> target = new Matrix<byte>(3,2,8);
			int columnIndex = 0;
			byte[] expected = new byte[] {8,8,8};
			byte[] actual;
			actual = target.GetColumnVector(columnIndex);
			Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
			Assert.AreEqual(expected[1], actual[1]);
		}

		[TestMethod()]
		public void GetColumnVectorTest()
		{
			GetColumnVectorTestHelper<byte>();
		}

		public void GetRowVectorTestHelper<T>()
		{
			Matrix<decimal> target = new Matrix<decimal>(3, 2, 5.34346368690M);
			int rowIndex = 1;
			decimal[] expected = new decimal[] { 5.34346368690M, 5.34346368690M };
			decimal[] actual;
			actual = target.GetRowVector(rowIndex);
			Assert.AreEqual(expected.GetLength(0), actual.GetLength(0));
			Assert.AreEqual(expected[1], actual[1]);
		}

		[TestMethod()]
		public void GetRowVectorTest()
		{
			GetRowVectorTestHelper<decimal>();
		}
		#endregion

		#region Permutation Tests
		[TestMethod()]
		public void GetPermutationSignPositiveTest()
		{
			Matrix<uint> target = new Matrix<uint>(3,3);
			List<int> perm = new List<int> {2,0,1};
			bool expected = true;
			bool actual;
			actual = target.GetPermutationSign(perm);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void GetPermutationSignNegativeTest()
		{
			Matrix<ulong> target = new Matrix<ulong>(3, 3);
			List<int> perm = new List<int> { 0,2,1 };
			bool expected = false;
			bool actual;
            actual = target.GetPermutationSign(perm);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void GetPermutationsTest()
		{
			Matrix<long> target = new Matrix<long>(2,2);
			List<List<int>> expected = new List<List<int>>()
			{
				new List<int>() { 0, 1 },
				new List<int>() { 1, 0 }
			};
			List<List<int>> actual;
			actual = target.GetPermutations();
			bool x = ComparePermutation(expected, actual);
			Assert.IsTrue(x);
		}

		public bool ComparePermutation(List<List<int>> ex, List<List<int>> ac)
		{
			for (int i = 0; i < ex.Count; i++)
			{
				for (int f = 0; f < ex[i].Count; f++)
				{
					if (ex[i][f] != ac[i][f])
					{
						return false;
					}
				}
			}
			return true;
		}
		#endregion

		#region Dimension Modifier Tests
		[TestMethod()]
		public void GetSubMatrixTest()
		{
			Matrix<uint> target = new Matrix<uint>(4,4,9001);
			int row = 0;
			int column = 2;
			Matrix<uint> expected = new Matrix<uint>(3, 3, 9001);
			Matrix<uint> actual;
			actual = target.GetSubMatrix(row, column);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void IsSameDimensionTest()
		{
			Matrix<long> target = new Matrix<long>(4,7);
			Matrix<long> compare = new Matrix<long>(4, 7);
			bool actual = target.IsSameDimension(compare);
			Assert.IsTrue(actual);
		}

		[TestMethod()]
		public void IsNotSameDimensionTest()
		{
			Matrix<float> target = new Matrix<float>(4, 7);
			Matrix<float> compare = new Matrix<float>(4, 7);
			bool actual = target.IsSameDimension(compare);
			Assert.IsTrue(actual);
		}

		[TestMethod()]
		public void TransposeTestHelper()
		{
			Matrix<uint> target = new Matrix<uint>(2,3,7);
			Matrix<uint> expected = new Matrix<uint>(3,2,7);
			Matrix<uint> actual;
			actual = target.Transpose();
			Assert.IsTrue(CompareMatrix(expected, actual));
		}
		#endregion

		#region Operation Tests
		[TestMethod()]
		public void op_AdditionTestHelper()
		{
			Matrix<uint> m1 = new Matrix<uint>(2, 2, 2);
			Matrix<uint> m2 = new Matrix<uint>(2, 2, 8);
			Matrix<uint> expected = new Matrix<uint>(2, 2, 10);
			Matrix<uint> actual;
			actual = (m1 + m2);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void op_MultiplyMultiplyMatricesTest()
		{
			Matrix<uint> m1 = new Matrix<uint>(1, 2);
			Matrix<uint> m2 = new Matrix<uint>(2, 2);
			m1[0, 0] = 5;
			m1[0, 1] = 3;

			m2[0, 0] = 2;
			m2[0, 1] = 5;
			m2[1, 0] = 4;
			m2[1, 1] = 3;
			Matrix<uint> expected = new Matrix<uint>(1, 2);
			expected[0, 0] = 22;
			expected[0, 1] = 34;
			Matrix<uint> actual;
			actual = (m1 * m2);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void op_ScalarMultiplyIntTest()
		{
			int scalar = 10;
			Matrix<uint> matrix = new Matrix<uint>(2,2,10);
			Matrix<uint> expected = new Matrix<uint>(2,2,100);
			Matrix<uint> actual;
			actual = (scalar * matrix);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void op_ScalarMultiplyDoubleTest()
		{
			double scalar = 0.5;
			Matrix<uint> matrix = new Matrix<uint>(2, 2, 50);
			Matrix<uint> expected = new Matrix<uint>(2, 2, 25);
			Matrix<uint> actual;
			actual = (scalar * matrix);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void op_SubtractionTestHelper()
		{
			Matrix<uint> m1 = new Matrix<uint>(2, 2, 6);
			Matrix<uint> m2 = new Matrix<uint>(2, 2, 2);
			Matrix<uint> expected = new Matrix<uint>(2, 2, 4);
			Matrix<uint> actual;
			actual = (m1 - m2);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}
		#endregion
	}
}
