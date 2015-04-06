using MatrixLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTestProj
{
	[TestClass()]
	public class MatrixHelperTest
	{
		private TestContext testContextInstance;
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

		public bool CompareMatrix(Matrix<int> m1, Matrix<int> m2)
		{
			if (m1.Rows != m2.Rows && m1.Columns != m2.Columns) return false;
			for (int r = 0; r < m1.Rows; r++)
				for (int c = 0; c < m1.Columns; c++)
					if (m1[r, c] != m2[r, c]) return false;
			return true;
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		[TestMethod()]
		public void GetDeterminantTest()
		{
			Matrix<int> matrix = new Matrix<int>(4, 4);

			matrix[0, 0] = 5;
			matrix[0, 1] = 5;
			matrix[0, 2] = 4;
			matrix[0, 3] = 6;

			matrix[1, 0] = 8;
			matrix[1, 1] = 7;
			matrix[1, 2] = 2;
			matrix[1, 3] = 8;

			matrix[2, 0] = 4;
			matrix[2, 1] = 6;
			matrix[2, 2] = 9;
			matrix[2, 3] = 6;

			matrix[3, 0] = 7;
			matrix[3, 1] = 10;
			matrix[3, 2] = 11;
			matrix[3, 3] = 7;

			decimal expected = -15;
			decimal actual;
			actual = MatrixHelper.GetDeterminant(matrix);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void GetTraceTest()
		{
			Matrix<int> matrix = new Matrix<int>(3, 3, 5);
			int expected = 15;
			int actual;
			actual = MatrixHelper.GetTrace(matrix);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void RowAdditionTest()
		{
			Matrix<int> matrix = new Matrix<int>(4, 4, 3);
			int additive = 1;
			int target = 2;
			Matrix<int> expected = new Matrix<int>(4,4,3);
			for (int c = 0; c < matrix.Columns; c++)
			{
				expected[target, c] = 6;
			}
			Matrix<int> actual;
			actual = MatrixHelper.RowAddition(matrix, additive, target);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void RowAdditionWithMultipleTest()
		{
			Matrix<int> matrix = new Matrix<int>(4, 4, 3);
			int additive = 1;
			int target = 2;
			double multiple = 3.0;
			Matrix<int> expected = new Matrix<int>(4, 4, 3);
			for (int c = 0; c < matrix.Columns; c++)
			{
				expected[target, c] = 12;
			}
			Matrix<int> actual;
			actual = MatrixHelper.RowAddition(matrix, additive, target, multiple);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void RowMultiplicationTestHelper()
		{
			Matrix<int> matrix = new Matrix<int>(3, 3, 5);
			int target = 0;
			double multiple = 4.0;
			Matrix<int> expected = new Matrix<int>(3, 3, 5);
			for (int c = 0; c < expected.Columns; c++)
			{
				expected[target, c] = 20;
			}
			Matrix<int> actual;
			actual = MatrixHelper.RowMultiplication(matrix, target, multiple);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}

		[TestMethod()]
		public void IdentityTest()
		{
			int size = 3;
			Matrix<int> expected = new Matrix<int>(3, 3, 0);
			for (int i = 0; i < expected.Columns; i++)
			{
				expected[i, i] = 1;
			}
			Matrix<int> actual;
			actual = MatrixHelper.Identity<int>(size);
			Assert.IsTrue(CompareMatrix(expected, actual));
		}
	}
}
