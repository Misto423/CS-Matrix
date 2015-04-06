using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MatrixLib;

namespace MatrixConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var imf = MatrixHelper.Identity<float>(3);
			//var imi = MatrixHelper.Identity<int>(2);
			//var imf2 = new Matrix<float>(3, 3);
			imf[0, 0] = 5;
			imf[0, 1] = 8.42535f;
			imf[0, 2] = -41.5f;
			imf[1, 0] = -6;
			imf[1, 1] = 17;
			imf[1, 2] = 0.0424f;
			imf[2, 0] = 0;
			imf[2, 1] = -0.55f;
			imf[2, 2] = 15;
			var f = MatrixHelper.GetTrace(imf);
			var x = MatrixHelper.GetDeterminant(imf);
			//List<List<int>> x = imf.GetPermutations();
			//foreach (List<int> j in x)
			//{
			//    bool g = imf.GetPermutationSign(j);
			//}
			//imf = MatrixHelper.RowAddition(imf, 1, 2);
			//imf = MatrixHelper.RowMultiplication(imf, 0, 3); 
			//imf2[0, 0] = 2;
			//imf2[0, 1] = 3.42535f;
			//imf2[0, 2] = -1.5f;
			//imf2[1, 0] = 6;
			//imf2[1, 1] = -87;
			//imf2[1, 2] = 0.354f;
			//imf2[2, 0] = 4;
			//imf2[2, 1] = 0.442f;
			//imf2[2, 2] = 15;

			//var added = MatrixHelper.Add(imf, imf2);
			//added = 2 * added;

			Matrix<int> tt = new Matrix<int>(2, 3);
			tt[0, 0] = 1;
			tt[0, 1] = 2;
			tt[0, 2] = 3;
			tt[1, 0] = 0;
			tt[1, 1] = -6;
			tt[1, 2] = 7;
			//tt = tt.GetSubMatrix(0, 0);
			//Matrix<int> tranpose = tt.Transpose();

			Matrix<int> m1 = new Matrix<int>(1, 2);
			Matrix<int> m2 = new Matrix<int>(2, 2);
			m1[0, 0] = 5;
			m1[0, 1] = 3;

			m2[0, 0] = 2;
			m2[0, 1] = 5;
			m2[1, 0] = 4;
			m2[1, 1] = 3;
			Matrix<int> mm = MatrixHelper.Multiply(new Matrix<int>[] { m1, m2 });

			Matrix<byte> bm = mm.ConvertToByte();

			Console.Read();
		}
	}
}
