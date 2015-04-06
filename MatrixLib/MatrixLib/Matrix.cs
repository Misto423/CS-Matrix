using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MatrixLib
{
	public class UnsupportedTypeException : Exception, ISerializable
	{
		public UnsupportedTypeException() 
		{
			
		}

		public UnsupportedTypeException(string message) : 
			base(message) {}

		public UnsupportedTypeException(string message, Exception inner) :
			base(message, inner) { }

		protected UnsupportedTypeException(SerializationInfo info, StreamingContext context) :
			base(info, context) { }

		public override string Message
		{
			get
			{
				return base.Message;
			}
		}
		public override System.Collections.IDictionary Data
		{
			get
			{
				return base.Data;
			}
		}
		public override string StackTrace
		{
			get
			{
				return base.StackTrace;
			}
		}
		public override string HelpLink
		{
			get
			{
				return base.HelpLink;
			}
			set
			{
				base.HelpLink = value;
			}
		}
		public override string Source
		{
			get
			{
				return base.Source;
			}
			set
			{
				base.Source = value;
			}
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}
		public override Exception GetBaseException()
		{
			return base.GetBaseException();
		}
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
	public class InvalidDimensionsException : Exception, ISerializable
	{
		public InvalidDimensionsException() 
		{
			
		}

		public InvalidDimensionsException(string message) : 
			base(message) {}

		public InvalidDimensionsException(string message, Exception inner) :
			base(message, inner) { }

		protected InvalidDimensionsException(SerializationInfo info, StreamingContext context) :
			base(info, context) { }

		public override string Message
		{
			get
			{
				return base.Message;
			}
		}
		public override System.Collections.IDictionary Data
		{
			get
			{
				return base.Data;
			}
		}
		public override string StackTrace
		{
			get
			{
				return base.StackTrace;
			}
		}
		public override string HelpLink
		{
			get
			{
				return base.HelpLink;
			}
			set
			{
				base.HelpLink = value;
			}
		}
		public override string Source
		{
			get
			{
				return base.Source;
			}
			set
			{
				base.Source = value;
			}
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}
		public override Exception GetBaseException()
		{
			return base.GetBaseException();
		}
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}

	public static class MatrixExtensions
	{
		public static Matrix<byte> ConvertToByte<T>(this Matrix<T> mat)
		{
			Matrix<byte> m = new Matrix<byte>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (byte)Convert.ChangeType(mat[r, c], typeof(byte));
			return m;
		}
		public static Matrix<ushort> ConvertToUnsignedShort<T>(this Matrix<T> mat)
		{
			Matrix<ushort> m = new Matrix<ushort>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (ushort)Convert.ChangeType(mat[r, c], typeof(ushort));
			return m;
		}
		public static Matrix<short> ConvertToShort<T>(this Matrix<T> mat)
		{
			Matrix<short> m = new Matrix<short>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (short)Convert.ChangeType(mat[r, c], typeof(short));
			return m;
		}
		public static Matrix<uint> ConvertToUnsignedInt<T>(this Matrix<T> mat)
		{
			Matrix<uint> m = new Matrix<uint>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (uint)Convert.ChangeType(mat[r, c], typeof(uint));
			return m;
		}
		public static Matrix<int> ConvertToInt<T>(this Matrix<T> mat)
		{
			Matrix<int> m = new Matrix<int>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (int)Convert.ChangeType(mat[r, c], typeof(int));
			return m;
		}
		public static Matrix<ulong> ConvertToUnsignedLong<T>(this Matrix<T> mat)
		{
			Matrix<ulong> m = new Matrix<ulong>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (ulong)Convert.ChangeType(mat[r, c], typeof(ulong));
			return m;
		}
		public static Matrix<long> ConvertToLong<T>(this Matrix<T> mat)
		{
			Matrix<long> m = new Matrix<long>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (long)Convert.ChangeType(mat[r, c], typeof(long));
			return m;
		}
		public static Matrix<float> ConvertToFloat<T>(this Matrix<T> mat)
		{
			Matrix<float> m = new Matrix<float>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (float)Convert.ChangeType(mat[r, c], typeof(float));
			return m;
		}
		public static Matrix<double> ConvertToDouble<T>(this Matrix<T> mat)
		{
			Matrix<double> m = new Matrix<double>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (double)Convert.ChangeType(mat[r, c], typeof(double));
			return m;
		}
		public static Matrix<decimal> ConvertToDecimal<T>(this Matrix<T> mat)
		{
			Matrix<decimal> m = new Matrix<decimal>(mat.Rows, mat.Columns);
			for (int r = 0; r < m.Rows; r++)
				for (int c = 0; c < m.Columns; c++)
					m[r, c] = (decimal)Convert.ChangeType(mat[r, c], typeof(decimal));
			return m;
		}
	}

	public class Matrix<T>
	{
		private T[,] matrix_array;
		private int rows, columns;

		public Matrix()
		{
			if (!TypeValidate())
			{
				throw new UnsupportedTypeException("This type is unsupported.  Only primitive numeric types are supported.");
			}
			matrix_array = new T[1, 1];
			rows = columns = 1;
		}

		public Matrix(int rows, int columns)
		{
			if (!TypeValidate())
			{
				throw new UnsupportedTypeException("This type is unsupported.  Only primitive numeric types are supported.");
			}
			matrix_array = new T[rows, columns];
			this.rows = rows;
			this.columns = columns;
		}

		public Matrix(int rows, int columns, T initValue)
		{
			if (!TypeValidate())
			{
				throw new UnsupportedTypeException("This type is unsupported.  Only primitive numeric types are supported.");
			}

			matrix_array = new T[rows, columns];
			this.rows = rows;
			this.columns = columns;

			for (int r = 0; r < rows; r++)
				for (int c = 0; c < columns; c++)
					matrix_array[r, c] = initValue;
		}

		public int Columns
		{
			get { return columns; }
		}

		public int Rows
		{
			get { return rows; }
		}

		/// <summary>
		/// Gets an array of the specified row.
		/// </summary>
		/// <param name="rowIndex">The index of the row required.</param>
		/// <returns>An array of the specified row.</returns>
		public T[] GetRowVector(int rowIndex)
		{
			T[] row = new T[columns];

			for (int i = 0; i < columns; i++)
			{
				row[i] = matrix_array[rowIndex,i];
			}

			return row;
		}

		/// <summary>
		/// Gets an array of the specified column.
		/// </summary>
		/// <param name="columnIndex">The index of column required.</param>
		/// <returns>An array of the specified column.</returns>
		public T[] GetColumnVector(int columnIndex)
		{
			T[] column = new T[rows];

			for (int i = 0; i < rows; i++)
			{
				column[i] = matrix_array[i, columnIndex];
			}

			return column;
		}

		private bool TypeValidate()
		{
			Type t = typeof(T);
			if (t == typeof(int) || t == typeof(uint) || t == typeof(ushort) || t == typeof(short) ||
				t == typeof(byte) || t == typeof(long) || t == typeof(ulong) || t == typeof(float) ||
				t == typeof(double) || t == typeof(decimal))
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Compare the dimensions of two matrices to determine if they have the same number of rows and columns.
		/// </summary>
		/// <param name="compare">The matrix to compare to the current matrix.</param>
		/// <returns>True if the matrices have the same dimensions.</returns>
		public bool IsSameDimension(Matrix<T> compare)
		{
			if (this.Columns == compare.Columns && this.Rows == compare.Rows)
				return true;
			return false;
		}

		/// <summary>
		/// Transpose the current matrix.
		/// </summary>
		/// <returns>A new matrix that is the tranpose of the current matrix.</returns>
		public Matrix<T> Transpose()
		{
			Matrix<T> m = new Matrix<T>(this.Columns, this.Rows);
			for (int w = 0; w < this.Columns; w++)
			{
				for (int h = 0; h < this.Rows; h++)
				{
					m[w, h] = this[h, w];
				}
			}
			return m;
		}

		/// <summary>
		/// Creates a submatrix with a row and/or column removed from the source matrix.
		/// </summary>
		/// <param name="row">The index of the row to remove from the matrix, use -1 to not remove a row.</param>
		/// <param name="column">The index of the column to remove from the matrix, use -1 to not remove a column.</param>
		/// <returns>A new matrix with the row and column removed.</returns>
		public Matrix<T> GetSubMatrix(int row, int column)
		{
			Matrix<T> m;
			if (row > -1 && column > -1)
			{
				m = new Matrix<T>(rows - 1, columns - 1);
			}
			else if (row < 0 && column > -1)
			{
				m = new Matrix<T>(rows, columns - 1);
			}
			else if (row > -1 && column < 0)
			{
				m = new Matrix<T>(rows - 1, columns);
			}
			else //rows and columns less than 0
			{
				throw new Exception();
			}

			int mr = 0, mc = 0;
			for (int r = 0; r < this.Rows; r++)
			{
				if (r == row) continue;
				mc = 0;
				for (int c = 0; c < this.columns; c++)
				{
					if (c == column) continue;
					m[mr, mc] = this[r, c];
					mc++;
				}
				mr++;
			}
			return m;
		}

		internal List<List<int>> GetPermutations()
		{
			List<int> num = new List<int>();
			num.AddRange(Enumerable.Range(0, rows));
			List<List<int>> permutations = new List<List<int>>();
			permutations.Add(new List<int>(num));
			int largestIndex = -1;
			while (true)
			{
				largestIndex = -1;
				for (int i = num.Count - 2; i >= 0; i--)
				{
					if (num[i] < num[i + 1])
					{
						largestIndex = i;
						break;
					}
				}

				if (largestIndex < 0) break;

				int large = -1;
				for (int i = num.Count - 1; i >= 0; i--)
				{
					if (num[largestIndex] < num[i])
					{
						large = i;
						break;
					}
				}

				int tempStore = num[largestIndex];
				num[largestIndex] = num[large];
				num[large] = tempStore;

				for (int i = largestIndex + 1, j = num.Count - 1; i < j; i++, j--)
				{
					tempStore = num[i];
					num[i] = num[j];
					num[j] = tempStore;
				}
				permutations.Add(new List<int>(num));
			}

			return permutations;
		}

		internal bool GetPermutationSign(List<int> perm)
		{
			int length = perm.Count;
			for (int p = 0; p < length; p++) perm[p]++;
			int n, i, parity;
			List<bool> visit = new List<bool>(Enumerable.Repeat(false, length));

			parity = 1;
			for (int k = 0; k < length; k++)
			{
				if (!visit[k])
				{
					n = k;
					i = 0;
					while (!visit[n])
					{
						i++;
						visit[n] = true;
						n = perm[n] - 1;
					}
					if (i % 2 == 0) parity = -parity;
				}
			}

			if (parity < 0) return false;
			return true;
		}

		public static Matrix<T> operator ~(Matrix<T> m1)
		{
			return m1.Transpose();
		}

		public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Add(new Matrix<T>[] { m1, m2 });
		}

		public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Subtract(new Matrix<T>[] { m1, m2 });
		}

		public static Matrix<T> operator *(int scalar, Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).ScalarMultiply(scalar, matrix);
		}

		public static Matrix<T> operator *(double scalar, Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).ScalarMultiply(scalar, matrix);
		}

		public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Multiply(new Matrix<T>[] {m1, m2});
		}

		public T this[int r, int c]
		{
			get
			{
				return matrix_array[r,c];
			}
			set
			{
				matrix_array[r,c] = value;
			}
		}
	}

	public static class MatrixHelper
	{
		/// <summary>
		/// Gets an identity matrix with size x size dimensions.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="size">The dimensions of the matrix.</param>
		/// <returns>An identity matrix of the specified type with size x size dimensions.</returns>
		public static Matrix<T> Identity<T>(int size)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Identity(size);
		}

		/// <summary>
		/// Adds matrices together.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="matrices">The matrices to add together.</param>
		/// <returns>A new matrix with the elements of the matrices added together.</returns>
		public static Matrix<T> Add<T>(params Matrix<T>[] matrices)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Add(matrices);
		}

		/// <summary>
		/// Subtracts matrices together.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="matrices">The matrices to subtract from.</param>
		/// <returns>A new matrix with the elements of the matrices subtracted from one another.</returns>
		public static Matrix<T> Subtract<T>(params Matrix<T>[] matrices)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Subtract(matrices);
		}

		/// <summary>
		/// Multiplies the elements of the matrix by a scalar value.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="scalar">The scalar (int) value to multiple the elements by.</param>
		/// <param name="matrix">The matrix whose elements will be scaled by the scalar value.</param>
		/// <returns>A new matrix with the result of the scalar multiplication.</returns>
		public static Matrix<T> ScalarMultiply<T>(int scalar, Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).ScalarMultiply(scalar, matrix);
		}

		/// <summary>
		/// Multiplies the elements of the matrix by a scalar value.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="scalar">The scalar (double) value to multiple the elements by.</param>
		/// <param name="matrix">The matrix whose elements will be scaled by the scalar value.</param>
		/// <returns>A new matrix with the result of the scalar multiplication.</returns>
		public static Matrix<T> ScalarMultiply<T>(double scalar, Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).ScalarMultiply(scalar, matrix);
		}

		/// <summary>
		/// Multiplies matrices together.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="matrices">The matrices to multiply together</param>
		/// <returns>A new matrix with the result of the multiplication.</returns>
		public static Matrix<T> Multiply<T>(params Matrix<T>[] matrices)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).Multiply(matrices);
		}

		/// <summary>
		/// Adds one row to another row of a matrix.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="matrix">The matrix used for row addition.</param>
		/// <param name="additive">The index of the row that will be added to the target.</param>
		/// <param name="target">The index of the row that will be replaced by the addition</param>
		/// <param name="multiple">A multiple to be used with the additive row.</param>
		/// <returns>A matrix with matrix[target] = matrix[target] + (multiple) * matrix[additive].</returns>
		public static Matrix<T> RowAddition<T>(Matrix<T> matrix, int additive, int target, double multiple = 1.0)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).RowAddition(matrix, additive, target, multiple);
		}

		/// <summary>
		/// Multiply a row of the matrix by a scalar value.
		/// </summary>
		/// <typeparam name="T">A primitive numeric type.</typeparam>
		/// <param name="matrix">The matrix whose row will be multiplied by a value.</param>
		/// <param name="target">The index of the row that will be scaled.</param>
		/// <param name="multiple">The scalar value used for multiplication.</param>
		/// <returns>A matrix with matrix[target] = (multiple) * matrix[target].</returns>
		public static Matrix<T> RowMultiplication<T>(Matrix<T> matrix, int target, double multiple)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).RowMultiplication(matrix, target, multiple);
		}

		public static decimal GetDeterminant<T>(Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).GetDeterminant(matrix);
		}

		public static T GetTrace<T>(Matrix<T> matrix)
		{
			return (MatrixGen.MatrixMath as IMatrixNumeric<T>).GetTrace(matrix);
		}
	}

	internal interface IMatrixNumeric<T>
	{
		Matrix<T> Identity(int size);
		Matrix<T> Add(Matrix<T> m1, Matrix<T> m2);
		Matrix<T> Subtract(Matrix<T> m1, Matrix<T> m2);
		Matrix<T> ScalarMultiply(int scalar, Matrix<T> m);
		Matrix<T> ScalarMultiply(double scalar, Matrix<T> m);
		Matrix<T> Multiply(Matrix<T> m1, Matrix<T> m2);
		Matrix<T> RowAddition(Matrix<T> m, int additive, int target, double multiple = 1.0);
		Matrix<T> RowMultiplication(Matrix<T> m, int target, double multiple);
		decimal GetDeterminant(Matrix<T> matrix);
		T GetTrace(Matrix<T> matrix);
	}

	internal sealed class MatrixGen :
		IMatrixNumeric<byte>,
		IMatrixNumeric<ushort>,
		IMatrixNumeric<short>,
		IMatrixNumeric<uint>,
		IMatrixNumeric<int>,
		IMatrixNumeric<ulong>,
		IMatrixNumeric<long>,
		IMatrixNumeric<float>,
		IMatrixNumeric<double>,
		IMatrixNumeric<decimal>
	{
		public static MatrixGen MatrixMath = new MatrixGen();

		#region Identity Functions
		Matrix<byte> IMatrixNumeric<byte>.Identity(int size)
		{
			Matrix<byte> m = new Matrix<byte>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1;
			}
			return m;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.Identity(int size)
		{
			Matrix<ushort> m = new Matrix<ushort>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1;
			}
			return m;
		}
		Matrix<short> IMatrixNumeric<short>.Identity(int size)
		{
			Matrix<short> m = new Matrix<short>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1;
			}
			return m;
		}
		Matrix<uint> IMatrixNumeric<uint>.Identity(int size)
		{
			Matrix<uint> m = new Matrix<uint>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1;
			}
			return m;
		}
		Matrix<int> IMatrixNumeric<int>.Identity(int size)
		{
			Matrix<int> m = new Matrix<int>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1;
			}
			return m;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.Identity(int size)
		{
			Matrix<ulong> m = new Matrix<ulong>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1L;
			}
			return m;
		}
		Matrix<long> IMatrixNumeric<long>.Identity(int size)
		{
			Matrix<long> m = new Matrix<long>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1L;
			}
			return m;
		}
		Matrix<float> IMatrixNumeric<float>.Identity(int size)
		{
			Matrix<float> m = new Matrix<float>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1.0f;
			}
			return m;
		}
		Matrix<double> IMatrixNumeric<double>.Identity(int size)
		{
			Matrix<double> m = new Matrix<double>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1.0d;
			}
			return m;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.Identity(int size)
		{
			Matrix<decimal> m = new Matrix<decimal>(size, size);
			for (int x = 0; x < size; x++)
			{
				m[x, x] = 1.0m;
			}
			return m;
		}
		#endregion

		#region Addition Functions
		Matrix<byte> IMatrixNumeric<byte>.Add(Matrix<byte> m1, Matrix<byte> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<byte> finalMatrix = new Matrix<byte>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (byte)(m1[w, h] + m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.Add(Matrix<ushort> m1, Matrix<ushort> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<ushort> finalMatrix = new Matrix<ushort>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (ushort)(m1[w, h] + m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<short> IMatrixNumeric<short>.Add(Matrix<short> m1, Matrix<short> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<short> finalMatrix = new Matrix<short>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (short)(m1[w, h] + m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<uint> IMatrixNumeric<uint>.Add(Matrix<uint> m1, Matrix<uint> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<uint> finalMatrix = new Matrix<uint>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<int> IMatrixNumeric<int>.Add(Matrix<int> m1, Matrix<int> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<int> finalMatrix = new Matrix<int>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.Add(Matrix<ulong> m1, Matrix<ulong> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<ulong> finalMatrix = new Matrix<ulong>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<long> IMatrixNumeric<long>.Add(Matrix<long> m1, Matrix<long> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<long> finalMatrix = new Matrix<long>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<float> IMatrixNumeric<float>.Add(Matrix<float> m1, Matrix<float> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<float> finalMatrix = new Matrix<float>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}	
		Matrix<double> IMatrixNumeric<double>.Add(Matrix<double> m1, Matrix<double> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<double> finalMatrix = new Matrix<double>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.Add(Matrix<decimal> m1, Matrix<decimal> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<decimal> finalMatrix = new Matrix<decimal>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] + m2[w, h];
				}
			}
			return finalMatrix;
		}
		#endregion

		#region Subtraction Functions
		Matrix<byte> IMatrixNumeric<byte>.Subtract(Matrix<byte> m1, Matrix<byte> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<byte> finalMatrix = new Matrix<byte>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (byte)(m1[w, h] - m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.Subtract(Matrix<ushort> m1, Matrix<ushort> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<ushort> finalMatrix = new Matrix<ushort>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (ushort)(m1[w, h] - m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<short> IMatrixNumeric<short>.Subtract(Matrix<short> m1, Matrix<short> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<short> finalMatrix = new Matrix<short>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = (short)(m1[w, h] - m2[w, h]);
				}
			}
			return finalMatrix;
		}
		Matrix<uint> IMatrixNumeric<uint>.Subtract(Matrix<uint> m1, Matrix<uint> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<uint> finalMatrix = new Matrix<uint>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<int> IMatrixNumeric<int>.Subtract(Matrix<int> m1, Matrix<int> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<int> finalMatrix = new Matrix<int>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.Subtract(Matrix<ulong> m1, Matrix<ulong> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<ulong> finalMatrix = new Matrix<ulong>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<long> IMatrixNumeric<long>.Subtract(Matrix<long> m1, Matrix<long> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<long> finalMatrix = new Matrix<long>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<float> IMatrixNumeric<float>.Subtract(Matrix<float> m1, Matrix<float> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<float> finalMatrix = new Matrix<float>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<double> IMatrixNumeric<double>.Subtract(Matrix<double> m1, Matrix<double> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<double> finalMatrix = new Matrix<double>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.Subtract(Matrix<decimal> m1, Matrix<decimal> m2)
		{
			if (!m1.IsSameDimension(m2))
			{
				throw new InvalidDimensionsException("The matrix dimensions must be the same.");
			}
			Matrix<decimal> finalMatrix = new Matrix<decimal>(m1.Columns, m1.Rows);
			for (int w = 0; w < m1.Columns; w++)
			{
				for (int h = 0; h < m1.Rows; h++)
				{
					finalMatrix[w, h] = m1[w, h] - m2[w, h];
				}
			}
			return finalMatrix;
		}
		#endregion

		#region Scalar Multiplication Functions
		Matrix<byte> IMatrixNumeric<byte>.ScalarMultiply(int scalar, Matrix<byte> m)
		{
			Matrix<byte> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (byte)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<byte> IMatrixNumeric<byte>.ScalarMultiply(double scalar, Matrix<byte> m)
		{
			Matrix<byte> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (byte)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.ScalarMultiply(int scalar, Matrix<ushort> m)
		{
			Matrix<ushort> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (ushort)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.ScalarMultiply(double scalar, Matrix<ushort> m)
		{
			Matrix<ushort> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (ushort)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<short> IMatrixNumeric<short>.ScalarMultiply(int scalar, Matrix<short> m)
		{
			Matrix<short> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (short)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<short> IMatrixNumeric<short>.ScalarMultiply(double scalar, Matrix<short> m)
		{
			Matrix<short> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (short)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<uint> IMatrixNumeric<uint>.ScalarMultiply(int scalar, Matrix<uint> m)
		{
			Matrix<uint> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (uint)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<uint> IMatrixNumeric<uint>.ScalarMultiply(double scalar, Matrix<uint> m)
		{
			Matrix<uint> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (uint)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<int> IMatrixNumeric<int>.ScalarMultiply(int scalar, Matrix<int> m)
		{
			Matrix<int> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<int> IMatrixNumeric<int>.ScalarMultiply(double scalar, Matrix<int> m)
		{
			Matrix<int> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (int)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.ScalarMultiply(int scalar, Matrix<ulong> m)
		{
			Matrix<ulong> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (ulong)((ulong)scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.ScalarMultiply(double scalar, Matrix<ulong> m)
		{
			Matrix<ulong> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (ulong)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<long> IMatrixNumeric<long>.ScalarMultiply(int scalar, Matrix<long> m)
		{
			Matrix<long> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (long)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<long> IMatrixNumeric<long>.ScalarMultiply(double scalar, Matrix<long> m)
		{
			Matrix<long> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (long)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<float> IMatrixNumeric<float>.ScalarMultiply(int scalar, Matrix<float> m)
		{
			Matrix<float> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (float)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<float> IMatrixNumeric<float>.ScalarMultiply(double scalar, Matrix<float> m)
		{
			Matrix<float> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (float)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<double> IMatrixNumeric<double>.ScalarMultiply(int scalar, Matrix<double> m)
		{
			Matrix<double> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (double)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<double> IMatrixNumeric<double>.ScalarMultiply(double scalar, Matrix<double> m)
		{
			Matrix<double> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = scalar * m[r, c];
				}
			}
			return m;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.ScalarMultiply(int scalar, Matrix<decimal> m)
		{
			Matrix<decimal> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (decimal)(scalar * m[r, c]);
				}
			}
			return m;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.ScalarMultiply(double scalar, Matrix<decimal> m)
		{
			Matrix<decimal> matrix = m;
			for (int r = 0; r < m.Rows; r++)
			{
				for (int c = 0; c < m.Columns; c++)
				{
					matrix[r, c] = (decimal)((decimal)scalar * m[r, c]);
				}
			}
			return m;
		}
		#endregion

		#region Multiplication Functions
		Matrix<byte> IMatrixNumeric<byte>.Multiply(Matrix<byte> m1, Matrix<byte> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<byte> finalMatrix = new Matrix<byte>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += (byte)(m1[row, r] * m2[c, col]);
					}
				}
			}
			return finalMatrix;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.Multiply(Matrix<ushort> m1, Matrix<ushort> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<ushort> finalMatrix = new Matrix<ushort>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += (ushort)(m1[row, r] * m2[c, col]);
					}
				}
			}
			return finalMatrix;
		}
		Matrix<short> IMatrixNumeric<short>.Multiply(Matrix<short> m1, Matrix<short> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<short> finalMatrix = new Matrix<short>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += (short)(m1[row, r] * m2[c, col]);
					}
				}
			}
			return finalMatrix;
		}
		Matrix<uint> IMatrixNumeric<uint>.Multiply(Matrix<uint> m1, Matrix<uint> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<uint> finalMatrix = new Matrix<uint>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		Matrix<int> IMatrixNumeric<int>.Multiply(Matrix<int> m1, Matrix<int> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<int> finalMatrix = new Matrix<int>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.Multiply(Matrix<ulong> m1, Matrix<ulong> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<ulong> finalMatrix = new Matrix<ulong>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		Matrix<long> IMatrixNumeric<long>.Multiply(Matrix<long> m1, Matrix<long> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<long> finalMatrix = new Matrix<long>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}		
		Matrix<float> IMatrixNumeric<float>.Multiply(Matrix<float> m1, Matrix<float> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<float> finalMatrix = new Matrix<float>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		Matrix<double> IMatrixNumeric<double>.Multiply(Matrix<double> m1, Matrix<double> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<double> finalMatrix = new Matrix<double>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.Multiply(Matrix<decimal> m1, Matrix<decimal> m2)
		{
			if (m1.Columns != m2.Rows)
			{
				throw new InvalidDimensionsException("The rows of m2 must be equal to the columns of m1 to multiply.");
			}
			Matrix<decimal> finalMatrix = new Matrix<decimal>(m1.Rows, m2.Columns);
			for (int row = 0; row < finalMatrix.Rows; row++)
			{
				for (int col = 0; col < finalMatrix.Columns; col++)
				{
					for (int r = 0, c = 0; r < m1.Columns && c < m2.Rows; r++, c++)
					{
						finalMatrix[row, col] += m1[row, r] * m2[c, col];
					}
				}
			}
			return finalMatrix;
		}
		#endregion

		#region Row Addition Functions
		Matrix<byte> IMatrixNumeric<byte>.RowAddition(Matrix<byte> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (byte)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.RowAddition(Matrix<ushort> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (ushort)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<short> IMatrixNumeric<short>.RowAddition(Matrix<short> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (short)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<uint> IMatrixNumeric<uint>.RowAddition(Matrix<uint> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (uint)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<int> IMatrixNumeric<int>.RowAddition(Matrix<int> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (int)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.RowAddition(Matrix<ulong> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (ulong)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<long> IMatrixNumeric<long>.RowAddition(Matrix<long> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (long)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<float> IMatrixNumeric<float>.RowAddition(Matrix<float> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (float)(multiple * m[additive, i]);
			}
			return m;
		}
		Matrix<double> IMatrixNumeric<double>.RowAddition(Matrix<double> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += multiple * m[additive, i];
			}
			return m;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.RowAddition(Matrix<decimal> m, int additive, int target, double multiple)
		{
			if (additive == target)
			{
				throw new InvalidOperationException("The Additive row cannot be the same as the target row.");
			}
			for (int i = 0; i < m.Columns; i++)
			{
				m[target, i] += (decimal)multiple * m[additive, i];
			}
			return m;
		}
		#endregion

		#region Row Multiplication Functions
		Matrix<byte> IMatrixNumeric<byte>.RowMultiplication(Matrix<byte> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (byte)(multiple);
				}
			}
			return m;
		}
		Matrix<ushort> IMatrixNumeric<ushort>.RowMultiplication(Matrix<ushort> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (ushort)(multiple);
				}
			}
			return m;
		}
		Matrix<short> IMatrixNumeric<short>.RowMultiplication(Matrix<short> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (short)(multiple);
				}
			}
			return m;
		}
		Matrix<uint> IMatrixNumeric<uint>.RowMultiplication(Matrix<uint> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (uint)(multiple);
				}
			}
			return m;
		}
		Matrix<int> IMatrixNumeric<int>.RowMultiplication(Matrix<int> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (int)(multiple);
				}
			}
			return m;
		}
		Matrix<ulong> IMatrixNumeric<ulong>.RowMultiplication(Matrix<ulong> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (ulong)(multiple);
				}
			}
			return m;
		}
		Matrix<long> IMatrixNumeric<long>.RowMultiplication(Matrix<long> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (long)(multiple);
				}
			}
			return m;
		}
		Matrix<float> IMatrixNumeric<float>.RowMultiplication(Matrix<float> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (float)(multiple);
				}
			}
			return m;
		}
		Matrix<double> IMatrixNumeric<double>.RowMultiplication(Matrix<double> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= multiple;
				}
			}
			return m;
		}
		Matrix<decimal> IMatrixNumeric<decimal>.RowMultiplication(Matrix<decimal> m, int target, double multiple)
		{
			if (multiple != 0)
			{
				for (int i = 0; i < m.Columns; i++)
				{
					m[target, i] *= (decimal)(multiple);
				}
			}
			return m;
		}
		#endregion

		#region Determinant Functions
		decimal IMatrixNumeric<byte>.GetDeterminant(Matrix<byte> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			int det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				int part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return (byte)det;
		}
		decimal IMatrixNumeric<ushort>.GetDeterminant(Matrix<ushort> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			short det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				short part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= (short)matrix[x, perm[x] - 1];
				}
				det += (short)(sign ? part : -part);
			}
			return (ushort)det;
		}
		decimal IMatrixNumeric<short>.GetDeterminant(Matrix<short> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			int det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				int part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return (short)det;
		}
		decimal IMatrixNumeric<uint>.GetDeterminant(Matrix<uint> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			int det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				int part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= (int)matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return (uint)det;
		}
		decimal IMatrixNumeric<int>.GetDeterminant(Matrix<int> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			int det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				int part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return det;
		}
		decimal IMatrixNumeric<ulong>.GetDeterminant(Matrix<ulong> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			long det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				long part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= (long)matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return (ulong)det;
		}
		decimal IMatrixNumeric<long>.GetDeterminant(Matrix<long> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			long det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				long part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return det;
		}
		decimal IMatrixNumeric<float>.GetDeterminant(Matrix<float> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			decimal det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				decimal part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= (decimal)matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return det;
		}
		decimal IMatrixNumeric<double>.GetDeterminant(Matrix<double> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			decimal det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				decimal part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= (decimal)matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return det;
		}
		decimal IMatrixNumeric<decimal>.GetDeterminant(Matrix<decimal> matrix)
		{
			if (matrix.Rows != matrix.Columns) throw new InvalidDimensionsException("Matrix must be a square matrix.");

			List<List<int>> perms = matrix.GetPermutations();

			decimal det = 0;

			foreach (List<int> perm in perms)
			{
				bool sign = matrix.GetPermutationSign(perm);
				decimal part = 1;
				for (int x = 0; x < matrix.Rows; x++)
				{
					part *= matrix[x, perm[x] - 1];
				}
				det += sign ? part : -part;
			}
			return det;
		}
		#endregion

		#region Trace Functions
		byte IMatrixNumeric<byte>.GetTrace(Matrix<byte> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			byte trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		ushort IMatrixNumeric<ushort>.GetTrace(Matrix<ushort> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			ushort trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		short IMatrixNumeric<short>.GetTrace(Matrix<short> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			short trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		uint IMatrixNumeric<uint>.GetTrace(Matrix<uint> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			uint trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		int IMatrixNumeric<int>.GetTrace(Matrix<int> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			int trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		ulong IMatrixNumeric<ulong>.GetTrace(Matrix<ulong> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			ulong trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		long IMatrixNumeric<long>.GetTrace(Matrix<long> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			long trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		float IMatrixNumeric<float>.GetTrace(Matrix<float> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			float trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		double IMatrixNumeric<double>.GetTrace(Matrix<double> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			double trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		decimal IMatrixNumeric<decimal>.GetTrace(Matrix<decimal> matrix)
		{
			if (matrix.Rows != matrix.Columns)
			{
				throw new InvalidDimensionsException("Matrix must be a square matrix.");
			}
			decimal trace = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				trace += matrix[i, i];
			}
			return trace;
		}
		#endregion
	}

	internal static class MMath
	{
		public static Matrix<T> Identity<X, T>(this X Mat, int size)
			where X : IMatrixNumeric<T>
		{
			return Mat.Identity(size);
		}

		public static Matrix<T> Add<X, T>(this X Mat, params Matrix<T>[] matrices)
			where X : IMatrixNumeric<T>
		{
			if (matrices.Length < 2) throw new InvalidOperationException("Invalid use of binary operation.");
			Matrix<T> finalMatrix = new Matrix<T>(matrices[0].Columns, matrices[0].Rows);
			foreach (Matrix<T> m in matrices)
			{
				finalMatrix = Mat.Add(finalMatrix, m);
			}
			return finalMatrix;
		}

		public static Matrix<T> Subtract<X, T>(this X Mat, params Matrix<T>[] matrices)
			where X : IMatrixNumeric<T>
		{
			if (matrices.Length < 2) throw new InvalidOperationException("Invalid use of binary operation.");
			Matrix<T> finalMatrix = new Matrix<T>(matrices[0].Columns, matrices[0].Rows);
			finalMatrix = Mat.Subtract(matrices[0], matrices[1]);
			for (int x = 2; x < matrices.Length; x++)
			{
				finalMatrix = Mat.Subtract(finalMatrix, matrices[x]);
			}
			return finalMatrix;
		}

		public static Matrix<T> ScalarMultiply<X, T>(this X Mat, int scalar, Matrix<T> m)
			where X : IMatrixNumeric<T>
		{
			return Mat.ScalarMultiply(scalar, m);
		}

		public static Matrix<T> ScalarMultiply<X, T>(this X Mat, double scalar, Matrix<T> m)
			where X : IMatrixNumeric<T>
		{
			return Mat.ScalarMultiply(scalar, m);
		}

		public static Matrix<T> Multiply<X, T>(this X Mat, params Matrix<T>[] matrices)
			where X : IMatrixNumeric<T>
		{
			if (matrices.Length < 2) throw new InvalidOperationException("Invalid use of binary operation.");
			Matrix<T> finalMatrix = Mat.Multiply(matrices[0], matrices[1]);
			for(int x = 2; x < matrices.Length; x++)
			{
				finalMatrix = Mat.Multiply(finalMatrix, matrices[x]);
			}
			return finalMatrix;
		}

		public static Matrix<T> RowAddition<X, T>(this X Mat, Matrix<T> matrix, int additive, int target, double multiple = 1.0)
			where X : IMatrixNumeric<T>
		{
			return Mat.RowAddition(matrix, additive, target, multiple);
		}

		public static Matrix<T> RowMultiplication<X, T>(this X Mat, Matrix<T> matrix, int target, double multiple)
			where X : IMatrixNumeric<T>
		{
			return Mat.RowMultiplication(matrix, target, multiple);
		}

		public static decimal GetDeterminant<X, T>(this X Mat, Matrix<T> matrix)
			where X : IMatrixNumeric<T>
		{
			return Mat.GetDeterminant(matrix);
		}

		public static T GetTrace<X, T>(this X Mat, Matrix<T> matrix)
			where X : IMatrixNumeric<T>
		{
			return Mat.GetTrace(matrix);
		}
	}
}
