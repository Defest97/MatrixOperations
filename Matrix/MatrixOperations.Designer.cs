namespace MatrixOperations
{
    partial class MatrixOperationsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMatrix = new DataGridView();
            resultTextBox = new TextBox();
            addButton = new Button();
            subtractButton = new Button();
            multiplyByScalarButton = new Button();
            multiplyMatricesButton = new Button();
            determinantButton = new Button();
            inverseButton = new Button();
            nudRows = new NumericUpDown();
            nudColumns = new NumericUpDown();
            lbRows = new Label();
            lbColumns = new Label();
            btnInitialize = new Button();
            btnInitialize2 = new Button();
            label1 = new Label();
            label2 = new Label();
            nudColumns2 = new NumericUpDown();
            nudRows2 = new NumericUpDown();
            dgvMatrix2 = new DataGridView();
            dgvMatrixResult = new DataGridView();
            label3 = new Label();
            nudScalar = new NumericUpDown();
            comboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRows2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrixResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudScalar).BeginInit();
            SuspendLayout();
            // 
            // dgvMatrix
            // 
            dgvMatrix.AllowUserToAddRows = false;
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.ColumnHeadersVisible = false;
            dgvMatrix.Location = new Point(14, 47);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.RowHeadersVisible = false;
            dgvMatrix.RowTemplate.Height = 25;
            dgvMatrix.Size = new Size(498, 178);
            dgvMatrix.TabIndex = 0;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(656, 303);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(121, 23);
            resultTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(518, 107);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(518, 136);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(100, 23);
            subtractButton.TabIndex = 4;
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyByScalarButton
            // 
            multiplyByScalarButton.Location = new Point(518, 273);
            multiplyByScalarButton.Name = "multiplyByScalarButton";
            multiplyByScalarButton.Size = new Size(121, 23);
            multiplyByScalarButton.TabIndex = 5;
            multiplyByScalarButton.Text = "MultiplyByScalar";
            multiplyByScalarButton.UseVisualStyleBackColor = true;
            multiplyByScalarButton.Click += multiplyByScalarButton_Click;
            // 
            // multiplyMatricesButton
            // 
            multiplyMatricesButton.Location = new Point(518, 165);
            multiplyMatricesButton.Name = "multiplyMatricesButton";
            multiplyMatricesButton.Size = new Size(100, 23);
            multiplyMatricesButton.TabIndex = 6;
            multiplyMatricesButton.Text = "Multiply";
            multiplyMatricesButton.UseVisualStyleBackColor = true;
            multiplyMatricesButton.Click += multiplyMatricesButton_Click;
            // 
            // determinantButton
            // 
            determinantButton.Location = new Point(518, 302);
            determinantButton.Name = "determinantButton";
            determinantButton.Size = new Size(121, 23);
            determinantButton.TabIndex = 7;
            determinantButton.Text = "Determinant";
            determinantButton.UseVisualStyleBackColor = true;
            determinantButton.Click += determinantButton_Click;
            // 
            // inverseButton
            // 
            inverseButton.Location = new Point(518, 331);
            inverseButton.Name = "inverseButton";
            inverseButton.Size = new Size(121, 23);
            inverseButton.TabIndex = 8;
            inverseButton.Text = "Inverse";
            inverseButton.UseVisualStyleBackColor = true;
            inverseButton.Click += inverseButton_Click;
            // 
            // nudRows
            // 
            nudRows.Location = new Point(76, 18);
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(120, 23);
            nudRows.TabIndex = 9;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(283, 18);
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(120, 23);
            nudColumns.TabIndex = 10;
            // 
            // lbRows
            // 
            lbRows.AutoSize = true;
            lbRows.Location = new Point(12, 20);
            lbRows.Name = "lbRows";
            lbRows.Size = new Size(41, 15);
            lbRows.TabIndex = 11;
            lbRows.Text = "Rows: ";
            // 
            // lbColumns
            // 
            lbColumns.AutoSize = true;
            lbColumns.Location = new Point(219, 20);
            lbColumns.Name = "lbColumns";
            lbColumns.Size = new Size(58, 15);
            lbColumns.TabIndex = 12;
            lbColumns.Text = "Columns:";
            // 
            // btnInitialize
            // 
            btnInitialize.Location = new Point(423, 18);
            btnInitialize.Name = "btnInitialize";
            btnInitialize.Size = new Size(89, 23);
            btnInitialize.TabIndex = 13;
            btnInitialize.Text = "Initialization";
            btnInitialize.UseVisualStyleBackColor = true;
            btnInitialize.Click += btnInitialize_Click;
            // 
            // btnInitialize2
            // 
            btnInitialize2.Location = new Point(423, 244);
            btnInitialize2.Name = "btnInitialize2";
            btnInitialize2.Size = new Size(89, 23);
            btnInitialize2.TabIndex = 19;
            btnInitialize2.Text = "Initialization";
            btnInitialize2.UseVisualStyleBackColor = true;
            btnInitialize2.Click += btnInitialize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 246);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 18;
            label1.Text = "Columns:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 17;
            label2.Text = "Rows: ";
            // 
            // nudColumns2
            // 
            nudColumns2.Location = new Point(283, 244);
            nudColumns2.Name = "nudColumns2";
            nudColumns2.Size = new Size(120, 23);
            nudColumns2.TabIndex = 16;
            // 
            // nudRows2
            // 
            nudRows2.Location = new Point(76, 244);
            nudRows2.Name = "nudRows2";
            nudRows2.Size = new Size(120, 23);
            nudRows2.TabIndex = 15;
            // 
            // dgvMatrix2
            // 
            dgvMatrix2.AllowUserToAddRows = false;
            dgvMatrix2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix2.ColumnHeadersVisible = false;
            dgvMatrix2.Location = new Point(14, 273);
            dgvMatrix2.Name = "dgvMatrix2";
            dgvMatrix2.RowHeadersVisible = false;
            dgvMatrix2.RowTemplate.Height = 25;
            dgvMatrix2.Size = new Size(498, 178);
            dgvMatrix2.TabIndex = 14;
            // 
            // dgvMatrixResult
            // 
            dgvMatrixResult.AllowUserToAddRows = false;
            dgvMatrixResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrixResult.ColumnHeadersVisible = false;
            dgvMatrixResult.Location = new Point(656, 47);
            dgvMatrixResult.Name = "dgvMatrixResult";
            dgvMatrixResult.RowHeadersVisible = false;
            dgvMatrixResult.RowTemplate.Height = 25;
            dgvMatrixResult.Size = new Size(498, 178);
            dgvMatrixResult.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(887, 18);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 21;
            label3.Text = "Result";
            // 
            // nudScalar
            // 
            nudScalar.Hexadecimal = true;
            nudScalar.Location = new Point(656, 273);
            nudScalar.Name = "nudScalar";
            nudScalar.Size = new Size(120, 23);
            nudScalar.TabIndex = 22;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Matrix 1", "Matrix 2" });
            comboBox.Location = new Point(656, 246);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 277);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 24;
            label4.Text = "Scalar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 248);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 25;
            label5.Text = "Choose matrix: ";
            // 
            // MatrixOperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 486);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox);
            Controls.Add(nudScalar);
            Controls.Add(label3);
            Controls.Add(dgvMatrixResult);
            Controls.Add(btnInitialize2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nudColumns2);
            Controls.Add(nudRows2);
            Controls.Add(dgvMatrix2);
            Controls.Add(btnInitialize);
            Controls.Add(lbColumns);
            Controls.Add(lbRows);
            Controls.Add(nudColumns);
            Controls.Add(nudRows);
            Controls.Add(inverseButton);
            Controls.Add(determinantButton);
            Controls.Add(multiplyMatricesButton);
            Controls.Add(multiplyByScalarButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(resultTextBox);
            Controls.Add(dgvMatrix);
            Name = "MatrixOperationsForm";
            Text = "Matrix Operations";
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRows2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrixResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudScalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMatrix;
        private TextBox resultTextBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyByScalarButton;
        private Button multiplyMatricesButton;
        private Button determinantButton;
        private Button inverseButton;
        private NumericUpDown nudRows;
        private NumericUpDown nudColumns;
        private Label lbRows;
        private Label lbColumns;
        private Button btnInitialize;
        private Button btnInitialize2;
        private Label label1;
        private Label label2;
        private NumericUpDown nudColumns2;
        private NumericUpDown nudRows2;
        private DataGridView dgvMatrix2;
        private DataGridView dgvMatrixResult;
        private Label label3;
        private NumericUpDown nudScalar;
        private ComboBox comboBox;
        private Label label4;
        private Label label5;
    }
}