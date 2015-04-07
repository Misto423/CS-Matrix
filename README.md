# CS-Matrix
A policy-based matrix library for C#.

A simple library that uses a policy pattern to use numeric matrices.

# Usage

Provides a Matrix class that can be defined generically with numberic types.

**Default Constructor:** ` var floatMatrix = new Matrix<float>(); `

**Constructor Specifing Dimensions (Rows x Columns):** ` var intMatrix = new Matrix<int>(3,5); `

**Constructor Specifing Dimensions and Initial Value:** ` var longMatrix = new Matrix<long>(3,4,8); ` - creates a 3x4 matrix with each cell having the value 8.

You can also create an NxN identity matrix with the following:
` var m = MatrixHelper.Identity<type>(N); `

The Matrix class has methods to `GetColumnVector` and `GetRowVector` as well as `Transpose` the matrix, get a `SubMatrix` and compare dimensions of matrices.

You can access cells of the matrix using standard bracket formation.

` floatMatrix[r,c] = 4; `

You can do basic matrix math (add, subtract, multiply, scalar multiply)

` var addedMatrix = m + floatMatrix; `

` var SMMatrix = 5 * floatMatrix; `

` var multMatrix = matrix1 * matrix2; `

Or if you want to perform an operation on many matrices

` var multMatrix = MatrixHelper.Multiply(new Matrix<int>[] {m1,m2,m3,m4}); ` is the same as m1 * m2 * m3 * m4;

The Matrix Helper class also provides methods to perform **Row Addition**, **Row Multiplication**, **Determinants**, and **Trace**.

Extension methods are available for the matrix class to cast into different numeric types.
