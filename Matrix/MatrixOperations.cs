using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MatrixOperations
{
    public partial class MatrixOperationsForm : Form
    {
        public MatrixOperationsForm()
        {
            InitializeComponent();
        }
        private double[,] ReadMatrixFromDataGridView(DataGridView dataGridView)
        {
            int rows = dataGridView.RowCount;
            int cols = dataGridView.ColumnCount;
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string cellValue = dataGridView.Rows[i].Cells[j].Value?.ToString();

                    if (string.IsNullOrEmpty(cellValue))
                    {
                        MessageBox.Show($"Введіть значення для комірки ({i + 1}, {j + 1}).");
                        return null;
                    }

                    if (!double.TryParse(cellValue, out matrix[i, j]))
                    {
                        MessageBox.Show($"Введіть коректне число для комірки ({i + 1}, {j + 1}).");
                        return null;
                    }
                }
            }

            return matrix;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = ReadMatrixFromDataGridView(dgvMatrix);
            double[,] matrix2 = ReadMatrixFromDataGridView(dgvMatrix2);
            if (matrix1 != null && matrix2 != null)
            {
                int rows = matrix1.GetLength(0);
                int cols = matrix1.GetLength(1);

                if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
                {
                    MessageBox.Show("Матриці повинні мати однакові розміри для додавання.");
                    return;
                }

                double[,] result = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
                DisplayResult(result);
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = ReadMatrixFromDataGridView(dgvMatrix);
            double[,] matrix2 = ReadMatrixFromDataGridView(dgvMatrix2);
            if (matrix1 != null && matrix2 != null)
            {
                int rows = matrix1.GetLength(0);
                int cols = matrix1.GetLength(1);

                if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
                {
                    MessageBox.Show("Матриці повинні мати однакові розміри для віднімання.");
                    return;
                }

                double[,] result = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }
                DisplayResult(result);
            }
        }

        private void multiplyByScalarButton_Click(object sender, EventArgs e)
        {
            double scalar = (double)nudScalar.Value;
            double[,] matrix = null;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix);
                    }
                    break;
                case 1:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix2);
                    }
                    break;
            }
            if (matrix != null)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                double[,] result = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] * scalar;
                    }
                }
                DisplayResult(result);
            }
        }

        private void multiplyMatricesButton_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = ReadMatrixFromDataGridView(dgvMatrix);
            double[,] matrix2 = ReadMatrixFromDataGridView(dgvMatrix2);
            if (matrix1 != null && matrix2 != null) { 
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                MessageBox.Show("Кількість стовпців першої матриці не дорівнює кількості рядків другої матриці.");
                return;
            }
            double[,] result = new double[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            DisplayResult(result);
        }
        }

        private void determinantButton_Click(object sender, EventArgs e)
        {
            double[,] matrix = null;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix);
                    }
                    break;
                case 1:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix2);
                    }
                    break;
            }
            if (matrix != null)
            {
                double determinant = CalculateDeterminant(matrix);
                resultTextBox.Text = determinant.ToString();
            }
        }
        private double CalculateDeterminant(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                MessageBox.Show("Для обчислення визначника матриця має бути квадратною.");
                return 0;
            }

            if (rows == 1)
            {
                return matrix[0, 0];
            }

            double determinant = 0;

            for (int j = 0; j < cols; j++)
            {
                int sign = (j % 2 == 0) ? 1 : -1;
                double cofactor = sign * matrix[0, j] * CalculateDeterminant(GetSubmatrix(matrix, 0, j));
                determinant += cofactor;
            }

            return determinant;
        }

        private double[,] GetSubmatrix(double[,] matrix, int rowToRemove, int colToRemove)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[,] submatrix = new double[rows - 1, cols - 1];

            int rowIndex = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i == rowToRemove)
                    continue;

                int colIndex = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j == colToRemove)
                        continue;

                    submatrix[rowIndex, colIndex] = matrix[i, j];
                    colIndex++;
                }

                rowIndex++;
            }

            return submatrix;
        }

        private void inverseButton_Click(object sender, EventArgs e)
        {
            double[,] matrix = null;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix);
                    }
                    break;
                case 1:
                    {
                        matrix = ReadMatrixFromDataGridView(dgvMatrix2);
                    }
                    break;
            }
            if (matrix != null)
            {
                try
                {
                    double[,] inverseMatrix = CalculateInverseMatrix(matrix);
                    DisplayResult(inverseMatrix);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private double[,] CalculateInverseMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                MessageBox.Show("Матриця має бути квадратною, щоб обчислити її зворотну матрицю.");
                return null;
            }

            double determinant = CalculateDeterminant(matrix);

            if (determinant == 0)
            {
                MessageBox.Show("Матриця є сингулярною, і її оберненої не існує.");
                return null;
            }

            double[,] adjugateMatrix = CalculateAdjugateMatrix(matrix);

            double[,] inverseMatrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    inverseMatrix[i, j] = adjugateMatrix[i, j] / determinant;
                }
            }

            return inverseMatrix;
        }

        private void DisplayResult(double[,] result)
        {
            if (result != null)
            {
                int rows = result.GetLength(0);
                int cols = result.GetLength(1);
                dgvMatrixResult.Rows.Clear();
                dgvMatrixResult.Columns.Clear();
                dgvMatrixResult.ColumnCount = cols;
                for (int i = 0; i < rows; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int j = 0; j < cols; j++)
                    {
                        dgvMatrixResult.Columns[j].Width = 25;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = result[i, j] });
                    }
                    dgvMatrixResult.Rows.Add(row);
                }
            }
        }
        private double[,] CalculateAdjugateMatrix(double[,] matrix)
        {
            if (matrix != null)
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                double[,] adjugateMatrix = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        double cofactor = Math.Pow(-1, i + j) * CalculateDeterminant(GetSubmatrix(matrix, i, j));
                        adjugateMatrix[j, i] = cofactor;
                    }
                }

                return adjugateMatrix;
            }
            return null;
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (clickedButton.Name == "btnInitialize")
                {
                    if (nudRows.Value > 0 && nudColumns.Value > 0)
                    {
                        dgvMatrix.ColumnCount = (int)nudColumns.Value;
                        dgvMatrix.RowCount = (int)nudRows.Value;
                        for (int i = 0; i < dgvMatrix.Columns.Count; i++)
                        {
                            dgvMatrix.Columns[i].Width = 25;
                        }
                        comboBox.SelectedIndex = 0;
                    }
                }
                if (clickedButton.Name == "btnInitialize2")
                {
                    if (nudRows2.Value > 0 && nudColumns2.Value > 0)
                    {
                        dgvMatrix2.ColumnCount = (int)nudColumns2.Value;
                        dgvMatrix2.RowCount = (int)nudRows2.Value;
                        for (int i = 0; i < dgvMatrix2.Columns.Count; i++)
                        {
                            dgvMatrix2.Columns[i].Width = 25;
                            comboBox.SelectedIndex =1;
                        }
                    }
                }
            }
        }
    }
}
